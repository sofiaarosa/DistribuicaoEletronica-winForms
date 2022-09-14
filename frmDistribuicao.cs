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
    public partial class frmDistribuicao : Form
    {
        public frmDistribuicao()
        {
            InitializeComponent();
        }
        private void limpar()
        {
            lblResult.Text = " ";
            lblKs.Visible = false; lblKs.Text = " ";
            lblLs.Visible = false; lblLs.Text = " ";
            lblLp.Visible = false; lblLp.Text = " ";
            lblMs.Visible = false; lblMs.Text = " ";
            lblMp.Visible = false; lblMp.Text = " ";
            lblMd.Visible = false; lblMd.Text = " ";
            lblNs.Visible = false; lblNs.Text = " ";
            lblNp.Visible = false; lblNp.Text = " ";
            lblNd.Visible = false; lblNd.Text = " ";
            lblNf.Visible = false; lblNf.Text = " ";
            lblOs.Visible = false; lblOs.Text = " ";
            lblOp.Visible = false; lblOp.Text = " ";
            lblOf.Visible = false; lblOf.Text = " ";
            lblOd.Visible = false; lblOd.Text = " ";
            lblPs.Visible = false; lblPs.Text = " ";
            lblPp.Visible = false; lblPp.Text = " ";
            lblPd.Visible = false; lblPd.Text = " ";
            lblQs.Visible = false; lblQs.Text = " ";
            lblQp.Visible = false; lblQp.Text = " ";
        }

        private void distribui(int numeroAtomico)
        {
            int ks = 0, ls = 0, lp = 0, ms = 0, mp = 0, md = 0, ns = 0, np = 0, nd = 0, nf = 0, os = 0, op = 0, od = 0, of = 0, ps = 0, pp = 0, pd = 0, qs = 0, qp = 0;
            for (int i=1;i<=numeroAtomico;i++)
            {
                if (i <= 2)
                {
                    ks++;
                    lblKs.Text = "1s" + ks;
                    lblKs.Visible = true;
                }
                else if (i > 2 && i <= 4)
                {
                    ls++;
                    lblLs.Text = "2s" + ls;
                    lblLs.Visible = true;
                }
                else if (i > 4 && i <= 10)
                {
                    lp++;
                    lblLp.Text = "2p" + lp; 
                    lblLp.Visible = true;
                }
                else if (i > 10 && i <= 12)
                {
                    ms++;
                    lblMs.Text = "3s" + ms; 
                    lblMs.Visible = true;
                }
                else if (i > 12 && i <= 18)
                {
                    mp++;
                    lblMp.Text = "3p" + mp;
                    lblMp.Visible = true;
                }
                else if (i > 18 && i <= 20)
                {
                    ns++;
                    lblNs.Text = "4s" + ns;
                    lblNs.Visible = true;
                }
                else if (i > 20 && i <= 30)
                {
                    md++;
                    lblMd.Text = "3d" + md;
                    lblMd.Visible = true;
                }
                else if (i > 30 && i <= 36)
                {
                    np++;
                    lblNp.Text = "4p" + np;
                    lblNp.Visible = true;
                }
                else if (i > 36 && i <= 38)
                {
                    os++;
                    lblOs.Text = "5s" + os;
                    lblOs.Visible = true;
                }
                else if (i > 38 && i <= 48)
                {
                    nd++;
                    lblNd.Text = "4d" + nd;
                    lblNd.Visible = true;
                }
                else if (i > 48 && i <= 54)
                {
                    op++;
                    lblOp.Text = "5p" + op;
                    lblOp.Visible = true;
                }
                else if (i > 54 && i <= 56)
                {
                    ps++;
                    lblPs.Text = "6s" + ps;
                    lblPs.Visible = true;
                }
                else if (i > 56 && i <= 70)
                {
                    nf++;
                    lblNf.Text = "4f" + nf;
                    lblNf.Visible = true;
                }
                else if (i > 70 && i <= 80)
                {
                    od++;
                    lblOd.Text = "5d" + od;
                    lblOd.Visible = true;
                }
                else if (i > 80 && i <= 86)
                {
                    pp++;
                    lblPp.Text = "6p" + pp;
                    lblPp.Visible = true;
                }
                else if (i > 86 && i <= 88)
                {
                    qs++;
                    lblQs.Text = "7s" + qs;
                    lblQs.Visible = true;
                }
                else if (i > 88 && i <= 102)
                {
                    of++;
                    lblOf.Text = "5f" + of;
                    lblOf.Visible = true;
                }
                else if (i > 102 && i <= 112)
                {
                    pd++;
                    lblPd.Text = "6d" + pd;
                    lblPd.Visible = true;
                }
                else if (i > 112 && i <= 118)
                {
                    qp++;
                    lblQp.Text = "7p" + qp;
                    lblQp.Visible = true;
                }

            }//for
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            nudNumeroAtomico.Value = 1;
            limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDistribui_Click(object sender, EventArgs e)
        {
            limpar();
            int numeroAtomico = Convert.ToInt32(nudNumeroAtomico.Value);
            if (numeroAtomico > 118 || numeroAtomico < 1)
            {
                nudNumeroAtomico.Value = 1;
                limpar();
                lblResult.Text = "Máximo = 118!";
                return;
            }
            distribui(numeroAtomico);
            lblResult.Text = "(Z="+numeroAtomico+") "+
                lblKs.Text + " " + lblLs.Text + " " + lblLp.Text + " " + lblMs.Text + " " + lblMp.Text + " " + lblNs.Text + " " +
                lblMd.Text + " " + lblNp.Text + " " + lblOs.Text + " " + lblNd.Text + " " + lblOp.Text + " " + lblPs.Text + " " + 
                lblNf.Text + " " + lblOd.Text + " " + lblPp.Text + " " + lblQs.Text + " " + lblOf.Text + " " + lblPd.Text + " " + 
                lblQp.Text;
        }

        private void btnTeoria_Click(object sender, EventArgs e)
        {
            frmTeoria muda = new frmTeoria();
            this.Hide();
            muda.ShowDialog();
        }
    }
}
