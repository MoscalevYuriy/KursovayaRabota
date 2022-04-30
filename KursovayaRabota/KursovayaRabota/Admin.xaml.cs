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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void buttonOlimpInfo_Click(object sender, RoutedEventArgs e)
        {
            AdminOlimp adminolimp = new AdminOlimp();
            adminolimp.Show();
            this.Close();
        }

        private void buttonAdminBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void buttonUchastnikInfo_Click(object sender, RoutedEventArgs e)
        {
            UchastnikiInfo result = new UchastnikiInfo();
            result.Show();
            this.Close();

        }
    }
}
