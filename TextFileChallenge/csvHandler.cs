using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using TextFileChallenge.Interfaces;

namespace TextFileChallenge
{
    public class CsvHandler : IFileHandler
    {
        private readonly string _filePath;

        public CsvHandler(List<UserModel> userModels, string filePath)
        {
            UserModels = userModels;
            _filePath = filePath;
        }

        public List<UserModel> UserModels { get; }

        public void Read()
        {
            using (var reader = new StreamReader(_filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    foreach (var Records in csv.GetRecords<UserModel>()) UserModels.Add(Records);
                }
            }
        }

        public void Write()
        {
        }
    }
}