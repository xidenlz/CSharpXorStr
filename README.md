# C# XorStr

Since I couldn't find a good way to use XorStr in C#, I made this. It's based on [this implementation](https://github.com/JustasMasiulis/xorstr/tree/master).

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
