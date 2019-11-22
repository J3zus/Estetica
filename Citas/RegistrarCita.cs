using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            PanelPrinc.Visible = false;
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
            PanelPrinc.Visible = false;
            panelCita.Visible = true;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
        }

        private void BtnPoS_Click(object sender, EventArgs e)
        {
            PanelPrinc.Visible = false;
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PanelPrinc.Visible = true;
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PanelPrinc.Visible = true;
            panelCita.Visible = false;
            panelCliente.Visible = false;
            panelPoS.Visible = false;
        }
    }
}
