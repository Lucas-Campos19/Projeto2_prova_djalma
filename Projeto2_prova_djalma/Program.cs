using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_prova_djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod, d, m, a;
            DateTime data;
            string mes = null;

            Console.WriteLine(" 1 - Atibaia");
            Console.WriteLine(" 2 - Bragança Paulista");
            Console.WriteLine(" 3 - Mairiporã");
            Console.WriteLine(" 4 - Nazaré");
            Console.WriteLine(" 5 - Terra Preta");
            Console.WriteLine(" 6 - Extrema");
            Console.WriteLine(" 7 - Vargem");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");


            Console.Write(" Pressione o número informado para a cidade escolhida:");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");

            Console.Write(" Insira a data(Com barras)");
            data = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");

            d = data.Day;
            m = data.Month;
            a = data.Year;

            switch (m)
            {
                case 1:
                    mes = "Janeiro";
                    break;
                case 2:
                    mes = "Fevereiro";
                    break;
                case 3:
                    mes = "Março";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Maio";
                    break;
                case 6:
                    mes = "Junho";
                    break;
                case 7:
                    mes = "Julho";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Setembro";
                    break;
                case 10:
                    mes = "Outubro";
                    break;
                case 11:
                    mes = "Novembro";
                    break;
                case 12:
                    mes = "Dezembro";
                    break;
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            
            if(cod == 1)
            {
                Console.WriteLine(" Atibaia" + " ," +  d  + " de " + mes + " de " + a);
            }
            else if(cod == 2)
            {
                Console.WriteLine(" Bragança Paulista" + " ," + d + " de " + mes + " de " + a);
            }
            else if(cod == 3)
            {
                Console.WriteLine(" Mairiporã" + " ," + d + " de " + mes + " de " + a); ;
            }
            else if(cod == 4)
            {
                Console.WriteLine(" Nazaré" + " ," + d + " de " + mes + " de " + a);
            }
            else if(cod == 5)
            {
                Console.WriteLine(" Terra Preta" + " ," + d + " de " + mes + " de " + a);
            }
            else if(cod == 6)
            {
                Console.WriteLine(" Extrema" + " ," + d + " de " + mes + " de " + a);
            }
            else if(cod == 7)
            {
                Console.WriteLine(" Vargem" + " ," + d + " de " + mes + " de " + a);
            }

            Console.ReadKey();

        }
    }
}
