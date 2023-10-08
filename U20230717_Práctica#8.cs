using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenu de opciones:");
                Console.WriteLine("1. Suma dos numeros enteros. ");
                Console.WriteLine("2. Calcular Salario. ");
                Console.WriteLine("3. Calcular salario neto. ");
                Console.WriteLine("4. Salir. ");
                Console.WriteLine("\nIngrese su opcion: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("\nIngrese el primer numero: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Ingrese el segundo numero: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            SumarDosNumeros(num1, num2);
                            break;

                        case 2:
                            Console.Write("\nIngrese el numero de horas trabajadas: ");
                            int horasTrabajadas = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Ingrese el precio por hora: ");
                            double precioPorHora = Convert.ToDouble(Console.ReadLine());

                            CalcularSalario(horasTrabajadas, precioPorHora);
                            break;

                        case 3:
                            Console.Write("\nIngrese el numero de horas trabajadas: ");
                            int hTrabajadas = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Ingrese el precio por hora: ");
                            double precioPHora = Convert.ToDouble(Console.ReadLine());

                            CalcularSalarioNeto(hTrabajadas, precioPHora);
                            break;

                        case 4:
                            Console.WriteLine("\nSaliendo del programa........");
                            break;
                        default:
                            Console.WriteLine("\nOpcion no valida. Intenta de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nOpcion no valida. Intenta de nuevo.");
                }

            } while (opcion !=4);

        }

        static void SumarDosNumeros(int num1, int num2)
        {
            int suma = num1 + num2;
            Console.WriteLine("\nLa suma es: " + suma);
        }

        static void CalcularSalario(int horasTrabajadas, double precioPorHora)
        {
            double salario = horasTrabajadas * precioPorHora;

            Console.WriteLine("\nEl salario es: $" + salario);
        }

        static void CalcularSalarioNeto(int hTrabajadas, double precioPHora)
        {
            double SalarioNeto = hTrabajadas * precioPHora;
            double limiteISSS = 30;

            if (SalarioNeto > 1000)
            {
                SalarioNeto -= limiteISSS;
            }
            Console.WriteLine("\nEl salario es: $" + SalarioNeto);
        }
    }
}
