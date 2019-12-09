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
    public partial class PanelControl : Form
    {   
        public PanelControl()
        {
            InitializeComponent();
            btn_consulta.Focus();
        int user = Acceso.TipoCuenta;
       
        if (user == 1)
        {
            lab_tipo_usuario.Text = "Administrador";
            pictureBox1.BackgroundImage = Properties.Resources.admin;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        else if (user == 2)
        {
            lab_tipo_usuario.Text = "Cajero";
            btn_modi_producto.Enabled = false;
            btn_modi_registro.Enabled = false;

            pictureBox1.BackgroundImage = Properties.Resources.user;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        else
            lab_tipo_usuario.Text = "Null Null Null";


            lab_NombreCuenta.Text = Acceso.NombCuenta;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            this.Close();
            VENDER p = new VENDER();
            p.Show();
        }

        private void PanelControl_MouseHover(object sender, EventArgs e)
        {

        }

        //METODO LABEL3 propiedades -------------------------------------
        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            RecuPass rp = new RecuPass();
            rp.ShowDialog();
        } 
        //---------------------------------------------------------------------

        private void btn_modi_registro_Click(object sender, EventArgs e)
        {
            this.Close();
            Productos p = new Productos();
            p.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            INICIO f = new INICIO();
            f.Show();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void btn_modi_producto_Click(object sender, EventArgs e)
        {
            this.Close();
            Eliminar_Producto ep = new Eliminar_Producto();
            ep.Show();
        }

        private void label4_MouseHover_2(object sender, EventArgs e)
        {
 label4.ForeColor = Color.Red;
        }

        private void label4_MouseLeave_1(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }


        private void btn_cambiar_imagen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("por motivo de estres no se termino esto", "Att Poveda");
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            INICIO f = new INICIO();
            f.Show();
        }
       
    }
}
