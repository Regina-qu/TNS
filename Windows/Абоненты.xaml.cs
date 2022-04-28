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

namespace TNS.Windows
{
    /// <summary>
    /// Логика взаимодействия для Абоненты.xaml
    /// </summary>
    public partial class Абоненты : Window
    {
        public Абоненты()
        {
            InitializeComponent();
        }

        private void УправлениеОборудованием_Click(object sender, RoutedEventArgs e)
        {
            УправлениеОборудованием управление = new УправлениеОборудованием();
            управление.Show();
            Hide();
        }

        private void Активы_Click(object sender, RoutedEventArgs e)
        {
            Активы активы = new Активы();
            активы.Show();
            Hide();
        }

        private void Биллинг_Click(object sender, RoutedEventArgs e)
        {
            Биллинг биллинг = new Биллинг();
            биллинг.Show();
            Hide();
        }

        private void ПоддержкаПользователей_Click(object sender, RoutedEventArgs e)
        {
            ПоддержкаПользователей поддержка = new ПоддержкаПользователей();
            поддержка.Show();
            Hide();
        }

        private void CRM_Click(object sender, RoutedEventArgs e)
        {
            CRM crm = new CRM();
            crm.Show();
            Hide();
        }

        private void абоненты_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
