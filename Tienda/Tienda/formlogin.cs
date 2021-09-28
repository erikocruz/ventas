using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;
            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            if (usuario == "admin" && contrasena == "unah")
            {
                
            
            this.Close();
            }
             
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
}
        }
    }
}


