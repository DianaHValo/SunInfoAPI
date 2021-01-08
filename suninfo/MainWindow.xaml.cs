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

namespace suninfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();

        }

        public async void LoadSunInfo_Click(object sender, RoutedEventArgs e)
        {
            var sunInfo = await SunProcessor.LoadSunInfo(Country.Text);
            sunriseText.Text = $"Sunrise is at {sunInfo.SunRise.ToLocalTime().ToShortTimeString()}";
            sunsetText.Text = $"Sunset is at {sunInfo.SunSet.ToLocalTime().ToShortTimeString()}";

        }
    }
}
