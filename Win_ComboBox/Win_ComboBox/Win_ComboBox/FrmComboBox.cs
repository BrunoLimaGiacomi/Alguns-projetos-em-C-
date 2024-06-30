using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_ComboBox
{
    public partial class FrmComboBox : Form
    {
        #region Declaração das variáveis
        string texto = "Deseja sair da aplicação?";
        string cabec = "***** FIM *****";
        MessageBoxButtons botao= MessageBoxButtons.YesNo;
        MessageBoxIcon icone = MessageBoxIcon.Question;
        object resposta;
        #endregion
        #region Método Construtor da Classe
        public FrmComboBox()
        {
            InitializeComponent();
        }
        #endregion
        #region Código do Botão Adicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            cboListaDropDownList.Items.Add(txtTexto.Text);
            txtTexto.Clear();
            txtTexto.Focus();
        }
        #endregion
        #region Código do botão Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboListaDropDownList.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item foi selecionado!!!",
                                "**** ComboBox ****",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                cboListaDropDownList.Items.RemoveAt(cboListaDropDownList.SelectedIndex);
            }
        }
        #endregion
        #region Código do botão Limpar Toda a Lista
        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            cboListaDropDownList.Items.Clear();
        }
        #endregion
        #region Código do botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            cboListaDropDownList.SelectedIndex = -1;
            lblPosLista.Text = null;
            lblTextoSel.Text = null;
            lblTotal.Text = null;
            txtTexto.Focus();
        }
        #endregion
        #region Código do botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            resposta = MessageBox.Show(texto, cabec, botao, icone);
            if (resposta.Equals(DialogResult.Yes))
            {
               this.Close();
            }
            else
            {
                btnLimpar_Click(sender, e);
            }
        }
        #endregion
        #region Código do ComboBox
        private void cboListaDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboListaDropDownList.SelectedIndex != -1)
            {
                lblPosLista.Text=cboListaDropDownList.SelectedIndex.ToString();
                lblTextoSel.Text=cboListaDropDownList.SelectedItem.ToString();
                lblTotal.Text=cboListaDropDownList.Items.Count.ToString();
            }
        }
        #endregion
        #region Código da tecla ENTER
        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAdicionar_Click(sender, e);
            }
        }
        #endregion
    }
}
