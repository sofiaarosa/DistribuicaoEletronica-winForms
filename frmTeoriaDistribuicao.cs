using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuição_Eletrônica
{
    public partial class frmTeoria : Form
    {
        public frmTeoria()
        {
            InitializeComponent();
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            frmDistribuicao muda = new frmDistribuicao();
            this.Hide();
            muda.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
