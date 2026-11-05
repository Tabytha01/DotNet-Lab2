namespace Lab_2
{
    partial class MushroomForm
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
            lblquestion = new Label();
            btnyes = new Button();
            btnno = new Button();
            lblresult = new Label();
            btnback = new Button();
            btnlogout = new Button();
            SuspendLayout();
            // 
            // lblquestion
            // 
            lblquestion.AutoSize = true;
            lblquestion.Location = new Point(190, 90);
            lblquestion.Name = "lblquestion";
            lblquestion.Size = new Size(420, 15);
            lblquestion.Text = "Does your mushroom have a ring?";
            // 
            // btnyes
            // 
            btnyes.Location = new Point(300, 140);
            btnyes.Name = "btnyes";
            btnyes.Size = new Size(75, 27);
            btnyes.Text = "Yes";
            btnyes.UseVisualStyleBackColor = true;
            btnyes.Click += btnyes_Click;
            // 
            // btnno
            // 
            btnno.Location = new Point(410, 140);
            btnno.Name = "btnno";
            btnno.Size = new Size(75, 27);
            btnno.Text = "No";
            btnno.UseVisualStyleBackColor = true;
            btnno.Click += btnno_Click;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(190, 210);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(0, 15);
            // 
            // btnback
            // 
            btnback.Location = new Point(270, 280);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 27);
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(420, 280);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(75, 27);
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogout);
            Controls.Add(btnback);
            Controls.Add(lblresult);
            Controls.Add(btnno);
            Controls.Add(btnyes);
            Controls.Add(lblquestion);
            Name = "MushroomForm";
            Text = "Mushroom Identifier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblquestion;
        private Button btnyes;
        private Button btnno;
        private Label lblresult;
        private Button btnback;
        private Button btnlogout;
    }
}