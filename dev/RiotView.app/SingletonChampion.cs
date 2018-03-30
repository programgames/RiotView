using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Champions;
using Service;
using System.IO;

namespace RiotView.app
{
    public sealed class SingletonChampion
    {
        #region instanceObligatoireDeNosSingleton
        private static SingletonChampion instance = null;
        private static readonly object padlock = new object();
        #endregion
        #region attribut
        public Manager gestion;
        public List<Champion> _listeChampionGlobale;
        public int _index;
#endregion
        #region Construteur
        SingletonChampion()
        {
            gestion = new Manager();

            _index = 0;
            _listeChampionGlobale = new List<Champion>();
           _listeChampionGlobale = gestion.AjouterChampion(_listeChampionGlobale, "Garen", "A E R ggwp", "sort1", "bon damage", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\GarenQ.jpg"), TypeSpell.A, "Sort 2", "bouclier", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\GarenW.jpg"), TypeSpell.Z, "Sort 3", "tourni", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\GarenE.jpg"), TypeSpell.E, "sort ult", "press r", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\GarenR.jpg"), TypeSpell.R, System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\Garen.mp4"), System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\Garen.jpg"));
            _listeChampionGlobale = gestion.AjouterChampion(_listeChampionGlobale, "Darius", "NOPE", "sort1", "bon damage", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\DariusQ.jpg"), TypeSpell.A, "Sort 2", "estropiaison", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\DariusR.jpg"), TypeSpell.Z, "Sort 3", "grab", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\DariusE.jpg"), TypeSpell.E, "sort ult", "press r", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\DariusR.jpg"), TypeSpell.R, System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\Darius.MP4"), System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\Darius.jpg"));
        }
        #endregion
        #region publicInstance
        public static SingletonChampion Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonChampion();
                    }
                    return instance;
                }
            }
        }
        #endregion
        #region proprieter
        public void Sauvegarder()
        {
            gestion.Ecrire("Champions.txt", _listeChampionGlobale);

        }
        public void ChargerChampion()
        {
            string fichier = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Champions.txt");
            bool exist = File.Exists(fichier);

            if(exist)
            {
                _listeChampionGlobale = gestion.Lire<List<Champion>>(fichier);
            }
        }
#endregion
    }
}
