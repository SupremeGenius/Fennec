using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fennec.Watchers;
using Fennec.View;
using Fennec.Model;
using Fennec.Controller;

namespace Fennec
{
    class Program
    {
        static void Main(string[] args)
        {
            //  >>>>>[  Set us up the Session Lock/Unlock Recording
            //          -----
            SessionLockWatcher slWatcher = new SessionLockWatcher();

            //  >>>>>[  Set us up the rest of the Application
            //          -----
            FennecModel Model = new FennecModel();
            FennecController Controller = new FennecController(Model);
            FennecMainView View = new FennecMainView(Model, Controller);

            //  >>>>>[  Link Model and View
            //          -----
            Model.AddView(View);

            //  >>>>>[  Wonder Twin Powers, ACTIVATE!
            //          -----
            View.ModelChanged();
        }
    }
}
