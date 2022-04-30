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

namespace KursovayaRabota
{
    /// <summary>
    /// Логика взаимодействия для goZayavka.xaml
    /// </summary>
    public partial class goZayavka : Window
    {
        public goZayavka()
        {
            InitializeComponent();
        }

        private void dataGridOlimpiad_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridOlimpiad.ItemsSource = KursovayaEntities1.GetContext().Информация_об_олимпиадах.ToList();
        }

        private void buttonAdminBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonAdminOlimpBack_Click(object sender, RoutedEventArgs e)
        {
            UchastnikMenu menu = new UchastnikMenu();
            menu.Show();
            this.Close();
        }

        private void buttongozayavka_Click(object sender, RoutedEventArgs e)
        {
            addZayavka add = new addZayavka();
            add.Show();
        }
    }
}
