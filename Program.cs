using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractionClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hewan Hewan;    // objek polymorpishm

            Hewan = new Burung_Hantu();
            Hewan.Bergerak();

            Console.WriteLine();

            Hewan = new Lumba_lumba();
            Hewan.Bergerak();

            Console.ReadKey();*/

            IHewan Hewan;   // objek polymorpishm

            Hewan = new Burung_Hantu();    
            Hewan.Bergerak();

            Console.WriteLine();

            Hewan = new Lumba_lumba();
            Hewan.Bergerak();

            Console.ReadKey();
        }
    }
}
