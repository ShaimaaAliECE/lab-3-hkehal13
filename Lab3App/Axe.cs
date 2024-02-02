using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Axe : Tool
    {
        public Axe(string Description) : base(Description) { }

        public override void AddMe(List<Collectable> collections)
        {
            base.AddMe(collections);
            DoAction();
        }

        public void DoAction()
        {
            Console.WriteLine("Axe is used");
        }

        public override void Display()
        {
            Console.Write("Axe ");
            base.Display();
        }
    }
}
