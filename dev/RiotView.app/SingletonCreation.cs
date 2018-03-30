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
    public sealed class SingletonCreation
    {
        #region instanceObligatoireDeNosSingleton
        private static SingletonCreation instance = null;
        private static readonly object padlock = new object();
        #endregion
        #region attribut
        public Creation fenetre;
        #endregion
        #region constructeur
        SingletonCreation()
        {
            fenetre = new Creation();
        }
        #endregion
        #region publicInstance
        public static SingletonCreation Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonCreation();
                    }
                    return instance;
                }
            }
        }
#endregion
        
    }
}
