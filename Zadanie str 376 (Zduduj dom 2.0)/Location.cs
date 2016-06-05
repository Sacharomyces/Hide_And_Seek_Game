using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_376__Zduduj_dom_2._0_
{
    abstract class Location
    {
        public Location(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
        public Location[] Exits;

        public virtual string Description
        {
            get
            {
                string description = "Stoisz w: " + Name + ".\r\n\r\nWidzisz przejścia do:  ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += "" + Exits[i].Name;
                    if (i != Exits.Length - 1)
                        description += " , ";
                }
                description += ".\r\n\r\n";

                return description;
            }

        }
    }
}