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
    /// Логика взаимодействия для addZayavka.xaml
    /// </summary>
    public partial class addZayavka : Window
    {

        private Информация_об_участниках _currentUchastniki = new Информация_об_участниках();
        //private Результаты_участников _currentResult = new Результаты_участников();

        public addZayavka()
        {
            InitializeComponent();
            DataContext = _currentUchastniki;
            //DataContext = _currentResult;
        }

        private void buttonGoZayavka_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_currentUchastniki.ФИО == null)
                errors.AppendLine("Укажите ФИО");
            if (_currentUchastniki.ID_Олимпиады  == null)
                errors.AppendLine("Укажите ID олимпиады");
            if (_currentUchastniki.Электронная_почта == null)
                errors.AppendLine("Укажите электронную почту");
            if (_currentUchastniki.Номер_телефона == null)
                errors.AppendLine("Укажите номер телефона");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentUchastniki.ID_участника == 0)
                KursovayaEntities1.GetContext().Информация_об_участниках.Add(_currentUchastniki);
               // KursovayaEntities1.GetContext().Результаты_участников.Add(_currentResult);
            try
            {
                //Результаты_участников _currentResult = new Результаты_участников();
                //DataContext = _currentResult;
                //KursovayaEntities1.GetContext().Результаты_участников.Add(_currentResult);


                KursovayaEntities1.GetContext().SaveChanges();
                MessageBox.Show("Заявка успешно подана");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        
    }
    }
}
