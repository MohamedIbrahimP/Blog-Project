using Blog_Project.Models;
using System.Data;


namespace Blog_Project.User_Controls
{
    public partial class myprofileUC : UserControl
    {
        BlogContext db = new BlogContext();
        public string userName { get; set; }
        public string password { get; set; }
        byte[] imageData;

        public myprofileUC()
        {
            InitializeComponent();
        }

        private void myprofileUC_Load(object sender, EventArgs e)
        {
            try
            {
                this.FindForm().Cursor = Cursors.WaitCursor;
                var user = db.Authers.Where(x => x.userName == userName && x.password == password).FirstOrDefault();
                Auther auther = new Auther()
                {
                    userName = user.userName,
                    age = user.age,
                    email = user.email,
                    password = user.password,
                    image = user.image,
                };
                txt_name.Text = auther.userName;
                txt_age.Text = auther.age.ToString();
                txt_email.Text = auther.email;
                txt_password.Text = auther.password;
                txt_confirmpassword.Text = auther.password;
                if(auther.image != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream(auther.image))
                    {
                        pic.Image = Image.FromStream(memoryStream);
                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        pic.Image = new Bitmap(pic.Image, pic.Width, pic.Height);
                    }
                }
                this.FindForm().Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_name.ReadOnly = txt_password.ReadOnly = txt_email.ReadOnly = txt_confirmpassword.ReadOnly = txt_age.ReadOnly = false;
        }

        private void btn_savechange_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_password.Text == txt_confirmpassword.Text)
                {
                    this.FindForm().Cursor = Cursors.WaitCursor;
                    var user = db.Authers.Where(x => x.userName == userName && x.password == password).FirstOrDefault();
                    user.userName = txt_name.Text;
                    user.age = Convert.ToInt32(txt_age.Text);
                    user.email = txt_email.Text;
                    user.password = txt_password.Text;
                    user.confirmPassword = txt_confirmpassword.Text;
                    user.image = imageData;

                    db.Authers.Update(user);
                    db.SaveChanges();
                    MessageBox.Show("Updated successful!");
                    txt_name.ReadOnly = txt_password.ReadOnly = txt_email.ReadOnly = txt_confirmpassword.ReadOnly = txt_age.ReadOnly = true;
                    this.FindForm().Cursor=Cursors.Default;
                }
                else
                {
                    string message2 = "Password not match";
                    string title2 = "Title";
                    MessageBox.Show(message2, title2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // openFileDialog.Filter = "Image Files (.jpg;.jpeg; .png)|.jpg; .jpeg;.png";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    imageData = File.ReadAllBytes(openFileDialog.FileName);

                    try
                    {
                        pic.Image = Image.FromFile(openFileDialog.FileName);
                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        pic.Image = new Bitmap(pic.Image, pic.Width, pic.Height);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error displaying image: " + ex.Message);
                    }

                }
            }
        }



    }
}
