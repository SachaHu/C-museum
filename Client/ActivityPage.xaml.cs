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
using Client.Controller;

namespace Client
{
    /// <summary>
    /// ActivityPage.xaml 的交互逻辑
    /// </summary>
    public partial class ActivityPage : Window
    {
        private readonly ICollection<Activity> ListeActivities;
        public ActivityPage()
        {
            InitializeComponent();
            
            ListeActivities = API.Instance.GetActivitiesAsync().Result;
            foreach(Activity  activity in ListeActivities)
            {
                Button btn = new Button();
                btn.Content = activity.Name;
                btn.Click += new RoutedEventHandler(btnA_click);
                btn.Tag = activity.Id;
                Sp.Children.Add(btn);
                
            }
        }
        private void btnA_click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            MainWindow.actNowId = btn.Tag.ToString()  ;
            ActivityInfo activityInfo = new ActivityInfo();
            activityInfo.ShowDialog(); 
        }


    }
}
