using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Casque
    {
        private string nom;
        private int protection;
        private int value;
        private Random random = new Random();

        public Casque (string nom,int value,int protection) {
            this.nom = nom;
            this.value = value;
            this.protection = protection;
        }
        public int GetProtection {
            get {
                return this.protection;
            }
        }
        public int GetValue
        {
            get
            {
                return this.value;
            }
        }
        public string ToString() {
            return string.Format("Votre casque {0} vaut {1} piece(s) d'or et possède {2} de protection", nom, value, protection);
        }
    }
}
