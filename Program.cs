using System;
using System.Security.Cryptography;

namespace crypto_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Placide IRANDORA Is A Rwandan Software Engineer And Cybersecurity Specialist.\n");
            Console.Write("Cryptographic Random Number: ");
            Console.WriteLine(Convert.ToBase64String(GenerateRandomNumber(40)));
            Console.WriteLine();
        }

        // Method for returning a cryptographic random number
        public static byte[] GenerateRandomNumber(int length)
        {   
            // Object for generating a cryptographic random number
            using (RNGCryptoServiceProvider randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[length];
                randomNumberGenerator.GetBytes(randomNumber);
                return randomNumber;
            }
        }
    }
}