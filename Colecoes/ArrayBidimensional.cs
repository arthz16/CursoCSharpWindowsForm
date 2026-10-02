using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharpWindowsForm.Colecoes
{
    public class ArrayBidimensional
    {
        public static void Executar() {
            double[,] matriz = new double[4, 2] {
                {8, 6},
                {10, 9 },
                {7, 5 },
                {9, 8 }
            };

            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            string[,] matrizString = new string[linhas, colunas];
            string matrizSaida = "";

            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    matrizString[i, j] = matriz[i, j].ToString();

                }
            }

            for (int i = 0; i < matrizString.GetLength(0); i++) {
                for (int j = 0; j < matrizString.GetLength(1); j++) {
                    matrizSaida += "\n" + matrizString[i, j];
                }
            }

            MessageBox.Show("Array Bidimensional é" + matrizSaida,
                    "Resultado do Array",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
