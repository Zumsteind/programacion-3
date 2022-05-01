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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mostrarnombres_Click(object sender, EventArgs e)
        {
            string nombres = cajanombre.Text;
            listadenombres.Items.Add(nombres);

        }

        private void colorfavorito_SelectedIndexChanged(object sender, EventArgs e)
        {
           // colorfavorito.Items.Add("rojo");
            // colorfavorito.Items.Add("azul");
            // colorfavorito.Items.Add("rosa");
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            colorfavorito.Items.Add("rojo");
            colorfavorito.Items.Add("azul");
            colorfavorito.Items.Add("rosa");
        }

        private void cargarperfil_Click(object sender, EventArgs e)
        {
            string nombre = cajanombre.Text;
            string sexo = checkmujer.Checked == true ? "MUJER" : "";
            string sexoh = checkhombre.Checked == true ? "HOMBRE" : "";

            string altura;
            if (opcionalto.Checked)
                altura = "ALTO";
            else if (opcionmediano.Checked)
                altura = "MEDIANO";
            else altura = "BAJO";

            DateTime fecha = fechanacimiento.Value;

            string color = colorfavorito.SelectedItem.ToString();
            try
            {
                
            }
            catch (NullReferenceException r)
            {

                MessageBox.Show("error no ha seleccionado un color favorito");
            }
            
           
               

           


            MessageBox.Show("Nombre: " + nombre + ",  SEXO: " + sexo + sexoh + ",  ALTURA: " + altura + "  FECHA NACIMIENTO: " + fecha +
                "  Color Favorito: " + color) ;

        }
    }
}
