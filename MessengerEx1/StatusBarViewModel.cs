using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerEx1
{
    public partial class StatusBarViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? _statusText;

        public StatusBarViewModel()
        {
            WeakReferenceMessenger.Default.Register<StatusMessage>(this, (r, m) =>
            {
                StatusText = m.Value; // 상태바에 표시
            });
        }
    }
}
