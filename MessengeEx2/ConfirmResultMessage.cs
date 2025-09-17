using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengeEx2;
public class ConfirmResultMessage : ValueChangedMessage<bool>
{
    public ConfirmResultMessage(bool value) : base(value) { }
}
