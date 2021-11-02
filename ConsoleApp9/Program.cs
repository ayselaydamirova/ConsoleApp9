using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

           
            {

                #region Task3
                int[] digits = new int[] { 32, 36, 43, 23, 70 };
                Console.WriteLine("Deyer daxil edin");
                int input = Convert.ToInt32(Console.ReadLine());
                AddArray(digits, input);
                #endregion
                #region Task4
                Console.WriteLine("Text daxil edin");
                string text = Console.ReadLine();
                Console.WriteLine(Words(text));
                #endregion

            }

            #region Task3
            static void AddArray(int[] intarr, int input)
            {
                Array.Resize(ref intarr, intarr.Length + 1);
                intarr[intarr.Length - 1] = input;
                foreach (var item in intarr)
                {
                    Console.WriteLine(item);
                }
            }
            #endregion
            #region Task4
            static string[] Words(string str)
            {
                string[] countofwords = str.Trim().Split(' ');
                foreach (var item in countofwords)
                {
                    Console.WriteLine(item);
                }
                return countofwords;
            }
            #endregion


        }
    }
}
    

