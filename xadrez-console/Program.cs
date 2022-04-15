using tabuleiro;
using xadrez;
Console.WriteLine("Hello World");

try
{
    Tabuleiro tab = new(8, 8);
    tab.ColocarPeca(new Torre(tab, Cor.Branco), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(tab, Cor.Branco), new Posicao(1, 9));
    tab.ColocarPeca(new Rei(tab, Cor.Branco), new Posicao(0, 2));
    Tela.ImprimirTabuleiro(tab);
    Console.WriteLine();
}
catch (TabuleiroException ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine();
//Posicao p;
//p = new Posicao(3, 4);
//Console.WriteLine("Posição:" + p);



