using tabuleiro;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    while (!partida.Terminada)
    {
        try
        {
            Console.Clear();
            Tela.ImprimirTabuleiro(partida.Tab);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.Turno);
            Console.WriteLine("Aguardando Jogada do " + partida.JogadorAtual);
            Console.Write("Origem: ");
            Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeOrigem(origem);
            bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
            Console.Clear();
            Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);
            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
            partida.validarPosicaoDeDestino(origem, destino);
            partida.RealizaJogada(origem, destino);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
        
    }

}catch (TabuleiroException ex)
{
    Console.WriteLine(ex.Message);
}



//Posicao p;
//p = new Posicao(3, 4);
//Console.WriteLine("Posição:" + p);



