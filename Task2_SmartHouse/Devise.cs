using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_SmartHouse
{
    public abstract class Devise
    {
        public bool Status { get; set; }
        public Devise(bool status)
        {
            Status = status;
        }
    }
}
