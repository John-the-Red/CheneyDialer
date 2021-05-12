using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheney_Dialer
{
    class Phone
    {
        protected string _company;
        protected string _number;
        protected int _type;

        public Phone(string Company, string Number, int Type)
        {
            _company = Company;
            _number = Number;
            _type = Type;
        }

        public virtual void Dial()
        {
            if (_type == 1)
            {
                Console.WriteLine(_company + " is being dialed using " + _number + "...");
            }
        }
    }
}
