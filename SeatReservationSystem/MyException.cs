using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeslihanTurpcu300359919
{
    class MyException:Exception
    {
        public MyException() : base("This seat is already taken.")
        {

        }

    }
}
