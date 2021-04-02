using _ICodeChecker;
using _ProgramConverter;
using System;

namespace _ProgramHelper {
    class ProgramHelper : ProgramConverter, ICodeChecker {
        bool ICodeChecker.CheckCodeSyntax(string source, string language) {
            var code = source.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return language switch {
                "CSharp" => code[^1] == ";",
                "VB" => code[^1] != ";",
                _ => false,
            };
        }
    }
}