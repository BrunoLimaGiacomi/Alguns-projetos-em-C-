using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Banco06
{
    public partial class FrmBanco06 : Form
    {
        ClassBD bd = new ClassBD();
        public FrmBanco06()
        {
            InitializeComponent();
        }

        private void FrmBanco06_Load(object sender, EventArgs e)
        {

            dataSet1BindingSource.DataSource = bd.ProcedureRetornaDataSet();
            this.reportViewer1.RefreshReport();
        }
    }
}
