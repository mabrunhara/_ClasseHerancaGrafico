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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprofessor professor = new frmprofessor();
            professor.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarUsuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmaluno menu = new frmaluno ();
            menu.Show();
        }
    }
}
