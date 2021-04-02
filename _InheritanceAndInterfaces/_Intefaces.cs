namespace _IConvertible {
    interface IConvertible {
        string ConvertToCSharp(string source);
        string ConvertToVB(string source);
    }
}
namespace _ICodeChecker {
    interface ICodeChecker {
        bool CheckCodeSyntax(string source, string language);
    }
}