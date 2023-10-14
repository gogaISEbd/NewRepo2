using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Controllers
{
    public class EncryptiontController
    {
        public string Encrypt(string plainText, string password,
               string salt = "Kosher", string hashAlgorithm = "SHA1",
                int passwordIterations = 2, string initialVector = "FAHfd16tgew92dH", int keySize = 256)
        {
            if (string.IsNullOrEmpty(plainText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] cipherTextBytes = null;

            using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memStream.ToArray();
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }
            symmetricKey.Clear();
            return Convert.ToBase64String(cipherTextBytes);
        }
    }
}
