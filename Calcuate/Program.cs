using System.Runtime.ExceptionServices;

namespace Calculate
{
    public interface ICalculator
    {
        int Add(int a, int b);
        void Event();
    }

    public class Calculator : ICalculator
    {
     
        public int Add(int a, int b)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            return a + b;
        }
        public void Event()
        {
            Console.WriteLine("Сложение успешно");
        }
    }

    public class ExpencionSum : ICalculator
    {
        int ICalculator.Add(int a, int b)
        {
           Console.WriteLine("{0} and {1} не удается сложить" , a , b); 
            return 0;
        }

        void ICalculator.Event()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Сложение не получилось...Увы и Ах )) "); ;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();
            ICalculator expSum = new ExpencionSum();

            Console.WriteLine("Введите два числа:");

            try
            {
                Console.Write("Превое число - ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Второе число - ");
                int b = Convert.ToInt32(Console.ReadLine());

                int result = calculator.Add(a, b);
                calculator.Event();
                Console.WriteLine($"Сумма чисел: {result}");
            }
            catch (Exception ex)
            {
                expSum.Event();
                
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}