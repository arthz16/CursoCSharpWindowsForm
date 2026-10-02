using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharpWindowsForm.Colecoes
{
    public class ClasseArray
    {
        public static void Executar() {
            string nomes = "";
            string[] alunos = new string[5];
            alunos[0] = "Ana";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniel";
            alunos[4] = "Rafael";
            for (int i = 0; i < alunos.Length; i++) {
                nomes += "\n" + alunos[i];
            }
            MessageBox.Show("O Valor do Array é" + nomes,
                    "Resultado do Array",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            foreach (string aluno in alunos) {
                MessageBox.Show("O Valor do Array é" + aluno,
                    "Resultado do Array",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
