using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario alumno
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario docente
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario laboratorio
            Form3 form3 = new Form3();
            form3.Show();
        }
        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario asignatura
            Form4 form4 = new Form4();
            form4.Show();
        }
        private void jeferPracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario jefePractica
            Form5 form5 = new Form5();
            form5.Show();
        }
        private void notaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario nota
            Form6 form6 = new Form6();
            form6.Show();
        }
        private void rectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario rector
            Form7 form7 = new Form7();
            form7.Show();
        }
        private void pppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario Pppp
            Form8 form8 = new Form8();
            form8.Show();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}
