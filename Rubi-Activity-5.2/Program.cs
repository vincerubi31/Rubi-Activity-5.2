using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // DSA Activity 5.2 - Rubi, Vince Paul Ronald

        Console.WriteLine("PALINDROME PROGRAM");
        Console.WriteLine("Enter 0 to exit.");

        while (true)
        {
            Console.Write("\nEnter word: ");
            string word = Console.ReadLine().ToLower();
            if (word == "0")
            {
                Console.WriteLine("Thank you for using the program");
                break;
            }
            Stack<char> stack = new Stack<char>();
            foreach (char ch in word)
            {
                stack.Push(ch);
            }
            string reversed = "";

            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }
            if (word == reversed)
            {
                Console.WriteLine("It is PALINDROME");
            }
            else
            {
                Console.WriteLine("It is NOT PALINDROME");
            }
        }
    }
}