
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using TextFileChallenge.Interfaces;


namespace TextFileChallenge
{
    public class CsvHandler : IFileHandler
    {
        private  IList<UserModel> _userModels;
        private  string _filePath;
        public CsvHandler(IList<UserModel> userModels, string filePath)
        {
            _userModels = userModels;
            _filePath = filePath;
        }

        public IList<UserModel> UserModels => _userModels;

        public void Read()
        {
            IEnumerable<dynamic> records ;

            //var filePath1 = @"F:\0DataSet.csv";

            var bla = new MemoryStream();
            using (var reader = new StreamReader(_filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<dynamic>();
                }
            }
            string muh = "1";

        }

        public void Write()
        {
           
        }
    }
}