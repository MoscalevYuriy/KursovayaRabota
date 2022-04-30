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
using System.Data.SqlClient;
using System.Data;

namespace KursovayaRabota
{
    /// <summary>
    /// Логика взаимодействия для AdminOlimp.xaml
    /// </summary>
    public partial class AdminOlimp : Window
    {

        public AdminOlimp()
        {
            InitializeComponent();
            dataGridOlimpiad.ItemsSource = KursovayaEntities1.GetContext().Информация_об_олимпиадах.ToList();
        }

        private void buttonAdminBack_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        public void dataGridOlimpiad_Loaded(object sender, RoutedEventArgs e)
        {       
        }

        private void buttonOlimpSave_Click(object sender, RoutedEventArgs e)
        {
        }

        private void buttonOlimpAdd_Click(object sender, RoutedEventArgs e)
        {
            addOlimpiad add = new addOlimpiad(null);
            add.Show();
        }

        private void buttonAdminOlimpReload_Click(object sender, RoutedEventArgs e)
        {
           // KursovayaEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload);
            dataGridOlimpiad.ItemsSource = KursovayaEntities1.GetContext().Информация_об_олимпиадах.ToList();
        }

        private void imageOlimpEdit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            addOlimpiad add = new addOlimpiad((sender as Image).DataContext as Информация_об_олимпиадах);
            add.Show();
        }

        private void buttonOlimpDelete_Click(object sender, RoutedEventArgs e)
        {
            var Информация_об_олимпиадахForRemoving = dataGridOlimpiad.SelectedItems.Cast<Информация_об_олимпиадах>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {Информация_об_олимпиадахForRemoving.Count()} элементов?","Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question)==MessageBoxResult.Yes)
            {
                try
                {
                    KursovayaEntities1.GetContext().Информация_об_олимпиадах.RemoveRange(Информация_об_олимпиадахForRemoving);
                    KursovayaEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    dataGridOlimpiad.ItemsSource = KursovayaEntities1.GetContext().Информация_об_олимпиадах.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
