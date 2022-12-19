using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feliz Cumpleaños Mi Zami Hermosa, Te Quiero Demasiado, Gracias Por Todo Y Feliz Día <3 ", "TQM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
    }
}
