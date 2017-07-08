using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traduccion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnespanol_Click(object sender, EventArgs e)
        {
            lblpruba.Text = "Prueba";
            btncerrar.Text = "Cerrar";
        }

        private void btningles_Click(object sender, EventArgs e)
        {
            lblpruba.Text = "Test";
            btnespanol.Text = "spanish";
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
