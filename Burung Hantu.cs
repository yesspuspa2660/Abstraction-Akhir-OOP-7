using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Burung_Hantu   :   IHewan
    {
        public void Bergerak()
        {
            Console.WriteLine("Burung Hantu bergerak dengan cara terbang");
            Console.WriteLine("Dengan bantuan sayap");
        }
    }
}
