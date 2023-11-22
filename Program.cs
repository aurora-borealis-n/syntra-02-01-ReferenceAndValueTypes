using static System.Net.Mime.MediaTypeNames;

namespace ReferenceAndValueTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputValue = string.Empty;
            Console.WriteLine($"value or reference?");
            inputValue = Console.ReadLine();

            if (inputValue == "value")
            {
                int a = 2;

                Console.WriteLine($"before calling function DoSomething, a is {a}");

                DoSomething(a);

                Console.ReadLine();//Just a wait

                Console.WriteLine($"return value of function DoSomething, a is {a}");

            } else if (inputValue == "reference")
            {
                Example test = new Example();
                test.CalculationValue = 3;

                Console.WriteLine($"before calling function DoSomethingWithAReferenceType, test's CalculationValue is {test.CalculationValue}");

                DoSomethingWithAReferenceType(test);

                Console.ReadLine();//Just a wait

                Console.WriteLine($"before calling function DoSomethingWithAReferenceType, test's CalculationValue is {test.CalculationValue}");

            }

        }

        static void DoSomething(int x) {
            x = x + 5;

            Console.ReadLine();//Just a wait

            Console.WriteLine($"after calling function DoSomething, x is {x}");
        }

        static void DoSomethingWithAReferenceType(Example example)
        {
            example.CalculationValue = example.CalculationValue + 5;

            Console.ReadLine();//Just a wait

            Console.WriteLine($"after calling function DoSomethingWithAReferenceType with an object of Example, its CalculationValue is {example.CalculationValue}");
        }
    }


    //Should be in a different file
    public class Example
    {
        public int CalculationValue = 0;
    }

}