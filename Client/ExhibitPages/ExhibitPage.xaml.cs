using Client.Controller;
using Client.Exhibit;
using Client.ExhibitPages;
using MuseeApi.Models;
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
    /// ExhibitPage.xaml 的交互逻辑
    /// </summary>
    public partial class ExhibitPage : Window
    {
        private readonly ICollection<MuseeApi.Models.Exhibit> ListeExhibits;
        public ExhibitPage()
        {
            InitializeComponent();
            ListeExhibits = API.Instance.GetExhibitsAsync().Result;
            foreach (MuseeApi.Models.Exhibit exhibit  in ListeExhibits)
            {
                Button btn = new Button();
                btn.Content = exhibit.Name;
                btn.Click += new RoutedEventHandler(btnA_click);
                btn.Tag = exhibit.Id;
                spc.Children.Add(btn);

            }
        }
        private void btnA_click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            MainWindow.exhNowId  = btn.Tag.ToString();
            ExhibitInfo exhibitInfo = new ExhibitInfo();

            exhibitInfo.ShowDialog();
            this.Close();
        }

        private void BtnAjou_Click(object sender, RoutedEventArgs e)
        {
            ExhibitAjout exhibitAjout = new ExhibitAjout();
            exhibitAjout.Show();
            this.Close();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Conso conso = new Conso();
            conso.Show();
            this.Close();
        }
    }
}
