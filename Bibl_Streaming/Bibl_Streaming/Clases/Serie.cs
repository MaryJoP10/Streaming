using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Streaming.Clases
{
    class Serie
    {
        //Atributos
        private string nombre;
        public enum l_temporadas { una, dos, tres, cuatro, cinco, seis, siete, ocho, nueve, diez, once, doce, trece, catorce, quince, dieciseis, diecisiete, dieciocho, diecinueve, veinte};
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
        public byte Cap_temporada { get => cap_temporada; set => cap_temporada = value; }
        internal l_temporadas Temporadas_serie { get => temporadas_serie; set => temporadas_serie = value; }

    }
}
