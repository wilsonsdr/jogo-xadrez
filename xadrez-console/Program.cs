global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
using System.Globalization;
using tabuleiro;
using xadrez_console;
using xadrez;


try
{
    PartidaXadrez partida = new PartidaXadrez();

    while(!partida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab);

        Console.WriteLine();

        Console.Write("\nOrigem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ConverterPosicao();
        Console.Write("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ConverterPosicao();

        partida.ExecutaMovimento(origem, destino);
    }

    Tela.ImprimirTabuleiro(partida.Tab);
}

catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}


