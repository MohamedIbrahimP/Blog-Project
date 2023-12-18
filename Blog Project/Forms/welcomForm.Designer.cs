namespace Blog_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btn_signIn = new Button();
            btn_signUp = new Button();
            panal = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 9);
            label1.Name = "label1";
            label1.Size = new Size(515, 79);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Our Blog";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_signIn
            // 
            btn_signIn.FlatAppearance.BorderSize = 0;
            btn_signIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_signIn.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_signIn.Location = new Point(526, 91);
            btn_signIn.Name = "btn_signIn";
            btn_signIn.Size = new Size(130, 50);
            btn_signIn.TabIndex = 2;
            btn_signIn.Text = "Sign In";
            btn_signIn.UseVisualStyleBackColor = true;
            btn_signIn.Click += btn_signIn_Click;
            // 
            // btn_signUp
            // 
            btn_signUp.FlatAppearance.BorderSize = 0;
            btn_signUp.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btn_signUp.Font = new Font("MV Boli", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_signUp.Location = new Point(141, 91);
            btn_signUp.Name = "btn_signUp";
            btn_signUp.Size = new Size(130, 50);
            btn_signUp.TabIndex = 3;
            btn_signUp.Text = "Sign Up";
            btn_signUp.UseVisualStyleBackColor = true;
            btn_signUp.Click += btn_signUp_Click;
            // 
            // panal
            // 
            panal.BackgroundImage = Properties.Resources.bg;
            panal.BackgroundImageLayout = ImageLayout.Stretch;
            panal.Dock = DockStyle.Bottom;
            panal.Location = new Point(0, 144);
            panal.Name = "panal";
            panal.Size = new Size(778, 400);
            panal.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(778, 544);
            Controls.Add(panal);
            Controls.Add(btn_signUp);
            Controls.Add(btn_signIn);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Splitter splitter1;
        private Button btn_signIn;
        private Button btn_signUp;
        private Panel panal;
    }
}
