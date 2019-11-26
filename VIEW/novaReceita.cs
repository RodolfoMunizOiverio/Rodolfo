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
    public partial class novaReceita : Form
    {
        public novaReceita()
        {
            InitializeComponent();
        }

        private void SelecionaDataReceita_ValueChanged(object sender, EventArgs e)
        {
            dataReceita.Text = selecionaDataReceita.Text;
        }
    }
}
