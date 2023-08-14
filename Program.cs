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
            Console.WriteLine("S = seconds");
            Console.WriteLine("M = minutes");
            Console.WriteLine("0 = exit");
            Console.WriteLine("Enter the time to start the stopwatch");
            try
            {
                var data = Console.ReadLine().ToLower();

                var type = char.Parse(data.Substring(data.Length - 1, 1));
                var time = int.Parse(data.Substring(0, data.Length - 1));

                var multiplier = 1;

                if (type == 'm')
                    multiplier = 60;

                if (time == 0)
                {
                    Console.WriteLine("Exit");
                    return;
                }

                Start(time * multiplier);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input");
            }

            static void Start(int time)
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
            }


        }
    }
}