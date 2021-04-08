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
    /// TagInfo.xaml 的交互逻辑
    /// </summary>
    public partial class TagInfo : Window
    {
        private readonly ICollection<ExhibitTag> ListeExhibitsTags;
        public TagInfo()
        {
            InitializeComponent();
            Tag tag = API.Instance.GetTagAsync(int.Parse(MainWindow.tagNowId)).Result ;

            Label label1 = new Label();
            label1.Content = "Id = " + tag.Id.ToString ();
            sp.Children.Add(label1);

            Label label2 = new Label();
            label2.Content = "Type =  " + tag.Type ;
            sp.Children.Add(label2); 

            Label label3 = new Label();
            label3.Content = "Description = " + tag.Description ;
            sp.Children.Add(label3);

            ListeExhibitsTags = API.Instance.GetExhibitByTagAsync(tag.Id).Result;
            foreach (ExhibitTag exhibitTag in ListeExhibitsTags)
            {
                Label label = new Label();
                label.Content = "Exhibit : "+exhibitTag.ExhibitId.ToString()+" " + exhibitTag.Exhibit.Name.ToString () ;
                sp.Children.Add(label);
            }
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            CatePage catePage = new CatePage();
            catePage.Show();
            this.Close();
        }

        private void BtSup_Click(object sender, RoutedEventArgs e)
        {
            _=API.Instance.SupprTagAsync(int.Parse(MainWindow.tagNowId));
            CatePage catePage = new CatePage();
            catePage.Show();
            this.Close();
        }

        private void BtnMod_Click(object sender, RoutedEventArgs e)
        {
            Tag tag = new Tag()
            {
                Id = int.Parse(MainWindow.tagNowId)
                
            };
            tag.Type = TbTp.Text;
            tag.Description = TbDes.Text;
            _ = API.Instance.ModifTagAsync(tag);
            CatePage catePage = new CatePage();
            catePage.Show();
            this.Close();

                

            }

        }
    }

