using System;

namespace NumberGuessing
{
    public class Game
    {
        private  Random _rnd = new Random();
        private int _Intentos {get;set;}
        public int Number {get;set;}

        public int GetIntentos() => _Intentos;
        public void SetNumber(int newNumber) => Number = newNumber;

        public Game()
        {
            _rnd.Next(0,101);
        }

        public void SetIntentos(string dificult)
        {
            if(dificult == "Easy")
                _Intentos = 8;

            if(dificult == "Medium")
                _Intentos = 5;
            else
                _Intentos = 3;
        }  

        public int InGame()
        {
            while(_Intentos > 0)
            {
                Console.Write("Choose a number: ");
                int newNumber = Convert.ToInt32(Console.ReadLine());
                SetNumber(newNumber);

                if(newNumber >= Convert.ToInt32(_rnd))
                {
                    _Intentos--;
                    Console.WriteLine($"Incorrect! The number is less than {newNumber}");
                }

                if(newNumber <= Convert.ToInt32(_rnd))
                {
                    _Intentos--;
                    Console.WriteLine($"Incorrect! The number is greater than {newNumber}"); 
                }

                else
                {
                    Console.WriteLine("You Won!");
                    return 1;
                }
            }
            Console.WriteLine("You are a fucking loser");
            return 0;
        }     
    }  
}