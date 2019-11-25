using System;
using System.Windows.Forms;

namespace Estetica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TsbCCP_Click(object sender, EventArgs e)
        {
            Citas.RegistrarCita formCitas = new Citas.RegistrarCita();
            formCitas.ShowDialog();
        }

        private void TsbInventario_Click(object sender, EventArgs e)
        {
            Inventario.Inventario formInventario = new Inventario.Inventario();
            this.Hide();
            formInventario.ShowDialog();
        }

        private void TsbEmpleados_Click(object sender, EventArgs e)
        {
            Empleados.VentanaAdministrador formEmpleados = new Empleados.VentanaAdministrador();
            this.Hide();
            formEmpleados.ShowDialog();
        }
    }
}
