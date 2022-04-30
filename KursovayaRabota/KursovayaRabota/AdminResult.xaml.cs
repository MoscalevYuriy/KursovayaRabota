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
    /// Логика взаимодействия для AdminResult.xaml
    /// </summary>
    public partial class AdminResult : Window
    {
        public AdminResult()
        {
            InitializeComponent();
            dataGridResult.ItemsSource = KursovayaEntities1.GetContext().Результаты_участников.ToList();
        }

        private void imageOlimpEdit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            addOlimpiad add = new addOlimpiad((sender as Image).DataContext as Информация_об_олимпиадах);
        }

        private void buttonOlimpAdd_Click(object sender, RoutedEventArgs e)
        {
            var Результаты_участниковForRemoving = dataGridResult.SelectedItems.Cast<Результаты_участников>().ToList();

            KursovayaEntities1.GetContext().Результаты_участников.RemoveRange(Результаты_участниковForRemoving);
            KursovayaEntities1.GetContext().SaveChanges();

            MessageBox.Show("Данные сохранены!");
        }

        private void buttonAdminOlimpReload_Click(object sender, RoutedEventArgs e)
        {
            dataGridResult.ItemsSource = KursovayaEntities1.GetContext().Результаты_участников.ToList();
        }

        private void buttonAdminOlimpBack_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}
