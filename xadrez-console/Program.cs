using tabuleiro;
using xadrez;

try
{
    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.ColocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
    tab.ColocarPeca(new Rei(tab, Cor.Preto), new Posicao(0, 2));

    tab.ColocarPeca(new Torre(tab, Cor.Branco), new Posicao(7, 0));
    tab.ColocarPeca(new Torre(tab, Cor.Branco), new Posicao(6, 3));
    tab.ColocarPeca(new Rei(tab, Cor.Branco), new Posicao(5, 2));

    Tela.ImprimirTabuleiro(tab);

}catch (TabuleiroException ex)
{
    Console.WriteLine(ex.Message);
}



//Posicao p;
//p = new Posicao(3, 4);
//Console.WriteLine("Posição:" + p);



