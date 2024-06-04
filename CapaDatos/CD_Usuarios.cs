using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void agregar(string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "agregarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
