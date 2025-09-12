using System;

namespace AbbaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeAbba("Hi", "Bye"));       // → HiByeByeHi
            Console.WriteLine(MakeAbba("Yo", "Alice"));     // → YoAliceAliceYo
            Console.WriteLine(MakeAbba("What", "Up"));      // → WhatUpUpWhat
            Console.WriteLine(MakeAbba("Code", "Fun"));     // → CodeFunFunCode
        }

        // Method that returns abba-style string
        static string MakeAbba(string a, string b)
        {
            return $"{a}{b}{b}{a}";
        }
    }
}