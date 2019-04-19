using System;
using Fennec.Watchers;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fennec
{
    class Program
    {
        static void Main(string[] args)
        {
            //  >>>>>[  Set up Session Lock/Unlock Recording
            //          -----
            SessionLockWatcher slWatcher = new SessionLockWatcher();

            Console.ReadLine();
        }
    }
}
