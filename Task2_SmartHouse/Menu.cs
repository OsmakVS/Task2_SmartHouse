using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_SmartHouse
{
    class Menu
    {
        IDictionary<string, Devise> devDic = new Dictionary<string, Devise>();
        public void Processing()
        {
            devDic.Add("MainLamp", new Lighting(false, BrightnessLevel.Low));
            devDic.Add("MainTv", new Tv(false, 1, 20));
            devDic.Add("MainTermostat", new Thermostat(false, TempLevel.Low));
            devDic.Add("MainAlarm", new Alarm(false));
            while (true)
            {
                Console.Clear();
                foreach (var d in devDic)
                {
                    Console.WriteLine(d.Key + d.Value.ToString());
                }
                Console.WriteLine("Введите Команду");
                string[] array = Console.ReadLine().Split(' ');
                if (array[0] == "exit")
                {
                    return;
                }
                else if (array.Length != 3 && array.Length != 2)
                {
                    Help();
                    continue;
                }
                if (array[0] == "add")
                {
                    if (CheckInContainName(array[2]) == false)
                    {
                        if (array[1] == "light")
                        {
                            AddLight(array[2]);
                        }
                        else if (array[1] == "tv")
                        {
                            AddTv(array[2]);
                        }
                        else if (array[1] == "term")
                        {
                            AddTermostat(array[2]);
                        }
                        else if (array[1] == "alarm")
                        {
                            AddAlarm(array[2]);
                        }
                    }
                }
                switch (array[0].ToLower())
                    {
                        case "del":
                            devDic.Remove(array[1]);
                            break;
                        case "on":
                            ((ISwich)devDic[array[1]]).SetOn();
                            break;
                        case "off":
                            ((ISwich)devDic[array[1]]).SetOff();
                            break;
                        case "chu":
                            if (devDic[array[1]] is IChannel)
                            {
                                ((IChannel)devDic[array[1]]).SetChannelUp();
                            }
                            else
                            {
                                Console.WriteLine("Команда не соответствует устройсву.");
                                Console.ReadKey();
                            }
                            break;
                        case "chd":
                            if (devDic[array[1]] is IChannel)
                            {
                                ((IChannel)devDic[array[1]]).SetChannelDown();
                            }
                            else
                            {
                                Console.WriteLine("Команда не соответствует устройсву.");
                                Console.ReadKey();
                            }
                            break;
                        case "volu":
                            if (devDic[array[1]] is IVolume)
                            {
                                ((IVolume)devDic[array[1]]).SetVolumeUp();
                            }
                            else
                            {
                                Console.WriteLine("Команда не соответствует устройсву.");
                                Console.ReadKey();
                            }
                            break;
                        case "vold":
                            if (devDic[array[1]] is IVolume)
                            {
                                ((IVolume)devDic[array[1]]).SetVolumeDown();
                            }
                            else
                            {
                                Console.WriteLine("Команда не соответствует устройсву.");
                                Console.ReadKey();
                            }
                            break;
                        case "blow":
                            if (devDic[array[1]] is IBright)
                            {
                                ((IBright)devDic[array[1]]).SetBrightLow();
                            }
                            else
                            {
                                Console.WriteLine("Команда не соответствует устройсву.");
                                Console.ReadKey();
                            }
                            break;
                        case "bmed":
                            if (devDic[array[1]] is IBright)
                            {
                                ((IBright)devDic[array[1]]).SetBrightMed();
                            }
                            else
                            {
                                Console.WriteLine("Команда не соответствует устройсву.");
                                Console.ReadKey();
                            }
                            break;
                        case "bhigh":
                            if (devDic[array[1]] is IBright)
                            {
                                ((IBright)devDic[array[1]]).SetBrightHigh();
                            }
                            else
                            {
                                Console.WriteLine("Команда не соответствует устройсву.");
                                Console.ReadKey();
                            }
                            break;
                        case "tlow":
                            if (devDic[array[1]] is ITemprerature)
                            {
                                ((ITemprerature)devDic[array[1]]).SetTempLow();
                            }
                            else
                            {
                                Console.WriteLine("Команда не соответствует устройсву.");
                                Console.ReadKey();
                            }
                            break;
                        case "tmed":
                            if (devDic[array[1]] is ITemprerature)
                            {
                                ((ITemprerature)devDic[array[1]]).SetTempMed();
                            }
                            else
                            {
                                Console.WriteLine("Команда не соответствует устройсву.");
                                Console.ReadKey();
                            }
                            break;
                        case "thigh":
                            if (devDic[array[1]] is ITemprerature)
                            {
                                ((ITemprerature)devDic[array[1]]).SetTempHigh();
                            }
                            else
                            {
                                Console.WriteLine("Команда не соответствует устройсву.");
                                Console.ReadKey();
                            }
                            break;
                    }
                }
            }
        public void Help()
        {
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("add тип устройства имя устройсва (например: add tv MainTv)\n(Доступные типы устройсва: light, tv , term, alarm)");
            Console.WriteLine("del имя устройства (например del MainTv)");
            Console.WriteLine("on имя устройства (например on MainTv)");
            Console.WriteLine("off имя устройства (например off MainTv)");
            Console.WriteLine("volu имя устройства (например volu MainTv)");
            Console.WriteLine("vold имя устройства (например vold MainTv)");
            Console.WriteLine("chu имя устройства (например chu MainTv)");
            Console.WriteLine("chd имя устройства (например chd MainTv)");
            Console.WriteLine("blow имя устройства (например blow MainLamp)");
            Console.WriteLine("bmed имя устройства (например bmed MainLamp)");
            Console.WriteLine("bhigh имя устройства (например bhigh MainLamp)");
            Console.WriteLine("tlow имя устройства (например tlow MainTermostat)");
            Console.WriteLine("tmed имя устройства (например tmed MainTermostat)");
            Console.WriteLine("thigh имя устройства (например thigh MainTermostat)");
            Console.WriteLine("Для продолжения нажмите любую кнопку.");
            Console.ReadKey();
        }
        public void AddLight(string name)
        {
            devDic.Add(name, new Lighting(false, BrightnessLevel.Low));
        }
        public void AddTv(string name)
        {
            devDic.Add(name, new Tv(false, 1, 20));
        }
        public void AddTermostat(string name)
        {
            devDic.Add(name, new Thermostat(false, TempLevel.Low));
        }
        public void AddAlarm(string name)
        {
            devDic.Add(name, new Alarm(false));
        }
        public bool CheckInContainName(string name)
        {
            if (devDic.ContainsKey(name))
            {
                Console.WriteLine("Устройсво с таким именем уже существует.");
                Console.ReadKey();
                return true;
            }
            return false;
        }
    }
}
