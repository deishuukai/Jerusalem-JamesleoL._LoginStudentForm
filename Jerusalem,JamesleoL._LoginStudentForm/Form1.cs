namespace Jerusalem_JamesleoL._LoginStudentForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            if (username == "james" && password == "12345")
            {
                MessageBox.Show("Login Successfully");
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
                MessageBox.Show("Error");
        }
    }
}
