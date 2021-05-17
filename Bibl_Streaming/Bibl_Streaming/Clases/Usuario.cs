using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Streaming.Clases
{
    class Usuario
    {
        private ushort id_interno;
        private string nombre;
        private DateTime fecha_afiliacion;

        public Usuario(ushort id_interno, string nombre, DateTime fecha_afiliacion)
        {
            Id_interno = id_interno;
            Nombre = nombre;
            Fecha_afiliacion = fecha_afiliacion;

        }

        public ushort Id_interno
        {
            get => id_interno; set
            {
                if (value < 0)
                {
                    throw new Exception("El id interno no puede ser negativo");
                }
                else
                {
                    id_interno = value;
                }
            }
        }
        public string Nombre
        {
            get => nombre; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El nombre no puede ser nulo o estar vacio.");
                }
                else
                {
                    nombre = value;
                }
            }
        }
        public DateTime Fecha_afiliacion
        {
            get => fecha_afiliacion; set
            {
                if (value.Year < 1800 || value.Year > DateTime.Now.Year)
                {
                    throw new Exception("No hay afiliaciones antes de 1800 ni tampoco se puede afiliar en un año mayor al año actual.");
                }
                else
                {
                    fecha_afiliacion = value;
                }
            }
        }
    }
}
