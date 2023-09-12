using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérek2020
{
    internal class Bérek
    {
        string név;
        string neme;
        string részleg;
        int belépés;
        int bér;

        public string Név 
        { 
            get => név; 
            set => név = value; 
        }
        public string Neme 
        { 
            get => neme; 
            set => neme = value; 
        }
        public string Részleg 
        { 
            get => részleg; 
            set => részleg = value; 
        }
        public int Belépés 
        { 
            get => belépés; 
            set => belépés = value; 
        }
        public int Bér 
        { 
            get => bér; 
            set => bér=value; 
        }

        public Bérek(string név, string neme, string részleg, int belépés, int bér)
        {
            Név=név;
            Neme=neme;
            Részleg=részleg;
            Belépés=belépés;
            Bér=bér;
        }

        public Bérek(string beolvasottsor)
        {
            string[] strings=beolvasottsor.Split(';');
            Név=strings[0];
            Neme=strings[1];
            Részleg=strings[2];
            Belépés=int.Parse(strings[3]);
            Bér=int.Parse(strings[4]);
        }
    }
}
