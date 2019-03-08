using System;
using System.Collections.Generic;

namespace ForEach
{
    class Program
    {
        static void Main()
        {           
            var people = new People(new List<IPersonModell>());

            IWriter cw = new ConsoleWriter();

            var allp = people.SetNames(AllFirstname(), AllLastname());

            foreach (var item in allp)
            {
                cw.Write($"{item.Firstname} {item.Lastname}");
            }
            Console.ReadKey();
        }

        private static IList<string> AllFirstname()
        {
            var firstnames = new List<string>
            {
                "Jonny",
                "Jonny1",
                "Jonny2",
                "Jonny2"
            };

            return firstnames;
        }

        private static IList<string> AllLastname()
        {
            var lastnames = new List<string>
            {
                "Roe",
                "Mula",
                "Jo",
                "Joy",              
            };


            return lastnames;
        }
    }
}
