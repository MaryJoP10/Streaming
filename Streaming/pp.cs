using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibl_Streaming.Clases;

namespace Streaming
{
    public partial class pp : Form
    {
        List<Juego> l_juegos = new List<Juego>();
        List<Serie> l_series = new List<Serie>();
        List<Pelicula> l_peliculas = new List<Pelicula>();
        Proveedor Shander = new Proveedor();
        public pp()
        {
            InitializeComponent();
            cb_tipo.DataSource = Enum.GetValues(typeof(Proveedor.l_contenido));
            tb_fecha.Text = DateTime.Now.ToString();
            
            
        }

        private void b_anadir_Click(object sender, EventArgs e)
        {
            try
            {
                switch ((Proveedor.l_contenido)Enum.Parse(typeof(Proveedor.l_contenido), cb_tipo.SelectedItem.ToString()))
                {
                    case Proveedor.l_contenido.Juego:
                        l_juegos.Add(new Juego(tb_nombre.Text, tb_genero.Text));
                        cb_juegos.DataSource = null;
                        cb_juegos.DataSource = l_juegos;
                        Limpiar();
                        break;
                    case Proveedor.l_contenido.Serie:
                        byte cap_temporada;
                        if (byte.TryParse(tb_capitulos.Text, out cap_temporada))
                            l_series.Add(new Serie(tb_nombre.Text, cap_temporada, (Serie.l_temporadas)Enum.Parse(typeof(Serie.l_temporadas), cb_temporadas.Text)));
                        else
                            throw new Exception("Revisar el campo de capítulos, hay un error.");
                        cb_series.DataSource = null;
                        cb_series.DataSource = l_series;
                        Limpiar();
                        break;
                    case Proveedor.l_contenido.Pelicula:
                        l_peliculas.Add(new Pelicula(tb_nombre.Text, ushort.Parse(tb_duracion.Text), float.Parse(tb_calificacion.Text)));
                        cb_peliculas.DataSource = null;
                        cb_peliculas.DataSource = l_peliculas;
                        Limpiar();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar el contenido " + error);
            }
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch ((Proveedor.l_contenido)Enum.Parse(typeof(Proveedor.l_contenido), cb_tipo.SelectedItem.ToString()))
            {
                case Proveedor.l_contenido.Juego:
                    tb_genero.ReadOnly = false;
                    tb_genero.BackColor = System.Drawing.SystemColors.Window;
                    tb_capitulos.ReadOnly = true;
                    tb_capitulos.BackColor = System.Drawing.SystemColors.Control;
                    cb_temporadas.DataSource = null;
                    tb_duracion.ReadOnly = true;
                    tb_duracion.BackColor = System.Drawing.SystemColors.Control;
                    tb_calificacion.ReadOnly = true;
                    tb_calificacion.BackColor = System.Drawing.SystemColors.Control;
                    break;
                case Proveedor.l_contenido.Serie:
                    cb_temporadas.DataSource = Enum.GetValues(typeof(Serie.l_temporadas));
                    tb_capitulos.ReadOnly = false;
                    tb_capitulos.BackColor = System.Drawing.SystemColors.Window;
                    tb_duracion.ReadOnly = true;
                    tb_duracion.BackColor = System.Drawing.SystemColors.Control;
                    tb_calificacion.ReadOnly = true;
                    tb_calificacion.BackColor = System.Drawing.SystemColors.Control;
                    tb_genero.ReadOnly = true;
                    tb_genero.BackColor = System.Drawing.SystemColors.Control;
                    break;
                case Proveedor.l_contenido.Pelicula:
                    tb_duracion.ReadOnly = false;
                    tb_duracion.BackColor = System.Drawing.SystemColors.Window;
                    tb_calificacion.ReadOnly = false;
                    tb_calificacion.BackColor = System.Drawing.SystemColors.Window;
                    cb_temporadas.DataSource = null;
                    tb_capitulos.ReadOnly = true;
                    tb_capitulos.BackColor = System.Drawing.SystemColors.Control;
                    tb_genero.ReadOnly = true;
                    tb_genero.BackColor = System.Drawing.SystemColors.Control;
                    break;
                default:
                    break;
            }

        }

        private void cb_juegos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            tb_nombre.Clear();
            tb_genero.Clear();
            tb_calificacion.Clear();
            tb_duracion.Clear();
            tb_capitulos.Clear();
            tb_nombre.Focus();
        }

        private void b_infojuego_Click(object sender, EventArgs e)
        {
        }

        private void tb_fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_generar_Click(object sender, EventArgs e)
        {
            Random id = new Random();
            tb_id.Text = ((ushort)id.Next(10000, 100000)).ToString();
        }

        private void b_crear_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(tb_fecha.Text);
            //Crear Usuario
            Usuario usuario = new Usuario(ushort.Parse(tb_id.Text), tb_usuario.Text, fecha);
            Cuenta cuenta = new Cuenta(usuario);

            Shander.L_cuentas.Add(cuenta);
            lb_cuentas.DataSource = null;
            lb_cuentas.DataSource = Shander.L_cuentas;

            cb_cuentas_agregar.DataSource = null;
            cb_cuentas_agregar.DataSource = Shander.L_cuentas;
            cb_cuentas_info.DataSource = null;
            cb_cuentas_info.DataSource = Shander.L_cuentas;
        }

        private void cb_cuentas_info_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cb_cuentas_agregar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
