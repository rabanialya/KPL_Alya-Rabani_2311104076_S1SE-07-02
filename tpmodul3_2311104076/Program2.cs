using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_2311104076
{
    class Program2
    {
        static void Main()
        {
            DoorMachine pintu = new DoorMachine();

            Console.WriteLine("\nMenjalankan simulasi...");

            pintu.BukaPintu();
            pintu.BukaPintu();
            pintu.KunciPintu();
            pintu.KunciPintu();
        }
    }
}
