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
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
            tex_usuario.Focus();
            lab_fecha.Text = DateTime.Now.ToLongDateString();
            lab_hora.Text = DateTime.Now.ToLongTimeString();
        }
        Acceso ace = new Acceso();
        int veces = 0;
        private const int intentos = 2;

        private void Form1_Load(object sender, EventArgs e)
        {
            tex_usuario.Focus();
            che_clave.Checked = false;

           // Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
          //  Int32 alto = (desktopSize.Height - 200) / 2;
          //  Int32 ancho = (desktopSize.Width - 500) / 2;
           // panelingreso.Location = new Point(ancho, alto);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Yellow;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void che_clave_CheckedChanged(object sender, EventArgs e)
        {

            if (che_clave.Checked == false)
            {
                che_clave.Image = Properties.Resources.seguridad_ojo;
                tex_clave.UseSystemPasswordChar = true;
            }
            else
            {
                che_clave.Image = Properties.Resources.seguridad_ojo2;
                tex_clave.UseSystemPasswordChar = false;
            }
        }

        private void tex_usuario_Enter(object sender, EventArgs e)
        {
            tex_usuario.BackColor = Color.Yellow;
        }

        private void tex_usuario_MouseLeave(object sender, EventArgs e)
        {
            tex_usuario.BackColor = Color.White;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(125, 75);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(100, 50);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lab_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Por motivo de Estres no se termino esta funcion","Att Poveda");
        }

       //inicio de secion clave
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ace.Usuario = tex_usuario.Text;
            ace.Clave = tex_clave.Text;
            
            if (tex_usuario.Text == "")
            {
                MessageBox.Show("Digite Usuario para Continuar", "CompuBinario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tex_usuario.Focus();
            }
            else if (tex_clave.Text == "")
            {
                MessageBox.Show("Digite Clave para Continuar", "CompuBinario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tex_clave.Focus();
            }
            else if (ace.Verificar() == true)
            {
                //MessageBox.Show(ace.Mensaje, "CompuBinario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                // MessageBox.Show(ace.NombreCuenta,"nombre de la cuenta");
                this.Hide();
                PanelControl pc = new PanelControl();
                pc.Show();     
            }
            else
            {
                if (veces == 2)
                {
                    MessageBox.Show(ace.Mensaje, "CompuBinario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Su Usuario o Contraseña NO Coinciden o son Erroneas \n \n                        Le Quedan " + (intentos - veces) + " Intento(s)", "CompuBinario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tex_usuario.Clear();
                    tex_clave.Clear();
                    veces = veces + 1;
                }
            }//fin del else
        }//fin del metodo

        private void tex_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tex_usuario.Text != "")
            {
                if ((e.KeyChar) == Convert.ToChar(Keys.Enter) || (e.KeyChar) == Convert.ToChar(Keys.Tab))
                {
                    tex_clave.Focus();
                }
            }
            //else MessageBox.Show("El usuario no puede estar VACIO", "Att Poveda", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void tex_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tex_clave.Text != "")
            {
                if ((e.KeyChar) == Convert.ToChar(Keys.Enter)) {
                    ace.Usuario = tex_usuario.Text;
                    ace.Clave = tex_clave.Text;

                    if (tex_usuario.Text == "")
                    {
                        MessageBox.Show("Digite Usuario para Continuar", "CompuBinario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tex_usuario.Focus();
                    }
                    else if (tex_clave.Text == "")
                    {
                        MessageBox.Show("Digite Clave para Continuar", "CompuBinario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tex_clave.Focus();
                    }
                    else if (ace.Verificar() == true)
                    {
                        //MessageBox.Show(ace.Mensaje, "CompuBinario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        // MessageBox.Show(ace.NombreCuenta,"nombre de la cuenta");
                        this.Hide();
                        PanelControl pc = new PanelControl();
                        pc.Show();
                    }
                    else
                    {
                        if (veces == 2)
                        {
                            MessageBox.Show(ace.Mensaje, "CompuBinario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Su Usuario o Contraseña NO Coinciden o son Erroneas \n \n                        Le Quedan " + (intentos - veces) + " Intento(s)", "CompuBinario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tex_usuario.Clear();
                            tex_clave.Clear();
                            veces = veces + 1;
                        }
                    }//fin del else
                }
            }
            //else MessageBox.Show("La contraceña no puede estar VACIA", "Att Poveda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
