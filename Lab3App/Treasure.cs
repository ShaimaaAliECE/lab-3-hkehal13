using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score { get; set; }

        public Treasure(string Description, int score): base (Description){
            Score = score;
        }

        public override void AddMe(List<Collectable> collects)
        {
            base.AddMe(collects);
            Board.UpdateTotalScore(Score);
        }



    }
}
