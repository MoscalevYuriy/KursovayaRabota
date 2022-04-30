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
    /// Логика взаимодействия для UchastnikiInfo.xaml
    /// </summary>
    public partial class UchastnikiInfo : Window
    {
        public UchastnikiInfo()
        {
            InitializeComponent();
            dataGridUchastniki.ItemsSource = KursovayaEntities1.GetContext().Информация_об_участниках.ToList();
        }

        private void buttonOlimpDelete_Click(object sender, RoutedEventArgs e)
        {
            var Информация_об_участникахForRemoving = dataGridUchastniki.SelectedItems.Cast<Информация_об_участниках>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {Информация_об_участникахForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    KursovayaEntities1.GetContext().Информация_об_участниках.RemoveRange(Информация_об_участникахForRemoving);
                    KursovayaEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    dataGridUchastniki.ItemsSource = KursovayaEntities1.GetContext().Информация_об_участниках.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void buttonAdminBack_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void buttonAdminOlimpReload_Click(object sender, RoutedEventArgs e)
        {
            dataGridUchastniki.ItemsSource = KursovayaEntities1.GetContext().Информация_об_участниках.ToList();

        }

        private void imageOlimpEdit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
    }

