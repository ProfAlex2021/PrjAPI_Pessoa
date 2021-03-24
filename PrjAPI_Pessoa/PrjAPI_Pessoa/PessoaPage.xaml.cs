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
    public partial class PessoaPage : ContentPage
    {
        public PessoaPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}