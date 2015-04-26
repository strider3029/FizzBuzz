using System;

namespace FizzBuzz
{
    /// <summary>
    /// Print 1 - 100 with Fizz in place of 3, Buzz in place of 5 and FizzBuzz in place of 3 AND 5.
    /// </summary>
    public static class FizzBuzz
    {
        /// <summary>
        /// Select and run a function variation of FizzBuzz.
        /// </summary>
        public static void RunFizzBuzzSelect()
        {
            Console.WriteLine("Select 1 to print FizzBuzz using a basic function, Select 2 to print FizzBuzz recursively, Select 3 to quit:");

            ConsoleKeyInfo keyPressed = Console.ReadKey();
            Console.WriteLine();

            switch (keyPressed.KeyChar)
            {
                case '1':
                    {
                        Console.WriteLine("Basic FizzBuzz:");
                        FizzBuzz.RunBasicFizzBuzz();
                        Console.ReadKey();
                        break;
                    }
                case '2':
                    {
                        Console.WriteLine("Recursive FizzBuzz:");
                        FizzBuzz.RunRecursiveFizzBuzz();
                        Console.ReadKey();
                        break;
                    }
                case '3':
                    {
                        Console.WriteLine("Terminating FizzBuzz");
                        Console.ReadKey();
                        break;
                    }
                default:
                    {
                        RunFizzBuzzSelect();
                        break;
                    }
            }
        }

        /// <summary>
        /// Basic version of FizzBuzz.
        /// </summary>
        public static void RunBasicFizzBuzz()
        {
            string line;

            for(int x = 1; x <= 100; ++x)
            {
                line = "";
                line += (x % 3 == 0) ? "Fizz" : "";
                line += (x % 5 == 0) ? "Buzz" : "";

                if(string.IsNullOrWhiteSpace(line))
                {
                    line = x.ToString();
                }

                Console.WriteLine(line);
            }
        }

        /// <summary>
        /// Recursive version of FizzBuzz.
        /// </summary>
        /// <param name="x">
        /// Current value to evaluate for output.
        /// </param>
        public static void RunRecursiveFizzBuzz(int x = 1)
        {
            if(x <= 100)
            {
                string line = "";
                line += (x % 3 == 0) ? "Fizz" : "";
                line += (x % 5 == 0) ? "Buzz" : "";

                if (string.IsNullOrWhiteSpace(line))
                {
                    line = x.ToString();
                }

                Console.WriteLine(line);

                RunRecursiveFizzBuzz(++x);
            }
        }
    }
}
