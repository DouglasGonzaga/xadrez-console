using tabuleiro;
using xadrez;
Console.WriteLine("Hello World");


//Posicao p;
//p = new Posicao(3, 4);
//Console.WriteLine("Posição:" + p);
Tabuleiro tab = new (8, 8);

tab.ColocarPeca(new Torre(tab, Cor.Branco), new Posicao(0, 0));
tab.ColocarPeca(new Torre(tab, Cor.Branco), new Posicao(1, 3));
tab.ColocarPeca(new Rei(tab, Cor.Branco), new Posicao(2, 4));
Tela.ImprimirTabuleiro(tab);
Console.WriteLine();
