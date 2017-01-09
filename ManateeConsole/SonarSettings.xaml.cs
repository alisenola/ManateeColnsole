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

namespace ManateeConsole
{
    /// <summary>
    /// Interaction logic for SonarSettings.xaml
    /// </summary>
    public partial class SonarSettings : Window
    {
        public SonarSettings()
        {
            InitializeComponent();
        }

        private void OnClickOK(object sender, RoutedEventArgs e)
        {
            ApplicationState.SetValue("sonarIpaddr1", ipaddr1.Text);
            ApplicationState.SetValue("sonarIpaddr2", ipaddr2.Text);
            ApplicationState.SetValue("sonarIpaddr3", ipaddr3.Text);
            ApplicationState.SetValue("sonarIpaddr4", ipaddr4.Text);
            ApplicationState.SetValue("sonarChecked1", checkBox1.IsChecked);
            ApplicationState.SetValue("sonarChecked2", checkBox2.IsChecked);
            ApplicationState.SetValue("sonarChecked3", checkBox3.IsChecked);
            ApplicationState.SetValue("sonarChecked4", checkBox4.IsChecked);
        }

        private void OnClickCancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
