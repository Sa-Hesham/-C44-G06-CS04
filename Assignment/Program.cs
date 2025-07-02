using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Transactions;
using System.Xml.Linq;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1 - Write a program that takes a number from the user then print yes if that
            //number can be divided by 3 and 4 otherwise print no.
            //bool Isparse;

            //int num;

            //do
            //{
            //    Console.WriteLine("please enter the number ");
            //    Isparse=int.TryParse(Console.ReadLine(), out num);


            //} while (!Isparse);

            //if (num % 4 ==0 && num % 3 == 0)
            //{
            //    Console.WriteLine("yes");
            //}else
            //{
            //    Console.WriteLine("no");
            //}

            #endregion



            #region Q2

            ////    Write a program that allows the user to insert an integer then print
            ////negative if it is negative number otherwise print positive.
            //Console.WriteLine("Enter the number ");
            //int.TryParse(Console.ReadLine(), out int x);
            //string message = x switch
            //{

            //    > 0 => "positive",
            //    < 0 => "negative",
            //    _ => " it not positive or negative  it is Zero "



            //};

            //Console.WriteLine(message);

            #endregion


            #region Q3

            //3 - Write a program that takes 3 integers from the user then prints the max
            //element and the min element.

            Console.WriteLine("enter number 1 ");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("enter number 2 ");
            int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("enter number 3 ");
            int.TryParse(Console.ReadLine(), out int num3);

            //// ======== first way ===========
            //int max = 0;
            //int min = 0;
            //if (num1 > num2 && num1 >num3)
            //{
            //    max = num1;
            //    if (num2 >num3)
            //    {
            //        min = num3;
            //    }else
            //    {
            //        min = num2;
            //    }

            //}else if (num2 >num1 && num2 > num3)
            //{
            //    max = num2;
            //    if (num1 > num3)
            //    {
            //        min = num3;
            //    }
            //    else
            //    {
            //        min = num1;
            //    }

            //}else
            //{
            //    max = num3;
            //    if (num1 > num2)
            //        min = num2;
            //    else
            //        min = num1;
            //}

            //Console.WriteLine($"max number is {max} ,,  min number is :: {min}");




            //=============Another Way===================== 
           int Maxnum = num1;
            int Minnum = num1;

            if (num2 > Maxnum)
                Maxnum = num2;
            if (num3 > Maxnum)
                Maxnum = num3;



            if (num2 < Maxnum)
                Minnum = num2;
            if (num3 < Maxnum)
                Minnum = num3;

            Console.WriteLine($"max number is {Maxnum} ,,  min number is :: {Minnum}");





            #endregion

















        }

    }
}
