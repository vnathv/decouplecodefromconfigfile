﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBusinessLogic
{
    public class FileConfig : IFileConfig
    {
        public string FilePath => ConfigurationManager.AppSettings["ServerPath"];

        public string FileName => ConfigurationManager.AppSettings["Filename"];
    }
}
