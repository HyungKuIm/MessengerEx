using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MessengeEx2;
public sealed class WindowManager : IWindowManager
{
    private readonly IServiceProvider _root;

    public WindowManager(IServiceProvider root) => _root = root;

    public void ShowWindow<TWindow, TViewModel>(Action<TViewModel>? init = null)
        where TWindow : Window
        where TViewModel : class
    {
        var scope = _root.CreateScope();
        var sp = scope.ServiceProvider;

        var window = sp.GetRequiredService<TWindow>();
        var vm = sp.GetRequiredService<TViewModel>();
        init?.Invoke(vm);

        window.DataContext = vm;
        window.Closed += (_, __) => scope.Dispose();
        window.Show();
    }

    public bool? ShowDialog<TWindow, TViewModel>(Action<TViewModel>? init = null)
        where TWindow : Window
        where TViewModel : class
    {
        var scope = _root.CreateScope();
        var sp = scope.ServiceProvider;

        var window = sp.GetRequiredService<TWindow>();
        var vm = sp.GetRequiredService<TViewModel>();
        init?.Invoke(vm);

        window.DataContext = vm;
        window.Closed += (_, __) => scope.Dispose();
        window.Owner = Application.Current.MainWindow;
        return window.ShowDialog();
    }
}
