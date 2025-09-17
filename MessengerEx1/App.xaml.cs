using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MessengerEx1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var services = new ServiceCollection();

            services.AddTransient<StatusBarViewModel>();

            services.AddTransient<MainViewModel>();

            var provider = services.BuildServiceProvider();
            var mainWindow = new MainWindow
            {
                DataContext = provider.GetRequiredService<MainViewModel>()
            };

            mainWindow.Show();

        }
    }

}
