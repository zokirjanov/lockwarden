﻿using LockWarden.Desktop.Components;
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

namespace LockWarden.Desktop.Pages
{
    /// <summary>
    /// Interaction logic for TrashPage.xaml
    /// </summary>
    public partial class TrashPage : Page
    {
        public TrashPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            for (int i = 0; i < 50; i++)
            {
                var trash = new trashControl();
                loginControlStackPanel.Children.Add(trash);
            }
        }
    }
}
