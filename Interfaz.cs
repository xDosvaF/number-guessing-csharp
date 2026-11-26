using System;

namespace NumberGuessing
{
    public class Interfaz
    {
        public static int option { get; set; }

        public static int Dificult { get; set; }

        public static void Options()
        {
            Console.Write("Name: ");
            string newName = Console.ReadLine()!;
            var newPlayer = new Player(newName);
            while (true)
            {
                Console.WriteLine(
                    @"1.- Play
2.- Stats
3.- Exit 
                ");
                Console.Write("Option: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine(
                            @"Welcome to the Number Guessing Game!
                          I'm thinking of a number between 1 and 100."
                            );

                        Console.WriteLine(
                            @"1. Easy (10 chances)
2. Medium (5 chances)
3. Hard (3 chances)"
                            );
                        Console.Write("Dificult: ");
                        Dificult = Convert.ToInt32(Console.ReadLine());
                        var NewGame = new Game();
                        NewGame.SetIntentos(Dificult);
                        int GetPoint = NewGame.InGame();
                        if (GetPoint == 1)
                        {
                            newPlayer.SetVictory(1);
                        }
                        else
                        {
                            newPlayer.SetDefeat(1);
                        }

                        break;
                    case 2:
                        Console.WriteLine(newPlayer.GetStats());
                        break;
                    case 3:
                        Console.WriteLine("See you later");
                        return;
                    default:
                        Console.WriteLine("Choose a correct option");
                        break;
                }
            }

        }
    }
}