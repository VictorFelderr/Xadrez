using System;
using System.Security.Cryptography.X509Certificates;
using Tabuleiro;
using Xadrez.Tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
         {
            return "R";
         }
       
    }
}



