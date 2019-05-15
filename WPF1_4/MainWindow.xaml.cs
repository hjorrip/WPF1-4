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

namespace WPF1_4
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

        private void btnButton1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 1 clicked");
        }

        private void btnButton2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 2 clicked");
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)e.Source;
            MessageBox.Show(b.Content + "handled at Grid");
            e.Handled = true;
        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)e.Source;
            MessageBox.Show(b.Content + "Handled at Window");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtStuff.Text = "halló heimur!";
            txtStuff.SelectionStart = txtStuff.Text.Length;
            txtStuff.Focus();
        }
    }
}
