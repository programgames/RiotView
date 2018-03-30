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
    public sealed class SingletonMenu
    {
        #region instanceObligatoireDeNosSingleton
        private static SingletonMenu instance = null;
        private static readonly object padlock = new object();
        #endregion
        #region attribut
        public Menu fenetre;
        public string pseudo;
        #endregion
        #region constructeur
        SingletonMenu()
        {
           
            fenetre = new Menu();
        }
        #endregion
        #region publicInstance
        public static SingletonMenu Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonMenu();
                    }
                    return instance;
                }
            }
        }
#endregion
    }
}
