using System;

namespace ColorMathcingGame
{
    class Play
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.initialMove = 0;
            game._push();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("| Press q/Q to quit the Game                 |");
            Console.WriteLine("| Enter column number separated by a space   |");
            Console.WriteLine("----------------------------------------------");
            
        
            while (true)
            {
                var res = game.GameSuccessful();
                game.display();
                Console.WriteLine();
                if (res.Equals(true))
                {
                    Console.WriteLine("Game Successful");
                    break;
                }
                else
                {
                    
                    var input = Console.ReadLine().Split(' ');
                    try
                    {
                        if (input[0].ToLower().Equals("q"))
                        {
                            break;
                        }
                        else
                        {
                            var current = int.Parse(input[0]);
                            var destination = int.Parse(input[1]);
                            game.move(current, destination);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nInvalid format \npossible formates are:");
                        Console.WriteLine("1 2 or 2 1 or 1 3 or 3 1 or 2 3 or 3 2\n");
                    }
                }
            }
        }
    }
}
