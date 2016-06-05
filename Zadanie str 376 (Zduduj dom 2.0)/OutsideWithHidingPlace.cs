using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_376__Zduduj_dom_2._0_
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public  OutsideWithHidingPlace (string name, bool hot, string hidingPlace)
            :base (name, hot)
        {
            this.HidingPlace = hidingPlace;
        }
        public string HidingPlace
        {
            get;
            
        }
    }
}
