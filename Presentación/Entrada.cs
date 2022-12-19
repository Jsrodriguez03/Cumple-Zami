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
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == "En un solo día") || (txtCodigo.Text == "EN UN SOLO DÍA") || 
                (txtCodigo.Text == "en un solo día"))
            {
                Carta carta = new Carta();
                this.Hide();
                carta.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Codigo Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
