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
    /// ActivityAjout.xaml 的交互逻辑
    /// </summary>
    public partial class ActivityAjout : Window
    {
        public ActivityAjout()
        {
            InitializeComponent();
        }

        private void BtnAjout_Click(object sender, RoutedEventArgs e)
        {
            Activity activity = new Activity();
            activity.Name = TbName.Text;
            activity.Description = TbDes.Text;
            activity.Limit = int.Parse(TbNlimit.Text);
            activity.StartDate = DateTime.Parse(TbSdate.Text);
            activity.EndDate = DateTime.Parse(TbEdate.Text);

            _ = API.Instance.AjoutActivityAsync(activity);
            ActivityPage exhibitPage = new ActivityPage();
            exhibitPage.Show();
            this.Close();
        }
        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            ActivityPage exhibitPage = new ActivityPage();
            exhibitPage.Show();
            this.Close();
        }
    }
}
