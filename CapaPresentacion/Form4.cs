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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        // Declarar un objeto a partir de la clase
        private Asignatura asignatura = new Asignatura();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string nombres = txtNombres.Text.Trim();
            string creditos = txtCreditos.Text.Trim();
            string especialidad = txtEspecialidad.Text.Trim();
            string horario = txtHorario.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string tiempo = txtTiempo.Text.Trim();
            // Escribir los datos del alumno en el objeto
            asignatura.Nombres = nombres;
            asignatura.Creditos = creditos;
            asignatura.Especialidad = especialidad;
            asignatura.Horario = horario;
            asignatura.Codigo = codigo;
            asignatura.Tiempo = tiempo;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtNombres.Clear();
            txtCreditos.Clear();
            txtEspecialidad.Clear();
            txtHorario.Clear();
            txtCodigo.Clear();
            txtTiempo.Clear();
            //Hacer que el mause este en apellidos
            txtNombres.Focus();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string nombres = asignatura.Nombres;
            string creditos = asignatura.Creditos;
            string especialidad = asignatura.Especialidad;
            string horario = asignatura.Horario;
            string codigo = asignatura.Codigo;
            string tiempo = asignatura.Tiempo;
            MessageBox.Show("Datos de asignatura:" + "\n" + "Nombres:" + nombres + "\n" +
                            "Creditos:" + creditos + "\n" + "Especialidad:" + especialidad + "\n" +
                            "Horario:" + horario + "\n" + "Codigo:" + codigo + "\n" + "Tiempo:" + tiempo);
        }
        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(asignatura.Contar());
        }
        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Ordenar());
        }
        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Examinar());
        }
        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Aprender());
        }
        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Indagar());
        }
        private void btnMetodo6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Especializar());
        }
    }
}
