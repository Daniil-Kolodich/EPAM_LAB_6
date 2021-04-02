using _ICodeChecker;
using _ProgramConverter;
using _ProgramHelper;
using System;
namespace _InheritanceAndInterfaces {
    class Program {
        static void Main(string[] args) {
            string someCode = "code ;";
            Console.WriteLine($"Code to perform tests with : {someCode}");
            int size = 2;
            ProgramConverter[] array = new ProgramConverter[size];
            array[0] = new ProgramHelper();
            array[1] = new ProgramConverter();
            for (int i = 0; i < size; i++) {
                Console.WriteLine($"\nCurrent index of array is [{i}] : ");
                if (array[i] is ICodeChecker) {
                    Console.WriteLine("This object realize ICodeChecker");
                    
                    _IConvertible.IConvertible convertible = array[i];
                    Console.WriteLine(convertible.ConvertToCSharp(someCode) + "\n\t : Converted to CSharp");
                    Console.WriteLine(convertible.ConvertToVB(someCode) + "\n\t : Converted to VB");
                    
                    ICodeChecker codeChecker = (ICodeChecker)array[i];
                    string result = codeChecker.CheckCodeSyntax(someCode, "CSharp") switch {
                        true => "Correct code",
                        _ => "Invalid code",
                    };
                    Console.WriteLine(result + " for CSharp");
                    result = codeChecker.CheckCodeSyntax(someCode, "VB") switch {
                        true => "Correct code",
                        _ => "Invalid code",
                    };
                    Console.WriteLine(result + " for VB");
                }
                else {
                    Console.WriteLine("This object realize IConvertible");
                    
                    _IConvertible.IConvertible convertible = array[i];
                    Console.WriteLine(convertible.ConvertToCSharp(someCode) + "\n\t : Converted to CSharp");
                    Console.WriteLine(convertible.ConvertToVB(someCode) + "\n\t : Converted to VB");
                }
            }
        }
    }
}
