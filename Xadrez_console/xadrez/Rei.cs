using System;
using tabuleiro;
using System.Collections.Generic;
using System.Text;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab,cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
