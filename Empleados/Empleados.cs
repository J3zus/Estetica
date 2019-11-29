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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void PBsalir_Click(object sender, EventArgs e)
        {
            Index.Index formIndex = new Index.Index();
            formIndex.Show();
            this.Close();
        }
    }
}
