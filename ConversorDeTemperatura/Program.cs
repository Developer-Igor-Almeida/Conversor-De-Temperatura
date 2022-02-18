using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("#### CONVERSOR DE TEMPERATURAS");
            Console.Write("Insira a temperatura em Celsius:  ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("--------");

            // (c * 9 / 5) + 32 = F

            f = (c * 9 / 5) + 32;

            Console.WriteLine("O valor convertido em Celsius para Fahrenheit");
            Console.WriteLine(f);
            Console.WriteLine("-------------------");
            // c + 273,15 = k

            k = c + 273.15;

            Console.WriteLine("O valor convertido em celsius para Kelvin");
            Console.WriteLine(k);

            Console.WriteLine("-----------");
            Console.ReadLine();

            Console.Write("Insira uma nova temperatura em Celsius:  ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------");

            f = (c * 9 / 5);
            k = c + 273.15;

            Console.WriteLine(c + "Valor em Graus  " + f + "valor em fahrenheit  ");
            Console.WriteLine(c + "Valor em Graus  " + k +  "Valor em Kelvin  ");
            Console.ReadKey();




            Console.ReadKey();


        }
    }
}
