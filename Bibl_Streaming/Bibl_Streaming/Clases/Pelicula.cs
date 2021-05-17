using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Streaming.Clases
{
    class Pelicula
    {
        //Atributos
        private string nombre;
        private double duracion;
        private float calificacion;

        //Constructores
        public Pelicula(string nombre, double duracion, float calificacion)
        {
            Nombre = nombre;
            Duracion = duracion;
            Calificacion = calificacion;
        }

        //Accesores
        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El nombre no puede estar vacio o ser nulo.");
                else
                    nombre = value;
            }
        }
        public double Duracion
        {
            get => duracion;
            set
            {
                if (value < 0)
                    throw new Exception("La pelicula no puede ser durar menos de 0 minutos.");
                else
                    duracion = value;
            }
        }
        public float Calificacion
        {
            get => calificacion;
            set
            {
                if (value < 0 || value > 5)
                    throw new Exception("ERROR: valor ingresado debe ser entre 0 y 5");
                else
                    calificacion = value;
            }
        }

        //Metodos
        public string Acumular_puntos(ulong horas_vistas, ulong minutos_vistos, Cuenta cuenta_viendo)
        {
            try
            {
                ulong minutos_vistos_aux;
                ulong conversion_horas_minutos = horas_vistas * 60;

                minutos_vistos_aux = (conversion_horas_minutos + minutos_vistos);
                cuenta_viendo.Suma_minutos += minutos_vistos_aux;
                cuenta_viendo.Acumulador_de_puntos();
                return "Total puntos acumulados: " + cuenta_viendo.Puntos_totales;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en método Acumular puntos en la clase Pelicula.");
            }
        }
    }
}
