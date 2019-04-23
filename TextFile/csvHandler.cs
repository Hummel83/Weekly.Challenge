using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileChallenge.Interfaces;

namespace TextFileChallenge
{
    internal class csvHandler : IFileHandler
    {
        private readonly IList<UserModel> _userModels;
        public csvHandler(IList<UserModel> userModels)
        {
            _userModels = userModels;
        }

        public IList<UserModel> UserModels => _userModels;

        public IList<UserModel> Read()
        {
            throw new NotImplementedException();
        }

        public void Write(IList<UserModel> userModels)
        {
            throw new NotImplementedException();
        }
    }
}
