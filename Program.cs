using System.Security.Cryptography;

namespace RipassoFunzioniInfo
{
    internal class Program
    {
        static int[,] InserimentoVett(int[,] inserimento)
        {            
            for (int i = 0; i < inserimento.GetLength(0); i++)
            {
                for(int j = 0; j < inserimento.GetLength(1); j++)
                {
                    Console.WriteLine("inserisci il numero");
                    inserimento[i,j] = int.Parse(Console.ReadLine());
                }
            }
            return inserimento;
        }
        static int[] SommaRighe(int[] SommaR, int[,]Matricce)
        {
            int s = 0;
            for (int i = 0; i < Matricce.GetLength(0); i++)
            {
                for (int j = 0; j < Matricce.GetLength(1); j++)
                {
                    s += Matricce[i,j];
                }
                SommaR[i] = s;
                s = 0;
            }
            return SommaR;
        }
        static void Main(string[] args)
        {
            int[,] matrice = new int[3,4];
            InserimentoVett(matrice);
            int[] somma = new int [matrice.GetLength(1)];

            foreach (int i in somma)
            {
                Console.WriteLine(" " + i);
            }
        }
    }
}
