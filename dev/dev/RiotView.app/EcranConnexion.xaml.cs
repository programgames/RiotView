using RiotView.app.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace RiotView.app
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class EcranConnexion : Window
    {
        private  EcranConnexionViewModel _viewModel;
        public EcranConnexion()
        {
            InitializeComponent();
            _viewModel = new EcranConnexionViewModel();
            DataContext = _viewModel;
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            
            this.Hide();
            e.Cancel = true;
            base.OnClosing(e);
        }
    }
}
