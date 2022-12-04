using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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

namespace cram_sessions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counterToHell = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TestButton3_Click(object sender, RoutedEventArgs e) {
            if (TestButton1.IsChecked == true) {
                //MessageBox.Show("Hello.");
                TitleText.Text += "Why'd you do that?";
                counterToHell++;
            } else if (TestButton2.IsChecked == true) {
                //MessageBox.Show("Goodbye.");
            }
            if (counterToHell > 5) {
                var psi = new ProcessStartInfo {
                    FileName = "https://www.google.com/search?q=white+woman&tbm=isch",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
        }
    }
}
