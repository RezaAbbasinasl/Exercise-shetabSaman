using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercise_shetabSaman
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

        private void OpenWindows_Click(object sender, RoutedEventArgs e)
        {
            var screens = Screen.AllScreens;

            foreach (var screen in screens)
            {
                var monitorWindow = new MonitorWindow(screen);
                monitorWindow.Show();
            }
        }
    }
}