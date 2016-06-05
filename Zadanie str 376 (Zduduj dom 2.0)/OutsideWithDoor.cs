using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_376__Zduduj_dom_2._0_
{
    class OutsideWithDoor:Outside,IHasExteriorDoor,IHidingPlace
    {
        public OutsideWithDoor(string name, bool hot, string hidingPlace)
            : base(name, hot)
        {
            this.HidingPlace = hidingPlace;
        }
        public string DoorDescryption
        {
            get
            {
                if (Name == "Podwórko przed domem")

                    return "drzwi dębowe z mosiężną klamką.\r\n";

                else
                    return "drzwi suwane.\r\n";
            }
        }
        public override string Description
        {
            get
            {
                return base.Description + "Widzisz również " + DoorDescryption + "\r\n Możesz przez nie przejść.";
            }
        }


        public Location DoorLocation
        {
            get;
            set;
        }

        public string HidingPlace
        {
            get;
            
           
        }
    }
}
