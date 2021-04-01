using System.Windows;

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

        private void BtLogin_Click(object sender, RoutedEventArgs e)
        {
            if (TbLogin.Text.Length >0)
            {
                if (PbPassword.Password.Length > 3)
                {
                    if (TbLogin.Text == "root" && PbPassword.Password == "root")
                    {

                        Conso conso = new Conso();
                        conso.Show();
                     
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Information ne sont pas correctes", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Information ne sont pas correctes", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            
        }
    }
}
