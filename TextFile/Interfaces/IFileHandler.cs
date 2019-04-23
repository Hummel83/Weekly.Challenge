using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileChallenge.Interfaces
{
    interface IFileHandler
    {
        IList<UserModel> Read();
        void Write(IList<UserModel> userModels);
    }
}
