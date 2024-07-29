using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExemplo
{
    class Program
    {
        delegate int Division(int number1, int number2);

        static void Main(string[] args)
        {
            // Lambda
            Division divLambda = (x, y) => x / y;
            Console.WriteLine(divLambda(2, 3));
            Console.WriteLine(divLambda(50, 10));
            // Sem lambda
            Division div = Divide;
            Console.WriteLine(div(2, 3));
            Console.WriteLine(div(50, 10));


            IEnumerable<string> values = new List<string>() { "DevMedia", "Expressões Lambda", "C#", ".NET" };
            // Lambda
            Console.WriteLine(values.Any(s => s.Contains("Dev")));
            // Sem lambda
            foreach (string s in values)
            {
                if (s.Contains("Dev"))
                {
                    Console.WriteLine(true);
                    break;
                }
            }


            Console.WriteLine();


            string email = "hmgasparotto@hotmail.com";
            string notEmail = "DevMedia";
            Func<string, bool> emailValidator =
                e => {
                    if (!e.Contains("@"))
                        return false;
                    if (!e.Contains(".com"))
                        return false;
                    return true;
                };
            // Lambda
            Console.WriteLine(emailValidator(email));
            Console.WriteLine(emailValidator(notEmail));
            // Sem lambda
            Console.WriteLine(ValidateEmail(email));
            Console.WriteLine(ValidateEmail(notEmail));


            Console.ReadKey();
        }

        public static int Divide (int x, int y)
        {
            return x / y;
        }

        public static bool ValidateEmail(string email)
        {
            if (!email.Contains("@"))
                return false;
            if (!email.Contains(".com"))
                return false;
            return true;
        }
    }
}
