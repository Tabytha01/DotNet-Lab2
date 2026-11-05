namespace Lab_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Trim() == "" || txtpass.Text.Trim() == "")
            {
                MessageBox.Show("Username and Password cannot be empty");
            }
            else
            {
                txtuser.Clear();
                txtpass.Clear();
                ChooseForm choose = new ChooseForm();
                choose.Show();
                this.Hide();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
