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
using MuseeApi.Models;
using Client.Controller;

namespace Client
{
    /// <summary>
    /// CatePage.xaml 的交互逻辑
    /// </summary>
    public partial class CatePage : Window
    {
        private readonly ICollection<Tag> ListeTags;
        public CatePage()
        {
            InitializeComponent();
            ListeTags = API.Instance.GetTagsAsync().Result;
            foreach (Tag tag in ListeTags)
            {
                Button btn = new Button();
                btn.Content = tag.Type;
                btn.Click += new RoutedEventHandler(btnA_click);
                btn.Tag = tag.Id;
                spc.Children.Add(btn);

            }
        }
        private void btnA_click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            MainWindow.tagNowId = btn.Tag.ToString();
            TagInfo tagInfo = new TagInfo();

            tagInfo.ShowDialog();
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
            TagAjout tagAjout = new TagAjout();
            tagAjout.Show();
            this.Close();
        }
    }
}
