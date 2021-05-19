using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Streaming.Clases
{
    public class Contenido
    {
        //Atributos

        //Constructores 
        public Contenido()
        {
        }

        //Accesores

        //Metodos
        
        public string Acumular_Puntos(ulong horas_vistas, ulong minutos_vistos, Cuenta cuenta_viendo)
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
