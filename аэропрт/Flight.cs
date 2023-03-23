using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace аэропрт
{
    [Serializable]
    public class Flight
    {
        
        private string Destination_point;
        private string stop_point;
        private double flight_range;
        private static uint weight;
        private static uint passengers;
        private string name_plane;
        private static uint max_weight = 600000;
        private string status;
        private string Pilot1;
        private string Kapitan;
        private string Pilot2;
        private string Stuardesa;
        private int id;
        public string Status { set; get; }
        public int ID
        {
            set
            {
                if (value > 10000)
                {
                    id = value;
                }
                else
                {
                    Random gena = new Random();
                    value = gena.Next(10000, 99999);
                    id = value;
                }
            }
            get
            {
                return id;
            }
        }
        public string Destination_Point
        {
            set
            {
                if (value.Trim().Length <= 1)
                {
                    throw new Exception("Такого пункта назначения не сущетсвует");

                }
                else
                {
                    string s = value.Trim();
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (!(((s[i] >= 'a') && (s[i] <= 'z')) || ((s[i] >= 'A') && (s[i] <= 'Z')) || ((s[i] >= 'А') && (s[i] <= 'Я')) || ((s[i] >= 'а') && (s[i] <= 'я'))))
                        {
                            throw new Exception("\nПункт должен содержать только буквы");
                        }
                        Destination_point = value;
                    }
                }

            }
            get
            {
                return Destination_point;
            }
        }
        public string Stop_point
        {
            set
            {
                if (value.Trim().Length <= 1)
                {
                    throw new Exception("Такой остановки не сущетсвует");

                }
                else
                {
                    string s = value.Trim();
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (!(((s[i] >= 'a') && (s[i] <= 'z')) || ((s[i] >= 'A') && (s[i] <= 'Z')) || ((s[i] >= 'А') && (s[i] <= 'Я')) || ((s[i] >= 'а') && (s[i] <= 'я'))))
                        {
                            throw new Exception("\nПункт должен содержать только буквы");
                        }
                    }
                    stop_point = value;
                }
            }
            get
            {
                return stop_point;
            }
        }
        public double Flight_range
        {
            set
            {
                if (value < 50)
                {
                    throw new Exception("Компания не осущевляет такие рейсы");
                }
                flight_range = value;

            }
            get
            {
                return flight_range;
            }
        }
        public uint Weight
        {
            set
            {
                if (value > max_weight)
                {
                    throw new Exception("Слишком много груза для рейса");
                }
                weight = value;
            }
            get
            {
                return weight;
            }
        }
        public uint Passengers
        {
            set
            {
                if (value > 350)
                {
                    throw new Exception("Столько пассажиров не может лететь");
                }
                passengers = value;
            }
            get
            {
                return passengers;
            }
        }
        public string Name_plane
        {
            set
            {
                if (value.Trim().Length <= 1)
                {
                    throw new Exception("Такого вида самолета не может быть");
                }
                name_plane = value;
            }
            get
            {
                return name_plane;
            }
        }
        public string pilot1
        {
            set
            {
                string s = value.Trim();
                Regex regex = new Regex(@"[А-ЯA-Z]{1}[a-zа-я]{1,15}\s[А-ЯA-Z]{1}[a-zа-я]{1,15}\s[А-ЯA-Z]{1}[a-zа-я]{1,15}");

                if (regex.IsMatch(s))
                {
                    Pilot1 = value;
                }
                else
                {
                    throw new Exception("Неверное ФИО");
                }
            }
            get
            {
                return Pilot1;
            }
        }
        public string kapitan
        {
            set
            {
                string s = value.Trim();
                Regex regex = new Regex(@"[А-ЯA-Z]{1}[a-zа-я]{1,15}\s[А-ЯA-Z]{1}[a-zа-я]{1,15}\s[А-ЯA-Z]{1}[a-zа-я]{1,15}");
                if (regex.IsMatch(s))
                {
                    Kapitan = value;
                }
                else
                {
                    throw new Exception("Неверное ФИО");
                }
            }
            get
            {
                return Kapitan;
            }
        }
        public string pilot2
        {
            set
            {
                string s = value.Trim();
                Regex regex = new Regex(@"[А-ЯA-Z]{1}[a-zа-я]{1,15}\s[А-ЯA-Z]{1}[a-zа-я]{1,15}\s[А-ЯA-Z]{1}[a-zа-я]{1,15}");
                if (regex.IsMatch(s))
                {
                    Pilot2 = value;
                }
                else
                {
                    throw new Exception("Неверное ФИО");
                }
            }
            get
            {
                return Pilot2;
            }
        }
        public string stuardesa
        {
            set
            {
                string s = value.Trim();
                Regex regex = new Regex(@"[А-ЯA-Z]{1}[a-zа-я]{1,15}\s[А-ЯA-Z]{1}[a-zа-я]{1,15}\s[А-ЯA-Z]{1}[a-zа-я]{1,15}");
                if (regex.IsMatch(s))
                {
                    Stuardesa = value;
                }
                else
                {
                    throw new Exception("Неверное ФИО");
                }
            }
            get
            {
                return Stuardesa;
            }
        }
        public Flight()
        {
        }
        public Flight(string DestinationParam, string StopParam, double RangeParam, uint WeightParam, uint PassengersParam, string NameParam, string pilot_one, string pilot_two, string kapitan_plane, string stuardesa_plane, int idd, string StatuS)
        {
            Destination_Point = DestinationParam;
            Stop_point = StopParam;
            Flight_range = RangeParam;
            Weight = WeightParam;
            Passengers = PassengersParam;
            Name_plane = NameParam;
            pilot1 = pilot_one;
            pilot2 = pilot_two;
            kapitan = kapitan_plane;
            stuardesa = stuardesa_plane;
            ID = idd;
            Status = StatuS;
        }
    }
   
    
}

