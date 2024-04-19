using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Zadání_Hra
{
    public class Hráč : Herní_Postava
    {
        string specializace;
        public int oblicej = 0 ;
        public int vlasy = 0;
        public int barvaVlasu = 0;
        public int XP = 0;
        public Hráč(string jmeno, string specializace, int oblicej, int vlasy, int barvaVlasu) : base(jmeno)
        {
            Specializace = specializace;
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barvaVlasu = barvaVlasu;
        }

        public string Specializace
        {
            get 
            { 
                return specializace; 
            }
            set 
            { 
                specializace = value; 
            }
        }
        public void PridejXP()
        {
            XP = level * 100;
        }
    }
}
