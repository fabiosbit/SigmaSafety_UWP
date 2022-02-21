using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Essentials;

namespace SigmaSafety
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Sobre : ContentPage
	{
		public Sobre ()
		{
			InitializeComponent ();
		}

        private void btnWhats(object sender, EventArgs e)
        {
            try
            {
                Chat.Open("+5549988324940");
            }
            catch (Exception msg)
            {
                DisplayAlert("Erro", msg.Message, "ok");
            }
        }

        private async void btnWWW(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri("http://www.sigmacco.com.br/"));
        }
    }
}