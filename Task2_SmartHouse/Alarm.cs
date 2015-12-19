using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_SmartHouse
{
    class Alarm : Devise, ISwich
    {
        public Alarm(bool status)
            : base(status)
        {

        }
        void ISwich.SetOn()
        {
            Status = true;
        }
        void ISwich.SetOff()
        {
            Status = false;
        }
        public override string ToString()
        {
            string status;
            if (Status)
            {
                status = "Включена";
            }
            else
            {
                status = "Выключена";
            }
            return ", Сигнализация: " + status;
        }
    }
}
