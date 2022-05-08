using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confectionery.Core
{
    class ErrorEventArgs : EventArgs
    {
        public string Message { get; }
        public ErrorEventArgs(string msg)
        {
            Message = msg;
        }
    }
}
