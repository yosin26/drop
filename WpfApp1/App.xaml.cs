using System.Windows;
using WpfApp1.Repository;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow app = new MainWindow();
            ProductViewModel context = new ProductViewModel(new ProductRepository());
            app.DataContext = context;
            app.Show();
        }
    }
}
