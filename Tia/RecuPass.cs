using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tia
{
    public partial class RecuPass : Form
    {
        public RecuPass()
        {
            InitializeComponent();
            labUsuario.Text = Acceso.NombCuenta;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (che_clave.Checked == true)
                tex_clave.UseSystemPasswordChar = false;
            else
                tex_clave.UseSystemPasswordChar = true;
        }
    }
}
