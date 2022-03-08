
//Classe que define e retorna os índices das matrizes
//Também retorna o fator de multiplicação para posicionar as linhas da régua na tabela

namespace SigmaSafety
{
    public class Indices
    {
        public static int RiscoBaixoHh(int hh, out double coordenada)
        {
            //Definindo índice do eixo X (Hh, antigo A):
            if (hh >= 2500)
            {
                coordenada = 3.5;
                return 0;
            }
            else if (hh >= 2400 && hh < 2500)
            {
                coordenada = 4.5;
                return 1;
            }
            else if (hh >= 2200 && hh < 2400)
            {
                coordenada = 5.5;
                return 2;
            }
            else if (hh >= 2000 && hh < 2200)
            {
                coordenada = 6.5;
                return 3;
            }
            else if (hh >= 1800 && hh < 2000)
            {
                coordenada = 7.4;
                return 4;
            }
            else if (hh >= 1600 && hh < 1800)
            {
                coordenada = 8.3;
                return 5;
            }
            else if (hh >= 1400 && hh < 1600)
            {
                coordenada = 9.3;
                return 6;
            }
            else if (hh >= 1200 && hh < 1400)
            {
                coordenada = 10.3;
                return 7;
            }
            else if (hh >= 1000 && hh < 1200)
            {
                coordenada = 11.3;
                return 8;
            }
            else if (hh >= 800 && hh < 1000)
            {
                coordenada = 12.3;
                return 9;
            }
            else if (hh >= 600 && hh < 800)
            {
                coordenada = 13.3;
                return 10;
            }
            else if (hh >= 400 && hh < 600)
            {
                coordenada = 14.3;
                return 11;
            }
            else if (hh >= 200 && hh < 400)
            {
                coordenada = 15.3;
                return 12;
            }
            else //(hh >= 0 && hh < 200)
            {
                coordenada = 16.3;
                return 13;
            }
        }

        public static int RiscoBaixoHps(int hps, out double coordenada)
        {
            //Definindo índice do eixo Y (Hps, antigo B):
            if (hps >= 1000 && hps < 1200)
            {
                coordenada = 1.6;
                return 0;
            }
            else if (hps >= 1200 && hps < 1400)
            {
                coordenada = 2.6;
                return 1;
            }
            else if (hps >= 1400 && hps < 1600)
            {
                coordenada = 3.6;
                return 2;
            }
            else if (hps >= 1600 && hps < 1800)
            {
                coordenada = 4.6;
                return 3;
            }
            else if (hps >= 1800 && hps < 2000)
            {
                coordenada = 5.5;
                return 4;
            }
            else if (hps >= 2000 && hps < 2200)
            {
                coordenada = 6.4;
                return 5;
            }
            else if (hps >= 2200 && hps < 2400)
            {
                coordenada = 7.4;
                return 6;
            }
            else if (hps >= 2400 && hps < 2500)
            {
                coordenada = 8.4;
                return 7;
            }
            else //(hps >= 2500)
            {
                coordenada = 9.5;
                return 8;
            }
        }

        public static int RiscoBaixoSh(int sh)
        {
            //Definindo índice do eixo Z (Sh, antigo C):
            if (sh >= 0 && sh < 100)
            {
                return 0;
            }
            else if (sh >= 100 && sh < 200)
            {
                return 1;
            }
            else if (sh >= 200 && sh < 250)
            {
                return 2;
            }
            else if (sh >= 250 && sh < 300)
            {
                return 3;
            }
            else if (sh >= 300 && sh < 350)
            {
                return 4;
            }
            else if (sh >= 350 && sh < 400)
            {
                return 5;
            }
            else if (sh >= 400 && sh < 500)
            {
                return 6;
            }
            else if (sh >= 500 && sh < 600)
            {
                return 7;
            }
            else if (sh >= 600 && sh < 700)
            {
                return 8;
            }
            else if (sh >= 700 && sh < 800)
            {
                return 9;
            }
            else if (sh >= 800 && sh < 900)
            {
                return 10;
            }
            else if (sh >= 900 && sh < 1000)
            {
                return 11;
            }
            else if (sh >= 1000 && sh < 1100)
            {
                return 12;
            }
            else if (sh >= 1100 && sh < 1200)
            {
                return 13;
            }
            else if (sh >= 1200 && sh < 1300)
            {
                return 14;
            }
            else if (sh >= 1300 && sh < 1400)
            {
                return 15;
            }
            else //(sh >= 1400)
            {
                return 16;
            }
        }

        public static int RiscoAltoHh(int hh, out double coordenada)
        {
            //Definindo índice do eixo X (Hh, antigo A):
            if (hh >= 2700)
            {
                coordenada = 3.5;
                return 0;
            }
            else if (hh >= 2600 && hh < 2700)
            {
                coordenada = 4.5;
                return 1;
            }
            else if (hh >= 2400 && hh < 2600)
            {
                coordenada = 5.5;
                return 2;
            }
            else if (hh >= 2200 && hh < 2400)
            {
                coordenada = 6.4;
                return 3;
            }
            else if (hh >= 2000 && hh < 2200)
            {
                coordenada = 7.4;
                return 4;
            }
            else if (hh >= 1800 && hh < 2000)
            {
                coordenada = 8.4;
                return 5;
            }
            else if (hh >= 1600 && hh < 1800)
            {
                coordenada = 9.3;
                return 6;
            }
            else if (hh >= 1400 && hh < 1600)
            {
                coordenada = 10.3;
                return 7;
            }
            else if (hh >= 1200 && hh < 1400)
            {
                coordenada = 11.3;
                return 8;
            }
            else if (hh >= 1000 && hh < 1200)
            {
                coordenada = 12.3;
                return 9;
            }
            else if (hh >= 800 && hh < 1000)
            {
                coordenada = 13.3;
                return 10;
            }
            else if (hh >= 600 && hh < 800)
            {
                coordenada = 14.3;
                return 11;
            }
            else if (hh >= 400 && hh < 600)
            {
                coordenada = 15.3;
                return 12;
            }
            else if (hh >= 200 && hh < 400)
            {
                coordenada = 16.3;
                return 13;
            }
            else //(hh >= 0 && hh < 200)
            {
                coordenada = 17.2;
                return 14;
            }
        }

        public static int RiscoAltoHps(int hps, out double coordenada)
        {
            //Definindo índice do eixo Y (Hps, antigo B):
            if (hps >= 1000 && hps < 1200)
            {
                coordenada = 1.6;
                return 0;
            }
            else if (hps >= 1200 && hps < 1400)
            {
                coordenada = 2.6;
                return 1;
            }
            else if (hps >= 1400 && hps < 1600)
            {
                coordenada = 3.6;
                return 2;
            }
            else if (hps >= 1600 && hps < 1800)
            {
                coordenada = 4.6;
                return 3;
            }
            else if (hps >= 1800 && hps < 2000)
            {
                coordenada = 5.6;
                return 4;
            }
            else if (hps >= 2000 && hps < 2200)
            {
                coordenada = 6.5;
                return 5;
            }
            else if (hps >= 2200 && hps < 2400)
            {
                coordenada = 7.5;
                return 6;
            }
            else if (hps >= 2400 && hps < 2500)
            {
                coordenada = 8.4;
                return 7;
            }
            else if (hps >= 2500 && hps < 2700)
            {
                coordenada = 9.4;
                return 8;
            }
            else //(hps >= 2700)
            {
                coordenada = 10.5;
                return 9;
            }
        }

        public static int RiscoAltoSh(int sh)
        {
            //Definindo índice do eixo Z (Sh, antigo C):
            if (sh >= 0 && sh < 100)
            {
                return 0;
            }
            else if (sh >= 100 && sh < 300)
            {
                return 1;
            }
            else if (sh >= 300 && sh < 400)
            {
                return 2;
            }
            else if (sh >= 400 && sh < 500)
            {
                return 3;
            }
            else if (sh >= 500 && sh < 600)
            {
                return 4;
            }
            else if (sh >= 600 && sh < 700)
            {
                return 5;
            }
            else if (sh >= 700 && sh < 800)
            {
                return 6;
            }
            else if (sh >= 800 && sh < 900)
            {
                return 7;
            }
            else if (sh >= 900 && sh < 1000)
            {
                return 8;
            }
            else if (sh >= 1000 && sh < 1100)
            {
                return 9;
            }
            else if (sh >= 1100 && sh < 1200)
            {
                return 10;
            }
            else if (sh >= 1200 && sh < 1300)
            {
                return 11;
            }
            else if (sh >= 1300 && sh < 1400)
            {
                return 12;
            }
            else if (sh >= 1400 && sh < 1500)
            {
                return 13;
            }
            else //(sh >= 1500)
            {
                return 14;
            }
        }
    }
}
