using System.Collections.Generic;
using ForEachChallenge;
using ForEachChallenge.Interfaces;
using Xunit;

namespace WeeklyChallengeTests.ForEach
{
    public class PeopleTests
    {
        [Fact]
        public void GetFullPeopleCollection()
        {
            var dpc = new DummyPersonCreater();
            var people = new People(new List<IPersonModell>());

            var testtarget = people.SetNames(dpc.AllFirstname(), dpc.AllLastname()).Count;

            Assert.Equal(4, testtarget);
        }
    }
}