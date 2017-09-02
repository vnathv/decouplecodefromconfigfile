using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBusinessLogic
{
    public class CoupledServerFileDetails
    {
        public string GetFile()
        {
            return ConfigurationManager.AppSettings["ServerPath"] +
                   ConfigurationManager.AppSettings["Filename"];
        }
    }
}
