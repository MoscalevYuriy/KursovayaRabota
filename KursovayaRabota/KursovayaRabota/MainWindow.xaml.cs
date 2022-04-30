using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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


namespace KursovayaRabota
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

        private void buttonEnter_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            Admin admin = new Admin();

            if (textBoxLogin.Text.Length > 0)
            {
                if (passBox.Password.Length > 0)
                {
                    DataTable dt_user = main.Select("SELECT * FROM [dbo].[Авторизация] WHERE [логин] = " +
                        "'" + textBoxLogin.Text + "' AND [пароль] = '" + passBox.Password + "'");
                    if (dt_user.Rows.Count > 0) // если такая запись существует
                    {
                        this.Hide();
                        admin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Данного пользователя не существует!");
                    }
                }
                else
                {
                    MessageBox.Show("Данного пользователя не существует!");
                }
            }
            else
            {
                MessageBox.Show("Данного пользователя не существует!");
            }

        }

        private void buttonReg_Click(object sender, RoutedEventArgs e)
        {
            goZayavka menu = new goZayavka();
            menu.Show();
            this.Close();
        }

        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
                                                                            // подключаемся к базе данных
            SqlConnection sqlConnection = new SqlConnection("server=KXRSTI\\SQLEXPRESS01;Trusted_Connection=Yes;" +
                "DataBase=Kursovaya;");
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);                                 // возращаем таблицу с результатом
            return dataTable;
        }
    }
}
