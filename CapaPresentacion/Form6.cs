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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        // Declarar un objeto a partir de la clase
        private Nota nota = new Nota();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string asignatura = txtAsignatura.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string estatus = txtEstatus.Text.Trim();
            string inspeccionar = txtInspeccionar.Text.Trim();
            // Escribir los datos del alumno en el objeto
            nota.Asignatura = asignatura;
            nota.Correo = correo;
            nota.Codigo = codigo;
            nota.Estatus = estatus;
            nota.Inspeccionar = inspeccionar;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtAsignatura.Clear();
            txtCorreo.Clear();
            txtCodigo.Clear();
            txtEstatus.Clear();
            txtInspeccionar.Clear();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string asignatura = nota.Asignatura;
            string correo = nota.Correo;
            string codigo = nota.Codigo;
            string estatus = nota.Estatus;
            string inspeccionar = nota.Inspeccionar;
            MessageBox.Show("Datos de nota:" + "\n" + "Asignatura:" + asignatura + "\n" +
                            "Correo:" + correo + "\n" + "Codigo:" + codigo + "\n" +
                            "Estatus:" + estatus + "\n" + "Inspeccionar:" + inspeccionar);
        }
        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(nota.Posicionar());
        }
        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota.Calificar());
        }
        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota.Ranquear());
        }
        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota.Ordenar());
        }
        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota.Promediar());
        }
        private void btnMetodo6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota.Indicar());
        }
    }
}
