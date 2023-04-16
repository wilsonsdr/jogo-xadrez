global using global::System;
using tabuleiro;
using xadrez;
using xadrez_console;

try
{
    PartidaXadrez partida = new PartidaXadrez();

    while (!partida.Terminada)
    {
        try
        {
            Console.Clear();

            Tela.ImprimirPartida(partida);

            Console.Write("\nOrigem: ");
            Posicao origem = Tela.LerPosicaoXadrez().ConverterPosicao();
            partida.ValidarPosicaoOrigem(origem);

            bool[,] posicoesPossives = partida.Tab.Peca(origem).MovimentosPossiveis();

            Console.Clear();
            Tela.ImprimirTabuleiro(partida.Tab, posicoesPossives);

            Console.WriteLine();

            Console.Write("\nDestino: ");
            Posicao destino = Tela.LerPosicaoXadrez().ConverterPosicao();
            partida.ValidarPosicaoDestino(origem, destino);

            partida.RealizarJogada(origem, destino);
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    }
    Console.Clear();
    Tela.ImprimirPartida(partida);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}