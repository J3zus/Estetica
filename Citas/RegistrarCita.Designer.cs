namespace Estetica.Citas
{
    partial class RegistrarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarCita));
            this.wrapperhead = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelIzq = new System.Windows.Forms.Panel();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.panelCita = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPoS = new System.Windows.Forms.Button();
            this.BtnCita = new System.Windows.Forms.Button();
            this.PanelPrinc = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPoS = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.wrapperhead.SuspendLayout();
            this.PanelIzq.SuspendLayout();
            this.panelCita.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.PanelPrinc.SuspendLayout();
            this.panelPoS.SuspendLayout();
            this.SuspendLayout();
            // 
            // wrapperhead
            // 
            this.wrapperhead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.wrapperhead.Controls.Add(this.button5);
            this.wrapperhead.Controls.Add(this.label1);
            this.wrapperhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.wrapperhead.Location = new System.Drawing.Point(0, 0);
            this.wrapperhead.Name = "wrapperhead";
            this.wrapperhead.Size = new System.Drawing.Size(1000, 58);
            this.wrapperhead.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button5.Image = global::Estetica.Properties.Resources.Close_Window__2_48px;
            this.button5.Location = new System.Drawing.Point(934, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 49);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Registro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelIzq
            // 
            this.PanelIzq.BackColor = System.Drawing.Color.DarkGray;
            this.PanelIzq.Controls.Add(this.BtnCliente);
            this.PanelIzq.Controls.Add(this.BtnPoS);
            this.PanelIzq.Controls.Add(this.BtnCita);
            this.PanelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzq.Location = new System.Drawing.Point(0, 58);
            this.PanelIzq.Name = "PanelIzq";
            this.PanelIzq.Size = new System.Drawing.Size(200, 592);
            this.PanelIzq.TabIndex = 2;
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCliente.Location = new System.Drawing.Point(0, 64);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(200, 67);
            this.BtnCliente.TabIndex = 1;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelCita
            // 
            this.panelCita.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCita.Controls.Add(this.label2);
            this.panelCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCita.Location = new System.Drawing.Point(200, 58);
            this.panelCita.Name = "panelCita";
            this.panelCita.Size = new System.Drawing.Size(800, 592);
            this.panelCita.TabIndex = 0;
            this.panelCita.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Este es el Panel Cita";
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCliente.Controls.Add(this.label4);
            this.panelCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCliente.Location = new System.Drawing.Point(200, 58);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(800, 592);
            this.panelCliente.TabIndex = 2;
            this.panelCliente.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Esto es el Panel Cliente";
            // 
            // BtnPoS
            // 
            this.BtnPoS.BackColor = System.Drawing.Color.DarkGray;
            this.BtnPoS.FlatAppearance.BorderSize = 0;
            this.BtnPoS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPoS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPoS.Location = new System.Drawing.Point(0, 128);
            this.BtnPoS.Name = "BtnPoS";
            this.BtnPoS.Size = new System.Drawing.Size(200, 67);
            this.BtnPoS.TabIndex = 2;
            this.BtnPoS.Text = "Producto/Servicio";
            this.BtnPoS.UseVisualStyleBackColor = false;
            this.BtnPoS.Click += new System.EventHandler(this.BtnPoS_Click);
            // 
            // BtnCita
            // 
            this.BtnCita.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCita.FlatAppearance.BorderSize = 0;
            this.BtnCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCita.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCita.Location = new System.Drawing.Point(0, 0);
            this.BtnCita.Name = "BtnCita";
            this.BtnCita.Size = new System.Drawing.Size(200, 67);
            this.BtnCita.TabIndex = 0;
            this.BtnCita.Text = "Cita";
            this.BtnCita.UseVisualStyleBackColor = false;
            this.BtnCita.Click += new System.EventHandler(this.BtnCita_Click);
            // 
            // PanelPrinc
            // 
            this.PanelPrinc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelPrinc.Controls.Add(this.label3);
            this.PanelPrinc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrinc.Location = new System.Drawing.Point(200, 58);
            this.PanelPrinc.Name = "PanelPrinc";
            this.PanelPrinc.Size = new System.Drawing.Size(800, 592);
            this.PanelPrinc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Panel Principal";
            // 
            // panelPoS
            // 
            this.panelPoS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPoS.Controls.Add(this.label5);
            this.panelPoS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPoS.Location = new System.Drawing.Point(200, 58);
            this.panelPoS.Name = "panelPoS";
            this.panelPoS.Size = new System.Drawing.Size(800, 592);
            this.panelPoS.TabIndex = 3;
            this.panelPoS.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Panel Producto/Servicio";
            // 
            // RegistrarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.PanelPrinc);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.panelCita);
            this.Controls.Add(this.panelPoS);
            this.Controls.Add(this.PanelIzq);
            this.Controls.Add(this.wrapperhead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendado de Citas";
            this.wrapperhead.ResumeLayout(false);
            this.wrapperhead.PerformLayout();
            this.PanelIzq.ResumeLayout(false);
            this.panelCita.ResumeLayout(false);
            this.panelCita.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.PanelPrinc.ResumeLayout(false);
            this.PanelPrinc.PerformLayout();
            this.panelPoS.ResumeLayout(false);
            this.panelPoS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel wrapperhead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelIzq;
        private System.Windows.Forms.Panel PanelPrinc;
        private System.Windows.Forms.Button BtnPoS;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnCita;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelCita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPoS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}