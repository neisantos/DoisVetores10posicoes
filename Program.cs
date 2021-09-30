using System;

namespace QUESTÃO_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] vetNotaparcial = new double [2];
            double [] vetNotaOficial = new double [2];
            double [] vetMedia = new double [2];
            
            

            Console.WriteLine("Preencha o vetor de 3 posições com as notas dos alunos:");
            for (int i = 0; i < vetNotaparcial.Length; i++)
            {
                Console.Write($"digite a nota parcial do aluno {i}º   : ");
                vetNotaparcial [i] = int.Parse (Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i = 0; i < vetNotaOficial.Length; i++)
            {
                Console.Write($"digite a nota Oficial do aluno {i}º  : ");
                vetNotaOficial [i] = int.Parse (Console.ReadLine());
            }
            Console.WriteLine("");



            for (int i = 0; i < vetMedia.Length; i++)
            {
               vetMedia [i] =((vetNotaparcial[i] * 2)+(vetNotaOficial[i] * 8)) / 10 ;
            }
            /**********************************/

            for (int i = 0; i < vetNotaparcial.Length; i++)
            {
                Console.Write($"{vetNotaparcial [i]} |");
            }
            Console.WriteLine();
            for (int i = 0; i < vetNotaOficial.Length; i++)
            {
                Console.Write($"{vetNotaOficial [i]} |");                
            }
            Console.WriteLine();
            for (int i = 0; i < vetMedia.Length; i++)
            {
                Console.Write($"{vetMedia[i]} |");
            }






        }
    }
}
