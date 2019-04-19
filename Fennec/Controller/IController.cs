using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fennec.Controller
{
    public interface IController
    {
        Boolean Execute(String command);
    }
}
