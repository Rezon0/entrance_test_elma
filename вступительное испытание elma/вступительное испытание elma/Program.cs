using System;

namespace вступительное_испытание_elma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)  //цикл для перебора чисел
            {
                if (i % 15 == 0)    //проверяем кратность на 15, если истина, выводим FizzBuzz
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)    //проверяем кратность на 5, если истина, выводим Buzz
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)    //проверяем кратность на 3, если истина, выводим Fizz
                {
                    Console.WriteLine("Fizz");
                }
                else Console.WriteLine(i);  //в остальных случаях выводим i
            }
        }
    }
}
