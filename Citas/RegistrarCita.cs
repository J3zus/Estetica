using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Estetica.Citas
{
    public partial class RegistrarCita : Form
    {
        public RegistrarCita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // PanelPrinc.Visible = false;
            panelCita.Visible = false;
            panelCliente.Visible = true;
            panelPoS.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCita_Click(object sender, EventArgs e)
        {
            
            panelCita.Visible = true;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
        }

        private void BtnPoS_Click(object sender, EventArgs e)
        {
            
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
               e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }

            if (TxtTelefono.Text.Trim().Length != 9)
            {
                LblTelefonoError.Text = "El Teléfono debe tener 10 dígitos";
            }
            else{
                LblTelefonoError.Text = "";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void TxtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
               e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }

            if (TxtTelefono.Text.Trim().Length != 9)
            {
                LblTelefonoError.Text = "El Teléfono debe tener 10 dígitos";
            }
            else
            {
                LblTelefonoError.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
        }

        private void BtnCancelPro_Click(object sender, EventArgs e)
        {
            
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
        }

        private void TxtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
