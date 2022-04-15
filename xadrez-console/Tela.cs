using tabuleiro;

namespace tabuleiro
{
    public class Tela
    {
        
        public static void ImprimirTabuleiro(Tabuleiro Tab)
        {
            for (int i = 0; i < Tab.Linhas; i++)
            {
                Console.Write(8-i+" ");
                for (int j = 0; j < Tab.Linhas; j++)
                {
                    if(Tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(Tab.peca(i, j));
                        Console.Write(" ");
                    } 
                }
                Console.WriteLine();
            }

            Console.WriteLine("  A B C D E F G H");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if(peca.Cor == Cor.Branco)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
