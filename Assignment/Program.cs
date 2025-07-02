using System.ComponentModel;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1 - Write a program that takes a number from the user then print yes if that
            //number can be divided by 3 and 4 otherwise print no.
            bool Isparse;

            int num;

            do
            {
                Console.WriteLine("please enter the number ");
                Isparse=int.TryParse(Console.ReadLine(), out num);


            } while (!Isparse);

            if (num % 4 ==0 && num % 3 == 0)
            {
                Console.WriteLine("yes");
            }else
            {
                Console.WriteLine("no");
            }

            #endregion
        }
    }
}
