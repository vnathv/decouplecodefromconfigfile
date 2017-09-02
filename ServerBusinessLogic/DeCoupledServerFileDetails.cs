using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBusinessLogic
{
    public class DeCoupledServerFileDetails
    {
        private readonly IFileConfig _fileConfig;
        public DeCoupledServerFileDetails(IFileConfig fileConfig)
        {
            _fileConfig = fileConfig;
        }

        public string GetFile()
        {
            return _fileConfig.FilePath + _fileConfig.FileName;
        }
    }
}
