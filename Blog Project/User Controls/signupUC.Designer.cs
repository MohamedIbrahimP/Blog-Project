namespace Blog_Project.User_Controls
{
    partial class signupUC
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
            btn_signup = new Button();
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
            SuspendLayout();
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.SandyBrown;
            btn_signup.FlatAppearance.BorderSize = 0;
            btn_signup.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_signup.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_signup.Location = new Point(206, 321);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(389, 50);
            btn_signup.TabIndex = 38;
            btn_signup.Text = "Sign Up";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(206, 262);
            label8.Name = "label8";
            label8.Size = new Size(145, 30);
            label8.TabIndex = 37;
            label8.Text = "Confirm Pass";
            // 
            // txt_confirmpassword
            // 
            txt_confirmpassword.BorderStyle = BorderStyle.FixedSingle;
            txt_confirmpassword.Location = new Point(395, 262);
            txt_confirmpassword.Name = "txt_confirmpassword";
            txt_confirmpassword.Size = new Size(200, 38);
            txt_confirmpassword.TabIndex = 36;
            txt_confirmpassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(206, 202);
            label7.Name = "label7";
            label7.Size = new Size(107, 30);
            label7.TabIndex = 35;
            label7.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Location = new Point(395, 202);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(200, 38);
            txt_password.TabIndex = 34;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 145);
            label6.Name = "label6";
            label6.Size = new Size(67, 30);
            label6.TabIndex = 33;
            label6.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Location = new Point(395, 145);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(200, 38);
            txt_email.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 84);
            label5.Name = "label5";
            label5.Size = new Size(53, 30);
            label5.TabIndex = 31;
            label5.Text = "Age";
            // 
            // txt_age
            // 
            txt_age.BorderStyle = BorderStyle.FixedSingle;
            txt_age.Location = new Point(395, 84);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(200, 38);
            txt_age.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 29);
            label4.Name = "label4";
            label4.Size = new Size(71, 30);
            label4.TabIndex = 29;
            label4.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Location = new Point(395, 29);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(200, 38);
            txt_name.TabIndex = 28;
            // 
            // signupUC
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_signup);
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
            Name = "signupUC";
            Size = new Size(800, 400);
            Load += signupUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_signup;
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
    }
}
