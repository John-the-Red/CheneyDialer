using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheney_Dialer
{
    class Cellphone : Phone
    {
        public Cellphone(string company, string number, int cell) : base(company, number, cell)
        {

        }
        public override void Dial()
        {
            Console.WriteLine(_company + " is being dialed using 1+" + _number + "...");
        }
    }
}
