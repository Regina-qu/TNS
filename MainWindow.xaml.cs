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
using TNS.Windows;

namespace TNS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Вход_Click(object sender, RoutedEventArgs e)
        {
            Абоненты абоненты = new Абоненты();
            абоненты.Show();
            Hide();
        }

        private void Отмена_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
