using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unidad4windforms
{
    public partial class pantallaprincipal : Form
    {
        public pantallaprincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicio ventana = new inicio();
            ventana.ShowDialog();
        }

        private void cajanombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void sumar_Click(object sender, EventArgs e)
        {

            try
            {
                int a, b, r;
                a = int.Parse(suma1.Text);
                b = int.Parse(suma2.Text);
                r = a + b;
                muestrasuma.Text = "La suma es: " + r;

            }
            catch (FormatException er)
            {
                MessageBox.Show("ERROR SOLO SE PUEDEN SUMAR NUMEROS");
            }
                


        }
    }
}
