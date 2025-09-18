using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengeEx2;
public partial class OrdersViewModel : ObservableObject
{
    private readonly IWindowManager _windows;

    public OrdersViewModel(IWindowManager windows)
    {
        WeakReferenceMessenger.Default.Register<ConfirmResultMessage>(this, (r, m) =>
        {
            if (m.Value)
                DeleteOrder();
        });

        _windows = windows;
    }

    [ObservableProperty]
    private string _deleteMsg;

    private void DeleteOrder()
    {
        // 삭제 로직
        Debug.WriteLine("삭제되었습니다.");
        DeleteMsg = "삭제되었습니다";
    }

    [RelayCommand]
    private void OpenDelete()
    {
        _windows.ShowDialog<DeleteDialogWindow, ConfirmDialogViewModel>();
    }
}
