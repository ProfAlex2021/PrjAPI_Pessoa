using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrjAPI_Pessoa
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListaPessoaPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
