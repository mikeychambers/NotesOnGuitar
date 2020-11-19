using System;

namespace NoteLearner
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] notes = { {"E0", "E" }, {"E1", "F" }, {"E2", "F#" }, {"E3", "G" }, {"E4", "G#" }, {"E5", "A" }, {"E6", "A#" }, {"E7", "B" }, {"E8", "C" }, {"E9", "C#" }, {"E10", "D" }, {"E11", "D#" },
                                {"A0", "A" }, { "A1", "A#" }, { "A2", "B" }, { "A3", "C" }, { "A4", "C#" }, { "A5", "D" }, {"A6", "D#" }, { "A7", "E" }, { "A8", "F" }, { "A9", "F#" }, { "A10", "G" }, { "A11", "G#" },
                                {"D0", "D" }, {"D1", "D#" }, {"D2", "E" }, {"D3", "F#" }, {"D4", "F#" }, {"D5", "G" }, {"D6", "G#" }, {"D7", "A" }, {"D8", "A#" }, {"D9", "B" }, {"D10", "C" }, {"D11", "C#" },
                                {"G0", "G" }, {"G1", "G#" }, {"G2", "A" }, {"G3", "A#" }, {"G4", "B" }, {"G5", "C" }, {"G6", "C#" }, {"G7", "D" }, {"G8", "D#" }, {"G9", "E" }, {"G10", "F" }, {"G11", "F#" },
                                {"B0", "B" }, {"B1", "C" }, {"B2", "C#" }, {"B3", "D" }, {"B4", "D#" }, {"B5", "E" }, {"B6", "F" }, {"B7", "F#" }, {"B8", "G" }, {"B9", "G#" }, {"B10", "A" }, {"B11", "A#" }
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
