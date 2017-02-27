using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Pet Utsukushii = new VirtualPet.Pet();
            Utsukushii.SayMyName();
            Utsukushii.FurColors();
            Utsukushii.Fun();
            Utsukushii.ImFast();
            Utsukushii.MyAge();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Utsukushii.Tick();
            

        }
    }
}
