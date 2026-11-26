using System;

namespace NumberGuessing
{
    public class Game
    {
        private Random _rnd = new Random();
        private int RandomNumber {get;set;}
        private int _Intentos { get; set; }
        public int Number { get; set; }

        public int GetIntentos() => _Intentos;
        public void SetNumber(int newNumber) => Number = newNumber;

        public Game()
        {
            RandomNumber = _rnd.Next(0, 101);
        }

        public void SetIntentos(int dificult)
        {
            if (dificult == 1)
                _Intentos = 8;

            else if (dificult == 2)
                _Intentos = 5;
            else
                _Intentos = 3;
        }

        public int InGame()
        {
            while (_Intentos > 0)
            {
                try
                {
                    Console.Write("Choose a number: ");
                    int newNumber = Convert.ToInt32(Console.ReadLine());
                    SetNumber(newNumber);

                    if (newNumber > RandomNumber)
                    {
                        _Intentos -=1;
                        Console.WriteLine($"Incorrect! The number is less than {newNumber}");
                    }

                    else if (newNumber < RandomNumber)
                    {
                        _Intentos -=1;
                        Console.WriteLine($"Incorrect! The number is greater than {newNumber}");
                    }

                    else
                    {
                        Console.WriteLine("You Won!");
                        return 1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
            Console.WriteLine("You are a fucking loser");
            return 0;
        }
    }
}