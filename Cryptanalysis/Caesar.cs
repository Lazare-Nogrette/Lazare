using System;
using System.ComponentModel;

namespace Cryptanalysis
{
public class Caesar
{
    private int Key;
    public Caesar(int key)
    {
        this.Key = key;
    }

    public string Encrypt(string msg)
    {
        string cez = "";
        foreach (char x in msg)
        {
            cez += Tools.RotChar(x, Key);
        }

        return cez;
    }

    public string Decrypt(string cypherText)
    {
        string real = "";
        foreach (char y in cypherText)
        {
            real += Tools.RotChar(y, -Key);
        }

        return real;
    }
    
    public static int GuessKey(string cypherText)
    {
        int[] hist = Tools.Histogram(cypherText);
        int limit = 0;
        foreach (int i in hist)
        {
            if (limit < i)
            {
                limit = i;
            }
        }
        return limit;
    }
}
}