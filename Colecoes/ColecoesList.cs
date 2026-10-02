using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CursoCSharpWindowsForm.Colecoes
{
    public class ColecoesList
    {
        public static void Executar() {
            List<string> estados = new List<string>();
            estados.Add("SP");
            estados.Add("MG");
            estados.Add("BA");
            estados.Add("RJ");

            MessageBox.Show($"Quantidade adicionados " +
                $"{estados.Count} Estados",
                "Listagem de Estados",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            string estadosString = string.Join("\n", estados);

            MessageBox.Show($"Estados Adicionados:" +
                $"\n{estadosString}",
                "Listagem de Estados",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
