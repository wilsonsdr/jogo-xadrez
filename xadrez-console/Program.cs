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


PosicaoXadrez pos = new PosicaoXadrez('a', 1);

Console.WriteLine(pos);

Console.WriteLine(pos.ConverterPosicao());


