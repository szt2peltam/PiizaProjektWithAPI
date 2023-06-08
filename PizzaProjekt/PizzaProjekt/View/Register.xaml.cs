using Newtonsoft.Json;
using PizzaProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PizzaProjekt.View
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void BackToLogin(object sender, RoutedEventArgs e)
        {
            Login window = new Login();
            this.Close();
            window.Show();
        }

        private async void RegisterUser(object sender, RoutedEventArgs e)
        {
            using(HttpClient client = new HttpClient())
            {
                if (NameInput.Text == "" ) Warning.Text = "Felhasználónév mező üres";
                if (PasswordInput.Text == "" ) Warning.Text = "Jelszó mező üres";
                if (NameInput.Text == "" && PasswordInput.Text == "") Warning.Text = "Mezők üresek"; 
                if(NameInput.Text.Length > 0 && PasswordInput.Text.Length > 0)
                {
                    var User = new UserModel { Id = 0, Name = NameInput.Text, Password = PasswordInput.Text };
                    var response = await client.PostAsync("https://localhost:7216/Users", new StringContent(JsonConvert.SerializeObject(User), Encoding.UTF8, "application/json") );
                    if(response.IsSuccessStatusCode) {

                        Warning.Text = "Sikeres regiszráció";
                    }
                    else
                    {
                        Warning.Text = "Regisztráció sikertelen "+ response.StatusCode;
                    }

                }
            }
        }

    }
}
