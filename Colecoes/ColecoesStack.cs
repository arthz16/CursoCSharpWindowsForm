using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace CursoCSharpWindowsForm.Colecoes
{
    public class ColecoesStack
    {
        public static void Executar()
        {
            StringBuilder mensagemFinal = new StringBuilder();
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("A");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                mensagemFinal.AppendLine($"Item: {item.ToString()}");
            }

            MessageBox.Show(mensagemFinal.ToString(),
                "Coleções Stack",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            MessageBox.Show($"\n Pop: {pilha.Pop()}",
                "Coleções Stack",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            mensagemFinal = new StringBuilder();

            foreach (var item in pilha)
            {
                mensagemFinal.AppendLine($"Item: {item.ToString()}");
            }

            MessageBox.Show(mensagemFinal.ToString(),
                "Coleções Stack",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}
