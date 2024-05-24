using System;
using System.Collections;
using System.Collections.Generic;

namespace FilaLimitada
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaLimitada<int> colecao = new FilaLimitada<int>(new List<int> { 1, 2, 3, 4, 5 });

            foreach (int item in colecao)
            {
                Console.WriteLine(item);
            }
        }
    }
}
