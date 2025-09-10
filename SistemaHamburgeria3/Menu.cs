using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHamburgeria3
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            frmLoading loading = new frmLoading();
            loading.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sair == DialogResult.No)
            {
                btnPedido.Focus();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
