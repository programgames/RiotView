using RiotView.app.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Service;
using Champions;
using System.Windows;

// ========================================================================
//
// Copyright (C) 2008-2009 IUT CLERMONT1 - UNIVERSITE D’AUVERGNE
// 
//
// Module : ViewModel du menu
// Author : Matthias Gaydu et Julien Marcon
// Creation date: 2017-08-20
//
// ======================================================================== 

namespace RiotView.app.ViewModel
{

    public class MenuViewModel : ViewModelBase
    {

#region variables

        private static MenuViewModel _instance = new MenuViewModel();
        public static MenuViewModel Instance { get { return _instance; } }





        string _rechercher;
        string _imageGauche;
        string _imageDroite;
        string _nom;
        private bool _IsVisible;
        private bool _isClick;
        

        bool canExecute = true;

        Manager gestion;

        public bool _canExecute;
        private ModifiezUtilisateur vueModif;



        private int index = 0;
        #endregion
#region constructeur
        public MenuViewModel()
        {
           
            NotifyPropertyChanged("IsVisible");
            _canExecute = true;
            IsVisible = true;

            _isClick = true;
           

            SingletonChampion.Instance._index = 0;
            gestion = new Manager();
            SingletonChampion.Instance.ChargerChampion();



            SingletonView.Instance._viewCreation = new Creation();

        }
        #endregion
#region Binding
        public int Index
        {
            get
            {
                return SingletonChampion.Instance._index;
            }
            set
            {
                SingletonChampion.Instance._index = value;
            }
        }
        
        public bool IsVisible
        {
            get
            {
                
                return SingletonConnecter.Instance.admin;
            }

            set
            {
                
                SingletonConnecter.Instance.admin = value;
               
                NotifyPropertyChanged("IsVisible");
            }
        }
        public List<Champion> ListeChampion
        {
            /*get => _listeChampion;*/
            get => SingletonChampion.Instance._listeChampionGlobale;
            set
            {
                /*  _listeChampion = value;*/
                SingletonChampion.Instance._listeChampionGlobale = value;
                NotifyPropertyChanged("ListeChampion");
            }
        }
        public string DisplayedImage
        {
            get
            {
                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Image;
            }
            set
            {

                /* _listeChampion[SingletonChampion.Instance._index].Image = value;*/
                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Image = value;

                NotifyPropertyChanged("DisplayedImage");

                ///System.Environment.Exit(1);

            }
        }



                    public string ImageGauche
        {
            get { return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\gauche.png"); }
            set
            {
                _imageGauche = value;
                NotifyPropertyChanged("imageGauche");

            }
        }
        public string ImageDroite
        {
            get { return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\droite.png"); }
            set
            {
                _imageDroite = value;
                NotifyPropertyChanged("imageDroite");

            }
        }
        public string NomChampion
        {
            get
            {
                /*if (SingletonChampion.Instance._index > _listeChampion.Count()-1 || SingletonChampion.Instance._index == -1)*/
                if (SingletonChampion.Instance._index > SingletonChampion.Instance._listeChampionGlobale.Count() - 1 || SingletonChampion.Instance._index == -1)
                {
                    SingletonChampion.Instance._index = 0;
                }
                /*return _listeChampion[SingletonChampion.Instance._index].NomChamps; }*/
                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].NomChamps;
            }
            set
            {
                /* _listeChampion[SingletonChampion.Instance._index].NomChamps = value;*/
                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].NomChamps = value;
                NotifyPropertyChanged("NomChampion");

            }
        }
        #endregion   
#region commande
    
        private ICommand _bouttonSauvegarder;
        public ICommand BoutonSauvegarder
        {
            get
            {
                return _bouttonSauvegarder ?? (_bouttonSauvegarder = new CommandHandler(() => Save(), _canExecute));
            }
        }

        private ICommand _CommandeSuivant;
        public ICommand CommandeSuivant
        {
            get
            {
               
                return _CommandeSuivant ?? (_CommandeSuivant = new CommandHandler(() => Suivant(), _canExecute));
            }
        }
        private ICommand _CommandeModifiezUtilisateur;
        public ICommand CommandeModifiezUtilisateur
        {
            get
            {
                return _CommandeModifiezUtilisateur ?? (_CommandeModifiezUtilisateur = new CommandHandler(() => ModifiezLUtilisateur(), _canExecute));
            }
        }
        
        private ICommand _CommandePrecedant;
        public ICommand CommandePrecedant
        {
            get
            {
                return _CommandePrecedant ?? (_CommandePrecedant = new CommandHandler(() => Precedant(), _canExecute));
            }
        }
        private ICommand _CommandeAjouter;
        public ICommand CommandeAjouter
        {
            get
            {
                return _CommandeAjouter ?? (_CommandeAjouter = new CommandHandler(() => Ajouter(), _canExecute));
            }
        }
        private ICommand _CommandeEdition;
        public ICommand CommandeEdition
        {
            get
            {
                return _CommandeEdition ?? (_CommandeEdition = new CommandHandler(() =>Edition(), _canExecute));
            }
        }
        private ICommand _CommandeDetail;
        public ICommand CommandeDetail
        {
            get
            {
                return _CommandeDetail ?? (_CommandeDetail = new CommandHandler(() => VoirDetail(), _canExecute));
            }
        }
        private ICommand _CommandeRechercher;
        public ICommand CommandeRechercher
        {
            get
            {
                return _CommandeRechercher ?? (_CommandeRechercher = new CommandHandler(() => RechercherChampion(), _canExecute));
            }
        }

        #endregion
#region fonctions
        public void Ajouter()
        {
            SingletonCreation.Instance.fenetre.ShowDialog();
        }
        public void Edition()
        {
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("Histoire");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("Video");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("TitleView");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("DescriptionSortA");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("DescriptionSortZ");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("DescriptionSortE");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("DescriptionSortR");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("NomSortA");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("NomSortZ");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("NomSortE");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("NomSortR");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("ImageSortA");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("ImageSortZ");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("ImageSortE");
            SingletonAvecModif.Instance.fenetre._vm2.NotifyPropertyChanged("ImageSortR");
            SingletonAvecModif.Instance.fenetre.SorryForBehindCode();

            SingletonAvecModif.Instance.fenetre.ShowDialog();
        }
        public void VoirDetail()
        {

            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("Histoire");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("Video");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("TitleView");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("DescriptionSortA");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("DescriptionSortZ");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("DescriptionSortE");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("DescriptionSortR");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("NomSortA");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("NomSortZ");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("NomSortE");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("NomSortR");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("ImageSortA");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("ImageSortZ");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("ImageSortE");
            SingletonSansModif.Instance.fenetre._vm2.NotifyPropertyChanged("ImageSortR");
            SingletonSansModif.Instance.fenetre.SorryForBehindCode();

            SingletonSansModif.Instance.fenetre.ShowDialog();


        }

        public void ModifiezLUtilisateur()
        {
            SingletonModifutilisateur.Instance.fenetre = new ModifiezUtilisateur();
            SingletonModifutilisateur.Instance.fenetre.ShowDialog();
            NotifyPropertyChanged("ModifierLUtilisateur");
        }
        public void Suivant()
        {
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Image);
            Console.WriteLine("*****************************************************************");
            if (SingletonChampion.Instance._index < SingletonChampion.Instance._listeChampionGlobale.Count - 1)
            {

                SingletonChampion.Instance._index = SingletonChampion.Instance._index + 1;


                NotifyPropertyChanged("DisplayedImage");
                NotifyPropertyChanged("NomChampion");

            }
        }
        public void Precedant()
        {

            if (SingletonChampion.Instance._index > 0)
            {

                SingletonChampion.Instance._index = SingletonChampion.Instance._index - 1;

                NotifyPropertyChanged("DisplayedImage");
                NotifyPropertyChanged("NomChampion");

            }
        }

        public void Save()
        {

            gestion.Ecrire("fichier.txt", SingletonChampion.Instance._listeChampionGlobale, true);
            System.Environment.Exit(1);

        }
        public void RechercherChampion()
        {

            NotifyPropertyChanged("NomChampion");
            NotifyPropertyChanged("DisplayedImage");


        }
        public string Rechercher
        {
            get
            {
                return _rechercher;
            }
            set
            {
                _rechercher = value;

                /* if (gestion.rechercherChampion(_rechercher, _listeChampion) != -1)*/
                if (gestion.RechercherChampion(_rechercher, SingletonChampion.Instance._listeChampionGlobale) != -1)
                {

                    /* SingletonChampion.Instance._index = gestion.rechercherChampion(_rechercher, _listeChampion);*/
                    SingletonChampion.Instance._index = gestion.RechercherChampion(_rechercher, SingletonChampion.Instance._listeChampionGlobale);

                    NotifyPropertyChanged("NomChampion");
                    NotifyPropertyChanged("DisplayedImage");

                }



            }
        }
        
        private bool CanExcuteClick(object obj)
        {
            return _isClick;
        }

        #endregion
    }

}
#region classeCommandeHandler
public class CommandHandler : ICommand
{
    private Action _action;
    private bool _canExecute = true;
    public CommandHandler(Action action, bool canExecute)
    {
        _action = action;
        _canExecute = canExecute;
    }

    public bool CanExecute(object obj)
    {
        return _canExecute;
    }
    
    public event EventHandler CanExecuteChanged;

    public void Execute(object parameter)
    {
        _action();
    }
}
#endregion