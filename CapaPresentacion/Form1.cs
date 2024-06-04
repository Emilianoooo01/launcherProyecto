using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //Remplazar por la direccion del videojuego
            Process.Start("notepad.exe");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.ShowDialog();
        }
    }
}
