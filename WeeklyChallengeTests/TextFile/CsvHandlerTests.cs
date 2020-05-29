using System.Collections.Generic;
using System.Linq;
using TextFileChallenge;
using Xunit;

namespace WeeklyChallengeTests.TextFile
{
    public class CsvHandlerTests
    {
        public CsvHandlerTests()
        {
            _ph = new PathHelper();
        }

        private readonly PathHelper _ph;


        [Fact]
        public void ReadFirstCsvFile()
        {
            //Arrange
            var filepath = _ph.GetAllFileNamePath().First();
            var except = new List<UserModel>
            {
                new UserModel{FirstName ="Dean",LastName = "Flynn",Age = 31,IsAlive = false}
            };
          
            //Act
            var csvHelp = new CsvHandler(new List<UserModel>(), filepath);
            csvHelp.Read();

            //Assert
            Assert.Equal(except,csvHelp.UserModels);
        
        }
    }
}