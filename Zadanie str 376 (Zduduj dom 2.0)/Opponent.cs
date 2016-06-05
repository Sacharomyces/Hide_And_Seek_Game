using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_376__Zduduj_dom_2._0_
{
    class Opponent
    {
        public Opponent (Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }
        private Location myLocation;

        private Random random;

        public void Move()
        {
           
            bool hidden = false;
            while (!hidden)
            {
                if (myLocation is IHasExteriorDoor)
                {
                    IHasExteriorDoor locationWithDoor = myLocation as IHasExteriorDoor;

                    if (random.Next(2) == 1)

                        myLocation = locationWithDoor.DoorLocation;
                }

                int i = random.Next(myLocation.Exits.Length);

                myLocation = myLocation.Exits[i];

                if (myLocation is IHidingPlace)
                {
                    hidden = true;
                }
            }

        }
        public bool Check(Location checkingLocation)
        {
            if (checkingLocation == myLocation)
                return true;
            else
                return false;
        }
    }
}
