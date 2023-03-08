using data_struct;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
namespace lab12
{
    internal class Program<T> where T : IComparable<T>
    {
        public T Max(T a, T b)
        {
            return a;
        }
        public static void Main()
        {

            int option = 0;
            Console.WriteLine("Виберiть опцiю 1 - запустити тести, 2 запустити огляд: ");
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            if(option == 1)
            {
                TestCase.Run();
                return;
            }
            else if(option == 2)
            {
                UserInput.Run();

            }
            else { throw new FormatException(); }
            var a = new data_struct.LinkedList<string>();
            var b = new data_struct.LinkedList<int>();
        }
    }
}