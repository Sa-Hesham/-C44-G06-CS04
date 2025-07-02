using System.Threading.Channels;

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



            #region switch C# 8.0

            #region pattern matching with out alias 

            //object obj = 10;

            //switch (obj)
            //{

            //    case int when (int)obj <10 : 
            //        Console.WriteLine($" value is int");
            //        break;
            //    case double :
            //        Console.WriteLine($" value is double");
            //        break;
            //    case float :
            //        Console.WriteLine($" value is float");
            //        break;
            //    case Person :
            //        Console.WriteLine($" value is person ");
            //        break;
            //    default:
            //        Console.WriteLine($" value is not int or double or float or person );
            //        break;
            //}

            #endregion
            #region switch experssion [constant pattern - discard pattern]
            //int number;

            //int.TryParse(Console.ReadLine(), out  number);

            //string result = number switch
            //{

            //    1 => "one", // constant pattern
            //    2 => "two",
            //    3 => "three",
            //    _=> "other" //discard pattern

            //};

            //Console.WriteLine(result);




            #endregion


            #region property pattern
            //Person person = new Person() { id = 2, name = "ahmed", age = 20 };
            //string result = person switch
            //{
            //    { age: < 18 } => "under age",  // property pattern 
            //    { age: >= 18, name: "ahmed" } => "adult ahmed",
            //    { age: >= 18, name: "mohamed" } => "adult mohamed",
            //    _ =>" hello world"
            //};

            //Console.WriteLine(result);
            #endregion


            #region nullable type 

            ////int? number = null;
            //int? number = null;
            //string result = number switch
            //{

            //    null => "null",
            //    int x when x> 0 => "positive", // must use alias Name to make comaprison 
            //    int y when y< 0 =>"negative ",
            //    _=>"it is zero "



            //};
            #endregion


            #region switch C# 9.0


            //int? number = null;
            int? number = null;
            string result = number switch
            {

                null => "null",
                > 0 => "positive", // must use alias Name to make comaprison 
                 < 0 => "negative ",
                _ => "it is zero "

            };
            Console.WriteLine(result);
            #endregion




            #endregion












        }
    }
}
