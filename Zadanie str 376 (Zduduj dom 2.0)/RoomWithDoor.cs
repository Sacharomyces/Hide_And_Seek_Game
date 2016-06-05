using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_376__Zduduj_dom_2._0_
{
    class RoomWithDoor:Room,IHasExteriorDoor,IHidingPlace
    {
        public RoomWithDoor(string name, string hidingPlace):base(name)
             
        {
            HidingPlace = hidingPlace;

        }
       
        public string DoorDescryption
        {
            get
            {
                if (Name == "Salon")

                    return "drzwi dębowe z mosiężną klamką";
                else
                    return "drzwi suwane";
            }
        }

        public Location DoorLocation
        {
            get;
            set;
        }
        public override string Description
        {
            get
            {
                return base.Description + "Widzisz również "+ DoorDescryption+".\r\n\r\n Możesz przez nie przejść.";
            }
        }

        public string HidingPlace
        {
            get;
            
        }
    }

}
