using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Streaming.Clases
{
    public class Cuenta
    {
        //Atributos
        private Usuario usuario;
        private Contenido contenido_visto;
        private ulong suma_scores;
        private ulong suma_capitulos;
        private ulong suma_minutos;
        private double puntos_totales;

        //Constructores
        public Cuenta(Usuario usuario)
        {
            this.usuario = usuario;
        }
        public Cuenta(Contenido contenido_visto)
        {
            this.contenido_visto = contenido_visto;
        }

        //Accesores
        public ulong Suma_scores 
        { 
            get => suma_scores;
            set => suma_scores = value;
        }
        public ulong Suma_capitulos 
        { 
            get => suma_capitulos;
            set => suma_capitulos = value;
        }
        public ulong Suma_minutos
        {
            get => suma_minutos;
            set => suma_minutos = value;
        }
        public double Puntos_totales 
        { 
            get => puntos_totales; 
            set => puntos_totales = value;
        }
        //Metodos
        public void Acumulador_de_puntos()
        {
            try
            {
                Puntos_totales = Suma_capitulos + Suma_minutos + Suma_scores;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método Acumulador_De_Puntos en la clase cuenta.");
            }
        }
        public string Saber_puntos()
        {
            try
            {
                Acumulador_de_puntos();
                Console.WriteLine("*******puntos totales*******");
                return "Total de puntos: " + Puntos_totales;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método Saber Puntos en la clase cuenta.");
            }
        }
        public override string ToString()
        {
            return usuario.Nombre;
        }
    }
}
