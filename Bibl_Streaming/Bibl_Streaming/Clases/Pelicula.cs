using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Streaming.Clases
{
    public class Pelicula
    {
        //Atributos
        private string nombre;
        private ushort duracion;
        private float calificacion;

        //Constructores
        public Pelicula(string nombre, ushort duracion, float calificacion)
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
        public ushort Duracion
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
        public ulong Acumular_Puntos(ulong minutos_vistos, Cuenta cuenta_viendo)
        {
            try
            {
                ulong minutos_vistos_aux;

                minutos_vistos_aux = (minutos_vistos);
                cuenta_viendo.Suma_minutos += minutos_vistos_aux / 60;
                return minutos_vistos_aux / 60;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método Acumular_Puntos en la clase Pelicula.");
            }
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
