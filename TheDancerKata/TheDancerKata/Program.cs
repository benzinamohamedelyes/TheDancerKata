namespace TheDancerKata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to the dancer kata");
            Console.WriteLine("************************************");
            var stop = false;
            while (!stop)
            {
                Console.WriteLine("Please enter the number of steps you want to take or 'exit' to quit");
                var input = Console.ReadLine();
                if (input?.ToLower() == "exit")
                {
                    stop = true;
                }
                else
                {
                    if (int.TryParse(input, out int steps))
                    {
                        if (steps < 0 || steps > 2147483647)
                        {
                            Console.WriteLine("Please enter a valid number of steps between 0 and 2147483647");
                            return;
                        }
                        var dancer = new Domain.Dancer();
                        var position = dancer.GetPositionAt(steps);
                        Console.WriteLine($"The dancer is at position {position}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }

        }
    }
}
