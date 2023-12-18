namespace Blog_Project
{
    partial class profileForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profileForm));
            btn_profile = new Button();
            btn_signout = new Button();
            btn_catalog = new Button();
            btn_myposts = new Button();
            btn_allposts = new Button();
            pic = new PictureBox();
            panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // btn_profile
            // 
            btn_profile.FlatAppearance.BorderSize = 0;
            btn_profile.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_profile.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_profile.Location = new Point(12, 12);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(130, 50);
            btn_profile.TabIndex = 3;
            btn_profile.Text = "Profile";
            btn_profile.UseVisualStyleBackColor = true;
            btn_profile.Click += btn_profile_Click;
            // 
            // btn_signout
            // 
            btn_signout.BackColor = Color.DarkGreen;
            btn_signout.FlatAppearance.BorderSize = 0;
            btn_signout.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_signout.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_signout.ForeColor = SystemColors.Control;
            btn_signout.Location = new Point(636, 12);
            btn_signout.Name = "btn_signout";
            btn_signout.Size = new Size(130, 50);
            btn_signout.TabIndex = 4;
            btn_signout.Text = "Sign Out";
            btn_signout.UseVisualStyleBackColor = false;
            btn_signout.Click += btn_signout_Click;
            // 
            // btn_catalog
            // 
            btn_catalog.FlatAppearance.BorderSize = 0;
            btn_catalog.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_catalog.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_catalog.Location = new Point(420, 12);
            btn_catalog.Name = "btn_catalog";
            btn_catalog.Size = new Size(130, 50);
            btn_catalog.TabIndex = 5;
            btn_catalog.Text = "Catalog";
            btn_catalog.UseVisualStyleBackColor = true;
            btn_catalog.Click += btn_catalog_Click;
            // 
            // btn_myposts
            // 
            btn_myposts.FlatAppearance.BorderSize = 0;
            btn_myposts.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_myposts.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_myposts.Location = new Point(284, 12);
            btn_myposts.Name = "btn_myposts";
            btn_myposts.Size = new Size(130, 50);
            btn_myposts.TabIndex = 6;
            btn_myposts.Text = "My Posts";
            btn_myposts.UseVisualStyleBackColor = true;
            btn_myposts.Click += btn_myposts_Click;
            // 
            // btn_allposts
            // 
            btn_allposts.FlatAppearance.BorderSize = 0;
            btn_allposts.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_allposts.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_allposts.Location = new Point(148, 12);
            btn_allposts.Name = "btn_allposts";
            btn_allposts.Size = new Size(130, 50);
            btn_allposts.TabIndex = 7;
            btn_allposts.Text = "All Posts";
            btn_allposts.UseVisualStyleBackColor = true;
            btn_allposts.Click += btn_allposts_Click;
            // 
            // pic
            // 
            pic.BackColor = Color.Transparent;
            pic.BackgroundImage = (Image)resources.GetObject("pic.BackgroundImage");
            pic.Image = (Image)resources.GetObject("pic.Image");
            pic.InitialImage = (Image)resources.GetObject("pic.InitialImage");
            pic.Location = new Point(556, 12);
            pic.Name = "pic";
            pic.Size = new Size(74, 50);
            pic.TabIndex = 8;
            pic.TabStop = false;
            // 
            // panel
            // 
            panel.Location = new Point(12, 78);
            panel.Name = "panel";
            panel.Size = new Size(754, 500);
            panel.TabIndex = 9;
            // 
            // profileForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(778, 590);
            Controls.Add(panel);
            Controls.Add(pic);
            Controls.Add(btn_allposts);
            Controls.Add(btn_myposts);
            Controls.Add(btn_catalog);
            Controls.Add(btn_signout);
            Controls.Add(btn_profile);
            Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "profileForm";
            Text = "profileForm";
            FormClosing += profileForm_FormClosing;
            Load += profileForm_Load;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_profile;
        private Button btn_signout;
        private Button btn_catalog;
        private Button btn_myposts;
        private Button btn_allposts;
        private PictureBox pic;
        private Panel panel;
    }
}