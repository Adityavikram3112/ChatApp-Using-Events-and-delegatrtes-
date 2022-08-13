using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp__Using_Events_and_delegatrtes__
{
    class MessageArgs :EventArgs
    {
        public string UserText { get; set; }
    }
}
