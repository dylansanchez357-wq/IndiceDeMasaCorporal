using IndiceDeMasaCorporal;

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

            Console.WriteLine("Proporcione el peso en kilogramos de la persona: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Proporcione la estatura en metros de la persona: ");
            double estatura = Convert.ToDouble(Console.ReadLine());

            double imc = CalcularIMC(peso, estatura);
            string estado = ObtenerEstadoNutricional(imc);

            Console.WriteLine("El indice de masa corporal de la persona es: " + imc);
            Console.WriteLine("El estado nutricional de la persona es: " + estado);

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }

}