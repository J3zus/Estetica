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

        private void button1_Click(object sender, EventArgs e)
        {
            Citas.RegistrarCita formCitas = new Citas.RegistrarCita();
            formCitas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
