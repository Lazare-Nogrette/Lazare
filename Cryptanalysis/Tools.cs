using System;

namespace Cryptanalysis
{
public static class Tools
{
    public static int Modulus(int a, int b)
    {
        if (b < 0)
            b = -b;
        
        var mod = a % b;
        return mod < 0 ? b + mod : mod;
    }

    public static int LetterIndex(char c)
    {
        int x = Convert.ToInt32(c);
        if (x >= 65 && x <= 90)
        {
            x -= 65;
        }

        if (x >= 97 && x <= 122)
        {
            x -= 97;
        }
        else
        {
            x = -1;
        }

        return x;
    }
    
    public static char RotChar(char c, int n)
    {
        int y = Convert.ToInt32(c);
        if (n >= 27)
        {
            n -= 26;
        }
        if (y >= 65 && y <= 90 || y >=97 && y <= 122)
        {
            y += n;
            Convert.ToChar(y);
            y = c;
        }
        
        return c;
    }

    public static int[] Histogram(string str)
    {
        int[] res = new int[26];
        int i = 0;
        for (i = 0; i < res.Length; i++)
        {
            Console.Write(str[i]);
        }
        return res;
    }
    
    public static string FilterLetters(string str)
    {
        throw new NotImplementedException();
    }

    public static string Extract(string str, int start, int step)
    {
        throw new NotImplementedException();
    }
}
}
