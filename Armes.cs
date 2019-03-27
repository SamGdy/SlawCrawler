using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Arme
    {
        private string nom;
        private int degats;
        private int value;
        private Random random = new Random();

        public Arme (string nom,int value,int degatsMin,int degatsMax) {
            this.nom = nom;
            this.value = value;
            this.degats = random.Next(degatsMin, degatsMax);
        }
        public int GetDegats
        {
            get
            {
                return this.degats ;
            }
        }
        public int GetValue
        {
            get
            {
                return this.value;
            }
        }
        public string GetNom
        {
            get
            {
                return this.nom;
            }
        }
        public string ToString() {
            return string.Format("Votre arme {0} vaut {1} piece(s) d'or et fait {2} dégats", nom, value, degats);
        }
    }
}
