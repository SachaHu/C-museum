﻿using System;
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

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        public static string actNowId;
        public static string tagNowId;
        private void BtLogin_Click(object sender, RoutedEventArgs e)
        {
            if (TbLogin.Text.Length > 0)
            {
                if (PbPassword.Password.Length > 3)
                {
                    if (TbLogin.Text == "root" && PbPassword.Password == "root")
                    {

                        Conso conso = new Conso();
                        conso.Show();

                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Information ne sont pas correctes", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Information ne sont pas correctes", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }
    }
}