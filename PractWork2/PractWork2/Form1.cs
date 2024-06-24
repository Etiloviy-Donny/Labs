namespace PractWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            if (string.IsNullOrEmpty(login)||string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            if(CheckifUserExists(login))
            {

            }    
        }
    }
}
