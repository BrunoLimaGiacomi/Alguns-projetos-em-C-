using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_RaizQuadrada
{
    public partial class FrmRaizQuadrada : Form
    {
        ClassProcessar cp= new ClassProcessar();
        double n;
        public FrmRaizQuadrada()
        {
            InitializeComponent();
        }

        public void Cancelar()
        {
            txtnum.Clear();
            txtnum.Focus();
        }

        public void Sair()
        {
            if(MessageBox.Show("Deseja sair da aplicação?",
                               "<<<<< FINALIZANDO >>>>>",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == DialogResult.Yes)
            {
               // Application.Exit();
               this.Close();
            }
            else
            {
                this.Cancelar();
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {  
                this.n=double.Parse(txtnum.Text);
                MessageBox.Show("A Raiz quadrada de "+this.n+" é igual a "+
                                cp.CalcRaiz(this.n),
                                "***** RAIZ QUADRADA *****",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"+++++ ERRO +++++",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Cancelar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Cancelar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Sair();
        }
    }
}
