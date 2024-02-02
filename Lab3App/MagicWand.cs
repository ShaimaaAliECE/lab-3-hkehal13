using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class MagicWand : Tool
    {
        public MagicWand(string Description) : base(Description)
        {

        }

        public override void AddMe(List<Collectable> collects)
        {
            base.AddMe(collects);
            DoAction();
        }

        public void DoAction() {
            Console.WriteLine("MagicWand is used");
        }

        public override void Display()
        {
            Console.Write("MagicWand ");
            base.Display();
        }

    }
}
