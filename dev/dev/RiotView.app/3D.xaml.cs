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
    /// Logique d'interaction pour test.xaml
    /// </summary>
    public partial class Test : Window
    {
        private _3DViewModel _viewModel;
        public Test()
        {
            InitializeComponent();
            _viewModel = new _3DViewModel();

            DataContext = _viewModel;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
           
            this.Hide();
            e.Cancel = true;
            base.OnClosing(e);
        }
    }
}
