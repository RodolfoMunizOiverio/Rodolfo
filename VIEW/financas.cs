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
    public partial class financas : Form
    {
        public financas()
        {
            InitializeComponent();
        }

        private void BotaoNovaReceita_Click(object sender, EventArgs e)
        {
            novaReceita nova = new novaReceita();
            nova.Show();
        }

        private void BotaoNovaDespesa_Click(object sender, EventArgs e)
        {
            novaDespesa nova = new novaDespesa();
            nova.Show();
        }
    }
}
