using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var scanFacade = new ScanFacade();
            scanFacade.Scan("http://github.com/somerepo");
        }
    }
}
