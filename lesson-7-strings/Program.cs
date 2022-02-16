using System;
using System.Text;
namespace lesson_7_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string placeholder = "Hello {0} and {1}";
            string name = "Nikita";
            string hisName = "Alex";
            Console.WriteLine("Hello " + name);                                    //Hello Nikita
            Console.WriteLine(string.Format ("Hello {0}", name));                  //Hello Nikita
            Console.WriteLine(string.Format ("Hello {0} and {1}", name, hisName)); //Hello Nikita and Alex
            Console.WriteLine($"Hello {name} and {hisName}");                      //Hello Nikita and Alex
            Console.WriteLine(string.Format(placeholder, name, hisName));          //Hello Nikita and Alex

            var hello = $"Hello, {name} and {hisName}";
            char symbol = hello[0];

            Console.WriteLine(symbol);                  //H
            Console.WriteLine(char.IsLetter(symbol));   //true
            Console.WriteLine(char.IsDigit(symbol));    //false
            Console.WriteLine(char.IsUpper(symbol));    //true

            Console.WriteLine(hello.Contains('q'));     //false
            Console.WriteLine(hello.Contains("Ni"));    //true

            var helloPlaceholder = " Hello ";
            var index = helloPlaceholder.IndexOf(' '); //5

            Console.WriteLine(helloPlaceholder.Insert(index + 1, name));    //true
            Console.WriteLine($"Hello {name}".Replace(name, hisName));

            Console.WriteLine(hello.PadLeft(40).Trim());   //пробелчики 
            Console.WriteLine(hello.ToLower());            //верхний регистр
            Console.WriteLine(hello.ToUpper());            //нижний регистр

            Console.WriteLine(string.Compare("abc", "bdc")); //сравнения 
            Console.WriteLine(string.Equals("abc", "bdc"));
            Console.WriteLine("abc" != "bdc");

            Console.WriteLine("Hello " + name);

            var emptyString = string.Empty;             //для очень малых значений
            const int N = 1000;
            for (int i = 0; i < N; i++)
            {
                emptyString += $" {i}";                 //в ряд до 1000
            }

            var stringBuilder = new StringBuilder();    //для очень больших строк
            for (int i = 0; i < N; i++)
            {
                stringBuilder.AppendFormat(" {0}", i);
            }

            Console.WriteLine(emptyString);
            Console.WriteLine(stringBuilder.ToString());
            Console.WriteLine("--------------------------");

            string UpLow = Console.ReadLine();
            string LowUp = string.Empty;

            for (int i = 0; i < UpLow.Length; i++)
            {  
                if(char.IsUpper(UpLow[i]))
                { 
                    LowUp += char.ToLower(UpLow[i]);
                } else 
                {
                    LowUp += char.ToUpper(UpLow[i]);
                }

            }
            Console.WriteLine(LowUp);
        }
    }
}
