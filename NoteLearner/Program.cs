using System;

namespace NoteLearner
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] notes = { {"E0", "E" }, {"E1", "F" }, {"E2", "F#" }, {"E3", "G" }, {"E4", "G#" }, {"E5", "A" },
                                {"A0", "A" }, { "A1", "A#" }, { "A2", "B" }, { "A3", "C" }, { "A4", "C#" }, { "A5", "D" },
                                {"D0", "D" }, {"D1", "D#" }, {"D2", "E" }, {"D3", "F#" }, {"D4", "F#" }, {"D5", "G" },
                                {"G0", "G" }, {"G1", "G" }, {"G2", "G" }, {"G3", "G" }, {"G4", "G" }, {"G5", "G" },
                                {"B0", "B" }, {"B1", "C" }, {"B2", "C#" }, {"B3", "D" }, {"B4", "D#" }, {"B5", "E" } 
            };

            Random rnd = new Random();
            int score = 0;
            bool showanswer = false;
            Main();
           

            void Main()
            {

                Console.WriteLine("Enter the amount of questions you want");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("If incorrect do you want to show the answer? y/n");
                string yn = Console.ReadLine().ToLower();
                if (yn == "y")
                {
                    showanswer = true;
                }

                for (int i = 0; i < x; i++)
                {
                    int j = rnd.Next(notes.Length / 2);

                    Console.Clear();
                    Console.WriteLine("{0}\nQuestion {1}/{2}", notes[j, 0], i + 1, x);
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == notes[j, 1])
                    {
                        Console.WriteLine("Correct");
                        Console.ReadLine();
                        score++;
                    }

                    if (answer != notes[j, 1] && showanswer == true)
                    {
                        Console.WriteLine("Incorrect {0}", notes[j, 1]);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                        Console.ReadLine();
                    }

                }
                Console.Clear();
                Console.WriteLine("Score: {0}/{1}\nDo you want to go again y/n", score, x);
               string replay = Console.ReadLine().ToLower();
                if (replay == "y")
                {
                    Console.Clear();
                    Main();
                }
                else
                {
                    Environment.Exit(0);
                }

            }

           

        }
    }
}
