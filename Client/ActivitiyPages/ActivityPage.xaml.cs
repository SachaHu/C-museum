using Client.Controller;
using MuseeApi.Models;
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

namespace Client.ActivitiyPages
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
            foreach (Activity activity  in ListeActivities)
            {
                Button btn = new Button();
                btn.Content = activity .Name;
                btn.Click += new RoutedEventHandler(btnA_click);
                btn.Tag = activity .Id;
                spc.Children.Add(btn);

            }
        }
        private void btnA_click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            MainWindow.actNowId = btn.Tag.ToString();
            ActivityInfo activityInfo = new ActivityInfo();

            activityInfo.ShowDialog();
            this.Close();
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Conso conso = new Conso();
            conso.Show();
            this.Close();
        }
        private void BtnAjou_Click(object sender, RoutedEventArgs e)
        {
            ActivityAjout activityAjout = new ActivityAjout();
            activityAjout.Show();
            this.Close();
        }
    }
}
