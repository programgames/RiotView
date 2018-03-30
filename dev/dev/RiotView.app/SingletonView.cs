using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace RiotView.app
{
    public sealed class SingletonView
    {
        #region instanceObligatoireDeNosSingleton
        private static SingletonView instance = null;
        private static readonly object padlock = new object();
        #endregion
        #region attribut
        private int rololol;
        public Manager gestion;
        public DetailChampion _viewDetail;
        public Creation _viewCreation;
        public DetailChampionSansModif _viewDetailSansModif;
        #endregion
        #region constructeur
        SingletonView()
        {
            gestion = new Manager();
            rololol = 156;
            
        }
        #endregion
        #region publicInstance
        public static SingletonView Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonView();
                    }
                    return instance;
                }
            }
        }
        
        
#endregion

    }
}
