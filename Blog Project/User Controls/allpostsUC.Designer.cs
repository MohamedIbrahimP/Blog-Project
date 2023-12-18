namespace Blog_Project.User_Controls
{
    partial class allpostsUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_allposts = new DataGridView();
            cb_category = new ComboBox();
            btn_add = new Button();
            label2 = new Label();
            txt_bref = new TextBox();
            label3 = new Label();
            txt_title = new TextBox();
            label1 = new Label();
            txt_desc = new TextBox();
            label4 = new Label();
            btn_edit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_allposts).BeginInit();
            SuspendLayout();
            // 
            // dgv_allposts
            // 
            dgv_allposts.BackgroundColor = SystemColors.Control;
            dgv_allposts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_allposts.Location = new Point(3, 142);
            dgv_allposts.Name = "dgv_allposts";
            dgv_allposts.RowHeadersWidth = 62;
            dgv_allposts.Size = new Size(738, 356);
            dgv_allposts.TabIndex = 0;
            dgv_allposts.RowHeaderMouseClick += dgv_allposts_RowHeaderMouseClick;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(561, 42);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(180, 38);
            cb_category.TabIndex = 4;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.SandyBrown;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_add.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(375, 86);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(180, 50);
            btn_add.TabIndex = 20;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 9);
            label2.Name = "label2";
            label2.Size = new Size(60, 30);
            label2.TabIndex = 19;
            label2.Text = "Bref";
            // 
            // txt_bref
            // 
            txt_bref.BorderStyle = BorderStyle.FixedSingle;
            txt_bref.Location = new Point(189, 42);
            txt_bref.Name = "txt_bref";
            txt_bref.Size = new Size(180, 38);
            txt_bref.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 17;
            label3.Text = "Title";
            // 
            // txt_title
            // 
            txt_title.BorderStyle = BorderStyle.FixedSingle;
            txt_title.Location = new Point(3, 42);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(180, 38);
            txt_title.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 22;
            label1.Text = "Description";
            // 
            // txt_desc
            // 
            txt_desc.BorderStyle = BorderStyle.FixedSingle;
            txt_desc.Location = new Point(375, 42);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(180, 38);
            txt_desc.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 9);
            label4.Name = "label4";
            label4.Size = new Size(104, 30);
            label4.TabIndex = 23;
            label4.Text = "Category";
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.LightSkyBlue;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_edit.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit.Location = new Point(561, 86);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(180, 50);
            btn_edit.TabIndex = 25;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // allpostsUC
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_edit);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txt_desc);
            Controls.Add(btn_add);
            Controls.Add(label2);
            Controls.Add(txt_bref);
            Controls.Add(label3);
            Controls.Add(txt_title);
            Controls.Add(cb_category);
            Controls.Add(dgv_allposts);
            Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "allpostsUC";
            Size = new Size(745, 500);
            Load += allpostsUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_allposts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_allposts;
        private ComboBox cb_category;
        private DateTimePicker dateTimePicker1;
        private Button btn_add;
        private Label label2;
        private TextBox txt_title;
        private Label label3;
        private TextBox txt_bref;
        private Label label1;
        private TextBox txt_desc;
        private Label label4;
        private Button btn_edit;
    }
}
