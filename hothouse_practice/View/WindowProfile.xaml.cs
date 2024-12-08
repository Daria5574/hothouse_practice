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

namespace hothouse_practice.View
{
    /// <summary>
    /// Логика взаимодействия для WindowProfile.xaml
    /// </summary>
    public partial class WindowProfile : Window
    {
        public WindowProfile()
        {
            InitializeComponent();
        }
        private void MouseLeftButtonDown_profile(object sender, MouseButtonEventArgs e)
        {
            WindowProfile wProfile = new WindowProfile();
            wProfile.Show();
            Close();
        }
        public void MouseLeftButtonDown_main(object sender, MouseButtonEventArgs e)
        {
            WindowPlots wPlots = new WindowPlots();
            wPlots.Show();
            Close();
        }
    }
}
