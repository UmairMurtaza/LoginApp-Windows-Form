using BusinessLogicLayer;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        private readonly MyBusinessLogic _businessLogic = new MyBusinessLogic();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string username = UsernametextBox.Text.Trim();
           string password = PasswordtextBox.Text.Trim();
         

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            bool isAuthenticated = _businessLogic.Login(username, password);
            if (isAuthenticated)
            {
                MessageBox.Show("Login Successful!");
                // Redirect to another form if needed
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }
        }
    }
}
