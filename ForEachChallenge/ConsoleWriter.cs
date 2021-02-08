using ForEachChallenge.Interfaces;
using System;

namespace ForEachChallenge
{
    internal class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }

        public void Read()
        {
            Console.ReadKey();
        }
    }
}