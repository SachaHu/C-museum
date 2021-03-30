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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace webWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
        private void ButtonIntroduction_Click(object sender, RoutedEventArgs e)
        {
            Introduction introduction = new Introduction();
            introduction.ShowDialog();
        }

        private void ButtonActivity_Click(object sender, RoutedEventArgs e)
        {
            ActivityPage activity = new ActivityPage();
            activity.ShowDialog();
        }
        private void ButtonExhibit_Click(object sender, RoutedEventArgs e{
            ExhibitPage exhibitPage = new ExhibitPage();
            exhibitPage.ShowDialog();
        }
    }
}
