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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // Declarar un objeto a partir de la clase
        private Laboratorio laboratorio = new Laboratorio();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string nombres = txtNombres.Text.Trim();
            string creditos = txtCreditos.Text.Trim();
            string horario = txtHorario.Text.Trim();
            string lugar = txtLugar.Text.Trim();
            string especialidad = txtEspecialidad.Text.Trim();
            string tiempo = txtTiempo.Text.Trim();
            // Escribir los datos del alumno en el objeto
            laboratorio.Nombres = nombres;
            laboratorio.Creditos = creditos;
            laboratorio.Horarios = horario;
            laboratorio.Lugar = lugar;
            laboratorio.Especialidad = especialidad;
            laboratorio.Tiempo = tiempo;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtNombres.Clear();
            txtCreditos.Clear();
            txtHorario.Clear();
            txtLugar.Clear();
            txtEspecialidad.Clear();
            txtTiempo.Clear();
            //Hacer que el mause este en apellidos
            txtNombres.Focus();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string nombres = laboratorio.Nombres;
            string creditos = laboratorio.Creditos;
            string horario = laboratorio.Horarios;
            string lugar = laboratorio.Lugar;
            string especialidad = laboratorio.Especialidad;
            string tiempo = laboratorio.Tiempo;
            MessageBox.Show("Datos de laboratorio:" + "\n" + "Nombres:" + nombres + "\n" +
                            "Creditos:" + creditos + "\n" + "Horario:" + horario + "\n" +
                            "Lugar:" + lugar + "\n" + "Especialidad:" + especialidad + "\n" +
                            "Tiempo:" + tiempo);
        }
        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(laboratorio.Analizar());
        }
        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.Observar());
        }
        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.Investigar());
        }
        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.Experimentar());
        }
        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.Calcular());
        }
        private void btnMetodo6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.Verificar());
        }
    }
}
