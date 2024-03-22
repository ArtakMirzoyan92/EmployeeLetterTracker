using EmployeeLetter.App.Models;
using Newtonsoft.Json;
using System.Text;

namespace EmployeeLetter.App
{
    public partial class SaveLetter : Form
    {       

        public SaveLetter()
        {
            InitializeComponent();          
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                MessageBox.Show(isNullOrEmpty);
                return;
            }
            using (var client = new HttpClient())
            {
                try
                {

                    var letterData = new IncomingLetter()
                    {
                        Title = Title.Text,
                        Sender = Sender.Text,
                        Content = Content.Text,
                        Recipient = Recipient.Text,
                    };

                    var json = JsonConvert.SerializeObject(letterData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = client.PostAsync(apiUrl, content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(letterSuccess);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show($"{letterError}: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{letterError} {ex.Message}");
                }
            }
        }
        #region Helpers

        bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(Title.Text) ||
                string.IsNullOrWhiteSpace(Sender.Text) ||
                string.IsNullOrWhiteSpace(Content.Text) ||
                string.IsNullOrWhiteSpace(Recipient.Text))
                return true;
            return false;
        }

        void ClearFields()
        {
            Title.Text = null;
            Sender.Text = null;
            Content.Text = null;
            Recipient.Text = null;
        }

        const string isNullOrEmpty = "Все поля должны быть заполненный";
        const string apiUrl = "https://localhost:7238/Letter/AddLetter";
        const string letterSuccess = "Письмо успешно отправлено";
        const string letterError = "Ошибка";
        #endregion
    }
}
