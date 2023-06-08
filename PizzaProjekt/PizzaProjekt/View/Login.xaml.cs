using Newtonsoft.Json;
using PizzaProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PizzaProjekt.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        bool IsPasswordCorrect;
        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            int NameId = await GetIdFromName(Name.Text);

            if(NameId == -1) {
                ResponseText.Text = "Nem található ilyen felhasználónév";

            }
            else
            {
                IsPasswordCorrect = await GetPasswordFromId(NameId);
            }

            if (IsPasswordCorrect)
            {
                ResponseText.Text = "Sikeres bejelentkezés!";
                MainWindow window = new MainWindow();
                this.Close();
                window.Show();
            }
            else
            {
                ResponseText.Text = "Helytelen jelszó!";
            }



        }

        private async Task<int> GetIdFromName(string name)
        {
            using(HttpClient client = new HttpClient())
            {

                var response = await client.GetAsync("https://localhost:7216/Name/" + name);
                if(response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<IdModel>(await response.Content.ReadAsStringAsync());
                    return result.Id;
                }
                return -1;
            }
        }

        private async Task<bool> GetPasswordFromId(int id)
        {
            using(HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7216/Password/" + id);
                if(response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<PasswordModel>(await response.Content.ReadAsStringAsync());
                    if(result.Password == Password.Text)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
