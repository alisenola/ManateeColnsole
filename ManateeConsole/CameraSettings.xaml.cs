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
    /// Interaction logic for CameraSettings.xaml
    /// </summary>
    public partial class CameraSettings : Window
    {
        public CameraSettings()
        {
            InitializeComponent();
        }

        private void OnClickOK(object sender, RoutedEventArgs e)
        {
            ApplicationState.SetValue("cameraIpaddr1", ipaddr1.Text);
            ApplicationState.SetValue("cameraIpaddr2", ipaddr2.Text);
            ApplicationState.SetValue("cameraIpaddr3", ipaddr3.Text);
            ApplicationState.SetValue("cameraIpaddr4", ipaddr4.Text);
            ApplicationState.SetValue("cameraChecked1", checkBox1.IsChecked);
            ApplicationState.SetValue("cameraChecked2", checkBox2.IsChecked);
            ApplicationState.SetValue("cameraChecked3", checkBox3.IsChecked);
            ApplicationState.SetValue("cameraChecked4", checkBox4.IsChecked);
            this.Close();
        }

        private void OnClickCancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
