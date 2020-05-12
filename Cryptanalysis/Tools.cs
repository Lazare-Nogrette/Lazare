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
        if (90 >= y && y >= 65 )
        {
            if (90 < y + n )
            {
                return Convert.ToChar(y + n - 26);
            }

            if (y + n  < 65 )
            {
                return Convert.ToChar(y + n + 26);
            }
            return Convert.ToChar(y + n);
        }

        if (122 >= y && y >= 97 )
        {
            if (122 < y + n )
            {
                return Convert.ToChar(y + n - 26);
            }

            if (y + n  < 97 )
            {
                return Convert.ToChar(y + n + 26);
            }
            return Convert.ToChar(y + n);
        }

        return c;
    }

    public static int[] Histogram(string str)
    {
        int[] res = new int[26];
        foreach (char i in str)
        {
            if (LetterIndex(i) != -1)
            {
                res[LetterIndex(i)] += 1;
            }
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
