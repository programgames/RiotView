using RiotView.app.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RiotView.app.ViewModel
{
    class _3DViewModel : ViewModelBase
    {
        #region construteur
        public _3DViewModel()
        {

        }
        #endregion
        #region commande
        private ICommand _ClickCommand;
        public ICommand ClickCommand
        {
            get
            {
                return _ClickCommand ?? (_ClickCommand = new CommandHandler(() => Connexion(), true));
            }
        }
        #endregion
        #region proprieter
        public void Connexion()
        {
            SingletonConnexion.Instance.fenetre.ShowDialog();
        }
#endregion
    }
}
