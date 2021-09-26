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

namespace RandomNumGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int min, max, num;
            Random rand = new Random();

            while (int.TryParse(txtBoxMin.Text, out min) == false)
            {
                MessageBox.Show("You did not enter in a number.");
            }

            while (int.TryParse(txtBoxMax.Text, out max) == false)
            {
                MessageBox.Show("You did not enter in a number.");
            }

            num = rand.Next(min, max + 1);

            txtBlock.Text = Convert.ToString(num);
        }
    }
}
