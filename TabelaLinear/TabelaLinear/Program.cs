using System.Diagnostics;
using System;



namespace TabelaLinear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 90, 70, 50, 80, 60, 86 };

            //Anexar tabela linnear
            var op = new Operacoes();
            array = op.Add(array, 75);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }

            Console.WriteLine();

            //Inserção de item em tabela linear
            int[] array2 = { 90, 70, 50, 80, 60, 86 };
            array2 = op.Insert(array2, 75, 2);

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + ",");
            }

            Console.WriteLine();

            int[] array3 = { 90, 70, 50, 80, 60, 86 };

            array3 = op.Remover(array3, 2);

            for(int i = 0;i < array3.Length; i++)
            {
                Console.Write(array3[i] + ",");
            }






        }
        
        
    }
}


