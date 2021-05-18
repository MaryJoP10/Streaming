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
        private List<Pelicula> l_peliculas;
        private List<Serie> l_series;

        //Constructores 
        public Contenido(List<Pelicula> l_peliculas, List<Serie> l_series)
        {
            L_peliculas = l_peliculas;
            L_series = l_series;
        }

        //Accesores
        internal List<Pelicula> L_peliculas { get => l_peliculas; set => l_peliculas = value; }
        internal List<Serie> L_series { get => l_series; set => l_series = value; }

        //Metodos
        public string Nueva_pelicula(Pelicula pelicula)
        {
            try
            {
                L_peliculas.Append(pelicula);
                return "peliculas y series agregadas satisfactoriamente";
            }
            catch (Exception)
            {
                throw new Exception("ocurrio un error en metodo organizar_peliculas en clase contenido");
            }
        }
        public string Nueva_serie(Serie serie)
        {
            try
            {
                L_series.Append(serie);
                return "peliculas y series agregadas satisfactoriamente";
            }
            catch (Exception)
            {
                throw new Exception("ocurrio un error en metodo organizar_peliculas en clase contenido");
            }
        }
        public void Saber_contenido()
        {
            try
            {
                Console.WriteLine("*******Lista de peliculas*******");
                for (int i = 0; i < L_peliculas.Count; i++)
                {
                    Console.WriteLine(L_peliculas[i].Nombre);
                }
                Console.WriteLine("*******Lista de series*******");
                for (int j = 0; j < L_series.Count; j++)
                {
                    Console.WriteLine(L_series[j].Nombre);
                }
            }
            catch (Exception)
            {
                throw new Exception("ocurrio un error en metodo saber_contenido clase contenido");
            }

        }
    }
}
