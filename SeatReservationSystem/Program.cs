using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NeslihanTurpcu300359919
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mainapp mainapp = new Mainapp();
            mainapp.startForReservation();
            mainapp.display();
            ReadKey();
        }
    }
}
