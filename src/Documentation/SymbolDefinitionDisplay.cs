// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Roslynator.CSharp;

namespace Roslynator.Documentation
{
    internal static class SymbolDefinitionDisplay
    {
        public static ImmutableArray<SymbolDisplayPart> GetDisplayParts(
            ISymbol symbol,
            SymbolDisplayFormat format,
            SymbolDisplayTypeDeclarationOptions typeDeclarationOptions = SymbolDisplayTypeDeclarationOptions.None,
            bool omitContainingNamespace = false,
            bool addAttributes = false,
            bool addParameterAttributes = false,
            bool addAccessorAttributes = false,
            Func<INamedTypeSymbol, bool> shouldDisplayAttribute = null,
            bool formatAttributes = false,
            bool formatBaseList = false,
            bool formatConstraints = false,
            bool formatParameters = false,
            bool includeAttributeArguments = false,
            bool omitIEnumerable = false,
            bool useDefaultLiteral = true)
        {
            ImmutableArray<SymbolDisplayPart> parts;

            if (symbol is INamedTypeSymbol typeSymbol)
            {
                parts = typeSymbol.ToDisplayParts(format, typeDeclarationOptions);
            }
            else
            {
                parts = symbol.ToDisplayParts(format);
                typeSymbol = null;
            }

            ImmutableArray<AttributeData> attributes = ImmutableArray<AttributeData>.Empty;
            bool hasAttributes = false;

            if (addAttributes)
            {
                attributes = symbol.GetAttributes();

                hasAttributes = (shouldDisplayAttribute != null)
                    ? attributes.Any(f => shouldDisplayAttribute(f.AttributeClass))
                    : attributes.Any();
            }

            int baseListCount = 0;
            INamedTypeSymbol baseType = null;
            ImmutableArray<INamedTypeSymbol> interfaces = default;

            if (typeSymbol != null)
            {
                if (typeSymbol.TypeKind.Is(TypeKind.Class, TypeKind.Interface))
                {
                    baseType = typeSymbol.BaseType;

                    if (baseType?.SpecialType == SpecialType.System_Object)
                        baseType = null;
                }

                interfaces = typeSymbol.Interfaces;

                if (omitIEnumerable
                    && interfaces.Any(f => f.OriginalDefinition.SpecialType == SpecialType.System_Collections_Generic_IEnumerable_T))
                {
                    interfaces = interfaces.RemoveAll(f => f.SpecialType == SpecialType.System_Collections_IEnumerable);
                }

                baseListCount = interfaces.Length;

                if (baseType != null)
                    baseListCount++;
            }

            int constraintCount = 0;
            int whereIndex = -1;

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].IsKeyword("where"))
                {
                    if (whereIndex == -1)
                        whereIndex = i;

                    constraintCount++;
                }
            }

            if (!hasAttributes
                && baseListCount == 0
                && constraintCount == 0
                && (!formatParameters || symbol.GetParameters().Length <= 1)
                && (!useDefaultLiteral || symbol.GetParameters().All(f => !f.HasExplicitDefaultValue))
                && (!addAccessorAttributes || !symbol.IsKind(SymbolKind.Property, SymbolKind.Event))
                && (!addParameterAttributes || !symbol.GetParameters().Any()))
            {
                return parts;
            }

            ImmutableArray<SymbolDisplayPart>.Builder builder = ImmutableArray.CreateBuilder<SymbolDisplayPart>(parts.Length);

            AddAttributes(builder, attributes, shouldDisplayAttribute, omitContainingNamespace, formatAttributes: formatAttributes, includeAttributeArguments: includeAttributeArguments);

            if (baseListCount > 0)
            {
                if (whereIndex != -1)
                {
                    builder.AddRange(parts, whereIndex);
                }
                else
                {
                    builder.AddRange(parts);
                    builder.AddSpace();
                }

                builder.AddPunctuation(":");
                builder.AddSpace();

                if (baseType != null)
                {
                    builder.AddDisplayParts(baseType, omitContainingNamespace);

                    if (interfaces.Any())
                    {
                        builder.AddPunctuation(",");

                        if (formatBaseList)
                        {
                            builder.AddLineBreak();
                            builder.AddIndentation();
                        }
                        else
                        {
                            builder.AddSpace();
                        }
                    }
                }

                interfaces = interfaces.Sort((x, y) =>
                {
                    if (omitContainingNamespace)
                    {
                        return NamedTypeSymbolDefinitionComparer.Instance.Compare(x, y);
                    }
                    else
                    {
                        return SymbolDefinitionComparer.SystemNamespaceFirstInstance.Compare(x, y);
                    }
                });

                ImmutableArray<INamedTypeSymbol>.Enumerator en = interfaces.GetEnumerator();

                if (en.MoveNext())
                {
                    while (true)
                    {
                        builder.AddDisplayParts(en.Current, omitContainingNamespace);

                        if (en.MoveNext())
                        {
                            builder.AddPunctuation(",");

                            if (formatBaseList)
                            {
                                builder.AddLineBreak();
                                builder.AddIndentation();
                            }
                            else
                            {
                                builder.AddSpace();
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (whereIndex != -1)
                {
                    if (!formatConstraints
                        || (baseListCount == 1 && constraintCount == 1))
                    {
                        builder.AddSpace();
                    }
                }
            }
            else if (whereIndex != -1)
            {
                builder.AddRange(parts, whereIndex);
            }
            else
            {
                builder.AddRange(parts);
            }

            if (whereIndex != -1)
            {
                for (int i = whereIndex; i < parts.Length; i++)
                {
                    if (parts[i].IsKeyword("where"))
                    {
                        if (formatConstraints
                            && (baseListCount > 1 || constraintCount > 1))
                        {
                            builder.AddLineBreak();
                            builder.AddIndentation();
                        }

                        builder.Add(parts[i]);
                    }
                    else if (parts[i].IsTypeName()
                        && parts[i].Symbol is INamedTypeSymbol namedTypeSymbol)
                    {
                        builder.AddDisplayParts(namedTypeSymbol, omitContainingNamespace);
                    }
                    else
                    {
                        builder.Add(parts[i]);
                    }
                }
            }

            if (addAccessorAttributes)
            {
                if (symbol.Kind == SymbolKind.Property)
                {
                    var propertySymbol = (IPropertySymbol)symbol;

                    AddPropertyAccessorAttributes(propertySymbol.GetMethod);
                    AddPropertyAccessorAttributes(propertySymbol.SetMethod);
                }
                else if (symbol.Kind == SymbolKind.Event)
                {
                    AddEventAccessorAttributes(
                        builder,
                        (IEventSymbol)symbol,
                        predicate: shouldDisplayAttribute,
                        omitContainingNamespace: omitContainingNamespace,
                        formatAttributes: false,
                        includeAttributeArguments: includeAttributeArguments);
                }
            }

            ImmutableArray<IParameterSymbol> parameters = symbol.GetParameters();

            if (addParameterAttributes
                && parameters.Any())
            {
                AddParameterAttributes(
                    builder,
                    symbol,
                    parameters,
                    predicate: shouldDisplayAttribute,
                    omitContainingNamespace: omitContainingNamespace,
                    formatAttributes: false,
                    includeAttributeArguments: includeAttributeArguments);
            }

            if (formatParameters
                && parameters.Length > 1)
            {
                FormatParameters(symbol, builder, DefinitionListFormat.Default.IndentChars);
            }

            if (useDefaultLiteral
                && parameters.Any(f => f.HasExplicitDefaultValue))
            {
                return ReplaceDefaultExpressionWithDefaultLiteral(symbol, builder.ToImmutableArray());
            }

            return builder.ToImmutableArray();

            void AddPropertyAccessorAttributes(IMethodSymbol accessorMethod)
            {
                if (accessorMethod == null)
                    return;

                AddAccessorAttributes(
                    builder,
                    accessorMethod,
                    predicate: shouldDisplayAttribute,
                    omitContainingNamespace: omitContainingNamespace,
                    formatAttributes: false,
                    includeAttributeArguments: includeAttributeArguments);
            }
        }

        public static ImmutableArray<SymbolDisplayPart> GetAttributesParts(
            ISymbol symbol,
            Func<INamedTypeSymbol, bool> predicate,
            bool omitContainingNamespace = false,
            bool formatAttributes = true,
            bool includeAttributeArguments = false,
            bool addNewLine = true)
        {
            ImmutableArray<AttributeData> attributes = symbol.GetAttributes();

            if (!attributes.Any())
                return ImmutableArray<SymbolDisplayPart>.Empty;

            ImmutableArray<SymbolDisplayPart>.Builder parts = ImmutableArray.CreateBuilder<SymbolDisplayPart>();

            AddAttributes(
                parts: parts,
                attributes: attributes,
                predicate: predicate,
                omitContainingNamespace: omitContainingNamespace,
                formatAttributes: formatAttributes,
                includeAttributeArguments: includeAttributeArguments,
                addNewLine: addNewLine);

            return parts.ToImmutableArray();
        }

        private static void AddAttributes(
            ImmutableArray<SymbolDisplayPart>.Builder parts,
            ImmutableArray<AttributeData> attributes,
            Func<INamedTypeSymbol, bool> predicate = null,
            bool omitContainingNamespace = false,
            bool formatAttributes = true,
            bool includeAttributeArguments = false,
            bool addNewLine = true)
        {
            IEnumerable<AttributeData> sortedAttributes = attributes.Where(f => predicate(f.AttributeClass));

            if (omitContainingNamespace)
            {
                sortedAttributes = attributes.OrderBy(f => f.AttributeClass, NamedTypeSymbolDefinitionComparer.Instance);
            }
            else
            {
                sortedAttributes = attributes.OrderBy(f => f.AttributeClass, SymbolDefinitionComparer.SystemNamespaceFirstInstance);
            }

            using (IEnumerator<AttributeData> en = sortedAttributes.GetEnumerator())
            {
                if (en.MoveNext())
                {
                    parts.AddPunctuation("[");

                    while (true)
                    {
                        AddAttribute(parts, en.Current, omitContainingNamespace, includeAttributeArguments);

                        if (en.MoveNext())
                        {
                            if (formatAttributes)
                            {
                                parts.AddPunctuation("]");

                                if (addNewLine)
                                {
                                    parts.AddLineBreak();
                                }
                                else
                                {
                                    parts.AddSpace();
                                }

                                parts.AddPunctuation("[");
                            }
                            else
                            {
                                parts.AddPunctuation(",");
                                parts.AddSpace();
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    parts.AddPunctuation("]");

                    if (addNewLine)
                        parts.AddLineBreak();
                }
            }
        }

        internal static ImmutableArray<SymbolDisplayPart> GetAttributeParts(
            AttributeData attribute,
            bool omitContainingNamespace = false,
            bool includeAttributeArguments = false)
        {
            ImmutableArray<SymbolDisplayPart>.Builder parts = ImmutableArray.CreateBuilder<SymbolDisplayPart>();

            AddAttribute(parts, attribute, omitContainingNamespace, includeAttributeArguments);

            return parts.ToImmutableArray();
        }

        private static void AddAttribute(
            ImmutableArray<SymbolDisplayPart>.Builder parts,
            AttributeData attribute,
            bool omitContainingNamespace,
            bool includeAttributeArguments)
        {
            parts.AddDisplayParts(attribute.AttributeClass, omitContainingNamespace, removeAttributeSuffix: true);

            if (includeAttributeArguments)
                AddAttributeArguments();

            void AddAttributeArguments()
            {
                bool hasConstructorArgument = false;
                bool hasNamedArgument = false;

                AppendConstructorArguments();
                AppendNamedArguments();

                if (hasConstructorArgument || hasNamedArgument)
                {
                    parts.AddPunctuation(")");
                }

                void AppendConstructorArguments()
                {
                    ImmutableArray<TypedConstant>.Enumerator en = attribute.ConstructorArguments.GetEnumerator();

                    if (en.MoveNext())
                    {
                        hasConstructorArgument = true;
                        parts.AddPunctuation("(");

                        while (true)
                        {
                            AddConstantValue(en.Current);

                            if (en.MoveNext())
                            {
                                parts.AddPunctuation(",");
                                parts.AddSpace();
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                void AppendNamedArguments()
                {
                    ImmutableArray<KeyValuePair<string, TypedConstant>>.Enumerator en = attribute.NamedArguments.GetEnumerator();

                    if (en.MoveNext())
                    {
                        hasNamedArgument = true;

                        if (hasConstructorArgument)
                        {
                            parts.AddPunctuation(",");
                            parts.AddSpace();
                        }
                        else
                        {
                            parts.AddPunctuation("(");
                        }

                        while (true)
                        {
                            parts.Add(new SymbolDisplayPart(SymbolDisplayPartKind.PropertyName, null, en.Current.Key));
                            parts.AddSpace();
                            parts.AddPunctuation("=");
                            parts.AddSpace();
                            AddConstantValue(en.Current.Value);

                            if (en.MoveNext())
                            {
                                parts.AddPunctuation(",");
                                parts.AddSpace();
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            void AddConstantValue(TypedConstant typedConstant)
            {
                switch (typedConstant.Kind)
                {
                    case TypedConstantKind.Primitive:
                        {
                            parts.Add(new SymbolDisplayPart(
                                GetSymbolDisplayPart(typedConstant.Type.SpecialType),
                                null,
                                SymbolDisplay.FormatPrimitive(typedConstant.Value, quoteStrings: true, useHexadecimalNumbers: false)));

                            break;
                        }
                    case TypedConstantKind.Enum:
                        {
                            OneOrMany<EnumFieldSymbolInfo> oneOrMany = EnumUtility.GetConstituentFields(typedConstant.Value, (INamedTypeSymbol)typedConstant.Type);

                            OneOrMany<EnumFieldSymbolInfo>.Enumerator en = oneOrMany.GetEnumerator();

                            if (en.MoveNext())
                            {
                                while (true)
                                {
                                    AddDisplayParts(parts, en.Current.Symbol, omitContainingNamespace);

                                    if (en.MoveNext())
                                    {
                                        parts.AddSpace();
                                        parts.AddPunctuation("|");
                                        parts.AddSpace();
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                parts.AddPunctuation("(");
                                AddDisplayParts(parts, (INamedTypeSymbol)typedConstant.Type, omitContainingNamespace);
                                parts.AddPunctuation(")");
                                parts.Add(new SymbolDisplayPart(SymbolDisplayPartKind.NumericLiteral, null, typedConstant.Value.ToString()));
                            }

                            break;
                        }
                    case TypedConstantKind.Type:
                        {
                            parts.AddKeyword("typeof");
                            parts.AddPunctuation("(");
                            AddDisplayParts(parts, (ISymbol)typedConstant.Value, omitContainingNamespace);
                            parts.AddPunctuation(")");

                            break;
                        }
                    case TypedConstantKind.Array:
                        {
                            var arrayType = (IArrayTypeSymbol)typedConstant.Type;

                            parts.AddKeyword("new");
                            parts.AddSpace();
                            AddDisplayParts(parts, arrayType.ElementType, omitContainingNamespace);

                            parts.AddPunctuation("[");
                            parts.AddPunctuation("]");
                            parts.AddSpace();
                            parts.AddPunctuation("{");
                            parts.AddSpace();

                            ImmutableArray<TypedConstant>.Enumerator en = typedConstant.Values.GetEnumerator();

                            if (en.MoveNext())
                            {
                                while (true)
                                {
                                    AddConstantValue(en.Current);

                                    if (en.MoveNext())
                                    {
                                        parts.AddPunctuation(",");
                                        parts.AddSpace();
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }

                            parts.AddSpace();
                            parts.AddPunctuation("}");
                            break;
                        }
                    default:
                        {
                            throw new InvalidOperationException();
                        }
                }

                SymbolDisplayPartKind GetSymbolDisplayPart(SpecialType specialType)
                {
                    switch (specialType)
                    {
                        case SpecialType.System_Boolean:
                            return SymbolDisplayPartKind.Keyword;
                        case SpecialType.System_SByte:
                        case SpecialType.System_Byte:
                        case SpecialType.System_Int16:
                        case SpecialType.System_UInt16:
                        case SpecialType.System_Int32:
                        case SpecialType.System_UInt32:
                        case SpecialType.System_Int64:
                        case SpecialType.System_UInt64:
                        case SpecialType.System_Single:
                        case SpecialType.System_Double:
                            return SymbolDisplayPartKind.NumericLiteral;
                        case SpecialType.System_Char:
                        case SpecialType.System_String:
                            return SymbolDisplayPartKind.StringLiteral;
                        default:
                            throw new InvalidOperationException();
                    }
                }
            }
        }

        private static void AddParameterAttributes(
            ImmutableArray<SymbolDisplayPart>.Builder parts,
            ISymbol symbol,
            ImmutableArray<IParameterSymbol> parameters,
            Func<INamedTypeSymbol, bool> predicate = null,
            bool omitContainingNamespace = false,
            bool formatAttributes = true,
            bool includeAttributeArguments = false)
        {
            int i = FindParameterListStart(symbol, parts);

            if (i == -1)
                return;

            i++;

            int parameterIndex = 0;

            AddParameterAttributes();

            int parenthesesDepth = 1;
            int bracesDepth = 0;
            int bracketsDepth = 0;
            int angleBracketsDepth = 0;

            while (i < parts.Count)
            {
                SymbolDisplayPart part = parts[i];

                if (part.Kind == SymbolDisplayPartKind.Punctuation)
                {
                    switch (part.ToString())
                    {
                        case ",":
                            {
                                if (((angleBracketsDepth == 0 && parenthesesDepth == 1 && bracesDepth == 0 && bracketsDepth == 0)
                                        || (angleBracketsDepth == 0 && parenthesesDepth == 0 && bracesDepth == 0 && bracketsDepth == 1))
                                    && i < parts.Count - 1)
                                {
                                    SymbolDisplayPart nextPart = parts[i + 1];

                                    if (nextPart.Kind == SymbolDisplayPartKind.Space)
                                    {
                                        i += 2;
                                        parameterIndex++;

                                        AddParameterAttributes();
                                        continue;
                                    }
                                }

                                break;
                            }
                        case "(":
                            {
                                parenthesesDepth++;
                                break;
                            }
                        case ")":
                            {
                                Debug.Assert(parenthesesDepth >= 0);
                                parenthesesDepth--;

                                if (parenthesesDepth == 0
                                    && symbol.IsKind(SymbolKind.Method, SymbolKind.NamedType))
                                {
                                    return;
                                }

                                break;
                            }
                        case "[":
                            {
                                bracketsDepth++;
                                break;
                            }
                        case "]":
                            {
                                Debug.Assert(bracketsDepth >= 0);
                                bracketsDepth--;

                                if (bracketsDepth == 0
                                    && symbol.Kind == SymbolKind.Property)
                                {
                                    return;
                                }

                                break;
                            }
                        case "{":
                            {
                                bracesDepth++;
                                break;
                            }
                        case "}":
                            {
                                Debug.Assert(bracesDepth >= 0);
                                bracesDepth--;
                                break;
                            }
                        case "<":
                            {
                                angleBracketsDepth++;
                                break;
                            }
                        case ">":
                            {
                                Debug.Assert(angleBracketsDepth >= 0);
                                angleBracketsDepth--;
                                break;
                            }
                    }
                }

                i++;
            }

            void AddParameterAttributes()
            {
                IParameterSymbol parameter = parameters[parameterIndex];

                ImmutableArray<SymbolDisplayPart> attributeParts = GetAttributesParts(
                    parameter,
                    predicate: predicate,
                    omitContainingNamespace: omitContainingNamespace,
                    formatAttributes: formatAttributes,
                    includeAttributeArguments: includeAttributeArguments,
                    addNewLine: false);

                if (attributeParts.Any())
                {
                    parts.Insert(i, SymbolDisplayPartFactory.Space());
                    parts.InsertRange(i, attributeParts);
                    i += attributeParts.Length + 1;
                }
            }
        }

        private static void AddAccessorAttributes(
            ImmutableArray<SymbolDisplayPart>.Builder parts,
            IMethodSymbol methodSymbol,
            Func<INamedTypeSymbol, bool> predicate,
            bool omitContainingNamespace,
            bool formatAttributes,
            bool includeAttributeArguments)
        {
            ImmutableArray<SymbolDisplayPart> attributeParts = GetAttributesParts(
                methodSymbol,
                predicate: predicate,
                omitContainingNamespace: omitContainingNamespace,
                formatAttributes: formatAttributes,
                includeAttributeArguments: includeAttributeArguments,
                addNewLine: false);

            if (attributeParts.Any())
            {
                string keyword = GetKeyword();

                SymbolDisplayPart part = parts.FirstOrDefault(f => f.IsKeyword(keyword));

                Debug.Assert(part.Kind == SymbolDisplayPartKind.Keyword);

                if (part.Kind == SymbolDisplayPartKind.Keyword)
                {
                    int index = parts.IndexOf(part);

                    parts.Insert(index, SymbolDisplayPartFactory.Space());
                    parts.InsertRange(index, attributeParts);
                }
            }

            string GetKeyword()
            {
                switch (methodSymbol.MethodKind)
                {
                    case MethodKind.EventAdd:
                        return "add";
                    case MethodKind.EventRemove:
                        return "remove";
                    case MethodKind.PropertyGet:
                        return "get";
                    case MethodKind.PropertySet:
                        return "set";
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        private static void AddEventAccessorAttributes(
            ImmutableArray<SymbolDisplayPart>.Builder parts,
            IEventSymbol eventSymbol,
            Func<INamedTypeSymbol, bool> predicate,
            bool omitContainingNamespace,
            bool formatAttributes,
            bool includeAttributeArguments)
        {
            bool addMethodHasAttributes = HasAttributes(eventSymbol.AddMethod);
            bool removeMethodHasAttributes = HasAttributes(eventSymbol.RemoveMethod);

            if (addMethodHasAttributes
                || removeMethodHasAttributes)
            {
                parts.AddSpace();
                parts.AddPunctuation("{");
                parts.AddSpace();

                if (addMethodHasAttributes)
                    AddAttributes(eventSymbol.AddMethod);

                parts.AddKeyword("add");
                parts.AddPunctuation(";");
                parts.AddSpace();

                if (removeMethodHasAttributes)
                    AddAttributes(eventSymbol.RemoveMethod);

                parts.AddKeyword("remove");
                parts.AddPunctuation(";");
                parts.AddSpace();
                parts.AddPunctuation("}");
            }

            bool HasAttributes(IMethodSymbol accessorSymbol)
            {
                if (accessorSymbol != null)
                {
                    ImmutableArray<AttributeData> attributes = accessorSymbol.GetAttributes();
                    addMethodHasAttributes = attributes.Any();

                    if (predicate != null)
                    {
                        addMethodHasAttributes = attributes.Any(f => predicate(f.AttributeClass));
                    }
                    else
                    {
                        return attributes.Any();
                    }
                }

                return false;
            }

            void AddAttributes(IMethodSymbol accessorMethod)
            {
                ImmutableArray<SymbolDisplayPart> attributeParts = GetAttributesParts(
                    accessorMethod,
                    predicate: predicate,
                    omitContainingNamespace: omitContainingNamespace,
                    formatAttributes: formatAttributes,
                    includeAttributeArguments: includeAttributeArguments,
                    addNewLine: false);

                parts.AddRange(attributeParts);
                parts.AddSpace();
            }
        }

        private static void FormatParameters(
            ISymbol symbol,
            ImmutableArray<SymbolDisplayPart>.Builder parts,
            string indentChars)
        {
            int parenthesesDepth = 0;
            int bracesDepth = 0;
            int bracketsDepth = 0;
            int angleBracketsDepth = 0;

            int i = 0;

            int index = FindParameterListStart(symbol, parts);

            Debug.Assert(index != -1);

            if (index == -1)
                return;

            parts.Insert(index + 1, SymbolDisplayPartFactory.Indentation(indentChars));
            parts.Insert(index + 1, SymbolDisplayPartFactory.LineBreak());

            i++;

            while (i < parts.Count)
            {
                SymbolDisplayPart part = parts[i];

                if (part.Kind == SymbolDisplayPartKind.Punctuation)
                {
                    switch (part.ToString())
                    {
                        case ",":
                            {
                                if (((angleBracketsDepth == 0 && parenthesesDepth == 1 && bracesDepth == 0 && bracketsDepth == 0)
                                        || (angleBracketsDepth == 0 && parenthesesDepth == 0 && bracesDepth == 0 && bracketsDepth == 1))
                                    && i < parts.Count - 1)
                                {
                                    SymbolDisplayPart nextPart = parts[i + 1];

                                    if (nextPart.Kind == SymbolDisplayPartKind.Space)
                                    {
                                        parts[i + 1] = SymbolDisplayPartFactory.LineBreak();
                                        parts.Insert(i + 2, SymbolDisplayPartFactory.Indentation(indentChars));
                                    }
                                }

                                break;
                            }
                        case "(":
                            {
                                parenthesesDepth++;
                                break;
                            }
                        case ")":
                            {
                                Debug.Assert(parenthesesDepth >= 0);
                                parenthesesDepth--;

                                if (parenthesesDepth == 0
                                    && symbol.IsKind(SymbolKind.Method, SymbolKind.NamedType))
                                {
                                    return;
                                }

                                break;
                            }
                        case "[":
                            {
                                bracketsDepth++;
                                break;
                            }
                        case "]":
                            {
                                Debug.Assert(bracketsDepth >= 0);
                                bracketsDepth--;

                                if (bracketsDepth == 0
                                    && symbol.Kind == SymbolKind.Property)
                                {
                                    return;
                                }

                                break;
                            }
                        case "{":
                            {
                                bracesDepth++;
                                break;
                            }
                        case "}":
                            {
                                Debug.Assert(bracesDepth >= 0);
                                bracesDepth--;
                                break;
                            }
                        case "<":
                            {
                                angleBracketsDepth++;
                                break;
                            }
                        case ">":
                            {
                                Debug.Assert(angleBracketsDepth >= 0);
                                angleBracketsDepth--;
                                break;
                            }
                    }
                }

                i++;
            }
        }

        private static int FindParameterListStart(
            ISymbol symbol,
            IList<SymbolDisplayPart> parts)
        {
            int parenthesesDepth = 0;
            int bracesDepth = 0;
            int bracketsDepth = 0;
            int angleBracketsDepth = 0;

            int i = 0;

            while (i < parts.Count)
            {
                SymbolDisplayPart part = parts[i];

                if (part.Kind == SymbolDisplayPartKind.Punctuation)
                {
                    switch (part.ToString())
                    {
                        case "(":
                            {
                                parenthesesDepth++;

                                if (symbol.IsKind(SymbolKind.Method, SymbolKind.NamedType)
                                    && parenthesesDepth == 1
                                    && bracesDepth == 0
                                    && bracketsDepth == 0
                                    && angleBracketsDepth == 0)
                                {
                                    return i;
                                }

                                break;
                            }
                        case ")":
                            {
                                Debug.Assert(parenthesesDepth >= 0);
                                parenthesesDepth--;
                                break;
                            }
                        case "[":
                            {
                                bracketsDepth++;

                                if (symbol.Kind == SymbolKind.Property
                                    && parenthesesDepth == 0
                                    && bracesDepth == 0
                                    && bracketsDepth == 1
                                    && angleBracketsDepth == 0)
                                {
                                    return i;
                                }

                                break;
                            }
                        case "]":
                            {
                                Debug.Assert(bracketsDepth >= 0);
                                bracketsDepth--;
                                break;
                            }
                        case "{":
                            {
                                bracesDepth++;
                                break;
                            }
                        case "}":
                            {
                                Debug.Assert(bracesDepth >= 0);
                                bracesDepth--;
                                break;
                            }
                        case "<":
                            {
                                angleBracketsDepth++;
                                break;
                            }
                        case ">":
                            {
                                Debug.Assert(angleBracketsDepth >= 0);
                                angleBracketsDepth--;
                                break;
                            }
                    }
                }

                i++;
            }

            return -1;
        }

        private static ImmutableArray<SymbolDisplayPart> ReplaceDefaultExpressionWithDefaultLiteral(
            ISymbol symbol,
            ImmutableArray<SymbolDisplayPart> parts)
        {
            int parenthesesDepth = 0;
            int bracketsDepth = 0;

            int i = FindParameterListStart(symbol, parts);

            Debug.Assert(i >= 0);

            if (i == -1)
                return parts;

            int prevIndex = 0;

            ImmutableArray<SymbolDisplayPart>.Builder builder = null;

            while (i < parts.Length)
            {
                SymbolDisplayPart part = parts[i];

                if (part.Kind == SymbolDisplayPartKind.Punctuation)
                {
                    switch (part.ToString())
                    {
                        case "(":
                            {
                                parenthesesDepth++;
                                break;
                            }
                        case ")":
                            {
                                Debug.Assert(parenthesesDepth >= 0);
                                parenthesesDepth--;

                                if (parenthesesDepth == 0
                                    && bracketsDepth == 0)
                                {
                                    return GetResult();
                                }

                                break;
                            }
                        case "[":
                            {
                                bracketsDepth++;
                                break;
                            }
                        case "]":
                            {
                                Debug.Assert(bracketsDepth >= 0);
                                bracketsDepth--;

                                if (bracketsDepth == 0
                                    && parenthesesDepth == 0)
                                {
                                    return GetResult();
                                }

                                break;
                            }
                        case "=":
                            {
                                ReplaceDefaultExpressionWithDefaultLiteral();
                                break;
                            }
                    }
                }

                i++;
            }

            return GetResult();

            void ReplaceDefaultExpressionWithDefaultLiteral()
            {
                int j = i + 1;
                if (j >= parts.Length
                    || !parts[j].IsSpace())
                {
                    return;
                }

                j++;
                if (j >= parts.Length
                    || !parts[j].IsKeyword("default"))
                {
                    return;
                }

                j++;
                if (j >= parts.Length
                    || !parts[j].IsPunctuation("("))
                {
                    return;
                }

                int k = FindClosingParentheses(j + 1);

                if (k == -1)
                    return;

                if (builder == null)
                    builder = ImmutableArray.CreateBuilder<SymbolDisplayPart>(parts.Length);

                for (int l = prevIndex; l < j; l++)
                    builder.Add(parts[l]);

                i = k;

                prevIndex = i + 1;
            }

            int FindClosingParentheses(int startIndex)
            {
                int depth = 1;

                int j = startIndex;

                while (j < parts.Length)
                {
                    SymbolDisplayPart part = parts[j];

                    if (part.IsPunctuation())
                    {
                        string text = part.ToString();

                        if (text == "(")
                        {
                            depth++;
                        }
                        else if (text == ")")
                        {
                            Debug.Assert(parenthesesDepth > 0);

                            depth--;

                            if (depth == 0)
                                return j;
                        }
                    }

                    j++;
                }

                return -1;
            }

            ImmutableArray<SymbolDisplayPart> GetResult()
            {
                if (builder == null)
                    return parts;

                for (int j = prevIndex; j < parts.Length; j++)
                {
                    builder.Add(parts[j]);
                }

                return builder.ToImmutableArray();
            }
        }

        private static void AddDisplayParts(
            this ImmutableArray<SymbolDisplayPart>.Builder parts,
            ISymbol symbol,
            bool omitContainingNamespace = false,
            bool removeAttributeSuffix = false)
        {
            SymbolDisplayFormat format = (omitContainingNamespace)
                ? SymbolDefinitionDisplayFormats.TypeNameAndContainingTypes
                : SymbolDefinitionDisplayFormats.TypeNameAndContainingTypesAndNamespaces;

            parts.AddRange(symbol.ToDisplayParts(format));

            if (!(symbol is INamedTypeSymbol typeSymbol))
                return;

            if (removeAttributeSuffix)
            {
                SymbolDisplayPart last = parts.Last();

                if (last.Kind == SymbolDisplayPartKind.ClassName)
                {
                    const string attributeSuffix = "Attribute";

                    string text = last.ToString();
                    if (text.EndsWith(attributeSuffix, StringComparison.Ordinal))
                    {
                        parts[parts.Count - 1] = last.WithText(text.Remove(text.Length - attributeSuffix.Length));
                    }
                }
            }

            ImmutableArray<ITypeSymbol> typeArguments = typeSymbol.TypeArguments;

            ImmutableArray<ITypeSymbol>.Enumerator en = typeArguments.GetEnumerator();

            if (en.MoveNext())
            {
                parts.AddPunctuation("<");

                while (true)
                {
                    if (en.Current.Kind == SymbolKind.NamedType)
                    {
                        parts.AddDisplayParts((INamedTypeSymbol)en.Current, omitContainingNamespace);
                    }
                    else
                    {
                        Debug.Assert(en.Current.Kind == SymbolKind.TypeParameter, en.Current.Kind.ToString());

                        parts.Add(new SymbolDisplayPart(SymbolDisplayPartKind.TypeParameterName, en.Current, en.Current.Name));
                    }

                    if (en.MoveNext())
                    {
                        parts.AddPunctuation(",");
                        parts.AddSpace();
                    }
                    else
                    {
                        break;
                    }
                }

                parts.AddPunctuation(">");
            }
        }

        private static void AddSpace(this ImmutableArray<SymbolDisplayPart>.Builder builder)
        {
            builder.Add(SymbolDisplayPartFactory.Space());
        }

        private static void AddIndentation(this ImmutableArray<SymbolDisplayPart>.Builder builder)
        {
            builder.Add(SymbolDisplayPartFactory.Indentation());
        }

        private static void AddLineBreak(this ImmutableArray<SymbolDisplayPart>.Builder builder)
        {
            builder.Add(SymbolDisplayPartFactory.LineBreak());
        }

        private static void AddPunctuation(this ImmutableArray<SymbolDisplayPart>.Builder builder, string text)
        {
            builder.Add(SymbolDisplayPartFactory.Punctuation(text));
        }

        private static void AddKeyword(this ImmutableArray<SymbolDisplayPart>.Builder builder, string text)
        {
            builder.Add(SymbolDisplayPartFactory.Keyword(text));
        }

        private static void InsertRange(this ImmutableArray<SymbolDisplayPart>.Builder builder, int index, ImmutableArray<SymbolDisplayPart> parts)
        {
            for (int i = parts.Length - 1; i >= 0; i--)
            {
                builder.Insert(index, parts[i]);
            }
        }
    }
}
