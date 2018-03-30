using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Champions;
using Service;
using Utilisateurs;

namespace RiotView.app
{
    public sealed class SingletonSansModif
    {
        #region instanceObligatoireDeNosSingleton
        private static SingletonSansModif instance = null;
        private static readonly object padlock = new object();
        public DetailChampionSansModif fenetre;
        #endregion
        #region constructeur
        SingletonSansModif()
        {

            fenetre = new DetailChampionSansModif();
        }
        #endregion
        #region publicInstance
        public static SingletonSansModif Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonSansModif();
                    }
                    return instance;
                }
            }
        }
#endregion
        
    }
}
