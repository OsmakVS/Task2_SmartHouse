using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_SmartHouse
{
    class Thermostat : Devise, ITemprerature, ISwich
    {
        public TempLevel Tlvl { get; set; }
        public Thermostat(bool status, TempLevel tlvl)
            : base(status)
        {
            Tlvl = tlvl;
        }
        public void SetOn()
        {
            Status = true;
        }
        public void SetOff()
        {
            Status = false; 
        }
        public void SetTempLow()
        {
            Tlvl = TempLevel.Low;
        }
        public void SetTempMed()
        {
            Tlvl = TempLevel.Medium;
        }
        public void SetTempHigh()
        {
            Tlvl = TempLevel.High;
        }
        public override string ToString()
        {
            string status;
            string mode;
            if (Tlvl == TempLevel.Low)
            {
                mode = "Низкий";
            }
            else if (Tlvl == TempLevel.Medium)
            {
                mode = "Средний";
            }
            else
            {
                mode = "Высокий";
            }
            if (Status)
            {
                status = "Включено";
            }
            else
            {
                status = "Выключено";
            }
            return ", Устройсво: " + status + ", Уровень обогрева: " + mode; 
        }
    }
}
