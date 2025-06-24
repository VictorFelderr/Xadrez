using System;
using System.Security.Cryptography.X509Certificates;
using Tabuleiro;
using Xadrez.Tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }

    }
}