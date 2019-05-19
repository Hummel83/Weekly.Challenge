using System;
using System.Collections.Generic;
using TextFileChallenge.Interfaces;

namespace TextFileChallenge
{
    internal class csvHandler : IFileHandler
    {
        public csvHandler(IList<UserModel> userModels)
        {
            UserModels = userModels;
        }

        public IList<UserModel> UserModels { get; }

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