﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estetica.Empleados
{
    public partial class VentanaAdministrador : Form
    {
        public VentanaAdministrador()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Form1 formMain = new Form1();
            this.Close();
            formMain.Show();
        }
    }
}
