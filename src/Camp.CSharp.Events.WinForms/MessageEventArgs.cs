using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camp.CSharp.Events.WinForms
{
    public class MessageEventArgs: EventArgs
    {
        public string Message { get; }
        public MessageEventArgs(string message)
        {
            Message = message;
        }
    }
}
