using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Streaming.Clases
{
    class Juego
    {
        //Atributos 
        private string nombre;
        private string genero;

        //Contructores
        public Juego(string nombre, string genero)
        {
            Nombre = nombre;
            Genero = genero;
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
        public string Genero
        {
            get => genero;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El genero no puede estar vacio o ser nulo.");
                else
                    genero = value;
            }
        }

        //Metodos
        public string Acumular_puntos(byte score, Cuenta cuenta_jugando)
        {
            try
            {
                byte puntos_en_score;
                puntos_en_score = (score);
                cuenta_jugando.Suma_scores += (ulong)puntos_en_score / 5;
                cuenta_jugando.Acumulador_de_puntos();
                return "Total puntos acumulados: " + cuenta_jugando.Puntos_totales;
            }
            catch (Exception)
            {
                throw new Exception("ocurrio un error en metodo acumular_puntos de clase juego");
            }
        }
    }
}
