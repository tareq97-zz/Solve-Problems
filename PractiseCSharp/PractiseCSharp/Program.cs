using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseCSharp
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            bool result;
            bool checkPalin;
            char first = ' ';
            char last = ' ';
            string exit = "";
            string input = "";
            while (true)
            {
                result = true;
                checkPalin = false;
                Console.Write(Comman.EnterString);
                input = Console.ReadLine();
                Loop(ref result, ref checkPalin, input, ref first, ref last);
                IsPalindrome(result);
                Console.Write(Comman.ExitOrContinue);
                exit = Console.ReadLine();
                if (exit == Comman.YesExit)
                    break;
            }
        }

        private static void Loop(ref bool result, ref bool checkPalin, string input, ref char first, ref char last)
        {
            for (int i = 0; i <= input.Length / 2; i++)
            {
                first = input[i];
                last = input[(input.Length - 1) - i];
                checkPalin = new Program().Compare(first, last);
                result = result & checkPalin;
            }
        }

        private static void IsPalindrome(bool result)
        {
            if (result)
            {
                Console.WriteLine("Is palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }

        private bool Compare(char first, char last)
        {
            if (first == last)
                return true;
            else
                return false;
        }
    }
}
