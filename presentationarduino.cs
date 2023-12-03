using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTPArduino
{
    public partial class presentationarduino : Form
    {
        public presentationarduino()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exercice11_Load(object sender, EventArgs e)
        {
            this.button_back.Visible = false;
            this.button_next.Location = new Point(75, 614);
        }

        int iCount = 1;
        bool bText = false;
        private void button_next_Click(object sender, EventArgs e)
        {

            iCount++;

            string sNewTitle = "Exercice " + iCount;

            this.TitleExercice.Text = sNewTitle;

            if (iCount == 2)
            {
                this.exercice11.Visible = false;
                this.exercice21.Visible = true;

                this.sQuestion.Text = (string)this.exercice21.Tag;

                this.button_back.Visible = true;
                this.button_next.Location = new Point(131, 614);
            }

            if (iCount == 3)
            {
                this.exercice21.Visible = false;
                this.exercice31.Visible = true;

                this.sQuestion.Text = (string)this.exercice31.Tag;
            }

            if (iCount == 4 && !bText)
            {
                this.exercice31.Visible = false;
                this.exercice3_21.Visible = true;

                this.sQuestion.Text = (string)this.exercice3_21.Tag;

                this.TitleExercice.Text = "Exercice 3";

                iCount = 3;
                bText = true;
            }

            if (iCount == 4 && bText)
            {
                this.exercice3_21.Visible = false;
                this.exercice41.Visible = true;

                this.sQuestion.Text = (string)this.exercice41.Tag;
            }

            if (iCount == 5)
            {
                this.exercice41.Visible = false;
                this.exercice51.Visible = true;

                this.sQuestion.Text = (string)this.exercice51.Tag;

                this.button_next.Visible = false;
                this.button_back.Location = new Point(75, 614);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (iCount <= 1) { return; }
            iCount--;

            string sNewTitle =  "Exercice " + iCount;

            this.TitleExercice.Text = sNewTitle;

            if (iCount == 1)
            {
                this.exercice11.Visible = true;
                this.exercice21.Visible = false;

                this.sQuestion.Text = (string)this.exercice11.Tag;

                this.button_back.Visible = false;
                this.button_next.Location = new Point(75, 614);
            }

            if (iCount == 2)
            {
                this.exercice21.Visible = true;
                this.exercice31.Visible = false;

                this.sQuestion.Text = (string)this.exercice21.Tag;
            }

            if (iCount == 3 && bText)
  
            {
                this.exercice31.Visible = true;
                this.exercice3_21.Visible = false;

                this.sQuestion.Text = (string)this.exercice31.Tag;

                this.TitleExercice.Text = "Exercice 3";
                iCount++;
                bText = false;
            }

            if (iCount == 3 && !bText)
            {
                this.exercice3_21.Visible = true;
                this.exercice41.Visible = false;

                this.sQuestion.Text = (string)this.exercice3_21.Tag;
            }

            if (iCount == 4)
            {
                this.exercice41.Visible = true;
                this.exercice51.Visible = false;

                this.sQuestion.Text = (string)this.exercice41.Tag;

                this.button_next.Visible = true;
                this.button_back.Location = new System.Drawing.Point(19, 614);
            }
        }
    }
}
