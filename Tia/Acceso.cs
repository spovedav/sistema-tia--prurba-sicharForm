//Este programa fue echo por STEVYN POVEDA en las fechas al princìpio de Abril del 2018
//DESAROLLADOR:  Stevyn Poveda
//SISTEMA TIA  01/04/2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Tia
{
    class Acceso
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Tia2;Integrated Security=True");
        private string mensaje;
        private string usuario;
        private string clave;
       public static string NombCuenta = "";
       public static int TipoCuenta = 0;

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
       
        public bool Verificar()
        {
            bool resultado = false;
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Cuentas where ApadoAdmin='" + usuario + "'and PassAdmin='" + clave + "'", cn);
            cmd.Connection = cn;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                NombCuenta = dr["NombresAdmin"].ToString() + " " + dr["ApellidosAdmin"].ToString();
                TipoCuenta = Convert.ToInt32(dr["i_IdCargos"]);
                resultado = true;
                mensaje = "Inicio Correctamente \n \n               Bienvenido al Sistema tia \n \n TIA S.A";
            }

            else
            {
                mensaje = "         Excedio el Limite de Intentos al Sistema \n \nEspere unos Minutos y Ingrese Su Logueo Otra Vez";
            }
            cn.Close();
            return resultado;
        }
    }
}
