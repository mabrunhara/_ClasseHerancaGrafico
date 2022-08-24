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
    public partial class frmaluno : Form
    {
        Estudante aluno;
        public frmaluno()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            aluno=new Estudante (txtnome.Text, (Convert.ToInt32(txtidade.Text)), txtcurso.Text);
            txtnome.Clear();
            txtidade.Clear();
            txtcurso.Clear();
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aluno.ImprimeDados());
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu principal = new Menu();
            principal.Show();
        }
    }
}
