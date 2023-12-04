using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using DiaryOfSelfControl.DataAccessLogic;
using DiaryOfSelfControl.ViewModels;
using DiaryOfSelfControl.Views;

namespace DiaryOfSelfControl
{
    /// <summary> Interaction logic for App.xaml </summary>
    public partial class App : Application
    {
        public static ApplicationDbContext Database { get; set; }
        
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Database = new ApplicationDbContext();
            MainWindow = new MainWindow();

            var authViewModel = new AuthorizationViewModel();
            var auth = new AuthorizationView { DataContext = authViewModel };
            auth.ShowDialog();

            var loadingViewModel = new LoadingViewModel();
            var loadingView = new LoadingView { DataContext = loadingViewModel };
            loadingView.Show();

            await Task.Run(WaitLoading);
            loadingView.Close();

            MainWindow.Show();
        }

        private Task WaitLoading()
        {
            var i = 0;
            while (i < 500)
            {
                i++;
                Thread.Sleep(1);
            }
            return Task.CompletedTask;
        }
    }
}