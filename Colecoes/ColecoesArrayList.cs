using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace CursoCSharpWindowsForm.Colecoes
{
    public class ColecoesArrayList
    {
        public static void Executar() {
            var arrayList = new ArrayList {
                "Palavra",
                3,
                true
            };
            arrayList.Add(3.14f);
            string conteudo = string.Join("\n", 
                arrayList.ToArray());
            MessageBox.Show($"Conteúdo do ArrayList:" +
                $"\n { conteudo}", 
                "ArrayList", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ArrayList lista = new ArrayList { "Maça", "Banana",
            "Laranja", "Goiaba"};
            StringBuilder sb = new StringBuilder();
            foreach(var item in lista) {
                sb.AppendLine(item.ToString());
            }
            MessageBox.Show($"Conteúdo da Lista:\n {sb}",
                "Lista", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
