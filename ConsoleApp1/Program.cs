
namespace ConsoleApp1
{
    using CustomArray;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CustomArray arr = new CustomArray(2)
            {
                1, 3, 4, 5
            };

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("after insert");

            arr.InsertAt(2, 99);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(arr.Count);
            Console.WriteLine(arr.Capacity);


            Console.WriteLine("after delete");

            arr.RemoveAt(8);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            arr.GetItem(66);

        }
    }
}