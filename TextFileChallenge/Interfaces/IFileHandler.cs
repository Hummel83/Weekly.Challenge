using System.Collections.Generic;

namespace TextFileChallenge.Interfaces
{
    internal interface IFileHandler
    {
        IList<UserModel> Read();
        void Write(IList<UserModel> userModels);
    }
}