

using System;
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

            //Console.WriteLine("enter number 1 ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.WriteLine("enter number 2 ");
            //int.TryParse(Console.ReadLine(), out int num2);
            //Console.WriteLine("enter number 3 ");
            //int.TryParse(Console.ReadLine(), out int num3);

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
            //int Maxnum = num1;
            // int Minnum = num1;

            // if (num2 > Maxnum)
            //     Maxnum = num2;
            // if (num3 > Maxnum)
            //     Maxnum = num3;



            // if (num2 < Minnum)
            //     Minnum = num2;
            // if (num3 < Minnum)
            //     Minnum = num3;

            // Console.WriteLine($"max number is {Maxnum} ,,  min number is :: {Minnum}");





            #endregion


            #region Q4

            //4 - Write a program that allows the user to insert an integer number then
            //check If a number is even or odd.

            //Console.WriteLine("enter number 1 ");
            //int.TryParse(Console.ReadLine(), out int num1);

            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}else
            //{
            //    Console.WriteLine("ODD");
            //}


            #endregion



            #region Q5

            //5 - Write a program that takes character from the user then if it is a vowel
            //chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).

            //Console.WriteLine("enter character ");
            // char.TryParse(Console.ReadLine(),out char a);

            //switch (a)
            //{
            //    case 'a':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //    case 'e':
            //    case 'A':
            //    case 'I':
            //    case 'O':
            //    case 'U':
            //    case 'E':
            //        Console.WriteLine("Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("constant");
            //        break;





            //};


            #endregion



            #region Q6

            //6 - Write a program that allows the user to insert an integer then print all
            //numbers between 1 to that number.

            //Console.WriteLine("enter number ");
            //int.TryParse(Console.ReadLine(), out int num);

            //Console.WriteLine($"the number between 1 to {num} is ::");

            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write($" {i}, ");
            //}

            #endregion



            #region Q7

            //Console.WriteLine("enter number ");
            //int.TryParse(Console.ReadLine(), out int x);

            //Console.Clear();
            //for (int i = 1; i <= 12; i++)
            //{

            //    Console.WriteLine($"{x} * {i} = {5*i}");

            //}


            #endregion


            #region Q8

            //8 - Write a program that allows to user to insert number then print all even
            //    numbers between 1 to this number

            //Console.WriteLine("please enter number ");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.WriteLine($"Even number  are :: ");
            //for (int i=1; i<=number;i++)
            //{


            //    if (i % 2 == 0)
            //        Console.WriteLine($"{i},");



            //}


            #endregion


            #region Q9
            //Write a program that takes two integers then prints the power.

            //Console.WriteLine("enter the based number ");
            //  int.TryParse(Console.ReadLine(), out int based);

            //Console.WriteLine("enter the exponent number ");
            //int.TryParse(Console.ReadLine(), out int exponent);

            //int Multiply = 1;


            //for (int i = 1; i <= exponent; i++)
            //{
            //    Multiply *= based;

            //}  



            //Console.WriteLine($"{based} ^ {exponent} = {Multiply}");

            #endregion



            #region Q10

            //  int total = 0;
            //int  average = default;
            //int percent = default;

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"inter dgree subj {i}");
            //    int dgree;
            //    int.TryParse (Console.ReadLine(),out dgree);
            //    total += dgree;


            //}


            //average = total / 5;
            //percent = (408 * 100) / 500;

            //Console.WriteLine($" Total marks = {total}");
            //Console.WriteLine($" Average marks  = {average}");
            //Console.WriteLine($" Percentage = {percent}");






            #endregion


















        }

    }
}
