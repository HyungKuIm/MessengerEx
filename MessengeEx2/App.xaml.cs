using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MessengeEx2;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var services = new ServiceCollection();

        services.AddSingleton<IWindowManager, WindowManager>();

        services.AddTransient<ConfirmDialogViewModel>();
        services.AddTransient<OrdersViewModel>();

        //팝업
        services.AddTransient<DeleteDialogWindow>();

        var provider = services.BuildServiceProvider();
        var mainWindow = new MainWindow
        {
            DataContext = provider.GetRequiredService<OrdersViewModel>()
        };

        mainWindow.Show();


    }
}

