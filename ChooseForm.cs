using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btnbicycle_Click(object sender, EventArgs e)
        {
            BicycleForm bike = new BicycleForm();
            bike.Show();
            this.Hide();
        }

        private void btnmushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm();
            mushroom.Show();
            this.Hide();
        }

        private void ChooseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
