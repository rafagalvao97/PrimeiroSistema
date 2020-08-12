using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for.@while.@do
{
    class Program
    {
        static void Main(string[] args)
        {
            #region inicio do codigo

            Console.WriteLine("Média de alunos:");

            float soma = 0;
            float media = 0;
            #endregion

            #region LAÇO DE REPETIÇÃO

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite a nota do aluno" + i + ":");
                float nota = 0;
                float.TryParse(Console.ReadLine(), out nota);
                soma += nota;

            }

            #endregion

            #region Fim do codigo

            media = soma/5;
            Console.WriteLine("Média é igual a:" + media);
            Console.ReadKey();

            /* int i = 1;
            while (i < 40)
            {
                Console.WriteLine(i);
                i++;
                
                
            } */
            #endregion

        }
    }
}
