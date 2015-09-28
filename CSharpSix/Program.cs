using System;
using static System.Console;


namespace CSharpSix
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadLine();
        }
    }
}


//Example 1
//using static System.Console;
//using static CSharpSix.YetAnotherClass;

//namespace CSharpSix
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WriteLine("Hello World!");
//            HelloBack();
//            ReadLine();
//        }
//    }

//    static class YetAnotherClass
//    {
//        public static void HelloBack()
//        {
//            WriteLine("Hello Computer!");
//        }
//    }
//}


//Example 2
//using System;
//using static System.Console;

//namespace CSharpSix
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Customer cust = new Customer();
//            WriteLine(cust.customerID);
//            ReadLine();
//        }
//    }

//    public class Customer
//    {
//        public Guid customerID { get; set; } = Guid.NewGuid();
//    }

//}

//Example 3
//using System.Collections.Generic;
//using static System.Console;

//namespace CSharpSix
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var stars = new Dictionary<string, string>()
//            {
//                ["Michael Jordon"] = "Basketball",
//                ["Peyton Manning"] = "Football",
//                ["Babe Ruth"] = "Baseball"
//            };

//            foreach (KeyValuePair<string, string> keyValuePair in stars)
//            {
//                WriteLine(keyValuePair.Key + ": " +
//                keyValuePair.Value + "\n");
//            }

//            ReadLine();
//        }
//    }
//}

//Example 4
//using static System.Console;


//namespace CSharpSix
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string firstName = "Michael";
//            string lastName = "Crump";

//            WriteLine($"{firstName} {lastName} is my name!");

//            ReadLine();
//        }
//    }
//}

//Example 5
//using System;
//using static System.Console;


//namespace CSharpSix
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            DoSomething("Hi");
//            ReadLine();
//        }

//        public static void DoSomething(string city)
//        {
//            if (city == null) throw new Exception(nameof(city) + " is null");
//        }
//    }
//}

//using System;
//using static System.Console;


//Example 6
//namespace CSharpSix
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var httpStatusCode = 404;
//            Write("Exception type: ");

//            try
//            {
//                throw new Exception(httpStatusCode.ToString());
//            }
//            catch (Exception ex) when (ex.Message.Equals("400"))
//            {
//                Write("Bad Request");
//                ReadLine();
//            }
//            catch (Exception ex) when (ex.Message.Equals("401"))
//            {
//                Write("Unauthorized");
//                ReadLine();
//            }
//            catch (Exception ex) when (ex.Message.Equals("402"))
//            {
//                Write("Payment Required");
//                ReadLine();
//            }
//            catch (Exception ex) when (ex.Message.Equals("403"))
//            {
//                Write("Forbidden");
//                ReadLine();
//            }
//            catch (Exception ex) when (ex.Message.Equals("404"))
//            {
//                Write("Not Found");
//                ReadLine();
//            }

//            ReadLine();
//        }
//    }
//}

//Example 7
//using System;
//using System.Net.Http;
//using System.Threading.Tasks;
//using static System.Console;


//namespace CSharpSix
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Task.Factory.StartNew(() => GetPage());
//            ReadLine();
//        }

//        private async static Task GetPage()
//        {
//            HttpClient client = new HttpClient();
//            try
//            {
//                var result = await client.GetStringAsync("http://www.telerik.com");
//                WriteLine(result);
//            }
//            catch (Exception exception)
//            {
//                try
//                {
//                    throw new Exception("Error");
//                }
//                catch
//                {
//                WriteLine("Entered Catch Block");
//                }
//                finally
//                {
//                WriteLine("Entered Finally Block");
//                }
//            }
//        }
//    }
//}

//Example 8
//using static System.Console;


//namespace CSharpSix
//{
//    class Program
//    {
//        private static double MultiplyNumbers(double num1, double num2) => num1 * num2;
//        static void Main(string[] args)
//        {
//            double num1 = 5;
//            double num2 = 10;

//            WriteLine(MultiplyNumbers(num1, num2));
//            ReadLine();
//        }
//    }
//}

//Example 9
//using System;
//using static System.Console;


//namespace CSharpSix
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person person = new Person();
//            if (person.Name == String.Empty)
//            {
//                person = null;
//            }

//            WriteLine(person?.Name ?? "Field is null.");

//            ReadLine();
//        }
//    }

//    public class Person
//    {
//        public string Name { get; set; } = "";
//    }
//}