using DallUIApp.Views;

namespace DallUIApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Screen1View();
        }
    }
}
