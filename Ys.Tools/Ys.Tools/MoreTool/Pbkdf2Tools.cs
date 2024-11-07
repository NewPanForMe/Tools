using System;
using System.Security.Cryptography;

namespace Ys.Tools.MoreTool;

public class Pbkdf2Tools
{
    const int SaltSize = 24; // 字节大小
    const int HashSize = 24; // 字节大小
    const int Iterations = 100000; // pbkdf2迭代次数
    public static string CreateHash(string password)
    {
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        byte[] salt = new byte[SaltSize];
        rng.GetBytes(salt);
        // 生成哈希
        Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
        var bytes = pbkdf2.GetBytes(HashSize);
        return Convert.ToBase64String(bytes);
    }
}