using System;

namespace Cryptanalysis
{
public class Vigenere
{
    public const float FrenchIndexOfCoincidence = 0.0778F;
    private string mech;
    public Vigenere(string key)
    {
        this.mech = key;
    }

    public string Encrypt(string msg)
    {
        throw new NotImplementedException();
    }

    public string Decrypt(string cypherText)
    {
        throw new NotImplementedException();
    }

    public static string GuessKeyWithLength(string cypherText, int keyLength)
    {
        throw new NotImplementedException();
    }
    
    public static float IndexOfCoincidence(string str)
    {
        throw new NotImplementedException();
    }

    public static int GuessKeyLength(string cypherText)
    {
        throw new NotImplementedException();
    }
    
    public static string GuessKey(string cypherText)
    {
        throw new NotImplementedException();
    }
}
}
