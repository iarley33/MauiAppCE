using MauiAppCE.Views;

namespace MauiAppCE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Define a primeira tela do app
            MainPage = new NavigationPage(new CadastroEvento());
        }
    }
}
