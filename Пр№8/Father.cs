using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8
{
    class Father: IPerson, IComparable, ICloneable
    {
        public Father()
        {
            Name = null;
            Surname = null;
        }
        public string Name
        {
            get;set;
        }
        public string Surname
        {
            get;set;
        }
        public string Print()
        {
            string inf = "Фамилия:" + Surname + "\nИмя:" + Name;
            return inf;
        }
        public int CompareTo(Object obj)
        {
            Father temp = (Father)obj;
            if (this.Surname == temp.Surname) return 0;
            else return -1;
        }
        public Father ShallowClone()
        {
            return (Father)this.MemberwiseClone();
        }
        public object Clone()
        {
            Father name = new Father();
            name.Name = this.Name;
            name.Surname = this.Surname;
            return name;
        }
    }
}
