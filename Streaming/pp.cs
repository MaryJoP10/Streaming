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
        public pp()
        {
            InitializeComponent();
            cb_tipo.DataSource = Enum.GetValues(typeof(Proveedor.l_contenido));
            cb_temporadas.DataSource = Enum.GetValues(typeof(Serie.l_temporadas));
        }
    }
}
