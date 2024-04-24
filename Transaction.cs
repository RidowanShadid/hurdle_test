using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurdleTask
{
    public class Transaction : Thing
    {
        private decimal _amount;

        public Transaction(string number, string name, decimal amount) : base(number, name)
        {
            _amount = amount;
        }

        public override void Print()
        {
            Console.WriteLine($"#{Number}, {Name}, {_amount:C2}");
        }

        public override decimal Total()
        {
            return _amount;
        }
    }

}
