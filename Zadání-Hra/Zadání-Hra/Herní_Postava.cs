using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadání_Hra
{
    public class Herní_Postava
    {
        protected string jmeno;
        public int level = 1;
        public double poziceX = 0;
        public double poziceY = 0;

        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                if (value.Length > 10)
                {
                    MessageBox.Show("Příliš dlouhé jméno");
                }
                else
                {
                    this.jmeno = value;
                }
            }
        }

        public double PoziceX
        {
            get { return poziceX;}
        }

        public double PoziceY
        {
            get { return poziceY;}
        }

        public Herní_Postava(string jmeno)
        {
            Jmeno = jmeno;
        }

        public void ZmenaPozice()
        {
            this.poziceX = 0;
            this.poziceY = 0;
        }

        public override string ToString()
        {
            string s = "Jméno: " + Jmeno
                     + "\nLevel: " + this.level
                     + "\nPozice X: " + PoziceX
                     + "\nPozice Y: " + PoziceY;
            return base.ToString();
        }
    }
}
