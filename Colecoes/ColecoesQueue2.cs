using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharpWindowsForm.Colecoes
{
    public class ColecoesQueue2
    {
        public static void Executar()
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Ronsevaldo");
            fila.Enqueue("Arthur");
            fila.Enqueue("José");
            fila.Enqueue("João");
            fila.Enqueue("Ana");
            fila.Enqueue("Matheus Khalifa");

            MessageBox.Show($"Pessoas na fila: {fila.Count}",
                "Fila de Pessoas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            while (fila.Count > 0) 
            {
                MessageBox.Show($"Pessoa atendida: {fila.Peek()}",
                    "Fila",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                MessageBox.Show($"{fila.Dequeue()} foi atendido",
                    "Fila",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


            MessageBox.Show($"Pessoas na fila: {fila.Count}",
                "Fila de Pessoas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
