using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Car_Garage
{
    internal interface Interface2
    {
        public int CompareTo(object? obj)
        {
            return _name.CompareTo(obj as Car);
        }
    }
}
