using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Acteur
    {
        private int id;
        private string nom;
        private string prenom;
        private string anneeNaissance;


        public Acteur() { }
        public Acteur(int id, string nom, string prenom, string anneeNaissance)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.anneeNaissance = anneeNaissance;
        }

        public int getId
        {
            get { return id; }
            set { id = value; }
        }

        public string getNom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string getPrenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string getAneeNaissance
        { 
            get { return anneeNaissance; }
            set { anneeNaissance = value; }
        }

        public Acteur getInstance()
        {
            Acteur acteur = new Acteur();
            return acteur;
        }

        public override string ToString()
        {
            return $"Id : {this.id}, Nom : {this.nom}, Prénom :{this.prenom}, Année de naissance :{this.anneeNaissance}";
        }


    }
}
