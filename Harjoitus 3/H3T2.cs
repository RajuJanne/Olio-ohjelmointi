using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Janne Rajuvaara
//NTK17SP

namespace H3T2
{
    class Program
    {
        static void Main(string[] args)
        {
            ViikonPaiva paiva;

            do
            {
                Write("Anna luku väliltä 1-7: ");
                string syote = ReadLine();

                try
                {
                    bool OnkoNumero = int.TryParse(syote, out int temp);
                    int numero = temp;

                    if (!OnkoNumero)
                    {
                        throw new Exception("Syöte ei ole kokonaisluku.");
                    }

                    if (temp < 1 || 7 < temp)
                    {
                        throw new Exception("Luku ei ole väliltä 1-7.");
                    }

                    else
                    {
                        paiva = (ViikonPaiva)numero;
                        WriteLine($"Lukua {numero} vastaa päivä {paiva}");
                        break;
                    }
                }

                catch (Exception e)
                {
                    WriteLine(e.Message);
                }

            } while (true);

            ReadKey();
        }

        public enum ViikonPaiva
        {
            Maanantai = 1,
            Tiistai,
            Keskiviikko,
            Torstai,
            Perjantai,
            Lauantai,
            Sunnuntai
        }
    }
}
