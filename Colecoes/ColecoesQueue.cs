
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharpWindowsForm.Colecoes
{
    public class ColecoesQueue
    {
        public static void Executar()
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Primeiro");
            fila.Enqueue("Segundo");
            fila.Enqueue("Terceiro");

            MessageBox.Show($"Quantidade de elementos na fila: {fila.Count}",
                "Fila",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            string primeiroElemento = fila.Dequeue();
            MessageBox.Show($"Elemento removido da fila: {primeiroElemento}",
                "Fila",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            MessageBox.Show($"Quantidade de elementos na fila após remoção: {fila.Count}",
                "Fila",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}