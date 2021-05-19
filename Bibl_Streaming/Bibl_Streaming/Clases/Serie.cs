using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Streaming.Clases
{
    public class Serie
    {
        //Atributos
        private string nombre;
        public enum l_temporadas { Una, Dos, Tres, Cuatro, Cinco, Seis, Siete, Ocho, Nueve, Diez, Once, Doce, Trece, Catorce, Quince, Dieciseis, Diecisiete, Dieciocho, Diecinueve, Veinte};
        private byte cap_temporada;
        private l_temporadas temporadas_serie;

        //Constructores
        public Serie(string nombre, byte cap_temporada, l_temporadas temporadas_serie)
        {
            Nombre = nombre;
            Cap_temporada = cap_temporada;
            Temporadas_serie = temporadas_serie;
        }

        //Accesores
        public string Nombre 
        { 
            get => nombre; set => nombre = value; 
        }
        public byte Cap_temporada 
        { 
            get => cap_temporada; 
            set
            {
                if (value < 0 || value == 0)
                    throw new Exception("Las temporadas no tienen pueden tener 0 o menos capitulos.");
                else
                    cap_temporada = value;
            }
        }
        internal l_temporadas Temporadas_serie { get => temporadas_serie; set => temporadas_serie = value; }

        //Metodos
        public string Acumular_puntos(ulong episodios_vistos, Cuenta cuenta_viendo)
        {
            try
            {
                ulong puntos_por_capitulo;

                puntos_por_capitulo = (episodios_vistos);
                cuenta_viendo.Suma_capitulos += puntos_por_capitulo / 2;
                cuenta_viendo.Acumulador_de_puntos();
                return "Total puntos acumulados: " + cuenta_viendo.Puntos_totales;
            }
            catch (Exception)
            {
                throw new Exception("ERROR: ocurrio un error en clase AAcumular_puntos en clase Serie");
            }
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
