using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using TextFileChallenge;
using Xunit;

namespace WeeklyChallengeTests.TextFile
{
    public class CsvHandlerTests
    {
        private PathHelper _ph;

        public CsvHandlerTests()
        {
            _ph = new PathHelper();
        }
       

        [Fact]
        public void ReadFirstCsvFile()
        {
            string filepath = _ph.GetAllFileNamePath().First();
            var csvHelp = new CsvHandler(new List<UserModel>(), filepath);

            csvHelp.Read();

            Assert.NotEmpty(csvHelp.UserModels);
        }
       

       
    }
}