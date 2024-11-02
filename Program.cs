using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapok3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tömbök, for, foreach, doWhile, while ciklusok
            /*int[] tomb1 = { 12, 23, 31, 4,};
            int[] tomb2= new int[3];
            Console.WriteLine(tomb1[0]);
            //tomb2[0] = 3;
            //tomb2[1] = 2;
            //tomb2[2] = 1;
            //ilyen elem nincs: tomb2[3] = 1;
            tomb2[2] = 5;
            //tömb feltöltése ciklussal felhasználóval
            for (int i = 0; i < tomb2.Length; i++) { 
                Console.WriteLine("Kérem a {0}. tömb elemet", i );
                tomb2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.WriteLine($"{tomb2[i]}");
            }
            Console.WriteLine();
            foreach (int elem in tomb2) { 
                Console.WriteLine(elem+"  ");
            }
            Console.WriteLine("Kérem a keresendő elemt") ;
            int search = int.Parse(Console.ReadLine());
            int j = 0;
            do
            {
                j++;
            } while (j < tomb2.Length && tomb2[j] != search);
            if (j< tomb2.Length)
            {
                Console.WriteLine($"A keresett {search} szám a tömbben a {j} heylen van.") ;
            }
            else { Console.WriteLine("Nincs meg a keresett elem"); }
            Console.WriteLine("Kérek egy számot");
            int number = int.Parse(Console.ReadLine());
            while (number % 2 == 0 && number > 2) {
                number /= 2;
                Console.WriteLine("A szám fele " + number);
            }

            char[] betuTomb = new char[] { 'A', 'B', 'R', 'O' };
            Array.Sort(betuTomb);
            foreach (char karakter in betuTomb)
            {
                Console.Write(karakter + " ");
            } //for ciklussal is ki lehet iratni.

            */
            Console.WriteLine();
            int[,] matrix = new int[,] {
            { 2, 3, 4 , 5 },
            { 1, 2, 0, 2 }
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int s = 0; s < matrix.GetLength(1); s++)
                { Console.Write(matrix[i, s] + " "); }
                Console.WriteLine();
            }

            int[][] jaggedmatrix = new int[3][];



            #endregion
        }
    }
}
