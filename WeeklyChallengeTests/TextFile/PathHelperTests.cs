using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WeeklyChallengeTests.TextFile
{
   public class PathHelperTests
   {
       private readonly PathHelper _ph;

        public PathHelperTests()
        {
             _ph = new PathHelper();
        }

        [Fact]
        public void CheckCurrentTestBinPath()
        {
            var actual = _ph.BinPath;
            var expect = "F:\\DEV_Projects\\Projects\\Weekly.Challenge\\WeeklyChallengeTests\\bin\\Debug";

            Assert.Equal(expect,actual);
        }
        [Fact]
        public void GetAllFileNameTest()
        {
            var except = new List<string>() {"0DataSet.csv", "1StandardDataSet.csv", "2AdvancedDataSet.csv"};
            var testFile = _ph.GetAllFileNames();

            for (int i = 0; i < except.Count; i++)
            {
                Assert.Equal(testFile[i], except[i]);
            }
        }
        
    }
}
