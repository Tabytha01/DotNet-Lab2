using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtstart.Text, out int start) || !int.TryParse(txtend.Text, out int end))
            {
                MessageBox.Show("Please enter whole numbers only (no decimals or letters)");
                return;
            }

            if (start < 0 || start > 23)
            {
                MessageBox.Show("Start time must be between 0 and 23");
                return;
            }

            if (end < 1 || end > 24)
            {
                MessageBox.Show("End time must be between 1 and 24");
                return;
            }

            if (start >= end)
            {
                MessageBox.Show("Start time must be less than end time");
                return;
            }

            int total = 0;

            for (int hour = start; hour < end; hour++)
            {
                if ((hour >= 0 && hour < 7) || (hour >= 21 && hour < 24))
                {
                    total += 500;
                }
                else if ((hour >= 7 && hour < 14) || (hour >= 19 && hour < 21))
                {
                    total += 1000;
                }
                else if (hour >= 14 && hour < 19)
                {
                    total += 1500;
                }
            }

            txttotal.Text = total + " RWF";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new ChooseForm().Show();
            Close();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm? login = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();

            if (login == null)
            {
                login = new LoginForm();
            }

            login.Show();
            Close();
        }
    }
}
