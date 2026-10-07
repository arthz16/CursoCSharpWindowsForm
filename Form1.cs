using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharpWindowsForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arrayToolStripMenuItem_Click(object sender, EventArgs e) {
            CursoCSharpWindowsForm.Colecoes.ClasseArray.Executar();
        }

        private void arrayBidimensionalToolStripMenuItem_Click(object sender, EventArgs e) {
            CursoCSharpWindowsForm.Colecoes.ArrayBidimensional.Executar();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e) {
            CursoCSharpWindowsForm.Colecoes.ColecoesList.Executar();
        }

        private void coleçõesArrayToolStripMenuItem_Click(object sender, EventArgs e) {
            CursoCSharpWindowsForm.Colecoes.ColecoesArrayList.Executar();
        }

        private void classesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursoCSharpWindowsForm.Colecoes.ClassesList.Executar();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursoCSharpWindowsForm.Colecoes.Listagem.Executar();
        }
    }
}
