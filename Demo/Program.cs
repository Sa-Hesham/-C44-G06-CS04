using System.Diagnostics.Metrics;
using System.Threading.Channels;
using System.Xml.Linq;

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


            ////int? number = null;
            //int? number = null;
            //string result = number switch
            //{

            //    null => "null",
            //    > 0 => "positive", // must use alias Name to make comaprison 
            //     < 0 => "negative ",
            //    _ => "it is zero "

            //};
            //Console.WriteLine(result);


            #endregion



            #region looping [forloop - foreach ]

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);   

            //}

            //for(int i = 100; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach
            //working on collecation if same data type 
            //take a copy from the collectaion data =values
            // can modify with foreach 

            //int[] num = { 1, 2, 3, 4, 5, 6 };

            //foreach(int number in num)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion


            #region while - dowhile


            //#region [while -do while]
            //int number;
            //bool Isparsed;

            //do
            //{
            //    Console.WriteLine("enter number ");
            //    Isparsed=int.TryParse(Console.ReadLine(), out number);  

            //}while (!Isparsed );


            //While loop

            //Console.WriteLine("enter number ");
            // Isparsed=int.TryParse(Console.ReadLine(), out number);

            //if (Isparsed)
            //{
            //    while (number <= 10)
            //    {
            //        Console.WriteLine(number);
            //        number++;
            //    }

            //}




            #endregion


            #region string 
            //// String is a Reference Type, but actually as Value Type
            // String is a Immutable Type, Can’t change its Value
            string name1 = "ahmed";
            string name2 = "ali";  // string name2=new string("ali")  //synatx sugar 

            Console.WriteLine(name1.GetHashCode());
            Console.WriteLine(name2.GetHashCode());

            Console.WriteLine(name1.Equals(name2));
            Console.WriteLine(ReferenceEquals(name1, name2));
            Console.WriteLine("---------------------------------------------------");

            name2 = name1;
            Console.WriteLine(name1.GetHashCode());
            Console.WriteLine(name2.GetHashCode());

            Console.WriteLine(name1.Equals(name2));
            Console.WriteLine(ReferenceEquals(name1, name2));
            Console.WriteLine("[--------------------------------------------]");


            string Message = "Hello" ;
            Console.WriteLine(Message.GetHashCode());// -1667162590
            Message +=  "Ahmed";
            Console.WriteLine("After Change");
            Console.WriteLine(Message.GetHashCode());//
            //clr create new obj in heap have a  new value  
            // and ferferance has the new value 

            #endregion





            #endregion















        }
    }
}
