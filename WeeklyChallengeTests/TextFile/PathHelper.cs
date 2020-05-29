using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace WeeklyChallengeTests.TextFile
{
    public class PathHelper 
    {
        private string _binPath;
        private readonly IList<string> _csvCompletePath = new List<string>();
        private string _filePath;

        public string BinPath
        {
            get => GetBinPath();
            set => _binPath = value;
        }

        public string[] GetAllFileNames()
        {
            SetTestFilePath();
            var csvFiles = Directory.GetFiles(_filePath, "*.csv")
                .Select(Path.GetFileName)
                .ToArray();

            return csvFiles;
        }
        public string[] GetAllFileNamePath()
        {
            SetTestFilePath();
            var csvpath = Directory.GetFiles(_filePath, "*.csv")
                .ToArray();

            return csvpath;
        }


        private void SetTestFilePath()
        {
            _filePath = BinPath + "\\Files\\";
        }


        private string GetBinPath()
        {
            _binPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);

            if (_binPath != null) return _binPath = _binPath.Substring(6);
            return string.Empty;
        }

        public IList<string> GetCsvFileCollection(string FilePath)
        {
            var fileCol = GetAllFileNames();
            foreach (var fileColItem in fileCol)
            {
                _csvCompletePath.Add(FilePath + fileColItem);
            }

            return _csvCompletePath;
        }
    }
}