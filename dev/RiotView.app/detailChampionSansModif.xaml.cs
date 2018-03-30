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
using System.ComponentModel;

namespace RiotView.app
{
    /// <summary>
    /// Logique d'interaction pour DetailChampionSansModif.xaml
    /// </summary>
    public partial class DetailChampionSansModif : Window
    {
        public DetailChampionSansModifViewModel _vm2;
        public DetailChampionSansModif()
        {
            _vm2 = new DetailChampionSansModifViewModel();

            DataContext = _vm2;
            InitializeComponent();

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            VideoMedia.Stop();
            this.Hide();
            e.Cancel = true;
          //  base.OnClosing(e);
        }
        public void SorryForBehindCode()
        {
            VideoMedia.Play();
        }
      
    }
}
