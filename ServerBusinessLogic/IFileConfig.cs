using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBusinessLogic
{
    public interface IFileConfig
    {
        string FilePath { get; }
        string FileName { get; }
    }
}
