using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8
{
    class Child : IPerson, IComparable, ICloneable
    {
        public Child()
        {
            Name = null;
            Surname = null;
            MiddleName = null;
        }
        public string Name
        {
            get;set;
        }
        public string Surname
        {
            get;set;
        }
        public string MiddleName
        {
            get;set;
        }
        public string Print()
        {
            string inf = "Фамилия:" + Surname  + "\nИмя:" + Name + "\nОтчество:" + MiddleName;
            return inf;
        }
        public int CompareTo(Object obj)
        {
            Child temp = (Child)obj;
            if (this.Surname == temp.Surname) return 0;
            else return -1;
        }
        public Child ShallowClone()
        {
            return (Child)this.MemberwiseClone();
        }
        public object Clone()
        {
            Child name = new Child();
            name.Name = this.Name;
            name.Surname = this.Surname;
            name.MiddleName = this.MiddleName;
            return name;
        }
    }
}
