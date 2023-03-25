﻿namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            _pecas = new Peca[linhas, colunas];
        }

        public Peca Peca(int linhas, int colunas)
        {
            return _pecas[linhas, colunas];
        }
    }
}
    

