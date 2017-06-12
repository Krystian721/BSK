using System;
using System.Security.Cryptography;
using System.Text;
static class HashFunctions
{
    public static string CalculateMD5Hash(string input)
    {
        MD5 md5 = MD5.Create();
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hash = md5.ComputeHash(inputBytes);

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            stringBuilder.Append(hash[i].ToString("X2"));
        }
        return stringBuilder.ToString();
    }

    public static string CalculateRIPEMD160Hash(string input)
    {
        RIPEMD160 ripemd160 = RIPEMD160.Create();
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hash = ripemd160.ComputeHash(inputBytes);

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            stringBuilder.Append(hash[i].ToString("X2"));
        }
        return stringBuilder.ToString();
    }

    public static string CalculateSHA1Hash(string input)
    {
        SHA1 sha1 = SHA1.Create();
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hash = sha1.ComputeHash(inputBytes);

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            stringBuilder.Append(hash[i].ToString("X2"));
        }
        return stringBuilder.ToString();
    }

    public static string CalculateSHA256Hash(string input)
    {
        SHA256 sha256 = SHA256.Create();
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hash = sha256.ComputeHash(inputBytes);

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            stringBuilder.Append(hash[i].ToString("X2"));
        }
        return stringBuilder.ToString();
    }

    public static string CalculateSHA384Hash(string input)
    {
        SHA384 sha384 = SHA384.Create();
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hash = sha384.ComputeHash(inputBytes);

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            stringBuilder.Append(hash[i].ToString("X2"));
        }
        return stringBuilder.ToString();
    }

    public static string CalculateSHA512Hash(string input)
    {
        SHA512 sha512 = SHA512.Create();
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hash = sha512.ComputeHash(inputBytes);

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            stringBuilder.Append(hash[i].ToString("X2"));
        }
        return stringBuilder.ToString();
    }

    public static bool VerifyingMD5Hash(string input, string hash)
    {
        string hashOfInput = CalculateMD5Hash(input);
        StringComparer comparer = StringComparer.OrdinalIgnoreCase;
        if (0 == comparer.Compare(hashOfInput, hash))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool VerifyingRIPEMD160Hash(string input, string hash)
    {
        string hashOfInput = CalculateRIPEMD160Hash(input);
        StringComparer comparer = StringComparer.OrdinalIgnoreCase;
        if (0 == comparer.Compare(hashOfInput, hash))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool VerifyingSHA1Hash(string input, string hash)
    {
        string hashOfInput = CalculateSHA1Hash(input);
        StringComparer comparer = StringComparer.OrdinalIgnoreCase;
        if (0 == comparer.Compare(hashOfInput, hash))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool VerifyingSHA256Hash(string input, string hash)
    {
        string hashOfInput = CalculateSHA256Hash(input);
        StringComparer comparer = StringComparer.OrdinalIgnoreCase;
        if (0 == comparer.Compare(hashOfInput, hash))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool VerifyingSHA384Hash(string input, string hash)
    {
        string hashOfInput = CalculateSHA384Hash(input);
        StringComparer comparer = StringComparer.OrdinalIgnoreCase;
        if (0 == comparer.Compare(hashOfInput, hash))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool VerifyingSHA512Hash(string input, string hash)
    {
        string hashOfInput = CalculateSHA512Hash(input);
        StringComparer comparer = StringComparer.OrdinalIgnoreCase;
        if (0 == comparer.Compare(hashOfInput, hash))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
