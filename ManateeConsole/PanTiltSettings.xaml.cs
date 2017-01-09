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
    /// Interaction logic for PanTiltSettings.xaml
    /// </summary>
    public partial class PanTiltSettings : Window
    {
        public PanTiltSettings()
        {
            InitializeComponent();
        }

        private void OnClickOK(object sender, RoutedEventArgs e)
        {
            ApplicationState.SetValue("serialPort1", comboBox1SerialPort1.Text);
            ApplicationState.SetValue("serialPort2", comboBox1SerialPort2.Text);
            ApplicationState.SetValue("serialPort3", comboBox1SerialPort3.Text);
            ApplicationState.SetValue("serialPort4", comboBox1SerialPort4.Text);
            ApplicationState.SetValue("partnerSonar1", comboBoxPartnerSonar1.Text);
            ApplicationState.SetValue("partnerSonar2", comboBoxPartnerSonar2.Text);
            ApplicationState.SetValue("partnerSonar3", comboBoxPartnerSonar3.Text);
            ApplicationState.SetValue("partnerSonar4", comboBoxPartnerSonar4.Text);
            ApplicationState.SetValue("autoConnect1", checkBoxAutoConnect1.IsChecked);
            ApplicationState.SetValue("autoConnect2", checkBoxAutoConnect2.IsChecked);
            ApplicationState.SetValue("autoConnect3", checkBoxAutoConnect3.IsChecked);
            ApplicationState.SetValue("autoConnect4", checkBoxAutoConnect4.IsChecked);
            ApplicationState.SetValue("panPosition1", textBoxPanPosition1.Text);
            ApplicationState.SetValue("panPosition2", textBoxPanPosition2.Text);
            ApplicationState.SetValue("panPosition3", textBoxPanPosition3.Text);
            ApplicationState.SetValue("panPosition4", textBoxPanPosition4.Text);
            ApplicationState.SetValue("tiltPosition1", textBoxTiltPosition1.Text);
            ApplicationState.SetValue("tiltPosition2", textBoxTiltPosition2.Text);
            ApplicationState.SetValue("tiltPosition3", textBoxTiltPosition3.Text);
            ApplicationState.SetValue("tiltPosition4", textBoxTiltPosition4.Text);
            ApplicationState.SetValue("offset1", checkBoxOffset1.IsChecked);
            ApplicationState.SetValue("offset2", checkBoxOffset2.IsChecked);
            ApplicationState.SetValue("offset3", checkBoxOffset3.IsChecked);
            ApplicationState.SetValue("offset4", checkBoxOffset4.IsChecked);
            this.Close();
        }

        private void OnClickCancel(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show(ApplicationState.GetValue<String>("serialPort1"));
            this.Close();
        }
    }
}
