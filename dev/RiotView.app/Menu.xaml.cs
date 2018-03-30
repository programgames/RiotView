// ========================================================================
//
// Copyright (C) 2008-2009 IUT CLERMONT1 - UNIVERSITE D’AUVERGNE
// 
//
// Module : Code behind de la vue du menu
// Author : Matthias Gaydu et Julien Marcon
// Creation date: 2017-08-20
//
// ======================================================================== 
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
    /// Logique d'interaction pour Menu.xaml
    /// </summary>
    /// 
   
    public partial class Menu : Window
    {
        
        public MenuViewModel _vm;
        public Menu()
        {
            InitializeComponent();
           
            
            _vm = new MenuViewModel();
           
            DataContext = _vm;
        }
        public void Maj()
        {
            SingletonMenu.Instance.fenetre._vm.NotifyPropertyChanged("IsVisible");
        }
       
        protected override void OnClosing(CancelEventArgs e)
        {
            MessageBox.Show("Fermeture de l'application", "Fermeture", MessageBoxButton.OK);
            
            System.Environment.Exit(0);
            SingletonChampion.Instance.Sauvegarder();
            this.Hide();
            e.Cancel = true;
            base.OnClosing(e);
        }
       
    }
}
