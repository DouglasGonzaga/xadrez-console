
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
        public bool existeMovimentosPossiveis()
        {
            bool[,] Mat = MovimentosPossiveis();
            for(int i = 0; i<Tabuleiro.Linhas; i++)
            {
                for(int j = 0; j<Tabuleiro.Colunas; j++)
                {
                    if (Mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool podeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha,pos.Coluna];
        }
        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }
        public void DecrementarQteMovimentos()
        {
            QteMovimentos--;
        }
    }
}
