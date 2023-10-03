using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Cinema
    {
        private Cinema cine;
        private List<Film> lesFilms;
        private List<Acteur> lesActeurs;

        public Cinema()
        {
            this.lesFilms= new List<Film>();
            this.lesActeurs= new List<Acteur>();
        }

        public List<Film> LesFilms
        {
            get { return this.lesFilms; }
            set { this.lesFilms = value; }
        }

        public List<Acteur> LesActeur
        {
            get { return this.lesActeurs; }
            set { this.lesActeurs = value; }
        }



        public Cinema(Cinema cine )
        { this.cine = cine; }

        public Cinema getInstance()
        {
            Cinema monCinema = new Cinema();
            return monCinema;
        }

      

        public Acteur getActeur(int idActeur)
        {
            Acteur v = new Acteur();
            foreach(Acteur a in lesActeurs)
            {
                if(a.getId==idActeur)
                {
                    v = a;
                }
            }
            return v;
        }

        public Film getFilm(int idFilm)
        {   Film v = new Film();
            foreach(Film f in lesFilms)
            {
                if(f.getIdFilm==idFilm)
                {
                    v = f;
                }
            }
            return v;
        }
        public int nbActeurs()
        {
           return  this.lesActeurs.Count();
        }
        public int nbFilms()
        {
            return this.lesFilms.Count();
        }

        public void setFilm(int idFilm, string titre,string genre,string resume,int annee, Acteur acteurPrincipal)
        {
            Film f2 = new Film(idFilm, titre, genre, resume,annee,acteurPrincipal);
            this.lesFilms.Add(f2);
        }

        public void setActeur(Acteur act)
        {
            this.lesActeurs.Add(act);

        }
    }   
}
