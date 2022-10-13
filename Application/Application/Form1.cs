namespace Applications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                UserAccount userAccount = new UserAccount();
                userAccount.Show();
            }
            else
            {
                MessageBox.Show("user ou mot de passe", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}