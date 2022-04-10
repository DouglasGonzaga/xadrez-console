using tabuleiro;

namespace tabuleiro
{
    public class Tela
    {
        
        public static void ImprimirTabuleiro(Tabuleiro Tab)
        {
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Linhas; j++)
                {
                    if(Tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(Tab.peca(i, j) + " ");
                    } 
                }
                Console.WriteLine();
            }
        }
    }
}
