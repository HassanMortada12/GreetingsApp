﻿using System;

namespace GreetingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to the Greeting App.");
        }
    }
}
