using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengeEx2;
public class CloseDialogMessage : ValueChangedMessage<bool>
{
    public CloseDialogMessage(bool value) : base(value) { }
    // true = OK, false = Cancel
}
