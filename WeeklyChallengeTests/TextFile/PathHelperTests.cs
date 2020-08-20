using System.Collections.Generic;
using Xunit;

namespace WeeklyChallengeTests.TextFile
{
    public class PathHelperTests
    {
        public PathHelperTests()
        {
            _ph = new PathHelper();
        }

        private readonly PathHelper _ph;

        [Fact]
        public void CheckCurrentTestBinPath()
        {
            var actual = _ph.BinPath;
            var expect = "F:\\DEV_Projects\\Projects\\Weekly.Challenge\\WeeklyChallengeTests\\bin\\Debug";

            Assert.Equal(expect, actual);
        }

        [Fact]
        public void GetAllFileNameTest()
        {
            var except = new List<string> {"0DataSet.csv", "1StandardDataSet.csv", "2AdvancedDataSet.csv"};
            var testFile = _ph.GetAllFileNames();

            for (var i = 0; i < except.Count; i++) Assert.Equal(testFile[i], except[i]);
        }
    }
}