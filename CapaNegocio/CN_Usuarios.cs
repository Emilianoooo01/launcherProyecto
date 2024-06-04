using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objetoCD = new CD_Usuarios();

        public DataTable mostrarUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrar();
            return tabla;
        }

        public void insertarProd(string nombre)
        {
            objetoCD.agregar(nombre);
        }
    }
}
