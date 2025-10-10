using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlan
    {
        // Atributos

        string id; // identificador
        Position initialPosition; // posicion inicial
        Position currentPosition; // posicion actual
        Position finalPosition; // posicion final
        double velocidad; //Velocidad

        // Constructures
        public FlightPlan(string id, double cpx, double cpy, double fpx, double fpy, double velocidad)
        {
            this.id = id;
            this.initialPosition = new Position(cpx, cpy);
            this.currentPosition = new Position(cpx, cpy);
            this.finalPosition = new Position(fpx, fpy);
            this.velocidad = velocidad;
        }

        // Metodos
        public void SetId(string id)
        {
            this.id = id;
        }
       
        public void SetCurrentPosition(double cpx, double cpy)
        {
            this.currentPosition = new Position(cpx, cpy);
        }
        
        public void SetFinalPosition(double fpx, double fpy)
        {
            this.finalPosition = new Position(fpx, fpy);
        }
        
        public void SetVelocidad(double velocidad)
        // setter del atributo velocidad
        { this.velocidad = velocidad; }

        //Gets
        public string GetId()
        {
            return id;
        }
        public Position GetInitialPosition()
        {
            return this.initialPosition;
        }
        public Position GetCurrentPosition()
        {
            return this.currentPosition;
        }
        public Position GetFinalPosition()
        {
            return this.finalPosition;
        }
        public double GetVelocidad()
        {
            return this.velocidad;
        }
        //Métodos
        public bool HaLlegado()
        {
            bool esta_en_destino = false;

            if (currentPosition == finalPosition)
                esta_en_destino = true;
            return esta_en_destino;

        }
        public void Mover(double tiempo)
        // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
        {
            //Calculamos la distancia recorrida en el tiempo dado
            double distancia = tiempo * this.velocidad / 60; //Módulo de la distancia en un intervalo de t.

            //Calculamos las razones trigonométricas
            double hipotenusa = Math.Sqrt((finalPosition.GetX() - currentPosition.GetX()) * (finalPosition.GetX() - currentPosition.GetX()) + (finalPosition.GetY() - currentPosition.GetY()) * (finalPosition.GetY() - currentPosition.GetY()));
            double coseno = (finalPosition.GetX() - currentPosition.GetX()) / hipotenusa;
            double seno = (finalPosition.GetY() - currentPosition.GetY()) / hipotenusa;

            //Caculamos la nueva posición del vuelo
            double x = currentPosition.GetX() + distancia * coseno; //Variación de X en un intervalo de t.
            double y = currentPosition.GetY() + distancia * seno; //Variación de Y en un intervalo de t.



            Position nuevaPosicion = new Position(x, y);

            //La distancia de la current a la nueva no puede ser mayor que  ala final, nos estaríamos pasando
            if (currentPosition.Distancia(nuevaPosicion) >= currentPosition.Distancia(finalPosition))
            {
                currentPosition = finalPosition;
            }
            else
            {
                currentPosition = nuevaPosicion;
            }

        }
        public void Restart()
        {
            this.currentPosition = this.initialPosition;
        }

        public double Distance(FlightPlan b)
        {
            double distancia = b.currentPosition.Distancia(this.currentPosition);
            return distancia;
        }
        public bool conflictoProximidad(FlightPlan b, double minimaDistancia)
        {
            bool conflicto = false;
            if (b.currentPosition.Distancia(currentPosition) < minimaDistancia)
                conflicto = true;
            return conflicto;
        }
        public void EscribeConsola()
        // escribe en consola los datos del plan de vuelo
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Datos del vuelo: ");
            Console.WriteLine("Identificador: {0:F2}", id);
            Console.WriteLine("Velocidad: {0:F2}", velocidad);
            Console.WriteLine("Posición actual: ({0:F2},{1:F2})", currentPosition.GetX(), currentPosition.GetY());
            Console.WriteLine("******************************");
        }
    }
}
