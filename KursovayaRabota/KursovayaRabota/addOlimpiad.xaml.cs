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
    /// Логика взаимодействия для addOlimpiad.xaml
    /// </summary>
    public partial class addOlimpiad : Window
    {

        private Информация_об_олимпиадах _currentOlimp = new Информация_об_олимпиадах();

        public addOlimpiad(Информация_об_олимпиадах selectedинформация_Об_Олимпиадах)
        {
            InitializeComponent();

            if (selectedинформация_Об_Олимпиадах != null)
                _currentOlimp = selectedинформация_Об_Олимпиадах;

            DataContext = _currentOlimp;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_currentOlimp.Название == null)
                errors.AppendLine("Укажите название олимпиады");
            if (_currentOlimp.Компетенция == null)
                errors.AppendLine("Укажите компетенцию");

            if (errors.Length>0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentOlimp.ID == 0)
                KursovayaEntities1.GetContext().Информация_об_олимпиадах.Add(_currentOlimp);
            try
            {
                KursovayaEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация добавлена!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
