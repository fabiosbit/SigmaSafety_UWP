using System;
using System.Linq;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SigmaSafety
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabela4 : ContentPage
    {
        public Tabela4()
        {
            InitializeComponent();
        }

        private void btnCalcularDist_Clicked(object sender, EventArgs e)
        {
            decimal s = 0, d, c, t;
            // s = distância mínima
            // d = capacidade de detecção
            // c = distância de invasão (fórmula)
            // T = tempo de parada do sistema
            // S = (K x T) + C

            try
            {
                d = Convert.ToDecimal(entryResol.Text);
                t = Convert.ToDecimal(entryTempo.Text);

                if (t < 0)
                {
                    t *= -1;
                }

                if (entryResol.Text == null || entryTempo.Text == null)
                {
                    DisplayAlert("Erro", "Entre com os valores de T e D", "voltar");
                }
                else
                {
                    //Para dispositivos de proteção com capacidade D <= 40mm
                    if (d <= 40)
                    {
                        c = 8 * (d - 14);   //c não pode ser negativo.

                        if (c < 0)
                        {
                            c = 0;
                        }

                        s = (2000 * t) + c;
                        labelObs.IsVisible = false;

                        //S não pode ser menor que 100mm usando K=2000 eq3
                        if (s < 100)
                        {
                            s = 100;
                            labelObs.Text = "* A distância não pode ser menor que 100mm.";
                            labelObs.IsVisible = true;
                        }

                        //Primeira particularidade da norma (6.2.3.1)
                        if (s >= 500)
                        {
                            s = (1600 * t) + c;
                            labelObs.IsVisible = false;

                            //S não pode se menor que 500mm usando K=1600 eq4
                            if (s < 500)
                            {
                                s = 500;
                                labelObs.Text = "* A distância não pode ser menor que 500mm.";
                                labelObs.IsVisible = true;
                            }
                        }
                    }

                    //Para dispositivos de proteção com capacidade D > 40mm <= 70mm
                    //Segunda particularidade da norma (6.2.3.2)
                    if (d > 40)
                    {
                        s = (1600 * t) + 850;
                        labelObs.IsVisible = false;
                    }

                    //Cálculo para feixe único C = 1200
                    if (feixeUnico == true)
                    {
                        s = (1600 * t) + 1200;
                        labelResultado.Text = "Para Feixe Único: " + s + "mm";
                        labelTextoResultado.IsVisible = true;
                        labelObs.IsVisible = false;
                    }
                    else
                    {
                        labelResultado.Text = s + "mm";
                        labelTextoResultado.IsVisible = true;
                    }
                }

            }
            catch (FormatException)
            {
                DisplayAlert("Erro", "Valor informado é inválido", "ok");
            }
        }

        //Verifica se o caracter digitado é um número e o apaga caso não seja.
        private void TextChanged(object sender, TextChangedEventArgs args)
        {
            if (!string.IsNullOrWhiteSpace(args.NewTextValue))
            {
                bool numeroOk = args.NewTextValue.ToCharArray().All(x => char.IsDigit(x));

                ((Entry)sender).Text = numeroOk ? args.NewTextValue : args.NewTextValue.Remove(args.NewTextValue.Length - 1);
            }
        }

        private void entryTempo_TextChanged(object sender, TextChangedEventArgs args)
        {
            //string pattern = @"[.]";
            //string substitution = @",";
            //string input = entryTempo.Text;

            const string numRegex = @"^[0-9,]+$";
            if (!string.IsNullOrWhiteSpace(args.NewTextValue))
            {
                bool IsValid = Regex.IsMatch(args.NewTextValue, numRegex);
                ((Entry)sender).Text = IsValid ? args.NewTextValue : args.NewTextValue.Remove(args.NewTextValue.Length - 1);


            }

            //Regex regex = new Regex(pattern);
            //entryTempo.Text = regex.Replace(input, substitution);
        }

        bool feixeUnico;
        private void swFeixeUnico_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                feixeUnico = true;
            }
            else
            {
                feixeUnico = false;
            }
        }
    }
}
