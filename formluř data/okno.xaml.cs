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

namespace formluř_data
{
    /// <summary>
    /// Interakční logika pro okno.xaml
    /// </summary>
    public partial class Okno : Window
    {
        public string Zaznam1 { get; set; }
        public string Zaznam2 { get; set; }
        public Okno()
        {
            InitializeComponent();
            Zaznam1 = string.Empty;
            Zaznam2 = string.Empty;
        }

        private void Conf_button_Click(object sender, RoutedEventArgs e)
        {
            Zaznam2 = cmbbox.SelectedItem.ToString();
            Zaznam1 = Input_textbox.Text;
            Close();
        }
    }
}
