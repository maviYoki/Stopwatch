using System.Threading;

namespace Stopwatch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("S = seconds");
            Console.WriteLine("M = minutes");
            Console.WriteLine("0 = exit");
            Console.WriteLine("Enter the time to start the stopwatch");

            try
            {
                var data = Console.ReadLine().ToLower();

                if (data == "0")
                {
                    Console.WriteLine("Exit");
                    return;
                }

                var type = char.Parse(data.Substring(data.Length - 1, 1));
                Console.WriteLine(type);
                Thread.Sleep(2000);
                var time = int.Parse(data.Substring(0, data.Length - 1));



                Console.WriteLine("D - Descending count");
                Console.WriteLine("G - Growing count");

                var count = Console.ReadLine().ToUpper();


                var multiplier = 1;

                if (type == 'm')
                    multiplier = 60;

                if (count == "D")
                    Descending(time * multiplier);

                if (count == "G")
                    Growing(time * multiplier);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input");
            }

        }
        static void Growing(int time)
        {
            var currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();

            Console.WriteLine("Finished stopwatch...");
            Thread.Sleep(2000);
            Menu();
        }

        static void Descending(int time)
        {
            var currentTime = 0;

            while (time != currentTime)
            {
                Console.Clear();
                time--;
                Console.WriteLine(time);
                Thread.Sleep(1000);
            }
            Console.Clear();

            Console.WriteLine("Finished stopwatch...");
            Thread.Sleep(2000);
            Menu();
        }
    }
}