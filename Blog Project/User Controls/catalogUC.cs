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

namespace Blog_Project.User_Controls
{
    public partial class catalogUC : UserControl
    {
        BlogContext db = new BlogContext();
        public string userName { get; set; }
        public string password { get; set; }
        int categoryId;
        public catalogUC()
        {
            InitializeComponent();
        }

        private void catalogUC_Load(object sender, EventArgs e)
        {
            this.FindForm().Cursor = Cursors.WaitCursor;
            btn_edit.Enabled = false;
            txt_name.Text = txt_desc.Text = "";
            dgv.DataSource = db.Categories.ToList();
            this.FindForm().Cursor = Cursors.Default;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_desc.Text != "" && txt_name.Text != "")
                {
                    this.FindForm().Cursor = Cursors.WaitCursor;
                    Category category = new Category()
                    {
                        name = txt_name.Text,
                        desc = txt_desc.Text,
                    };
                    db.Categories.Add(category);
                    db.SaveChanges();
                    catalogUC_Load(null, null);
                    txt_name.Text = txt_desc.Text = "";
                    MessageBox.Show("Add successfully");
                    this.FindForm().Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Fill the item ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {


            try
            {
                this.FindForm().Cursor = Cursors.WaitCursor;
                var category = db.Categories.Where(x => x.id == categoryId).SingleOrDefault();
                category.name = txt_name.Text;
                category.desc = txt_desc.Text;

                db.Categories.Update(category);
                db.SaveChanges();

                MessageBox.Show("Updated");
                catalogUC_Load(null, null);
                txt_name.Text = txt_desc.Text = "";
                this.FindForm().Cursor = Cursors.Default;
                btn_add.Enabled = true;
                btn_edit.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv.Rows[e.RowIndex];
            categoryId = (int)row.Cells[0].Value;
            txt_name.Text = row.Cells[1].Value.ToString();
            txt_desc.Text = row.Cells[2].Value.ToString();
            btn_edit.Enabled = true;
            btn_add.Enabled = false;
        }
    }
}
