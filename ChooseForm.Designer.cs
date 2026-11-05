namespace Lab_2
{
    partial class ChooseForm
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
            btnbicycle = new Button();
            btnmushroom = new Button();
            SuspendLayout();
            // 
            // btnbicycle
            // 
            btnbicycle.Location = new Point(227, 123);
            btnbicycle.Name = "btnbicycle";
            btnbicycle.Size = new Size(75, 23);
            btnbicycle.TabIndex = 0;
            btnbicycle.Text = "Bicycle";
            btnbicycle.UseVisualStyleBackColor = true;
            btnbicycle.Click += btnbicycle_Click;
            // 
            // btnmushroom
            // 
            btnmushroom.Location = new Point(404, 123);
            btnmushroom.Name = "btnmushroom";
            btnmushroom.Size = new Size(75, 23);
            btnmushroom.TabIndex = 1;
            btnmushroom.Text = "Mushroom";
            btnmushroom.UseVisualStyleBackColor = true;
            btnmushroom.Click += btnmushroom_Click;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnmushroom);
            Controls.Add(btnbicycle);
            Name = "ChooseForm";
            Text = "Form1";
            Load += ChooseForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnbicycle;
        private Button btnmushroom;
    }
}