using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electro_Fih
{
    public partial class LoginPage : Form
    {
        private readonly HttpClient client;

        public LoginPage()
        {
            InitializeComponent();

            // Base address of the API
            client = new HttpClient
            {
                BaseAddress = new Uri("http://100.122.255.19:5229/")
            };
        }

        // ================= LOGIN =================
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            string email = txtboxEmail.Text.Trim();
            string password = txtboxPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter email and password");
                return;
            }

            try
            {
                var loginData = new { email = email, password = password };
                string json = JsonConvert.SerializeObject(loginData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("api/auth/login", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres bejelentezés!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var mainForm = new Form1();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nem megegyező email vagy jelszó!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Cannot reach server. Check your connection or API URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= REGISTER =================
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtboxEmail.Text.Trim();
            string password = txtboxPassword.Text;

            //MessageBox.Show(
            //    $"Email=[{txtboxEmail.Text}] Password=[{txtboxPassword.Text}]"
            //);




            //if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            //{
            //    MessageBox.Show("Fields are empty BEFORE sending");
            //    return;
            //}

            var payload = new
            {
                email = email,
                password = password
            };

            string json = JsonConvert.SerializeObject(payload);

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://100.122.255.19:5229/");

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response =
                    await client.PostAsync("api/auth/register", content);

                string responseText = await response.Content.ReadAsStringAsync();

                MessageBox.Show(
                    "Status: " + (int)response.StatusCode + "\n" +
                    responseText
                );
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loginPageLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
