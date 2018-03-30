using RiotView.app.Abstract;
using System;
using System.Windows;
using System.Windows.Input;
using System.Data;    

namespace RiotView.app.ViewModel
{
    class EcranConnexionViewModel : ViewModelBase
    {
        #region variables
        string _pseudo;
        string _mdp;
        #endregion
        #region constructeur
        public EcranConnexionViewModel()
        {
            _pseudo = "Entrez votre pseudo";
            NotifyPropertyChanged("Pseudo");
            _mdp = "Entrer votre mot de passe";
            SingletonUtilisateur.Instance.ChargerUsers();
            //SingletonUtilisateur.Instance.ShowDialog["juju"].Administrateur = true;
            SingletonUtilisateur.Instance.listeUtilisateur["SuppHerHard"].Administrateur = true;
        }
        #endregion
        #region Binding
        public string Pseudo
        {
            get
            {
                return _pseudo;
            }
            set
            {

                _pseudo = value;

                NotifyPropertyChanged("Pseudo");

                ///System.Environment.Exit(1);

            }
        }
        public string MDP
        {
            get
            {
                return _mdp;
            }
            set
            {

                _mdp = value;

                NotifyPropertyChanged("MDP");

                ///System.Environment.Exit(1);

            }
        }
#endregion
        #region commandes
        private ICommand _CommandeInfo;
        public ICommand CommandeInfo
        {
            get
            {
                return _CommandeInfo ?? (_CommandeInfo = new CommandHandler(() => OuvrirInfo(),true));
            }
        }
        private ICommand _CommandeConnexion;
        public ICommand CommandeConnexion
        {
            get
            {
                return _CommandeConnexion ?? (_CommandeConnexion = new CommandHandler(() => OuvrirMenu(), true));
            }
        }
        private ICommand _CommandeInscription;
        public ICommand CommandeInscription
        {
            get
            {
                return _CommandeInscription ?? (_CommandeInscription = new CommandHandler(() => OuvrirInscription(), true));
            }
        }
        #endregion
        #region fonctions
        public void OuvrirInfo()
        {

            SingletonInfo.Instance.fenetre.Show();

        }
        
        public void OuvrirMenu()
        {

            if (SingletonUtilisateur.Instance.listeUtilisateur.ContainsKey(_pseudo))
                {
                   
                    if(SingletonUtilisateur.Instance.listeUtilisateur[_pseudo].Mdp == _mdp)
                {
                    SingletonConnecter.Instance.pseudo = _pseudo;
                    SingletonConnecter.Instance.admin = SingletonUtilisateur.Instance.listeUtilisateur[_pseudo].Administrateur;
                      SingletonMenu.Instance.fenetre._vm.NotifyPropertyChanged("IsVisible");
                    SingletonMenu.Instance.fenetre.Maj();
                    if (SingletonConnecter.Instance.admin)
                    {
                        MessageBox.Show("Administration activée");
                    }
                    
                    
                    SingletonConnecter.Instance.admin = SingletonUtilisateur.Instance.listeUtilisateur[_pseudo].Administrateur;
                   
                    SingletonMenu.Instance.fenetre.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect", "Erreur");
                }
               
            }
            else
            {
                MessageBox.Show("Utilisateur introuvable.","Erreur");
            }
        }

        public void OuvrirInscription()
        {

            SingletonInscription.Instance.fenetre.ShowDialog();
        }
#endregion

    }

}
