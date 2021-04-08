﻿using Client.ActivitiyPages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Client
{
    /// <summary>
    /// Conso.xaml 的交互逻辑
    /// </summary>
    public partial class Conso : Window
    {
        public Conso()
        {
            InitializeComponent();
        }
        private void BtnEx_Click(object sender, RoutedEventArgs e)
        {
            ExhibitPage exhibitPage = new ExhibitPage();
            exhibitPage.Show();
            this.Close();
        }

        private void BtnHalls_Click(object sender, RoutedEventArgs e)
        {
            HallsPage hallsPage = new HallsPage();
            hallsPage.Show();
            this.Close();
        }

        private void BtnAct_Click(object sender, RoutedEventArgs e)
        {
            ActivityPage activityPage = new ActivityPage();
            activityPage.Show();
            this.Close();
        }

        private void BtnCate_Click(object sender, RoutedEventArgs e)
        {
            CatePage catePage = new CatePage();
            catePage.Show();
            this.Close();
        }
    }
}
