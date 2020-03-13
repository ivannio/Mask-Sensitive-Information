using System;

namespace Mask_Sensitive_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your credit card number?");
            string secret = Console.ReadLine();
            string lastFour = secret.Substring(secret.Length - 4);
            string firstPart = secret.Substring(0, secret.Length - 4);

            foreach (char character in firstPart)
            {
                firstPart = firstPart.Replace(character, 'X');
            }

            string result = firstPart + lastFour;

            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
