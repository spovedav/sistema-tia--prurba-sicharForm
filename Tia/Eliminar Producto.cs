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
    public partial class Eliminar_Producto : Form
    {
        conectar co = new conectar();
        public Eliminar_Producto()
        {
            InitializeComponent();
            co.leerproductos(dataGridView1);
        }
        private void limpiar()
        {
            lab_cod.Text = ""; lab_nombre.Text = ""; lab_precio.Text = ""; lab_cantidad.Text = ""; lab_total.Text = "$"; descricion.Text = "";

        }

        private void lab_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
            if ((e.KeyChar) == Convert.ToChar(Keys.Enter))
            {
                if (co.busqueda(Convert.ToInt32(lab_cod.Text)) == 0)
                {
                    //si no xiste
                    if (MessageBox.Show("EL COD NO EXISTE, QUIERE INGRESARLO","Att Poveda",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)== DialogResult.Yes)
                    {
                        this.Hide();
                        Productos p = new Productos();
                        p.lab_cod.Text = lab_cod.Text;
                        p.Show();
                    }
                }
                else
                {
                    lab_cod.Text = co.codcargo.ToString();
                    lab_nombre.Text = co.nomproducto;
                    lab_precio.Text = co.precio_producto;
                    lab_cantidad.Text = co.cantidad2.ToString();
                    lab_total.Text = co.total_inver;
                    descricion.Text = co.descri;
                    //info_producto.Text = comboBox1.Text;
                    
                }
            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (lab_cod.Text != "")
            {
                co.eliminarproducto(int.Parse(lab_cod.Text));
                co.leerproductos(dataGridView1);
                limpiar();
            }
            else MessageBox.Show("No puede estar vacio el campo","Att Poveda");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           lab_cod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lab_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lab_precio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lab_cantidad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lab_total.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            // = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            descricion.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void agregarimg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("esta funcion aun no esta disponible");
        }
    }
}
