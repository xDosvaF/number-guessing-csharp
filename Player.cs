using System;

namespace NumberGuessing
{
    public class Player : IPlayer
    {
        private int _Victory {get;set;}
        private int _Defeat {get;set;} 
        public string Name  {get;set;} 

        public Player(string Name)
        {
            this.Name = Name;
        }

        public string GetName() => Name;
        public int GetVictory() => _Victory;
        public int GetDefeat() => _Defeat;

        public void SetVictory(int newVictory) => _Victory = newVictory;
        public void SetDefeat(int newDefeat) => _Defeat = newDefeat;

    }
}