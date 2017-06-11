using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;
using System.Text;

namespace MMEncryptor.Utils
{
    public static class Security
    {
        static string secret = GenerateSecret();
        static byte[] byteSecret = GenerateByteSecret(secret);

        public static string Encrypt(byte[] toEncrypt, string pathForEncryptedFile)
        {
            byte[] data = ProtectedData.Protect(toEncrypt, byteSecret, DataProtectionScope.CurrentUser);
            File.WriteAllBytes(pathForEncryptedFile, data);
            return secret;
        }

        public static void Encrypt(byte[] toEncrypt, string pathForEncryptedFile, string key)
        {
            byte[] data = ProtectedData.Protect(toEncrypt, Encoding.ASCII.GetBytes(key), DataProtectionScope.CurrentUser);
            File.WriteAllBytes(pathForEncryptedFile, data);
        }

        public static byte[] Decrypt(string pathForEncryptedFile, string key)
        {
            byte[] data = File.ReadAllBytes(pathForEncryptedFile);
            try
            {
                data = ProtectedData.Unprotect(data, Encoding.ASCII.GetBytes(key), DataProtectionScope.CurrentUser);
                return data;
            }
            catch (CryptographicException e)
            {
                throw;
            }
        }

        private static string GenerateSecret()
        {
            StringBuilder secret = new StringBuilder();

            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                secret.Append(rnd.Next(100).ToString());
            }

            return secret.ToString();
        }

        private static byte[] GenerateByteSecret(string secret)
        {
            byte[] byteSecret = Encoding.ASCII.GetBytes(secret);
            return byteSecret;
        }

        private static byte[] ReadByteArray(byte[] b)
        {
            MemoryStream s = new MemoryStream(b);
            byte[] rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("Stream did not contain properly formatted byte array");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("Did not read byte array properly");
            }

            return buffer;
        }
    }
}
