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

namespace WordsCounter
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CountButton_Click(object sender, RoutedEventArgs e)
        {
            string str = StringBox.Text;
            int count = 0, leng = 0;

            while (leng <= str.Length - 1)
            {
                if (str[leng] == ' ' || str[leng]=='\n' || str[leng] == '\t' || str[leng]=='.' || str[leng] == ',')
                {
                    count++;
                }
                leng++;
            }
            ResultBlock.Text = count.ToString();
        }
    }
}
