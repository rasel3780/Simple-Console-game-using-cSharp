using System;
using System.Collections.Generic;
using System.Text;

namespace ColorMathcingGame
{
    class Game
    {
        List<char> stick1 = new List<char>();
        List<char> stick2 = new List<char>();
        List<char> stick3 = new List<char>();
        public int initialMove { get; set; }



        public void _push()
        {
            char[] chars = "RGB".ToCharArray();
            Random r = new Random();
            var red = 0;
            var green = 0;
            var blue = 0;
            while (true)
            {
                int j = r.Next(chars.Length);
                if (j == 0 && red < 1)
                {
                    red++;
                    stick1.Add(chars[j]);
                }
                else if (j == 1 && green < 1)
                {
                    green++;
                    stick1.Add(chars[j]);
                }
                else if (j == 2 && blue < 1)
                {
                    blue++;
                    stick1.Add(chars[j]);
                }

                if (red == 1 && green == 1 && blue == 1)
                {
                    break;
                }
            }
            red = 0;
            green = 0;
            blue = 0;
            while (true)
            {
                int j = r.Next(chars.Length);
                if (j == 0 && red < 1)
                {
                    red++;
                    stick2.Add(chars[j]);
                }
                else if (j == 1 && green < 1)
                {
                    green++;
                    stick2.Add(chars[j]);
                }
                else if (j == 2 && blue < 1)
                {
                    blue++;
                    stick2.Add(chars[j]);
                }

                if (red == 1 && green == 1 && blue == 1)
                {
                    break;
                }
            }
            red = 0;
            green = 0;
            blue = 0;
            while (true)
            {
                int j = r.Next(chars.Length);
                if (j == 0 && red < 1)
                {
                    red++;
                    stick3.Add(chars[j]);
                }
                else if (j == 1 && green < 1)
                {
                    green++;
                    stick3.Add(chars[j]);
                }
                else if (j == 2 && blue < 1)
                {
                    blue++;
                    stick3.Add(chars[j]);
                }

                if (red == 1 && green == 1 && blue == 1)
                {
                    break;
                }
            }
        }



        public void move(int currentPos, int distination)
        {
            Console.WriteLine($"Move :[{currentPos} , {distination}]");
            if (currentPos == 1 && distination == 2)
            {
                if (stick1.Count != 0)
                {
                    stick2.Insert(0, stick1[0]);
                    stick1.RemoveAt(0);
                    initialMove++;
                }
                else
                    Console.WriteLine("Disk 1 Already empty");
            }
            else if (currentPos == 2 && distination == 1)
            {
                if (stick2.Count != 0)
                {
                    stick1.Insert(0, stick2[0]);
                    stick2.RemoveAt(0);
                    initialMove++;
                }
                else
                    Console.WriteLine("Disk 2 Already empty");

            }
            else if (currentPos == 1 && distination == 3)
            {
                if (stick1.Count != 0)
                {
                    stick3.Insert(0, stick1[0]);
                    stick1.RemoveAt(0);
                    initialMove++;
                }
                else
                    Console.WriteLine("Disk2 Aleady empty");
            }
            else if (currentPos == 3 && distination == 1)
            {
                if (stick3.Count != 0)
                {
                    stick1.Insert(0, stick3[0]);
                    stick3.RemoveAt(0);
                    initialMove++;
                }
                else
                    Console.WriteLine("Disk3 Already Empty");
            }

            else if (currentPos == 2 && distination == 3)
            {
                if (stick2.Count != 0)
                {
                    stick3.Insert(0, stick2[0]);
                    stick2.RemoveAt(0);
                    initialMove++;
                }
                else
                    Console.WriteLine("Disk 2 already empty");
            }
            else if (currentPos == 3 && distination == 2)
            {
                if (stick3.Count != 0)
                {
                    stick2.Insert(0, stick3[0]);
                    stick3.RemoveAt(0);
                    initialMove++;
                }
                else
                    Console.WriteLine("Disk3 Aleady Empty");
            }
            else
            {
                Console.WriteLine("Invalied Move");
            }
            Console.WriteLine($"TOTAL MOVE: {initialMove}");

        }



        public void display()
        {
            var max = Math.Max(stick1.Count, Math.Max(stick2.Count, stick3.Count));
            try
            {
                for (var i = 0; i < max; i++)
                {
                    if (i < stick1.Count)
                    {
                        Console.Write(stick1[i]);
                    }
                    Console.Write("\t");
                    if (i < stick2.Count)
                    {
                        Console.Write(stick2[i]);
                    }

                    Console.Write("\t");
                    if (i < stick3.Count)
                    {
                        Console.Write(stick3[i]);
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:\n");
            }
        }



        public bool GameSuccessful()
        {
            var disk1Matched = false;
            var disk2Matched = false;
            var disk3Matched = false;

            if (stick1.Count == 3)
            {
                if (stick1[0] == stick1[1] && stick1[1] == stick1[2])
                    disk1Matched = true;
            }
            if (stick2.Count == 3)
            {
                if (stick2[0] == stick2[1] && stick2[1] == stick2[2])
                    disk2Matched = true;
            }
            if (stick3.Count == 3)
            {
                if (stick3[0] == stick3[1] && stick3[1] == stick3[2])
                    disk3Matched = true;
            }
            if (disk1Matched && disk2Matched && disk3Matched)
            {
                Console.WriteLine($"You have solved in total: {initialMove} moves");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
