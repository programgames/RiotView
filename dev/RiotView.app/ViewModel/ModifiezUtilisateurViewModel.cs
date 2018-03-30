using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotView.app.Abstract;
using Service;
using System.Windows.Input;

namespace RiotView.app
{
    class ModifiezUtilisateurViewModel : ViewModelBase
    {
        
        private Manager gestion;
        private string _nom;
        private string _mdp;
        private Utilisateurs.Utilisateur a;
        #region Constructeur
        public ModifiezUtilisateurViewModel()
        {
            gestion = new Manager();
            _nom = SingletonConnecter.Instance.pseudo;
            SingletonUtilisateur.Instance.listeUtilisateur.TryGetValue(SingletonConnecter.Instance.pseudo, out a);
            _mdp= a.Mdp;
        }
        #endregion

        private ICommand _CommandeSauver;
        public ICommand CommandeSauver
        {
            get
            {
                return _CommandeSauver ?? (_CommandeSauver = new CommandHandler(() => Save(), true));
            }
        }



        public String Nom
        {
            get{
                return _nom;
            }
            set
            {
                
                _nom =value;
                NotifyPropertyChanged("Nom");
            }
        }
        public String MotDePasse
        {
            get
            {
                return _mdp;
            }
            set
            {
                _mdp = value;
                NotifyPropertyChanged("MotDePasse");
            }
        }
        public void Save()
        {
            SingletonUtilisateur.Instance.listeUtilisateur.Remove(SingletonConnecter.Instance.pseudo);
            SingletonConnecter.Instance.pseudo = _nom;
            SingletonUtilisateur.Instance.listeUtilisateur.Add(_nom, new Utilisateurs.Utilisateur(_nom, a.Sexe, a.Date, _mdp));
            SingletonUtilisateur.Instance.Sauvegarder();
            SingletonModifutilisateur.Instance.fenetre.Close();
        }
        
    }
}
