using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estetica.Index
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LblBienvenida.Text = "Registrar Cita";
            panelCita.Visible = true;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
            PanelPrincipal.Visible = false;
            PanelInventario.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LblBienvenida.Text = "Registrar Inventario";
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
            PanelPrincipal.Visible = false;
            PanelInventario.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LblBienvenida.Text = "Empleados";
            Empleados.VentanaAdministrador formEmpleados = new Empleados.VentanaAdministrador();
            formEmpleados.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            LblBienvenida.Text = "Registrar Cliente";
            panelCliente.Visible = true;
            panelCita.Visible = false;
            panelPoS.Visible = false;
            PanelPrincipal.Visible = false;
            PanelInventario.Visible = false;
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            LblBienvenida.Text = "Registrar Producto";
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = true;
            PanelPrincipal.Visible = false;
            PanelInventario.Visible = false;
        }

        private void RdbSi_CheckedChanged(object sender, EventArgs e)
        {
            TxtIdCliente.Text = "";
            TxtIdCliente.Enabled = true;
        }

        private void RdbNo_CheckedChanged(object sender, EventArgs e)
        {
            TxtIdCliente.Text = "Visita";
            TxtIdCliente.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LblBienvenida.Text = "Inicio Cita";
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
            PanelPrincipal.Visible = true;

            TxtApellidosCita.Text = "";
            TxtNombreCita.Text = "";
            TxtEmailCita.Text = "";
            TxtTelCita.Text = "";
            TxtIdCliente.Text = "";
        }

        private void BtnCancelarCliente_Click(object sender, EventArgs e)
        {
            LblBienvenida.Text = "Inicio";
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
            PanelPrincipal.Visible = true;

            TxtApellidoCliente.Text = "";
            TxtDireccionCliente.Text = "";
            TxtEmaiCliente.Text = "";
            TxtNombreCliente.Text = "";
            TxtTelefonCliente.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LblBienvenida.Text = "Inicio Inventario";
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
            PanelPrincipal.Visible = true;
            TxtIdBusqueda.Text = "";
        }

        private void BtnCancelPro_Click(object sender, EventArgs e)
        {
            LblBienvenida.Text = "Inicio";
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
            PanelPrincipal.Visible = true;

            TxtIdPro.Text = "";
            TxtNombrePro.Text = "";
            TxtPrecProd.Text = "";
            TxtProveedorProd.Text = "";
            CbTipo.Text = "";

            
        }

        private void BtnCsesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to logout", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Form1 objLogin = new Form1();
                objLogin.Show();
                this.Close();
                this.Hide();
            }
        }

    }
}
