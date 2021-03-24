using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrjAPI_Pessoa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPessoaPage : ContentPage
    {
        public ListaPessoaPage()
        {
            InitializeComponent();
        }

        private void listaDados_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new PessoaPage() { BindingContext = e.Item as Pessoa });
        }
    }
}