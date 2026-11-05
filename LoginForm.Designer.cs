namespace Lab_2
{
    partial class LoginForm
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
            btnlogin = new Button();
            btnclose = new Button();
            lbluser = new Label();
            lblpass = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(334, 182);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 23);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(451, 182);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(75, 23);
            btnclose.TabIndex = 1;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(320, 74);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(66, 15);
            lbluser.TabIndex = 2;
            lbluser.Text = "Username :";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Location = new Point(320, 120);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(63, 15);
            lblpass.TabIndex = 3;
            lblpass.Text = "Password :";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(410, 71);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(100, 23);
            txtuser.TabIndex = 4;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(410, 112);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(100, 23);
            txtpass.TabIndex = 5;
            txtpass.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(lblpass);
            Controls.Add(lbluser);
            Controls.Add(btnclose);
            Controls.Add(btnlogin);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private Button btnclose;
        private Label lbluser;
        private Label lblpass;
        private TextBox txtuser;
        private TextBox txtpass;
    }
}
