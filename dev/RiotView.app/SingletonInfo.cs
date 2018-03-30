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
    public sealed class SingletonInfo
    {
        #region instanceObligatoireDeNosSingleton
        private static SingletonInfo instance = null;
        private static readonly object padlock = new object();
        #endregion
        #region attribut
        public Info fenetre;
        #endregion
        #region constructeur
        SingletonInfo()
        {

            fenetre = new Info();
        }
        #endregion
        #region publicInstance
        public static SingletonInfo Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonInfo();
                    }
                    return instance;
                }
            }
        }
#endregion

    }
}
