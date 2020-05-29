
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using TextFileChallenge.Interfaces;


namespace TextFileChallenge
{
    public class CsvHandler : IFileHandler
    {
        private  List<UserModel> _userModels;
        private  string _filePath;
        public CsvHandler(List<UserModel> userModels, string filePath)
        {
            _userModels = userModels;
            _filePath = filePath;
        }

        public List<UserModel> UserModels => _userModels;

        public void Read()
        {
            using (var reader = new StreamReader(_filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    foreach (var Records in csv.GetRecords<UserModel>())
                    {
                        _userModels.Add(Records);
                    }
                }
            }
        }

        public void Write()
        {
           
        }
    }
}