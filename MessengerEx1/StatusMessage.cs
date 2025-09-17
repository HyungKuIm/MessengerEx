using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerEx1
{
    public class StatusMessage : ValueChangedMessage<string>
    {
        public StatusMessage(string value) : base(value) { }
    }
}
