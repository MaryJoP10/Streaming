using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Streaming.Clases
{
    class Cuenta
    {
        //Atributos
        private Usuario usuario;
        private Contenido contenido_visto;

        //Constructores
        public Cuenta(Usuario usuario, Contenido contenido_visto)
        {
            this.usuario = usuario;
            this.contenido_visto = contenido_visto;
        }
    }
}
