using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_Herança_Gráfico
{
    public partial class frmprofessor : Form
    {
        Prof prof;
        public frmprofessor()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            prof = new Prof(txtnome.Text, (Convert.ToInt32 (txtidade.Text)), txttitulacao.Text);
            txtnome.Clear();
            txtidade.Clear();
            txttitulacao.Clear();
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(prof.ImprimeDados());
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu principal = new Menu();
            principal.Show();
        }
    }
}
