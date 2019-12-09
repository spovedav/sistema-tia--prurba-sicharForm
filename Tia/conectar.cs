using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tia
{
    class conectar
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public string codcargo;
           public int cantidad2;
       public string nomproducto;
        public string precio_producto,precio2;
        public string descri;
        public string total_inver;
        public string cantidad_busqueda;
        public conectar()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=tia2;Integrated Security=True");
                cn.Open();
               // MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se conecto con la base de datos:" + ex.ToString());
            }
        }

        public void leerproductos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("exec leerproducto", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUEDE COMPLETAR LA TRANSACCION" + ex.ToString());
            }
        }

        public int busqueda(int cod)
          {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("exec busqueda " + cod + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())   // ciclo que recorra todos los registros de la consulta. poveda
                {
                    codcargo = dr["cod_producto"].ToString();
                    nomproducto = dr["nomproducto"].ToString();
                    precio_producto = dr["precio"].ToString();
                    cantidad_busqueda = dr["cantstok"].ToString();
                    descri = dr["descri"].ToString();
                    total_inver = dr["totalinver"].ToString();
                    contador++;
                }
                dr.Close(); // cerrar el data reader
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR:" + ex.ToString());
            }
            return contador; // retornamos la variable contador poveda
        }

        public void combo_producto(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select nomproducto from Productos", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())   // ciclo que recorra todos los registros de la consulta. poveda
                {
                    cb.Items.Add(dr["nomproducto"].ToString());
                }
                dr.Close();
                }catch (Exception error) { MessageBox.Show("no su pudo rellenar el combobox de rrellenar el nombre producto \n"+error); }
        }

        public void precio(string nom)
        {
            try
            {
                cmd = new SqlCommand("select cod_producto,precio,cantstok,descri from Productos where nomproducto = '" + nom+"'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())   // ciclo que recorra todos los registros de la consulta. poveda
                {
                    precio2 = dr["precio"].ToString();
                    cantidad2 = int.Parse(dr["cantstok"].ToString());
                    codcargo = dr["cod_producto"].ToString();
                    descri = dr["descri"].ToString();
                }
                dr.Close();
            }
            catch (Exception error) { MessageBox.Show("no su pudo rellenar el combobox de rrellenar el nombre producto \n"+error); }
        }

        public void actualizar_producto(int cod, int can)
        {
            try
            {
                cmd = new SqlCommand("update Productos set cantstok = cantstok - "+can+" where cod_producto = "+cod+"", cn);
                dr = cmd.ExecuteReader();
             
                dr.Close();
            }
            catch (Exception error) { MessageBox.Show("no se pudo realizar esta operacion \n" + error); }
        }
        /*
        public bool Verificar(string usuario, string clave)
        {
            bool resultado = false;

            SqlCommand cmd = new SqlCommand("exec verificar '" + usuario + "','" + clave + "'", cn);
            cmd.Connection = cn;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //Nombre = dr["NombresAdmin"].ToString();
                //Apellido = dr["ApellidosAdmin"].ToString();
                Usuario = dr["nom"].ToString();
                id_cuenta = Convert.ToInt32(dr["id"]);
                NombCuenta = dr["nom"].ToString() + " " + dr["ape"].ToString();
                TipoCuenta = Convert.ToInt32(dr["codcargo"]);
                clave = dr["pass"].ToString();
                resultado = true;
                mensaje = "Inicio Correctamente \n \n               Bienvenido al Sistema tia \n \n TIA S.A";
                dr.Close();
            }
            else
            {
                mensaje = "         Excedio el Limite de Intentos al Sistema \n \nEspere unos Minutos y Ingrese Su Logueo Otra Vez";
            }
            cn.Close();
            return resultado;
        }*/

        // FROM NUEVO PRODUCTOS -------------------------------
        public void agregarproducto(int cod,string nom,float precio,int cantidad, float total, string img, string drecri)
        {
            try
            {
                cmd = new SqlCommand("exec agregarproducto "+cod+", '"+nom+"' , "+precio+" , "+cantidad+" , "+total+" , '"+img+"' , '"+descri+"' ", cn);
                dr = cmd.ExecuteReader();

                dr.Close();
            }
            catch (Exception error) { MessageBox.Show("no se pudo realizar esta operacion \n" + error); }
        }

        public void eliminarproducto(int cod)
        {
            try
            {
                cmd = new SqlCommand("exec eliminarproducto "+cod+"", cn);
                dr = cmd.ExecuteReader();
                MessageBox.Show("Se a elimando un registro");
                dr.Close();
            }
            catch (Exception error) { MessageBox.Show("no se pudo eliminar el registro \n" + error); }
        }


    }
}
