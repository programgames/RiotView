using RiotView.app.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Service;
using System.Windows;
using Champions;
using System.Windows.Controls;

namespace RiotView.app.ViewModel
{
    public class DetailChampionSansModifViewModel : ViewModelBase
    {
        #region variables
        Manager gestion;
        private bool canExecute;
        string _video;
        private string modif;
        private MediaElement monMedia;
     
        #endregion
        #region constructeur
        public DetailChampionSansModifViewModel()
        {
           
            monMedia = new MediaElement();
            canExecute = true;
            // SingletonChampion.Instance._listeChampionGlobale = _listeChampion;
            gestion = new Manager();
            //SingletonMenu.Instance.fenetre.Close();
            //this.SingletonChampion.Instance._index = SingletonChampion.Instance._index;
            /* _histoire = avoirListe.ListeChampion[SingletonChampion.Instance._index].Histoire;*/
        }
#endregion
        #region commande

        private ICommand _CommandeFermer;
        

        public ICommand CommandeFermer
        {
            get
            {
                return _CommandeFermer ?? (_CommandeFermer = new CommandHandler(() => Fermer(), true));
            }
        }
        #endregion
        #region AutresBinding
        public string Modif
        {
            get { return modif; }
            set { modif = value; }
        }
        public string Histoire
        {
            get
            {

                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Histoire;
            }
            set
            {

                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Histoire = value;

                NotifyPropertyChanged("Histoire");

                ///System.Environment.Exit(1);

            }
        }
        public string Video
        {
            get
            {
                return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\Darius.MP4");
                //return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].VideoChamps;
            }
            set
            {

                _video = value;

                NotifyPropertyChanged("Video");

                ///System.Environment.Exit(1);

            }
        }
        public string TitleView
        {
            get
            {
                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].NomChamps;
            }
            set
            {
                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].NomChamps = value;
                NotifyPropertyChanged("TitleView");
            }
        }
        #endregion
        #region DescriptionSort
        public string DescriptionSortA
        {
            get
            {
                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[0].Description;
            }
            set
            {
                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[0].Description = value;
                NotifyPropertyChanged("DescriptionSortA");
            }
        }
        public string DescriptionSortZ
        {
            get
            {
                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[1].Description;
            }
            set
            {
                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[1].Description = value;
                NotifyPropertyChanged("DescriptionSortZ");
            }
        }
        public string DescriptionSortE
        {
            get
            {
                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[2].Description;
            }
            set
            {
                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[2].Description = value;
                NotifyPropertyChanged("DescriptionSortE");
            }
        }
        public string DescriptionSortR
        {
            get
            {
                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[3].Description;
            }
            set
            {
                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[3].Description = value;
                NotifyPropertyChanged("DescriptionSortR");
            }
        }
        #endregion
        #region NomSort
        public string NomSortA
        {
            get
            {

                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[0].NomSort;
            }
            set
            {

                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[0].NomSort = value;

                NotifyPropertyChanged("NomSortA");

                ///System.Environment.Exit(1);

            }
        }
        public string NomSortZ
        {
            get
            {

                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[1].NomSort;
            }
            set
            {

                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[1].NomSort = value;

                NotifyPropertyChanged("NomSortE");

                ///System.Environment.Exit(1);

            }
        }
        public string NomSortE
        {
            get
            {

                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[2].NomSort;
            }
            set
            {

                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[2].NomSort = value;

                NotifyPropertyChanged("NomSortE");

                ///System.Environment.Exit(1);

            }
        }
        public string NomSortR
        {
            get
            {

                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[3].NomSort;
            }
            set
            {

                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[3].NomSort = value;

                NotifyPropertyChanged("NomSortR");

                ///System.Environment.Exit(1);

            }
        }
        #endregion
        #region ImageSort
        public string ImageSortA
        {
            get
            {

                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[0].Image;
            }
            set
            {

                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[0].Image = value;

                NotifyPropertyChanged("ImageSortA");

                ///System.Environment.Exit(1);

            }
        }
        public string ImageSortZ
        {
            get
            {

                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[1].Image;
            }
            set
            {

                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[1].Image = value;

                NotifyPropertyChanged("ImageSortZ");

                ///System.Environment.Exit(1);

            }
        }
        public string ImageSortE
        {
            get
            {

                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[2].Image;
            }
            set
            {

                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[2].Image = value;

                NotifyPropertyChanged("ImageSortE");

                ///System.Environment.Exit(1);

            }
        }
        public string ImageSortR
        {
            get
            {

                return SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[3].Image;
            }
            set
            {

                SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].Spell[3].Image = value;

                NotifyPropertyChanged("ImageSortR");

                ///System.Environment.Exit(1);

            }
        }
        #endregion
        #region fonctions
        public void LireVideo()
        {
            monMedia.Source = new Uri(Video);
            // monMedia.LoadedBehavior = MediaState.Pause; //Pause
            /*monMedia.LoadedBehavior = MediaState.Stop; //Arret
            monMedia.LoadedBehavior = MediaState.Play; //Play*/
        }
        public void Fermer()
        {
            SingletonSansModif.Instance.fenetre.Close();
           
        }
#endregion

    }
}
