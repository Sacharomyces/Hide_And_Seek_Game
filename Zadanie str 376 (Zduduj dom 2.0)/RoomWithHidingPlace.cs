using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_376__Zduduj_dom_2._0_
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string hidingPlace)
            : base(name)
        {
            this.HidingPlace = hidingPlace;
        }

        public string HidingPlace
        {
            get;
                  
        }
    }

}
