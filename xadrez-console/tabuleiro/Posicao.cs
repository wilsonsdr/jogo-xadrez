namespace tabuleiro
{
    internal class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.Coluna = linha;
            this.Linha = coluna;
        }

        public override string ToString()
        {
            return $"Posição: {Coluna}, {Linha}";
        }
    }
}
