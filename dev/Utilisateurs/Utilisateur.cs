using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilisateurs
{
    [Serializable]
    public class Utilisateur
    {
           public string Pseudo { get; set; }
           public string Mdp { get; set; }
           public string Date { get; set; }
           public bool Sexe { get;  set; }
           public bool Administrateur { get; set; }


        public Utilisateur(string Pseudo,bool  Sexe, string Date, string Mdp)
        {
            this.Pseudo = Pseudo;
            this.Sexe = Sexe;
            this.Date = Date;
            this.Mdp = Mdp;
            Administrateur = false;
        }
        public void ModifiersInformation(string Pseudo, string Mdp, string Date, bool Sexe)
        {
            this.Pseudo = Pseudo;
            this.Sexe = Sexe;
            this.Date = Date;
            this.Mdp = Mdp;
        }

    }
  
}
