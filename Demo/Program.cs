namespace Demo
{
    class Person
    {
    public int id { get; set; }
    public string? name { get; set; }
    public int age { get; set; }


    }
internal class Program
    {
        static void Main(string[] args)
        {

            #region switch C#7.0

            // C# 7.0 introduced a new switch expression that allows for more concise and expressive code.

            #region pattern matching

            //pattern matching  



            //object obj = 10; //boxing
            //obj = 3.2d;
            //switch (obj)

            //{
            //    case int value:  //==> alias name (vale ) ==>un boxing
            //        Console.WriteLine($" value is int");
            //        break;

            //    case double value:
            //        Console.WriteLine($" value is double");
            //        break;

            //    case float value:
            //        Console.WriteLine($" value is float");
            //        break;

            //    default:
            //        Console.WriteLine($" value is not int or double or float");
            //        break;
            //}


            #endregion



            #region Case guard [when]

            //using when[keyword] to ability to add conadion to case statement
            //also can use  logigal operators like &&, ||, !  with when condition

            //object obj = 10; //boxing
            //obj = 3.2d;
            //switch (obj)

            //{
            //    case int value when value>10:  //==> alias name (vale ) ==>un boxing
            //        Console.WriteLine($" value is int");
            //        break;

            //    case double value when value <3.2:
            //        Console.WriteLine($" value is double");
            //        break;

            //    case float value:
            //        Console.WriteLine($" value is float");
            //        break;

            //    default:
            //        Console.WriteLine($" value is not int or double or float");
            //        break;
            //}


            #endregion



            #region use switch case with user defined data taypes 

            //object ob =new person() { id=1,name = "ahmed", age =20  };

            //switch (ob)
            //{
            //    case int value:
            //        Console.WriteLine($" value is int");
            //        break;
            //    case double value:
            //        Console.WriteLine($" value is double");
            //        break;
            //    case person value when value.id>=2:
            //        Console.WriteLine("value is person ");
            //        break;
            //    default:
            //        Console.WriteLine("value is not int or double or float");
            //        break;


            //}


            #endregion

            #endregion












        }
    }
}
