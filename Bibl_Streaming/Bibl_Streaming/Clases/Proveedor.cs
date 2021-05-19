using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Streaming.Clases
{
    public class Proveedor
    {
        //Atributos
        public enum l_contenido { Juego, Pelicula, Serie }
        private List<Cuenta> l_cuentas;
        private l_contenido tipo;

        //Constructores
        public Proveedor()
        {
            l_cuentas = new List<Cuenta>();
        }

        //Accesores
        public l_contenido Tipo { get => this.tipo; set => this.tipo = value; }
        public List<Cuenta> L_cuentas 
        { 
            get => l_cuentas; 
            set => l_cuentas = value; 
        }

        //Metodo

    }
}
