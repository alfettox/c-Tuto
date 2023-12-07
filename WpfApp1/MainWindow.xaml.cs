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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //need to downcast to button, use as to avoid problems at runtime
            //var button = (Button)sender;
            var button2 = sender as Button;
            if (button2 != null){
                MessageBox.Show(button2.ActualHeight.ToString());
            }
            MessageBox.Show("Hello world");
        }
    }
}