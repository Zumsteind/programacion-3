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
    }
}
