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
    /// ActivityInfo.xaml 的交互逻辑
    /// </summary>
    public partial class ActivityInfo : Window
    {
        public ActivityInfo()
        {
            InitializeComponent();
            Activity activity  = API.Instance.GetActivityAsync(int.Parse(MainWindow.actNowId)).Result;

            Label label1 = new Label();
            label1.Content = "Id = " + activity .Id.ToString() + "   Name = " + activity .Name;
            sp.Children.Add(label1);

            Label label2 = new Label();
            label2.Content = "Description = " + activity .Description;
            sp.Children.Add(label2);

            Label label3 = new Label();
            label3.Content = "Start Date = " + activity .StartDate .ToString() + " End Date = " + activity .EndDate .ToString();
            sp.Children.Add(label3);

            Label label4 = new Label();
            label4.Content = "Limit = " + activity.Limit.ToString () ;
            sp.Children.Add(label4);
        }
        private void BtnMod_Click(object sender, RoutedEventArgs e)
        {


            Activity  activity  = new Activity ();
            activity.Name = TbName.Text;
            activity.Description = TbDes.Text;
            activity.Limit = int.Parse(TbNlimit .Text );
            activity.StartDate = DateTime.Parse(TbSdate.Text);
            activity.EndDate = DateTime.Parse(TbEdate .Text );

            _ = API.Instance.ModifActivityAsync(activity );
            ActivityPage exhibitPage = new ActivityPage ();
            exhibitPage.Show();
            this.Close();
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            ActivityPage exhibitPage = new ActivityPage();
            exhibitPage.Show();
            this.Close();
        }
        private void BtSup_Click(object sender, RoutedEventArgs e)
        {
            _ = API.Instance.SupprActivityAsync(int.Parse(MainWindow.actNowId));
            ActivityPage exhibitPage = new ActivityPage();
            exhibitPage.Show();
            this.Close();
        }

    }
}
