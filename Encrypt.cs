using System;

namespace Encryptor
{
    class Program
    {

        static string alphabet = "abcdefghijklmnopqrstuvwxyz";

        // Encrypt then decrypt a string of characters, numbers are not included
        static void Main(string[] args)
        {
            // Test input
            string test = "hello dear sir my name is worthsworth";
            int key = 3;

            string testEnc = Encrypt(test, key);
            string testDec = Decrypt(testEnc, key);

            Console.WriteLine(testEnc);
            Console.WriteLine(testDec);

            Console.ReadLine();
        }

        static string Encrypt(string s, int k)
        {
            // returns an encrypted string that has been shifted by k to the right in the alphabet
            // formula: E(s, k) = (s + k) mod 26
            string cipher = "";       

            foreach (char l in s)
            {
                if (l == ' ')
                {
                    cipher += " ";
                }
                else
                {
                    cipher += alphabet[(alphabet.IndexOf(l) + k) % 26];
                }
            }

            return cipher;
        }

        static string Decrypt(string s, int k)
        {
            // returns an decrypted string that has been shifted by k to the left in the alphabet
            // formula: D(s, k) = (s - k) mod 26
            string decipher = "";

            foreach (char l in s)
            {
                if (l == ' ')
                {
                    decipher += " ";
                }
                else
                {
                    decipher += alphabet[(alphabet.IndexOf(l) + 26 - k) % 26]; // Add 26 to get rid of negative numbers
                }
            }

            return decipher;
        }
    }
}
