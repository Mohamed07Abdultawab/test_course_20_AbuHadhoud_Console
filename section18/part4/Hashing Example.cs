using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace test_course_20_AbuHadhoud_Console.section18.part4
{
    public class Hashing_Example
    {
        public void Display()
        {
            string data = "Mohamed AbedEltawab";
            string hashedData = ComputeHash(data);

            Console.WriteLine($"Original Data: {data}");
            Console.WriteLine($"Hashed Data: {hashedData}");
        }

        private string ComputeHash(string data)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] hashByte = sha256.ComputeHash(Encoding.UTF8.GetBytes(data));

                return BitConverter.ToString(hashByte).Replace("-", "").ToLower();
            }
        }
    }
}
