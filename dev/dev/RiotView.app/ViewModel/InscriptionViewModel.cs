using RiotView.app.Abstract;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RiotView.app.ViewModel
{
    public class InscriptionViewModel : ViewModelBase
    {

#region variables
        public string _pseudo;
        public string _mdp;
        public string _date;
        public string _mdpConfirmation;
        public Manager gestion;
        public bool _sexe;
        public DateTime m_AvailableFrom;
        #endregion
        #region constructeur
        public InscriptionViewModel()
        {
            gestion = new Manager();
        }
        #endregion
#region commandes
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
        public void OuvrirInscription()
        {
            if(_pseudo == null)
            {
                MessageBox.Show("Pseudo manquant");
                return;
            }
            if (_mdp == null)
            {
                MessageBox.Show("Mot de passe manquant");
                return;
            }
            if (_mdpConfirmation == null)
            {
                MessageBox.Show("Mot de passe de confirmation manquant");
                return;
            }

            if (SingletonUtilisateur.Instance.listeUtilisateur.ContainsKey(_pseudo))
            {
                MessageBox.Show("Pseudo deja utilisé", "Erreur", MessageBoxButton.OK);
                return;
            }
                if(_mdp != _mdpConfirmation)
            {
                MessageBox.Show("Mot de passe different", "Erreur", MessageBoxButton.OK);
                return;
            }
           
            SingletonUtilisateur.Instance.listeUtilisateur = gestion.AjouterUtilisateur(SingletonUtilisateur.Instance.listeUtilisateur, _pseudo,(bool)_sexe, m_AvailableFrom.ToString(), _mdp);
            MessageBox.Show("Confirmation reussi", "Confirmation", MessageBoxButton.OK);
            _pseudo = "";
            _mdp = "";
            _mdpConfirmation = "";
            NotifyPropertyChanged("Pseudo");
            NotifyPropertyChanged("MDP");
            NotifyPropertyChanged("MDPConfirmation");


        }
        #endregion
#region Binding
        public bool Sexe
        {
            get { return _sexe; }
            set
            {
                _sexe = value;
                
                NotifyPropertyChanged("Sexe");
            }
        }
        public string Pseudo
        {
            get
            {
                return _pseudo;
            }
            set
            {
                _pseudo = value;
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
            }
        }
        public string MDPConfirmation
        {
            get
            {
                return _mdpConfirmation;
            }
            set
            {
                _mdpConfirmation = value;
            }
        }
        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        public DateTime AvailableFrom
        {
            get
            {

                if (m_AvailableFrom == DateTime.MinValue)
                    return DateTime.Now;

                return m_AvailableFrom;
            }
            set
            {
                m_AvailableFrom = value;
            }
        }
#endregion
    }
}
