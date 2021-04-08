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

namespace Client.ExhibitPages
{
    /// <summary>
    /// ExhibitAjout.xaml 的交互逻辑
    /// </summary>
    public partial class ExhibitAjout : Window
    {
        private readonly ICollection<Tag> ListeTags;
        public ExhibitAjout()
        {
            InitializeComponent();
            ListeTags = API.Instance.GetTagsAsync().Result ;
            foreach (Tag tag in ListeTags)
            {

                Label label = new Label();
                label.Content = "Tag : " + tag.Id + "  " + tag.Type;
                sp.Children.Add(label);

            }
        }
        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            ExhibitPage exhibitPage = new ExhibitPage();
            exhibitPage.Show();
            this.Close();
        }

        private ICollection<MuseeApi.Models.Exhibit> listExhibit;
        private int id;

        private void BtnAjout_Click(object sender, RoutedEventArgs e)
        {

            MuseeApi.Models.Exhibit exhibit = new MuseeApi.Models.Exhibit();
            exhibit.Name = TbName.Text;
            exhibit.Description = TbDes.Text;
            exhibit.SizeX = float.Parse(TbSizeX.Text);
            exhibit.SizeY = float.Parse(TbSizeY.Text);
            exhibit.SizeZ = float.Parse(TbSizeZ.Text);
            _= API.Instance.AjoutExhibitAsync(exhibit).Result.ToString ();

            
            ExhibitPage exhibitPage = new ExhibitPage();
            exhibitPage.Show();
            this.Close();
        }
    }
   }
       


