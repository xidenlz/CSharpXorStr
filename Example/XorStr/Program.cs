using System;

public static class XorString
{
    private static T[] Xor<T>(T[] input, ulong key)
    {
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = XorValue(input[i], key);
        }
        return input;
    }

    private static T XorValue<T>(T value, ulong key)
    {
        byte[] bytes = BitConverter.GetBytes(Convert.ToUInt64(value));
        ulong valueUInt64 = BitConverter.ToUInt64(bytes, 0);
        valueUInt64 ^= key;

        if (typeof(T) == typeof(char))
        {
            valueUInt64 %= char.MaxValue + 1;
        }

        byte[] resultBytes = BitConverter.GetBytes(valueUInt64);
        return BitConverter.ToUInt64(resultBytes, 0).To<T>();
    }

    private static T[] XorStringArray<T>(T[] input, ulong key)
    {
        T[] result = new T[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            result[i] = XorValue(input[i], key);
        }
        return result;
    }

    private static T LoadFromReg<T>(T value)
    {
        return value;
    }

    public static string XorStr(string input, ulong key)
    {
        char[] charArray = input.ToCharArray();
        charArray = Xor(charArray, key);
        return new string(charArray);
    }

    public static string XorStr(string input)
    {
        const ulong Seed = 2166136261UL;
        ulong key = detail_key8(Seed);

        char[] charArray = input.ToCharArray();
        charArray = Xor(charArray, key);
        return new string(charArray);
    }

    private static ulong detail_key4(ulong seed)
    {
        ulong value = seed;
        foreach (char c in DateTime.Now.ToString("HH:mm:ss"))
        {
            value = (value ^ c) * 16777619UL;
        }
        return value;
    }

    private static ulong detail_key8(ulong s)
    {
        ulong firstPart = detail_key4(2166136261UL + s);
        ulong secondPart = detail_key4((ulong)firstPart);
        return (firstPart << 32) | secondPart;
    }
}

public static class Extensions
{
    public static T To<T>(this ulong value) => (T)Convert.ChangeType(value, typeof(T));
}



public class Program
{
    public static void Main()
    {
        string str = XorString.XorStr("Hello World!");
        Console.WriteLine(str);
    }
}

