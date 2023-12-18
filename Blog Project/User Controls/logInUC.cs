using Blog_Project.Models;
using System.Data;

namespace Blog_Project.User_Controls
{
    public partial class logInUC : UserControl
    {
        BlogContext db = new BlogContext();
        
        public string userName { get; set; }
        public string password { get; set; }

        public logInUC()
        {
            InitializeComponent();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            userName = txt_userName.Text;
            password = txt_password.Text;
            if (userName == "" || password == "")
            {
                MessageBox.Show("You Need To Sign Up First!");
                signupUC UC = new signupUC();
                Form1 welcome = (Form1)this.FindForm();
                welcome.AddUC(UC);
            }
            else
            {
                this.FindForm().Cursor = Cursors.AppStarting;
                var user = db.Authers.Where(x => x.userName == userName && x.password == password).FirstOrDefault();
                if (user == null)
                {
                    this.FindForm().Cursor = Cursors.Default;
                    MessageBox.Show("Fill User Name or Password Correctely!");
                }
                else
                {
                    profileForm profile = new profileForm();
                    profile.userName = userName;
                    profile.password = password;
                    profile.welcome = (Form1)this.FindForm();
                    if(user.image!= null)
                    {
                    profile.imageData = user.image;
                    }
                    profile.Show();
                    this.FindForm().Hide();
                   
                }


            }

        }
        private void logInUC_Load(object sender, EventArgs e)
        {

        }
    }
}
