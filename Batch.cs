using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurdleTask
{
    public class Batch : Thing
    {
        private List<Thing> _items;

        public Batch(string number, string name) : base(number, name)
        {
            _items = new List<Thing>();
        }

        public void Add(Thing item)
        {
            _items.Add(item);
        }

        public override void Print()
        {
            Console.WriteLine($"Batch sale: #{Number}, {Name}");
            foreach (var item in _items)
            {
                item.Print();
            }
            Console.WriteLine($"Total: {Total():C2}");
        }

        public override decimal Total()
        {
            return _items.Sum(item => item.Total());
        }
    }

   

}
