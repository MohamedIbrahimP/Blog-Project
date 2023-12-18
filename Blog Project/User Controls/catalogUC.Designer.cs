namespace Blog_Project.User_Controls
{
    partial class catalogUC
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
            dgv = new DataGridView();
            label2 = new Label();
            txt_desc = new TextBox();
            label1 = new Label();
            txt_name = new TextBox();
            btn_edit = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.Control;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Bottom;
            dgv.Location = new Point(0, 144);
            dgv.Margin = new Padding(4);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.Size = new Size(745, 356);
            dgv.TabIndex = 3;
            dgv.RowHeaderMouseClick += dgv_RowHeaderMouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 9);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 19;
            label2.Text = "Description";
            // 
            // txt_desc
            // 
            txt_desc.BorderStyle = BorderStyle.FixedSingle;
            txt_desc.Location = new Point(189, 42);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(180, 38);
            txt_desc.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Location = new Point(3, 42);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(180, 38);
            txt_name.TabIndex = 16;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.LightSkyBlue;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_edit.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit.Location = new Point(561, 34);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(180, 50);
            btn_edit.TabIndex = 27;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.SandyBrown;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_add.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(375, 34);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(180, 50);
            btn_add.TabIndex = 26;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // catalogUC
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(label2);
            Controls.Add(txt_desc);
            Controls.Add(label1);
            Controls.Add(txt_name);
            Controls.Add(dgv);
            Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "catalogUC";
            Size = new Size(745, 500);
            Load += catalogUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv;
        private Label label2;
        private TextBox txt_desc;
        private Label label1;
        private TextBox txt_name;
        private Button btn_edit;
        private Button btn_add;
    }
}
