using System;

namespace IndiceDeMasaCorporal
{
    class Program
    {
        //Metodo para calcular el IMC
        static double CalcularIMC(double peso, double estatura)
        {
            return peso / (estatura * estatura);
        }
    

        //Metodo para obtener el estado nutricional
        static string ObtenerEstadoNutricional(double imc)
        {
            if (imc < 18.5) return "Peso bajo";
            else if (imc < 25.0) return "Peso normal";
            else if (imc < 30.0) return "Sobrepeso";
            else if (imc < 40.0) return "Obesidad";
            else return "Obesidad extrema";

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo del Indice de Masa Corporal (IMC)");

            Console.WriteLine("Ingrese su peso en kilogramos: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su estatura en metros: ");
            double estatura = Convert.ToDouble(Console.ReadLine());

            double imc = CalcularIMC(peso, estatura);
            string estado = ObtenerEstadoNutricional(imc);

            Console.WriteLine("Su IMC es: " + imc);
            Console.WriteLine("Estado nutricional: " + estado);

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }

}