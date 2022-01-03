using System;

namespace Mydrugstore
{
    class program
    {
        static void Main(string[] args)
        {
            remedios remedio1 = new remedios();
            remedio1.nome = "Dorflex";
            remedio1.valor = 5.80;

            remedios remedio2 = new remedios();
            remedio2.nome = "Xarelto";
            remedio2.valor = 10.90;

            remedios remedio3 = new remedios();
            remedio3.nome = "Neosaldina";
            remedio3.valor = 7.40;

            remedios remedio4 = new remedios();
            remedio4.nome = "Glifage";
            remedio4.valor = 12.50;

            remedios remedio5 = new remedios();
            remedio5.nome = "Anthelios";
            remedio5.valor = 4.80;


            Console.WriteLine("*****************************************");
            Console.WriteLine("* Hello! what medication would you like? *");
            Console.WriteLine("*****************************************");
            Console.Write("Type here: ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Dorflex":
                    Console.WriteLine(" ");
                    Console.WriteLine($"we have this medication, it costs {remedio1.valor}");
                    break;
                case "Xarelto":
                    Console.WriteLine(" ");
                    Console.WriteLine($"we have this medication, it costs {remedio2.valor}");
                    break;
                case "Neosaldina":
                    Console.WriteLine(" ");
                    Console.WriteLine($"we have this medication, it costs {remedio3.valor}");
                    break;
                case "Glifage":
                    Console.WriteLine(" ");
                    Console.WriteLine($"we have this medication, it costs {remedio4.valor}");
                    break;
                case "Anthelios":
                    Console.WriteLine(" ");
                    Console.WriteLine($"we have this medication, it costs {remedio5.valor}");
                    break;
                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("Sorry, we don't have this medication");
                    break;
            }

            Console.ReadLine();
        }

    }

    public class remedios
    {
        public string nome;
        public double valor;
    }
}