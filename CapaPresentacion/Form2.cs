﻿using System;
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
    public partial class Form2 : Form
    {
        CN_Usuarios objetoCN = new CN_Usuarios();

        public Form2()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            objetoCN.insertarProd(txtNombre.Text);
            MessageBox.Show("Se registro correctamente");

            this.Close();
        }
    }
}
