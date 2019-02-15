* assembly Roslynator\.Core, Version=1\.0\.0\.10, Culture=neutral, PublicKeyToken=3aeedfaf14b2cebf
* assembly Roslynator\.CSharp, Version=1\.0\.0\.10, Culture=neutral, PublicKeyToken=390be46f77b79f52
* assembly Roslynator\.CSharp\.Workspaces, Version=1\.0\.0\.10, Culture=neutral, PublicKeyToken=ec3f0c29a7973f23
* assembly Roslynator\.Workspaces\.Core, Version=1\.0\.0\.10, Culture=neutral, PublicKeyToken=be1ec334fe31b7bb
* namespace Roslynator
* &emsp; public static class DiagnosticsExtensions
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, Location location, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, Location location, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxTreeAnalysisContext context, DiagnosticDescriptor descriptor, Location location, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxNode node, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxNode node, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxTreeAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxNode node, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxToken token, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxToken token, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxTreeAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxToken token, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxTrivia trivia, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxTrivia trivia, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxTreeAnalysisContext context, DiagnosticDescriptor descriptor, SyntaxTrivia trivia, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, Location location, IEnumerable\<Location> additionalLocations, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, Location location, IEnumerable\<Location> additionalLocations, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxTreeAnalysisContext context, DiagnosticDescriptor descriptor, Location location, IEnumerable\<Location> additionalLocations, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, Location location, ImmutableDictionary\<string, string> properties, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, Location location, ImmutableDictionary\<string, string> properties, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxTreeAnalysisContext context, DiagnosticDescriptor descriptor, Location location, ImmutableDictionary\<string, string> properties, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SymbolAnalysisContext context, DiagnosticDescriptor descriptor, Location location, IEnumerable\<Location> additionalLocations, ImmutableDictionary\<string, string> properties, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxNodeAnalysisContext context, DiagnosticDescriptor descriptor, Location location, IEnumerable\<Location> additionalLocations, ImmutableDictionary\<string, string> properties, params object\[\] messageArgs\)
* &emsp; \| &emsp; public static void ReportDiagnostic\(this SyntaxTreeAnalysisContext context, DiagnosticDescriptor descriptor, Location location, IEnumerable\<Location> additionalLocations, ImmutableDictionary\<string, string> properties, params object\[\] messageArgs\)
* &emsp; public static class EnumExtensions
* &emsp; \| &emsp; public static bool Is\(this Accessibility accessibility, Accessibility accessibility1, Accessibility accessibility2\)
* &emsp; \| &emsp; public static bool Is\(this MethodKind methodKind, MethodKind methodKind1, MethodKind methodKind2\)
* &emsp; \| &emsp; public static bool Is\(this SpecialType specialType, SpecialType specialType1, SpecialType specialType2\)
* &emsp; \| &emsp; public static bool Is\(this TypeKind typeKind, TypeKind typeKind1, TypeKind typeKind2\)
* &emsp; \| &emsp; public static bool Is\(this Accessibility accessibility, Accessibility accessibility1, Accessibility accessibility2, Accessibility accessibility3\)
* &emsp; \| &emsp; public static bool Is\(this MethodKind methodKind, MethodKind methodKind1, MethodKind methodKind2, MethodKind methodKind3\)
* &emsp; \| &emsp; public static bool Is\(this SpecialType specialType, SpecialType specialType1, SpecialType specialType2, SpecialType specialType3\)
* &emsp; \| &emsp; public static bool Is\(this TypeKind typeKind, TypeKind typeKind1, TypeKind typeKind2, TypeKind typeKind3\)
* &emsp; \| &emsp; public static bool Is\(this Accessibility accessibility, Accessibility accessibility1, Accessibility accessibility2, Accessibility accessibility3, Accessibility accessibility4\)
* &emsp; \| &emsp; public static bool Is\(this MethodKind methodKind, MethodKind methodKind1, MethodKind methodKind2, MethodKind methodKind3, MethodKind methodKind4\)
* &emsp; \| &emsp; public static bool Is\(this SpecialType specialType, SpecialType specialType1, SpecialType specialType2, SpecialType specialType3, SpecialType specialType4\)
* &emsp; \| &emsp; public static bool Is\(this TypeKind typeKind, TypeKind typeKind1, TypeKind typeKind2, TypeKind typeKind3, TypeKind typeKind4\)
* &emsp; \| &emsp; public static bool Is\(this Accessibility accessibility, Accessibility accessibility1, Accessibility accessibility2, Accessibility accessibility3, Accessibility accessibility4, Accessibility accessibility5\)
* &emsp; \| &emsp; public static bool Is\(this MethodKind methodKind, MethodKind methodKind1, MethodKind methodKind2, MethodKind methodKind3, MethodKind methodKind4, MethodKind methodKind5\)
* &emsp; \| &emsp; public static bool Is\(this SpecialType specialType, SpecialType specialType1, SpecialType specialType2, SpecialType specialType3, SpecialType specialType4, SpecialType specialType5\)
* &emsp; \| &emsp; public static bool Is\(this TypeKind typeKind, TypeKind typeKind1, TypeKind typeKind2, TypeKind typeKind3, TypeKind typeKind4, TypeKind typeKind5\)
* &emsp; \| &emsp; public static bool IsMoreRestrictiveThan\(this Accessibility accessibility, Accessibility other\)
* &emsp; public static class FileLinePositionSpanExtensions
* &emsp; \| &emsp; public static int EndLine\(this FileLinePositionSpan fileLinePositionSpan\)
* &emsp; \| &emsp; public static bool IsMultiLine\(this FileLinePositionSpan fileLinePositionSpan\)
* &emsp; \| &emsp; public static bool IsSingleLine\(this FileLinePositionSpan fileLinePositionSpan\)
* &emsp; \| &emsp; public static int StartLine\(this FileLinePositionSpan fileLinePositionSpan\)
* &emsp; public sealed class MetadataNameEqualityComparer\<TSymbol> : EqualityComparer\<TSymbol> where TSymbol : ISymbol
* &emsp; \| &emsp; public static MetadataNameEqualityComparer\<TSymbol> Instance \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(TSymbol x, TSymbol y\)
* &emsp; \| &emsp; public override int GetHashCode\(TSymbol obj\)
* &emsp; public abstract class NameGenerator
* &emsp; \| &emsp; protected NameGenerator\(\)
* &emsp; \| &emsp; public static NameGenerator Default \{ get; \}
* &emsp; \| &emsp; public static string CreateName\(ITypeSymbol typeSymbol, bool firstCharToLower = false\)
* &emsp; \| &emsp; public string EnsureUniqueEnumMemberName\(string baseName, INamedTypeSymbol enumType, bool isCaseSensitive = true\)
* &emsp; \| &emsp; public string EnsureUniqueLocalName\(string baseName, SemanticModel semanticModel, int position, bool isCaseSensitive = true, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; \[Obsolete\("This member is obsolete\."\)\] public string EnsureUniqueMemberName\(string baseName, INamedTypeSymbol typeSymbol, bool isCaseSensitive = true\)
* &emsp; \| &emsp; \[Obsolete\("This member is obsolete\."\)\] public string EnsureUniqueMemberName\(string baseName, SemanticModel semanticModel, int position, bool isCaseSensitive = true, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public abstract string EnsureUniqueName\(string baseName, IEnumerable\<string> reservedNames, bool isCaseSensitive = true\)
* &emsp; \| &emsp; public abstract string EnsureUniqueName\(string baseName, ImmutableArray\<ISymbol> symbols, bool isCaseSensitive = true\)
* &emsp; \| &emsp; public string EnsureUniqueName\(string baseName, SemanticModel semanticModel, int position, bool isCaseSensitive = true\)
* &emsp; \| &emsp; public static bool IsUniqueName\(string name, IEnumerable\<string> reservedNames, bool isCaseSensitive = true\)
* &emsp; \| &emsp; public static bool IsUniqueName\(string name, ImmutableArray\<ISymbol> symbols, bool isCaseSensitive = true\)
* &emsp; public static class SemanticModelExtensions
* &emsp; \| &emsp; public static INamedTypeSymbol GetEnclosingNamedType\(this SemanticModel semanticModel, int position, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static TSymbol GetEnclosingSymbol\<TSymbol>\(this SemanticModel semanticModel, int position, CancellationToken cancellationToken = default\) where TSymbol : ISymbol
* &emsp; \| &emsp; public static ISymbol GetSymbol\(this SemanticModel semanticModel, SyntaxNode node, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static INamedTypeSymbol GetTypeByMetadataName\(this SemanticModel semanticModel, string fullyQualifiedMetadataName\)
* &emsp; \| &emsp; public static ITypeSymbol GetTypeSymbol\(this SemanticModel semanticModel, SyntaxNode node, CancellationToken cancellationToken = default\)
* &emsp; public class SeparatedSyntaxListSelection\<TNode> : ISelection\<TNode> where TNode : SyntaxNode
* &emsp; \| &emsp; protected SeparatedSyntaxListSelection\(SeparatedSyntaxList\<TNode> list, TextSpan span, int firstIndex, int lastIndex\)
* &emsp; \| &emsp; public int Count \{ get; \}
* &emsp; \| &emsp; public int FirstIndex \{ get; \}
* &emsp; \| &emsp; public int LastIndex \{ get; \}
* &emsp; \| &emsp; public TextSpan OriginalSpan \{ get; \}
* &emsp; \| &emsp; public SeparatedSyntaxList\<TNode> UnderlyingList \{ get; \}
* &emsp; \| &emsp; public TNode this\[int index\] \{ get; \}
* &emsp; \| &emsp; public static SeparatedSyntaxListSelection\<TNode> Create\(SeparatedSyntaxList\<TNode> list, TextSpan span\)
* &emsp; \| &emsp; public TNode First\(\)
* &emsp; \| &emsp; public SeparatedSyntaxListSelection\<TNode>\.Enumerator GetEnumerator\(\)
* &emsp; \| &emsp; public TNode Last\(\)
* &emsp; \| &emsp; public static bool TryCreate\(SeparatedSyntaxList\<TNode> list, TextSpan span, out SeparatedSyntaxListSelection\<TNode> selection\)
* &emsp; \| &emsp; public struct Enumerator
* &emsp; \| &emsp; \| &emsp; public TNode Current \{ get; \}
* &emsp; \| &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; \| &emsp; public bool MoveNext\(\)
* &emsp; \| &emsp; \| &emsp; public void Reset\(\)
* &emsp; public static class SymbolExtensions
* &emsp; \| &emsp; public static IEnumerable\<INamedTypeSymbol> BaseTypes\(this ITypeSymbol type\)
* &emsp; \| &emsp; public static IEnumerable\<ITypeSymbol> BaseTypesAndSelf\(this ITypeSymbol typeSymbol\)
* &emsp; \| &emsp; public static bool EqualsOrInheritsFrom\(this ITypeSymbol type, ITypeSymbol baseType, bool includeInterfaces = false\)
* &emsp; \| &emsp; public static bool EqualsOrInheritsFrom\(this ITypeSymbol type, in MetadataName baseTypeName, bool includeInterfaces = false\)
* &emsp; \| &emsp; public static TSymbol FindMember\<TSymbol>\(this ITypeSymbol typeSymbol, Func\<TSymbol, bool> predicate = null\) where TSymbol : ISymbol
* &emsp; \| &emsp; public static TSymbol FindMember\<TSymbol>\(this ITypeSymbol typeSymbol, string name, Func\<TSymbol, bool> predicate = null\) where TSymbol : ISymbol
* &emsp; \| &emsp; public static TSymbol FindMember\<TSymbol>\(this INamedTypeSymbol typeSymbol, Func\<TSymbol, bool> predicate, bool includeBaseTypes = false\) where TSymbol : ISymbol
* &emsp; \| &emsp; public static TSymbol FindMember\<TSymbol>\(this INamedTypeSymbol typeSymbol, string name, Func\<TSymbol, bool> predicate = null, bool includeBaseTypes = false\) where TSymbol : ISymbol
* &emsp; \| &emsp; public static INamedTypeSymbol FindTypeMember\(this INamedTypeSymbol typeSymbol, Func\<INamedTypeSymbol, bool> predicate, bool includeBaseTypes = false\)
* &emsp; \| &emsp; public static INamedTypeSymbol FindTypeMember\(this INamedTypeSymbol typeSymbol, string name, Func\<INamedTypeSymbol, bool> predicate = null, bool includeBaseTypes = false\)
* &emsp; \| &emsp; public static INamedTypeSymbol FindTypeMember\(this INamedTypeSymbol typeSymbol, string name, int arity, Func\<INamedTypeSymbol, bool> predicate = null, bool includeBaseTypes = false\)
* &emsp; \| &emsp; public static AttributeData GetAttribute\(this ISymbol symbol, INamedTypeSymbol attributeClass\)
* &emsp; \| &emsp; public static AttributeData GetAttribute\(this ISymbol symbol, in MetadataName attributeName\)
* &emsp; \| &emsp; public static bool HasAttribute\(this ISymbol symbol, INamedTypeSymbol attributeClass\)
* &emsp; \| &emsp; public static bool HasAttribute\(this ISymbol symbol, in MetadataName attributeName\)
* &emsp; \| &emsp; public static bool HasAttribute\(this ITypeSymbol typeSymbol, INamedTypeSymbol attributeClass, bool includeBaseTypes\)
* &emsp; \| &emsp; public static bool HasAttribute\(this ITypeSymbol typeSymbol, in MetadataName attributeName, bool includeBaseTypes\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, bool value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, char value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, sbyte value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, byte value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, short value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, ushort value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, int value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, uint value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, long value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, ulong value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, decimal value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, float value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, double value\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this IFieldSymbol fieldSymbol, string value\)
* &emsp; \| &emsp; public static bool HasMetadataName\(this ISymbol symbol, in MetadataName metadataName\)
* &emsp; \| &emsp; public static bool Implements\(this ITypeSymbol typeSymbol, INamedTypeSymbol interfaceSymbol, bool allInterfaces = false\)
* &emsp; \| &emsp; public static bool Implements\(this ITypeSymbol typeSymbol, SpecialType interfaceType, bool allInterfaces = false\)
* &emsp; \| &emsp; public static bool Implements\(this ITypeSymbol typeSymbol, in MetadataName interfaceName, bool allInterfaces = false\)
* &emsp; \| &emsp; public static bool ImplementsAny\(this ITypeSymbol typeSymbol, SpecialType interfaceType1, SpecialType interfaceType2, bool allInterfaces = false\)
* &emsp; \| &emsp; public static bool ImplementsAny\(this ITypeSymbol typeSymbol, SpecialType interfaceType1, SpecialType interfaceType2, SpecialType interfaceType3, bool allInterfaces = false\)
* &emsp; \| &emsp; public static bool ImplementsInterfaceMember\(this ISymbol symbol, bool allInterfaces = false\)
* &emsp; \| &emsp; public static bool ImplementsInterfaceMember\(this ISymbol symbol, INamedTypeSymbol interfaceSymbol, bool allInterfaces = false\)
* &emsp; \| &emsp; public static bool ImplementsInterfaceMember\<TSymbol>\(this ISymbol symbol, bool allInterfaces = false\) where TSymbol : ISymbol
* &emsp; \| &emsp; public static bool ImplementsInterfaceMember\<TSymbol>\(this ISymbol symbol, INamedTypeSymbol interfaceSymbol, bool allInterfaces = false\) where TSymbol : ISymbol
* &emsp; \| &emsp; public static bool InheritsFrom\(this ITypeSymbol type, ITypeSymbol baseType, bool includeInterfaces = false\)
* &emsp; \| &emsp; public static bool InheritsFrom\(this ITypeSymbol type, in MetadataName baseTypeName, bool includeInterfaces = false\)
* &emsp; \| &emsp; public static bool IsAsyncMethod\(this ISymbol symbol\)
* &emsp; \| &emsp; public static bool IsErrorType\(this ISymbol symbol\)
* &emsp; \| &emsp; public static bool IsIEnumerableOfT\(this ITypeSymbol typeSymbol\)
* &emsp; \| &emsp; public static bool IsIEnumerableOrIEnumerableOfT\(this ITypeSymbol typeSymbol\)
* &emsp; \| &emsp; public static bool IsKind\(this ISymbol symbol, SymbolKind kind\)
* &emsp; \| &emsp; public static bool IsKind\(this ISymbol symbol, SymbolKind kind1, SymbolKind kind2\)
* &emsp; \| &emsp; public static bool IsKind\(this ISymbol symbol, SymbolKind kind1, SymbolKind kind2, SymbolKind kind3\)
* &emsp; \| &emsp; public static bool IsKind\(this ISymbol symbol, SymbolKind kind1, SymbolKind kind2, SymbolKind kind3, SymbolKind kind4\)
* &emsp; \| &emsp; public static bool IsKind\(this ISymbol symbol, SymbolKind kind1, SymbolKind kind2, SymbolKind kind3, SymbolKind kind4, SymbolKind kind5\)
* &emsp; \| &emsp; public static bool IsNullableOf\(this INamedTypeSymbol namedTypeSymbol, SpecialType specialType\)
* &emsp; \| &emsp; public static bool IsNullableOf\(this INamedTypeSymbol namedTypeSymbol, ITypeSymbol typeArgument\)
* &emsp; \| &emsp; public static bool IsNullableOf\(this ITypeSymbol typeSymbol, SpecialType specialType\)
* &emsp; \| &emsp; public static bool IsNullableOf\(this ITypeSymbol typeSymbol, ITypeSymbol typeArgument\)
* &emsp; \| &emsp; public static bool IsNullableType\(this ITypeSymbol typeSymbol\)
* &emsp; \| &emsp; public static bool IsObject\(this ITypeSymbol typeSymbol\)
* &emsp; \| &emsp; public static bool IsOrdinaryExtensionMethod\(this IMethodSymbol methodSymbol\)
* &emsp; \| &emsp; public static bool IsParameterArrayOf\(this IParameterSymbol parameterSymbol, SpecialType elementType\)
* &emsp; \| &emsp; public static bool IsParameterArrayOf\(this IParameterSymbol parameterSymbol, SpecialType elementType1, SpecialType elementType2\)
* &emsp; \| &emsp; public static bool IsParameterArrayOf\(this IParameterSymbol parameterSymbol, SpecialType elementType1, SpecialType elementType2, SpecialType elementType3\)
* &emsp; \| &emsp; public static bool IsPubliclyVisible\(this ISymbol symbol\)
* &emsp; \| &emsp; public static bool IsReducedExtensionMethod\(this IMethodSymbol methodSymbol\)
* &emsp; \| &emsp; public static bool IsRefOrOut\(this IParameterSymbol parameterSymbol\)
* &emsp; \| &emsp; public static bool IsReferenceTypeOrNullableType\(this ITypeSymbol typeSymbol\)
* &emsp; \| &emsp; public static bool IsString\(this ITypeSymbol typeSymbol\)
* &emsp; \| &emsp; public static bool IsVoid\(this ITypeSymbol typeSymbol\)
* &emsp; \| &emsp; public static IMethodSymbol ReducedFromOrSelf\(this IMethodSymbol methodSymbol\)
* &emsp; \| &emsp; public static bool SupportsExplicitDeclaration\(this ITypeSymbol typeSymbol\)
* &emsp; public static class SyntaxExtensions
* &emsp; \| &emsp; public static bool All\(this SyntaxTokenList list, Func\<SyntaxToken, bool> predicate\)
* &emsp; \| &emsp; public static bool All\(this SyntaxTriviaList list, Func\<SyntaxTrivia, bool> predicate\)
* &emsp; \| &emsp; public static bool All\<TNode>\(this SeparatedSyntaxList\<TNode> list, Func\<TNode, bool> predicate\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool All\<TNode>\(this SyntaxList\<TNode> list, Func\<TNode, bool> predicate\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool Any\(this SyntaxTokenList list, Func\<SyntaxToken, bool> predicate\)
* &emsp; \| &emsp; public static bool Any\(this SyntaxTriviaList list, Func\<SyntaxTrivia, bool> predicate\)
* &emsp; \| &emsp; public static bool Any\<TNode>\(this SeparatedSyntaxList\<TNode> list, Func\<TNode, bool> predicate\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool Any\<TNode>\(this SyntaxList\<TNode> list, Func\<TNode, bool> predicate\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxToken AppendToLeadingTrivia\(this SyntaxToken token, IEnumerable\<SyntaxTrivia> trivia\)
* &emsp; \| &emsp; public static SyntaxToken AppendToLeadingTrivia\(this SyntaxToken token, SyntaxTrivia trivia\)
* &emsp; \| &emsp; public static TNode AppendToLeadingTrivia\<TNode>\(this TNode node, IEnumerable\<SyntaxTrivia> trivia\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode AppendToLeadingTrivia\<TNode>\(this TNode node, SyntaxTrivia trivia\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxToken AppendToTrailingTrivia\(this SyntaxToken token, IEnumerable\<SyntaxTrivia> trivia\)
* &emsp; \| &emsp; public static SyntaxToken AppendToTrailingTrivia\(this SyntaxToken token, SyntaxTrivia trivia\)
* &emsp; \| &emsp; public static TNode AppendToTrailingTrivia\<TNode>\(this TNode node, IEnumerable\<SyntaxTrivia> trivia\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode AppendToTrailingTrivia\<TNode>\(this TNode node, SyntaxTrivia trivia\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool Contains\(this SyntaxTokenList tokens, SyntaxToken token\)
* &emsp; \| &emsp; public static bool Contains\<TNode>\(this SeparatedSyntaxList\<TNode> list, TNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool Contains\<TNode>\(this SyntaxList\<TNode> list, TNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool ContainsDirectives\(this SyntaxNode node, TextSpan span\)
* &emsp; \| &emsp; public static IEnumerable\<SyntaxTrivia> DescendantTrivia\<TNode>\(this SyntaxList\<TNode> list, Func\<SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static IEnumerable\<SyntaxTrivia> DescendantTrivia\<TNode>\(this SyntaxList\<TNode> list, TextSpan span, Func\<SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode FirstAncestor\<TNode>\(this SyntaxNode node, Func\<TNode, bool> predicate = null, bool ascendOutOfTrivia = true\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode FirstDescendant\<TNode>\(this SyntaxNode node, Func\<SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode FirstDescendant\<TNode>\(this SyntaxNode node, TextSpan span, Func\<SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode FirstDescendantOrSelf\<TNode>\(this SyntaxNode node, Func\<SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode FirstDescendantOrSelf\<TNode>\(this SyntaxNode node, TextSpan span, Func\<SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxTriviaList GetLeadingAndTrailingTrivia\(this SyntaxNode node\)
* &emsp; \| &emsp; public static SyntaxToken GetTrailingSeparator\<TNode>\(this SeparatedSyntaxList\<TNode> list\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool HasTrailingSeparator\<TNode>\(this SeparatedSyntaxList\<TNode> list\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static int IndexOf\(this SyntaxTokenList tokens, Func\<SyntaxToken, bool> predicate\)
* &emsp; \| &emsp; public static int IndexOf\(this SyntaxTriviaList triviaList, Func\<SyntaxTrivia, bool> predicate\)
* &emsp; \| &emsp; public static bool IsFirst\<TNode>\(this SeparatedSyntaxList\<TNode> list, TNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool IsFirst\<TNode>\(this SyntaxList\<TNode> list, TNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool IsLast\<TNode>\(this SeparatedSyntaxList\<TNode> list, TNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool IsLast\<TNode>\(this SyntaxList\<TNode> list, TNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxTriviaList LeadingAndTrailingTrivia\(this SyntaxToken token\)
* &emsp; \| &emsp; public static SyntaxToken PrependToLeadingTrivia\(this SyntaxToken token, IEnumerable\<SyntaxTrivia> trivia\)
* &emsp; \| &emsp; public static SyntaxToken PrependToLeadingTrivia\(this SyntaxToken token, SyntaxTrivia trivia\)
* &emsp; \| &emsp; public static TNode PrependToLeadingTrivia\<TNode>\(this TNode node, IEnumerable\<SyntaxTrivia> trivia\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode PrependToLeadingTrivia\<TNode>\(this TNode node, SyntaxTrivia trivia\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxToken PrependToTrailingTrivia\(this SyntaxToken token, IEnumerable\<SyntaxTrivia> trivia\)
* &emsp; \| &emsp; public static SyntaxToken PrependToTrailingTrivia\(this SyntaxToken token, SyntaxTrivia trivia\)
* &emsp; \| &emsp; public static TNode PrependToTrailingTrivia\<TNode>\(this TNode node, IEnumerable\<SyntaxTrivia> trivia\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode PrependToTrailingTrivia\<TNode>\(this TNode node, SyntaxTrivia trivia\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxTokenList ReplaceAt\(this SyntaxTokenList tokenList, int index, SyntaxToken newToken\)
* &emsp; \| &emsp; public static SyntaxTriviaList ReplaceAt\(this SyntaxTriviaList triviaList, int index, SyntaxTrivia newTrivia\)
* &emsp; \| &emsp; public static SeparatedSyntaxList\<TNode> ReplaceAt\<TNode>\(this SeparatedSyntaxList\<TNode> list, int index, TNode newNode\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxList\<TNode> ReplaceAt\<TNode>\(this SyntaxList\<TNode> list, int index, TNode newNode\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool SpanContainsDirectives\(this SyntaxNode node\)
* &emsp; \| &emsp; public static bool TryGetContainingList\(this SyntaxTrivia trivia, out SyntaxTriviaList triviaList, bool allowLeading = true, bool allowTrailing = true\)
* &emsp; \| &emsp; public static SyntaxToken WithTriviaFrom\(this SyntaxToken token, SyntaxNode node\)
* &emsp; \| &emsp; public static SeparatedSyntaxList\<TNode> WithTriviaFrom\<TNode>\(this SeparatedSyntaxList\<TNode> list, SyntaxNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxList\<TNode> WithTriviaFrom\<TNode>\(this SyntaxList\<TNode> list, SyntaxNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode WithTriviaFrom\<TNode>\(this TNode node, SyntaxToken token\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxNodeOrToken WithoutLeadingTrivia\(this SyntaxNodeOrToken nodeOrToken\)
* &emsp; \| &emsp; public static SyntaxToken WithoutLeadingTrivia\(this SyntaxToken token\)
* &emsp; \| &emsp; public static SyntaxNodeOrToken WithoutTrailingTrivia\(this SyntaxNodeOrToken nodeOrToken\)
* &emsp; \| &emsp; public static SyntaxToken WithoutTrailingTrivia\(this SyntaxToken token\)
* &emsp; \| &emsp; public static SyntaxNodeOrToken WithoutTrivia\(this SyntaxNodeOrToken nodeOrToken\)
* &emsp; public class SyntaxListSelection\<TNode> : ISelection\<TNode> where TNode : SyntaxNode
* &emsp; \| &emsp; protected SyntaxListSelection\(SyntaxList\<TNode> list, TextSpan span, int firstIndex, int lastIndex\)
* &emsp; \| &emsp; public int Count \{ get; \}
* &emsp; \| &emsp; public int FirstIndex \{ get; \}
* &emsp; \| &emsp; public int LastIndex \{ get; \}
* &emsp; \| &emsp; public TextSpan OriginalSpan \{ get; \}
* &emsp; \| &emsp; public SyntaxList\<TNode> UnderlyingList \{ get; \}
* &emsp; \| &emsp; public TNode this\[int index\] \{ get; \}
* &emsp; \| &emsp; public static SyntaxListSelection\<TNode> Create\(SyntaxList\<TNode> list, TextSpan span\)
* &emsp; \| &emsp; public TNode First\(\)
* &emsp; \| &emsp; public SyntaxListSelection\<TNode>\.Enumerator GetEnumerator\(\)
* &emsp; \| &emsp; public TNode Last\(\)
* &emsp; \| &emsp; public static bool TryCreate\(SyntaxList\<TNode> list, TextSpan span, out SyntaxListSelection\<TNode> selection\)
* &emsp; \| &emsp; public struct Enumerator
* &emsp; \| &emsp; \| &emsp; public TNode Current \{ get; \}
* &emsp; \| &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; \| &emsp; public bool MoveNext\(\)
* &emsp; \| &emsp; \| &emsp; public void Reset\(\)
* &emsp; public static class SyntaxTreeExtensions
* &emsp; \| &emsp; public static int GetEndLine\(this SyntaxTree syntaxTree, TextSpan span, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static int GetStartLine\(this SyntaxTree syntaxTree, TextSpan span, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static bool IsMultiLineSpan\(this SyntaxTree syntaxTree, TextSpan span, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static bool IsSingleLineSpan\(this SyntaxTree syntaxTree, TextSpan span, CancellationToken cancellationToken = default\)
* &emsp; public static class WorkspaceExtensions
* &emsp; \| &emsp; public static Task\<Document> InsertNodeAfterAsync\(this Document document, SyntaxNode nodeInList, SyntaxNode newNode, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> InsertNodeBeforeAsync\(this Document document, SyntaxNode nodeInList, SyntaxNode newNode, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> InsertNodesAfterAsync\(this Document document, SyntaxNode nodeInList, IEnumerable\<SyntaxNode> newNodes, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> InsertNodesBeforeAsync\(this Document document, SyntaxNode nodeInList, IEnumerable\<SyntaxNode> newNodes, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> RemoveNodeAsync\(this Document document, SyntaxNode node, SyntaxRemoveOptions options, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> RemoveNodesAsync\(this Document document, IEnumerable\<SyntaxNode> nodes, SyntaxRemoveOptions options, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> ReplaceNodeAsync\(this Document document, SyntaxNode oldNode, SyntaxNode newNode, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> ReplaceNodeAsync\(this Document document, SyntaxNode oldNode, IEnumerable\<SyntaxNode> newNodes, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Solution> ReplaceNodeAsync\<TNode>\(this Solution solution, TNode oldNode, TNode newNode, CancellationToken cancellationToken = default\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static Task\<Document> ReplaceNodesAsync\<TNode>\(this Document document, IEnumerable\<TNode> nodes, Func\<TNode, TNode, SyntaxNode> computeReplacementNode, CancellationToken cancellationToken = default\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static Task\<Solution> ReplaceNodesAsync\<TNode>\(this Solution solution, IEnumerable\<TNode> nodes, Func\<TNode, TNode, SyntaxNode> computeReplacementNodes, CancellationToken cancellationToken = default\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static Task\<Document> ReplaceTokenAsync\(this Document document, SyntaxToken oldToken, SyntaxToken newToken, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> ReplaceTokenAsync\(this Document document, SyntaxToken oldToken, IEnumerable\<SyntaxToken> newTokens, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> ReplaceTriviaAsync\(this Document document, SyntaxTrivia oldTrivia, SyntaxTrivia newTrivia, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> ReplaceTriviaAsync\(this Document document, SyntaxTrivia oldTrivia, IEnumerable\<SyntaxTrivia> newTrivia, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> WithTextChangeAsync\(this Document document, TextChange textChange, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> WithTextChangesAsync\(this Document document, TextChange\[\] textChanges, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> WithTextChangesAsync\(this Document document, IEnumerable\<TextChange> textChanges, CancellationToken cancellationToken = default\)
* &emsp; public readonly struct ExtensionMethodSymbolInfo : IEquatable\<ExtensionMethodSymbolInfo>
* &emsp; \| &emsp; public bool IsReduced \{ get; \}
* &emsp; \| &emsp; public IMethodSymbol ReducedSymbol \{ get; \}
* &emsp; \| &emsp; public IMethodSymbol ReducedSymbolOrSymbol \{ get; \}
* &emsp; \| &emsp; public IMethodSymbol Symbol \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(ExtensionMethodSymbolInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public static bool operator ==\(in ExtensionMethodSymbolInfo info1, in ExtensionMethodSymbolInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in ExtensionMethodSymbolInfo info1, in ExtensionMethodSymbolInfo info2\)
* &emsp; public readonly struct MetadataName : IEquatable\<MetadataName>
* &emsp; \| &emsp; public MetadataName\(IEnumerable\<string> containingNamespaces, string name\)
* &emsp; \| &emsp; public MetadataName\(ImmutableArray\<string> containingNamespaces, string name\)
* &emsp; \| &emsp; public MetadataName\(IEnumerable\<string> containingNamespaces, IEnumerable\<string> containingTypes, string name\)
* &emsp; \| &emsp; public MetadataName\(ImmutableArray\<string> containingNamespaces, ImmutableArray\<string> containingTypes, string name\)
* &emsp; \| &emsp; public ImmutableArray\<string> ContainingNamespaces \{ get; \}
* &emsp; \| &emsp; public ImmutableArray\<string> ContainingTypes \{ get; \}
* &emsp; \| &emsp; public bool IsDefault \{ get; \}
* &emsp; \| &emsp; public string Name \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(MetadataName other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public static MetadataName Parse\(string name\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool TryParse\(string name, out MetadataName metadataName\)
* &emsp; \| &emsp; public static bool operator ==\(in MetadataName metadataName1, in MetadataName metadataName2\)
* &emsp; \| &emsp; public static bool operator \!=\(in MetadataName metadataName1, in MetadataName metadataName2\)
* &emsp; public interface ISelection\<T> : IReadOnlyList\<T>
* &emsp; \| &emsp; int FirstIndex \{ get; \}
* &emsp; \| &emsp; int LastIndex \{ get; \}
* &emsp; \| &emsp; T First\(\)
* &emsp; \| &emsp; T Last\(\)
* &emsp; public enum Visibility
* &emsp; \| &emsp; NotApplicable = 0
* &emsp; \| &emsp; Private = 1
* &emsp; \| &emsp; Internal = 2
* &emsp; \| &emsp; Public = 3
* namespace Roslynator\.CSharp
* &emsp; public static class CSharpExtensions
* &emsp; \| &emsp; public static IParameterSymbol DetermineParameter\(this SemanticModel semanticModel, ArgumentSyntax argument, bool allowParams = false, bool allowCandidate = false, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static IParameterSymbol DetermineParameter\(this SemanticModel semanticModel, AttributeArgumentSyntax attributeArgument, bool allowParams = false, bool allowCandidate = false, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ExtensionMethodSymbolInfo GetExtensionMethodInfo\(this SemanticModel semanticModel, ExpressionSyntax expression, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static IMethodSymbol GetMethodSymbol\(this SemanticModel semanticModel, ExpressionSyntax expression, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ExtensionMethodSymbolInfo GetReducedExtensionMethodInfo\(this SemanticModel semanticModel, ExpressionSyntax expression, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ISymbol GetSymbol\(this SemanticModel semanticModel, AttributeSyntax attribute, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ISymbol GetSymbol\(this SemanticModel semanticModel, ConstructorInitializerSyntax constructorInitializer, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ISymbol GetSymbol\(this SemanticModel semanticModel, CrefSyntax cref, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ISymbol GetSymbol\(this SemanticModel semanticModel, ExpressionSyntax expression, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ISymbol GetSymbol\(this SemanticModel semanticModel, OrderingSyntax ordering, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ISymbol GetSymbol\(this SemanticModel semanticModel, SelectOrGroupClauseSyntax selectOrGroupClause, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ITypeSymbol GetTypeSymbol\(this SemanticModel semanticModel, AttributeSyntax attribute, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ITypeSymbol GetTypeSymbol\(this SemanticModel semanticModel, ConstructorInitializerSyntax constructorInitializer, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ITypeSymbol GetTypeSymbol\(this SemanticModel semanticModel, ExpressionSyntax expression, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ITypeSymbol GetTypeSymbol\(this SemanticModel semanticModel, SelectOrGroupClauseSyntax selectOrGroupClause, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static bool HasConstantValue\(this SemanticModel semanticModel, ExpressionSyntax expression, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static bool IsDefaultValue\(this SemanticModel semanticModel, ITypeSymbol typeSymbol, ExpressionSyntax expression, CancellationToken cancellationToken = default\)
* &emsp; public static class CSharpFactory
* &emsp; \| &emsp; public static AccessorListSyntax AccessorList\(AccessorDeclarationSyntax accessor\)
* &emsp; \| &emsp; public static AccessorListSyntax AccessorList\(params AccessorDeclarationSyntax\[\] accessors\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax AddAccessorDeclaration\(BlockSyntax body\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax AddAccessorDeclaration\(ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax AddAccessorDeclaration\(SyntaxTokenList modifiers, BlockSyntax body\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax AddAccessorDeclaration\(SyntaxTokenList modifiers, ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax AddAssignmentExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax AddAssignmentExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax AddExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax AddExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax AddressOfExpression\(ExpressionSyntax operand\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax AddressOfExpression\(ExpressionSyntax operand, SyntaxToken operatorToken\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax AndAssignmentExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax AndAssignmentExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static ArgumentSyntax Argument\(NameColonSyntax nameColon, ExpressionSyntax expression\)
* &emsp; \| &emsp; public static ArgumentListSyntax ArgumentList\(ArgumentSyntax argument\)
* &emsp; \| &emsp; public static ArgumentListSyntax ArgumentList\(params ArgumentSyntax\[\] arguments\)
* &emsp; \| &emsp; public static InitializerExpressionSyntax ArrayInitializerExpression\(SeparatedSyntaxList\<ExpressionSyntax> expressions = default\)
* &emsp; \| &emsp; public static InitializerExpressionSyntax ArrayInitializerExpression\(SyntaxToken openBraceToken, SeparatedSyntaxList\<ExpressionSyntax> expressions, SyntaxToken closeBraceToken\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax AsExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax AsExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AttributeSyntax Attribute\(NameSyntax name, AttributeArgumentSyntax argument\)
* &emsp; \| &emsp; public static AttributeArgumentSyntax AttributeArgument\(NameColonSyntax nameColon, ExpressionSyntax expression\)
* &emsp; \| &emsp; public static AttributeArgumentSyntax AttributeArgument\(NameEqualsSyntax nameEquals, ExpressionSyntax expression\)
* &emsp; \| &emsp; public static AttributeArgumentListSyntax AttributeArgumentList\(AttributeArgumentSyntax attributeArgument\)
* &emsp; \| &emsp; public static AttributeArgumentListSyntax AttributeArgumentList\(params AttributeArgumentSyntax\[\] attributeArguments\)
* &emsp; \| &emsp; public static AttributeListSyntax AttributeList\(AttributeSyntax attribute\)
* &emsp; \| &emsp; public static AttributeListSyntax AttributeList\(params AttributeSyntax\[\] attributes\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax AutoGetAccessorDeclaration\(SyntaxTokenList modifiers = default\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax AutoSetAccessorDeclaration\(SyntaxTokenList modifiers = default\)
* &emsp; \| &emsp; public static ConstructorInitializerSyntax BaseConstructorInitializer\(ArgumentListSyntax argumentList = null\)
* &emsp; \| &emsp; public static ConstructorInitializerSyntax BaseConstructorInitializer\(SyntaxToken semicolonToken, ArgumentListSyntax argumentList\)
* &emsp; \| &emsp; public static BaseListSyntax BaseList\(BaseTypeSyntax type\)
* &emsp; \| &emsp; public static BaseListSyntax BaseList\(params BaseTypeSyntax\[\] types\)
* &emsp; \| &emsp; public static BaseListSyntax BaseList\(SyntaxToken colonToken, BaseTypeSyntax baseType\)
* &emsp; \| &emsp; public static BaseListSyntax BaseList\(SyntaxToken colonToken, params BaseTypeSyntax\[\] types\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax BitwiseAndExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax BitwiseAndExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax BitwiseNotExpression\(ExpressionSyntax operand\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax BitwiseNotExpression\(ExpressionSyntax operand, SyntaxToken operatorToken\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax BitwiseOrExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax BitwiseOrExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BlockSyntax Block\(StatementSyntax statement\)
* &emsp; \| &emsp; public static BlockSyntax Block\(SyntaxToken openBrace, StatementSyntax statement, SyntaxToken closeBrace\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax BooleanLiteralExpression\(bool value\)
* &emsp; \| &emsp; public static BracketedArgumentListSyntax BracketedArgumentList\(ArgumentSyntax argument\)
* &emsp; \| &emsp; public static BracketedArgumentListSyntax BracketedArgumentList\(params ArgumentSyntax\[\] arguments\)
* &emsp; \| &emsp; public static BracketedParameterListSyntax BracketedParameterList\(ParameterSyntax parameter\)
* &emsp; \| &emsp; public static BracketedParameterListSyntax BracketedParameterList\(params ParameterSyntax\[\] parameters\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax CharacterLiteralExpression\(char value\)
* &emsp; \| &emsp; public static CheckedExpressionSyntax CheckedExpression\(ExpressionSyntax expression\)
* &emsp; \| &emsp; public static CheckedExpressionSyntax CheckedExpression\(SyntaxToken openParenToken, ExpressionSyntax expression, SyntaxToken closeParenToken\)
* &emsp; \| &emsp; public static ClassOrStructConstraintSyntax ClassConstraint\(\)
* &emsp; \| &emsp; public static ClassDeclarationSyntax ClassDeclaration\(SyntaxTokenList modifiers, string identifier, SyntaxList\<MemberDeclarationSyntax> members = default\)
* &emsp; \| &emsp; public static ClassDeclarationSyntax ClassDeclaration\(SyntaxTokenList modifiers, SyntaxToken identifier, SyntaxList\<MemberDeclarationSyntax> members = default\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax CoalesceExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax CoalesceExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static InitializerExpressionSyntax CollectionInitializerExpression\(SeparatedSyntaxList\<ExpressionSyntax> expressions = default\)
* &emsp; \| &emsp; public static InitializerExpressionSyntax CollectionInitializerExpression\(SyntaxToken openBraceToken, SeparatedSyntaxList\<ExpressionSyntax> expressions, SyntaxToken closeBraceToken\)
* &emsp; \| &emsp; public static CompilationUnitSyntax CompilationUnit\(MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static CompilationUnitSyntax CompilationUnit\(SyntaxList\<UsingDirectiveSyntax> usings, MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static CompilationUnitSyntax CompilationUnit\(SyntaxList\<UsingDirectiveSyntax> usings, SyntaxList\<MemberDeclarationSyntax> members\)
* &emsp; \| &emsp; public static InitializerExpressionSyntax ComplexElementInitializerExpression\(SeparatedSyntaxList\<ExpressionSyntax> expressions = default\)
* &emsp; \| &emsp; public static InitializerExpressionSyntax ComplexElementInitializerExpression\(SyntaxToken openBraceToken, SeparatedSyntaxList\<ExpressionSyntax> expressions, SyntaxToken closeBraceToken\)
* &emsp; \| &emsp; public static ConstructorDeclarationSyntax ConstructorDeclaration\(SyntaxTokenList modifiers, SyntaxToken identifier, ParameterListSyntax parameterList, BlockSyntax body\)
* &emsp; \| &emsp; public static ConstructorDeclarationSyntax ConstructorDeclaration\(SyntaxTokenList modifiers, SyntaxToken identifier, ParameterListSyntax parameterList, ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax DefaultLiteralExpression\(\)
* &emsp; \| &emsp; public static SwitchSectionSyntax DefaultSwitchSection\(StatementSyntax statement\)
* &emsp; \| &emsp; public static SwitchSectionSyntax DefaultSwitchSection\(SyntaxList\<StatementSyntax> statements\)
* &emsp; \| &emsp; public static DelegateDeclarationSyntax DelegateDeclaration\(SyntaxTokenList modifiers, TypeSyntax returnType, string identifier, ParameterListSyntax parameterList\)
* &emsp; \| &emsp; public static DelegateDeclarationSyntax DelegateDeclaration\(SyntaxTokenList modifiers, TypeSyntax returnType, SyntaxToken identifier, ParameterListSyntax parameterList\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax DivideAssignmentExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax DivideAssignmentExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax DivideExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax DivideExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static SyntaxTrivia EmptyWhitespace\(\)
* &emsp; \| &emsp; public static EnumDeclarationSyntax EnumDeclaration\(SyntaxTokenList modifiers, SyntaxToken identifier, SeparatedSyntaxList\<EnumMemberDeclarationSyntax> members\)
* &emsp; \| &emsp; public static EnumMemberDeclarationSyntax EnumMemberDeclaration\(SyntaxToken identifier, ExpressionSyntax value\)
* &emsp; \| &emsp; public static EnumMemberDeclarationSyntax EnumMemberDeclaration\(SyntaxToken identifier, EqualsValueClauseSyntax value\)
* &emsp; \| &emsp; public static EnumMemberDeclarationSyntax EnumMemberDeclaration\(string name, ExpressionSyntax value\)
* &emsp; \| &emsp; public static EnumMemberDeclarationSyntax EnumMemberDeclaration\(string name, EqualsValueClauseSyntax value\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax EqualsExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax EqualsExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static EventDeclarationSyntax EventDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, string identifier, AccessorListSyntax accessorList\)
* &emsp; \| &emsp; public static EventDeclarationSyntax EventDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, SyntaxToken identifier, AccessorListSyntax accessorList\)
* &emsp; \| &emsp; public static EventFieldDeclarationSyntax EventFieldDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, string identifier\)
* &emsp; \| &emsp; public static EventFieldDeclarationSyntax EventFieldDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, SyntaxToken identifier\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax ExclusiveOrAssignmentExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax ExclusiveOrAssignmentExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax ExclusiveOrExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax ExclusiveOrExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static ConversionOperatorDeclarationSyntax ExplicitConversionOperatorDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, ParameterListSyntax parameterList, BlockSyntax body\)
* &emsp; \| &emsp; public static ConversionOperatorDeclarationSyntax ExplicitConversionOperatorDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, ParameterListSyntax parameterList, ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax FalseLiteralExpression\(\)
* &emsp; \| &emsp; public static FieldDeclarationSyntax FieldDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, string identifier, EqualsValueClauseSyntax initializer\)
* &emsp; \| &emsp; public static FieldDeclarationSyntax FieldDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, SyntaxToken identifier, EqualsValueClauseSyntax initializer\)
* &emsp; \| &emsp; public static FieldDeclarationSyntax FieldDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, string identifier, ExpressionSyntax value = null\)
* &emsp; \| &emsp; public static FieldDeclarationSyntax FieldDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, SyntaxToken identifier, ExpressionSyntax value = null\)
* &emsp; \| &emsp; public static GenericNameSyntax GenericName\(string identifier, TypeSyntax typeArgument\)
* &emsp; \| &emsp; public static GenericNameSyntax GenericName\(SyntaxToken identifier, TypeSyntax typeArgument\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax GetAccessorDeclaration\(BlockSyntax body\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax GetAccessorDeclaration\(ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax GetAccessorDeclaration\(SyntaxTokenList modifiers, BlockSyntax body\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax GetAccessorDeclaration\(SyntaxTokenList modifiers, ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax GreaterThanExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax GreaterThanExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax GreaterThanOrEqualExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax GreaterThanOrEqualExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static ConversionOperatorDeclarationSyntax ImplicitConversionOperatorDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, ParameterListSyntax parameterList, BlockSyntax body\)
* &emsp; \| &emsp; public static ConversionOperatorDeclarationSyntax ImplicitConversionOperatorDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, ParameterListSyntax parameterList, ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static IndexerDeclarationSyntax IndexerDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, BracketedParameterListSyntax parameterList, AccessorListSyntax accessorList\)
* &emsp; \| &emsp; public static IndexerDeclarationSyntax IndexerDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, BracketedParameterListSyntax parameterList, ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static InterfaceDeclarationSyntax InterfaceDeclaration\(SyntaxTokenList modifiers, string identifier, SyntaxList\<MemberDeclarationSyntax> members = default\)
* &emsp; \| &emsp; public static InterfaceDeclarationSyntax InterfaceDeclaration\(SyntaxTokenList modifiers, SyntaxToken identifier, SyntaxList\<MemberDeclarationSyntax> members = default\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax IsExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax IsExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax LeftShiftAssignmentExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax LeftShiftAssignmentExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax LeftShiftExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax LeftShiftExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax LessThanExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax LessThanExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax LessThanOrEqualExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax LessThanOrEqualExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax LiteralExpression\(object value\)
* &emsp; \| &emsp; public static LocalDeclarationStatementSyntax LocalDeclarationStatement\(TypeSyntax type, string identifier, EqualsValueClauseSyntax initializer\)
* &emsp; \| &emsp; public static LocalDeclarationStatementSyntax LocalDeclarationStatement\(TypeSyntax type, SyntaxToken identifier, EqualsValueClauseSyntax initializer\)
* &emsp; \| &emsp; public static LocalDeclarationStatementSyntax LocalDeclarationStatement\(TypeSyntax type, string identifier, ExpressionSyntax value = null\)
* &emsp; \| &emsp; public static LocalDeclarationStatementSyntax LocalDeclarationStatement\(TypeSyntax type, SyntaxToken identifier, ExpressionSyntax value = null\)
* &emsp; \| &emsp; public static LocalFunctionStatementSyntax LocalFunctionStatement\(SyntaxTokenList modifiers, TypeSyntax returnType, SyntaxToken identifier, ParameterListSyntax parameterList, BlockSyntax body\)
* &emsp; \| &emsp; public static LocalFunctionStatementSyntax LocalFunctionStatement\(SyntaxTokenList modifiers, TypeSyntax returnType, SyntaxToken identifier, ParameterListSyntax parameterList, ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax LogicalAndExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax LogicalAndExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax LogicalNotExpression\(ExpressionSyntax operand\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax LogicalNotExpression\(ExpressionSyntax operand, SyntaxToken operatorToken\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax LogicalOrExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax LogicalOrExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static MethodDeclarationSyntax MethodDeclaration\(SyntaxTokenList modifiers, TypeSyntax returnType, SyntaxToken identifier, ParameterListSyntax parameterList, BlockSyntax body\)
* &emsp; \| &emsp; public static MethodDeclarationSyntax MethodDeclaration\(SyntaxTokenList modifiers, TypeSyntax returnType, SyntaxToken identifier, ParameterListSyntax parameterList, ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax ModuloAssignmentExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax ModuloAssignmentExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax ModuloExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax ModuloExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax MultiplyAssignmentExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax MultiplyAssignmentExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax MultiplyExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax MultiplyExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static InvocationExpressionSyntax NameOfExpression\(ExpressionSyntax expression\)
* &emsp; \| &emsp; public static InvocationExpressionSyntax NameOfExpression\(string identifier\)
* &emsp; \| &emsp; public static NamespaceDeclarationSyntax NamespaceDeclaration\(NameSyntax name, MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static NamespaceDeclarationSyntax NamespaceDeclaration\(NameSyntax name, SyntaxList\<MemberDeclarationSyntax> members\)
* &emsp; \| &emsp; public static SyntaxTrivia NewLine\(\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax NotEqualsExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax NotEqualsExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax NullLiteralExpression\(\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax NumericLiteralExpression\(int value\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax NumericLiteralExpression\(uint value\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax NumericLiteralExpression\(sbyte value\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax NumericLiteralExpression\(decimal value\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax NumericLiteralExpression\(double value\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax NumericLiteralExpression\(float value\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax NumericLiteralExpression\(long value\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax NumericLiteralExpression\(ulong value\)
* &emsp; \| &emsp; public static ObjectCreationExpressionSyntax ObjectCreationExpression\(TypeSyntax type, ArgumentListSyntax argumentList\)
* &emsp; \| &emsp; public static InitializerExpressionSyntax ObjectInitializerExpression\(SeparatedSyntaxList\<ExpressionSyntax> expressions = default\)
* &emsp; \| &emsp; public static InitializerExpressionSyntax ObjectInitializerExpression\(SyntaxToken openBraceToken, SeparatedSyntaxList\<ExpressionSyntax> expressions, SyntaxToken closeBraceToken\)
* &emsp; \| &emsp; public static OperatorDeclarationSyntax OperatorDeclaration\(SyntaxTokenList modifiers, TypeSyntax returnType, SyntaxToken operatorToken, ParameterListSyntax parameterList, BlockSyntax body\)
* &emsp; \| &emsp; public static OperatorDeclarationSyntax OperatorDeclaration\(SyntaxTokenList modifiers, TypeSyntax returnType, SyntaxToken operatorToken, ParameterListSyntax parameterList, ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax OrAssignmentExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax OrAssignmentExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static ParameterSyntax Parameter\(TypeSyntax type, string identifier, ExpressionSyntax @default = null\)
* &emsp; \| &emsp; public static ParameterSyntax Parameter\(TypeSyntax type, SyntaxToken identifier, ExpressionSyntax @default = null\)
* &emsp; \| &emsp; public static ParameterSyntax Parameter\(TypeSyntax type, SyntaxToken identifier, EqualsValueClauseSyntax @default\)
* &emsp; \| &emsp; public static ParameterListSyntax ParameterList\(ParameterSyntax parameter\)
* &emsp; \| &emsp; public static ParameterListSyntax ParameterList\(params ParameterSyntax\[\] parameters\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax PointerIndirectionExpression\(ExpressionSyntax operand\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax PointerIndirectionExpression\(ExpressionSyntax operand, SyntaxToken operatorToken\)
* &emsp; \| &emsp; public static PostfixUnaryExpressionSyntax PostDecrementExpression\(ExpressionSyntax operand\)
* &emsp; \| &emsp; public static PostfixUnaryExpressionSyntax PostDecrementExpression\(ExpressionSyntax operand, SyntaxToken operatorToken\)
* &emsp; \| &emsp; public static PostfixUnaryExpressionSyntax PostIncrementExpression\(ExpressionSyntax operand\)
* &emsp; \| &emsp; public static PostfixUnaryExpressionSyntax PostIncrementExpression\(ExpressionSyntax operand, SyntaxToken operatorToken\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax PreDecrementExpression\(ExpressionSyntax operand\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax PreDecrementExpression\(ExpressionSyntax operand, SyntaxToken operatorToken\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax PreIncrementExpression\(ExpressionSyntax operand\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax PreIncrementExpression\(ExpressionSyntax operand, SyntaxToken operatorToken\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedBoolType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedByteType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedCharType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedDecimalType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedDoubleType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedFloatType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedIntType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedLongType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedObjectType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedSByteType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedShortType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedStringType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedUIntType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedULongType\(\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax PredefinedUShortType\(\)
* &emsp; \| &emsp; public static PropertyDeclarationSyntax PropertyDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, SyntaxToken identifier, ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static PropertyDeclarationSyntax PropertyDeclaration\(SyntaxTokenList modifiers, TypeSyntax type, SyntaxToken identifier, AccessorListSyntax accessorList, ExpressionSyntax value = null\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax RemoveAccessorDeclaration\(BlockSyntax body\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax RemoveAccessorDeclaration\(ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax RemoveAccessorDeclaration\(SyntaxTokenList modifiers, BlockSyntax body\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax RemoveAccessorDeclaration\(SyntaxTokenList modifiers, ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax RightShiftAssignmentExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax RightShiftAssignmentExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax RightShiftExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax RightShiftExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax SetAccessorDeclaration\(BlockSyntax body\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax SetAccessorDeclaration\(ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax SetAccessorDeclaration\(SyntaxTokenList modifiers, BlockSyntax body\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax SetAccessorDeclaration\(SyntaxTokenList modifiers, ArrowExpressionClauseSyntax expressionBody\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax SimpleAssignmentExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax SimpleAssignmentExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static ExpressionStatementSyntax SimpleAssignmentStatement\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static ExpressionStatementSyntax SimpleAssignmentStatement\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static MemberAccessExpressionSyntax SimpleMemberAccessExpression\(ExpressionSyntax expression, SimpleNameSyntax name\)
* &emsp; \| &emsp; public static MemberAccessExpressionSyntax SimpleMemberAccessExpression\(ExpressionSyntax expression, SyntaxToken operatorToken, SimpleNameSyntax name\)
* &emsp; \| &emsp; public static InvocationExpressionSyntax SimpleMemberInvocationExpression\(ExpressionSyntax expression, SimpleNameSyntax name\)
* &emsp; \| &emsp; public static InvocationExpressionSyntax SimpleMemberInvocationExpression\(ExpressionSyntax expression, SimpleNameSyntax name, ArgumentSyntax argument\)
* &emsp; \| &emsp; public static InvocationExpressionSyntax SimpleMemberInvocationExpression\(ExpressionSyntax expression, SimpleNameSyntax name, ArgumentListSyntax argumentList\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax StringLiteralExpression\(string value\)
* &emsp; \| &emsp; public static ClassOrStructConstraintSyntax StructConstraint\(\)
* &emsp; \| &emsp; public static StructDeclarationSyntax StructDeclaration\(SyntaxTokenList modifiers, string identifier, SyntaxList\<MemberDeclarationSyntax> members = default\)
* &emsp; \| &emsp; public static StructDeclarationSyntax StructDeclaration\(SyntaxTokenList modifiers, SyntaxToken identifier, SyntaxList\<MemberDeclarationSyntax> members = default\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax SubtractAssignmentExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static AssignmentExpressionSyntax SubtractAssignmentExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax SubtractExpression\(ExpressionSyntax left, ExpressionSyntax right\)
* &emsp; \| &emsp; public static BinaryExpressionSyntax SubtractExpression\(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right\)
* &emsp; \| &emsp; public static SwitchSectionSyntax SwitchSection\(SwitchLabelSyntax switchLabel, StatementSyntax statement\)
* &emsp; \| &emsp; public static SwitchSectionSyntax SwitchSection\(SwitchLabelSyntax switchLabel, SyntaxList\<StatementSyntax> statements\)
* &emsp; \| &emsp; public static SwitchSectionSyntax SwitchSection\(SyntaxList\<SwitchLabelSyntax> switchLabels, StatementSyntax statement\)
* &emsp; \| &emsp; public static ConstructorInitializerSyntax ThisConstructorInitializer\(ArgumentListSyntax argumentList = null\)
* &emsp; \| &emsp; public static ConstructorInitializerSyntax ThisConstructorInitializer\(SyntaxToken semicolonToken, ArgumentListSyntax argumentList\)
* &emsp; \| &emsp; public static SyntaxTokenList TokenList\(Accessibility accessibility\)
* &emsp; \| &emsp; public static SyntaxTokenList TokenList\(SyntaxKind kind\)
* &emsp; \| &emsp; public static SyntaxTokenList TokenList\(SyntaxKind kind1, SyntaxKind kind2\)
* &emsp; \| &emsp; public static SyntaxTokenList TokenList\(SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3\)
* &emsp; \| &emsp; public static LiteralExpressionSyntax TrueLiteralExpression\(\)
* &emsp; \| &emsp; public static TryStatementSyntax TryStatement\(BlockSyntax block, CatchClauseSyntax @catch, FinallyClauseSyntax @finally = null\)
* &emsp; \| &emsp; public static TypeArgumentListSyntax TypeArgumentList\(TypeSyntax argument\)
* &emsp; \| &emsp; public static TypeArgumentListSyntax TypeArgumentList\(params TypeSyntax\[\] arguments\)
* &emsp; \| &emsp; public static TypeParameterConstraintClauseSyntax TypeParameterConstraintClause\(IdentifierNameSyntax identifierName, TypeParameterConstraintSyntax typeParameterConstraint\)
* &emsp; \| &emsp; public static TypeParameterConstraintClauseSyntax TypeParameterConstraintClause\(string name, TypeParameterConstraintSyntax typeParameterConstraint\)
* &emsp; \| &emsp; public static TypeParameterListSyntax TypeParameterList\(TypeParameterSyntax parameter\)
* &emsp; \| &emsp; public static TypeParameterListSyntax TypeParameterList\(params TypeParameterSyntax\[\] parameters\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax UnaryMinusExpression\(ExpressionSyntax operand\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax UnaryMinusExpression\(ExpressionSyntax operand, SyntaxToken operatorToken\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax UnaryPlusExpression\(ExpressionSyntax operand\)
* &emsp; \| &emsp; public static PrefixUnaryExpressionSyntax UnaryPlusExpression\(ExpressionSyntax operand, SyntaxToken operatorToken\)
* &emsp; \| &emsp; public static CheckedExpressionSyntax UncheckedExpression\(ExpressionSyntax expression\)
* &emsp; \| &emsp; public static CheckedExpressionSyntax UncheckedExpression\(SyntaxToken openParenToken, ExpressionSyntax expression, SyntaxToken closeParenToken\)
* &emsp; \| &emsp; public static UsingDirectiveSyntax UsingStaticDirective\(NameSyntax name\)
* &emsp; \| &emsp; public static UsingDirectiveSyntax UsingStaticDirective\(SyntaxToken usingKeyword, SyntaxToken staticKeyword, NameSyntax name, SyntaxToken semicolonToken\)
* &emsp; \| &emsp; public static IdentifierNameSyntax VarType\(\)
* &emsp; \| &emsp; public static VariableDeclarationSyntax VariableDeclaration\(TypeSyntax type, VariableDeclaratorSyntax variable\)
* &emsp; \| &emsp; public static VariableDeclarationSyntax VariableDeclaration\(TypeSyntax type, SyntaxToken identifier, EqualsValueClauseSyntax initializer\)
* &emsp; \| &emsp; public static VariableDeclarationSyntax VariableDeclaration\(TypeSyntax type, string identifier, ExpressionSyntax value = null\)
* &emsp; \| &emsp; public static VariableDeclarationSyntax VariableDeclaration\(TypeSyntax type, SyntaxToken identifier, ExpressionSyntax value = null\)
* &emsp; \| &emsp; public static VariableDeclaratorSyntax VariableDeclarator\(string identifier, EqualsValueClauseSyntax initializer\)
* &emsp; \| &emsp; public static VariableDeclaratorSyntax VariableDeclarator\(SyntaxToken identifier, EqualsValueClauseSyntax initializer\)
* &emsp; \| &emsp; public static PredefinedTypeSyntax VoidType\(\)
* &emsp; \| &emsp; public static YieldStatementSyntax YieldBreakStatement\(\)
* &emsp; \| &emsp; public static YieldStatementSyntax YieldReturnStatement\(ExpressionSyntax expression\)
* &emsp; public static class CSharpFacts
* &emsp; \| &emsp; public static bool CanBeEmbeddedStatement\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool CanHaveEmbeddedStatement\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool CanHaveExpressionBody\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool CanHaveMembers\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool CanHaveModifiers\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool CanHaveStatements\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsAnonymousFunctionExpression\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsBooleanExpression\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsBooleanLiteralExpression\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsCommentTrivia\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsCompoundAssignmentExpression\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsConstraint\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsFunction\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsIfElseDirective\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsIncrementOrDecrementExpression\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsIterationStatement\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsJumpStatement\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsLambdaExpression\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsLiteralExpression\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsPredefinedType\(SpecialType specialType\)
* &emsp; \| &emsp; public static bool IsSimpleType\(SpecialType specialType\)
* &emsp; \| &emsp; public static bool IsSwitchLabel\(SyntaxKind kind\)
* &emsp; \| &emsp; public static bool SupportsPrefixOrPostfixUnaryOperator\(SpecialType specialType\)
* &emsp; public static class EnumExtensions
* &emsp; \| &emsp; public static bool Is\(this SyntaxKind kind, SyntaxKind kind1, SyntaxKind kind2\)
* &emsp; \| &emsp; public static bool Is\(this SyntaxKind kind, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3\)
* &emsp; \| &emsp; public static bool Is\(this SyntaxKind kind, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4\)
* &emsp; \| &emsp; public static bool Is\(this SyntaxKind kind, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5\)
* &emsp; \| &emsp; public static bool Is\(this SyntaxKind kind, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5, SyntaxKind kind6\)
* &emsp; public sealed class MemberDeclarationListSelection : SyntaxListSelection\<MemberDeclarationSyntax>
* &emsp; \| &emsp; public SyntaxNode Parent \{ get; \}
* &emsp; \| &emsp; public static MemberDeclarationListSelection Create\(CompilationUnitSyntax compilationUnit, TextSpan span\)
* &emsp; \| &emsp; public static MemberDeclarationListSelection Create\(NamespaceDeclarationSyntax namespaceDeclaration, TextSpan span\)
* &emsp; \| &emsp; public static MemberDeclarationListSelection Create\(TypeDeclarationSyntax typeDeclaration, TextSpan span\)
* &emsp; \| &emsp; public static bool TryCreate\(NamespaceDeclarationSyntax namespaceDeclaration, TextSpan span, out MemberDeclarationListSelection selectedMembers\)
* &emsp; \| &emsp; public static bool TryCreate\(TypeDeclarationSyntax typeDeclaration, TextSpan span, out MemberDeclarationListSelection selectedMembers\)
* &emsp; public static class ModifierList
* &emsp; \| &emsp; public static int GetInsertIndex\(SyntaxTokenList tokens, SyntaxKind kind, IComparer\<SyntaxKind> comparer = null\)
* &emsp; \| &emsp; public static int GetInsertIndex\(SyntaxTokenList tokens, SyntaxToken token, IComparer\<SyntaxToken> comparer = null\)
* &emsp; \| &emsp; public static SyntaxTokenList Insert\(SyntaxTokenList modifiers, SyntaxKind kind, IComparer\<SyntaxKind> comparer = null\)
* &emsp; \| &emsp; public static SyntaxTokenList Insert\(SyntaxTokenList modifiers, SyntaxToken modifier, IComparer\<SyntaxToken> comparer = null\)
* &emsp; \| &emsp; public static TNode Insert\<TNode>\(TNode node, SyntaxKind kind, IComparer\<SyntaxKind> comparer = null\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode Insert\<TNode>\(TNode node, SyntaxToken modifier, IComparer\<SyntaxToken> comparer = null\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode Remove\<TNode>\(TNode node, SyntaxKind kind\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode Remove\<TNode>\(TNode node, SyntaxToken modifier\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode RemoveAll\<TNode>\(TNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode RemoveAll\<TNode>\(TNode node, Func\<SyntaxToken, bool> predicate\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode RemoveAt\<TNode>\(TNode node, int index\) where TNode : SyntaxNode
* &emsp; public abstract class ModifierList\<TNode> where TNode : SyntaxNode
* &emsp; \| &emsp; public static ModifierList\<TNode> Instance \{ get; \}
* &emsp; \| &emsp; public TNode Insert\(TNode node, SyntaxKind kind, IComparer\<SyntaxKind> comparer = null\)
* &emsp; \| &emsp; public TNode Insert\(TNode node, SyntaxToken modifier, IComparer\<SyntaxToken> comparer = null\)
* &emsp; \| &emsp; public TNode Remove\(TNode node, SyntaxKind kind\)
* &emsp; \| &emsp; public TNode Remove\(TNode node, SyntaxToken modifier\)
* &emsp; \| &emsp; public TNode RemoveAll\(TNode node\)
* &emsp; \| &emsp; public TNode RemoveAll\(TNode node, Func\<SyntaxToken, bool> predicate\)
* &emsp; \| &emsp; public TNode RemoveAt\(TNode node, int index\)
* &emsp; public static class Modifiers
* &emsp; \| &emsp; public static SyntaxTokenList Const\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Internal\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Internal\_Abstract\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Internal\_Const\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Internal\_Override\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Internal\_Partial\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Internal\_ReadOnly\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Internal\_Static\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Internal\_Static\_Partial\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Internal\_Static\_ReadOnly\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Internal\_Virtual\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Partial\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Private\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Private\_Const\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Private\_Partial\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Private\_Protected\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Private\_ReadOnly\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Private\_Static\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Private\_Static\_Partial\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Private\_Static\_ReadOnly\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Protected\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Protected\_Abstract\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Protected\_Const\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Protected\_Internal\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Protected\_Override\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Protected\_ReadOnly\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Protected\_Static\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Protected\_Static\_ReadOnly\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Protected\_Virtual\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Public\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Public\_Abstract\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Public\_Const\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Public\_Override\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Public\_Partial\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Public\_ReadOnly\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Public\_Static\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Public\_Static\_Partial\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Public\_Static\_ReadOnly\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Public\_Virtual\(\)
* &emsp; \| &emsp; public static SyntaxTokenList ReadOnly\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Ref\_ReadOnly\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Static\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Static\_ReadOnly\(\)
* &emsp; \| &emsp; public static SyntaxTokenList Virtual\(\)
* &emsp; public sealed class StatementListSelection : SyntaxListSelection\<StatementSyntax>
* &emsp; \| &emsp; public static StatementListSelection Create\(BlockSyntax block, TextSpan span\)
* &emsp; \| &emsp; public static StatementListSelection Create\(SwitchSectionSyntax switchSection, TextSpan span\)
* &emsp; \| &emsp; public static StatementListSelection Create\(in StatementListInfo statementsInfo, TextSpan span\)
* &emsp; \| &emsp; public static bool TryCreate\(BlockSyntax block, TextSpan span, out StatementListSelection selectedStatements\)
* &emsp; \| &emsp; public static bool TryCreate\(SwitchSectionSyntax switchSection, TextSpan span, out StatementListSelection selectedStatements\)
* &emsp; public static class SymbolExtensions
* &emsp; \| &emsp; public static bool SupportsConstantValue\(this ITypeSymbol typeSymbol\)
* &emsp; \| &emsp; public static TypeSyntax ToMinimalTypeSyntax\(this INamespaceOrTypeSymbol namespaceOrTypeSymbol, SemanticModel semanticModel, int position, SymbolDisplayFormat format = null\)
* &emsp; \| &emsp; public static TypeSyntax ToMinimalTypeSyntax\(this INamespaceSymbol namespaceSymbol, SemanticModel semanticModel, int position, SymbolDisplayFormat format = null\)
* &emsp; \| &emsp; public static TypeSyntax ToMinimalTypeSyntax\(this ITypeSymbol typeSymbol, SemanticModel semanticModel, int position, SymbolDisplayFormat format = null\)
* &emsp; \| &emsp; public static TypeSyntax ToTypeSyntax\(this INamespaceOrTypeSymbol namespaceOrTypeSymbol, SymbolDisplayFormat format = null\)
* &emsp; \| &emsp; public static TypeSyntax ToTypeSyntax\(this INamespaceSymbol namespaceSymbol, SymbolDisplayFormat format = null\)
* &emsp; \| &emsp; public static TypeSyntax ToTypeSyntax\(this ITypeSymbol typeSymbol, SymbolDisplayFormat format = null\)
* &emsp; public static class SyntaxAccessibility
* &emsp; \| &emsp; public static Accessibility GetAccessibility\(SyntaxNode declaration\)
* &emsp; \| &emsp; public static Accessibility GetDefaultAccessibility\(SyntaxNode declaration\)
* &emsp; \| &emsp; public static Accessibility GetDefaultExplicitAccessibility\(SyntaxNode declaration\)
* &emsp; \| &emsp; public static Accessibility GetExplicitAccessibility\(SyntaxNode declaration\)
* &emsp; \| &emsp; public static Accessibility GetExplicitAccessibility\(SyntaxTokenList modifiers\)
* &emsp; \| &emsp; public static bool IsPubliclyVisible\(MemberDeclarationSyntax declaration\)
* &emsp; \| &emsp; public static bool IsValidAccessibility\(SyntaxNode node, Accessibility accessibility, bool ignoreOverride = false\)
* &emsp; \| &emsp; public static TNode WithExplicitAccessibility\<TNode>\(TNode node, Accessibility newAccessibility, IComparer\<SyntaxKind> comparer = null\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode WithoutExplicitAccessibility\<TNode>\(TNode node\) where TNode : SyntaxNode
* &emsp; public static class SyntaxExtensions
* &emsp; \| &emsp; public static SyntaxList\<StatementSyntax> Add\(this SyntaxList\<StatementSyntax> statements, StatementSyntax statement, bool ignoreLocalFunctions\)
* &emsp; \| &emsp; \[Obsolete\("This method is obsolete\."\)\] public static ClassDeclarationSyntax AddAttributeLists\(this ClassDeclarationSyntax classDeclaration, bool keepDocumentationCommentOnTop, params AttributeListSyntax\[\] attributeLists\)
* &emsp; \| &emsp; \[Obsolete\("This method is obsolete\."\)\] public static InterfaceDeclarationSyntax AddAttributeLists\(this InterfaceDeclarationSyntax interfaceDeclaration, bool keepDocumentationCommentOnTop, params AttributeListSyntax\[\] attributeLists\)
* &emsp; \| &emsp; \[Obsolete\("This method is obsolete\."\)\] public static StructDeclarationSyntax AddAttributeLists\(this StructDeclarationSyntax structDeclaration, bool keepDocumentationCommentOnTop, params AttributeListSyntax\[\] attributeLists\)
* &emsp; \| &emsp; public static CompilationUnitSyntax AddUsings\(this CompilationUnitSyntax compilationUnit, bool keepSingleLineCommentsOnTop, params UsingDirectiveSyntax\[\] usings\)
* &emsp; \| &emsp; public static IfStatementCascade AsCascade\(this IfStatementSyntax ifStatement\)
* &emsp; \| &emsp; public static ExpressionChain AsChain\(this BinaryExpressionSyntax binaryExpression, TextSpan? span = null\)
* &emsp; \| &emsp; public static CSharpSyntaxNode BodyOrExpressionBody\(this AccessorDeclarationSyntax accessorDeclaration\)
* &emsp; \| &emsp; public static CSharpSyntaxNode BodyOrExpressionBody\(this ConstructorDeclarationSyntax constructorDeclaration\)
* &emsp; \| &emsp; public static CSharpSyntaxNode BodyOrExpressionBody\(this ConversionOperatorDeclarationSyntax conversionOperatorDeclaration\)
* &emsp; \| &emsp; public static CSharpSyntaxNode BodyOrExpressionBody\(this DestructorDeclarationSyntax destructorDeclaration\)
* &emsp; \| &emsp; public static CSharpSyntaxNode BodyOrExpressionBody\(this LocalFunctionStatementSyntax localFunctionStatement\)
* &emsp; \| &emsp; public static CSharpSyntaxNode BodyOrExpressionBody\(this MethodDeclarationSyntax methodDeclaration\)
* &emsp; \| &emsp; public static CSharpSyntaxNode BodyOrExpressionBody\(this OperatorDeclarationSyntax operatorDeclaration\)
* &emsp; \| &emsp; public static TextSpan BracesSpan\(this ClassDeclarationSyntax classDeclaration\)
* &emsp; \| &emsp; public static TextSpan BracesSpan\(this EnumDeclarationSyntax enumDeclaration\)
* &emsp; \| &emsp; public static TextSpan BracesSpan\(this InterfaceDeclarationSyntax interfaceDeclaration\)
* &emsp; \| &emsp; public static TextSpan BracesSpan\(this NamespaceDeclarationSyntax namespaceDeclaration\)
* &emsp; \| &emsp; public static TextSpan BracesSpan\(this StructDeclarationSyntax structDeclaration\)
* &emsp; \| &emsp; public static bool Contains\(this SyntaxTokenList tokenList, SyntaxKind kind\)
* &emsp; \| &emsp; public static bool Contains\(this SyntaxTriviaList triviaList, SyntaxKind kind\)
* &emsp; \| &emsp; public static bool Contains\<TNode>\(this SeparatedSyntaxList\<TNode> list, SyntaxKind kind\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool Contains\<TNode>\(this SyntaxList\<TNode> list, SyntaxKind kind\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool ContainsAny\(this SyntaxTokenList tokenList, SyntaxKind kind1, SyntaxKind kind2\)
* &emsp; \| &emsp; public static bool ContainsAny\(this SyntaxTokenList tokenList, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3\)
* &emsp; \| &emsp; public static bool ContainsAny\(this SyntaxTokenList tokenList, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4\)
* &emsp; \| &emsp; public static bool ContainsAny\(this SyntaxTokenList tokenList, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5\)
* &emsp; \| &emsp; public static bool ContainsDefaultLabel\(this SwitchSectionSyntax switchSection\)
* &emsp; \| &emsp; public static bool ContainsYield\(this LocalFunctionStatementSyntax localFunctionStatement\)
* &emsp; \| &emsp; public static bool ContainsYield\(this MethodDeclarationSyntax methodDeclaration\)
* &emsp; \| &emsp; public static CSharpSyntaxNode DeclarationOrExpression\(this UsingStatementSyntax usingStatement\)
* &emsp; \| &emsp; public static SwitchSectionSyntax DefaultSection\(this SwitchStatementSyntax switchStatement\)
* &emsp; \| &emsp; public static IEnumerable\<XmlElementSyntax> Elements\(this DocumentationCommentTriviaSyntax documentationComment, string localName\)
* &emsp; \| &emsp; public static SyntaxToken Find\(this SyntaxTokenList tokenList, SyntaxKind kind\)
* &emsp; \| &emsp; public static SyntaxTrivia Find\(this SyntaxTriviaList triviaList, SyntaxKind kind\)
* &emsp; \| &emsp; public static TNode Find\<TNode>\(this SeparatedSyntaxList\<TNode> list, SyntaxKind kind\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode Find\<TNode>\(this SyntaxList\<TNode> list, SyntaxKind kind\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxNode FirstAncestor\(this SyntaxNode node, SyntaxKind kind, bool ascendOutOfTrivia = true\)
* &emsp; \| &emsp; public static SyntaxNode FirstAncestor\(this SyntaxNode node, Func\<SyntaxNode, bool> predicate, bool ascendOutOfTrivia = true\)
* &emsp; \| &emsp; public static SyntaxNode FirstAncestor\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2, bool ascendOutOfTrivia = true\)
* &emsp; \| &emsp; public static SyntaxNode FirstAncestor\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, bool ascendOutOfTrivia = true\)
* &emsp; \| &emsp; public static SyntaxNode FirstAncestorOrSelf\(this SyntaxNode node, SyntaxKind kind, bool ascendOutOfTrivia = true\)
* &emsp; \| &emsp; public static SyntaxNode FirstAncestorOrSelf\(this SyntaxNode node, Func\<SyntaxNode, bool> predicate, bool ascendOutOfTrivia = true\)
* &emsp; \| &emsp; public static SyntaxNode FirstAncestorOrSelf\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2, bool ascendOutOfTrivia = true\)
* &emsp; \| &emsp; public static SyntaxNode FirstAncestorOrSelf\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, bool ascendOutOfTrivia = true\)
* &emsp; \| &emsp; public static IfStatementCascadeInfo GetCascadeInfo\(this IfStatementSyntax ifStatement\)
* &emsp; \| &emsp; public static DocumentationCommentTriviaSyntax GetDocumentationComment\(this MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static SyntaxTrivia GetDocumentationCommentTrivia\(this MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static EndRegionDirectiveTriviaSyntax GetEndRegionDirective\(this RegionDirectiveTriviaSyntax regionDirective\)
* &emsp; \| &emsp; public static DirectiveTriviaSyntax GetFirstDirective\(this SyntaxNode node, TextSpan span, Func\<DirectiveTriviaSyntax, bool> predicate = null\)
* &emsp; \| &emsp; public static DirectiveTriviaSyntax GetNextRelatedDirective\(this DirectiveTriviaSyntax directiveTrivia\)
* &emsp; \| &emsp; public static SyntaxTrivia GetPreprocessingMessageTrivia\(this EndRegionDirectiveTriviaSyntax endRegionDirective\)
* &emsp; \| &emsp; public static SyntaxTrivia GetPreprocessingMessageTrivia\(this RegionDirectiveTriviaSyntax regionDirective\)
* &emsp; \| &emsp; public static RegionDirectiveTriviaSyntax GetRegionDirective\(this EndRegionDirectiveTriviaSyntax endRegionDirective\)
* &emsp; \| &emsp; public static DocumentationCommentTriviaSyntax GetSingleLineDocumentationComment\(this MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static SyntaxTrivia GetSingleLineDocumentationCommentTrivia\(this MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static IfStatementSyntax GetTopmostIf\(this ElseClauseSyntax elseClause\)
* &emsp; \| &emsp; public static IfStatementSyntax GetTopmostIf\(this IfStatementSyntax ifStatement\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax Getter\(this AccessorListSyntax accessorList\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax Getter\(this IndexerDeclarationSyntax indexerDeclaration\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax Getter\(this PropertyDeclarationSyntax propertyDeclaration\)
* &emsp; \| &emsp; public static bool HasDocumentationComment\(this MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static bool HasSingleLineDocumentationComment\(this MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static bool IsAutoImplemented\(this AccessorDeclarationSyntax accessorDeclaration\)
* &emsp; \| &emsp; public static bool IsDescendantOf\(this SyntaxNode node, SyntaxKind kind, bool ascendOutOfTrivia = true\)
* &emsp; \| &emsp; public static bool IsEmbedded\(this StatementSyntax statement, bool canBeBlock = false, bool canBeIfInsideElse = true, bool canBeUsingInsideUsing = true\)
* &emsp; \| &emsp; public static bool IsEmptyOrWhitespace\(this SyntaxTriviaList triviaList\)
* &emsp; \| &emsp; public static bool IsEndOfLineTrivia\(this SyntaxTrivia trivia\)
* &emsp; \| &emsp; public static bool IsHexNumericLiteral\(this LiteralExpressionSyntax literalExpression\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxToken token, SyntaxKind kind1, SyntaxKind kind2\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxTrivia trivia, SyntaxKind kind1, SyntaxKind kind2\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxToken token, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxTrivia trivia, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxToken token, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxTrivia trivia, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxToken token, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxTrivia trivia, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5, SyntaxKind kind6\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxToken token, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5, SyntaxKind kind6\)
* &emsp; \| &emsp; public static bool IsKind\(this SyntaxTrivia trivia, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5, SyntaxKind kind6\)
* &emsp; \| &emsp; public static bool IsLast\(this SyntaxList\<StatementSyntax> statements, StatementSyntax statement, bool ignoreLocalFunctions\)
* &emsp; \| &emsp; public static bool IsParams\(this ParameterSyntax parameter\)
* &emsp; \| &emsp; public static bool IsParentKind\(this SyntaxNode node, SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsParentKind\(this SyntaxToken token, SyntaxKind kind\)
* &emsp; \| &emsp; public static bool IsParentKind\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2\)
* &emsp; \| &emsp; public static bool IsParentKind\(this SyntaxToken token, SyntaxKind kind1, SyntaxKind kind2\)
* &emsp; \| &emsp; public static bool IsParentKind\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3\)
* &emsp; \| &emsp; public static bool IsParentKind\(this SyntaxToken token, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3\)
* &emsp; \| &emsp; public static bool IsParentKind\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4\)
* &emsp; \| &emsp; public static bool IsParentKind\(this SyntaxToken token, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4\)
* &emsp; \| &emsp; public static bool IsParentKind\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5\)
* &emsp; \| &emsp; public static bool IsParentKind\(this SyntaxToken token, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5\)
* &emsp; \| &emsp; public static bool IsParentKind\(this SyntaxNode node, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5, SyntaxKind kind6\)
* &emsp; \| &emsp; public static bool IsParentKind\(this SyntaxToken token, SyntaxKind kind1, SyntaxKind kind2, SyntaxKind kind3, SyntaxKind kind4, SyntaxKind kind5, SyntaxKind kind6\)
* &emsp; \| &emsp; public static bool IsSimpleIf\(this IfStatementSyntax ifStatement\)
* &emsp; \| &emsp; public static bool IsTopmostIf\(this IfStatementSyntax ifStatement\)
* &emsp; \| &emsp; public static bool IsVerbatim\(this InterpolatedStringExpressionSyntax interpolatedString\)
* &emsp; \| &emsp; public static bool IsVoid\(this TypeSyntax type\)
* &emsp; \| &emsp; public static bool IsWhitespaceOrEndOfLineTrivia\(this SyntaxTrivia trivia\)
* &emsp; \| &emsp; public static bool IsWhitespaceTrivia\(this SyntaxTrivia trivia\)
* &emsp; \| &emsp; public static bool IsYieldBreak\(this YieldStatementSyntax yieldStatement\)
* &emsp; \| &emsp; public static bool IsYieldReturn\(this YieldStatementSyntax yieldStatement\)
* &emsp; \| &emsp; public static int LastIndexOf\(this SyntaxTriviaList triviaList, SyntaxKind kind\)
* &emsp; \| &emsp; public static int LastIndexOf\<TNode>\(this SeparatedSyntaxList\<TNode> list, SyntaxKind kind\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static int LastIndexOf\<TNode>\(this SyntaxList\<TNode> list, SyntaxKind kind\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static StatementSyntax NextStatement\(this StatementSyntax statement\)
* &emsp; \| &emsp; public static TextSpan ParenthesesSpan\(this CastExpressionSyntax castExpression\)
* &emsp; \| &emsp; public static TextSpan ParenthesesSpan\(this CommonForEachStatementSyntax forEachStatement\)
* &emsp; \| &emsp; public static TextSpan ParenthesesSpan\(this ForStatementSyntax forStatement\)
* &emsp; \| &emsp; public static StatementSyntax PreviousStatement\(this StatementSyntax statement\)
* &emsp; \| &emsp; public static SyntaxTokenList RemoveRange\(this SyntaxTokenList list, int index, int count\)
* &emsp; \| &emsp; public static SyntaxTriviaList RemoveRange\(this SyntaxTriviaList list, int index, int count\)
* &emsp; \| &emsp; public static SeparatedSyntaxList\<TNode> RemoveRange\<TNode>\(this SeparatedSyntaxList\<TNode> list, int index, int count\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxList\<TNode> RemoveRange\<TNode>\(this SyntaxList\<TNode> list, int index, int count\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode RemoveTrivia\<TNode>\(this TNode node, TextSpan? span = null\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode RemoveWhitespace\<TNode>\(this TNode node, TextSpan? span = null\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxTokenList ReplaceRange\(this SyntaxTokenList list, int index, int count, IEnumerable\<SyntaxToken> newTokens\)
* &emsp; \| &emsp; public static SyntaxTriviaList ReplaceRange\(this SyntaxTriviaList list, int index, int count, IEnumerable\<SyntaxTrivia> newTrivia\)
* &emsp; \| &emsp; public static SeparatedSyntaxList\<TNode> ReplaceRange\<TNode>\(this SeparatedSyntaxList\<TNode> list, int index, int count, IEnumerable\<TNode> newNodes\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxList\<TNode> ReplaceRange\<TNode>\(this SyntaxList\<TNode> list, int index, int count, IEnumerable\<TNode> newNodes\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static TNode ReplaceWhitespace\<TNode>\(this TNode node, SyntaxTrivia replacement, TextSpan? span = null\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool ReturnsVoid\(this DelegateDeclarationSyntax delegateDeclaration\)
* &emsp; \| &emsp; public static bool ReturnsVoid\(this LocalFunctionStatementSyntax localFunctionStatement\)
* &emsp; \| &emsp; public static bool ReturnsVoid\(this MethodDeclarationSyntax methodDeclaration\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax Setter\(this AccessorListSyntax accessorList\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax Setter\(this IndexerDeclarationSyntax indexerDeclaration\)
* &emsp; \| &emsp; public static AccessorDeclarationSyntax Setter\(this PropertyDeclarationSyntax propertyDeclaration\)
* &emsp; \| &emsp; public static SeparatedSyntaxList\<TNode> ToSeparatedSyntaxList\<TNode>\(this IEnumerable\<TNode> nodes\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SeparatedSyntaxList\<TNode> ToSeparatedSyntaxList\<TNode>\(this IEnumerable\<SyntaxNodeOrToken> nodesAndTokens\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxList\<TNode> ToSyntaxList\<TNode>\(this IEnumerable\<TNode> nodes\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxTokenList ToSyntaxTokenList\(this IEnumerable\<SyntaxToken> tokens\)
* &emsp; \| &emsp; public static SyntaxToken TrimLeadingTrivia\(this SyntaxToken token\)
* &emsp; \| &emsp; public static TNode TrimLeadingTrivia\<TNode>\(this TNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxToken TrimTrailingTrivia\(this SyntaxToken token\)
* &emsp; \| &emsp; public static TNode TrimTrailingTrivia\<TNode>\(this TNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxToken TrimTrivia\(this SyntaxToken token\)
* &emsp; \| &emsp; public static TNode TrimTrivia\<TNode>\(this TNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static bool TryGetContainingList\(this StatementSyntax statement, out SyntaxList\<StatementSyntax> statements\)
* &emsp; \| &emsp; public static ExpressionSyntax WalkDownParentheses\(this ExpressionSyntax expression\)
* &emsp; \| &emsp; public static ExpressionSyntax WalkUpParentheses\(this ExpressionSyntax expression\)
* &emsp; \| &emsp; public static ClassDeclarationSyntax WithMembers\(this ClassDeclarationSyntax classDeclaration, MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static ClassDeclarationSyntax WithMembers\(this ClassDeclarationSyntax classDeclaration, IEnumerable\<MemberDeclarationSyntax> members\)
* &emsp; \| &emsp; public static CompilationUnitSyntax WithMembers\(this CompilationUnitSyntax compilationUnit, MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static CompilationUnitSyntax WithMembers\(this CompilationUnitSyntax compilationUnit, IEnumerable\<MemberDeclarationSyntax> members\)
* &emsp; \| &emsp; public static InterfaceDeclarationSyntax WithMembers\(this InterfaceDeclarationSyntax interfaceDeclaration, MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static InterfaceDeclarationSyntax WithMembers\(this InterfaceDeclarationSyntax interfaceDeclaration, IEnumerable\<MemberDeclarationSyntax> members\)
* &emsp; \| &emsp; public static NamespaceDeclarationSyntax WithMembers\(this NamespaceDeclarationSyntax namespaceDeclaration, MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static NamespaceDeclarationSyntax WithMembers\(this NamespaceDeclarationSyntax namespaceDeclaration, IEnumerable\<MemberDeclarationSyntax> members\)
* &emsp; \| &emsp; public static StructDeclarationSyntax WithMembers\(this StructDeclarationSyntax structDeclaration, MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public static StructDeclarationSyntax WithMembers\(this StructDeclarationSyntax structDeclaration, IEnumerable\<MemberDeclarationSyntax> members\)
* &emsp; public static class SyntaxInfo
* &emsp; \| &emsp; public static AsExpressionInfo AsExpressionInfo\(BinaryExpressionSyntax binaryExpression, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static AsExpressionInfo AsExpressionInfo\(SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static AssignmentExpressionInfo AssignmentExpressionInfo\(AssignmentExpressionSyntax assignmentExpression, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static AssignmentExpressionInfo AssignmentExpressionInfo\(SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static BinaryExpressionInfo BinaryExpressionInfo\(BinaryExpressionSyntax binaryExpression, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static BinaryExpressionInfo BinaryExpressionInfo\(SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static ConditionalExpressionInfo ConditionalExpressionInfo\(ConditionalExpressionSyntax conditionalExpression, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static ConditionalExpressionInfo ConditionalExpressionInfo\(SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static GenericInfo GenericInfo\(TypeParameterConstraintClauseSyntax constraintClause\)
* &emsp; \| &emsp; public static GenericInfo GenericInfo\(DelegateDeclarationSyntax delegateDeclaration\)
* &emsp; \| &emsp; public static GenericInfo GenericInfo\(LocalFunctionStatementSyntax localFunctionStatement\)
* &emsp; \| &emsp; public static GenericInfo GenericInfo\(MethodDeclarationSyntax methodDeclaration\)
* &emsp; \| &emsp; public static GenericInfo GenericInfo\(SyntaxNode node\)
* &emsp; \| &emsp; public static GenericInfo GenericInfo\(TypeDeclarationSyntax typeDeclaration\)
* &emsp; \| &emsp; public static GenericInfo GenericInfo\(TypeParameterSyntax typeParameter\)
* &emsp; \| &emsp; public static GenericInfo GenericInfo\(TypeParameterConstraintSyntax typeParameterConstraint\)
* &emsp; \| &emsp; public static GenericInfo GenericInfo\(TypeParameterListSyntax typeParameterList\)
* &emsp; \| &emsp; public static IsExpressionInfo IsExpressionInfo\(BinaryExpressionSyntax binaryExpression, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static IsExpressionInfo IsExpressionInfo\(SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static LocalDeclarationStatementInfo LocalDeclarationStatementInfo\(LocalDeclarationStatementSyntax localDeclarationStatement, bool allowMissing = false\)
* &emsp; \| &emsp; public static LocalDeclarationStatementInfo LocalDeclarationStatementInfo\(ExpressionSyntax value, bool allowMissing = false\)
* &emsp; \| &emsp; public static MemberDeclarationListInfo MemberDeclarationListInfo\(CompilationUnitSyntax compilationUnit\)
* &emsp; \| &emsp; public static MemberDeclarationListInfo MemberDeclarationListInfo\(NamespaceDeclarationSyntax declaration\)
* &emsp; \| &emsp; public static MemberDeclarationListInfo MemberDeclarationListInfo\(TypeDeclarationSyntax declaration\)
* &emsp; \| &emsp; public static MemberDeclarationListInfo MemberDeclarationListInfo\(ClassDeclarationSyntax declaration\)
* &emsp; \| &emsp; public static MemberDeclarationListInfo MemberDeclarationListInfo\(StructDeclarationSyntax declaration\)
* &emsp; \| &emsp; public static MemberDeclarationListInfo MemberDeclarationListInfo\(InterfaceDeclarationSyntax declaration\)
* &emsp; \| &emsp; public static MemberDeclarationListInfo MemberDeclarationListInfo\(SyntaxNode node\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(AccessorDeclarationSyntax accessorDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(ClassDeclarationSyntax classDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(ConstructorDeclarationSyntax constructorDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(ConversionOperatorDeclarationSyntax conversionOperatorDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(DelegateDeclarationSyntax delegateDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(DestructorDeclarationSyntax destructorDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(EnumDeclarationSyntax enumDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(EventDeclarationSyntax eventDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(EventFieldDeclarationSyntax eventFieldDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(FieldDeclarationSyntax fieldDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(IncompleteMemberSyntax incompleteMember\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(IndexerDeclarationSyntax indexerDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(InterfaceDeclarationSyntax interfaceDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(LocalDeclarationStatementSyntax localDeclarationStatement\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(LocalFunctionStatementSyntax localFunctionStatement\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(MethodDeclarationSyntax methodDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(SyntaxNode node\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(OperatorDeclarationSyntax operatorDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(ParameterSyntax parameter\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(PropertyDeclarationSyntax propertyDeclaration\)
* &emsp; \| &emsp; public static ModifierListInfo ModifierListInfo\(StructDeclarationSyntax structDeclaration\)
* &emsp; \| &emsp; public static NullCheckExpressionInfo NullCheckExpressionInfo\(SyntaxNode node, NullCheckStyles allowedStyles = ComparisonToNull \| IsPattern, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static NullCheckExpressionInfo NullCheckExpressionInfo\(SyntaxNode node, SemanticModel semanticModel, NullCheckStyles allowedStyles = All, bool walkDownParentheses = true, bool allowMissing = false, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static RegionInfo RegionInfo\(EndRegionDirectiveTriviaSyntax endRegionDirective\)
* &emsp; \| &emsp; public static RegionInfo RegionInfo\(RegionDirectiveTriviaSyntax regionDirective\)
* &emsp; \| &emsp; public static SimpleAssignmentExpressionInfo SimpleAssignmentExpressionInfo\(AssignmentExpressionSyntax assignmentExpression, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static SimpleAssignmentExpressionInfo SimpleAssignmentExpressionInfo\(SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static SimpleAssignmentStatementInfo SimpleAssignmentStatementInfo\(AssignmentExpressionSyntax assignmentExpression, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static SimpleAssignmentStatementInfo SimpleAssignmentStatementInfo\(ExpressionStatementSyntax expressionStatement, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static SimpleAssignmentStatementInfo SimpleAssignmentStatementInfo\(StatementSyntax statement, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static SimpleIfElseInfo SimpleIfElseInfo\(IfStatementSyntax ifStatement, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static SimpleIfStatementInfo SimpleIfStatementInfo\(IfStatementSyntax ifStatement, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static SimpleIfStatementInfo SimpleIfStatementInfo\(SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static SimpleMemberInvocationExpressionInfo SimpleMemberInvocationExpressionInfo\(InvocationExpressionSyntax invocationExpression, bool allowMissing = false\)
* &emsp; \| &emsp; public static SimpleMemberInvocationExpressionInfo SimpleMemberInvocationExpressionInfo\(SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static SimpleMemberInvocationStatementInfo SimpleMemberInvocationStatementInfo\(ExpressionStatementSyntax expressionStatement, bool allowMissing = false\)
* &emsp; \| &emsp; public static SimpleMemberInvocationStatementInfo SimpleMemberInvocationStatementInfo\(InvocationExpressionSyntax invocationExpression, bool allowMissing = false\)
* &emsp; \| &emsp; public static SimpleMemberInvocationStatementInfo SimpleMemberInvocationStatementInfo\(SyntaxNode node, bool allowMissing = false\)
* &emsp; \| &emsp; public static SingleLocalDeclarationStatementInfo SingleLocalDeclarationStatementInfo\(ExpressionSyntax value\)
* &emsp; \| &emsp; public static SingleLocalDeclarationStatementInfo SingleLocalDeclarationStatementInfo\(LocalDeclarationStatementSyntax localDeclarationStatement, bool allowMissing = false\)
* &emsp; \| &emsp; public static SingleLocalDeclarationStatementInfo SingleLocalDeclarationStatementInfo\(VariableDeclarationSyntax variableDeclaration, bool allowMissing = false\)
* &emsp; \| &emsp; public static SingleParameterLambdaExpressionInfo SingleParameterLambdaExpressionInfo\(LambdaExpressionSyntax lambdaExpression, bool allowMissing = false\)
* &emsp; \| &emsp; public static SingleParameterLambdaExpressionInfo SingleParameterLambdaExpressionInfo\(SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false\)
* &emsp; \| &emsp; public static StatementListInfo StatementListInfo\(StatementSyntax statement\)
* &emsp; \| &emsp; public static StringConcatenationExpressionInfo StringConcatenationExpressionInfo\(BinaryExpressionSyntax binaryExpression, SemanticModel semanticModel, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static StringConcatenationExpressionInfo StringConcatenationExpressionInfo\(in ExpressionChain expressionChain, SemanticModel semanticModel, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static StringConcatenationExpressionInfo StringConcatenationExpressionInfo\(SyntaxNode node, SemanticModel semanticModel, bool walkDownParentheses = true, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static StringLiteralExpressionInfo StringLiteralExpressionInfo\(LiteralExpressionSyntax literalExpression\)
* &emsp; \| &emsp; public static StringLiteralExpressionInfo StringLiteralExpressionInfo\(SyntaxNode node, bool walkDownParentheses = true\)
* &emsp; \| &emsp; public static UsingDirectiveListInfo UsingDirectiveListInfo\(CompilationUnitSyntax compilationUnit\)
* &emsp; \| &emsp; public static UsingDirectiveListInfo UsingDirectiveListInfo\(NamespaceDeclarationSyntax declaration\)
* &emsp; \| &emsp; public static UsingDirectiveListInfo UsingDirectiveListInfo\(SyntaxNode node\)
* &emsp; \| &emsp; public static XmlElementInfo XmlElementInfo\(XmlNodeSyntax xmlNode\)
* &emsp; public static class SyntaxInverter
* &emsp; \| &emsp; public static ExpressionSyntax LogicallyInvert\(ExpressionSyntax expression, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static ExpressionSyntax LogicallyInvert\(ExpressionSyntax expression, SemanticModel semanticModel, CancellationToken cancellationToken = default\)
* &emsp; public static class WorkspaceExtensions
* &emsp; \| &emsp; public static Task\<Document> RemoveCommentsAsync\(this Document document, CommentKinds kinds, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> RemoveCommentsAsync\(this Document document, TextSpan span, CommentKinds kinds, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> RemovePreprocessorDirectivesAsync\(this Document document, PreprocessorDirectiveKinds directiveKinds, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> RemovePreprocessorDirectivesAsync\(this Document document, TextSpan span, PreprocessorDirectiveKinds directiveKinds, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> RemoveRegionAsync\(this Document document, RegionInfo region, CancellationToken cancellationToken = default\)
* &emsp; \| &emsp; public static Task\<Document> RemoveTriviaAsync\(this Document document, TextSpan span, CancellationToken cancellationToken = default\)
* &emsp; public static class WorkspaceSyntaxExtensions
* &emsp; \| &emsp; public static ParenthesizedExpressionSyntax Parenthesize\(this ExpressionSyntax expression, bool includeElasticTrivia = true, bool simplifiable = true\)
* &emsp; \| &emsp; public static SyntaxToken WithFormatterAnnotation\(this SyntaxToken token\)
* &emsp; \| &emsp; public static TNode WithFormatterAnnotation\<TNode>\(this TNode node\) where TNode : SyntaxNode
* &emsp; \| &emsp; public static SyntaxToken WithRenameAnnotation\(this SyntaxToken token\)
* &emsp; \| &emsp; public static SyntaxToken WithSimplifierAnnotation\(this SyntaxToken token\)
* &emsp; \| &emsp; public static TNode WithSimplifierAnnotation\<TNode>\(this TNode node\) where TNode : SyntaxNode
* &emsp; public readonly struct ExpressionChain : IEnumerable\<ExpressionSyntax>, IEquatable\<ExpressionChain>
* &emsp; \| &emsp; public BinaryExpressionSyntax BinaryExpression \{ get; \}
* &emsp; \| &emsp; public TextSpan? Span \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(ExpressionChain other\)
* &emsp; \| &emsp; public ExpressionChain\.Enumerator GetEnumerator\(\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public ExpressionChain\.Reversed Reverse\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in ExpressionChain info1, in ExpressionChain info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in ExpressionChain info1, in ExpressionChain info2\)
* &emsp; \| &emsp; public struct Enumerator
* &emsp; \| &emsp; \| &emsp; public ExpressionSyntax Current \{ get; \}
* &emsp; \| &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; \| &emsp; public bool MoveNext\(\)
* &emsp; \| &emsp; \| &emsp; public void Reset\(\)
* &emsp; \| &emsp; public readonly struct Reversed : IEnumerable\<ExpressionSyntax>, IEquatable\<ExpressionChain\.Reversed>
* &emsp; \| &emsp; \| &emsp; public Reversed\(in ExpressionChain chain\)
* &emsp; \| &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; \| &emsp; public bool Equals\(ExpressionChain\.Reversed other\)
* &emsp; \| &emsp; \| &emsp; public ExpressionChain\.Reversed\.Enumerator GetEnumerator\(\)
* &emsp; \| &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; \| &emsp; public static bool operator ==\(in ExpressionChain\.Reversed reversed1, in ExpressionChain\.Reversed reversed2\)
* &emsp; \| &emsp; \| &emsp; public static bool operator \!=\(in ExpressionChain\.Reversed reversed1, in ExpressionChain\.Reversed reversed2\)
* &emsp; \| &emsp; \| &emsp; public struct Enumerator
* &emsp; \| &emsp; \| &emsp; \| &emsp; public ExpressionSyntax Current \{ get; \}
* &emsp; \| &emsp; \| &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; \| &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; \| &emsp; \| &emsp; public bool MoveNext\(\)
* &emsp; \| &emsp; \| &emsp; \| &emsp; public void Reset\(\)
* &emsp; public readonly struct IfStatementCascade : IEnumerable\<IfStatementOrElseClause>, IEquatable\<IfStatementCascade>
* &emsp; \| &emsp; public IfStatementSyntax IfStatement \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(IfStatementCascade other\)
* &emsp; \| &emsp; public IfStatementCascade\.Enumerator GetEnumerator\(\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in IfStatementCascade cascade1, in IfStatementCascade cascade2\)
* &emsp; \| &emsp; public static bool operator \!=\(in IfStatementCascade cascade1, in IfStatementCascade cascade2\)
* &emsp; \| &emsp; public struct Enumerator
* &emsp; \| &emsp; \| &emsp; public IfStatementOrElseClause Current \{ get; \}
* &emsp; \| &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; \| &emsp; public bool MoveNext\(\)
* &emsp; \| &emsp; \| &emsp; public void Reset\(\)
* &emsp; public readonly struct IfStatementCascadeInfo : IEquatable\<IfStatementCascadeInfo>
* &emsp; \| &emsp; public IfStatementCascadeInfo\(IfStatementSyntax ifStatement\)
* &emsp; \| &emsp; public int Count \{ get; \}
* &emsp; \| &emsp; public bool EndsWithElse \{ get; \}
* &emsp; \| &emsp; public bool EndsWithIf \{ get; \}
* &emsp; \| &emsp; public IfStatementSyntax IfStatement \{ get; \}
* &emsp; \| &emsp; public bool IsSimpleIf \{ get; \}
* &emsp; \| &emsp; public bool IsSimpleIfElse \{ get; \}
* &emsp; \| &emsp; public IfStatementOrElseClause Last \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(IfStatementCascadeInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in IfStatementCascadeInfo info1, in IfStatementCascadeInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in IfStatementCascadeInfo info1, in IfStatementCascadeInfo info2\)
* &emsp; public readonly struct IfStatementOrElseClause : IEquatable\<IfStatementOrElseClause>
* &emsp; \| &emsp; public IfStatementOrElseClause\(ElseClauseSyntax elseClause\)
* &emsp; \| &emsp; public IfStatementOrElseClause\(IfStatementSyntax ifStatement\)
* &emsp; \| &emsp; public TextSpan FullSpan \{ get; \}
* &emsp; \| &emsp; public bool IsElse \{ get; \}
* &emsp; \| &emsp; public bool IsIf \{ get; \}
* &emsp; \| &emsp; public SyntaxKind Kind \{ get; \}
* &emsp; \| &emsp; public SyntaxNode Parent \{ get; \}
* &emsp; \| &emsp; public TextSpan Span \{ get; \}
* &emsp; \| &emsp; public StatementSyntax Statement \{ get; \}
* &emsp; \| &emsp; public ElseClauseSyntax AsElse\(\)
* &emsp; \| &emsp; public IfStatementSyntax AsIf\(\)
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(IfStatementOrElseClause other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static implicit operator IfStatementOrElseClause\(IfStatementSyntax ifStatement\)
* &emsp; \| &emsp; public static implicit operator IfStatementSyntax\(in IfStatementOrElseClause ifOrElse\)
* &emsp; \| &emsp; public static implicit operator IfStatementOrElseClause\(ElseClauseSyntax elseClause\)
* &emsp; \| &emsp; public static implicit operator ElseClauseSyntax\(in IfStatementOrElseClause ifOrElse\)
* &emsp; \| &emsp; public static bool operator ==\(in IfStatementOrElseClause left, in IfStatementOrElseClause right\)
* &emsp; \| &emsp; public static bool operator \!=\(in IfStatementOrElseClause left, in IfStatementOrElseClause right\)
* &emsp; \[Flags\] public enum CommentKinds
* &emsp; \| &emsp; None = 0
* &emsp; \| &emsp; SingleLine = 1
* &emsp; \| &emsp; MultiLine = 2
* &emsp; \| &emsp; NonDocumentation = SingleLine \| MultiLine
* &emsp; \| &emsp; SingleLineDocumentation = 4
* &emsp; \| &emsp; MultiLineDocumentation = 8
* &emsp; \| &emsp; Documentation = SingleLineDocumentation \| MultiLineDocumentation
* &emsp; \| &emsp; All = NonDocumentation \| Documentation
* &emsp; \[Flags\] public enum ModifierKinds
* &emsp; \| &emsp; None = 0
* &emsp; \| &emsp; New = 1
* &emsp; \| &emsp; Public = 2
* &emsp; \| &emsp; Private = 4
* &emsp; \| &emsp; Protected = 8
* &emsp; \| &emsp; Internal = 16
* &emsp; \| &emsp; Accessibility = Public \| Private \| Protected \| Internal
* &emsp; \| &emsp; Const = 32
* &emsp; \| &emsp; Static = 64
* &emsp; \| &emsp; Virtual = 128
* &emsp; \| &emsp; Sealed = 256
* &emsp; \| &emsp; Override = 512
* &emsp; \| &emsp; Abstract = 1024
* &emsp; \| &emsp; AbstractVirtualOverride = Virtual \| Override \| Abstract
* &emsp; \| &emsp; ReadOnly = 2048
* &emsp; \| &emsp; Extern = 4096
* &emsp; \| &emsp; Unsafe = 8192
* &emsp; \| &emsp; Volatile = 16384
* &emsp; \| &emsp; Async = 32768
* &emsp; \| &emsp; Partial = 65536
* &emsp; \| &emsp; Ref = 131072
* &emsp; \| &emsp; Out = 262144
* &emsp; \| &emsp; In = 524288
* &emsp; \| &emsp; Params = 1048576
* &emsp; \| &emsp; This = 2097152
* &emsp; \[Flags\] public enum NullCheckStyles
* &emsp; \| &emsp; None = 0
* &emsp; \| &emsp; EqualsToNull = 1
* &emsp; \| &emsp; NotEqualsToNull = 2
* &emsp; \| &emsp; ComparisonToNull = EqualsToNull \| NotEqualsToNull
* &emsp; \| &emsp; IsNull = 4
* &emsp; \| &emsp; NotIsNull = 8
* &emsp; \| &emsp; IsPattern = IsNull \| NotIsNull
* &emsp; \| &emsp; NotHasValue = 16
* &emsp; \| &emsp; CheckingNull = EqualsToNull \| IsNull \| NotHasValue
* &emsp; \| &emsp; HasValue = 32
* &emsp; \| &emsp; CheckingNotNull = NotEqualsToNull \| NotIsNull \| HasValue
* &emsp; \| &emsp; HasValueProperty = NotHasValue \| HasValue
* &emsp; \| &emsp; All = ComparisonToNull \| IsPattern \| HasValueProperty
* &emsp; \[Flags\] public enum PreprocessorDirectiveKinds
* &emsp; \| &emsp; None = 0
* &emsp; \| &emsp; If = 1
* &emsp; \| &emsp; Elif = 2
* &emsp; \| &emsp; Else = 4
* &emsp; \| &emsp; EndIf = 8
* &emsp; \| &emsp; Region = 16
* &emsp; \| &emsp; EndRegion = 32
* &emsp; \| &emsp; Define = 64
* &emsp; \| &emsp; Undef = 128
* &emsp; \| &emsp; Error = 256
* &emsp; \| &emsp; Warning = 512
* &emsp; \| &emsp; Line = 1024
* &emsp; \| &emsp; PragmaWarning = 2048
* &emsp; \| &emsp; PragmaChecksum = 4096
* &emsp; \| &emsp; Pragma = PragmaWarning \| PragmaChecksum
* &emsp; \| &emsp; Reference = 8192
* &emsp; \| &emsp; Load = 16384
* &emsp; \| &emsp; Bad = 32768
* &emsp; \| &emsp; Shebang = 65536
* &emsp; \| &emsp; All = If \| Elif \| Else \| EndIf \| Region \| EndRegion \| Define \| Undef \| Error \| Warning \| Line \| Pragma \| Reference \| Load \| Bad \| Shebang
* namespace Roslynator\.CSharp\.Syntax
* &emsp; public readonly struct AsExpressionInfo : IEquatable\<AsExpressionInfo>
* &emsp; \| &emsp; public BinaryExpressionSyntax AsExpression \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Expression \{ get; \}
* &emsp; \| &emsp; public SyntaxToken OperatorToken \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public TypeSyntax Type \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(AsExpressionInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in AsExpressionInfo info1, in AsExpressionInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in AsExpressionInfo info1, in AsExpressionInfo info2\)
* &emsp; public readonly struct AssignmentExpressionInfo : IEquatable\<AssignmentExpressionInfo>
* &emsp; \| &emsp; public AssignmentExpressionSyntax AssignmentExpression \{ get; \}
* &emsp; \| &emsp; public SyntaxKind Kind \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Left \{ get; \}
* &emsp; \| &emsp; public SyntaxToken OperatorToken \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Right \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(AssignmentExpressionInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in AssignmentExpressionInfo info1, in AssignmentExpressionInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in AssignmentExpressionInfo info1, in AssignmentExpressionInfo info2\)
* &emsp; public readonly struct BinaryExpressionInfo : IEquatable\<BinaryExpressionInfo>
* &emsp; \| &emsp; public BinaryExpressionSyntax BinaryExpression \{ get; \}
* &emsp; \| &emsp; public SyntaxKind Kind \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Left \{ get; \}
* &emsp; \| &emsp; public SyntaxToken OperatorToken \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Right \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public ExpressionChain AsChain\(\)
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(BinaryExpressionInfo other\)
* &emsp; \| &emsp; \[Obsolete\("This method is obsolete\. Use method 'AsChain' instead\."\)\] public IEnumerable\<ExpressionSyntax> Expressions\(bool leftToRight = false\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in BinaryExpressionInfo info1, in BinaryExpressionInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in BinaryExpressionInfo info1, in BinaryExpressionInfo info2\)
* &emsp; public readonly struct ConditionalExpressionInfo : IEquatable\<ConditionalExpressionInfo>
* &emsp; \| &emsp; public SyntaxToken ColonToken \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Condition \{ get; \}
* &emsp; \| &emsp; public ConditionalExpressionSyntax ConditionalExpression \{ get; \}
* &emsp; \| &emsp; public SyntaxToken QuestionToken \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax WhenFalse \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax WhenTrue \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(ConditionalExpressionInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in ConditionalExpressionInfo info1, in ConditionalExpressionInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in ConditionalExpressionInfo info1, in ConditionalExpressionInfo info2\)
* &emsp; public readonly struct GenericInfo : IEquatable\<GenericInfo>
* &emsp; \| &emsp; public SyntaxList\<TypeParameterConstraintClauseSyntax> ConstraintClauses \{ get; \}
* &emsp; \| &emsp; public SyntaxKind Kind \{ get; \}
* &emsp; \| &emsp; public SyntaxNode Node \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public TypeParameterListSyntax TypeParameterList \{ get; \}
* &emsp; \| &emsp; public SeparatedSyntaxList\<TypeParameterSyntax> TypeParameters \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(GenericInfo other\)
* &emsp; \| &emsp; public TypeParameterConstraintClauseSyntax FindConstraintClause\(string typeParameterName\)
* &emsp; \| &emsp; public TypeParameterSyntax FindTypeParameter\(string name\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public GenericInfo RemoveAllConstraintClauses\(\)
* &emsp; \| &emsp; public GenericInfo RemoveConstraintClause\(TypeParameterConstraintClauseSyntax constraintClause\)
* &emsp; \| &emsp; public GenericInfo RemoveTypeParameter\(TypeParameterSyntax typeParameter\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public GenericInfo WithConstraintClauses\(SyntaxList\<TypeParameterConstraintClauseSyntax> constraintClauses\)
* &emsp; \| &emsp; public GenericInfo WithTypeParameterList\(TypeParameterListSyntax typeParameterList\)
* &emsp; \| &emsp; public static bool operator ==\(in GenericInfo info1, in GenericInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in GenericInfo info1, in GenericInfo info2\)
* &emsp; public readonly struct IsExpressionInfo : IEquatable\<IsExpressionInfo>
* &emsp; \| &emsp; public ExpressionSyntax Expression \{ get; \}
* &emsp; \| &emsp; public BinaryExpressionSyntax IsExpression \{ get; \}
* &emsp; \| &emsp; public SyntaxToken OperatorToken \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public TypeSyntax Type \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(IsExpressionInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in IsExpressionInfo info1, in IsExpressionInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in IsExpressionInfo info1, in IsExpressionInfo info2\)
* &emsp; public readonly struct LocalDeclarationStatementInfo : IEquatable\<LocalDeclarationStatementInfo>
* &emsp; \| &emsp; public VariableDeclarationSyntax Declaration \{ get; \}
* &emsp; \| &emsp; public SyntaxTokenList Modifiers \{ get; \}
* &emsp; \| &emsp; public SyntaxToken SemicolonToken \{ get; \}
* &emsp; \| &emsp; public LocalDeclarationStatementSyntax Statement \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public TypeSyntax Type \{ get; \}
* &emsp; \| &emsp; public SeparatedSyntaxList\<VariableDeclaratorSyntax> Variables \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(LocalDeclarationStatementInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in LocalDeclarationStatementInfo info1, in LocalDeclarationStatementInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in LocalDeclarationStatementInfo info1, in LocalDeclarationStatementInfo info2\)
* &emsp; public readonly struct MemberDeclarationListInfo : IEquatable\<MemberDeclarationListInfo>, IReadOnlyList\<MemberDeclarationSyntax>
* &emsp; \| &emsp; public int Count \{ get; \}
* &emsp; \| &emsp; public SyntaxList\<MemberDeclarationSyntax> Members \{ get; \}
* &emsp; \| &emsp; public SyntaxNode Parent \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public MemberDeclarationSyntax this\[int index\] \{ get; \}
* &emsp; \| &emsp; public MemberDeclarationListInfo Add\(MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public MemberDeclarationListInfo AddRange\(IEnumerable\<MemberDeclarationSyntax> members\)
* &emsp; \| &emsp; public bool Any\(\)
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(MemberDeclarationListInfo other\)
* &emsp; \| &emsp; public MemberDeclarationSyntax First\(\)
* &emsp; \| &emsp; public MemberDeclarationSyntax FirstOrDefault\(\)
* &emsp; \| &emsp; public SyntaxList\<MemberDeclarationSyntax>\.Enumerator GetEnumerator\(\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public int IndexOf\(MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public int IndexOf\(Func\<MemberDeclarationSyntax, bool> predicate\)
* &emsp; \| &emsp; public MemberDeclarationListInfo Insert\(int index, MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public MemberDeclarationListInfo InsertRange\(int index, IEnumerable\<MemberDeclarationSyntax> members\)
* &emsp; \| &emsp; public MemberDeclarationSyntax Last\(\)
* &emsp; \| &emsp; public int LastIndexOf\(MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public int LastIndexOf\(Func\<MemberDeclarationSyntax, bool> predicate\)
* &emsp; \| &emsp; public MemberDeclarationSyntax LastOrDefault\(\)
* &emsp; \| &emsp; public MemberDeclarationListInfo Remove\(MemberDeclarationSyntax member\)
* &emsp; \| &emsp; public MemberDeclarationListInfo RemoveAt\(int index\)
* &emsp; \| &emsp; public MemberDeclarationListInfo RemoveNode\(SyntaxNode node, SyntaxRemoveOptions options\)
* &emsp; \| &emsp; public MemberDeclarationListInfo Replace\(MemberDeclarationSyntax memberInList, MemberDeclarationSyntax newMember\)
* &emsp; \| &emsp; public MemberDeclarationListInfo ReplaceAt\(int index, MemberDeclarationSyntax newMember\)
* &emsp; \| &emsp; public MemberDeclarationListInfo ReplaceNode\(SyntaxNode oldNode, SyntaxNode newNode\)
* &emsp; \| &emsp; public MemberDeclarationListInfo ReplaceRange\(MemberDeclarationSyntax memberInList, IEnumerable\<MemberDeclarationSyntax> newMembers\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public MemberDeclarationListInfo WithMembers\(IEnumerable\<MemberDeclarationSyntax> members\)
* &emsp; \| &emsp; public MemberDeclarationListInfo WithMembers\(SyntaxList\<MemberDeclarationSyntax> members\)
* &emsp; \| &emsp; public static bool operator ==\(in MemberDeclarationListInfo info1, in MemberDeclarationListInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in MemberDeclarationListInfo info1, in MemberDeclarationListInfo info2\)
* &emsp; public readonly struct ModifierListInfo : IEquatable\<ModifierListInfo>
* &emsp; \| &emsp; public Accessibility ExplicitAccessibility \{ get; \}
* &emsp; \| &emsp; public bool IsAbstract \{ get; \}
* &emsp; \| &emsp; public bool IsAsync \{ get; \}
* &emsp; \| &emsp; public bool IsConst \{ get; \}
* &emsp; \| &emsp; public bool IsExtern \{ get; \}
* &emsp; \| &emsp; public bool IsIn \{ get; \}
* &emsp; \| &emsp; public bool IsNew \{ get; \}
* &emsp; \| &emsp; public bool IsOut \{ get; \}
* &emsp; \| &emsp; public bool IsOverride \{ get; \}
* &emsp; \| &emsp; public bool IsParams \{ get; \}
* &emsp; \| &emsp; public bool IsPartial \{ get; \}
* &emsp; \| &emsp; public bool IsReadOnly \{ get; \}
* &emsp; \| &emsp; public bool IsRef \{ get; \}
* &emsp; \| &emsp; public bool IsSealed \{ get; \}
* &emsp; \| &emsp; public bool IsStatic \{ get; \}
* &emsp; \| &emsp; public bool IsUnsafe \{ get; \}
* &emsp; \| &emsp; public bool IsVirtual \{ get; \}
* &emsp; \| &emsp; public bool IsVolatile \{ get; \}
* &emsp; \| &emsp; public SyntaxTokenList Modifiers \{ get; \}
* &emsp; \| &emsp; public SyntaxNode Parent \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(ModifierListInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public ModifierKinds GetKinds\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public ModifierListInfo WithExplicitAccessibility\(Accessibility newAccessibility, IComparer\<SyntaxKind> comparer = null\)
* &emsp; \| &emsp; public ModifierListInfo WithModifiers\(SyntaxTokenList modifiers\)
* &emsp; \| &emsp; public ModifierListInfo WithoutExplicitAccessibility\(\)
* &emsp; \| &emsp; public static bool operator ==\(in ModifierListInfo info1, in ModifierListInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in ModifierListInfo info1, in ModifierListInfo info2\)
* &emsp; public readonly struct NullCheckExpressionInfo : IEquatable\<NullCheckExpressionInfo>
* &emsp; \| &emsp; public ExpressionSyntax Expression \{ get; \}
* &emsp; \| &emsp; public bool IsCheckingNotNull \{ get; \}
* &emsp; \| &emsp; public bool IsCheckingNull \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax NullCheckExpression \{ get; \}
* &emsp; \| &emsp; public NullCheckStyles Style \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(NullCheckExpressionInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in NullCheckExpressionInfo info1, in NullCheckExpressionInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in NullCheckExpressionInfo info1, in NullCheckExpressionInfo info2\)
* &emsp; public readonly struct RegionInfo : IEquatable\<RegionInfo>
* &emsp; \| &emsp; public RegionDirectiveTriviaSyntax Directive \{ get; \}
* &emsp; \| &emsp; public EndRegionDirectiveTriviaSyntax EndDirective \{ get; \}
* &emsp; \| &emsp; public TextSpan FullSpan \{ get; \}
* &emsp; \| &emsp; public bool IsEmpty \{ get; \}
* &emsp; \| &emsp; public TextSpan Span \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(RegionInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in RegionInfo info1, in RegionInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in RegionInfo info1, in RegionInfo info2\)
* &emsp; public readonly struct SimpleAssignmentExpressionInfo : IEquatable\<SimpleAssignmentExpressionInfo>
* &emsp; \| &emsp; public AssignmentExpressionSyntax AssignmentExpression \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Left \{ get; \}
* &emsp; \| &emsp; public SyntaxToken OperatorToken \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Right \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(SimpleAssignmentExpressionInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in SimpleAssignmentExpressionInfo info1, in SimpleAssignmentExpressionInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in SimpleAssignmentExpressionInfo info1, in SimpleAssignmentExpressionInfo info2\)
* &emsp; public readonly struct SimpleAssignmentStatementInfo : IEquatable\<SimpleAssignmentStatementInfo>
* &emsp; \| &emsp; public AssignmentExpressionSyntax AssignmentExpression \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Left \{ get; \}
* &emsp; \| &emsp; public SyntaxToken OperatorToken \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Right \{ get; \}
* &emsp; \| &emsp; public ExpressionStatementSyntax Statement \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(SimpleAssignmentStatementInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in SimpleAssignmentStatementInfo info1, in SimpleAssignmentStatementInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in SimpleAssignmentStatementInfo info1, in SimpleAssignmentStatementInfo info2\)
* &emsp; public readonly struct SimpleIfElseInfo : IEquatable\<SimpleIfElseInfo>
* &emsp; \| &emsp; public ExpressionSyntax Condition \{ get; \}
* &emsp; \| &emsp; public ElseClauseSyntax Else \{ get; \}
* &emsp; \| &emsp; public IfStatementSyntax IfStatement \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public StatementSyntax WhenFalse \{ get; \}
* &emsp; \| &emsp; public StatementSyntax WhenTrue \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(SimpleIfElseInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in SimpleIfElseInfo info1, in SimpleIfElseInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in SimpleIfElseInfo info1, in SimpleIfElseInfo info2\)
* &emsp; public readonly struct SimpleIfStatementInfo : IEquatable\<SimpleIfStatementInfo>
* &emsp; \| &emsp; public ExpressionSyntax Condition \{ get; \}
* &emsp; \| &emsp; public IfStatementSyntax IfStatement \{ get; \}
* &emsp; \| &emsp; public StatementSyntax Statement \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(SimpleIfStatementInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in SimpleIfStatementInfo info1, in SimpleIfStatementInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in SimpleIfStatementInfo info1, in SimpleIfStatementInfo info2\)
* &emsp; public readonly struct SimpleMemberInvocationExpressionInfo : IEquatable\<SimpleMemberInvocationExpressionInfo>
* &emsp; \| &emsp; public ArgumentListSyntax ArgumentList \{ get; \}
* &emsp; \| &emsp; public SeparatedSyntaxList\<ArgumentSyntax> Arguments \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Expression \{ get; \}
* &emsp; \| &emsp; public InvocationExpressionSyntax InvocationExpression \{ get; \}
* &emsp; \| &emsp; public MemberAccessExpressionSyntax MemberAccessExpression \{ get; \}
* &emsp; \| &emsp; public SimpleNameSyntax Name \{ get; \}
* &emsp; \| &emsp; public string NameText \{ get; \}
* &emsp; \| &emsp; public SyntaxToken OperatorToken \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(SimpleMemberInvocationExpressionInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in SimpleMemberInvocationExpressionInfo info1, in SimpleMemberInvocationExpressionInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in SimpleMemberInvocationExpressionInfo info1, in SimpleMemberInvocationExpressionInfo info2\)
* &emsp; public readonly struct SimpleMemberInvocationStatementInfo : IEquatable\<SimpleMemberInvocationStatementInfo>
* &emsp; \| &emsp; public ArgumentListSyntax ArgumentList \{ get; \}
* &emsp; \| &emsp; public SeparatedSyntaxList\<ArgumentSyntax> Arguments \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Expression \{ get; \}
* &emsp; \| &emsp; public InvocationExpressionSyntax InvocationExpression \{ get; \}
* &emsp; \| &emsp; public MemberAccessExpressionSyntax MemberAccessExpression \{ get; \}
* &emsp; \| &emsp; public SimpleNameSyntax Name \{ get; \}
* &emsp; \| &emsp; public string NameText \{ get; \}
* &emsp; \| &emsp; public ExpressionStatementSyntax Statement \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(SimpleMemberInvocationStatementInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in SimpleMemberInvocationStatementInfo info1, in SimpleMemberInvocationStatementInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in SimpleMemberInvocationStatementInfo info1, in SimpleMemberInvocationStatementInfo info2\)
* &emsp; public readonly struct SingleLocalDeclarationStatementInfo : IEquatable\<SingleLocalDeclarationStatementInfo>
* &emsp; \| &emsp; public VariableDeclarationSyntax Declaration \{ get; \}
* &emsp; \| &emsp; public VariableDeclaratorSyntax Declarator \{ get; \}
* &emsp; \| &emsp; public SyntaxToken EqualsToken \{ get; \}
* &emsp; \| &emsp; public SyntaxToken Identifier \{ get; \}
* &emsp; \| &emsp; public string IdentifierText \{ get; \}
* &emsp; \| &emsp; public EqualsValueClauseSyntax Initializer \{ get; \}
* &emsp; \| &emsp; public SyntaxTokenList Modifiers \{ get; \}
* &emsp; \| &emsp; public SyntaxToken SemicolonToken \{ get; \}
* &emsp; \| &emsp; public LocalDeclarationStatementSyntax Statement \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public TypeSyntax Type \{ get; \}
* &emsp; \| &emsp; public ExpressionSyntax Value \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(SingleLocalDeclarationStatementInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in SingleLocalDeclarationStatementInfo info1, in SingleLocalDeclarationStatementInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in SingleLocalDeclarationStatementInfo info1, in SingleLocalDeclarationStatementInfo info2\)
* &emsp; public readonly struct SingleParameterLambdaExpressionInfo : IEquatable\<SingleParameterLambdaExpressionInfo>
* &emsp; \| &emsp; public CSharpSyntaxNode Body \{ get; \}
* &emsp; \| &emsp; public bool IsParenthesizedLambda \{ get; \}
* &emsp; \| &emsp; public bool IsSimpleLambda \{ get; \}
* &emsp; \| &emsp; public LambdaExpressionSyntax LambdaExpression \{ get; \}
* &emsp; \| &emsp; public ParameterSyntax Parameter \{ get; \}
* &emsp; \| &emsp; public ParameterListSyntax ParameterList \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(SingleParameterLambdaExpressionInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in SingleParameterLambdaExpressionInfo info1, in SingleParameterLambdaExpressionInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in SingleParameterLambdaExpressionInfo info1, in SingleParameterLambdaExpressionInfo info2\)
* &emsp; public readonly struct StatementListInfo : IEquatable\<StatementListInfo>, IReadOnlyList\<StatementSyntax>
* &emsp; \| &emsp; public int Count \{ get; \}
* &emsp; \| &emsp; public bool IsParentBlock \{ get; \}
* &emsp; \| &emsp; public bool IsParentSwitchSection \{ get; \}
* &emsp; \| &emsp; public SyntaxNode Parent \{ get; \}
* &emsp; \| &emsp; public BlockSyntax ParentAsBlock \{ get; \}
* &emsp; \| &emsp; public SwitchSectionSyntax ParentAsSwitchSection \{ get; \}
* &emsp; \| &emsp; public SyntaxList\<StatementSyntax> Statements \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public StatementSyntax this\[int index\] \{ get; \}
* &emsp; \| &emsp; public StatementListInfo Add\(StatementSyntax statement\)
* &emsp; \| &emsp; public StatementListInfo AddRange\(IEnumerable\<StatementSyntax> statements\)
* &emsp; \| &emsp; public bool Any\(\)
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(StatementListInfo other\)
* &emsp; \| &emsp; public StatementSyntax First\(\)
* &emsp; \| &emsp; public StatementSyntax FirstOrDefault\(\)
* &emsp; \| &emsp; public SyntaxList\<StatementSyntax>\.Enumerator GetEnumerator\(\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public int IndexOf\(Func\<StatementSyntax, bool> predicate\)
* &emsp; \| &emsp; public int IndexOf\(StatementSyntax statement\)
* &emsp; \| &emsp; public StatementListInfo Insert\(int index, StatementSyntax statement\)
* &emsp; \| &emsp; public StatementListInfo InsertRange\(int index, IEnumerable\<StatementSyntax> statements\)
* &emsp; \| &emsp; public StatementSyntax Last\(\)
* &emsp; \| &emsp; public int LastIndexOf\(Func\<StatementSyntax, bool> predicate\)
* &emsp; \| &emsp; public int LastIndexOf\(StatementSyntax statement\)
* &emsp; \| &emsp; public StatementSyntax LastOrDefault\(\)
* &emsp; \| &emsp; public StatementListInfo Remove\(StatementSyntax statement\)
* &emsp; \| &emsp; public StatementListInfo RemoveAt\(int index\)
* &emsp; \| &emsp; public StatementListInfo RemoveNode\(SyntaxNode node, SyntaxRemoveOptions options\)
* &emsp; \| &emsp; public StatementListInfo Replace\(StatementSyntax statementInList, StatementSyntax newStatement\)
* &emsp; \| &emsp; public StatementListInfo ReplaceAt\(int index, StatementSyntax newStatement\)
* &emsp; \| &emsp; public StatementListInfo ReplaceNode\(SyntaxNode oldNode, SyntaxNode newNode\)
* &emsp; \| &emsp; public StatementListInfo ReplaceRange\(StatementSyntax statementInList, IEnumerable\<StatementSyntax> newStatements\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public StatementListInfo WithStatements\(IEnumerable\<StatementSyntax> statements\)
* &emsp; \| &emsp; public StatementListInfo WithStatements\(SyntaxList\<StatementSyntax> statements\)
* &emsp; \| &emsp; public static bool operator ==\(in StatementListInfo info1, in StatementListInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in StatementListInfo info1, in StatementListInfo info2\)
* &emsp; public readonly struct StringConcatenationExpressionInfo : IEquatable\<StringConcatenationExpressionInfo>
* &emsp; \| &emsp; public BinaryExpressionSyntax BinaryExpression \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public ExpressionChain AsChain\(\)
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(StringConcatenationExpressionInfo other\)
* &emsp; \| &emsp; \[Obsolete\("This method is obsolete\. Use method 'AsChain' instead\."\)\] public IEnumerable\<ExpressionSyntax> Expressions\(bool leftToRight = false\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in StringConcatenationExpressionInfo info1, in StringConcatenationExpressionInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in StringConcatenationExpressionInfo info1, in StringConcatenationExpressionInfo info2\)
* &emsp; public readonly struct StringLiteralExpressionInfo : IEquatable\<StringLiteralExpressionInfo>
* &emsp; \| &emsp; public bool ContainsEscapeSequence \{ get; \}
* &emsp; \| &emsp; public bool ContainsLinefeed \{ get; \}
* &emsp; \| &emsp; public LiteralExpressionSyntax Expression \{ get; \}
* &emsp; \| &emsp; public string InnerText \{ get; \}
* &emsp; \| &emsp; public bool IsRegular \{ get; \}
* &emsp; \| &emsp; public bool IsVerbatim \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public string Text \{ get; \}
* &emsp; \| &emsp; public SyntaxToken Token \{ get; \}
* &emsp; \| &emsp; public string ValueText \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(StringLiteralExpressionInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in StringLiteralExpressionInfo info1, in StringLiteralExpressionInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in StringLiteralExpressionInfo info1, in StringLiteralExpressionInfo info2\)
* &emsp; public readonly struct UsingDirectiveListInfo : IEquatable\<UsingDirectiveListInfo>, IReadOnlyList\<UsingDirectiveSyntax>
* &emsp; \| &emsp; public int Count \{ get; \}
* &emsp; \| &emsp; public SyntaxNode Parent \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public SyntaxList\<UsingDirectiveSyntax> Usings \{ get; \}
* &emsp; \| &emsp; public UsingDirectiveSyntax this\[int index\] \{ get; \}
* &emsp; \| &emsp; public UsingDirectiveListInfo Add\(UsingDirectiveSyntax usingDirective\)
* &emsp; \| &emsp; public UsingDirectiveListInfo AddRange\(IEnumerable\<UsingDirectiveSyntax> usings\)
* &emsp; \| &emsp; public bool Any\(\)
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(UsingDirectiveListInfo other\)
* &emsp; \| &emsp; public UsingDirectiveSyntax First\(\)
* &emsp; \| &emsp; public UsingDirectiveSyntax FirstOrDefault\(\)
* &emsp; \| &emsp; public SyntaxList\<UsingDirectiveSyntax>\.Enumerator GetEnumerator\(\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public int IndexOf\(Func\<UsingDirectiveSyntax, bool> predicate\)
* &emsp; \| &emsp; public int IndexOf\(UsingDirectiveSyntax usingDirective\)
* &emsp; \| &emsp; public UsingDirectiveListInfo Insert\(int index, UsingDirectiveSyntax usingDirective\)
* &emsp; \| &emsp; public UsingDirectiveListInfo InsertRange\(int index, IEnumerable\<UsingDirectiveSyntax> usings\)
* &emsp; \| &emsp; public UsingDirectiveSyntax Last\(\)
* &emsp; \| &emsp; public int LastIndexOf\(Func\<UsingDirectiveSyntax, bool> predicate\)
* &emsp; \| &emsp; public int LastIndexOf\(UsingDirectiveSyntax usingDirective\)
* &emsp; \| &emsp; public UsingDirectiveSyntax LastOrDefault\(\)
* &emsp; \| &emsp; public UsingDirectiveListInfo Remove\(UsingDirectiveSyntax usingDirective\)
* &emsp; \| &emsp; public UsingDirectiveListInfo RemoveAt\(int index\)
* &emsp; \| &emsp; public UsingDirectiveListInfo RemoveNode\(SyntaxNode node, SyntaxRemoveOptions options\)
* &emsp; \| &emsp; public UsingDirectiveListInfo Replace\(UsingDirectiveSyntax usingInLine, UsingDirectiveSyntax newUsingDirective\)
* &emsp; \| &emsp; public UsingDirectiveListInfo ReplaceAt\(int index, UsingDirectiveSyntax newUsingDirective\)
* &emsp; \| &emsp; public UsingDirectiveListInfo ReplaceNode\(SyntaxNode oldNode, SyntaxNode newNode\)
* &emsp; \| &emsp; public UsingDirectiveListInfo ReplaceRange\(UsingDirectiveSyntax usingInLine, IEnumerable\<UsingDirectiveSyntax> newUsingDirectives\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public UsingDirectiveListInfo WithUsings\(IEnumerable\<UsingDirectiveSyntax> usings\)
* &emsp; \| &emsp; public UsingDirectiveListInfo WithUsings\(SyntaxList\<UsingDirectiveSyntax> usings\)
* &emsp; \| &emsp; public static bool operator ==\(in UsingDirectiveListInfo info1, in UsingDirectiveListInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in UsingDirectiveListInfo info1, in UsingDirectiveListInfo info2\)
* &emsp; public readonly struct XmlElementInfo : IEquatable\<XmlElementInfo>
* &emsp; \| &emsp; public XmlNodeSyntax Element \{ get; \}
* &emsp; \| &emsp; public bool IsEmptyElement \{ get; \}
* &emsp; \| &emsp; public SyntaxKind Kind \{ get; \}
* &emsp; \| &emsp; public string LocalName \{ get; \}
* &emsp; \| &emsp; public bool Success \{ get; \}
* &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; public bool Equals\(XmlElementInfo other\)
* &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; public override string ToString\(\)
* &emsp; \| &emsp; public static bool operator ==\(in XmlElementInfo info1, in XmlElementInfo info2\)
* &emsp; \| &emsp; public static bool operator \!=\(in XmlElementInfo info1, in XmlElementInfo info2\)
* namespace Roslynator\.Text
* &emsp; public class TextLineCollectionSelection : ISelection\<TextLine>
* &emsp; \| &emsp; protected TextLineCollectionSelection\(TextLineCollection lines, TextSpan span, int firstIndex, int lastIndex\)
* &emsp; \| &emsp; public int Count \{ get; \}
* &emsp; \| &emsp; public int FirstIndex \{ get; \}
* &emsp; \| &emsp; public int LastIndex \{ get; \}
* &emsp; \| &emsp; public TextSpan OriginalSpan \{ get; \}
* &emsp; \| &emsp; public TextLineCollection UnderlyingLines \{ get; \}
* &emsp; \| &emsp; public TextLine this\[int index\] \{ get; \}
* &emsp; \| &emsp; public static TextLineCollectionSelection Create\(TextLineCollection lines, TextSpan span\)
* &emsp; \| &emsp; public TextLine First\(\)
* &emsp; \| &emsp; public TextLineCollectionSelection\.Enumerator GetEnumerator\(\)
* &emsp; \| &emsp; public TextLine Last\(\)
* &emsp; \| &emsp; public static bool TryCreate\(TextLineCollection lines, TextSpan span, out TextLineCollectionSelection selectedLines\)
* &emsp; \| &emsp; public struct Enumerator
* &emsp; \| &emsp; \| &emsp; public TextLine Current \{ get; \}
* &emsp; \| &emsp; \| &emsp; public override bool Equals\(object obj\)
* &emsp; \| &emsp; \| &emsp; public override int GetHashCode\(\)
* &emsp; \| &emsp; \| &emsp; public bool MoveNext\(\)
* &emsp; \| &emsp; \| &emsp; public void Reset\(\)
