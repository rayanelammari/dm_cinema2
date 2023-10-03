using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public  class Film
    {
        private int idFilm;
        private string titre;
        private string genre;
        private string resume;
        private int annee;
        private Acteur acteurPrincipal;

        public Film() { }

        public Film(int idFilm, string titre,string genre, string resume,int annee,Acteur acteurPrincipal)

        {
            this.idFilm = idFilm;
            this.titre = titre;
            this.genre = genre;
            this.resume = resume;
            this.annee = annee;
            this.acteurPrincipal= acteurPrincipal;
        }

        public int getAnnee
        {
            get { return annee; }
            set { annee = value; }
        }

        public string getGenre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int getIdFilm
        {
            get { return idFilm; }
            set { idFilm = value; }
        }

        public string getResume
        {
            get { return resume; }
            set { resume = value; }
        }

        public string getTitre
        {
            get { return titre; }
            set { titre = value; }
        }

        public Acteur getacteurPrincipal
        { 
            get { return acteurPrincipal; }
            set { acteurPrincipal = value; }
        }

        public Film getInstance()
        {
            Film film = new Film();
            return film;
        }

        public Acteur getActeurPrincipal()
        {
            return acteurPrincipal;
             
        }
        public override string ToString()
        {
            return $"Id Film : {this.idFilm}, Titre : {this.titre},genre : {this.genre}, resumé : {this.resume}, Année sortie : {this.annee}, Nom acteur : {this.acteurPrincipal.getNom},  Prénom : {this.acteurPrincipal.getPrenom}";
        }

    }
}

