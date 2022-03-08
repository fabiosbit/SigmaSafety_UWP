using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SigmaSafety
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraBarreira : ContentPage
    {
        public CalculadoraBarreira()
        {
            InitializeComponent();
        }

        //Recebe as dimenções das tabelas.png
        double altura, largura;

        public void btnCalcular_Clicked(object sender, EventArgs e)
        {
            int hh = -1, hps = -1, sh = -1, x = -1, y = -1, z = -1;
            bool tudoOk = true;

            //Verifica os campos e captura seus valores:
            try
            {
                if (Hh.Text != null && Hh.Text != "")
                {
                    hh = Convert.ToInt16(Hh.Text);
                }
                else
                {
                    hh = -1;
                }

                if (Hps.Text != null && Hps.Text != "")
                {
                    hps = Convert.ToInt16(Hps.Text);
                }
                else
                {
                    hps = -1;
                }

                if (Sh.Text != null && Sh.Text != "")
                {
                    sh = Convert.ToInt16(Sh.Text);
                }
                else
                {
                    sh = -1;
                }

                //Informa o usuário caso os campos não sejam preenchidos corretamente:
                if (hh == -1 && hps == -1 && sh == -1)
                {
                    DisplayAlert("Erro", "Nenhum valor informado", "Voltar");
                    tudoOk = false;
                }
                if (hh != -1 && hps != -1 && sh != -1)
                {
                    DisplayAlert("Erro", "Informe apenas dois valores", "Voltar");
                    tudoOk = false;
                }
                if (hh != -1 && hps == -1 && sh == -1)
                {
                    DisplayAlert("Erro", "Informe o valor de Hps ou Sh", "Voltar");
                    tudoOk = false;
                }
                if (hh == -1 && hps != -1 && sh == -1)
                {
                    DisplayAlert("Erro", "Informe o valor de Hh ou Sh", "Voltar");
                    tudoOk = false;
                }
                if (hh == -1 && hps == -1 && sh != -1)
                {
                    DisplayAlert("Erro", "Informe o valor de Hh ou Hps", "Voltar");
                    tudoOk = false;
                }
            }
            catch (Exception erro)
            {
                DisplayAlert("Erro", erro.Message, "Voltar");
            }

            //Calcula os índices se os dados de entrada estiverem ok:
            if (tudoOk == true)
            {
                //TABELA1 BAIXO RISCO NBR 13857//
                if (riscoBaixo.IsChecked == true)
                {
                    //Exibir Resultados:
                    try
                    {
                        imageTabela.Source = "Tabela2_BR.png";
                        altura = imageTabela.Height / 17;
                        largura = imageTabela.Width / 10;

                        //Definindo os índices:
                        x = Indices.RiscoBaixoHh(hh, out double coordenadaY);
                        regua.TranslationY = altura * coordenadaY;
                        y = Indices.RiscoBaixoHps(hps, out double coordenadaX);
                        regua.TranslationX = largura * coordenadaX;
                        z = Indices.RiscoBaixoSh(sh);

                        //Exibindo resultado de SH risco baixo:
                        if (sh == -1)
                        {
                            if (hps < 1000)
                            {
                                LimiteHps();
                            }
                            else
                            {
                                labelResultado.Text = "Sh(c) = " + Tabelas.RiscoBaixoSh(x, y) + "mm";
                                ExibirCampoResultado();
                            }
                        }

                        //Exibindo resultado de HPS risco baixo:
                        else if (hps == -1)
                        {
                            labelResultado.Text = "Hps(b) = " + Tabelas.RiscoBaixoHps(x, z) + "mm";
                            ExibirCampoResultado();
                            regua.TranslationX = largura * 50;
                        }

                        //Exibindo resultado de HH risco baixo:
                        else if (hh == -1)
                        {
                            if (hps < 1000)
                            {
                                LimiteHps();
                            }
                            else
                            {
                                labelResultado.Text = "Hh(a) = " + Tabelas.RiscoBaixoHh(y, z) + "mm";
                                ExibirCampoResultado();
                                regua.TranslationY = altura * 50;
                            }
                        }
                    }
                    catch (Exception msg)
                    {
                        DisplayAlert("Erro", msg.Message, "ok");
                    }
                }

                //TABELA2 ALTO RISCO NBR 13857//
                if (riscoAlto.IsChecked == true)
                {
                    //Exibindo os resultados:
                    try
                    {
                        imageTabela.Source = "Tabela2_AR.png";
                        altura = imageTabela.Height / 18;
                        largura = imageTabela.Width / 11;

                        //Definindo os índices:
                        x = Indices.RiscoAltoHh(hh, out double coordenadaY);
                        regua.TranslationY = altura * coordenadaY;
                        y = Indices.RiscoAltoHps(hps, out double coordenadaX);
                        regua.TranslationX = largura * coordenadaX;
                        z = Indices.RiscoAltoSh(sh);

                        //Resultado de SH risco alto:
                        if (sh == -1)
                        {
                            if (hps < 1000)
                            {
                                LimiteHps();
                            }
                            else
                            {
                                labelResultado.Text = "Sh(c) = " + Tabelas.RiscoAltoSh(x, y);
                                ExibirCampoResultado();

                                if (Tabelas.RiscoAltoSh(x, y) < 1400)
                                {
                                    labelObs.Text = "* Não convém que as estruturas de proteção menores que 1400mm sejam aplicadas sem medidas de proteção adicionais.";
                                    labelObs.IsVisible = true;
                                }
                            }
                        }

                        //Resultado de HPS risco alto:
                        if (hps == -1)
                        {
                            labelResultado.Text = "Hps(b) = " + Tabelas.RiscoAltoHps(x, z) + "mm";
                            ExibirCampoResultado();
                            regua.TranslationX = largura * 50;
                        }

                        //Resultado de HH risco alto:
                        if (hh == -1)
                        {
                            if (hps < 1000)
                            {
                                LimiteHps();
                            }
                            else
                            {
                                labelResultado.Text = "Hh(a) = " + Tabelas.RiscoAltoHh(y, z) + "mm";
                                ExibirCampoResultado();
                                regua.TranslationY = altura * 50;
                            }
                        }
                    }
                    catch (Exception msg)
                    {
                        DisplayAlert("Erro", msg.Message, "ok");
                    }
                }
            }
        }

        private void LimiteHps()
        {
            labelResultado.Text = "0";
            labelObs.Text = "Estruturas de proteção (Hps) menores que 1000mm não restringem suficientemente o movimento do corpo.";
            labelTextoResultado.IsVisible = true;
            labelObs.IsVisible = true;
            regua.TranslationX = largura / 2;
            regua.TranslationY = altura / 2;
        }

        private void ExibirCampoResultado()
        {
            labelTextoResultado.IsVisible = true;
            labelObs.IsVisible = false;
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

        //Posiciona o segundo jogo de segmentos de régua, para quando o primeiro sair da tela.
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            regua.Children[0].TranslationY = imageTabela.Height;
            regua.Children[1].TranslationY = -imageTabela.Height;
            regua.Children[4].TranslationX = imageTabela.Width;
            regua.Children[5].TranslationX = -imageTabela.Width;
        }
    }
}