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
    public sealed class SingletonConnecter
    {
        #region instanceObligatoireDeNosSingleton
        private static SingletonConnecter instance = null;
        private static readonly object padlock = new object();
        #endregion
        #region attribut
        public string pseudo;
        public bool admin;
        #endregion
        #region constructeur
        SingletonConnecter()
        {
            admin = false;
           
        }
        #endregion
        #region publicInstance
        public static SingletonConnecter Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonConnecter();
                    }
                    return instance;
                }
            }
        }
#endregion




    }
}
