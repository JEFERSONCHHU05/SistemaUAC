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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Declarar un objeto a partir de la clase
        private Docente docente = new Docente();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string fechaNacimiento = txtFechaNacimiento.Text.Trim();
            string cargo = txtCargo.Text.Trim();
            string gradoAcademico = txtGradoAcademico.Text.Trim();
            string fechaIngresoDocente = txtFechaIngresoDocente.Text.Trim();
            // Escribir los datos del alumno en el objeto
            docente.Apellidos = apellidos;
            docente.Nombres = nombres;
            docente.Correo = correo;
            docente.Celular = celular;
            docente.FechaNaciemineto = fechaNacimiento;
            docente.Cargo = cargo;
            docente.GradoAcademico = gradoAcademico;
            docente.FechaIngresoDocente = fechaIngresoDocente;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCorreo.Clear(); 
            txtCelular.Clear();
            txtFechaNacimiento.Clear();
            txtCargo.Clear();
            txtGradoAcademico.Clear();
            txtFechaIngresoDocente.Clear();     
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string apellidos = docente.Apellidos;
            string nombres = docente.Nombres;
            string correo = docente.Correo;
            string celular = docente.Celular;
            string fechaNacimiento = docente.FechaNaciemineto;
            string cargo = docente.Cargo;
            string gradoAcademico = docente.GradoAcademico;
            string fechaIngresoDocente = docente.FechaIngresoDocente;
            MessageBox.Show("Datos del docente:" + "\n" + "Apellidos:" + apellidos +
                            "\n" + "Nombres:" + nombres + "\n" + "Correo:" + correo +
                            "\n" + "Celular:" + celular + "\n" + "FechaNacimineto:" + fechaNacimiento +
                            "\n" + "Cargo:" + cargo + "\n" + "GradoAcademico:" + gradoAcademico +
                            "\n" + "FechaIngresoNacimiento:" + fechaIngresoDocente);
        }
        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(docente.Ensenar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Motivar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Evaluar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Aconsejar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.SubirNotas());
        }
    }
}
