using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotView.app
{
    public sealed class SingletonModifutilisateur
    {
        #region instanceObligatoireDeNosSingleton
        private static SingletonModifutilisateur instance = null;
        private static readonly object padlock = new object();
        #endregion
        #region attribut
        public ModifiezUtilisateur fenetre;
        #endregion
        #region constructeur
        SingletonModifutilisateur()
        {

            fenetre = new ModifiezUtilisateur();
        }
        #endregion
        #region publicInstance
        public static SingletonModifutilisateur Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonModifutilisateur();
                    }
                    return instance;
                }
            }
        }
#endregion
    }
}
