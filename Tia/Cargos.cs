using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Tia
{
    public partial class Cargos : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-TTHU8V4;Initial Catalog=Tia;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public int itemC;
        public int Item
        {
            get { return itemC; }
            set { itemC = value; }
        }
        public Cargos()
        {
            InitializeComponent();
            tex_nombre.Focus();
            ra_agregar.Checked = true;
           //cn.Open();
        }

        private void Cargos_Load(object sender, EventArgs e)
        {
            lab_tipocuenta.Text = "Null";
            //cn.Open();
        }

        private void combx_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {    
       int iten = combx_puesto.SelectedIndex;
       itemC = iten + 1;
            if (iten == 0)
            {   lab_tipocuenta.Text = "ADMIN";
                iten = iten + 1;
                //SqlCommand cmd = new SqlCommand("select top(1)i_IdAdmin +1 as id from Cuentas order by i_IdAdmin desc", cn);
                cn.Open();
                cmd = new SqlCommand("select count(i_IdAdmin) + 1 as id from Cuentas where  i_IdCargos = 1", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { tex_id.Text = dr["id"].ToString(); } cn.Close();

                pictBx_foto.BackgroundImage = Properties.Resources.admin;
                pictBx_foto.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                lab_tipocuenta.Text = "CAJERO";
                cmd = new SqlCommand("select count(i_IdAdmin) + 1 as id from Cuentas where  i_IdCargos = 2", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { tex_id.Text = dr["id"].ToString(); cn.Close();}

                pictBx_foto.BackgroundImage = Properties.Resources.user;
                pictBx_foto.BackgroundImageLayout = ImageLayout.Stretch;
            }
            //cn.Close();
        }

        private void limpiar() { 
            tex_id.Text = "";
            lab_tipocuenta.Text = "";
            tex_nombre.Text = "";
            tex_apellido.Text = "";
            tex_usuario.Text = "";
            tex_contrace.Text = "";
            combx_puesto.Text = "Seleccione...";
            pictBx_foto.BackgroundImage = Properties.Resources.inconicto;
            pictBx_foto.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        //BOTON AGREGAR -----------------------------------------------------------
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            cn.Open();
            ///var combo = combx_puesto.Text;
            //MessageBox.Show(combo);
            if (tex_nombre.Text == "")
            { MessageBox.Show("rellene la casilla Nombre", "Att Poveda"); tex_nombre.Focus(); }
            else if (tex_apellido.Text == "")
            { MessageBox.Show("rellene la casilla Apellido", "Att Poveda"); tex_apellido.Focus(); }
            //else if (combx_puesto.SelectedIndex == 1 || combx_puesto.SelectedIndex == 2)
            else if (combx_puesto.Text == "Selecione...")
           { MessageBox.Show("rellene con un tipo de cuenta", "Att Poveda"); combx_puesto.Focus(); }
            else if (tex_usuario.Text == "")
            { MessageBox.Show("rellene el Usuario", "Att Poveda"); tex_usuario.Focus(); }
            else if (tex_contrace.Text == "")
            { MessageBox.Show("rellene la contraceña", "Att Poveda"); tex_contrace.Focus(); }
            else
            {
                cmd = new SqlCommand("exec sp_insertar_cuenta '" + tex_nombre.Text + "','" + tex_apellido.Text + "','" + itemC + "','" + tex_usuario.Text + "','" + tex_contrace.Text + "'", cn);
                cmd.ExecuteReader();
                if (MessageBox.Show("se ingreso correctamene el new user", "Att Poveda", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    limpiar();
                }
            }
        }//FIN DEL BOTON AGREGAR ---------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_panel_control_Click(object sender, EventArgs e)
        {
            this.Close();
            PanelControl pc = new PanelControl();
            pc.Show();
        }

        //-------------   RADIO BOTUNN ----------------------------------------
        private void ra_buscar_CheckedChanged(object sender, EventArgs e)
        {
            tex_nombre.Focus();
            btn_agregar.Enabled = false; btn_eliminar.Enabled = false; btn_actualizar.Enabled = false; btn_buscar.Enabled = true;
        }

        private void ra_agregar_CheckedChanged(object sender, EventArgs e)
        {
            tex_nombre.Focus();
            btn_agregar.Enabled = true; btn_eliminar.Enabled = false; btn_actualizar.Enabled = false; btn_buscar.Enabled = false;
        }

        private void ra_actualizar_CheckedChanged(object sender, EventArgs e)
        {
            tex_nombre.Focus();
            btn_agregar.Enabled = false; btn_eliminar.Enabled = false; btn_actualizar.Enabled = true; btn_buscar.Enabled = false;
        }

        private void ra_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            tex_nombre.Focus();
            btn_agregar.Enabled = false; btn_eliminar.Enabled = true; btn_actualizar.Enabled = false; btn_buscar.Enabled = false;
        }




        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            cn.Open();
            if (tex_id.TextLength > 0)
            {
                try
                {
                    cmd = new SqlCommand("exec sp_eliminar_cargo " + int.Parse(this.tex_id.Text) + "", cn);
                    cmd.ExecuteReader();
                    MessageBox.Show("SE ELIMINO CON EXITO POR ID", "Att Poveda");
                    cn.Close();
                }
                catch (Exception error) { MessageBox.Show("no se pudo eliminar la cuenta por ID \n"+error+"Att Poveda"); }
            }
            else if (tex_nombre.TextAlign > 0)
            {
                try
                {
                    cmd = new SqlCommand("exec sp_eliminar_cargo_nom '" + this.tex_nombre.Text + "'", cn);
                    cmd.ExecuteReader();
                    MessageBox.Show("SE ELIMINO CON EXITO POR NOMBRE","Att Poveda");
                    cn.Close();
                }
                catch (Exception error) { MessageBox.Show("no se pudo eliminar la cuenta por NOMBRE \n" + error + "Att Poveda"); }
            }
            else { MessageBox.Show("Es solo valido para ID, NOMBRE --> de la cuenta"); }
        }


    }
}
