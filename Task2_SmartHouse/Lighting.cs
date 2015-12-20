using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_SmartHouse
{
    public class Lighting : Devise, ISwitch, IBright
    {
        public BrightnessLevel Bright{ get; set;}
        public Lighting(bool status, BrightnessLevel bright)
            : base(status)
        {
            Bright = bright;
        }
        void ISwitch.SetOn()
        {
            Status = true; 
        }
        void ISwitch.SetOff()
        {
            Status = false;
        }
        void IBright.SetBrightLow()
        {
            Bright = BrightnessLevel.Low;
        }
        void IBright.SetBrightMed()
        {
            Bright = BrightnessLevel.Medium;
        }
        void IBright.SetBrightHigh()
        {
            Bright = BrightnessLevel.High;
        }
        public override string ToString()
        {
            string status;
            string mode = "";
            if (Status)
            {
                status = "Включено";
            }
            else
            {
                status = "Выключено";
            }
            if (Bright == BrightnessLevel.Low)
            {
                mode = "Низкая";
            }
            else if (Bright == BrightnessLevel.Medium)
            {
                mode = "Средняя";
            }
            else 
            {
                mode = "Высокая";
            }
            return ", Устройсво " + status + " Яркость: " + mode;
        }
    }
}
