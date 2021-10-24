
namespace CapaPresentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeferPracticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.docenteToolStripMenuItem,
            this.laboratorioToolStripMenuItem,
            this.asignaturaToolStripMenuItem,
            this.jeferPracticaToolStripMenuItem,
            this.notaToolStripMenuItem,
            this.rectorToolStripMenuItem,
            this.pppToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alumnoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.docenteToolStripMenuItem.Text = "Docente";
            this.docenteToolStripMenuItem.Click += new System.EventHandler(this.docenteToolStripMenuItem_Click);
            // 
            // laboratorioToolStripMenuItem
            // 
            this.laboratorioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.laboratorioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.laboratorioToolStripMenuItem.Name = "laboratorioToolStripMenuItem";
            this.laboratorioToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.laboratorioToolStripMenuItem.Text = "Laboratorio";
            this.laboratorioToolStripMenuItem.Click += new System.EventHandler(this.laboratorioToolStripMenuItem_Click);
            // 
            // asignaturaToolStripMenuItem
            // 
            this.asignaturaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.asignaturaToolStripMenuItem.Name = "asignaturaToolStripMenuItem";
            this.asignaturaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.asignaturaToolStripMenuItem.Text = "Asignatura";
            this.asignaturaToolStripMenuItem.Click += new System.EventHandler(this.asignaturaToolStripMenuItem_Click);
            // 
            // jeferPracticaToolStripMenuItem
            // 
            this.jeferPracticaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.jeferPracticaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.jeferPracticaToolStripMenuItem.Name = "jeferPracticaToolStripMenuItem";
            this.jeferPracticaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.jeferPracticaToolStripMenuItem.Text = "JeferPractica";
            this.jeferPracticaToolStripMenuItem.Click += new System.EventHandler(this.jeferPracticaToolStripMenuItem_Click);
            // 
            // notaToolStripMenuItem
            // 
            this.notaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.notaToolStripMenuItem.Name = "notaToolStripMenuItem";
            this.notaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.notaToolStripMenuItem.Text = "Nota";
            this.notaToolStripMenuItem.Click += new System.EventHandler(this.notaToolStripMenuItem_Click);
            // 
            // rectorToolStripMenuItem
            // 
            this.rectorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.rectorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rectorToolStripMenuItem.Name = "rectorToolStripMenuItem";
            this.rectorToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.rectorToolStripMenuItem.Text = "Rector";
            this.rectorToolStripMenuItem.Click += new System.EventHandler(this.rectorToolStripMenuItem_Click);
            // 
            // pppToolStripMenuItem
            // 
            this.pppToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pppToolStripMenuItem.Name = "pppToolStripMenuItem";
            this.pppToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pppToolStripMenuItem.Text = "Ppp";
            this.pppToolStripMenuItem.Click += new System.EventHandler(this.pppToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.home_slider_bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(604, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeferPracticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pppToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}