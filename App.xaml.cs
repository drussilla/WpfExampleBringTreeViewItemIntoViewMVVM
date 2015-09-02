using System.Windows;

namespace BringIntoViewMVVMExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // bootstrap logic
            var mainWindows = new MainWindow
            {
                DataContext = new MainWindowViewModel()
            };

            mainWindows.Show();
        }
    }
}
