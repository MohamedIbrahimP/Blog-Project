namespace Blog_Project.User_Controls
{
    partial class mypostsUC
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
            btn_edit = new Button();
            label4 = new Label();
            label1 = new Label();
            txt_desc = new TextBox();
            btn_add = new Button();
            label2 = new Label();
            txt_bref = new TextBox();
            label3 = new Label();
            txt_title = new TextBox();
            cb_category = new ComboBox();
            dgv = new DataGridView();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.LightSkyBlue;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_edit.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit.Location = new Point(561, 85);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(180, 50);
            btn_edit.TabIndex = 36;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 9);
            label4.Name = "label4";
            label4.Size = new Size(104, 30);
            label4.TabIndex = 35;
            label4.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 34;
            label1.Text = "Description";
            // 
            // txt_desc
            // 
            txt_desc.BorderStyle = BorderStyle.FixedSingle;
            txt_desc.Location = new Point(375, 42);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(180, 38);
            txt_desc.TabIndex = 33;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.SandyBrown;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_add.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(189, 88);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(180, 50);
            btn_add.TabIndex = 32;
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
            label2.TabIndex = 31;
            label2.Text = "Bref";
            // 
            // txt_bref
            // 
            txt_bref.BorderStyle = BorderStyle.FixedSingle;
            txt_bref.Location = new Point(189, 42);
            txt_bref.Name = "txt_bref";
            txt_bref.Size = new Size(180, 38);
            txt_bref.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 29;
            label3.Text = "Title";
            // 
            // txt_title
            // 
            txt_title.BorderStyle = BorderStyle.FixedSingle;
            txt_title.Location = new Point(3, 42);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(180, 38);
            txt_title.TabIndex = 28;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(561, 41);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(180, 38);
            cb_category.TabIndex = 27;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.Control;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(3, 144);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.Size = new Size(738, 356);
            dgv.TabIndex = 26;
            dgv.CellContentClick += dgv_CellContentClick;
            dgv.RowHeaderMouseClick += dgv_RowHeaderMouseClick;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_delete.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.Control;
            btn_delete.Location = new Point(375, 86);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(180, 50);
            btn_delete.TabIndex = 37;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // mypostsUC
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_delete);
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
            Controls.Add(dgv);
            Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "mypostsUC";
            Size = new Size(745, 500);
            Load += mypostsUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_edit;
        private Label label4;
        private Label label1;
        private TextBox txt_desc;
        private Button btn_add;
        private Label label2;
        private TextBox txt_bref;
        private Label label3;
        private TextBox txt_title;
        private ComboBox cb_category;
        private DataGridView dgv;
        private Button btn_delete;
    }
}
