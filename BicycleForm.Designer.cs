namespace Lab_2
{
    partial class BicycleForm
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
            lblstart = new Label();
            txtstart = new TextBox();
            lblend = new Label();
            txtend = new TextBox();
            btncalculate = new Button();
            lbltotal = new Label();
            txttotal = new TextBox();
            btnback = new Button();
            btnlogout = new Button();
            SuspendLayout();
            // 
            // lblstart
            // 
            lblstart.AutoSize = true;
            lblstart.Location = new Point(230, 80);
            lblstart.Name = "lblstart";
            lblstart.Size = new Size(69, 15);
            lblstart.Text = "Start hour:";
            // 
            // txtstart
            // 
            txtstart.Location = new Point(330, 77);
            txtstart.Name = "txtstart";
            txtstart.Size = new Size(100, 23);
            // 
            // lblend
            // 
            lblend.AutoSize = true;
            lblend.Location = new Point(230, 120);
            lblend.Name = "lblend";
            lblend.Size = new Size(64, 15);
            lblend.Text = "End hour:";
            // 
            // txtend
            // 
            txtend.Location = new Point(330, 117);
            txtend.Name = "txtend";
            txtend.Size = new Size(100, 23);
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(330, 160);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(100, 27);
            btncalculate.Text = "Calculate";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(230, 210);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(35, 15);
            lbltotal.Text = "Total:";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(330, 207);
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(100, 23);
            // 
            // btnback
            // 
            btnback.Location = new Point(230, 270);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 27);
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(355, 270);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(75, 27);
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // BicycleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogout);
            Controls.Add(btnback);
            Controls.Add(txttotal);
            Controls.Add(lbltotal);
            Controls.Add(btncalculate);
            Controls.Add(txtend);
            Controls.Add(lblend);
            Controls.Add(txtstart);
            Controls.Add(lblstart);
            Name = "BicycleForm";
            Text = "Bicycle Renting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblstart;
        private TextBox txtstart;
        private Label lblend;
        private TextBox txtend;
        private Button btncalculate;
        private Label lbltotal;
        private TextBox txttotal;
        private Button btnback;
        private Button btnlogout;
    }
}