using System.Collections.Generic;

namespace ForEachChallenge
{
    public class DummyPersonCreater
    {
        public IList<string> AllFirstname()
        {
            return new List<string>
            {
                "Jonny",
                "Jonny1",
                "Jonny2",
                "Jonny2"
            };
        }

        public IList<string> AllLastname()
        {
            return new List<string>
            {
                "Roe",
                "Mula",
                "Jo",
                "Joy"
            };
        }
    }
}