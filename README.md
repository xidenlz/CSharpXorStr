# C# XorStr
This C# repository provides an implementation of the XorStr (XOR string) encryption technique. The XorStr algorithm is designed to obfuscate strings by performing bitwise XOR operations on the characters with a specified key, providing a level of protection against casual inspection of the string literals in the compiled code.

The implementation includes a set of utility methods within the XorString class, allowing users to easily apply XorStr encryption to strings. Additionally, the code includes an example in the form of a console application and demonstrates how to use XorStr in a C# Windows Forms application.

This implementation is inspired by an [existing XorStr implementation](https://github.com/JustasMasiulis/xorstr/tree/master) and is tailored for usage in C# projects.

## Usage:
### C# Console 
```csharp
public class Program
{
    public static void Main()
    {
        string str = XorString.XorStr("Hello World!");
        Console.WriteLine(str);
    }
}
```
Output
```CS
????????????
```
C# Windows Forms
```CS
label1.Text = XorString.XorStr("EncryptedString");
```
Output 
```CS
肩楪櫫腆賸暘璉舰賸噼諜鼠
```
## Installation:
1. Create a new C# file in your project.
2. Copy and paste the XorString and Extensions classes.
### LICENSE:
This project is licensed under the [Apache 2.0 license](https://github.com/Mes2d/C-XorStr/blob/main/LICENSE).
