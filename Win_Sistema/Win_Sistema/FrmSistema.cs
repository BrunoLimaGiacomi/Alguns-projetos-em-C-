using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Sistema
{
    public partial class FrmSistema : Form
    {
        #region Declaração de Variáveiis Objeto
        string texto = "Deseja sair do Sistema?";
        string titulo = "<<<< FINALIZANDO >>>>";
        MessageBoxButtons botao = MessageBoxButtons.YesNo;
        MessageBoxIcon icone = MessageBoxIcon.Question;
        object resposta;
        #endregion
        #region Método Construtor da Classe
        public FrmSistema()
        {
            InitializeComponent();
        }
        #endregion
        #region Método para Sair da Aplicação
        public void Saida()
        {
            resposta= MessageBox.Show(texto,titulo,botao,icone);
            if (resposta.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }
        #endregion
        #region Código do Item de Menu Verificação de Números
        private void verificaçãoDeNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_Exemplo01.FrmExemplo01 verifica = new Win_Exemplo01.FrmExemplo01();
            verifica.ShowDialog();
        }
        #endregion
        #region Código do Item de Menu Raiz Quadrada
        private void raizQuadradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_RaizQuadrada.FrmRaizQuadrada raiz=new Win_RaizQuadrada.FrmRaizQuadrada();
            raiz.ShowDialog();
        }
        #endregion
        #region Código do Menu Sair do Sistema
        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Saida();
        }
        #endregion
        #region Código do Item de Menu Visualizador de Imagens
        private void visualizadorDeImagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_VisualizadorImagens.FrmVisualizarImagem imagem=new Win_VisualizadorImagens.FrmVisualizarImagem();
            imagem.ShowDialog();
        }
        #endregion
        #region Código do Item de Menu ComboBox
        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_ComboBox.FrmComboBox combo= new Win_ComboBox.FrmComboBox();
            combo.ShowDialog();
        }
        #endregion
        #region Código do Item de Menu ListBox
        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_ListBox.FrmListaBox lista = new Win_ListBox.FrmListaBox();
            lista.ShowDialog();
        }
        #endregion
    }
}
