using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Streaming.Clases
{
    class Contenido
    {
        //Atributos
        private List<Pelicula> l_peliculas;
        private List<Serie> l_series;

        //Constructores 
        public Contenido(List<Pelicula> l_peliculas, List<Serie> l_series)
        {
            this.l_peliculas = l_peliculas;
            this.l_series = l_series;
        }
    }
}
