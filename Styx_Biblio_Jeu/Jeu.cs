namespace Styx_Biblio_Jeu
{
    public class Jeu
    {
        //propriétés
        public List<Ennemie> EnnemieList;

        public int score;
        public int nbArtefacts;
        public int nbEnemis;
        public int nbFlammeRestant;
        public int tempEcoule;
        public int niveauEnCour;
        public int TickSpeed;

        public Jeu()
        {

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
        public void MoveAllEnemies(Plateau ptab, Joueur joueur)
        {
            foreach (var ennemi in EnnemieList)
            {
                if (!ennemi.estMort)
                {
                    ennemi.Move(ptab, joueur);
                }
            }
        }

    }

}
