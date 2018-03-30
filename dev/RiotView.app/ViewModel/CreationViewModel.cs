using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Champions;
using Utilisateurs;
using RiotView.app.Abstract;
using Microsoft.Win32;
using System.Windows;
using RiotView.app.ViewModel;
using System.Windows.Input;
// ========================================================================
//
// Copyright (C) 2016-2017 IUT CLERMONT1 - UNIVERSITE D’AUVERGNE
// 
//
// Module : ViewModel de la vue de l'ajout de champion
// Author : Matthias Gaydu et Julien Marcon
// Creation date: 2017-08-20
//
// ======================================================================== 

namespace RiotView.app.ViewModel
{
    public class CreationViewModel : ViewModelBase
    {
        #region attribut
      

        string _video;
        string _image;
        string _nomChampion;
        string _histoire;
        string _sortA;
        string _sortZ;
        string _sortE;
        string _sortR;
        string _imageA;
        string _imageZ;
        string _imageE;
        string _imageR;
        public DelegateCommand CloseCommand { get; private set; }
        public event Action<List<Champion>> Check;

        Manager gestion;
#endregion
        #region constructeur
        public CreationViewModel()
        {
            Check = DoWork;
            gestion = new Manager();
           
            CloseCommand = new DelegateCommand(OnClose);

        }
        #endregion
        #region commande
        private ICommand _bouttonImage;
        public ICommand BoutonImage
        {
            get
            {
                return _bouttonImage ?? (_bouttonImage = new CommandHandler(() => OuvrirImage(), true));
            }
        }
        
        private ICommand _bouttonVideo;
        public ICommand BouttonVideo
        {
            get
            {
                return _bouttonVideo ?? (_bouttonVideo = new CommandHandler(() => OuvrirVideo(), true));
            }
        }
        

        private ICommand _boutonImageA;
        public ICommand BoutonImageA
        {
            get
            {
                return _boutonImageA ?? (_boutonImageA = new CommandHandler(() => OuvrirImageA(), true));
            }
        }
        
        private ICommand _boutonImageZ;
        public ICommand BoutonImageZ
        {
            get
            {
                return _boutonImageZ ?? (_boutonImageZ = new CommandHandler(() => OuvrirImageZ(), true));
            }
        }
        
        private ICommand _boutonImageE;
        public ICommand BoutonImageE
        {
            get
            {
                return _boutonImageE ?? (_boutonImageZ = new CommandHandler(() => OuvrirImageE(), true));
            }
        }
        
        private ICommand _boutonImageR;
        public ICommand BoutonImageR
        {
            get
            {
                return _boutonImageR ?? (_boutonImageZ = new CommandHandler(() => OuvrirImageR(), true));
            }
        }
        



        private ICommand _bouttonSauvegarder;
        public ICommand BouttonSauvegarder
        {
            get
            {
                return _bouttonSauvegarder ?? (_bouttonSauvegarder = new CommandHandler(() => SauvegarderChampion(), true));
            }
        }
        #endregion
        #region propriete
        #region FaireChampion
        public static void DoWork(List<Champion> liste)
        {


        }
        public List<Champion> Renvoie()
        {
            return SingletonChampion.Instance._listeChampionGlobale;
        }
        public string NomChampion
        {
            get
            {
                return _nomChampion;
            }
            set
            {

                _nomChampion = value;

                NotifyPropertyChanged("NomChampion");

                ///System.Environment.Exit(1);

            }
        }
        public string Histoire
        {
            get
            {
                return _histoire;
            }
            set
            {

                _histoire = value;

                NotifyPropertyChanged("Histoire");

                ///System.Environment.Exit(1);

            }
        }
        #region sort
        public string SortA
        {
            get
            {
                return _sortA;
            }
            set
            {

                _sortA = value;

                NotifyPropertyChanged("SortA");

                ///System.Environment.Exit(1);

            }
        }
        public string SortZ
        {
            get
            {
                return _sortZ;
            }
            set
            {

                _sortZ = value;

                NotifyPropertyChanged("SortZ");

                ///System.Environment.Exit(1);

            }
        }
        public string SortE
        {
            get
            {
                return _sortE;
            }
            set
            {

                _sortE = value;

                NotifyPropertyChanged("SortE");

                ///System.Environment.Exit(1);

            }
        }
        public string SortR
        {
            get
            {
                return _sortR;
            }
            set
            {

                _sortR = value;

                NotifyPropertyChanged("SortR");

                ///System.Environment.Exit(1);

            }
        }

       
       
        #endregion
        #region Multimedia
        public void OuvrirImage()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                _image = openFileDialog.FileName;

            }
        }
        
        
        public void OuvrirVideo()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                _video = openFileDialog.FileName;

            }
        }

       
       
        public void OuvrirImageA()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                _imageA = openFileDialog.FileName;

            }
        }
       
      public void OuvrirImageZ()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                _imageZ = openFileDialog.FileName;

            }
        }
        
       
        public void OuvrirImageE()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                _imageE = openFileDialog.FileName;

            }
        }
       
       
        public void OuvrirImageR()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                _imageR = openFileDialog.FileName;

            }
        }
        #endregion
        #endregion
        #region SauverLeChamp
        public void SauvegarderChampion()
        {
            
            
            
            if(_video == null)
            {
                MessageBox.Show("Vidéo manquante");
                return;
            }
            if (_image == null)
            {
                MessageBox.Show("Image manquante");
                return;
            }
            if (_nomChampion == null)
            {
                MessageBox.Show("Nom manquant");
                return;
            }
            if (_histoire == null)
            {
                MessageBox.Show("Histoire manquante");
                return;
            }
            if (_sortA == null)
            {
                MessageBox.Show("Description su sort A manquante");
                return;
            }
            if (_sortZ == null)
            {
                MessageBox.Show("Description su sort Z manquante");
                return;
            }
            if (_sortE == null)
            {
                MessageBox.Show("Description su sort E manquante");
                return;
            }
            if (_sortR == null)
            {
                MessageBox.Show("Description su sort R manquante");
                return;
            }
            if (_imageA == null)
            {
                MessageBox.Show("Image du sort A manquante");
                return;
            }
            if (_imageZ == null)
            {
                MessageBox.Show("Image du sort Z manquante");
                return;
            }
            if (_imageE == null)
            {
                MessageBox.Show("Image du sort E manquante");
                return;
            }
            if (_imageR == null)
            {
                MessageBox.Show("Image du sort R manquante");
                return;
            }
            int NombreAvantAjout = SingletonChampion.Instance._listeChampionGlobale.Count();
            SingletonChampion.Instance._listeChampionGlobale = gestion.AjouterChampion(SingletonChampion.Instance._listeChampionGlobale, _nomChampion, _histoire, "NOMSORTA", _sortA, _imageA, TypeSpell.A, "NOMSORTB", _sortZ, _imageZ, TypeSpell.Z, "NOMSORTC", _sortE, _imageE, TypeSpell.E, "NOMSORTD", _sortR, _imageR, TypeSpell.R, _video, _image);
             _video = null;
            _image = null;
            _nomChampion = null;
            _histoire = null;
            _sortA = null;
            _sortZ = null;
            _sortE = null;
            _sortR = null;
            _imageA = null;
            _imageZ = null;
            _imageE = null;
            _imageR = null;
            NotifyPropertyChanged("NomChampion");
            NotifyPropertyChanged("Histoire");
            NotifyPropertyChanged("SortZ");
            NotifyPropertyChanged("SortE");
            NotifyPropertyChanged("SortA");
            NotifyPropertyChanged("SortR");
            
            if (SingletonChampion.Instance._listeChampionGlobale.Count() > NombreAvantAjout)
            {
                MessageBox.Show("Ajout Reussi");
            }
            if(SingletonChampion.Instance._listeChampionGlobale.Count() == NombreAvantAjout)
            {
                MessageBox.Show("Champion deja existant");
            }
           

            SingletonChampion.Instance.Sauvegarder();

            //SingletonCreation.Instance.fenetre.Close();


        }
        #endregion
        #region autreproprieter
        public List<Champion> ListeChampion
        {
            get
            {
                return SingletonChampion.Instance._listeChampionGlobale;
            }
            set
            {
                SingletonChampion.Instance._listeChampionGlobale = value;
            }
        }
        private void OnClose(object obj)
        {

            ButtonPressedEvent.GetInstance().OnButtonPressedHandler(EventArgs.Empty);
        }

        private void OnEventReceived(object sender, EventArgs e)
        {
           
        }
#endregion
        #endregion
    }
}
