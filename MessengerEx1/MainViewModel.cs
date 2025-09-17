using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerEx1
{
    public partial class MainViewModel : ObservableObject
    {
        public StatusBarViewModel StatusBarVM { get; }

        public MainViewModel(StatusBarViewModel statusBar)
        {
            StatusBarVM = statusBar;
        }

        [RelayCommand]
        private void SendStatus()
        {
            WeakReferenceMessenger.Default.Send(new StatusMessage("데이터 로드 완료"));
        }
    }
}
