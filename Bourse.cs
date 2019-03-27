using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Bourse
    {
        private int or;
        public Bourse(int or)
        {
            if (or > 0)
            {
                this.or = or;
            }
        }
        public int GetOr{ 
            get {
                return this.or;
            }
        }
        public void Placer(int or1){
            or = or + or1;
        }
        public void Prendre(int or1)
        {
            if (or - or1 > 0)
            {
                or = or - or1;
            }
            else
            {
                or = 0;
            }
        }
        public string ToString() {
            return string.Format("Vous possédez {0} pièce(s) d'or", or);
        }
    }
}
