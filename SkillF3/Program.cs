﻿using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age is {0} ", age);
        Console.ReadKey();
    }
}