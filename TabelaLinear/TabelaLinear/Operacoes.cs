using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TabelaLinear
{
    public class Operacoes
    {
        public Operacoes() { }
        public int[] Add(int[] Array, int valor)
        {
            int[] Temporario = new int[Array.Length + 1];
            for (int i = 0; i < Array.Length; i++)
            {
                Temporario[i] = Array[i];

            }
            Temporario[Array.Length] = valor;
            return Temporario;
        }


        public int[] Insert(int[] Array, int valor, int point)
        {
            int[] temp = new int[Array.Length];
            if (Array.Length > point)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    temp[i] = Array[i];
                }

                temp[point] = valor;

            }


            else
            {
                Console.WriteLine("O valor informado execede o tamanho do Array");

            }

            return temp;
        }


        public int[] Remover(int[] Array, int point)
        {

            int[] temp = new int[Array.Length - 1];
            for (int i = 0; i < Array.Length; i++)
            {
                if (i < point)


                    temp[i] = Array[i];


                if (i > point)
                    temp[i - 1] = Array[i];
                }
            return temp;
        }

    }
}



