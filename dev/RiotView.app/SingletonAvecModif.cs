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
    public sealed class SingletonAvecModif
    {
        #region instanceObligatoireDeNosSingleton
        private static SingletonAvecModif instance = null;
        private static readonly object padlock = new object();
        #endregion
        #region les attribut
        public DetailChampion fenetre;
    #endregion
        #region construteurprive
        SingletonAvecModif()
        {

            fenetre = new DetailChampion();
        }
        #endregion
        #region publicInstance
        public static SingletonAvecModif Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonAvecModif();
                    }
                    return instance;
                }
            }
        }
#endregion




    }
}
