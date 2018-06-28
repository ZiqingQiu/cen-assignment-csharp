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

namespace BindingToUIControl
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

        private void ButtonHandler(object sender, RoutedEventArgs e)
        {
            Button button = e.Source as Button;
            switch (button.Name)
            {
                case "btnCoding":
                    new winCoding().ShowDialog();
                    break;
                case "btnTwoWay":
                    new winTwoWay().ShowDialog();
                    break;
                case "btnOneWayToSource":
                    new winOneWayToSource().ShowDialog();
                    break;
                case "btnOneWayToTarget":
                    new winOneWayToTarget().ShowDialog();
                    break;
                case "btnOneTime":
                    new winOneTime().ShowDialog();
                    break;
            }
        }
    }
}
