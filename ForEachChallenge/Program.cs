using System.Collections.Generic;
using ForEachChallenge.Interfaces;

namespace ForEachChallenge
{
    internal class Program
    {
        private static void Main()
        {
            var people = new People(new List<IPersonModell>());

            IWriter cw = new ConsoleWriter();
            var dataCreater = new DummyPersonCreater();

            var allp = people.SetNames(dataCreater.AllFirstname(), dataCreater.AllLastname());

            foreach (var item in allp) cw.Write($"{item.Firstname} {item.Lastname}");
            cw.Read();
        }
    }
}