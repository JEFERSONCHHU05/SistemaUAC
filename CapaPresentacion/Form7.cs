using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Lamar a la capa negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        // Declarar un objeto a partir de la clase
        private Rector rector = new Rector();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string fechaNacimmiento = txtFechaNacimiento.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string dni = txtDni.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string facultad = txtFacultad.Text.Trim();
            // Escribir los datos del alumno en el objeto
            rector.Nombres = nombres;
            rector.Apellidos = apellidos;
            rector.FechaNacimiento = fechaNacimmiento;
            rector.Celular = celular;
            rector.Dni = dni;
            rector.Correo = correo;
            rector.Facultad = facultad;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtNombres.Clear();
            txtApellidos.Clear();
            txtFechaNacimiento.Clear();
            txtCelular.Clear();
            txtDni.Clear();
            txtCorreo.Clear();
            txtFacultad.Clear();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string nombres = rector.Nombres;
            string apellidos = rector.Apellidos;
            string fechaNacimiento = rector.FechaNacimiento;
            string celular = rector.Celular;
            string dni = rector.Dni;
            string correo = rector.Correo;
            string facultad = rector.Facultad;
            MessageBox.Show("Datos de rector:" + "\n" + "Nombres:" + nombres + "\n" +
                            "Apellidos:" + apellidos + "\n" + "FechaNacimiento:" + fechaNacimiento + "\n" +
                            "Celular:" + celular + "\n" + "Dni:" + dni + "\n" + "Correo:" + correo + "\n" +
                            "Facultad:" + facultad);
        }
        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(rector.Liderar());
        }
        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Representar());
        }
        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Impulsar());
        }
        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Supervisar());
        }
        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Orientar());
        }
        private void btnMetodo6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Evaluar());
        }
        private void btnMetodo7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Reportar());
        }
    }
}
