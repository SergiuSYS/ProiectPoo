using ProiectPoo.UI;

namespace ProiectPoo
{
    public partial class Form1 : Form
    {
        private ManagerUser userAccountManager = new ManagerUser();
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox1.Text;
            if (userAccountManager.Login(username, password))
            {
                MessageBox.Show("Login successful");
                Form2 form2 = new Form2(userAccountManager.GetAccount(username));
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox1.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both fields");
                return;
            }
            if (userAccountManager.UserExsist(username))
            {
                MessageBox.Show("This account already exists");
                return;
            }
            userAccountManager.Register(username, password);
            userAccountManager.SaveDataToJson();
        }
    }
}
