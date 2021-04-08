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

namespace Client.Exhibit
{
    /// <summary>
    /// ExhibitInfo.xaml 的交互逻辑
    /// </summary>
    public partial class ExhibitInfo : Window
    {
        private readonly ICollection<ExhibitTag> ListeExhibitsTags;
        public ExhibitInfo()
        {
            InitializeComponent();
            MuseeApi .Models .Exhibit  exhibit  = API.Instance.GetExhibitAsync(int.Parse(MainWindow.exhNowId )).Result;

            Label label1 = new Label();
            label1.Content = "Id = " + exhibit .Id.ToString()+"   Name = "+exhibit .Name ;
            sp.Children.Add(label1);

            Label label2 = new Label();
            label2.Content = "Description = " + exhibit.Description  ;
            sp.Children.Add(label2);

            Label label3 = new Label();
            label3.Content = "Size X = " + exhibit.SizeX.ToString() + " Size Y = " + exhibit.SizeY.ToString() + " Size Z = " + exhibit.SizeZ.ToString();
            sp.Children.Add(label3);

            ListeExhibitsTags = API.Instance.GetTagByExhibitAsync(exhibit .Id).Result;
            
            foreach (ExhibitTag exhibitTag in ListeExhibitsTags)
            {
                Label label = new Label();
                label.Content = "Tag : " + exhibitTag.TagId.ToString() + " " + exhibitTag.Tag.Type.ToString ();
                sp.Children.Add(label);
            }
        }

        private void BtnMod_Click(object sender, RoutedEventArgs e)
        {
            MuseeApi.Models.Exhibit exhibit = new MuseeApi.Models.Exhibit()
            {
                Id = int.Parse(MainWindow.exhNowId)
            };
            exhibit.Name = TbName.Text;
            exhibit.Description = TbDes.Text;
            exhibit.SizeX = float.Parse ( TbSizeX.Text);
            exhibit.SizeY = float.Parse(TbSizeY.Text);
            exhibit.SizeZ = float.Parse(TbSizeZ.Text);

            _ = API.Instance.ModifExhibitAsync(exhibit );
            ExhibitPage exhibitPage = new ExhibitPage();
            exhibitPage.Show();
            this.Close();
        }
        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            ExhibitPage exhibitPage = new ExhibitPage();
            exhibitPage.Show();
            this.Close();
        }
        private void BtSup_Click(object sender, RoutedEventArgs e)
        {
            _ = API.Instance.SupprExhibitAsync(int.Parse(MainWindow.exhNowId));
            ExhibitPage exhibitPage = new ExhibitPage();
            exhibitPage.Show();
            this.Close();
        }
        private void BtnAjoutTag_Click(object sender, RoutedEventArgs e)
        {
            ExhibitTag exhibitTag = new ExhibitTag() ;
            exhibitTag.ExhibitId = int.Parse (MainWindow.exhNowId);
            exhibitTag.TagId = int.Parse(TbAjoutTag.Text);
            _ = API.Instance.AjoutExhibitTagAsync(exhibitTag );
            ExhibitPage exhibitPage = new ExhibitPage();
            exhibitPage.Show();
            this.Close();
        }

        private void BtnSuppTag_Click(object sender, RoutedEventArgs e)
        {
            _ = API.Instance.SupprExhibitTagAsync(int.Parse(MainWindow.exhNowId),int.Parse ( TbSuppTag.Text ) );
            ExhibitPage exhibitPage = new ExhibitPage();
            exhibitPage.Show();
            this.Close();
        }
    }
}
