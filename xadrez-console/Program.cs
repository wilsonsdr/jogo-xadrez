﻿global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
using tabuleiro;
using xadrez_console;
using xadrez;

Tabuleiro tab = new Tabuleiro(8, 8);

tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 1));

tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

Tela.ImprimirTabuleiro(tab);

Console.WriteLine();
