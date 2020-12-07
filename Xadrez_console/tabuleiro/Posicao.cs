﻿namespace tabuleiro
{
    class Posicao
    {
        public int linha { get; set; }
        public int Coluna { get; set; }

        public Posicao()
        {
        }
        public Posicao(int linha,int coluna)
        {
            this.linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return linha + "," + Coluna;
        }
    }
}
