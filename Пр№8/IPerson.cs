using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_8
{
    interface IPerson
    {
        string Surname { get; set; }
        string Name { get; set; }
        string Print();
    }
}
