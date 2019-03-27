using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Potions
    {
        private int pointDeVie;
        private TypePotion type;
        private Random random = new Random();
        private string couleur;

        public Potions(int pointDeVie, TypePotion type)
        {
            int rand;
            this.pointDeVie = pointDeVie;
            if (type == TypePotion.poison)
            {
                this.type = TypePotion.poison;
                rand = random.Next(1, 10);
                if (rand < 9)
                {
                    this.couleur = "rouge";
                }
                else
                {
                    if (rand == 9)
                    {
                        this.couleur = "verte";
                    }
                    else
                    {
                        this.couleur = "bleu";
                    }
                }
            }
            if (type == TypePotion.antipoison)
            {
                this.type = TypePotion.antipoison;
                rand = random.Next(1, 10);
                if (rand < 9)
                {
                    this.couleur = "verte";
                }
                else
                {
                    if (rand == 9)
                    {
                        this.couleur = "rouge";
                    }
                    else
                    {
                        this.couleur = "bleu";
                    }
                }
            }
            if (type == TypePotion.neutre)
            {
                this.type = TypePotion.neutre;
                rand = random.Next(1, 10);
                if (rand < 9)
                {
                    this.couleur = "bleu";
                }
                else
                {
                    if (rand == 9)
                    {
                        this.couleur = "rouge";
                    }
                    else
                    {
                        this.couleur = "verte";
                    }
                }
            }
        }
        public int GetPointDeVie()
        {
            return this.pointDeVie;
        }
        public TypePotion GetType()
        {
            return this.type;
        }
        public string ToString() { 
            return string.Format("Cette potion est de couleur {0}, elle ajoute/enlève {1} point de vie.",couleur,pointDeVie);
        }
    }
}
