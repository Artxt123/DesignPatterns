using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var strategy = new WalkStrategy();

            var map = new Map(strategy);

            var start = new Coordinate();
            var end = new Coordinate();

            map.CreateRoute(start, end);
        }
    }
}
