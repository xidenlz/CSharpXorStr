# C# XorStr
Since I couldn't find a good way to use XorStr in C# i made this, it's based on this one 
https://github.com/JustasMasiulis/xorstr/tree/master


## Usage ⚙
C# Console 
```CS
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
## Installation 🤞
1. Make new cs file in your project
2. copy and paste XorString and Extensions classes 
### LICENSE:
This project is licensed under the [Apache 2.0 license](https://github.com/Mes2d/C-XorStr/blob/main/LICENSE).
