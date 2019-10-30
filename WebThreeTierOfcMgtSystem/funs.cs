using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace WebThreeTierOfcMgtSystem
{
    public class funs
    {
        public String SHA_256_salted(String Plain_text, String Salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var saltedPassword = string.Format("{0}{1}", Salt, Plain_text);
                byte[] saltedPasswordAsBytes = Encoding.UTF8.GetBytes(saltedPassword);
                return Convert.ToBase64String(sha256.ComputeHash(saltedPasswordAsBytes));
            }
        }

        public static string SHA_256(string Plain_text)
        {
            var message = Encoding.ASCII.GetBytes(Plain_text);
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";

            var hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }

        public static readonly string Key = ConfigurationManager.AppSettings["Encryption_Key"];
        public static readonly Encoding Encoder = Encoding.UTF8;

        public String ch(String c)
        {
            //return TripleDesEncrypt(c);
            return c;
        }

        public string TripleDesEncrypt(string plainText)
        {
            var des = CreateDes(Key);
            var ct = des.CreateEncryptor();
            var input = Encoding.UTF8.GetBytes(plainText);
            var output = ct.TransformFinalBlock(input, 0, input.Length);
            return Convert.ToBase64String(output);
        }

        public string TripleDesDecrypt(string cypherText)
        {
            var des = CreateDes(Key);
            var ct = des.CreateDecryptor();
            var input = Convert.FromBase64String(cypherText);
            var output = ct.TransformFinalBlock(input, 0, input.Length);
            return Encoding.UTF8.GetString(output);
        }

        public TripleDES CreateDes(string key)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDES des = new TripleDESCryptoServiceProvider();
            var desKey = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
            des.Key = desKey;
            des.IV = new byte[des.BlockSize / 8];
            des.Padding = PaddingMode.PKCS7;
            des.Mode = CipherMode.ECB;
            return des;
        }

    }
}
