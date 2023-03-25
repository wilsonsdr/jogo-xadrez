global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
using tabuleiro;
using xadrez_console;

Tabuleiro tab = new Tabuleiro(8, 8);

Tela.ImprimirTabuleiro(tab);

Console.WriteLine();
