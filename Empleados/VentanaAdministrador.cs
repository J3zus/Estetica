using System;
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

        private void PbSalir_Click(object sender, EventArgs e)
        {
            Index.Index formIndex = new Index.Index();
            formIndex.Show();
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Empleados formEmpleados = new Empleados();
            formEmpleados.ShowDialog();
            this.Hide();
        }
    }
}
