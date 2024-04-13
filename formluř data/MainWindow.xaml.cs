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

namespace formluř_data
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> items = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            ListBox.ItemsSource = items;
        }

        private void Del_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            Okno vstup = new Okno();
            vstup.ShowDialog();
            string userInputText = vstup.Zaznam1;
            string userInputType = vstup.Zaznam2;

            if (!string.IsNullOrEmpty(userInputText))
            {
                items.Add($"{userInputText} {userInputType} ({DateTime.Now.ToString("d")})");
                ListBox.Items.Refresh();
            }

        }
    }
}