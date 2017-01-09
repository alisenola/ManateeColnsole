using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ManateeConsole
{
    /// <summary>
    /// Interaction logic for SystemDiagnostics.xaml
    /// </summary>
    public partial class SystemDiagnostics : Window
    {
        public SystemDiagnostics()
        {
            InitializeComponent();
        }

        private void OnClickOK(object sender, RoutedEventArgs e)
        {
            ApplicationState.SetValue("rangeThreshold1", scrollBarRangeThreshold1.Value);
            ApplicationState.SetValue("soundVelocity1", scrollBarSoundVelocity1.Value);
            if (radioButtonUpRight1.IsChecked.Value)
            {
                ApplicationState.SetValue("sonarInfo1", "Upright");
            }
            else
            {
                ApplicationState.SetValue("sonarInfo1", "Inverted");
            }

            ApplicationState.SetValue("rangeThreshold2", scrollBarRangeThreshold2.Value);
            ApplicationState.SetValue("soundVelocity2", scrollBarSoundVelocity2.Value);
            if (radioButtonUpRight2.IsChecked.Value)
            {
                ApplicationState.SetValue("sonarInfo2", "Upright");
            }
            else
            {
                ApplicationState.SetValue("sonarInfo2", "Inverted");
            }

            ApplicationState.SetValue("rangeThreshold3", scrollBarRangeThreshold3.Value);
            ApplicationState.SetValue("soundVelocity3", scrollBarSoundVelocity3.Value);
            if (radioButtonUpRight3.IsChecked.Value)
            {
                ApplicationState.SetValue("sonarInfo3", "Upright");
            }
            else
            {
                ApplicationState.SetValue("sonarInfo3", "Inverted");
            }

            ApplicationState.SetValue("rangeThreshold4", scrollBarRangeThreshold4.Value);
            ApplicationState.SetValue("soundVelocity4", scrollBarSoundVelocity4.Value);
            if (radioButtonUpRight4.IsChecked.Value)
            {
                ApplicationState.SetValue("sonarInfo4", "Upright");
            }
            else
            {
                ApplicationState.SetValue("sonarInfo4", "Inverted");
            }

            this.Close();
        }

        private void OnClickCancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnClickOpenFileDialog(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBoxFilePath.Text = folderBrowserDialog.SelectedPath;
        }

        private void OnClickYES(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnClickNO(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
