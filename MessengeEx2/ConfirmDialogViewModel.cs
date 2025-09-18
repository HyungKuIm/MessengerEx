using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengeEx2;
public partial class ConfirmDialogViewModel : ObservableObject
{
    //public Action? CloseAction { get; set; }

    [RelayCommand]
    private void Ok()
    {
        WeakReferenceMessenger.Default.Send(new ConfirmResultMessage(true));
        WeakReferenceMessenger.Default.Send(new CloseDialogMessage(true));
        //CloseAction?.Invoke();
    }

    [RelayCommand]
    private void Cancel()
    {
        WeakReferenceMessenger.Default.Send(new ConfirmResultMessage(false));
        WeakReferenceMessenger.Default.Send(new CloseDialogMessage(false));
        //CloseAction?.Invoke();
    }
        
}
