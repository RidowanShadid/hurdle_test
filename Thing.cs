using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurdleTask
{
    public abstract class Thing
    {
        public string Number { get; private set; }
        public string Name { get; private set; }

        protected Thing(string number, string name)
        {
            Number = number;
            Name = name;
        }

        public abstract void Print();
        public abstract decimal Total();
    }
}

