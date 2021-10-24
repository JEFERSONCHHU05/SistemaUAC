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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        // Declarar un objeto a partir de la clase
        private Ppp ppp = new Ppp();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string especialidad = txtEspecialidad.Text.Trim();
            string nombreEmpresa = txtNombreEmpresa.Text.Trim();
            string dia = txtDia.Text.Trim();
            string sector = txtSector.Text.Trim();
            string perfil = txtPerfil.Text.Trim();
            // Escribir los datos del alumno en el objeto
            ppp.Especialidad = especialidad;
            ppp.NombreEmpresa = nombreEmpresa;
            ppp.Dia = dia;
            ppp.Sector = sector;
            ppp.Perfil = perfil;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtEspecialidad.Clear();
            txtNombreEmpresa.Clear();
            txtDia.Clear();
            txtSector.Clear();
            txtPerfil.Clear();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string especialidad = ppp.Especialidad;
            string nombreEmpresa = ppp.NombreEmpresa;
            string dia = ppp.Dia;
            string sector = ppp.Sector;
            string perfil = ppp.Perfil;
            MessageBox.Show("Datos de Practica pre professional;" + "\n" + "Especialidad:" + especialidad + "\n" +
                            "NombreEmpresa:" + nombreEmpresa + "\n" + "Dia:" + dia + "\n" + "Sector:" + sector + "\n" +
                            "Perfil:" + perfil);
        }
        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(ppp.Trabajar());
        }
        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp.Aprender());
        }
        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp.DesarrollarProyectos());
        }
        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp.Impulsar());
        }
        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp.Especializar());
        }
        private void btnMetodo6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp.Conocer());
        }
    }
}
