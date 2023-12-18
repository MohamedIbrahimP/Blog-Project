using Blog_Project.Models;
using Blog_Project.User_Controls;

namespace Blog_Project
{
    public partial class profileForm : Form
    {
        BlogContext db = new BlogContext();
        public string userName { get; set; }
        public string password { get; set; }
        public byte[] imageData;
        public Form1 welcome;
        myprofileUC myProfile = new myprofileUC();
        allpostsUC allposts = new allpostsUC();
        mypostsUC myPosts = new mypostsUC();
        catalogUC catalog = new catalogUC();
        public profileForm()
        {
            InitializeComponent();
        }
        public void AddUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void profileForm_Load(object sender, EventArgs e)
        {
            myProfile.userName = userName;
            myProfile.password = password;
            allposts.userName = userName;
            allposts.password = password;
            myPosts.userName = userName;
            myPosts.password = password;
            catalog.userName = userName;
            catalog.password = password;
            if (imageData != null)
            {
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    pic.Image = Image.FromStream(memoryStream);
                    pic.SizeMode = PictureBoxSizeMode.Normal;
                    pic.Image = new Bitmap(pic.Image, pic.Width, pic.Height);
                }
            }

            this.Cursor = Cursors.Default;
        }
        private void btn_profile_Click(object sender, EventArgs e)
        {
            AddUC(myProfile);
        }
        private void btn_allposts_Click(object sender, EventArgs e)
        {
            allposts.Dispose();
            allpostsUC newobj = new allpostsUC();
            newobj.userName = userName;
            newobj.password = password;
            AddUC(newobj);
        }
        private void btn_myposts_Click(object sender, EventArgs e)
        {
            myPosts.Dispose();
            mypostsUC newobj = new mypostsUC();
            newobj.userName = userName;
            newobj.password = password;
            AddUC(newobj);
        }
        private void btn_catalog_Click(object sender, EventArgs e)
        {
            AddUC(catalog);
        }
        private void btn_signout_Click(object sender, EventArgs e)
        {
            welcome.Show();
            welcome.RemoveUC();
            myProfile.Dispose();
            allposts.Dispose();
            myPosts.Dispose();
            catalog.Dispose();
            this.Dispose();
        }
        private void profileForm_FormClosing(object sender, FormClosingEventArgs e)
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
