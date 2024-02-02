using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3App
{
    public class Collectable : IDisplayable
    {
        public string Description { get; set; }
        public CollectionBoard Board{ get; set; }

        public Collectable(string desc)
        {
            Description = desc;
        }

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{Description} collected, congrats!!");
        }

        public virtual void Display()
        {
            Console.WriteLine($"{Description} is displayed");
        }

    }
}
