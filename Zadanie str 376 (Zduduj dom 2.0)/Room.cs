using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_376__Zduduj_dom_2._0_
{
    class Room:Location
    {
        public Room(string name)
            : base(name)
        {
            switch (Name)
            {
                case "Salon":
                    decoration = "kominek i dużą kanapę żeby się wnuki pomieściły przed telewizorem.";
                    break;
                case "Jadalnia":
                    decoration = "duży rodzinny stół z mnóstwem pysznych dań.";
                    break;
                case "Kuchnia":
                    decoration = "piramidka w zlewie i latającą Mamę.";
                    break;
                case "Schody":
                    decoration = "Fiefunie na czatach.";
                    break;
                case "Hol na piętrze":
                    decoration = "obrazy Gapy i duuużo naszych wspólnych zdjęć.";
                    break;
                case "Duża sypialnia":
                    decoration = "ogromne łóżko dla wszystkich zwierzaków (i Mamy jak się zmieści).";
                    break;
                case "Mała sypialnia":
                    decoration = "moje dzięcięce łóżko i inne dobra \"których nie można przecież wyrzucić\"";
                    break;
                case "Łazienka":
                    decoration = "zlew i prysznic, duuuuuża wanna, sporo świeczek, tylko tak jakos kuchni do tego brak.";
                    break;
            }
        }
        private string decoration;
        public override string Description
{
	get 
	{ 
		 return base.Description+"Przed sobą widzisz "+decoration+ ".\r\n\r\n";
	}
}

    }
}
