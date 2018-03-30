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
using System.Windows.Shapes;
using Champions;
using System.ComponentModel;

namespace RiotView.app
{
    /// <summary>
    /// Logique d'interaction pour Window4.xaml
    /// </summary>
    public partial class Creation : Window
    {
        public ViewModel.CreationViewModel _vm;

        



        public Creation()
        {
            InitializeComponent();
            _vm = new CreationViewModel();

           DataContext = _vm;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            
            this.Hide();
            e.Cancel = true;
            base.OnClosing(e);
        }
        
        
    }
}
