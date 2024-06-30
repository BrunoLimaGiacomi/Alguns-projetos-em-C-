using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_VisualizadorImagens
{
    public partial class FrmVisualizarImagem : Form
    {
        public FrmVisualizarImagem()
        {
            InitializeComponent();
        }

        private void rdoImagem1_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.AlimentosSaudáveis;
        }

        private void rdoImagem2_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.Alimentossaudaveis;
        }

        private void rdoSemBordas_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle=BorderStyle.None;
        }

        private void rdoBordasFixas_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
        }

        private void rdoBordas3D_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.Fixed3D;
        }

        private void chkVisivelInvisivel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVisivelInvisivel.Checked)
            {
                pcbFoto.Visible = true;
            }
            else
            {
                pcbFoto.Visible = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair da aplçicação?",
                                "**** FIM ****",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void rdoSemImagem_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image=Properties.Resources.SemImagem;
        }

        private void FrmVisualizarImagem_Activated(object sender, EventArgs e)
        {
            chkVisivelInvisivel.Checked=true;
        }
    }
}
