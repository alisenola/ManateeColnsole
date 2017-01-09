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

namespace ManateeConsole
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button backButton;

        public MainWindow()
        {
            InitializeComponent();
            
            backButton = new Button();
            backButton.Content = "Back";
            backButton.Width = 60;
            backButton.Height = 30;
            backButton.Margin = new Thickness(20);
            backButton.HorizontalAlignment = HorizontalAlignment.Right;
            backButton.VerticalAlignment = VerticalAlignment.Top;
        }

        private void OnMouseDownSonar1(object sender, MouseButtonEventArgs e)
        {
            MainGrid.RowDefinitions.Clear();

            MiddleGrid.Visibility = Visibility.Hidden;
            BottomGrid.Visibility = Visibility.Hidden;

            TopGrid.ColumnDefinitions.Clear();

            sonar2.Visibility = Visibility.Hidden;
            sonar3.Visibility = Visibility.Hidden;

            backButton.Click += new RoutedEventHandler(MinimizeTopGrid);
            TopGrid.Children.Add(backButton);
        }

        private void OnMouseDownSonar2(object sender, MouseButtonEventArgs e)
        {
            MainGrid.RowDefinitions.Clear();

            MiddleGrid.Visibility = Visibility.Hidden;
            BottomGrid.Visibility = Visibility.Hidden;

            TopGrid.ColumnDefinitions.Clear();

            sonar1.Visibility = Visibility.Hidden;
            sonar3.Visibility = Visibility.Hidden;

            backButton.Click += new RoutedEventHandler(MinimizeTopGrid);
            TopGrid.Children.Add(backButton);
        }

        private void OnMouseDownSonar3(object sender, MouseButtonEventArgs e)
        {
            MainGrid.RowDefinitions.Clear();

            MiddleGrid.Visibility = Visibility.Hidden;
            BottomGrid.Visibility = Visibility.Hidden;

            TopGrid.ColumnDefinitions.Clear();

            sonar1.Visibility = Visibility.Hidden;
            sonar2.Visibility = Visibility.Hidden;

            backButton.Click += new RoutedEventHandler(MinimizeTopGrid);
            TopGrid.Children.Add(backButton);
        }

        private void OnMouseDownVideo1(object sender, MouseButtonEventArgs e)
        {
            MainGrid.RowDefinitions.Clear();

            TopGrid.Visibility = Visibility.Hidden;
            BottomGrid.Visibility = Visibility.Hidden;

            MiddleGrid.ColumnDefinitions.Clear();

            video2.Visibility = Visibility.Hidden;
            video3.Visibility = Visibility.Hidden;

            backButton.Click += new RoutedEventHandler(MinimizeMiddleGrid);
            MiddleGrid.Children.Add(backButton);
        }

        private void OnMouseDownVideo2(object sender, MouseButtonEventArgs e)
        {
            MainGrid.RowDefinitions.Clear();

            TopGrid.Visibility = Visibility.Hidden;
            BottomGrid.Visibility = Visibility.Hidden;

            MiddleGrid.ColumnDefinitions.Clear();

            video1.Visibility = Visibility.Hidden;
            video3.Visibility = Visibility.Hidden;

            backButton.Click += new RoutedEventHandler(MinimizeMiddleGrid);
            MiddleGrid.Children.Add(backButton);
        }

        private void OnMouseDownVideo3(object sender, MouseButtonEventArgs e)
        {
            MainGrid.RowDefinitions.Clear();

            TopGrid.Visibility = Visibility.Hidden;
            BottomGrid.Visibility = Visibility.Hidden;

            MiddleGrid.ColumnDefinitions.Clear();

            video1.Visibility = Visibility.Hidden;
            video2.Visibility = Visibility.Hidden;

            backButton.Click += new RoutedEventHandler(MinimizeMiddleGrid);
            MiddleGrid.Children.Add(backButton);
        }

        private void MinimizeTopGrid(object sender, RoutedEventArgs e)
        {
            MainGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            MainGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            MainGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });

            TopGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            TopGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(3, GridUnitType.Star) });
            TopGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            TopGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(3, GridUnitType.Star) });
            TopGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            TopGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(3, GridUnitType.Star) });
            TopGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });

            Grid.SetRow(TopGrid, 0);
            Grid.SetRow(MiddleGrid, 1);
            Grid.SetRow(BottomGrid, 2);

            Grid.SetColumn(sonar1, 1);
            Grid.SetColumn(sonar2, 3);
            Grid.SetColumn(sonar3, 5);

            sonar1.Visibility = Visibility.Visible;
            sonar2.Visibility = Visibility.Visible;
            sonar3.Visibility = Visibility.Visible;

            TopGrid.Visibility = Visibility.Visible;
            MiddleGrid.Visibility = Visibility.Visible;
            BottomGrid.Visibility = Visibility.Visible;

            backButton.Click -= new RoutedEventHandler(MinimizeTopGrid);
            TopGrid.Children.Remove(backButton);
        }

        private void MinimizeMiddleGrid(object sender, RoutedEventArgs e)
        {
            MainGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            MainGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            MainGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });

            MiddleGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            MiddleGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            MiddleGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });

            Grid.SetRow(TopGrid, 0);
            Grid.SetRow(MiddleGrid, 1);
            Grid.SetRow(BottomGrid, 2);

            Grid.SetColumn(video1, 0);
            Grid.SetColumn(video2, 1);
            Grid.SetColumn(video3, 2);

            video1.Visibility = Visibility.Visible;
            video2.Visibility = Visibility.Visible;
            video3.Visibility = Visibility.Visible;

            TopGrid.Visibility = Visibility.Visible;
            MiddleGrid.Visibility = Visibility.Visible;
            BottomGrid.Visibility = Visibility.Visible;

            backButton.Click -= new RoutedEventHandler(MinimizeMiddleGrid);
            MiddleGrid.Children.Remove(backButton);
        }

        private void OnClickSonarSettings(object sender, RoutedEventArgs e)
        {
            SonarSettings sonar;
            sonar = new SonarSettings();
            sonar.Show();
            sonar.Activate();
        }

        private void OnClickCameraSettings(object sender, RoutedEventArgs e)
        {
            CameraSettings camera;
            camera = new CameraSettings();
            camera.Show();
            camera.Activate();
        }

        private void OnClickPanTiltSettings(object sender, RoutedEventArgs e)
        {
            PanTiltSettings pantilt;
            pantilt = new PanTiltSettings();
            pantilt.Show();
            pantilt.Activate();
        }

        private void OnClickSystemDiagnostics(object sender, RoutedEventArgs e)
        {
            SystemDiagnostics system;
            system = new SystemDiagnostics();
            system.Show();
            system.Activate();
        }
    }

    public static class ApplicationState
    {
        private static Dictionary<string, object> _values = new Dictionary<string, object>();

        public static void SetValue(string key, object value)
        {
            if (_values.ContainsKey(key))
            {
                _values.Remove(key);
            }
            _values.Add(key, value);
        }

        public static T GetValue<T>(string key)
        {
            if (_values.ContainsKey(key))
            {
                return (T)_values[key];
            }
            else
            {
                return default(T);
            }
        }
    }
}
