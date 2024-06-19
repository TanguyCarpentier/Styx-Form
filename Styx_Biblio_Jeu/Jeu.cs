namespace Styx_Biblio_Jeu
{
    public class Jeu
    {
        //propriétés
        public List<Ennemie> EnnemieList;

        public string Pseudo;
        public int score;
        public int nbArtefacts;
        public int nbEnemis;
        public int nbFlammeRestant;
        public int tempEcoule;
        public int niveauEnCour;
        public int TickSpeed;

        public Jeu(string pseudo)
        {
            Pseudo = pseudo;
            niveauEnCour = 0;
            score = 0;
            nbArtefacts = 0;
            nbEnemis = 0;
            nbFlammeRestant = 0;
            tempEcoule = 0;
            TickSpeed = 300;
            EnnemieList = new List<Ennemie>();

        }
        public Jeu(int niveau, int Score, int NbArtefact, int NbEnemis, int NbFlammes, int TempEcoule, List<Ennemie> ListEnnemis)
        {

            niveauEnCour = niveau;
            score = Score;
            nbArtefacts = NbArtefact;
            nbEnemis = NbEnemis;
            nbFlammeRestant = NbFlammes;
            tempEcoule = TempEcoule;
            EnnemieList = ListEnnemis;
        }

        public void MajNbEntite(Plateau tab, int nbEnnemis)
        {
            nbFlammeRestant = tab.compFlamme;
            nbArtefacts = tab.compArtefact;
            nbEnemis = nbEnnemis;
        }

        public void passageNiveau()
        {
            niveauEnCour += 1;
        }


        public void MoveAllEnemies(Plateau ptab, Joueur joueur)
        {
            foreach (var ennemi in EnnemieList)
            {
                if (!ennemi.estMort)
                {
                    ennemi.Move(ptab, joueur, this);
                }
            }
        }

        public bool VerifFinJeu(Joueur joueur)
        {
            if (!joueur.estMort)
            {
                if (nbArtefacts == 0)
                {
                    if (nbFlammeRestant == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }

}
