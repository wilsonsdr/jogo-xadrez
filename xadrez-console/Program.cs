global using global::System;
using tabuleiro;
using xadrez;
using xadrez_console;

try
{
    PartidaXadrez partida = new PartidaXadrez();

    while (!partida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab);

        Console.WriteLine();

        Console.Write("\nOrigem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ConverterPosicao();

        bool[,] posicoesPossives = partida.Tab.Peca(origem).MovimentosPossiveis();

        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossives);

        Console.WriteLine();

        Console.Write("\nDestino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ConverterPosicao();

        partida.ExecutaMovimento(origem, destino);
    }

    Tela.ImprimirTabuleiro(partida.Tab);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}