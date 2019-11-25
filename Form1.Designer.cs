namespace Estetica
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
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbCCP = new System.Windows.Forms.ToolStripButton();
            this.TsbInventario = new System.Windows.Forms.ToolStripButton();
            this.TsbEmpleados = new System.Windows.Forms.ToolStripButton();
            this.TsbAjustes = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNomUsu = new System.Windows.Forms.Label();
            this.LblApellidoUsu = new System.Windows.Forms.Label();
            this.LblTelUsu = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(723, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbCCP,
            this.TsbInventario,
            this.TsbEmpleados,
            this.TsbAjustes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(810, 36);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbCCP
            // 
            this.TsbCCP.Image = global::Estetica.Properties.Resources.notification_add;
            this.TsbCCP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsbCCP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCCP.Name = "TsbCCP";
            this.TsbCCP.Size = new System.Drawing.Size(129, 33);
            this.TsbCCP.Text = "Clientes/Citas/Productos";
            this.TsbCCP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbCCP.Click += new System.EventHandler(this.TsbCCP_Click);
            // 
            // TsbInventario
            // 
            this.TsbInventario.Image = global::Estetica.Properties.Resources.Note_Book;
            this.TsbInventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbInventario.Name = "TsbInventario";
            this.TsbInventario.Size = new System.Drawing.Size(61, 33);
            this.TsbInventario.Text = "Inventario";
            this.TsbInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TsbEmpleados
            // 
            this.TsbEmpleados.Image = global::Estetica.Properties.Resources.Users_2;
            this.TsbEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEmpleados.Name = "TsbEmpleados";
            this.TsbEmpleados.Size = new System.Drawing.Size(62, 33);
            this.TsbEmpleados.Text = "Empleados";
            this.TsbEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TsbAjustes
            // 
            this.TsbAjustes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsbAjustes.Image = global::Estetica.Properties.Resources.Settings_1;
            this.TsbAjustes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAjustes.Name = "TsbAjustes";
            this.TsbAjustes.Size = new System.Drawing.Size(63, 33);
            this.TsbAjustes.Text = "Ajustes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblTelUsu);
            this.groupBox1.Controls.Add(this.LblApellidoUsu);
            this.groupBox1.Controls.Add(this.LblNomUsu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(558, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 123);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // LblNomUsu
            // 
            this.LblNomUsu.AutoSize = true;
            this.LblNomUsu.Location = new System.Drawing.Point(75, 25);
            this.LblNomUsu.Name = "LblNomUsu";
            this.LblNomUsu.Size = new System.Drawing.Size(80, 13);
            this.LblNomUsu.TabIndex = 3;
            this.LblNomUsu.Text = "NombreUsuario";
            // 
            // LblApellidoUsu
            // 
            this.LblApellidoUsu.AutoSize = true;
            this.LblApellidoUsu.Location = new System.Drawing.Point(75, 56);
            this.LblApellidoUsu.Name = "LblApellidoUsu";
            this.LblApellidoUsu.Size = new System.Drawing.Size(80, 13);
            this.LblApellidoUsu.TabIndex = 4;
            this.LblApellidoUsu.Text = "ApellidoUsuario";
            // 
            // LblTelUsu
            // 
            this.LblTelUsu.AutoSize = true;
            this.LblTelUsu.Location = new System.Drawing.Point(75, 87);
            this.LblTelUsu.Name = "LblTelUsu";
            this.LblTelUsu.Size = new System.Drawing.Size(85, 13);
            this.LblTelUsu.TabIndex = 5;
            this.LblTelUsu.Text = "TelefonoUsuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estetica";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbCCP;
        private System.Windows.Forms.ToolStripButton TsbInventario;
        private System.Windows.Forms.ToolStripButton TsbEmpleados;
        private System.Windows.Forms.ToolStripButton TsbAjustes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblTelUsu;
        private System.Windows.Forms.Label LblApellidoUsu;
        private System.Windows.Forms.Label LblNomUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

