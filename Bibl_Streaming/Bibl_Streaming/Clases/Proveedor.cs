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
        private Cuenta[] l_cuentas;
        private Juego[] l_juegos;
        private l_contenido tipo;

        

        //Constructores
        public Proveedor(Cuenta[] l_cuentas)
        {
            this.l_cuentas = l_cuentas;
        }

        //Accesores
        public l_contenido Tipo { get => this.tipo; set => this.tipo = value; }
        public Juego[] L_juegos { get => l_juegos; set => l_juegos = value; }
    }
}
