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
    public partial class formmenu : Form
    {
        public formmenu()
        {
            InitializeComponent();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formlogin = new formlogin();
            formlogin.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ropaParaDamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproductos_mujer = new formproducto();
            formproductos_mujer.MdiParent = this;
            formproductos_mujer.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ropaParaCaballeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproductos_hombre = new Forminventarioh();
            formproductos_hombre.MdiParent = this;
            formproductos_hombre.Show();
        }

        private void ropaParaNiñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproductos_nino = new Forminventarion();
            formproductos_nino.MdiParent = this;
            formproductos_nino.Show();
        }

        private void reporteDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formreporinventario = new formreportinve();
            formreporinventario.MdiParent = this;
            formreporinventario.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formreporcliente = new formreportclie();
            formreporcliente.MdiParent = this;
            formreporcliente.Show();
        }

        private void reporteDeErroresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formreporterror = new formreporterr();
            formreporterror.MdiParent = this;
            formreporterror.Show();
        }

        private void administrarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formadmbase = new formadmbase();
            formadmbase.MdiParent = this;
            formadmbase.Show();

        }

        private void formmenu_Load(object sender, EventArgs e)
        {
            var formlogin = new formlogin();
            formlogin.ShowDialog();
        }
    }
    }

