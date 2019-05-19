using System;
using ForEachChallenge.Interfaces;

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