namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesReparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.Textequipos = new System.Windows.Forms.Label();
            this.TextReparaciones = new System.Windows.Forms.Label();
            this.TextUsuarios = new System.Windows.Forms.Label();
            this.TextTecnicos = new System.Windows.Forms.Label();
            this.TextAsignaciones = new System.Windows.Forms.Label();
            this.TextDetallesReparaciom = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.Datos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equiposToolStripMenuItem,
            this.reparacionesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.tecnicosToolStripMenuItem,
            this.asignacionesToolStripMenuItem,
            this.detallesReparacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // reparacionesToolStripMenuItem
            // 
            this.reparacionesToolStripMenuItem.Name = "reparacionesToolStripMenuItem";
            this.reparacionesToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.reparacionesToolStripMenuItem.Text = "Reparaciones";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // tecnicosToolStripMenuItem
            // 
            this.tecnicosToolStripMenuItem.Name = "tecnicosToolStripMenuItem";
            this.tecnicosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.tecnicosToolStripMenuItem.Text = "Tecnicos";
            // 
            // asignacionesToolStripMenuItem
            // 
            this.asignacionesToolStripMenuItem.Name = "asignacionesToolStripMenuItem";
            this.asignacionesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.asignacionesToolStripMenuItem.Text = "Asignaciones";
            // 
            // detallesReparacionToolStripMenuItem
            // 
            this.detallesReparacionToolStripMenuItem.Name = "detallesReparacionToolStripMenuItem";
            this.detallesReparacionToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.detallesReparacionToolStripMenuItem.Text = "DetallesReparacion";
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.textBox6);
            this.Datos.Controls.Add(this.textBox5);
            this.Datos.Controls.Add(this.textBox4);
            this.Datos.Controls.Add(this.textBox3);
            this.Datos.Controls.Add(this.textBox2);
            this.Datos.Controls.Add(this.textBox1);
            this.Datos.Controls.Add(this.TextDetallesReparaciom);
            this.Datos.Controls.Add(this.TextAsignaciones);
            this.Datos.Controls.Add(this.TextTecnicos);
            this.Datos.Controls.Add(this.TextUsuarios);
            this.Datos.Controls.Add(this.TextReparaciones);
            this.Datos.Controls.Add(this.Textequipos);
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(14, 43);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(599, 244);
            this.Datos.TabIndex = 1;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // Textequipos
            // 
            this.Textequipos.AutoSize = true;
            this.Textequipos.Location = new System.Drawing.Point(6, 23);
            this.Textequipos.Name = "Textequipos";
            this.Textequipos.Size = new System.Drawing.Size(69, 20);
            this.Textequipos.TabIndex = 0;
            this.Textequipos.Text = "Equipos\r\n";
            // 
            // TextReparaciones
            // 
            this.TextReparaciones.AutoSize = true;
            this.TextReparaciones.Location = new System.Drawing.Point(6, 53);
            this.TextReparaciones.Name = "TextReparaciones";
            this.TextReparaciones.Size = new System.Drawing.Size(112, 20);
            this.TextReparaciones.TabIndex = 1;
            this.TextReparaciones.Text = "Reparaciones";
            // 
            // TextUsuarios
            // 
            this.TextUsuarios.AutoSize = true;
            this.TextUsuarios.Location = new System.Drawing.Point(6, 86);
            this.TextUsuarios.Name = "TextUsuarios";
            this.TextUsuarios.Size = new System.Drawing.Size(76, 20);
            this.TextUsuarios.TabIndex = 2;
            this.TextUsuarios.Text = "Usuarios";
            // 
            // TextTecnicos
            // 
            this.TextTecnicos.AutoSize = true;
            this.TextTecnicos.Location = new System.Drawing.Point(6, 122);
            this.TextTecnicos.Name = "TextTecnicos";
            this.TextTecnicos.Size = new System.Drawing.Size(77, 20);
            this.TextTecnicos.TabIndex = 3;
            this.TextTecnicos.Text = "Tecnicos";
            // 
            // TextAsignaciones
            // 
            this.TextAsignaciones.AutoSize = true;
            this.TextAsignaciones.Location = new System.Drawing.Point(6, 151);
            this.TextAsignaciones.Name = "TextAsignaciones";
            this.TextAsignaciones.Size = new System.Drawing.Size(109, 20);
            this.TextAsignaciones.TabIndex = 4;
            this.TextAsignaciones.Text = "Asignaciones";
            // 
            // TextDetallesReparaciom
            // 
            this.TextDetallesReparaciom.AutoSize = true;
            this.TextDetallesReparaciom.Location = new System.Drawing.Point(6, 187);
            this.TextDetallesReparaciom.Name = "TextDetallesReparaciom";
            this.TextDetallesReparaciom.Size = new System.Drawing.Size(156, 20);
            this.TextDetallesReparaciom.TabIndex = 5;
            this.TextDetallesReparaciom.Text = "DetallesReparacion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 27);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 27);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(168, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(89, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 27);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 53);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(147, 27);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(81, 23);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(187, 27);
            this.textBox6.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(81, 23);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(187, 27);
            this.textBox7.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 120);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(574, 92);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reparacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesReparacionToolStripMenuItem;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.Label TextTecnicos;
        private System.Windows.Forms.Label TextUsuarios;
        private System.Windows.Forms.Label TextReparaciones;
        private System.Windows.Forms.Label Textequipos;
        private System.Windows.Forms.Label TextDetallesReparaciom;
        private System.Windows.Forms.Label TextAsignaciones;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

