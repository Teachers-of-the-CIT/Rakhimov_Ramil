using DemoRakhimov4432.Utils;
using DemoRakhimov4432.Windows;
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

namespace DemoRakhimov4432
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        //DESKTOP-OFQHETB\SQLEXPRESS
        {
            InitializeComponent();
        }

        private void ButtonSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (txtPassword.Password == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            using (var db = new Model())
            {
                User user = (from u in db.User where u.Login == txtLogin.Text select u).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Данный пользователь не существует!");
                    return;
                }
                if (user.Password != txtPassword.Password)
                {
                    MessageBox.Show("Неправильно введен пароль");
                    return;
                }
                ApplicationContext.User = user;

                if (user.Role == "Клиент")
                {
                    ClientWindow clientWindow = new ClientWindow();
                    this.Close();
                    clientWindow.ShowDialog();
                }
                else if (user.Role == "Администратор")
                {
                    AdminWindow adminWindow = new AdminWindow();
                    this.Close();
                    adminWindow.ShowDialog();
                }
                else 
                {
                    ManagerWindow managerWindow = new ManagerWindow();
                    this.Close();
                    managerWindow.ShowDialog();
                }
            }
        }
    }
}
