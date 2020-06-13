using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractionClass
{
    public abstract class Hewan
    {
        public abstract void Bergerak();

        public void Berhenti()
        {
            Console.WriteLine("Hewan Berhwnti");
        }
    }
}
