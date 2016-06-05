using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_376__Zduduj_dom_2._0_
{
    class Outside:Location
    {
        public Outside(string name,bool hot)
            :base(name)
        {
            this.hot = hot;

            switch (hot)
            {
                case true:
                    temperature = "Ale tu gorąco!\r\n\r\n";
                    break;
                case false:
                    temperature = "Tu nie jest gorąco.\r\n\r\n";
                    break;
            }
            switch (Name)
            {
                case "Ogród":
                    decoration = "małą drewnianą szopę (przechowalnie do winka i ogórków) i oczko wodne.\r\n\r\n";
                    break;
                case "Podjazd":
                    decoration = "garaż, troche za mały jak ale da rade.\r\n\r\n";
                    break;
                case "Podwórko przed domem":
                    decoration = "troche zapuszczony trawnik i skrzata, jednego bo drugiego sąsiedzi zakosili.\r\n\r\n";
                    break;
                case "Podwórko za domem":
                    decoration = "ogródek Mamy o którym tak marzyła:) a w nim ogórki koperek i czosnek na... ogórki;).\r\n\r\n";
                    break;

            }
            }

        private bool hot;
        private string temperature;
        private string decoration;
        public override string Description
        {
            get
            {
                return   base.Description + temperature + "W pobliżu widać " + decoration;
            }
        }

    }
}
