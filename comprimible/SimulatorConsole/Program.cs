
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FlightLib;

namespace SimulatorConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            FlightPlanList list = new FlightPlanList();
            try
            {
            
            Console.WriteLine("Escribe el identificador");
            //   string nombre = Console.ReadLine();
            string identificador = Console.ReadLine(); ;

            Console.WriteLine("Escribe la velocidad");
            double velocidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
            string linea = Console.ReadLine();
            string[] trozos = linea.Split(' ');
            double ix = Convert.ToDouble(trozos[0]);
            double iy = Convert.ToDouble(trozos[1]);

            Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
            linea = Console.ReadLine();
            trozos = linea.Split(' ');
            double fx = Convert.ToDouble(trozos[0]);
            double fy = Convert.ToDouble(trozos[1]);

            FlightPlan plan_a = new FlightPlan(identificador, ix, iy, fx, fy, velocidad);

            Console.WriteLine("Escribe el identificador");
            //   string nombre = Console.ReadLine();
            identificador = Console.ReadLine(); ;

            Console.WriteLine("Escribe la velocidad");
            velocidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
            linea = Console.ReadLine();
            trozos = linea.Split(' ');
            ix = Convert.ToDouble(trozos[0]);
            iy = Convert.ToDouble(trozos[1]);

            Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
            linea = Console.ReadLine();
            trozos = linea.Split(' ');
            fx = Convert.ToDouble(trozos[0]);
            fy = Convert.ToDouble(trozos[1]);

            FlightPlan plan_b = new FlightPlan(identificador, ix, iy, fx, fy, velocidad);

            list.AddFlightPlan(plan_a);
            list.AddFlightPlan(plan_b);
                    
            int i = 0;
            int ciclos = 2;
            int tiempoCiclo = 10;
            double minimaDistancia = 5;

            while (i < ciclos)
            {
            list.Mover(tiempoCiclo);
            
            list.EscribeConsola();

                if (plan_a.conflictoProximidad(plan_b, minimaDistancia))
                    Console.WriteLine("EXISTE CONFLICTO DE PROXIMIDAD.");

                i = i + 1;
            }

            Console.ReadLine();
            }
            catch(FormatException)
            {
                Console.WriteLine("Error de formato.");
                Console.ReadKey();
            }
        }
    }
}
