using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SigmaSafety
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabela3 : ContentPage
    {
        public Tabela3()
        {
            InitializeComponent();
        }

        public void btnCalcular_Clicked(object sender, EventArgs e)
        {
            //var consulta = new ConsultaTabelas();
            //consulta.TabBaixoRisco(4, 5, 6);

            int hh = -1, hps = -1, sh = -1, a = -1, b = -1, c = -1;
            bool tudoOk = true;
            double altura, largura;

            //DisplayAlert("Imagem", "Altura: " + altura + " Largura: " + largura, "ok");
            //DisplayAlert("Régua", "Régua X: " + regua.TranslationX + " Régua Y: " + regua.TranslationY, "ok");

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

            if (tudoOk == true)
            {

                //TABELA1 BAIXO RISCO NBR 13857//
                if (riscoBaixo.IsChecked == true)
                {
                    imageTabela.Source = "Tabela2_BR.png";
                    altura = imageTabela.Height / 17;
                    largura = imageTabela.Width / 10;

                    //Definindo Hh (antigo A)
                    if (hh >= 2500)
                    {
                        a = 0;
                        regua.TranslationY = altura * 3.5;
                    }
                    if (hh >= 2400 && hh < 2500)
                    {
                        a = 1;
                        regua.TranslationY = altura * 4.5;
                    }
                    if (hh >= 2200 && hh < 2400)
                    {
                        a = 2;
                        regua.TranslationY = altura * 5.5;
                    }
                    if (hh >= 2000 && hh < 2200)
                    {
                        a = 3;
                        regua.TranslationY = altura * 6.5;
                    }
                    if (hh >= 1800 && hh < 2000)
                    {
                        a = 4;
                        regua.TranslationY = altura * 7.4;
                    }
                    if (hh >= 1600 && hh < 1800)
                    {
                        a = 5;
                        regua.TranslationY = altura * 8.3;
                    }
                    if (hh >= 1400 && hh < 1600)
                    {
                        a = 6;
                        regua.TranslationY = altura * 9.3;
                    }
                    if (hh >= 1200 && hh < 1400)
                    {
                        a = 7;
                        regua.TranslationY = altura * 10.3;
                    }
                    if (hh >= 1000 && hh < 1200)
                    {
                        a = 8;
                        regua.TranslationY = altura * 11.3;
                    }
                    if (hh >= 800 && hh < 1000)
                    {
                        a = 9;
                        regua.TranslationY = altura * 12.3;
                    }
                    if (hh >= 600 && hh < 800)
                    {
                        a = 10;
                        regua.TranslationY = altura * 13.3;
                    }
                    if (hh >= 400 && hh < 600)
                    {
                        a = 11;
                        regua.TranslationY = altura * 14.3;
                    }
                    if (hh >= 200 && hh < 400)
                    {
                        a = 12;
                        regua.TranslationY = altura * 15.3;
                    }
                    if (hh >= 0 && hh < 200)
                    {
                        a = 13;
                        regua.TranslationY = altura * 16.3;
                    }

                    //Definindo Hps (antigo B):
                    if (hps >= 1000 && hps < 1200)
                    {
                        b = 0;
                        regua.TranslationX = largura * 1.6;
                    }
                    if (hps >= 1200 && hps < 1400)
                    {
                        b = 1;
                        regua.TranslationX = largura * 2.6;
                    }
                    if (hps >= 1400 && hps < 1600)
                    {
                        b = 2;
                        regua.TranslationX = largura * 3.6;
                    }
                    if (hps >= 1600 && hps < 1800)
                    {
                        b = 3;
                        regua.TranslationX = largura * 4.6;
                    }
                    if (hps >= 1800 && hps < 2000)
                    {
                        b = 4;
                        regua.TranslationX = largura * 5.5;
                    }
                    if (hps >= 2000 && hps < 2200)
                    {
                        b = 5;
                        regua.TranslationX = largura * 6.4;
                    }
                    if (hps >= 2200 && hps < 2400)
                    {
                        b = 6;
                        regua.TranslationX = largura * 7.4;
                    }
                    if (hps >= 2400 && hps < 2500)
                    {
                        b = 7;
                        regua.TranslationX = largura * 8.4;
                    }
                    if (hps >= 2500)
                    {
                        b = 8;
                        regua.TranslationX = largura * 9.5;
                    }

                    //Definindo Sh (antigo C)
                    if (sh >= 0 && sh < 100)
                    {
                        c = 0;
                    }
                    if (sh >= 100 && sh < 200)
                    {
                        c = 1;
                    }
                    if (sh >= 200 && sh < 250)
                    {
                        c = 2;
                    }
                    if (sh >= 250 && sh < 300)
                    {
                        c = 3;
                    }
                    if (sh >= 300 && sh < 350)
                    {
                        c = 4;
                    }
                    if (sh >= 350 && sh < 400)
                    {
                        c = 5;
                    }
                    if (sh >= 400 && sh < 500)
                    {
                        c = 6;
                    }
                    if (sh >= 500 && sh < 600)
                    {
                        c = 7;
                    }
                    if (sh >= 600 && sh < 700)
                    {
                        c = 8;
                    }
                    if (sh >= 700 && sh < 800)
                    {
                        c = 9;
                    }
                    if (sh >= 800 && sh < 900)
                    {
                        c = 10;
                    }
                    if (sh >= 900 && sh < 1000)
                    {
                        c = 11;
                    }
                    if (sh >= 1000 && sh < 1100)
                    {
                        c = 12;
                    }
                    if (sh >= 1100 && sh < 1200)
                    {
                        c = 13;
                    }
                    if (sh >= 1200 && sh < 1300)
                    {
                        c = 14;
                    }
                    if (sh >= 1300 && sh < 1400)
                    {
                        c = 15;
                    }
                    if (sh >= 1400)
                    {
                        c = 16;
                    }

                    //Tabela A x C = B
                    string[,] tabelaRiscoBaixoHps = new string[14, 17]; //[a,c]
                    tabelaRiscoBaixoHps[0, 0] = "0";
                    tabelaRiscoBaixoHps[0, 1] = "0";
                    tabelaRiscoBaixoHps[0, 2] = "0";
                    tabelaRiscoBaixoHps[0, 3] = "0";
                    tabelaRiscoBaixoHps[0, 4] = "0";
                    tabelaRiscoBaixoHps[0, 5] = "0";
                    tabelaRiscoBaixoHps[0, 6] = "0";
                    tabelaRiscoBaixoHps[0, 7] = "0";
                    tabelaRiscoBaixoHps[0, 8] = "0";
                    tabelaRiscoBaixoHps[0, 9] = "0";
                    tabelaRiscoBaixoHps[0, 10] = "0";
                    tabelaRiscoBaixoHps[0, 11] = "0";
                    tabelaRiscoBaixoHps[0, 12] = "0";
                    tabelaRiscoBaixoHps[0, 13] = "0";
                    tabelaRiscoBaixoHps[0, 14] = "0";
                    tabelaRiscoBaixoHps[0, 15] = "0";
                    tabelaRiscoBaixoHps[0, 16] = "0";
                    tabelaRiscoBaixoHps[1, 0] = "2500";
                    tabelaRiscoBaixoHps[1, 1] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 2] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 3] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 4] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 5] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 6] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 7] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 8] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 9] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 10] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 11] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 12] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 13] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 14] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 15] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[1, 16] = "De 1000 a 2400";
                    tabelaRiscoBaixoHps[2, 0] = "0";
                    tabelaRiscoBaixoHps[2, 1] = "2400";
                    tabelaRiscoBaixoHps[2, 2] = "2400";
                    tabelaRiscoBaixoHps[2, 3] = "2200";
                    tabelaRiscoBaixoHps[2, 4] = "2200";
                    tabelaRiscoBaixoHps[2, 5] = "2000";
                    tabelaRiscoBaixoHps[2, 6] = "1800";
                    tabelaRiscoBaixoHps[2, 7] = "1400 ou 1600";
                    tabelaRiscoBaixoHps[2, 8] = "1000 ou 1200";
                    tabelaRiscoBaixoHps[2, 9] = "0";
                    tabelaRiscoBaixoHps[2, 10] = "0";
                    tabelaRiscoBaixoHps[2, 11] = "0";
                    tabelaRiscoBaixoHps[2, 12] = "0";
                    tabelaRiscoBaixoHps[2, 13] = "0";
                    tabelaRiscoBaixoHps[2, 14] = "0";
                    tabelaRiscoBaixoHps[2, 15] = "0";
                    tabelaRiscoBaixoHps[2, 16] = "0";
                    tabelaRiscoBaixoHps[3, 0] = "0";
                    tabelaRiscoBaixoHps[3, 1] = "0";
                    tabelaRiscoBaixoHps[3, 2] = "0";
                    tabelaRiscoBaixoHps[3, 3] = "0";
                    tabelaRiscoBaixoHps[3, 4] = "0";
                    tabelaRiscoBaixoHps[3, 5] = "2000";
                    tabelaRiscoBaixoHps[3, 6] = "2000";
                    tabelaRiscoBaixoHps[3, 7] = "1800";
                    tabelaRiscoBaixoHps[3, 8] = "1600";
                    tabelaRiscoBaixoHps[3, 9] = "1400";
                    tabelaRiscoBaixoHps[3, 10] = "1400";
                    tabelaRiscoBaixoHps[3, 11] = "1200";
                    tabelaRiscoBaixoHps[3, 12] = "1200";
                    tabelaRiscoBaixoHps[3, 13] = "1000";
                    tabelaRiscoBaixoHps[3, 14] = "0";
                    tabelaRiscoBaixoHps[3, 15] = "0";
                    tabelaRiscoBaixoHps[3, 16] = "0";
                    tabelaRiscoBaixoHps[4, 0] = "0";
                    tabelaRiscoBaixoHps[4, 1] = "0";
                    tabelaRiscoBaixoHps[4, 2] = "0";
                    tabelaRiscoBaixoHps[4, 3] = "0";
                    tabelaRiscoBaixoHps[4, 4] = "0";
                    tabelaRiscoBaixoHps[4, 5] = "0";
                    tabelaRiscoBaixoHps[4, 6] = "0";
                    tabelaRiscoBaixoHps[4, 7] = "0";
                    tabelaRiscoBaixoHps[4, 8] = "1800";
                    tabelaRiscoBaixoHps[4, 9] = "1800";
                    tabelaRiscoBaixoHps[4, 10] = "1800";
                    tabelaRiscoBaixoHps[4, 11] = "1400 ou 1600";
                    tabelaRiscoBaixoHps[4, 12] = "1200";
                    tabelaRiscoBaixoHps[4, 13] = "1200";
                    tabelaRiscoBaixoHps[4, 14] = "1000";
                    tabelaRiscoBaixoHps[4, 15] = "0";
                    tabelaRiscoBaixoHps[4, 16] = "0";
                    tabelaRiscoBaixoHps[5, 0] = "0";
                    tabelaRiscoBaixoHps[5, 1] = "0";
                    tabelaRiscoBaixoHps[5, 2] = "0";
                    tabelaRiscoBaixoHps[5, 3] = "0";
                    tabelaRiscoBaixoHps[5, 4] = "0";
                    tabelaRiscoBaixoHps[5, 5] = "0";
                    tabelaRiscoBaixoHps[5, 6] = "0";
                    tabelaRiscoBaixoHps[5, 7] = "1800";
                    tabelaRiscoBaixoHps[5, 8] = "1800";
                    tabelaRiscoBaixoHps[5, 9] = "1800";
                    tabelaRiscoBaixoHps[5, 10] = "1800";
                    tabelaRiscoBaixoHps[5, 11] = "1400";
                    tabelaRiscoBaixoHps[5, 12] = "1200";
                    tabelaRiscoBaixoHps[5, 13] = "1200";
                    tabelaRiscoBaixoHps[5, 14] = "1200";
                    tabelaRiscoBaixoHps[5, 15] = "1000";
                    tabelaRiscoBaixoHps[5, 16] = "0";
                    tabelaRiscoBaixoHps[6, 0] = "0";
                    tabelaRiscoBaixoHps[6, 1] = "1800";
                    tabelaRiscoBaixoHps[6, 2] = "1800";
                    tabelaRiscoBaixoHps[6, 3] = "1800";
                    tabelaRiscoBaixoHps[6, 4] = "1800";
                    tabelaRiscoBaixoHps[6, 5] = "1800";
                    tabelaRiscoBaixoHps[6, 6] = "1800";
                    tabelaRiscoBaixoHps[6, 7] = "1800";
                    tabelaRiscoBaixoHps[6, 8] = "1800";
                    tabelaRiscoBaixoHps[6, 9] = "1800";
                    tabelaRiscoBaixoHps[6, 10] = "1600";
                    tabelaRiscoBaixoHps[6, 11] = "1400";
                    tabelaRiscoBaixoHps[6, 12] = "1200";
                    tabelaRiscoBaixoHps[6, 13] = "1200";
                    tabelaRiscoBaixoHps[6, 14] = "1200";
                    tabelaRiscoBaixoHps[6, 15] = "1000";
                    tabelaRiscoBaixoHps[6, 16] = "0";
                    tabelaRiscoBaixoHps[7, 0] = "0";
                    tabelaRiscoBaixoHps[7, 1] = "0";
                    tabelaRiscoBaixoHps[7, 2] = "0";
                    tabelaRiscoBaixoHps[7, 3] = "0";
                    tabelaRiscoBaixoHps[7, 4] = "0";
                    tabelaRiscoBaixoHps[7, 5] = "0";
                    tabelaRiscoBaixoHps[7, 6] = "0";
                    tabelaRiscoBaixoHps[7, 7] = "1600";
                    tabelaRiscoBaixoHps[7, 8] = "1600";
                    tabelaRiscoBaixoHps[7, 9] = "1600";
                    tabelaRiscoBaixoHps[7, 10] = "1600";
                    tabelaRiscoBaixoHps[7, 11] = "1400";
                    tabelaRiscoBaixoHps[7, 12] = "1200";
                    tabelaRiscoBaixoHps[7, 13] = "1200";
                    tabelaRiscoBaixoHps[7, 14] = "1200";
                    tabelaRiscoBaixoHps[7, 15] = "1200";
                    tabelaRiscoBaixoHps[7, 16] = "1000";
                    tabelaRiscoBaixoHps[8, 0] = "0";
                    tabelaRiscoBaixoHps[8, 1] = "0";
                    tabelaRiscoBaixoHps[8, 2] = "0";
                    tabelaRiscoBaixoHps[8, 3] = "0";
                    tabelaRiscoBaixoHps[8, 4] = "1600";
                    tabelaRiscoBaixoHps[8, 5] = "1600";
                    tabelaRiscoBaixoHps[8, 6] = "1600";
                    tabelaRiscoBaixoHps[8, 7] = "1600";
                    tabelaRiscoBaixoHps[8, 8] = "1600";
                    tabelaRiscoBaixoHps[8, 9] = "1600";
                    tabelaRiscoBaixoHps[8, 10] = "1600";
                    tabelaRiscoBaixoHps[8, 11] = "1400";
                    tabelaRiscoBaixoHps[8, 12] = "1200";
                    tabelaRiscoBaixoHps[8, 13] = "1200";
                    tabelaRiscoBaixoHps[8, 14] = "1200";
                    tabelaRiscoBaixoHps[8, 15] = "1200";
                    tabelaRiscoBaixoHps[8, 16] = "1000";
                    tabelaRiscoBaixoHps[9, 0] = "0";
                    tabelaRiscoBaixoHps[9, 1] = "0";
                    tabelaRiscoBaixoHps[9, 2] = "0";
                    tabelaRiscoBaixoHps[9, 3] = "0";
                    tabelaRiscoBaixoHps[9, 4] = "0";
                    tabelaRiscoBaixoHps[9, 5] = "0";
                    tabelaRiscoBaixoHps[9, 6] = "0";
                    tabelaRiscoBaixoHps[9, 7] = "0";
                    tabelaRiscoBaixoHps[9, 8] = "1400";
                    tabelaRiscoBaixoHps[9, 9] = "1400";
                    tabelaRiscoBaixoHps[9, 10] = "1400";
                    tabelaRiscoBaixoHps[9, 11] = "1200";
                    tabelaRiscoBaixoHps[9, 12] = "1200";
                    tabelaRiscoBaixoHps[9, 13] = "1200";
                    tabelaRiscoBaixoHps[9, 14] = "1200";
                    tabelaRiscoBaixoHps[9, 15] = "1000";
                    tabelaRiscoBaixoHps[9, 16] = "0";
                    tabelaRiscoBaixoHps[10, 0] = "0";
                    tabelaRiscoBaixoHps[10, 1] = "0";
                    tabelaRiscoBaixoHps[10, 2] = "0";
                    tabelaRiscoBaixoHps[10, 3] = "0";
                    tabelaRiscoBaixoHps[10, 4] = "0";
                    tabelaRiscoBaixoHps[10, 5] = "0";
                    tabelaRiscoBaixoHps[10, 6] = "0";
                    tabelaRiscoBaixoHps[10, 7] = "1200";
                    tabelaRiscoBaixoHps[10, 8] = "1200";
                    tabelaRiscoBaixoHps[10, 9] = "1200";
                    tabelaRiscoBaixoHps[10, 10] = "1200";
                    tabelaRiscoBaixoHps[10, 11] = "1200";
                    tabelaRiscoBaixoHps[10, 12] = "1200";
                    tabelaRiscoBaixoHps[10, 13] = "1200";
                    tabelaRiscoBaixoHps[10, 14] = "1000";
                    tabelaRiscoBaixoHps[10, 15] = "0";
                    tabelaRiscoBaixoHps[10, 16] = "0";
                    tabelaRiscoBaixoHps[11, 0] = "0";
                    tabelaRiscoBaixoHps[11, 1] = "0";
                    tabelaRiscoBaixoHps[11, 2] = "0";
                    tabelaRiscoBaixoHps[11, 3] = "0";
                    tabelaRiscoBaixoHps[11, 4] = "1200";
                    tabelaRiscoBaixoHps[11, 5] = "1200";
                    tabelaRiscoBaixoHps[11, 6] = "1200";
                    tabelaRiscoBaixoHps[11, 7] = "1200";
                    tabelaRiscoBaixoHps[11, 8] = "1200";
                    tabelaRiscoBaixoHps[11, 9] = "1200";
                    tabelaRiscoBaixoHps[11, 10] = "1200";
                    tabelaRiscoBaixoHps[11, 11] = "1200";
                    tabelaRiscoBaixoHps[11, 12] = "1200";
                    tabelaRiscoBaixoHps[11, 13] = "1200";
                    tabelaRiscoBaixoHps[11, 14] = "1000";
                    tabelaRiscoBaixoHps[11, 15] = "0";
                    tabelaRiscoBaixoHps[11, 16] = "0";
                    tabelaRiscoBaixoHps[12, 0] = "0";
                    tabelaRiscoBaixoHps[12, 1] = "0";
                    tabelaRiscoBaixoHps[12, 2] = "1200";
                    tabelaRiscoBaixoHps[12, 3] = "1200";
                    tabelaRiscoBaixoHps[12, 4] = "1200";
                    tabelaRiscoBaixoHps[12, 5] = "1200";
                    tabelaRiscoBaixoHps[12, 6] = "1200";
                    tabelaRiscoBaixoHps[12, 7] = "1200";
                    tabelaRiscoBaixoHps[12, 8] = "1200";
                    tabelaRiscoBaixoHps[12, 9] = "1200";
                    tabelaRiscoBaixoHps[12, 10] = "1200";
                    tabelaRiscoBaixoHps[12, 11] = "1200";
                    tabelaRiscoBaixoHps[12, 12] = "1200";
                    tabelaRiscoBaixoHps[12, 13] = "1000";
                    tabelaRiscoBaixoHps[12, 14] = "0";
                    tabelaRiscoBaixoHps[12, 15] = "0";
                    tabelaRiscoBaixoHps[12, 16] = "0";
                    tabelaRiscoBaixoHps[13, 0] = "0";
                    tabelaRiscoBaixoHps[13, 1] = "0";
                    tabelaRiscoBaixoHps[13, 2] = "1200";
                    tabelaRiscoBaixoHps[13, 3] = "1200";
                    tabelaRiscoBaixoHps[13, 4] = "1200";
                    tabelaRiscoBaixoHps[13, 5] = "1200";
                    tabelaRiscoBaixoHps[13, 6] = "1200";
                    tabelaRiscoBaixoHps[13, 7] = "1200";
                    tabelaRiscoBaixoHps[13, 8] = "1200";
                    tabelaRiscoBaixoHps[13, 9] = "1200";
                    tabelaRiscoBaixoHps[13, 10] = "1200";
                    tabelaRiscoBaixoHps[13, 11] = "1200";
                    tabelaRiscoBaixoHps[13, 12] = "1200";
                    tabelaRiscoBaixoHps[13, 13] = "1000";
                    tabelaRiscoBaixoHps[13, 14] = "0";
                    tabelaRiscoBaixoHps[13, 15] = "0";
                    tabelaRiscoBaixoHps[13, 16] = "0";

                    //Tabela A x B = C
                    int[,] tabelaRiscoBaixoSh = new int[14, 9]; //[a,b]
                    tabelaRiscoBaixoSh[0, 0] = 0;
                    tabelaRiscoBaixoSh[0, 1] = 0;
                    tabelaRiscoBaixoSh[0, 2] = 0;
                    tabelaRiscoBaixoSh[0, 3] = 0;
                    tabelaRiscoBaixoSh[0, 4] = 0;
                    tabelaRiscoBaixoSh[0, 5] = 0;
                    tabelaRiscoBaixoSh[0, 6] = 0;
                    tabelaRiscoBaixoSh[0, 7] = 0;
                    tabelaRiscoBaixoSh[0, 8] = 0;
                    tabelaRiscoBaixoSh[1, 0] = 100;
                    tabelaRiscoBaixoSh[1, 1] = 100;
                    tabelaRiscoBaixoSh[1, 2] = 100;
                    tabelaRiscoBaixoSh[1, 3] = 100;
                    tabelaRiscoBaixoSh[1, 4] = 100;
                    tabelaRiscoBaixoSh[1, 5] = 100;
                    tabelaRiscoBaixoSh[1, 6] = 100;
                    tabelaRiscoBaixoSh[1, 7] = 100;
                    tabelaRiscoBaixoSh[1, 8] = 0;
                    tabelaRiscoBaixoSh[2, 0] = 600;
                    tabelaRiscoBaixoSh[2, 1] = 600;
                    tabelaRiscoBaixoSh[2, 2] = 500;
                    tabelaRiscoBaixoSh[2, 3] = 500;
                    tabelaRiscoBaixoSh[2, 4] = 400;
                    tabelaRiscoBaixoSh[2, 5] = 350;
                    tabelaRiscoBaixoSh[2, 6] = 250;
                    tabelaRiscoBaixoSh[2, 7] = 0;
                    tabelaRiscoBaixoSh[2, 8] = 0;
                    tabelaRiscoBaixoSh[3, 0] = 1100;
                    tabelaRiscoBaixoSh[3, 1] = 900;
                    tabelaRiscoBaixoSh[3, 2] = 700;
                    tabelaRiscoBaixoSh[3, 3] = 600;
                    tabelaRiscoBaixoSh[3, 4] = 500;
                    tabelaRiscoBaixoSh[3, 5] = 350;
                    tabelaRiscoBaixoSh[3, 6] = 0;
                    tabelaRiscoBaixoSh[3, 7] = 0;
                    tabelaRiscoBaixoSh[3, 8] = 0;
                    tabelaRiscoBaixoSh[4, 0] = 1100;
                    tabelaRiscoBaixoSh[4, 1] = 1100;
                    tabelaRiscoBaixoSh[4, 2] = 900;
                    tabelaRiscoBaixoSh[4, 3] = 900;
                    tabelaRiscoBaixoSh[4, 4] = 600;
                    tabelaRiscoBaixoSh[4, 5] = 0;
                    tabelaRiscoBaixoSh[4, 6] = 0;
                    tabelaRiscoBaixoSh[4, 7] = 0;
                    tabelaRiscoBaixoSh[4, 8] = 0;
                    tabelaRiscoBaixoSh[5, 0] = 1300;
                    tabelaRiscoBaixoSh[5, 1] = 1100;
                    tabelaRiscoBaixoSh[5, 2] = 900;
                    tabelaRiscoBaixoSh[5, 3] = 900;
                    tabelaRiscoBaixoSh[5, 4] = 500;
                    tabelaRiscoBaixoSh[5, 5] = 0;
                    tabelaRiscoBaixoSh[5, 6] = 0;
                    tabelaRiscoBaixoSh[5, 7] = 0;
                    tabelaRiscoBaixoSh[5, 8] = 0;
                    tabelaRiscoBaixoSh[6, 0] = 1300;
                    tabelaRiscoBaixoSh[6, 1] = 1000;
                    tabelaRiscoBaixoSh[6, 2] = 900;
                    tabelaRiscoBaixoSh[6, 3] = 800;
                    tabelaRiscoBaixoSh[6, 4] = 100;
                    tabelaRiscoBaixoSh[6, 5] = 0;
                    tabelaRiscoBaixoSh[6, 6] = 0;
                    tabelaRiscoBaixoSh[6, 7] = 0;
                    tabelaRiscoBaixoSh[6, 8] = 0;
                    tabelaRiscoBaixoSh[7, 0] = 1400;
                    tabelaRiscoBaixoSh[7, 1] = 1000;
                    tabelaRiscoBaixoSh[7, 2] = 900;
                    tabelaRiscoBaixoSh[7, 3] = 500;
                    tabelaRiscoBaixoSh[7, 4] = 0;
                    tabelaRiscoBaixoSh[7, 5] = 0;
                    tabelaRiscoBaixoSh[7, 6] = 0;
                    tabelaRiscoBaixoSh[7, 7] = 0;
                    tabelaRiscoBaixoSh[7, 8] = 0;
                    tabelaRiscoBaixoSh[8, 0] = 1400;
                    tabelaRiscoBaixoSh[8, 1] = 1000;
                    tabelaRiscoBaixoSh[8, 2] = 900;
                    tabelaRiscoBaixoSh[8, 3] = 300;
                    tabelaRiscoBaixoSh[8, 4] = 0;
                    tabelaRiscoBaixoSh[8, 5] = 0;
                    tabelaRiscoBaixoSh[8, 6] = 0;
                    tabelaRiscoBaixoSh[8, 7] = 0;
                    tabelaRiscoBaixoSh[8, 8] = 0;
                    tabelaRiscoBaixoSh[9, 0] = 1300;
                    tabelaRiscoBaixoSh[9, 1] = 900;
                    tabelaRiscoBaixoSh[9, 2] = 600;
                    tabelaRiscoBaixoSh[9, 3] = 0;
                    tabelaRiscoBaixoSh[9, 4] = 0;
                    tabelaRiscoBaixoSh[9, 5] = 0;
                    tabelaRiscoBaixoSh[9, 6] = 0;
                    tabelaRiscoBaixoSh[9, 7] = 0;
                    tabelaRiscoBaixoSh[9, 8] = 0;
                    tabelaRiscoBaixoSh[10, 0] = 1200;
                    tabelaRiscoBaixoSh[10, 1] = 500;
                    tabelaRiscoBaixoSh[10, 2] = 0;
                    tabelaRiscoBaixoSh[10, 3] = 0;
                    tabelaRiscoBaixoSh[10, 4] = 0;
                    tabelaRiscoBaixoSh[10, 5] = 0;
                    tabelaRiscoBaixoSh[10, 6] = 0;
                    tabelaRiscoBaixoSh[10, 7] = 0;
                    tabelaRiscoBaixoSh[10, 8] = 0;
                    tabelaRiscoBaixoSh[11, 0] = 1200;
                    tabelaRiscoBaixoSh[11, 1] = 300;
                    tabelaRiscoBaixoSh[11, 2] = 0;
                    tabelaRiscoBaixoSh[11, 3] = 0;
                    tabelaRiscoBaixoSh[11, 4] = 0;
                    tabelaRiscoBaixoSh[11, 5] = 0;
                    tabelaRiscoBaixoSh[11, 6] = 0;
                    tabelaRiscoBaixoSh[11, 7] = 0;
                    tabelaRiscoBaixoSh[11, 8] = 0;
                    tabelaRiscoBaixoSh[12, 0] = 1100;
                    tabelaRiscoBaixoSh[12, 1] = 200;
                    tabelaRiscoBaixoSh[12, 2] = 0;
                    tabelaRiscoBaixoSh[12, 3] = 0;
                    tabelaRiscoBaixoSh[12, 4] = 0;
                    tabelaRiscoBaixoSh[12, 5] = 0;
                    tabelaRiscoBaixoSh[12, 6] = 0;
                    tabelaRiscoBaixoSh[12, 7] = 0;
                    tabelaRiscoBaixoSh[12, 8] = 0;
                    tabelaRiscoBaixoSh[13, 0] = 1100;
                    tabelaRiscoBaixoSh[13, 1] = 200;
                    tabelaRiscoBaixoSh[13, 2] = 0;
                    tabelaRiscoBaixoSh[13, 3] = 0;
                    tabelaRiscoBaixoSh[13, 4] = 0;
                    tabelaRiscoBaixoSh[13, 5] = 0;
                    tabelaRiscoBaixoSh[13, 6] = 0;
                    tabelaRiscoBaixoSh[13, 7] = 0;
                    tabelaRiscoBaixoSh[13, 8] = 0;

                    //Tabela B x C = A
                    string[,] tabelaRiscoBaixoHh = new string[9, 17]; //[b,c]
                    tabelaRiscoBaixoHh[8, 0] = "0";
                    tabelaRiscoBaixoHh[8, 1] = "0";
                    tabelaRiscoBaixoHh[8, 2] = "0";
                    tabelaRiscoBaixoHh[8, 3] = "0";
                    tabelaRiscoBaixoHh[8, 4] = "0";
                    tabelaRiscoBaixoHh[8, 5] = "0";
                    tabelaRiscoBaixoHh[8, 6] = "0";
                    tabelaRiscoBaixoHh[8, 7] = "0";
                    tabelaRiscoBaixoHh[8, 8] = "0";
                    tabelaRiscoBaixoHh[8, 9] = "0";
                    tabelaRiscoBaixoHh[8, 10] = "0";
                    tabelaRiscoBaixoHh[8, 11] = "0";
                    tabelaRiscoBaixoHh[8, 12] = "0";
                    tabelaRiscoBaixoHh[8, 13] = "0";
                    tabelaRiscoBaixoHh[8, 14] = "0";
                    tabelaRiscoBaixoHh[8, 15] = "0";
                    tabelaRiscoBaixoHh[8, 16] = "0";
                    tabelaRiscoBaixoHh[7, 0] = "0";
                    tabelaRiscoBaixoHh[7, 1] = "2400";
                    tabelaRiscoBaixoHh[7, 2] = "0";
                    tabelaRiscoBaixoHh[7, 3] = "0";
                    tabelaRiscoBaixoHh[7, 4] = "0";
                    tabelaRiscoBaixoHh[7, 5] = "0";
                    tabelaRiscoBaixoHh[7, 6] = "0";
                    tabelaRiscoBaixoHh[7, 7] = "0";
                    tabelaRiscoBaixoHh[7, 8] = "0";
                    tabelaRiscoBaixoHh[7, 9] = "0";
                    tabelaRiscoBaixoHh[7, 10] = "0";
                    tabelaRiscoBaixoHh[7, 11] = "0";
                    tabelaRiscoBaixoHh[7, 12] = "0";
                    tabelaRiscoBaixoHh[7, 13] = "0";
                    tabelaRiscoBaixoHh[7, 14] = "0";
                    tabelaRiscoBaixoHh[7, 15] = "0";
                    tabelaRiscoBaixoHh[7, 16] = "0";
                    tabelaRiscoBaixoHh[6, 0] = "0";
                    tabelaRiscoBaixoHh[6, 1] = "2400";
                    tabelaRiscoBaixoHh[6, 2] = "2400";
                    tabelaRiscoBaixoHh[6, 3] = "2200";
                    tabelaRiscoBaixoHh[6, 4] = "0";
                    tabelaRiscoBaixoHh[6, 5] = "0";
                    tabelaRiscoBaixoHh[6, 6] = "0";
                    tabelaRiscoBaixoHh[6, 7] = "0";
                    tabelaRiscoBaixoHh[6, 8] = "0";
                    tabelaRiscoBaixoHh[6, 9] = "0";
                    tabelaRiscoBaixoHh[6, 10] = "0";
                    tabelaRiscoBaixoHh[6, 11] = "0";
                    tabelaRiscoBaixoHh[6, 12] = "0";
                    tabelaRiscoBaixoHh[6, 13] = "0";
                    tabelaRiscoBaixoHh[6, 14] = "0";
                    tabelaRiscoBaixoHh[6, 15] = "0";
                    tabelaRiscoBaixoHh[6, 16] = "0";
                    tabelaRiscoBaixoHh[5, 0] = "0";
                    tabelaRiscoBaixoHh[5, 1] = "2400";
                    tabelaRiscoBaixoHh[5, 2] = "2400";
                    tabelaRiscoBaixoHh[5, 3] = "2200";
                    tabelaRiscoBaixoHh[5, 4] = "2200";
                    tabelaRiscoBaixoHh[5, 5] = "Não estar entre 2000 e 2200";
                    tabelaRiscoBaixoHh[5, 6] = "0";
                    tabelaRiscoBaixoHh[5, 7] = "0";
                    tabelaRiscoBaixoHh[5, 8] = "0";
                    tabelaRiscoBaixoHh[5, 9] = "0";
                    tabelaRiscoBaixoHh[5, 10] = "0";
                    tabelaRiscoBaixoHh[5, 11] = "0";
                    tabelaRiscoBaixoHh[5, 12] = "0";
                    tabelaRiscoBaixoHh[5, 13] = "0";
                    tabelaRiscoBaixoHh[5, 14] = "0";
                    tabelaRiscoBaixoHh[5, 15] = "0";
                    tabelaRiscoBaixoHh[5, 16] = "0";
                    tabelaRiscoBaixoHh[4, 0] = "0";
                    tabelaRiscoBaixoHh[4, 1] = "Não estar entre 1400 e 2400";
                    tabelaRiscoBaixoHh[4, 2] = "Não estar entre 1400 e 2400";
                    tabelaRiscoBaixoHh[4, 3] = "Não estar entre 1400 e 2400";
                    tabelaRiscoBaixoHh[4, 4] = "Não estar entre 1400 e 2400";
                    tabelaRiscoBaixoHh[4, 5] = "Não estar entre 1400 e 2400";
                    tabelaRiscoBaixoHh[4, 6] = "2200";
                    tabelaRiscoBaixoHh[4, 7] = "Não estar entre 1600 e 2000";
                    tabelaRiscoBaixoHh[4, 8] = "1800";
                    tabelaRiscoBaixoHh[4, 9] = "0";
                    tabelaRiscoBaixoHh[4, 10] = "0";
                    tabelaRiscoBaixoHh[4, 11] = "0";
                    tabelaRiscoBaixoHh[4, 12] = "0";
                    tabelaRiscoBaixoHh[4, 13] = "0";
                    tabelaRiscoBaixoHh[4, 14] = "0";
                    tabelaRiscoBaixoHh[4, 15] = "0";
                    tabelaRiscoBaixoHh[4, 16] = "0";
                    tabelaRiscoBaixoHh[3, 0] = "0";
                    tabelaRiscoBaixoHh[3, 1] = "2400";
                    tabelaRiscoBaixoHh[3, 2] = "2400";
                    tabelaRiscoBaixoHh[3, 3] = "2400";
                    tabelaRiscoBaixoHh[3, 4] = "1000";
                    tabelaRiscoBaixoHh[3, 5] = "1000";
                    tabelaRiscoBaixoHh[3, 6] = "1000";
                    tabelaRiscoBaixoHh[3, 7] = "Não estar entre 1200 e 2200";
                    tabelaRiscoBaixoHh[3, 8] = "2000";
                    tabelaRiscoBaixoHh[3, 9] = "2000";
                    tabelaRiscoBaixoHh[3, 10] = "1400";
                    tabelaRiscoBaixoHh[3, 11] = "Não estar entre 1600 e 1800";
                    tabelaRiscoBaixoHh[3, 12] = "0";
                    tabelaRiscoBaixoHh[3, 13] = "0";
                    tabelaRiscoBaixoHh[3, 14] = "0";
                    tabelaRiscoBaixoHh[3, 15] = "0";
                    tabelaRiscoBaixoHh[3, 16] = "0";
                    tabelaRiscoBaixoHh[2, 0] = "0";
                    tabelaRiscoBaixoHh[2, 1] = "2400";
                    tabelaRiscoBaixoHh[2, 2] = "2400";
                    tabelaRiscoBaixoHh[2, 3] = "2400";
                    tabelaRiscoBaixoHh[2, 4] = "2400";
                    tabelaRiscoBaixoHh[2, 5] = "2400";
                    tabelaRiscoBaixoHh[2, 6] = "2400";
                    tabelaRiscoBaixoHh[2, 7] = "2200";
                    tabelaRiscoBaixoHh[2, 8] = "800";
                    tabelaRiscoBaixoHh[2, 9] = "1000";
                    tabelaRiscoBaixoHh[2, 10] = "1000";
                    tabelaRiscoBaixoHh[2, 11] = "Não estar entre 1000 e 1800";
                    tabelaRiscoBaixoHh[2, 12] = "0";
                    tabelaRiscoBaixoHh[2, 13] = "0";
                    tabelaRiscoBaixoHh[2, 14] = "0";
                    tabelaRiscoBaixoHh[2, 15] = "0";
                    tabelaRiscoBaixoHh[2, 16] = "0";
                    tabelaRiscoBaixoHh[1, 0] = "0";
                    tabelaRiscoBaixoHh[1, 1] = "2400";
                    tabelaRiscoBaixoHh[1, 2] = "Não estar entre 0 e 200";
                    tabelaRiscoBaixoHh[1, 3] = "Não estar entre 0 e 200";
                    tabelaRiscoBaixoHh[1, 4] = "400";
                    tabelaRiscoBaixoHh[1, 5] = "400";
                    tabelaRiscoBaixoHh[1, 6] = "400";
                    tabelaRiscoBaixoHh[1, 7] = "600";
                    tabelaRiscoBaixoHh[1, 8] = "2200";
                    tabelaRiscoBaixoHh[1, 9] = "2200";
                    tabelaRiscoBaixoHh[1, 10] = "2200";
                    tabelaRiscoBaixoHh[1, 11] = "Não estar entre 800 e 2000";
                    tabelaRiscoBaixoHh[1, 12] = "Não estar entre 1000 e 2000";
                    tabelaRiscoBaixoHh[1, 13] = "0";
                    tabelaRiscoBaixoHh[1, 14] = "0";
                    tabelaRiscoBaixoHh[1, 15] = "0";
                    tabelaRiscoBaixoHh[1, 16] = "0";
                    tabelaRiscoBaixoHh[0, 0] = "0";
                    tabelaRiscoBaixoHh[0, 1] = "2400";
                    tabelaRiscoBaixoHh[0, 2] = "2400";
                    tabelaRiscoBaixoHh[0, 3] = "2400";
                    tabelaRiscoBaixoHh[0, 4] = "2400";
                    tabelaRiscoBaixoHh[0, 5] = "2400";
                    tabelaRiscoBaixoHh[0, 6] = "2400";
                    tabelaRiscoBaixoHh[0, 7] = "2400";
                    tabelaRiscoBaixoHh[0, 8] = "2200";
                    tabelaRiscoBaixoHh[0, 9] = "2200";
                    tabelaRiscoBaixoHh[0, 10] = "2200";
                    tabelaRiscoBaixoHh[0, 11] = "2200";
                    tabelaRiscoBaixoHh[0, 12] = "2200";
                    tabelaRiscoBaixoHh[0, 13] = "Não estar entre 0 e 2000";
                    tabelaRiscoBaixoHh[0, 14] = "Não estar entre 400 e 600";
                    tabelaRiscoBaixoHh[0, 15] = "Não estar entre 800 e 1600";
                    tabelaRiscoBaixoHh[0, 16] = "Não estar entre 1000 e 1200";

                    try
                    {
                        if (sh == -1)
                        {
                            if (hps < 1000)
                            {
                                labelResultado.Text = "0";
                                labelObs.Text = "Estruturas de proteção (Hps) menores que 1000mm não restringem suficientemente o movimento do corpo.";
                                labelTextoResultado.IsVisible = true;
                                labelObs.IsVisible = true;
                                regua.TranslationX = largura / 2;
                                regua.TranslationY = altura / 2;
                            }
                            else
                            {
                                labelResultado.Text = "Sh(c) = " + Convert.ToString(tabelaRiscoBaixoSh[a, b]) + "mm";
                                labelTextoResultado.IsVisible = true;
                                labelObs.IsVisible = false;
                            }
                        }

                        if (hps == -1)
                        {
                            labelResultado.Text = "Hps(b) = " + Convert.ToString(tabelaRiscoBaixoHps[a, c]) + "mm";
                            labelTextoResultado.IsVisible = true;
                            labelObs.IsVisible = false;
                            regua.TranslationX = largura * 50;
                        }

                        if (hh == -1)
                        {
                            if (hps < 1000)
                            {
                                labelResultado.Text = "0";
                                labelObs.Text = "Estruturas de proteção (Hps) menores que 1000mm não restringem suficientemente o movimento do corpo.";
                                labelTextoResultado.IsVisible = true;
                                labelObs.IsVisible = true;
                                regua.TranslationX = largura / 2;
                                regua.TranslationY = altura / 2;
                            }
                            else
                            {
                                labelResultado.Text = "Hh(a) = " + Convert.ToString(tabelaRiscoBaixoHh[b, c]) + "mm";
                                labelTextoResultado.IsVisible = true;
                                labelObs.IsVisible = false;
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
                    imageTabela.Source = "Tabela2_AR.png";
                    altura = imageTabela.Height / 18;
                    largura = imageTabela.Width / 11;

                    //Definindo Hh (antigo A)
                    if (hh >= 2700)
                    {
                        a = 0;
                        regua.TranslationY = altura * 3.5;
                    }
                    if (hh >= 2600 && hh < 2700)
                    {
                        a = 1;
                        regua.TranslationY = altura * 4.5;
                    }
                    if (hh >= 2400 && hh < 2600)
                    {
                        a = 2;
                        regua.TranslationY = altura * 5.5;
                    }
                    if (hh >= 2200 && hh < 2400)
                    {
                        a = 3;
                        regua.TranslationY = altura * 6.4;
                    }
                    if (hh >= 2000 && hh < 2200)
                    {
                        a = 4;
                        regua.TranslationY = altura * 7.4;
                    }
                    if (hh >= 1800 && hh < 2000)
                    {
                        a = 5;
                        regua.TranslationY = altura * 8.4;
                    }
                    if (hh >= 1600 && hh < 1800)
                    {
                        a = 6;
                        regua.TranslationY = altura * 9.3;
                    }
                    if (hh >= 1400 && hh < 1600)
                    {
                        a = 7;
                        regua.TranslationY = altura * 10.3;
                    }
                    if (hh >= 1200 && hh < 1400)
                    {
                        a = 8;
                        regua.TranslationY = altura * 11.3;
                    }
                    if (hh >= 1000 && hh < 1200)
                    {
                        a = 9;
                        regua.TranslationY = altura * 12.3;
                    }
                    if (hh >= 800 && hh < 1000)
                    {
                        a = 10;
                        regua.TranslationY = altura * 13.3;
                    }
                    if (hh >= 600 && hh < 800)
                    {
                        a = 11;
                        regua.TranslationY = altura * 14.3;
                    }
                    if (hh >= 400 && hh < 600)
                    {
                        a = 12;
                        regua.TranslationY = altura * 15.3;
                    }
                    if (hh >= 200 && hh < 400)
                    {
                        a = 13;
                        regua.TranslationY = altura * 16.3;
                    }
                    if (hh >= 0 && hh < 200)
                    {
                        a = 14;
                        regua.TranslationY = altura * 17.2;
                    }

                    //Definindo Hps (antigo B):
                    if (hps >= 1000 && hps < 1200)
                    {
                        b = 0;
                        regua.TranslationX = largura * 1.6;
                    }
                    if (hps >= 1200 && hps < 1400)
                    {
                        b = 1;
                        regua.TranslationX = largura * 2.6;
                    }
                    if (hps >= 1400 && hps < 1600)
                    {
                        b = 2;
                        regua.TranslationX = largura * 3.6;
                    }
                    if (hps >= 1600 && hps < 1800)
                    {
                        b = 3;
                        regua.TranslationX = largura * 4.6;
                    }
                    if (hps >= 1800 && hps < 2000)
                    {
                        b = 4;
                        regua.TranslationX = largura * 5.6;
                    }
                    if (hps >= 2000 && hps < 2200)
                    {
                        b = 5;
                        regua.TranslationX = largura * 6.5;
                    }
                    if (hps >= 2200 && hps < 2400)
                    {
                        b = 6;
                        regua.TranslationX = largura * 7.5;
                    }
                    if (hps >= 2400 && hps < 2500)
                    {
                        b = 7;
                        regua.TranslationX = largura * 8.4;
                    }
                    if (hps >= 2500 && hps < 2700)
                    {
                        b = 8;
                        regua.TranslationX = largura * 9.4;
                    }
                    if (hps >= 2700)
                    {
                        b = 9;
                        regua.TranslationX = largura * 10.5;
                    }

                    //Definindo Sh (antigo C)
                    if (sh >= 0 && sh < 100)
                    {
                        c = 0;
                    }
                    if (sh >= 100 && sh < 300)
                    {
                        c = 1;
                    }
                    if (sh >= 300 && sh < 400)
                    {
                        c = 2;
                    }
                    if (sh >= 400 && sh < 500)
                    {
                        c = 3;
                    }
                    if (sh >= 500 && sh < 600)
                    {
                        c = 4;
                    }
                    if (sh >= 600 && sh < 700)
                    {
                        c = 5;
                    }
                    if (sh >= 700 && sh < 800)
                    {
                        c = 6;
                    }
                    if (sh >= 800 && sh < 900)
                    {
                        c = 7;
                    }
                    if (sh >= 900 && sh < 1000)
                    {
                        c = 8;
                    }
                    if (sh >= 1000 && sh < 1100)
                    {
                        c = 9;
                    }
                    if (sh >= 1100 && sh < 1200)
                    {
                        c = 10;
                    }
                    if (sh >= 1200 && sh < 1300)
                    {
                        c = 11;
                    }
                    if (sh >= 1300 && sh < 1400)
                    {
                        c = 12;
                    }
                    if (sh >= 1400 && sh < 1500)
                    {
                        c = 13;
                    }
                    if (sh >= 1500)
                    {
                        c = 14;
                    }

                    //Tabela A x C = B
                    string[,] tabelaRiscoAltoHps = new string[15, 15]; //[a,c]
                    tabelaRiscoAltoHps[0, 0] = "0";
                    tabelaRiscoAltoHps[0, 1] = "0";
                    tabelaRiscoAltoHps[0, 2] = "0";
                    tabelaRiscoAltoHps[0, 3] = "0";
                    tabelaRiscoAltoHps[0, 4] = "0";
                    tabelaRiscoAltoHps[0, 5] = "0";
                    tabelaRiscoAltoHps[0, 6] = "0";
                    tabelaRiscoAltoHps[0, 7] = "0";
                    tabelaRiscoAltoHps[0, 8] = "0";
                    tabelaRiscoAltoHps[0, 9] = "0";
                    tabelaRiscoAltoHps[0, 10] = "0";
                    tabelaRiscoAltoHps[0, 11] = "0";
                    tabelaRiscoAltoHps[0, 12] = "0";
                    tabelaRiscoAltoHps[0, 13] = "0";
                    tabelaRiscoAltoHps[0, 14] = "0";

                    tabelaRiscoAltoHps[1, 0] = "0";
                    tabelaRiscoAltoHps[1, 1] = "2500";
                    tabelaRiscoAltoHps[1, 2] = "2400";
                    tabelaRiscoAltoHps[1, 3] = "2200";
                    tabelaRiscoAltoHps[1, 4] = "2000";
                    tabelaRiscoAltoHps[1, 5] = "1600 ou 1800";
                    tabelaRiscoAltoHps[1, 6] = "1400";
                    tabelaRiscoAltoHps[1, 7] = "1200";
                    tabelaRiscoAltoHps[1, 8] = "1000";
                    tabelaRiscoAltoHps[1, 9] = "0";
                    tabelaRiscoAltoHps[1, 10] = "0";
                    tabelaRiscoAltoHps[1, 11] = "0";
                    tabelaRiscoAltoHps[1, 12] = "0";
                    tabelaRiscoAltoHps[1, 13] = "0";
                    tabelaRiscoAltoHps[1, 14] = "0";

                    tabelaRiscoAltoHps[2, 0] = "0";
                    tabelaRiscoAltoHps[2, 1] = "2500";
                    tabelaRiscoAltoHps[2, 2] = "2400";
                    tabelaRiscoAltoHps[2, 3] = "2200";
                    tabelaRiscoAltoHps[2, 4] = "2200";
                    tabelaRiscoAltoHps[2, 5] = "2000";
                    tabelaRiscoAltoHps[2, 6] = "1800";
                    tabelaRiscoAltoHps[2, 7] = "1600";
                    tabelaRiscoAltoHps[2, 8] = "1400";
                    tabelaRiscoAltoHps[2, 9] = "1200";
                    tabelaRiscoAltoHps[2, 10] = "1000";
                    tabelaRiscoAltoHps[2, 11] = "0";
                    tabelaRiscoAltoHps[2, 12] = "0";
                    tabelaRiscoAltoHps[2, 13] = "0";
                    tabelaRiscoAltoHps[2, 14] = "0";

                    tabelaRiscoAltoHps[3, 0] = "0";
                    tabelaRiscoAltoHps[3, 1] = "0";
                    tabelaRiscoAltoHps[3, 2] = "2400";
                    tabelaRiscoAltoHps[3, 3] = "2200";
                    tabelaRiscoAltoHps[3, 4] = "2200";
                    tabelaRiscoAltoHps[3, 5] = "2000";
                    tabelaRiscoAltoHps[3, 6] = "2000";
                    tabelaRiscoAltoHps[3, 7] = "1800";
                    tabelaRiscoAltoHps[3, 8] = "1600";
                    tabelaRiscoAltoHps[3, 9] = "1400";
                    tabelaRiscoAltoHps[3, 10] = "1400";
                    tabelaRiscoAltoHps[3, 11] = "1200";
                    tabelaRiscoAltoHps[3, 12] = "1000";
                    tabelaRiscoAltoHps[3, 13] = "0";
                    tabelaRiscoAltoHps[3, 14] = "0";

                    tabelaRiscoAltoHps[4, 0] = "0";
                    tabelaRiscoAltoHps[4, 1] = "0";
                    tabelaRiscoAltoHps[4, 2] = "0";
                    tabelaRiscoAltoHps[4, 3] = "2200";
                    tabelaRiscoAltoHps[4, 4] = "2200";
                    tabelaRiscoAltoHps[4, 5] = "2000";
                    tabelaRiscoAltoHps[4, 6] = "2000";
                    tabelaRiscoAltoHps[4, 7] = "1800";
                    tabelaRiscoAltoHps[4, 8] = "1600";
                    tabelaRiscoAltoHps[4, 9] = "1600";
                    tabelaRiscoAltoHps[4, 10] = "1400";
                    tabelaRiscoAltoHps[4, 11] = "1400";
                    tabelaRiscoAltoHps[4, 12] = "1200";
                    tabelaRiscoAltoHps[4, 13] = "1000";
                    tabelaRiscoAltoHps[4, 14] = "0";

                    tabelaRiscoAltoHps[5, 0] = "0";
                    tabelaRiscoAltoHps[5, 1] = "0";
                    tabelaRiscoAltoHps[5, 2] = "0";
                    tabelaRiscoAltoHps[5, 3] = "0";
                    tabelaRiscoAltoHps[5, 4] = "0";
                    tabelaRiscoAltoHps[5, 5] = "2000";
                    tabelaRiscoAltoHps[5, 6] = "2000";
                    tabelaRiscoAltoHps[5, 7] = "1800";
                    tabelaRiscoAltoHps[5, 8] = "1600";
                    tabelaRiscoAltoHps[5, 9] = "1600";
                    tabelaRiscoAltoHps[5, 10] = "1400";
                    tabelaRiscoAltoHps[5, 11] = "1400";
                    tabelaRiscoAltoHps[5, 12] = "1400";
                    tabelaRiscoAltoHps[5, 13] = "1200";
                    tabelaRiscoAltoHps[5, 14] = "1000";

                    tabelaRiscoAltoHps[6, 0] = "0";
                    tabelaRiscoAltoHps[6, 1] = "0";
                    tabelaRiscoAltoHps[6, 2] = "0";
                    tabelaRiscoAltoHps[6, 3] = "0";
                    tabelaRiscoAltoHps[6, 4] = "2000";
                    tabelaRiscoAltoHps[6, 5] = "2000";
                    tabelaRiscoAltoHps[6, 6] = "2000";
                    tabelaRiscoAltoHps[6, 7] = "1800";
                    tabelaRiscoAltoHps[6, 8] = "1600";
                    tabelaRiscoAltoHps[6, 9] = "1600";
                    tabelaRiscoAltoHps[6, 10] = "1400";
                    tabelaRiscoAltoHps[6, 11] = "1400";
                    tabelaRiscoAltoHps[6, 12] = "1400";
                    tabelaRiscoAltoHps[6, 13] = "1200";
                    tabelaRiscoAltoHps[6, 14] = "1000";

                    tabelaRiscoAltoHps[7, 0] = "0";
                    tabelaRiscoAltoHps[7, 1] = "0";
                    tabelaRiscoAltoHps[7, 2] = "0";
                    tabelaRiscoAltoHps[7, 3] = "0";
                    tabelaRiscoAltoHps[7, 4] = "0";
                    tabelaRiscoAltoHps[7, 5] = "0";
                    tabelaRiscoAltoHps[7, 6] = "0";
                    tabelaRiscoAltoHps[7, 7] = "1800";
                    tabelaRiscoAltoHps[7, 8] = "1600";
                    tabelaRiscoAltoHps[7, 9] = "1600";
                    tabelaRiscoAltoHps[7, 10] = "1400";
                    tabelaRiscoAltoHps[7, 11] = "1400";
                    tabelaRiscoAltoHps[7, 12] = "1400";
                    tabelaRiscoAltoHps[7, 13] = "1200";
                    tabelaRiscoAltoHps[7, 14] = "1000";

                    tabelaRiscoAltoHps[8, 0] = "0";
                    tabelaRiscoAltoHps[8, 1] = "0";
                    tabelaRiscoAltoHps[8, 2] = "0";
                    tabelaRiscoAltoHps[8, 3] = "0";
                    tabelaRiscoAltoHps[8, 4] = "0";
                    tabelaRiscoAltoHps[8, 5] = "0";
                    tabelaRiscoAltoHps[8, 6] = "1800";
                    tabelaRiscoAltoHps[8, 7] = "1800";
                    tabelaRiscoAltoHps[8, 8] = "1600";
                    tabelaRiscoAltoHps[8, 9] = "1600";
                    tabelaRiscoAltoHps[8, 10] = "1400";
                    tabelaRiscoAltoHps[8, 11] = "1400";
                    tabelaRiscoAltoHps[8, 12] = "1400";
                    tabelaRiscoAltoHps[8, 13] = "1200";
                    tabelaRiscoAltoHps[8, 14] = "1000";

                    tabelaRiscoAltoHps[9, 0] = "0";
                    tabelaRiscoAltoHps[9, 1] = "0";
                    tabelaRiscoAltoHps[9, 2] = "0";
                    tabelaRiscoAltoHps[9, 3] = "0";
                    tabelaRiscoAltoHps[9, 4] = "0";
                    tabelaRiscoAltoHps[9, 5] = "0";
                    tabelaRiscoAltoHps[9, 6] = "0";
                    tabelaRiscoAltoHps[9, 7] = "1600";
                    tabelaRiscoAltoHps[9, 8] = "1600";
                    tabelaRiscoAltoHps[9, 9] = "1400";
                    tabelaRiscoAltoHps[9, 10] = "1400";
                    tabelaRiscoAltoHps[9, 11] = "1400";
                    tabelaRiscoAltoHps[9, 12] = "1400";
                    tabelaRiscoAltoHps[9, 13] = "1200";
                    tabelaRiscoAltoHps[9, 14] = "1000";

                    tabelaRiscoAltoHps[10, 0] = "0";
                    tabelaRiscoAltoHps[10, 1] = "0";
                    tabelaRiscoAltoHps[10, 2] = "0";
                    tabelaRiscoAltoHps[10, 3] = "0";
                    tabelaRiscoAltoHps[10, 4] = "0";
                    tabelaRiscoAltoHps[10, 5] = "1600";
                    tabelaRiscoAltoHps[10, 6] = "1600";
                    tabelaRiscoAltoHps[10, 7] = "1600";
                    tabelaRiscoAltoHps[10, 8] = "1400";
                    tabelaRiscoAltoHps[10, 9] = "1400";
                    tabelaRiscoAltoHps[10, 10] = "1400";
                    tabelaRiscoAltoHps[10, 11] = "1400";
                    tabelaRiscoAltoHps[10, 12] = "1200";
                    tabelaRiscoAltoHps[10, 13] = "1200";
                    tabelaRiscoAltoHps[10, 14] = "1000";

                    tabelaRiscoAltoHps[11, 0] = "0";
                    tabelaRiscoAltoHps[11, 1] = "0";
                    tabelaRiscoAltoHps[11, 2] = "0";
                    tabelaRiscoAltoHps[11, 3] = "0";
                    tabelaRiscoAltoHps[11, 4] = "0";
                    tabelaRiscoAltoHps[11, 5] = "0";
                    tabelaRiscoAltoHps[11, 6] = "0";
                    tabelaRiscoAltoHps[11, 7] = "1400";
                    tabelaRiscoAltoHps[11, 8] = "1400";
                    tabelaRiscoAltoHps[11, 9] = "1400";
                    tabelaRiscoAltoHps[11, 10] = "1400";
                    tabelaRiscoAltoHps[11, 11] = "1400";
                    tabelaRiscoAltoHps[11, 12] = "1200";
                    tabelaRiscoAltoHps[11, 13] = "1200";
                    tabelaRiscoAltoHps[11, 14] = "1000";

                    tabelaRiscoAltoHps[12, 0] = "0";
                    tabelaRiscoAltoHps[12, 1] = "0";
                    tabelaRiscoAltoHps[12, 2] = "0";
                    tabelaRiscoAltoHps[12, 3] = "1400";
                    tabelaRiscoAltoHps[12, 4] = "1400";
                    tabelaRiscoAltoHps[12, 5] = "1400";
                    tabelaRiscoAltoHps[12, 6] = "1400";
                    tabelaRiscoAltoHps[12, 7] = "1400";
                    tabelaRiscoAltoHps[12, 8] = "1400";
                    tabelaRiscoAltoHps[12, 9] = "1400";
                    tabelaRiscoAltoHps[12, 10] = "1400";
                    tabelaRiscoAltoHps[12, 11] = "1200";
                    tabelaRiscoAltoHps[12, 12] = "1200";
                    tabelaRiscoAltoHps[12, 13] = "1000";
                    tabelaRiscoAltoHps[12, 14] = "0";

                    tabelaRiscoAltoHps[13, 0] = "0";
                    tabelaRiscoAltoHps[13, 1] = "0";
                    tabelaRiscoAltoHps[13, 2] = "0";
                    tabelaRiscoAltoHps[13, 3] = "0";
                    tabelaRiscoAltoHps[13, 4] = "0";
                    tabelaRiscoAltoHps[13, 5] = "0";
                    tabelaRiscoAltoHps[13, 6] = "0";
                    tabelaRiscoAltoHps[13, 7] = "0";
                    tabelaRiscoAltoHps[13, 8] = "1200";
                    tabelaRiscoAltoHps[13, 9] = "1200";
                    tabelaRiscoAltoHps[13, 10] = "1200";
                    tabelaRiscoAltoHps[13, 11] = "1000";
                    tabelaRiscoAltoHps[13, 12] = "0";
                    tabelaRiscoAltoHps[13, 13] = "0";
                    tabelaRiscoAltoHps[13, 14] = "0";

                    tabelaRiscoAltoHps[14, 0] = "0";
                    tabelaRiscoAltoHps[14, 1] = "0";
                    tabelaRiscoAltoHps[14, 2] = "0";
                    tabelaRiscoAltoHps[14, 3] = "0";
                    tabelaRiscoAltoHps[14, 4] = "1200";
                    tabelaRiscoAltoHps[14, 5] = "1200";
                    tabelaRiscoAltoHps[14, 6] = "1200";
                    tabelaRiscoAltoHps[14, 7] = "1200";
                    tabelaRiscoAltoHps[14, 8] = "1200";
                    tabelaRiscoAltoHps[14, 9] = "1200";
                    tabelaRiscoAltoHps[14, 10] = "1000";
                    tabelaRiscoAltoHps[14, 11] = "0";
                    tabelaRiscoAltoHps[14, 12] = "0";
                    tabelaRiscoAltoHps[14, 13] = "0";
                    tabelaRiscoAltoHps[14, 14] = "0";

                    //Tabela A x B = C
                    int[,] tabelaRiscoAltoSh = new int[15, 10]; //[a,b]
                    tabelaRiscoAltoSh[0, 0] = 0;
                    tabelaRiscoAltoSh[0, 1] = 0;
                    tabelaRiscoAltoSh[0, 2] = 0;
                    tabelaRiscoAltoSh[0, 3] = 0;
                    tabelaRiscoAltoSh[0, 4] = 0;
                    tabelaRiscoAltoSh[0, 5] = 0;
                    tabelaRiscoAltoSh[0, 6] = 0;
                    tabelaRiscoAltoSh[0, 7] = 0;
                    tabelaRiscoAltoSh[0, 8] = 0;
                    tabelaRiscoAltoSh[0, 9] = 0;
                    tabelaRiscoAltoSh[1, 0] = 0;
                    tabelaRiscoAltoSh[1, 1] = 800;
                    tabelaRiscoAltoSh[1, 2] = 700;
                    tabelaRiscoAltoSh[1, 3] = 600;
                    tabelaRiscoAltoSh[1, 4] = 600;
                    tabelaRiscoAltoSh[1, 5] = 500;
                    tabelaRiscoAltoSh[1, 6] = 400;
                    tabelaRiscoAltoSh[1, 7] = 300;
                    tabelaRiscoAltoSh[1, 8] = 100;
                    tabelaRiscoAltoSh[1, 9] = 0;
                    tabelaRiscoAltoSh[2, 0] = 1100;
                    tabelaRiscoAltoSh[2, 1] = 1100;
                    tabelaRiscoAltoSh[2, 2] = 900;
                    tabelaRiscoAltoSh[2, 3] = 800;
                    tabelaRiscoAltoSh[2, 4] = 700;
                    tabelaRiscoAltoSh[2, 5] = 600;
                    tabelaRiscoAltoSh[2, 6] = 400;
                    tabelaRiscoAltoSh[2, 7] = 300;
                    tabelaRiscoAltoSh[2, 8] = 100;
                    tabelaRiscoAltoSh[2, 9] = 0;
                    tabelaRiscoAltoSh[3, 0] = 1300;
                    tabelaRiscoAltoSh[3, 1] = 1200;
                    tabelaRiscoAltoSh[3, 2] = 1000;
                    tabelaRiscoAltoSh[3, 3] = 900;
                    tabelaRiscoAltoSh[3, 4] = 800;
                    tabelaRiscoAltoSh[3, 5] = 600;
                    tabelaRiscoAltoSh[3, 6] = 400;
                    tabelaRiscoAltoSh[3, 7] = 300;
                    tabelaRiscoAltoSh[3, 8] = 0;
                    tabelaRiscoAltoSh[3, 9] = 0;
                    tabelaRiscoAltoSh[4, 0] = 1400;
                    tabelaRiscoAltoSh[4, 1] = 1300;
                    tabelaRiscoAltoSh[4, 2] = 1100;
                    tabelaRiscoAltoSh[4, 3] = 900;
                    tabelaRiscoAltoSh[4, 4] = 800;
                    tabelaRiscoAltoSh[4, 5] = 600;
                    tabelaRiscoAltoSh[4, 6] = 400;
                    tabelaRiscoAltoSh[4, 7] = 0;
                    tabelaRiscoAltoSh[4, 8] = 0;
                    tabelaRiscoAltoSh[4, 9] = 0;
                    tabelaRiscoAltoSh[5, 0] = 1500;
                    tabelaRiscoAltoSh[5, 1] = 1400;
                    tabelaRiscoAltoSh[5, 2] = 1100;
                    tabelaRiscoAltoSh[5, 3] = 900;
                    tabelaRiscoAltoSh[5, 4] = 800;
                    tabelaRiscoAltoSh[5, 5] = 600;
                    tabelaRiscoAltoSh[5, 6] = 0;
                    tabelaRiscoAltoSh[5, 7] = 0;
                    tabelaRiscoAltoSh[5, 8] = 0;
                    tabelaRiscoAltoSh[5, 9] = 0;
                    tabelaRiscoAltoSh[6, 0] = 1500;
                    tabelaRiscoAltoSh[6, 1] = 1400;
                    tabelaRiscoAltoSh[6, 2] = 1100;
                    tabelaRiscoAltoSh[6, 3] = 900;
                    tabelaRiscoAltoSh[6, 4] = 800;
                    tabelaRiscoAltoSh[6, 5] = 500;
                    tabelaRiscoAltoSh[6, 6] = 0;
                    tabelaRiscoAltoSh[6, 7] = 0;
                    tabelaRiscoAltoSh[6, 8] = 0;
                    tabelaRiscoAltoSh[6, 9] = 0;
                    tabelaRiscoAltoSh[7, 0] = 1500;
                    tabelaRiscoAltoSh[7, 1] = 1400;
                    tabelaRiscoAltoSh[7, 2] = 1100;
                    tabelaRiscoAltoSh[7, 3] = 900;
                    tabelaRiscoAltoSh[7, 4] = 800;
                    tabelaRiscoAltoSh[7, 5] = 0;
                    tabelaRiscoAltoSh[7, 6] = 0;
                    tabelaRiscoAltoSh[7, 7] = 0;
                    tabelaRiscoAltoSh[7, 8] = 0;
                    tabelaRiscoAltoSh[7, 9] = 0;
                    tabelaRiscoAltoSh[8, 0] = 1500;
                    tabelaRiscoAltoSh[8, 1] = 1400;
                    tabelaRiscoAltoSh[8, 2] = 1100;
                    tabelaRiscoAltoSh[8, 3] = 900;
                    tabelaRiscoAltoSh[8, 4] = 700;
                    tabelaRiscoAltoSh[8, 5] = 0;
                    tabelaRiscoAltoSh[8, 6] = 0;
                    tabelaRiscoAltoSh[8, 7] = 0;
                    tabelaRiscoAltoSh[8, 8] = 0;
                    tabelaRiscoAltoSh[8, 9] = 0;
                    tabelaRiscoAltoSh[9, 0] = 1500;
                    tabelaRiscoAltoSh[9, 1] = 1400;
                    tabelaRiscoAltoSh[9, 2] = 1000;
                    tabelaRiscoAltoSh[9, 3] = 800;
                    tabelaRiscoAltoSh[9, 4] = 0;
                    tabelaRiscoAltoSh[9, 5] = 0;
                    tabelaRiscoAltoSh[9, 6] = 0;
                    tabelaRiscoAltoSh[9, 7] = 0;
                    tabelaRiscoAltoSh[9, 8] = 0;
                    tabelaRiscoAltoSh[9, 9] = 0;
                    tabelaRiscoAltoSh[10, 0] = 1500;
                    tabelaRiscoAltoSh[10, 1] = 1300;
                    tabelaRiscoAltoSh[10, 2] = 900;
                    tabelaRiscoAltoSh[10, 3] = 600;
                    tabelaRiscoAltoSh[10, 4] = 0;
                    tabelaRiscoAltoSh[10, 5] = 0;
                    tabelaRiscoAltoSh[10, 6] = 0;
                    tabelaRiscoAltoSh[10, 7] = 0;
                    tabelaRiscoAltoSh[10, 8] = 0;
                    tabelaRiscoAltoSh[10, 9] = 0;
                    tabelaRiscoAltoSh[11, 0] = 1400;
                    tabelaRiscoAltoSh[11, 1] = 1300;
                    tabelaRiscoAltoSh[11, 2] = 800;
                    tabelaRiscoAltoSh[11, 3] = 0;
                    tabelaRiscoAltoSh[11, 4] = 0;
                    tabelaRiscoAltoSh[11, 5] = 0;
                    tabelaRiscoAltoSh[11, 6] = 0;
                    tabelaRiscoAltoSh[11, 7] = 0;
                    tabelaRiscoAltoSh[11, 8] = 0;
                    tabelaRiscoAltoSh[11, 9] = 0;
                    tabelaRiscoAltoSh[12, 0] = 1400;
                    tabelaRiscoAltoSh[12, 1] = 1200;
                    tabelaRiscoAltoSh[12, 2] = 400;
                    tabelaRiscoAltoSh[12, 3] = 0;
                    tabelaRiscoAltoSh[12, 4] = 0;
                    tabelaRiscoAltoSh[12, 5] = 0;
                    tabelaRiscoAltoSh[12, 6] = 0;
                    tabelaRiscoAltoSh[12, 7] = 0;
                    tabelaRiscoAltoSh[12, 8] = 0;
                    tabelaRiscoAltoSh[12, 9] = 0;
                    tabelaRiscoAltoSh[13, 0] = 1200;
                    tabelaRiscoAltoSh[13, 1] = 900;
                    tabelaRiscoAltoSh[13, 2] = 0;
                    tabelaRiscoAltoSh[13, 3] = 0;
                    tabelaRiscoAltoSh[13, 4] = 0;
                    tabelaRiscoAltoSh[13, 5] = 0;
                    tabelaRiscoAltoSh[13, 6] = 0;
                    tabelaRiscoAltoSh[13, 7] = 0;
                    tabelaRiscoAltoSh[13, 8] = 0;
                    tabelaRiscoAltoSh[14, 9] = 0;
                    tabelaRiscoAltoSh[14, 0] = 1100;
                    tabelaRiscoAltoSh[14, 1] = 100;
                    tabelaRiscoAltoSh[14, 2] = 0;
                    tabelaRiscoAltoSh[14, 3] = 0;
                    tabelaRiscoAltoSh[14, 4] = 0;
                    tabelaRiscoAltoSh[14, 5] = 0;
                    tabelaRiscoAltoSh[14, 6] = 0;
                    tabelaRiscoAltoSh[14, 7] = 0;
                    tabelaRiscoAltoSh[14, 8] = 0;
                    tabelaRiscoAltoSh[14, 9] = 0;

                    //Tabela B x C = A
                    string[,] tabelaRiscoAltoHh = new string[10, 15]; //[b,c]
                    tabelaRiscoAltoHh[9, 0] = "0";
                    tabelaRiscoAltoHh[9, 1] = "0";
                    tabelaRiscoAltoHh[9, 2] = "0";
                    tabelaRiscoAltoHh[9, 3] = "0";
                    tabelaRiscoAltoHh[9, 4] = "0";
                    tabelaRiscoAltoHh[9, 5] = "0";
                    tabelaRiscoAltoHh[9, 6] = "0";
                    tabelaRiscoAltoHh[9, 7] = "0";
                    tabelaRiscoAltoHh[9, 8] = "0";
                    tabelaRiscoAltoHh[9, 9] = "0";
                    tabelaRiscoAltoHh[9, 10] = "0";
                    tabelaRiscoAltoHh[9, 11] = "0";
                    tabelaRiscoAltoHh[9, 12] = "0";
                    tabelaRiscoAltoHh[9, 13] = "0";
                    tabelaRiscoAltoHh[9, 14] = "0";

                    tabelaRiscoAltoHh[8, 0] = "0";
                    tabelaRiscoAltoHh[8, 1] = "Não estar entre 2400 e 2600";
                    tabelaRiscoAltoHh[8, 2] = "0";
                    tabelaRiscoAltoHh[8, 3] = "0";
                    tabelaRiscoAltoHh[8, 4] = "0";
                    tabelaRiscoAltoHh[8, 5] = "0";
                    tabelaRiscoAltoHh[8, 6] = "0";
                    tabelaRiscoAltoHh[8, 7] = "0";
                    tabelaRiscoAltoHh[8, 8] = "0";
                    tabelaRiscoAltoHh[8, 9] = "0";
                    tabelaRiscoAltoHh[8, 10] = "0";
                    tabelaRiscoAltoHh[8, 11] = "0";
                    tabelaRiscoAltoHh[8, 12] = "0";
                    tabelaRiscoAltoHh[8, 13] = "0";
                    tabelaRiscoAltoHh[8, 14] = "0";

                    tabelaRiscoAltoHh[7, 0] = "0";
                    tabelaRiscoAltoHh[7, 1] = "0";
                    tabelaRiscoAltoHh[7, 2] = "Não estar entre 2200 e 2600";
                    tabelaRiscoAltoHh[7, 3] = "0";
                    tabelaRiscoAltoHh[7, 4] = "0";
                    tabelaRiscoAltoHh[7, 5] = "0";
                    tabelaRiscoAltoHh[7, 6] = "0";
                    tabelaRiscoAltoHh[7, 7] = "0";
                    tabelaRiscoAltoHh[7, 8] = "0";
                    tabelaRiscoAltoHh[7, 9] = "0";
                    tabelaRiscoAltoHh[7, 10] = "0";
                    tabelaRiscoAltoHh[7, 11] = "0";
                    tabelaRiscoAltoHh[7, 12] = "0";
                    tabelaRiscoAltoHh[7, 13] = "0";
                    tabelaRiscoAltoHh[7, 14] = "0";

                    tabelaRiscoAltoHh[6, 0] = "0";
                    tabelaRiscoAltoHh[6, 1] = "0";
                    tabelaRiscoAltoHh[6, 2] = "0";
                    tabelaRiscoAltoHh[6, 3] = "Não estar entre 2000 e 2600";
                    tabelaRiscoAltoHh[6, 4] = "0";
                    tabelaRiscoAltoHh[6, 5] = "0";
                    tabelaRiscoAltoHh[6, 6] = "0";
                    tabelaRiscoAltoHh[6, 7] = "0";
                    tabelaRiscoAltoHh[6, 8] = "0";
                    tabelaRiscoAltoHh[6, 9] = "0";
                    tabelaRiscoAltoHh[6, 10] = "0";
                    tabelaRiscoAltoHh[6, 11] = "0";
                    tabelaRiscoAltoHh[6, 12] = "0";
                    tabelaRiscoAltoHh[6, 13] = "0";
                    tabelaRiscoAltoHh[6, 14] = "0";

                    tabelaRiscoAltoHh[5, 0] = "0";
                    tabelaRiscoAltoHh[5, 1] = "0";
                    tabelaRiscoAltoHh[5, 2] = "0";
                    tabelaRiscoAltoHh[5, 3] = "0";
                    tabelaRiscoAltoHh[5, 4] = "Não estar entre 1600 e 2600";
                    tabelaRiscoAltoHh[5, 5] = "Não estar entre 1800 e 2400";
                    tabelaRiscoAltoHh[5, 6] = "0";
                    tabelaRiscoAltoHh[5, 7] = "0";
                    tabelaRiscoAltoHh[5, 8] = "0";
                    tabelaRiscoAltoHh[5, 9] = "0";
                    tabelaRiscoAltoHh[5, 10] = "0";
                    tabelaRiscoAltoHh[5, 11] = "0";
                    tabelaRiscoAltoHh[5, 12] = "0";
                    tabelaRiscoAltoHh[5, 13] = "0";
                    tabelaRiscoAltoHh[5, 14] = "0";

                    tabelaRiscoAltoHh[4, 0] = "0";
                    tabelaRiscoAltoHh[4, 1] = "0";
                    tabelaRiscoAltoHh[4, 2] = "0";
                    tabelaRiscoAltoHh[4, 3] = "0";
                    tabelaRiscoAltoHh[4, 4] = "0";
                    tabelaRiscoAltoHh[4, 5] = "2600";
                    tabelaRiscoAltoHh[4, 6] = "Não estar entre 1200 e 2400";
                    tabelaRiscoAltoHh[4, 7] = "Não estar entre 1400 e 2200";
                    tabelaRiscoAltoHh[4, 8] = "0";
                    tabelaRiscoAltoHh[4, 9] = "0";
                    tabelaRiscoAltoHh[4, 10] = "0";
                    tabelaRiscoAltoHh[4, 11] = "0";
                    tabelaRiscoAltoHh[4, 12] = "0";
                    tabelaRiscoAltoHh[4, 13] = "0";
                    tabelaRiscoAltoHh[4, 14] = "0";

                    tabelaRiscoAltoHh[3, 0] = "0";
                    tabelaRiscoAltoHh[3, 1] = "0";
                    tabelaRiscoAltoHh[3, 2] = "0";
                    tabelaRiscoAltoHh[3, 3] = "0";
                    tabelaRiscoAltoHh[3, 4] = "0";
                    tabelaRiscoAltoHh[3, 5] = "Não estar entre 800 e 2600";
                    tabelaRiscoAltoHh[3, 6] = "Não estar entre 800 e 2600";
                    tabelaRiscoAltoHh[3, 7] = "Não estar entre 1000 e 2400";
                    tabelaRiscoAltoHh[3, 8] = "Não estar entre 1200 e 2200";
                    tabelaRiscoAltoHh[3, 9] = "0";
                    tabelaRiscoAltoHh[3, 10] = "0";
                    tabelaRiscoAltoHh[3, 11] = "0";
                    tabelaRiscoAltoHh[3, 12] = "0";
                    tabelaRiscoAltoHh[3, 13] = "0";
                    tabelaRiscoAltoHh[3, 14] = "0";

                    tabelaRiscoAltoHh[2, 0] = "0";
                    tabelaRiscoAltoHh[2, 1] = "0";
                    tabelaRiscoAltoHh[2, 2] = "0";
                    tabelaRiscoAltoHh[2, 3] = "400";
                    tabelaRiscoAltoHh[2, 4] = "400";
                    tabelaRiscoAltoHh[2, 5] = "400";
                    tabelaRiscoAltoHh[2, 6] = "2600";
                    tabelaRiscoAltoHh[2, 7] = "600";
                    tabelaRiscoAltoHh[2, 8] = "Não estar entre 800 e 2400";
                    tabelaRiscoAltoHh[2, 9] = "Não estar entre 1000 e 2200";
                    tabelaRiscoAltoHh[2, 10] = "Não estar entre 1200 e 2000";
                    tabelaRiscoAltoHh[2, 11] = "0";
                    tabelaRiscoAltoHh[2, 12] = "0";
                    tabelaRiscoAltoHh[2, 13] = "0";
                    tabelaRiscoAltoHh[2, 14] = "0";

                    tabelaRiscoAltoHh[1, 0] = "0";
                    tabelaRiscoAltoHh[1, 1] = "0";
                    tabelaRiscoAltoHh[1, 2] = "0";
                    tabelaRiscoAltoHh[1, 3] = "0";
                    tabelaRiscoAltoHh[1, 4] = "1200";
                    tabelaRiscoAltoHh[1, 5] = "1200";
                    tabelaRiscoAltoHh[1, 6] = "1200";
                    tabelaRiscoAltoHh[1, 7] = "2600";
                    tabelaRiscoAltoHh[1, 8] = "200";
                    tabelaRiscoAltoHh[1, 9] = "2400";
                    tabelaRiscoAltoHh[1, 10] = "2400";
                    tabelaRiscoAltoHh[1, 11] = "Não estar entre 400 e 2200";
                    tabelaRiscoAltoHh[1, 12] = "Não estar entre 600 e 2000";
                    tabelaRiscoAltoHh[1, 13] = "Não estar entre 1000 e 1800";
                    tabelaRiscoAltoHh[1, 14] = "0";

                    tabelaRiscoAltoHh[0, 0] = "0";
                    tabelaRiscoAltoHh[0, 1] = "0";
                    tabelaRiscoAltoHh[0, 2] = "0";
                    tabelaRiscoAltoHh[0, 3] = "0";
                    tabelaRiscoAltoHh[0, 4] = "0";
                    tabelaRiscoAltoHh[0, 5] = "0";
                    tabelaRiscoAltoHh[0, 6] = "0";
                    tabelaRiscoAltoHh[0, 7] = "0";
                    tabelaRiscoAltoHh[0, 8] = "2600";
                    tabelaRiscoAltoHh[0, 9] = "2600";
                    tabelaRiscoAltoHh[0, 10] = "Não estar entre 0 e 2400";
                    tabelaRiscoAltoHh[0, 11] = "200";
                    tabelaRiscoAltoHh[0, 12] = "2400";
                    tabelaRiscoAltoHh[0, 13] = "Não estar entre 400/600 e 2000";
                    tabelaRiscoAltoHh[0, 14] = "Não estar entre 800 e 1800";

                    try
                    {
                        if (sh == -1)
                        {
                            if (hps < 1000)
                            {
                                labelResultado.Text = "0";
                                labelObs.Text = "Estruturas de proteção (Hps) menores que 1000mm não restringem suficientemente o movimento do corpo.";
                                labelTextoResultado.IsVisible = true;
                                labelObs.IsVisible = true;
                                regua.TranslationX = largura / 2;
                                regua.TranslationY = altura / 2;
                            }
                            else
                            {
                                labelResultado.Text = "Sh(c) = " + Convert.ToString(tabelaRiscoAltoSh[a, b]);
                                labelObs.IsVisible = false;

                                if (tabelaRiscoAltoSh[a, b] < 1400)
                                {
                                    labelObs.Text = "* Não convém que as estruturas de proteção menores que 1400mm sejam aplicadas sem medidas de proteção adicionais.";
                                    labelObs.IsVisible = true;
                                }

                                labelTextoResultado.IsVisible = true;
                            }
                        }
                        if (hps == -1)
                        {
                            labelResultado.Text = "Hps(b) = " + tabelaRiscoAltoHps[a, c] + "mm";
                            labelTextoResultado.IsVisible = true;
                            labelObs.IsVisible = false;
                            regua.TranslationX = largura * 50;

                        }

                        if (hh == -1)
                        {
                            if (hps < 1000)
                            {
                                labelResultado.Text = "0";
                                labelObs.Text = "Estruturas de proteção (Hps) menores que 1000mm não restringem suficientemente o movimento do corpo.";
                                labelTextoResultado.IsVisible = true;
                                labelObs.IsVisible = true;
                                regua.TranslationX = largura / 2;
                                regua.TranslationY = altura / 2;
                            }
                            else
                            {
                                labelResultado.Text = "Hh(a) = " + tabelaRiscoAltoHh[b, c] + "mm";
                                labelTextoResultado.IsVisible = true;
                                labelObs.IsVisible = false;
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