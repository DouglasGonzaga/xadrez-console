
namespace tabuleiro
{
    public abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; set; }

        public Peca(Tabuleiro tabuleiro,Cor cor)
        {
            Posicao = null;
            Cor = cor;
            QteMovimentos = 0;
            Tabuleiro = tabuleiro;
        }
        public abstract bool[,] MovimentosPossiveis();
        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }
    }
}
