using RiotView.app.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace RiotView.app
{
    /// <summary>
    /// Logique d'interaction pour Window2.xaml
    /// </summary>
    public partial class Inscription: Window
    {
        private InscriptionViewModel _vm;
        public Inscription()
        {
            

            
            InitializeComponent();
            _vm = new InscriptionViewModel();
            DataContext = _vm;
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            SingletonUtilisateur.Instance.Sauvegarder();
            this.Hide();
            e.Cancel = true;
            base.OnClosing(e);
        }
    }
}
