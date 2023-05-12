using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius, Fahrenheit, Kelvin;
            Console.WriteLine("###  CONVERSOR DE TEMPERATURAS  ###");
            Console.WriteLine("Insira a temperatura em Celsius ");
            Celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");


            //(Celsius * 9 / 5) + 32 = Fahrenheit
            Fahrenheit = (Celsius * 9/ 5) +32;

            // Celsius + 273,15
            Kelvin = Celsius + 273.15;

            Console.WriteLine(Celsius + " graus Celcius = " + Fahrenheit + " graus Fahrenheit ");
            Console.WriteLine(Celsius + " graus Celcius = " + Kelvin + " graus Kelvin ");
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();

        }
    }
}
