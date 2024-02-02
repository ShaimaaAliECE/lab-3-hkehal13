using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Coin : Treasure
    {
        public int Value {  get; set; }

        public Coin(string description, int score, int value) : base(description, score) 
        {
            Value = value;
        }


        public override void AddMe(List<Collectable> collects)
        {
            base.AddMe(collects);
            Board.UpdateTotalValue(Value);
        }

        public override void Display()
        {
            Console.Write("Coin ");
            base.Display();
        }

    }
}

