using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0400_media_ponderada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cálculo da média aritimética ponderada das notas: N1, N2 e N3 ");

            Console.WriteLine();

            Console.Write("Nome do aluno: ");
            string a = Console.ReadLine();

            Console.Write("Nota da 1ª prova: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Nota da 2ª prova: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.Write("Nota da 3ª prova: ");
            float n3 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float m1 = n1 * 2.0f; float m2 = n2 * 4.0f; float m3 = n3 * 6.0f;
            float mf = (m1 + m2 + m3) / (2 + 4 + 6);

            Console.WriteLine();

            Console.Write("Aluno: ");
            Console.Write(a);
            Console.Write(" | Média final: ");
            Console.Write(mf);


            Console.ReadLine();


        }
    }
}
