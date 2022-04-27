using tabuleiro;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    while (!partida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab);
        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);
        Console.WriteLine();
        Console.Write("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
        partida.ExecutaMovimento(origem, destino);
    }

}catch (TabuleiroException ex)
{
    Console.WriteLine(ex.Message);
}



//Posicao p;
//p = new Posicao(3, 4);
//Console.WriteLine("Posição:" + p);



