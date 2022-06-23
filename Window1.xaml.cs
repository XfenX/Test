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

namespace testikaaaaaaaaaaaaa
{
	/// <summary>
	/// Логика взаимодействия для Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			
			InitializeComponent();
		}

		private void Auth(object sender, RoutedEventArgs e)
		{
			Window k = new MainWindow();
			
			if (Login.Text == "Admin" && password.Password == "Admin")
			{ 
				this.Close();
				k.Show();
			}
			else MessageBox.Show("НЕ ПАРВИЛЬНО УЁБА");
			Login.Clear();
			password.Clear();
		}

		private void Clear(object sender, RoutedEventArgs e)
		{
			Login.Text = "";
			password.Password = "";
		}

        private void Login_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
			if (Login.Text == "Имя")
            {
				Login.Text = "";
			}
        }
    }
}
