using Blog_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Blog_Project.User_Controls
{
    public partial class signupUC : UserControl
    {
        BlogContext db = new BlogContext();
        public signupUC()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Auther auther = new Auther()
            {
                userName = txt_name.Text,
                age = Convert.ToInt32(txt_age.Text),
                email = txt_email.Text,
                password = txt_password.Text,
                confirmPassword = txt_confirmpassword.Text,
            };
            this.FindForm().Cursor = Cursors.WaitCursor;
            var validEmail = ValidateUser.ValidateEmail(auther.email);
            var validPass = ValidateUser.ValidatePassword(auther.password);
            var validUserName = ValidateUser.IsUserNameValid(auther.userName, db);
            var validAge = ValidateUser.ValidateAge(auther.age);

            if (validEmail && validPass && validUserName && validAge)
            {
                db.Authers.Add(auther);
                db.SaveChanges();
                MessageBox.Show("Registration successful!");
                this.FindForm().Cursor = Cursors.Default;
                profileForm profile = new profileForm();
                profile.userName = auther.userName;
                profile.password = auther.password;
                profile.welcome = (Form1)this.FindForm();
                profile.Show();
                this.FindForm().Hide();
            }

        }
        private void signupUC_Load(object sender, EventArgs e)
        {

        }
    }
}
