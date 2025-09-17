using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MessengeEx2;
public interface IWindowManager
{
    void ShowWindow<TWindow, TViewModel>(Action<TViewModel>? init = null)
        where TWindow : Window
        where TViewModel : class;

    bool? ShowDialog<TWindow, TViewModel>(Action<TViewModel>? init = null)
        where TWindow : Window
        where TViewModel : class;
}
