using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class SecurityScanner
    {
        public IEnumerable<string> SecurityScan(string hithubUrl)
        {
            Console.WriteLine("Security scan");
            return new List<string>() { "security error1", "security error2" };
        }
    }
}
