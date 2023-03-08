using data_struct;
using System.Diagnostics;
namespace lab12
{
    public static class UserInput
    {
        public static void Run()
        {
            Random rand = new Random();
            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();
            //TestCase.Run();
            int option = 0;
            Console.WriteLine("Виберiть опцiю 1 - запустити тести, 2 запустити огляд: ");
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            if (option != 1 && option != 2)
            {
                Console.WriteLine("Wrong input.");
                return;
            }
            if (option == 1)
            {
                TestCase.Run();
                return;
            }
            Console.Write("Введiть кiлькiсть елементiв: ");
            int n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            List<int> a = new List<int>();
            data_struct.LinkedList<int> list = new data_struct.LinkedList<int>();
            for (int i = 0; i < n; i++)
            {
                int val = rand.Next(10000);
                a.Add(val);
                list.PushBack(val);
            }
            Console.WriteLine("Generated array: ");
            list.Print();
            Console.WriteLine("\n Input element to search: ");
            int elem = 0;
            try
            {
                elem = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Using Linear search and Barrier search: ");
            stopwatch1.Reset();
            stopwatch1.Start();
            Console.WriteLine($"Результат лiнiйного пошуку за в масивi: {Search.LinearSearch(ref a, elem)}");
            stopwatch1.Stop();
            stopwatch2.Reset();
            stopwatch2.Start();
            Console.WriteLine($"Результат лiнiйного пошуку за в лiнiйному зв'язаному списку: {Search.LinearSearch(ref list, elem)}");
            Console.WriteLine($"Час затрачений на пошук\n Масив: {stopwatch1.Elapsed}\n Лiйний зв'язаний список: {stopwatch2.Elapsed}");
            stopwatch2.Reset();
            Console.WriteLine("Using Binary search and modified Binary Search: ");
            a.Sort();
            for (int i = 0; i < n; i++)
            {
                list[i] = a[i];
            }
            list.Print();
            Console.WriteLine("Input search element: ");
            try
            {
                elem = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            stopwatch1.Reset();
            stopwatch1.Start();
            Console.WriteLine($"Результат Бiнарного пошуку за в масивi: {Search.BinarySearch(ref a, 0, a.Count, elem)}");
            stopwatch1.Stop();
            stopwatch2.Reset();
            stopwatch2.Start();
            Console.WriteLine($"Результат Бiнарного пошуку за в лiнiйному зв'язаному списку: {Search.BinarySearch(ref list, 0, list.Size(), elem)}");
            Console.WriteLine($"Час затрачений на пошук\n Масив: {stopwatch1.Elapsed}\n Лiйний зв'язаний список: {stopwatch2.Elapsed}");
            stopwatch2.Reset();
            stopwatch1.Reset();
            stopwatch1.Start();
            Console.WriteLine($"Результат модифiкованого Бiнарного пошуку в масивi: {Search.Binary_Search_Modify(ref a, 0, a.Count, elem)}");
            stopwatch1.Stop();
            stopwatch2.Reset();
            stopwatch2.Start();
            Console.WriteLine($"Результат модифiкованого Бiнарного пошуку в лiнiйному зв'язаному списку: {Search.Binary_Search_Modify(ref list, 0, list.Size(), elem)}");
            Console.WriteLine($"Час затрачений на пошук\n Масив: {stopwatch1.Elapsed}\n Лiйний зв'язаний список: {stopwatch2.Elapsed}");
            stopwatch2.Reset();
        }
    }
}