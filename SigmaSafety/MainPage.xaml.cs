using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SigmaSafety
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnTab1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tabela1());
        }

        private async void btnTab2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tabela2());

        }

        private async void btnTab3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tabela3());

        }

        private async void btnTab4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tabela4());

        }

        private async void btnSobre_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }
    }
}
