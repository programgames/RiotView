using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Champions;
using Service;
using Utilisateurs;
using System.IO;

namespace RiotView.app
{
    public sealed class SingletonUtilisateur
    {
        #region instanceObligatoireDeNosSingleton
        private static SingletonUtilisateur instance = null;
        private static readonly object padlock = new object();
        #endregion
        #region attribut
        public Manager gestion;
        public string index;
        public Dictionary<string, Utilisateur> listeUtilisateur;
        #endregion
        #region constructeur
        SingletonUtilisateur()
        {
            gestion = new Manager();



            listeUtilisateur = new Dictionary<string, Utilisateur>();
            listeUtilisateur = gestion.AjouterUtilisateur(listeUtilisateur, "SuppHerHard",true, "19/06/2017", "judoka43");
            listeUtilisateur = gestion.AjouterUtilisateur(listeUtilisateur, "juju", true, "19/06/2017", "judoka43");
            listeUtilisateur["juju"].Administrateur = true;


        }
        #endregion
        #region publicInstance
        public static SingletonUtilisateur Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonUtilisateur();
                    }
                    return instance;
                }
            }
        }
        #endregion
        #region propriete
        public void Sauvegarder()
    {
            gestion.Ecrire("Users.txt", listeUtilisateur);
       

    }
    public void ChargerUsers()
    {
        string fichier = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Users.txt");
        bool exist = File.Exists(fichier);

        if (exist)
        {
            listeUtilisateur = gestion.Lire<Dictionary<string,Utilisateur>>(fichier);
        }
    }
#endregion
    } //classe
}
