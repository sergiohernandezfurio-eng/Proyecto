using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlanList
    {
        FlightPlan[] vector = new FlightPlan[10];
        int numero = 0;//Numero de Planes de Vuelo que cargaré al vector.

        public int AddFlightPlan(FlightPlan p)
        {
            if (numero < 10)
            {
                vector[numero] = p;
                numero ++;
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public FlightPlan GetFlightPlan(int i)
        {
            if (i >= 0 && i <= numero)
            {
                return vector[i];
            }
            else
            {
                return null;
            }
        }

        public int GetNumero()
        {
            return numero;
        }

        public void Mover(int tiempo)
        {
            foreach (FlightPlan flight in vector)
            {
                if (flight != null)
                {
                    flight.Mover(tiempo);
                }
            }
        }
        public void EscribeConsola()
        {
            foreach(FlightPlan flight in vector)
            {
                if (flight != null)
                {
                    flight.EscribeConsola();
                }
            }
        }
    }
}
