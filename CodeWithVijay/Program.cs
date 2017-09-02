using ServerBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithVijay
{
    class Program
    {
        static void Main(string[] args)
        {
            DeCoupledServerFileDetails deCoupledServerFileDetails = new DeCoupledServerFileDetails(new FileConfig());

            Console.WriteLine(deCoupledServerFileDetails.GetFile());

            Console.ReadKey();
        }
    }
}
