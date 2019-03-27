using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Personnage
    {
        private int agilite, chance, force,endurance, pointDeVie, pointDeVieMaximum;
        private string nom;
        private string etatSante;
        private Peuple peuple;
        private Class classe;
        private Mental mentalite;
        private Random random= new Random();
        private Arme arme;
        

        public Personnage(int agilite, int chance, int force,int endurance, int pointDeVieMaximum,Peuple peuple,Class classe,Mental mentalite, string nom) {
            this.agilite = agilite;
            this.chance = chance;
            this.force = force;
            this.endurance = endurance;
            this.etatSante = "ok";
            this.pointDeVieMaximum = pointDeVieMaximum;
            this.pointDeVie = pointDeVieMaximum;
            this.peuple=peuple;
            this.classe = classe;
            this.mentalite = mentalite;
            this.nom = nom;
            
        }
        public Personnage(string nom) {
            this.agilite = random.Next(6,15) ;
            this.chance = random.Next(6,15);
            this.force = random.Next(6, 15);
            this.endurance = random.Next(6, 15);
            this.etatSante = "ok";
            this.pointDeVieMaximum = random.Next(6, 15);
            this.pointDeVie = pointDeVieMaximum;
            this.peuple = (Peuple)random.Next(0, 8);
            this.classe = (Class)random.Next(0,3);
            this.mentalite = (Mental)random.Next(0,2);
            this.nom = nom;

        }
        public void Avancer(int direction) { }

        private void RecevoirCoup(int degats) {
            if (pointDeVie-degats<0){
                pointDeVie=0;
                Mourrir();
            }
            else{
                pointDeVie=pointDeVie-degats;
            }
        }
        private bool Toucher(Personnage adversaire) {
            double probaToucher=((Convert.ToDouble(agilite)+Convert.ToDouble(chance))/(Convert.ToDouble(adversaire.GetAgilite())+Convert.ToDouble(adversaire.GetChance())));
            if (probaToucher == 0) {
                if (chance < adversaire.GetChance())
                {
                    return false;
                }
                else {
                    return true;
                }
            }
            if (probaToucher > 1)
            {
                return true;
            }
            else {
                probaToucher = probaToucher * 10;
                Convert.ToInt32(probaToucher);
                int toucher = random.Next(0, 100);
                if (toucher <= probaToucher) {
                    return true;
                }
                else {
                    return false;
                }

            }
        }
        private int EvaluerDegats(Personnage adversaire){
            int degat = (force - adversaire.GetEndurance()+arme.GetDegats);
            return degat;

        }
        private void Frapper(Personnage adversaire,int degats) {
            adversaire.RecevoirCoup(degats);
        }
        public void Frapper(Personnage adversaire) {
            int degat;
            if (Toucher(adversaire) == true)
            {
                degat = EvaluerDegats(adversaire);
                Frapper(adversaire, degat);
                Console.WriteLine("{0} fait {1} degats à son adversaire !",nom,degat);
            }
            else
            {
                Console.WriteLine("{0},Vous avez raté la cible",nom);
            }
        }

        public void BoirePotion(Potions potion) {
            TypePotion type = potion.GetType();
            int pointDeViePotion = potion.GetPointDeVie();
            switch(type){
                case TypePotion.poison:
                    if (pointDeVie - pointDeViePotion <0)
                    {
                        pointDeVie = 0;
                        Mourrir();
                    }
                    else
                    {
                        pointDeVie = pointDeVie - pointDeViePotion;
                    }
                    this.etatSante = "Empoisonée";
                    break;
                case TypePotion.neutre:
                    if (pointDeVie + pointDeViePotion > pointDeVieMaximum)
                    {
                        pointDeVie = pointDeVieMaximum;
                    }
                    else
                    {
                        pointDeVie = pointDeVie + pointDeViePotion;
                    }
                    break;
                case TypePotion.antipoison:
                    if (pointDeVie + pointDeViePotion > pointDeVieMaximum)
                    {
                        pointDeVie = pointDeVieMaximum;
                    }
                    else
                    {
                        pointDeVie = pointDeVie + pointDeViePotion;
                    }
                    this.etatSante = "ok";
                    break;
            }
        }

        private void Mourrir() {
            Console.WriteLine("Argh c'est la fin pour moi... rip {0}",nom);
            
        }

        public bool EstVivant() {
            if (pointDeVie<=0){
                return false;
            }
            else {
                return true;
            }
        }
        public string ToString()
        {
            if (arme != null) {
                return string.Format("\nVotre {0} {1} est {7} possède {2} en force,{3} en chance et {4} en agilité.\nC'est un {5}, il peut avoir jusqu'a {6} point de vie maximum et actuellement il possède {8} point de vie.\n Actuellement l'etat de santé de {1} est {9}\nSon armes {10}, fait {11} de dégats et vaut {12}", peuple, nom, force, chance, agilite, classe, pointDeVieMaximum, mentalite, pointDeVie, etatSante, arme.GetNom, arme.GetDegats, arme.GetValue);
            }
            else
            {
                return string.Format("\nVotre {0} {1} est {7} possède {2} en force,{3} en chance et {4} en agilité.\nC'est un {5}, il peut avoir jusqu'a {6} point de vie maximum et actuellement il possède {8} point de vie.\n Actuellement l'etat de santé de {1} est {9}", peuple, nom, force, chance, agilite, classe, pointDeVieMaximum, mentalite, pointDeVie, etatSante);
            }
        }
        public int GetAgilite() { 
            return agilite;
        }
        public int GetForce()
        {
            return force;
        }
        public int GetEndurance()
        {
            return endurance;
        }
        public int GetChance()
        {
            return chance;
        }
        public int GetPointDeVieMax()
        {
            return pointDeVieMaximum;
        }
        public int GetPoinDeVie()
        {
            return pointDeVie;
        }
        public string GetClasse()
        {
            return string.Format("{0}",classe);
        }
        public string GetPeuple()
        {
            return string.Format("{0}",peuple);
        }
        public string GetMentalite()
        {
            return string.Format("{0}", mentalite);
        }
        public string GetNom
        {
            get{
                return this.nom;
            }
            set {
                this.nom= value ;
            }
        }
        public void SetArme(Arme arme){
            this.arme = arme;
        }
        
    }
}
