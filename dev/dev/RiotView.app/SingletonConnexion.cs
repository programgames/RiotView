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
    public sealed class SingletonConnexion
    {
        #region instanceObligatoireDeNosSingleton
        private static SingletonConnexion instance = null;
        private static readonly object padlock = new object();
        #endregion
        #region attribut
        public  EcranConnexion fenetre;
        #endregion
        #region construteur
        SingletonConnexion()
        {

            fenetre = new EcranConnexion();
        }
        #endregion
        #region publicInstance
        public static SingletonConnexion Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonConnexion();
                    }
                    return instance;
                }
            }
        }
#endregion




    }
}
