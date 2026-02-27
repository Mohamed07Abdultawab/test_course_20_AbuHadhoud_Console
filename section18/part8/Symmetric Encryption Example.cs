using System;
using System.Security.Cryptography;
using System.Text;

namespace test_course_20_AbuHadhoud_Console.section18.part8
{
    public class Symmetric_Encryption_Example
    {
        public void Display()
        {
            // Original data
            string originalData = "Sensitive information";


            // Key for AES encryption (128-bit key)
            string key = "1234567890123456";


            // Encrypt the original data
            string encryptedData = Encrypt(originalData, key);


            // Decrypt the encrypted data
            string decryptedData = Decrypt(encryptedData, key);


            // Display results
            Console.WriteLine($"Original Data: {originalData}");
            Console.WriteLine($"Encrypted Data: {encryptedData}");
            Console.WriteLine($"Decrypted Data: {decryptedData}");
        }

        private static string Encrypt(string plainText, string key)
        {
            
            using(Aes aesAlg = Aes.Create())
            {
                //set key and IV for aes encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                //create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key,aesAlg.IV);

                //encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    
                    //return the encrypted data as a base64-encoded
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }


        private static string Decrypt(string cipherText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                //create encrypt
                ICryptoTransform depryctor = aesAlg.CreateDecryptor(aesAlg.Key,aesAlg.IV);

                //de
                using(var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using(var csDecrypt = new CryptoStream(msDecrypt,depryctor,CryptoStreamMode.Read))
                    using(var srDecrypt = new System.IO.StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }

    }
}
