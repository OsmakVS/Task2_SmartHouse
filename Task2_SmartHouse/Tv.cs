using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_SmartHouse
{
    class Tv : Devise, ISwitch, IChannel, IVolume
    {
        public int Volume { get; set; }
        public int Channel { get; set; }
        public Tv(bool status, int channel, int volume)
            : base(status)
        {
            Channel = channel;
            Volume = volume;

        }
        void ISwitch.SetOn()
        {
            Status = true; 
        }
        void ISwitch.SetOff()
        {
            Status = false;
        }
        public void SetChannelUp()
        {
            Channel++;
        }
        public void SetChannelDown()
        {
            Channel--;
        }
        public void SetVolumeUp()
        {
            Volume++;
        }
        public void SetVolumeDown()
        {
            Volume--;
        }
        public override string ToString()
        {
            string status;
            string channel = Channel.ToString();
            string volume = Volume.ToString();
            if (Status)
            {
                status = "Включено";
            }
            else
            {
                status = "Выключено";
            }
            return ", Устройсво: " + status + ", Канал: " + channel + ", Громкость: " + volume;
        }
    }
}
