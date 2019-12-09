using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tia
{
    public partial class Productos : Form
    {
        public int codigo_global;
        public string nombre_global;
        public float precio_global;
        public int cantistok_global;
        public string total_global;
        public string img_global;
        public string descri_global;

        conectar co = new conectar();
        public Productos()
        {
            InitializeComponent();
            co.leerproductos(dataGridView1);
        }
        private void Productos_Load(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------------------
        //---------------------- KEYPRESS --------------------------------
        private void cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
            if ((e.KeyChar) == Convert.ToChar(Keys.Enter) || (e.KeyChar) == Convert.ToChar(Keys.Tab))
            {
                if (co.busqueda(Convert.ToInt32(lab_cod.Text)) == 0)
                {
                    lab_nombre.Focus();
                }
                else
                {
                    lab_cod.Text = co.codcargo.ToString();
                    lab_nombre.Text = co.nomproducto;
                    lab_precio.Text = co.precio_producto;
                    lab_cantidad.Text = co.cantidad_busqueda.ToString();
                    lab_descricion.Text = co.descri;
                    lab_total.Text = co.total_inver;
                    //calculartotal.Focus();
                    btn_nuevo.Focus();
                }
            }
        }

        private void tex_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Validacion.SoloLetras(e);
            if ((e.KeyChar) == Convert.ToChar(Keys.Enter))
            {
                //tex_genero.Focus();
            }
        }

        private void tex_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
            if ((e.KeyChar) == Convert.ToChar(Keys.Enter))
            {
                lab_cantidad.Focus();
            }
        }
      
        private void tex_cantida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
            if ((e.KeyChar) == Convert.ToChar(Keys.Enter))
            {
                lab_total.Text = (float.Parse(lab_precio.Text) * int.Parse(lab_cantidad.Text)).ToString();
                lab_descricion.Focus();
            }
        }

        private void tex_descricion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacion.SoloLetras(e);
            if ((e.KeyChar) == Convert.ToChar(Keys.Enter))
            {
                calculartotal.Focus();
            }
        }

        private void combx_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == Convert.ToChar(Keys.Enter))
            {
                btn_agregar.Focus();
            }
        }
        //FIN DEL KEYPRESS   -------------------------------------------------
        
//-------------------------------------------------------------------------------------
        private void limpiar() {
            lab_cod.Text = ""; lab_nombre.Text = ""; lab_precio.Text = ""; lab_cantidad.Text = ""; lab_total.Text = "$"; lab_descricion.Text = "";
        }

//-------------------------------------------------------------------------------------
        // boton Agregar
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (lab_cod.Text == "") { MessageBox.Show("rellene el campo codigo"); lab_cod.Focus(); }
            else if (lab_nombre.Text == "") { MessageBox.Show("rellene el el campo nombre"); lab_nombre.Focus(); }
            else if (lab_precio.Text == "") { MessageBox.Show("rellene el campo precio"); lab_precio.Focus(); }
            else if (lab_cantidad.Text == "") { MessageBox.Show("rellene el campo cantidad de stok"); lab_cantidad.Focus(); }
            else if (lab_total.Text == "") { MessageBox.Show("el total no puede estar vacio vele a calcular"); calculartotal.Focus(); }
            else if (lab_descricion.Text == "") { MessageBox.Show("haga una descicion del producto"); lab_descricion.Focus(); }
            //else if (combx_marca.Text == "Seleccione...") { MessageBox.Show("rellene el tipo de marca"); combx_marca.Focus(); }
            else
            {
                int cod = int.Parse(lab_cod.Text);
                string nom = lab_nombre.Text;
                float precio = float.Parse(this.lab_precio.Text);
                int cantidad = int.Parse(this.lab_cantidad.Text);
                int total = int.Parse(lab_total.Text);
                string img = "null";
                string descri = lab_descricion.Text;
                //int marca = combx_marca.SelectedIndex + 1;
                if (co.busqueda(Convert.ToInt32(cod)) == 0)
                {
                    co.agregarproducto(cod, nom, precio, cantidad, total, img, descri);
                     MessageBox.Show("Se Agregado Correctamente el Producto", "Att Poveda");
                    co.leerproductos(dataGridView1);
                    limpiar();
                }else
                {
                    MessageBox.Show("YA EXISTE UN REGISTRO CON ES CODIGO ");
                }
                   
            }
        }

        //boton Nuevo
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            PanelControl pc = new PanelControl();
            pc.Show();
        }

        private void calculartotal_Click(object sender, EventArgs e)
        {
            lab_total.Text = (float.Parse(lab_precio.Text) * int.Parse(lab_cantidad.Text)).ToString();
        }

        //TRANSACIONES -----
        private void btn_panelcontrol_MouseHover(object sender, EventArgs e)
        {
            //btn_panelcontrol.Size = new Size(228, 38);
            //btn_panelcontrol.Location = new Point(606 , 348);
        }

        private void btn_panelcontrol_MouseLeave(object sender, EventArgs e)
        {
            //btn_panelcontrol.Size = new Size(178, 38);
            //btn_panelcontrol.Location = new Point(661, 392);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
            Eliminar_Producto ep = new Eliminar_Producto();
            ep.lab_cod.Text = codigo_global.ToString();
            ep.lab_nombre.Text = nombre_global.ToString();
            ep.lab_precio.Text = precio_global.ToString();
            ep.lab_cantidad.Text = cantistok_global.ToString();
            ep.descricion.Text = descri_global.ToString();
            ep.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         codigo_global = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            nombre_global = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            precio_global = float.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            cantistok_global = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            total_global = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            img_global = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            descri_global = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            lab_cod.Text = codigo_global.ToString();
            lab_nombre.Text = nombre_global;
            lab_precio.Text = precio_global.ToString();
            lab_cantidad.Text = cantistok_global.ToString();
            lab_total.Text = total_global;
            lab_descricion.Text = descri_global;
        }

        private void lab_cod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
