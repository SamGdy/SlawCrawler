using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Personnage sam=new Personnage(20,15,9,6,60,Peuple.Hobbit,Class.Thief,Mental.Good,"Sam");
            Personnage azog = new Personnage(10, 9, 20, 18, 100, Peuple.Orc, Class.Fighter, Mental.evil, "Azog le Thug");
           

            Arme dague = new Arme("Dague", 5, 1, 4);
            Arme baton = new Arme("Baton", 10, 1, 5);
            Arme epeeCourte = new Arme("Short Sword", 15, 1, 6);
            Arme mace = new Arme("Mace", 30, 2, 6);
            Arme murasamaBlade = new Arme("Murasama Blade", 10000000, 10, 50);
            Arme [] tabArmes = new Arme[]{
                dague,baton,epeeCourte,mace,murasamaBlade };

            Armure robe = new Armure("Robe", 15, 1);
            Armure armCuir = new Armure("Armure de cuir", 50, 2);
            Armure cotteMail = new Armure("Cotte de mail", 90, 3);
            Armure[] tabArmure = new Armure[]{
                robe,armCuir,cotteMail
            };

            Casque casque = new Casque("casque simple", 100, 1);
            Casque [] tabCasque = new Casque[]{ casque };

            Bouclier petitBouclier = new Bouclier("Ptit Boubou", 20, 2);
            Bouclier grosBouclier = new Bouclier("Gros Boubou", 40, 3);
            Bouclier[] tabBouclier = new Bouclier[]{
                petitBouclier,grosBouclier
            };

            Gantelet ganteletCuivre = new Gantelet("de cuivre", 6000, 1);
            Gantelet ganteletArgent = new Gantelet("d'argent", 60000, 3);
            Gantelet[] tabGantelet = new Gantelet[]{
                ganteletCuivre,ganteletArgent
            };

            Potions poisonLegé = new Potions(2, TypePotion.poison);
            Potions antipoison = new Potions(2,TypePotion.antipoison);
            Potions grandePotion=new Potions (200,TypePotion.neutre);

            sam.SetArme(murasamaBlade);
            azog.SetArme(mace);
            Console.WriteLine(sam.ToString());
            bool samVie=sam.EstVivant(),azogVie=azog.EstVivant();

            while ( samVie== true && azogVie == true)
            {
                if (azogVie == true)
                {
                    sam.Frapper(azog);
                    azogVie = azog.EstVivant();
                }
                if (samVie == true)
                {
                    azog.Frapper(sam);
                    samVie = sam.EstVivant();
                }
            }
            Console.ReadLine();
        }

    }
}
