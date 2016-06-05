using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_376__Zduduj_dom_2._0_
{
    interface IHasExteriorDoor
    {
        
        string DoorDescryption
        {
            get;
        }
               
                
                
         Location DoorLocation { get; set; }
    }
}
