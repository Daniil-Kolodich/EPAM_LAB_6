using System;

namespace _ProgramConverter {
    class ProgramConverter : _IConvertible.IConvertible {
        string _IConvertible.IConvertible.ConvertToCSharp(string source) {
            var tmp = source.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return tmp[^1] switch {
                ";" => source,
                _ => string.Join(' ', tmp) + ";",
            };
        }
        string _IConvertible.IConvertible.ConvertToVB(string source) {
            var tmp = source.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return tmp[^1] switch {
                ";" => string.Join(' ', tmp[..^1]),
                _ => source,
            };
        }
    }
}