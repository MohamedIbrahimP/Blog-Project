namespace Blog_Project.User_Controls
{
    partial class myprofileUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myprofileUC));
            label8 = new Label();
            txt_confirmpassword = new TextBox();
            label7 = new Label();
            txt_password = new TextBox();
            label6 = new Label();
            txt_email = new TextBox();
            label5 = new Label();
            txt_age = new TextBox();
            label4 = new Label();
            txt_name = new TextBox();
            btn_edit = new Button();
            btn_savechange = new Button();
            pic = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(385, 342);
            label8.Name = "label8";
            label8.Size = new Size(145, 30);
            label8.TabIndex = 48;
            label8.Text = "Confirm Pass";
            // 
            // txt_confirmpassword
            // 
            txt_confirmpassword.BorderStyle = BorderStyle.FixedSingle;
            txt_confirmpassword.Location = new Point(542, 340);
            txt_confirmpassword.Name = "txt_confirmpassword";
            txt_confirmpassword.ReadOnly = true;
            txt_confirmpassword.Size = new Size(200, 38);
            txt_confirmpassword.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(385, 266);
            label7.Name = "label7";
            label7.Size = new Size(107, 30);
            label7.TabIndex = 46;
            label7.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Location = new Point(542, 264);
            txt_password.Name = "txt_password";
            txt_password.ReadOnly = true;
            txt_password.Size = new Size(200, 38);
            txt_password.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 190);
            label6.Name = "label6";
            label6.Size = new Size(67, 30);
            label6.TabIndex = 44;
            label6.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Location = new Point(542, 188);
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            txt_email.Size = new Size(200, 38);
            txt_email.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(385, 114);
            label5.Name = "label5";
            label5.Size = new Size(53, 30);
            label5.TabIndex = 42;
            label5.Text = "Age";
            // 
            // txt_age
            // 
            txt_age.BorderStyle = BorderStyle.FixedSingle;
            txt_age.Location = new Point(542, 112);
            txt_age.Name = "txt_age";
            txt_age.ReadOnly = true;
            txt_age.Size = new Size(200, 38);
            txt_age.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 38);
            label4.Name = "label4";
            label4.Size = new Size(71, 30);
            label4.TabIndex = 40;
            label4.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Location = new Point(542, 36);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(200, 38);
            txt_name.TabIndex = 39;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.LightSkyBlue;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_edit.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit.Location = new Point(562, 418);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(180, 50);
            btn_edit.TabIndex = 50;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_savechange
            // 
            btn_savechange.BackColor = Color.SandyBrown;
            btn_savechange.FlatAppearance.BorderSize = 0;
            btn_savechange.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_savechange.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_savechange.Location = new Point(376, 418);
            btn_savechange.Name = "btn_savechange";
            btn_savechange.Size = new Size(180, 50);
            btn_savechange.TabIndex = 49;
            btn_savechange.Text = "Save Change";
            btn_savechange.UseVisualStyleBackColor = false;
            btn_savechange.Click += btn_savechange_Click;
            // 
            // pic
            // 
            pic.BackgroundImage = (Image)resources.GetObject("pic.BackgroundImage");
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.Location = new Point(26, 112);
            pic.Name = "pic";
            pic.Size = new Size(250, 356);
            pic.TabIndex = 51;
            pic.TabStop = false;
            pic.WaitOnLoad = true;
            pic.Click += pic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 79);
            label1.Name = "label1";
            label1.Size = new Size(159, 30);
            label1.TabIndex = 52;
            label1.Text = "Profile Picture";
            // 
            // myprofileUC
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(pic);
            Controls.Add(btn_edit);
            Controls.Add(btn_savechange);
            Controls.Add(label8);
            Controls.Add(txt_confirmpassword);
            Controls.Add(label7);
            Controls.Add(txt_password);
            Controls.Add(label6);
            Controls.Add(txt_email);
            Controls.Add(label5);
            Controls.Add(txt_age);
            Controls.Add(label4);
            Controls.Add(txt_name);
            Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "myprofileUC";
            Size = new Size(745, 500);
            Load += myprofileUC_Load;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox txt_confirmpassword;
        private Label label7;
        private TextBox txt_password;
        private Label label6;
        private TextBox txt_email;
        private Label label5;
        private TextBox txt_age;
        private Label label4;
        private TextBox txt_name;
        private Button btn_edit;
        private Button btn_savechange;
        private PictureBox pic;
        private Label label1;
    }
}
