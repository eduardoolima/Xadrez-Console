﻿using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            //Console.WriteLine(pos);
            //Console.WriteLine(pos.toPosicao()); 
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(2, 4));
                tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(2, 6));
                tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(3, 5));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            //Posicao P = new Posicao(3, 4);

            //Console.WriteLine("Posição: " + P);

            Console.ReadLine();
        }
    }
}
