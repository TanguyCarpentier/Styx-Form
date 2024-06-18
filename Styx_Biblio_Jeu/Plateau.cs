using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styx_Biblio_Jeu
{
    public class Plateau
    {
        public string[,] tab; // Grille du labyrinthe
        private int[,] pile; // Initialisation de la pile qui contiendra toutes les coordonnées des cases visitées
        int comptPile = 0; // Initialisation du compteur de la pile
        public int compArtefact = 0;
        public int compFlamme = 0;
        int compteurPorte = 0; // Initialisation du compteur de porte
        int comptVisiteur = 0;// Initialisation du compteur du tableau visiteur
        private int[,] tabVisiteurs; // Initialisation du tableau visiteur qui contiendra toutes les coordonnées des cases visités
        public int Hauteur; // Hauteur du labyrinthe
        public int Largeur; // Largeur du labyrinthe
        private Random random = new Random(); // Générateur de nombres aléatoires

        // Constructeur initialisant la grille du labyrinthe avec sa taille
        public Plateau(int height, int width)
        {
            this.Hauteur = height;
            this.Largeur = width;
            tab = new string[400, 400]; // Initialisation de la grille
            pile = new int[400, 2];
            tabVisiteurs = new int[5000, 2];
        }

        // Méthode pour générer le labyrinthe
        public void Generatelaby()
        {

            // Initialiser le labyrinthe avec des murs
            Initializelaby();

            // Commencer le parcours en profondeur 
            parcourProfondeur(1, 1);
            creationPorteAleatoire();
            creationflammeAleatoire();
            creationdashAleatoire();
            creationlyreAleatoire();
            creationmultAleatoire();
            creationbouclierAleatoire();
            creationcoeurAleatoire();
            creationvitesseAleatoire();
            creationbalanceAleatoire();
            creationfloconAleatoire();
            //affichage des statistiques 
            Console.WriteLine($"nombre de portes : {compteurPorte}");
            Console.WriteLine($"pourcentage de portes : {compteurPorte * 100 / (760)}%");
            Console.WriteLine($"nombre de murs : {760 - compteurPorte}");
            Console.WriteLine($"pourcentage de murs : {100 - (compteurPorte * 100 / (760))}%");
        }

        // Méthode pour initialiser le labyrinthe avec des murs
        //Aucun paramètre
        //Aucun return
        //Affiche un quadriallage dans la console
        private void Initializelaby()
        {
            for (int hauteur = 0; hauteur < 40 + 1; hauteur++)
            {
                if (hauteur % 2 == 0)
                {
                    tab[hauteur, 0] = "+";
                    for (int largeur = 1; largeur < 40; largeur += 2)
                    {

                        tab[hauteur, largeur] = "---";
                        tab[hauteur, largeur + 1] = "+";
                    }
                }
                if (hauteur % 2 != 0)
                {
                    tab[hauteur, 0] = "|";
                    for (int largeur = 1; largeur < 40; largeur += 2)
                    {
                        tab[hauteur, largeur] = "esp";
                        tab[hauteur, largeur + 1] = "|";
                    }
                }
            }
        }
        private void parcourProfondeur(int ligne, int colonne)
        {
            int flag = 0;
            //0 correspond à aucune case visité 
            //1 correspond à 1 nouvelle case visité

            tabVisiteurs[0, 0] = ligne; // initialisation de la premiere case dans le tableau visiteur
            tabVisiteurs[0, 1] = colonne;
            comptVisiteur++; //compteur des visiteur
            pile[0, 0] = ligne; // Initialisation de la première case dans la pile
            pile[0, 1] = colonne;
            comptPile++;

            do
            {
                int[] directions = { 0, 1, 2, 3 };// Déclaration d'un tableau contenant les directions possibles
                melangeTableau(directions); // Mélanger l'ordre des directions

                //boucle qui traite les éléments du tableau directions 
                //"direction" est une variable qui prend une valeur de "directions" à chaque incrémentation
                foreach (int direction in directions)
                {
                    flag = 0;
                    int newLigne = 0;
                    int newColonne = 0;
                    int CoordonnéeVoisinLigne = 0;
                    int CoordonnéeVoisinColonne = 0;

                    //selon la valeur de la variable direction (0, 1, 2, 3) alors le parcour prend une direction différente
                    switch (direction)
                    {
                        case 0: // gauche
                            newLigne = ligne;
                            newColonne = colonne - 1;
                            CoordonnéeVoisinLigne = ligne;
                            CoordonnéeVoisinColonne = colonne - 2;
                            break;
                        case 1: // droite
                            newLigne = ligne;
                            newColonne = colonne + 1;
                            CoordonnéeVoisinLigne = ligne;
                            CoordonnéeVoisinColonne = colonne + 2;
                            break;
                        case 2: // bas
                            newLigne = ligne + 1;
                            newColonne = colonne;
                            CoordonnéeVoisinLigne = ligne + 2;
                            CoordonnéeVoisinColonne = colonne;
                            break;
                        case 3: // haut
                            newLigne = ligne - 1;
                            newColonne = colonne;
                            CoordonnéeVoisinLigne = ligne - 2;
                            CoordonnéeVoisinColonne = colonne;
                            break;
                    }
                    //on vérifie qu'on ne sort pas du labyrinthe
                    if (Bordure(newLigne, newColonne))
                    {
                        bool visiteurNonPresent = true;

                        //on vérifie que l'ont ne passe pas dans un case déjà visité
                        for (int parcourTabVisiteurs = 0; parcourTabVisiteurs < 5000; parcourTabVisiteurs++)
                        {
                            if (tabVisiteurs[parcourTabVisiteurs, 0] == CoordonnéeVoisinLigne && tabVisiteurs[parcourTabVisiteurs, 1] == CoordonnéeVoisinColonne)
                            {
                                visiteurNonPresent = false;
                                break;
                            }
                        }

                        //si la case que l'ont souhaite visiter est sur la même ligne (le mur est vertical)
                        if (visiteurNonPresent && tab[newLigne, newColonne] == "|")
                        {
                            //on retire le mur pour le remplacer par une porte
                            tab[newLigne, newColonne] = " ";

                            //on rajoute dans la pile la case dans laquel on vas 
                            pile[comptPile, 0] = CoordonnéeVoisinLigne;
                            pile[comptPile, 1] = CoordonnéeVoisinColonne;

                            //on rajoute la case dans la table des voisins aussi
                            tabVisiteurs[comptVisiteur, 0] = CoordonnéeVoisinLigne;
                            tabVisiteurs[comptVisiteur, 1] = CoordonnéeVoisinColonne;

                            //on incrémente le curseur de la pile et celui de la table des visiteurs
                            comptPile++;
                            comptVisiteur++;

                            //prochaine case devient la nouvelle case actuelle 
                            ligne = CoordonnéeVoisinLigne;
                            colonne = CoordonnéeVoisinColonne;

                            //on indique que l'on a trouver et changer de case
                            flag = 1;
                            //on incrémente le compteur de portes
                            compteurPorte++;


                        }
                        //si la case que l'ont souhaite visiter est sur la même ligne (le mur est horizontal)
                        if (visiteurNonPresent && tab[newLigne, newColonne] == "---")
                        {
                            //on retire le mur pour le remplacer par une porte
                            tab[newLigne, newColonne] = "   ";

                            //on rajoute la case suivante dans la pile et la table des voisins 
                            pile[comptPile, 0] = CoordonnéeVoisinLigne;
                            pile[comptPile, 1] = CoordonnéeVoisinColonne;
                            tabVisiteurs[comptVisiteur, 0] = CoordonnéeVoisinLigne;
                            tabVisiteurs[comptVisiteur, 1] = CoordonnéeVoisinColonne;

                            //on incrémente les curseurs de la pile et de la table des visiteurs 
                            comptPile++;
                            comptVisiteur++;

                            //prochaine case devient la nouvelle case actuelle 
                            ligne = CoordonnéeVoisinLigne;
                            colonne = CoordonnéeVoisinColonne;

                            //on indique que l'on a trouver et changer de case
                            flag = 1;

                            //on incrémente le compteur de portes
                            compteurPorte++;
                        }

                    }
                    if (flag == 1)
                    {
                        break; // Sortir de la boucle foreach si flag = 1 ce qui veut dire qu'une nouvelle case a été visitée
                    }

                }
                if (flag == 0) // Si aucune case n'a été visitée, nous remontons dans la pile pour chercher les coordonnées de la case précédente.
                {
                    ligne = pile[comptPile - 2, 0];// on reprend les coordonnées de la case précédente
                    colonne = pile[comptPile - 2, 1];
                    pile[comptPile - 2, 0] = 0;// on suprimme les coordonnées de la case précédente
                    pile[comptPile - 2, 1] = 0;
                    comptPile--; //Décrémentation du compteur, car nous avons enlevé une case à notre pile
                }
            } while (comptVisiteur < 400); // Le programme fonctionne tant que toutes les cases n'ont pas été visitées.


        }
        //le sous programme creationPorteAleatoire permet de rajouter des portes apres la génération en profondeur
        //Aucun paramètre
        //Aucun return
        //modification du quadriallage pour rajouter plus de porte dans le labyrinthe
        private void creationPorteAleatoire()
        {
            for (int parcourHauteur = 1; parcourHauteur < Hauteur - 2; parcourHauteur += 2)
            {
                int flag = 0;
                do
                {
                    //tableau qui possède toutes les valeur ou il y a possiblement un mur
                    int[] listeMurs = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38 };

                    //on choisie un des murs aléatoirement 
                    melangeTableau(listeMurs);

                    foreach (int mur in listeMurs)
                    {
                        //on retire le premier élément de la liste aléatoire et on sort de la boucle
                        if (tab[parcourHauteur, mur] == "|")
                        {
                            tab[parcourHauteur, mur] = " ";
                            flag++;
                            compteurPorte++;
                        }
                        if (flag == 2)
                        {
                            break; // Sortir de la boucle foreach si le flag est égale à 1
                        }

                    }
                    foreach (int direction in listeMurs)
                    {
                        //on retire le premier élément de la liste aléatoire et on sort de la boucle
                        if (tab[parcourHauteur + 1, direction + 1] == "---")
                        {
                            tab[parcourHauteur + 1, direction + 1] = "   ";
                            flag++;
                            compteurPorte++;
                        }
                        if (flag == 4)
                        {
                            break; // Sortir de la boucle foreach si le flag est égale à 2
                        }

                    }
                    // Sortir de la boucle while si le flag est égale à 2 (on a retirer 2 murs par ligne)
                } while (flag != 4);


            }
        }
        private void creationflammeAleatoire()
        {
            for (int parcourHauteur = 1; parcourHauteur < Hauteur - 2; parcourHauteur += 2)
            {
                int flag = 0;
                do
                {
                    //tableau qui possède toutes les valeur ou il y a possiblement des espaces
                    int[] listeflamme = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };

                    //on choisie un des murs aléatoirement 
                    melangeTableau(listeflamme);

                    foreach (int flamme in listeflamme)
                    {
                        //on retire le premier élément de la liste aléatoire et on sort de la boucle
                        if (tab[parcourHauteur, flamme] == "esp")
                        {
                            tab[parcourHauteur, flamme] = "fla";
                            flag++;
                            compFlamme++;
                        }
                        if (flag == 4)
                        {
                            break; // Sortir de la boucle foreach si le flag est égale à 1
                        }

                    }
                } while (flag != 4);


            }
        }

        private void creationdashAleatoire()
        {


            int[] tableau = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };
            Random random = new Random();
            int indiceAleatoire = random.Next(tableau.Length);
            int nombreAleatoire = tableau[indiceAleatoire];
            int flag = 0;
            do
            {
                //tableau qui possède toutes les valeur ou il y a possiblement des espaces
                int[] listeMurs = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };

                //on choisie un des murs aléatoirement 
                melangeTableau(listeMurs);

                foreach (int flamme in listeMurs)
                {
                    //on retire le premier élément de la liste aléatoire et on sort de la boucle
                    if (tab[nombreAleatoire, flamme] == "esp")
                    {
                        tab[nombreAleatoire, flamme] = "dash";
                        flag++;
                        compArtefact++;
                    }
                    if (flag == 1)
                    {
                        break; // Sortir de la boucle foreach si le flag est égale à 1
                    }

                }
            } while (flag != 1);
        }
        private void creationlyreAleatoire()
        {

            for (int i = 0; i < 4; i++)
            {
                int[] tableau = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };
                Random random = new Random();
                int indiceAleatoire = random.Next(tableau.Length);
                int nombreAleatoire = tableau[indiceAleatoire];
                int flag = 0;
                do
                {
                    //tableau qui possède toutes les valeur ou il y a possiblement des espaces
                    int[] listeMurs = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };

                    //on choisie un des murs aléatoirement 
                    melangeTableau(listeMurs);

                    foreach (int flamme in listeMurs)
                    {
                        //on retire le premier élément de la liste aléatoire et on sort de la boucle
                        if (tab[nombreAleatoire, flamme] == "esp")
                        {
                            tab[nombreAleatoire, flamme] = "lyre";
                            flag++;
                            compArtefact++;
                        }
                        if (flag == 1)
                        {
                            break; // Sortir de la boucle foreach si le flag est égale à 1
                        }

                    }
                } while (flag != 1);
            }
        }
        private void creationmultAleatoire()
        {

            for (int i = 0; i < 3; i++)
            {
                int[] tableau = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };
                Random random = new Random();
                int indiceAleatoire = random.Next(tableau.Length);
                int nombreAleatoire = tableau[indiceAleatoire];
                int flag = 0;
                do
                {
                    //tableau qui possède toutes les valeur ou il y a possiblement des espaces
                    int[] listeExp = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };

                    //on choisie un des murs aléatoirement 
                    melangeTableau(listeExp);

                    foreach (int flamme in listeExp)
                    {
                        //on retire le premier élément de la liste aléatoire et on sort de la boucle
                        if (tab[nombreAleatoire, flamme] == "esp")
                        {
                            tab[nombreAleatoire, flamme] = "exp";
                            flag++;
                            compArtefact++;
                        }
                        if (flag == 1)
                        {
                            break; // Sortir de la boucle foreach si le flag est égale à 1
                        }

                    }
                } while (flag != 1);
            }
        }
        private void creationbouclierAleatoire()
        {

            for (int i = 0; i < 2; i++)
            {
                int[] tableau = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };
                Random random = new Random();
                int indiceAleatoire = random.Next(tableau.Length);
                int nombreAleatoire = tableau[indiceAleatoire];
                int flag = 0;
                do
                {
                    //tableau qui possède toutes les valeur ou il y a possiblement des espaces
                    int[] listeBouclier = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };

                    //on choisie un des murs aléatoirement 
                    melangeTableau(listeBouclier);

                    foreach (int flamme in listeBouclier)
                    {
                        //on retire le premier élément de la liste aléatoire et on sort de la boucle
                        if (tab[nombreAleatoire, flamme] == "esp")
                        {
                            tab[nombreAleatoire, flamme] = "bou";
                            flag++;
                            compArtefact++;
                        }
                        if (flag == 1)
                        {
                            break; // Sortir de la boucle foreach si le flag est égale à 1
                        }

                    }
                } while (flag != 1);
            }
        }
        private void creationcoeurAleatoire()
        {

            for (int i = 0; i < 1; i++)
            {
                int[] tableau = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };
                Random random = new Random();
                int indiceAleatoire = random.Next(tableau.Length);
                int nombreAleatoire = tableau[indiceAleatoire];
                int flag = 0;
                do
                {
                    //tableau qui possède toutes les valeur ou il y a possiblement des espaces
                    int[] listecoeur = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };

                    //on choisie un des murs aléatoirement 
                    melangeTableau(listecoeur);

                    foreach (int flamme in listecoeur)
                    {
                        //on retire le premier élément de la liste aléatoire et on sort de la boucle
                        if (tab[nombreAleatoire, flamme] == "esp")
                        {
                            tab[nombreAleatoire, flamme] = "coe";
                            flag++;
                            compArtefact++;
                        }
                        if (flag == 1)
                        {
                            break; // Sortir de la boucle foreach si le flag est égale à 1
                        }

                    }
                } while (flag != 1);
            }
        }
        private void creationvitesseAleatoire()
        {

            for (int i = 0; i < 3; i++)
            {
                int[] tableau = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };
                Random random = new Random();
                int indiceAleatoire = random.Next(tableau.Length);
                int nombreAleatoire = tableau[indiceAleatoire];
                int flag = 0;
                do
                {
                    //tableau qui possède toutes les valeur ou il y a possiblement des espaces
                    int[] listevitesse = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };

                    //on choisie un des murs aléatoirement 
                    melangeTableau(listevitesse);

                    foreach (int flamme in listevitesse)
                    {
                        //on retire le premier élément de la liste aléatoire et on sort de la boucle
                        if (tab[nombreAleatoire, flamme] == "esp")
                        {
                            tab[nombreAleatoire, flamme] = "vit";
                            flag++;
                            compArtefact++;
                        }
                        if (flag == 1)
                        {
                            break; // Sortir de la boucle foreach si le flag est égale à 1
                        }

                    }
                } while (flag != 1);
            }
        }
        private void creationbalanceAleatoire()
        {

            for (int i = 0; i < 1; i++)
            {
                int[] tableau = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };
                Random random = new Random();
                int indiceAleatoire = random.Next(tableau.Length);
                int nombreAleatoire = tableau[indiceAleatoire];
                int flag = 0;
                do
                {
                    //tableau qui possède toutes les valeur ou il y a possiblement des espaces
                    int[] listebalance = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };

                    //on choisie un des murs aléatoirement 
                    melangeTableau(listebalance);

                    foreach (int flamme in listebalance)
                    {
                        //on retire le premier élément de la liste aléatoire et on sort de la boucle
                        if (tab[nombreAleatoire, flamme] == "esp")
                        {
                            tab[nombreAleatoire, flamme] = "bal";
                            flag++;
                            compArtefact++;
                        }
                        if (flag == 1)
                        {
                            break; // Sortir de la boucle foreach si le flag est égale à 1
                        }

                    }
                } while (flag != 1);
            }
        }
        private void creationfloconAleatoire()
        {

            for (int i = 0; i < 2; i++)
            {
                int[] tableau = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };
                Random random = new Random();
                int indiceAleatoire = random.Next(tableau.Length);
                int nombreAleatoire = tableau[indiceAleatoire];
                int flag = 0;
                do
                {
                    //tableau qui possède toutes les valeur ou il y a possiblement des espaces
                    int[] listeflocon = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };

                    //on choisie un des murs aléatoirement 
                    melangeTableau(listeflocon);

                    foreach (int flamme in listeflocon)
                    {
                        //on retire le premier élément de la liste aléatoire et on sort de la boucle
                        if (tab[nombreAleatoire, flamme] == "esp")
                        {
                            tab[nombreAleatoire, flamme] = "flo";
                            flag++;
                            compArtefact++;
                        }
                        if (flag == 1)
                        {
                            break; // Sortir de la boucle foreach si le flag est égale à 1
                        }

                    }
                } while (flag != 1);
            }
        }
        //sous programme qui mélange un tableau
        //Paramètre :
        //-un tableau
        //Return :
        //-ce même tableau trié
        private void melangeTableau(int[] tabAleatoire)
        {
            for (int i = tabAleatoire.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = tabAleatoire[i];
                tabAleatoire[i] = tabAleatoire[j];
                tabAleatoire[j] = temp;
            }
        }
        //Sous programme qui vérifie que les coordonnées sont dans le quadrillage
        //Paramètre :
        //-ligne : ligne du tableau
        //-colonne : colonne du tableau
        //Return :
        //-un booléen
        private bool Bordure(int ligne, int colonne)
        {
            return ligne >= 1 && ligne < 40 && colonne >= 1 && colonne < 40;
        }
        //sous programme qui affiche l'intégralité du quadriallage
        public void affichage()
        {
            for (int i = 0; i < Hauteur; i++)
            {
                for (int j = 0; j < Largeur; j++)
                {
                    Console.Write(tab[i, j]); // Afficher chaque cellule
                }
                Console.WriteLine(); // Aller à la ligne pour la prochaine rangée
            }
        }
        public string AfficheCase(int ligne, int colonne)
        {
            return this.tab[colonne, ligne];
        }

    }
}