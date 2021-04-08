using Client.Controller;
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
    /// HallsPage.xaml 的交互逻辑
    /// </summary>
    public partial class HallsPage : Window
    {
        private readonly ICollection<Area> ListeAreas;
        public HallsPage()
        {
            InitializeComponent();
            ListeAreas = API.Instance.GetAreasAsync().Result;
            foreach (Area tag in ListeAreas)
            {
                Button btn = new Button();
                btn.Content = tag.Name;
                btn.Tag = tag.Id;
                spc.Children.Add(btn);

            }
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Conso conso = new Conso();
            conso.Show();
            this.Close();
        }
    }
}
