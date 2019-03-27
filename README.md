# SlawCrawler

Présentation du projet : le but est de réaliser un jeu de rôle permettent un jeu massivement multijoueur.

Les outils mis en oeuvre :
* git
* visual studio
* mysql
* apache

Le développement tourne autour de 3 grandes parties
1. L'inscription en ligne
2. Le développement du jeu en lui même permettant l'esploration d'un labyrinthe.
3. La sauvegarde des personnages et du contexte du jeu.

|Développement      |langages |Technique de programmation                               |
|-------------------|:-------:|---------------------------                              |
|Incription en ligne|php Mysql|développement web MVC avec CodeIgnite                    |
|sio crawler le jeu |c#       |programmation objet tests unitaires                      |
|sauvegarde du contexte |c#, Mysql|programmation procédural procédures stockées en mysql|

# L'inscription en ligne 
Site web permettant à un joueur de s'inscrire en ligne le projet prévoit suivant pour l'inscription en ligne.

![acteurFluxInscription.png](http://image.noelshack.com/fichiers/2018/37/3/1536761964-acteurfluxinscription.png)

# Sio crawler le jeu
le joueur possédera les fonctionnalités suivantes.

![useCasePersonnage.png](https://image.noelshack.com/fichiers/2018/37/3/1536762099-usecasepersonnage.png)

les classes developpées.

![diagrammeClassePersonnage.png](http://image.noelshack.com/fichiers/2018/37/3/1536762094-diagrammeclassepersonnage.png)

# Sauvegarde du contexte
La sauvgarde du contexte se fera dans la base de données.

![mcdSauvegarde.png](http://image.noelshack.com/fichiers/2018/37/3/1536762097-mcdsauvegarde.png)
