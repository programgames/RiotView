using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RiotView.app.ViewModel;

namespace RiotView.app
{
    /// <summary>
    /// Logique d'interaction pour ModifiezUtilisateur.xaml
    /// </summary>
    public partial class ModifiezUtilisateur : Window
    {
        private ModifiezUtilisateurViewModel _vm;
        public ModifiezUtilisateur()
        {
            _vm = new ModifiezUtilisateurViewModel();
            InitializeComponent();
            DataContext = _vm;
        }
    }
}
