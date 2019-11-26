using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GE_FISIO.VIEW
{
    public partial class novaDespesa : Form
    {
        public novaDespesa()
        {
            InitializeComponent();
        }

        private void SelecionaDataNasc_ValueChanged(object sender, EventArgs e)
        {
            dataDespesa.Text = selecionaDataDespesa.Text;
        }
    }
}
