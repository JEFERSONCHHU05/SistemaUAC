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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        // Declarar un objeto a partir de la clase
        private JeferPractica jefePractica = new JeferPractica();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string especialidad = txtEspecialidad.Text.Trim();
            string dni = txtDni.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            // Escribir los datos del alumno en el objeto
            jefePractica.Nombres = nombres;
            jefePractica.Apellidos = apellidos;
            jefePractica.Especialidad = especialidad;
            jefePractica.Dni = dni;
            jefePractica.Correo = correo;
            jefePractica.Celular = celular;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEspecialidad.Clear();
            txtDni.Clear();
            txtCorreo.Clear();
            txtCelular.Clear();
            //Hacer que el mause este en apellidos
            txtNombres.Focus();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string nombres = jefePractica.Nombres;
            string apellidos = jefePractica.Apellidos;
            string especialidad = jefePractica.Especialidad;
            string dni = jefePractica.Dni;
            string correo = jefePractica.Correo;
            string celular = jefePractica.Celular;
            MessageBox.Show("Datos del jeferPractica:" + "\n" + "Nombres:" + nombres + "\n" +
                            "Apellidos:" + apellidos + "\n" + "Especialidad:" + especialidad + "\n" +
                            "Dni:" + dni + "\n" + "Correo:" + correo + "\n" + "Celular:" + celular);
        }
        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(jefePractica.Supervisar());
        }
        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Instruir());
        }
        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Evaluar());
        }
        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Motivar());
        }
        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Exponer());
        }
        private void btnMetodo6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Criticar());
        }
    }
}
