namespace Blog_Project.User_Controls
{
    partial class logInUC
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
            btn_login = new Button();
            label2 = new Label();
            txt_password = new TextBox();
            label1 = new Label();
            txt_userName = new TextBox();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.SandyBrown;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_login.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(206, 239);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(389, 50);
            btn_login.TabIndex = 15;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 172);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 14;
            label2.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Location = new Point(395, 172);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(200, 38);
            txt_password.TabIndex = 13;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 112);
            label1.Name = "label1";
            label1.Size = new Size(127, 30);
            label1.TabIndex = 12;
            label1.Text = "User Name";
            // 
            // txt_userName
            // 
            txt_userName.BorderStyle = BorderStyle.FixedSingle;
            txt_userName.Location = new Point(395, 112);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(200, 38);
            txt_userName.TabIndex = 11;
            // 
            // logInUC
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(txt_password);
            Controls.Add(label1);
            Controls.Add(txt_userName);
            Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "logInUC";
            Size = new Size(800, 400);
            Load += logInUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Label label2;
        private TextBox txt_password;
        private Label label1;
        private TextBox txt_userName;
    }
}
