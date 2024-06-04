using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form3 : Form
    {
        CN_Usuarios objetoCN = new CN_Usuarios();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            mostratUsuarios();
        }

        private void mostratUsuarios()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dataGridView1.DataSource = objeto.mostrarUsuario();
        }
    }
}
