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
    public sealed class SingletonInscription
    {
        #region instanceObligatoireDeNosSingleton
        private static SingletonInscription instance = null;
        private static readonly object padlock = new object();
        #endregion
        #region attribut
        public Inscription fenetre;
        #endregion
        #region constructeur
        SingletonInscription()
        {
            fenetre = new Inscription();
            
        }
        #endregion
        #region publicInstance
        public static SingletonInscription Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonInscription();
                    }
                    return instance;
                }
            }
        }
#endregion
        
    }
}
