﻿using System;
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
            string exit = "";
            while (true)
            {
                bool result = true;
                bool checkPalin = false;
                string input = "";
                char first = ' ';
                char last = ' ';
                Console.Write("Enter a string: ");
                input = Console.ReadLine();
                Loop(ref result, ref checkPalin, input, ref first, ref last);
                IsPalindrome(result);
                Console.Write("Do u want to exit. Press Y/N : ");
                exit = Console.ReadLine();
                if (exit == "Y")
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