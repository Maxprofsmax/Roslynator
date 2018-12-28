# EnumDeclarationSyntax

## Inheritance

* Object
  * SyntaxNode
    * CSharpSyntaxNode
      * [MemberDeclarationSyntax](MemberDeclarationSyntax.md)
        * [BaseTypeDeclarationSyntax](BaseTypeDeclarationSyntax.md)
          * EnumDeclarationSyntax

## Syntax Properties

| Name            | Type                                                                       |
| --------------- | -------------------------------------------------------------------------- |
| AttributeLists  | SyntaxList\<[AttributeListSyntax](AttributeListSyntax.md)>                 |
| Modifiers       | SyntaxTokenList                                                            |
| EnumKeyword     | SyntaxToken                                                                |
| Identifier      | SyntaxToken                                                                |
| BaseList        | [BaseListSyntax](BaseListSyntax.md)                                        |
| OpenBraceToken  | SyntaxToken                                                                |
| Members         | SyntaxList\<[EnumMemberDeclarationSyntax](EnumMemberDeclarationSyntax.md)> |
| CloseBraceToken | SyntaxToken                                                                |
| SemicolonToken  | SyntaxToken                                                                |

## See Also

* [Official Documentation](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.enumdeclarationsyntax)


*\(Generated with [DotMarkdown](http://github.com/JosefPihrt/DotMarkdown)\)*