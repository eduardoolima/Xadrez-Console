using System;
using tabuleiro;

namespace Xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for(int i=0;i<tab.linhas;i++)
            {
                for(int j=0;j<tab.colunas;j++)
                {
                    if(tab.Peca(i,j)==null)
                    {
                        Console.Write("- ");
                    }
                    Console.Write(tab.Peca(i,j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
