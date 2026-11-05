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
    public partial class MushroomForm : Form
    {
        private int questionStep;

        public MushroomForm()
        {
            InitializeComponent();
            questionStep = 0;
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            HandleAnswer(true);
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            HandleAnswer(false);
        }

        private void HandleAnswer(bool answerIsYes)
        {
            switch (questionStep)
            {
                case 0:
                    if (answerIsYes)
                    {
                        questionStep = 1;
                        lblquestion.Text = "Does it grow in a forest?";
                    }
                    else
                    {
                        questionStep = 2;
                        lblquestion.Text = "Does it have gills?";
                    }

                    break;

                case 1:
                    if (answerIsYes)
                    {
                        ShowResult("Amanite tue-mouche");
                    }
                    else
                    {
                        questionStep = 3;
                        lblquestion.Text = "Does it have a convex cap?";
                    }

                    break;

                case 2:
                    if (!answerIsYes)
                    {
                        ShowResult("Cepe de bordeaux");
                    }
                    else
                    {
                        questionStep = 4;
                        lblquestion.Text = "Does it have a convex cap?";
                    }

                    break;

                case 3:
                    ShowResult(answerIsYes ? "Agaric Jaunissant" : "Coprin chevelu");
                    break;

                case 4:
                    ShowResult(answerIsYes ? "Pied bleu" : "Girolle");
                    break;
            }
        }

        private void ShowResult(string mushroomName)
        {
            string result = $"Your mushroom is: {mushroomName}";
            lblresult.Text = result;
            btnyes.Enabled = false;
            btnno.Enabled = false;
            MessageBox.Show(result);
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
