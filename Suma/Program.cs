using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 10;
            double Num2 = 6.8;
            double Resultado;

            //Variable String
            string Saludo = "Hola";
            string Nombre = "Samantha";

            //Resultado = (Num1 + Num2);

            Resultado = (Num1 + 40);
            //Console.WriteLine(Resultado);

            Console.WriteLine(Saludo + " " + Nombre + ", " + "¿Cómo te encuentras?");
            Console.ReadKey();
        }
    }
}