﻿namespace tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }

        public Cor Cor { get; protected set; }

        public int QteMovimentos { get; protected set; }

        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.Tab = tab;
            this.QteMovimentos = 0;
        }

        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}