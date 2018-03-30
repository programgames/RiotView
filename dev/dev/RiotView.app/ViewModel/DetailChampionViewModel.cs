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
    public class DetailChampionViewModel : ViewModelBase
    {
        #region variable
        Manager gestion;
        private string _histoire;
        string _video;
        private string modif;
        private MediaElement monMedia;
        bool canExecute = true;
        public string Modif { get { return modif; } set { modif = value; } }
        #endregion
        #region constructeur
        public DetailChampionViewModel()
        {
           
            monMedia = new MediaElement();
            canExecute = true;
          
            gestion = new Manager();
          
        }
        #endregion
        #region commandes
        private ICommand _CommandeSupprimer;
        public ICommand CommandeSupprimer
        {
            get
            {
                return _CommandeSupprimer ?? (_CommandeSupprimer = new CommandHandler(() => Supprimer(),true));
            }
        }
        private ICommand _CommandeFermer;
        public ICommand CommandeFermer
        {
            get
            {
                return _CommandeFermer ?? (_CommandeFermer = new CommandHandler(() => Fermer(), true));
            }
        }
        #endregion
        #region propriete
        #region ChampionAffichage
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
        public string  Video
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
        public void LireVideo()
        {
            monMedia.Source = new Uri(Video);
           // monMedia.LoadedBehavior = MediaState.Pause; //Pause
            /*monMedia.LoadedBehavior = MediaState.Stop; //Arret
            monMedia.LoadedBehavior = MediaState.Play; //Play*/
        }
        
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
        #endregion
        #region titre
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
        #region ProprieteBouton
        public void Supprimer()
        {
            if(SingletonChampion.Instance._listeChampionGlobale.Count() == 1)
            {
                /* SingletonMenu.Instance.fenetre.Close();
                 SingletonMenu.Instance.fenetre = new Menu();
                 SingletonMenu.Instance.fenetre.ShowDialog();
                 SingletonView.Instance._viewDetail.Close();*/
                SingletonMenu.Instance.fenetre.Close();
                SingletonMenu.Instance.fenetre.UpdateLayout();
                SingletonMenu.Instance.fenetre.ShowDialog();
                MessageBox.Show("peut pas supprimer plus de champion");
                return;
            }
            
            
            SingletonChampion.Instance._listeChampionGlobale = gestion.RemoveChamp(SingletonChampion.Instance._listeChampionGlobale[SingletonChampion.Instance._index].NomChamps, SingletonChampion.Instance._listeChampionGlobale);
           
            SingletonMenu.Instance.fenetre.Close();
            SingletonChampion.Instance._index = 0;
            SingletonMenu.Instance.fenetre._vm.NotifyPropertyChanged("DisplayedImage");
            SingletonMenu.Instance.fenetre._vm.NotifyPropertyChanged("NomChampion");
            SingletonMenu.Instance.fenetre.UpdateLayout();
            SingletonMenu.Instance.fenetre.ShowDialog();





           NotifyPropertyChanged("supprimer");

           
        }
        

        public void Fermer()
        {
            SingletonAvecModif.Instance.fenetre.Close();
    
        }

        #endregion
#endregion
    }
}
