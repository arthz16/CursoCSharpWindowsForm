using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharpWindowsForm.Colecoes
{
    public class Listagem
    {
        public static void Executar()
        {
            ArrayList lista = new ArrayList();
            lista.Add("Palavra");
            lista.Add(123);   

            MessageBox.Show($"Conteúdo da Lista: \n {lista[0]}",
                
                "Lista",
                
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            int numero = (int)lista[1];

            MessageBox.Show($"Conteúdo da Lista: \n {numero}",

               "Lista",

               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            MessageBox.Show($"Conteúdo da Lista: \n {lista[0]}\n{lista[1]}",

          "Lista",

          MessageBoxButtons.OK,
          MessageBoxIcon.Information);



        }
    }
}
