using Blog_Project.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class allpostsUC : UserControl
    {
        BlogContext db = new BlogContext();
        public string userName { get; set; }
        public string password { get; set; }
        Auther auther;
        int postId;
        public allpostsUC()
        {
            InitializeComponent();
        }
        void GetData()
        {
            this.FindForm().Cursor = Cursors.WaitCursor;
            dgv_allposts.DataSource = db.Posts.Include(x => x.auther).Include(x => x.category).ToList();
            this.FindForm().Cursor = Cursors.Default;
            var category = db.Categories.ToList();
            cb_category.DataSource = category;
            cb_category.ValueMember = "id";
            cb_category.DisplayMember = "name";
            txt_bref.Text = txt_desc.Text = txt_title.Text = "";
        }
        private void allpostsUC_Load(object sender, EventArgs e)
        {
            GetData();
            auther = db.Authers.Where(x => x.userName == userName && x.password == password).FirstOrDefault();
            btn_edit.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_title.Text != "")
            {
                try
                {
                    DateTime time = DateTime.Now;
                    post post = new post()
                    {
                        title = txt_title.Text,
                        bref = txt_bref.Text,
                        date = time,
                        time = time.TimeOfDay,
                        desc = txt_desc.Text,
                        categoryId = Convert.ToInt32(cb_category.SelectedValue),
                        autherId = auther.id,
                    };
                    this.FindForm().Cursor = Cursors.WaitCursor;
                    db.Posts.Add(post);
                    db.SaveChanges();
                    MessageBox.Show("Added");
                    GetData();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
            else
            {
                MessageBox.Show("Cant insert Empty!");
            }
            

        }

        private void dgv_allposts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //var auther = db.Authers.Where(x => x.userName == userName && x.password == password).FirstOrDefault();
                DataGridViewRow row = dgv_allposts.Rows[e.RowIndex];
                if (auther.id == Convert.ToInt32(row.Cells[7].Value))
                {
                    btn_edit.Enabled = true;
                    postId = (int)row.Cells[0].Value;
                    txt_title.Text = row.Cells[1].Value.ToString();
                    txt_bref.Text = row.Cells[2].Value.ToString();
                    txt_desc.Text = row.Cells[3].Value.ToString();
                    cb_category.SelectedValue = Convert.ToInt32(row.Cells[9].Value);
                    btn_add.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Show only not edit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_title.Text != "")
            {
try
                {
                this.FindForm().Cursor = Cursors.WaitCursor;
                DateTime time = DateTime.Now;
                    var post = db.Posts.Where(x => x.id == postId).SingleOrDefault();
                    post.title = txt_title.Text;
                    post.desc = txt_desc.Text;
                    post.bref = txt_bref.Text;
                    post.date = time;
                    post.time = time.TimeOfDay;
                    post.categoryId = Convert.ToInt32(cb_category.SelectedValue);
                    db.Posts.Update(post);
                    db.SaveChanges();
                    MessageBox.Show("Updated");

                    btn_add.Enabled = true;
                    btn_edit.Enabled=false;
                GetData();
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Can't Insert Empty!");
            }  
            

        }
    }

}
