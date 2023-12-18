using Blog_Project.User_Controls;

namespace Blog_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AddUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Bottom;
            panal.Controls.Clear();
            panal.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public void RemoveUC()
        {
            panal.Controls.Clear();
        }
        private void btn_signUp_Click(object sender, EventArgs e)
        {
            signupUC UC = new signupUC();
            AddUC(UC);
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            logInUC UC = new logInUC();
            AddUC(UC);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            

        }
    }
}
