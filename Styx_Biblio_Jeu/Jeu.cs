namespace Styx_Biblio_Jeu
{
    public class Jeu
    {
        //propriétés
        public int score;
        public int nbArtefacts;
        public int nbEnemis;
        public int nbFlammeRestant;
        public int tempEcoule;
        public int niveauEnCour;

        public Jeu()
        {
            niveauEnCour = 0;
            score = 0;
            nbArtefacts = 0;
            nbEnemis = 0;
            nbFlammeRestant = 0;
            tempEcoule = 0;

            
        }

    }

}
