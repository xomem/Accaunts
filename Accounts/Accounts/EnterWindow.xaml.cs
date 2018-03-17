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

namespace Accounts
{
    /// <summary>
    /// Interaction logic for EnterWindow.xaml
    /// </summary>
    public partial class EnterWindow : Window
    {
        public EnterWindow()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            if(loginBox.Text != "" && passwordBox.Password != "")
            {
                if (Convert.ToString(errorLabel.Content) != "")
                {
                    errorLabel.Content = "";
                }
                if(Querys.Enter(loginBox.Text, passwordBox.Password))
                {
                    MessageBox.Show("true");
                }
                else
                {
                    MessageBox.Show("false");
                }
            }
            else
            {
                errorLabel.Content = "Не все поля заполнены!";
            }
        }
    }
}
