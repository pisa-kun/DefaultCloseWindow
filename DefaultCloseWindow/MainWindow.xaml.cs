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

namespace DefaultCloseWindow
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Default(object sender, RoutedEventArgs e)
        {
            var r = MessageBox.Show("Enter default ok", "caption", MessageBoxButton.OKCancel);
            this.text.Text = r.ToString();
        }

        private void Button_Escape(object sender, RoutedEventArgs e)
        {
            var r = MessageBox.Show("Enter", "caption", MessageBoxButton.YesNoCancel);
            this.text.Text = r.ToString();
        }

        private void Button_OnlyOK(object sender, RoutedEventArgs e)
        {
            var r = MessageBox.Show("Enter", "caption", MessageBoxButton.OK);
            this.text.Text = r.ToString();
        }

        private void Button_YesNo(object sender, RoutedEventArgs e)
        {
            var r = MessageBox.Show("Enter", "caption", MessageBoxButton.YesNo);
            this.text.Text = r.ToString();
        }

        private void Button_Custom(object sender, RoutedEventArgs e)
        {
            var s = new SubWindow();
            s.ShowDialog();
        }
    }
}
