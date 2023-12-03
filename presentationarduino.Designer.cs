namespace PresentationTPArduino
{
    partial class presentationarduino
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
            this.TitleExercice = new System.Windows.Forms.Label();
            this.sQuestion = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.DPanel_Exercice = new System.Windows.Forms.Panel();
            this.exercice51 = new PresentationTPArduino.exercice5();
            this.exercice41 = new PresentationTPArduino.exercice4();
            this.exercice3_21 = new PresentationTPArduino.exercice3_2();
            this.exercice31 = new PresentationTPArduino.exercice3();
            this.exercice21 = new PresentationTPArduino.exercice2();
            this.exercice11 = new PresentationTPArduino.exercice1();
            this.button_back = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.DPanel_Exercice.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleExercice
            // 
            this.TitleExercice.AutoSize = true;
            this.TitleExercice.BackColor = System.Drawing.Color.Transparent;
            this.TitleExercice.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleExercice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.TitleExercice.Location = new System.Drawing.Point(15, 85);
            this.TitleExercice.Margin = new System.Windows.Forms.Padding(0);
            this.TitleExercice.Name = "TitleExercice";
            this.TitleExercice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleExercice.Size = new System.Drawing.Size(126, 29);
            this.TitleExercice.TabIndex = 0;
            this.TitleExercice.Text = "Exercice 1";
            // 
            // sQuestion
            // 
            this.sQuestion.BackColor = System.Drawing.Color.Transparent;
            this.sQuestion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.sQuestion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sQuestion.Location = new System.Drawing.Point(15, 251);
            this.sQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.sQuestion.Name = "sQuestion";
            this.sQuestion.Size = new System.Drawing.Size(241, 179);
            this.sQuestion.TabIndex = 1;
            this.sQuestion.Text = "Réaliser un programme permettant de faire clignoter la LED JAUNE D2 à la vitesse " +
    "de 1s";
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.BackgroundImage = global::PresentationTPArduino.Properties.Resources.button_close;
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(1202, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(24, 24);
            this.button_close.TabIndex = 2;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // DPanel_Exercice
            // 
            this.DPanel_Exercice.BackColor = System.Drawing.Color.Transparent;
            this.DPanel_Exercice.Controls.Add(this.exercice51);
            this.DPanel_Exercice.Controls.Add(this.exercice41);
            this.DPanel_Exercice.Controls.Add(this.exercice3_21);
            this.DPanel_Exercice.Controls.Add(this.exercice31);
            this.DPanel_Exercice.Controls.Add(this.exercice21);
            this.DPanel_Exercice.Controls.Add(this.exercice11);
            this.DPanel_Exercice.Location = new System.Drawing.Point(259, 33);
            this.DPanel_Exercice.Name = "DPanel_Exercice";
            this.DPanel_Exercice.Size = new System.Drawing.Size(975, 632);
            this.DPanel_Exercice.TabIndex = 3;
            // 
            // exercice51
            // 
            this.exercice51.Location = new System.Drawing.Point(0, 0);
            this.exercice51.Name = "exercice51";
            this.exercice51.Size = new System.Drawing.Size(975, 632);
            this.exercice51.TabIndex = 8;
            this.exercice51.Tag = "Réaliser un programme permettant d’éteindre (ou d’allumer) l’afficheur avec";
            this.exercice51.Visible = false;
            // 
            // exercice41
            // 
            this.exercice41.Location = new System.Drawing.Point(0, 0);
            this.exercice41.Name = "exercice41";
            this.exercice41.Size = new System.Drawing.Size(976, 632);
            this.exercice41.TabIndex = 6;
            this.exercice41.Tag = "Réaliser un programme permettant d’allumer la led verte dès que l’on appuis";
            this.exercice41.Visible = false;
            // 
            // exercice3_21
            // 
            this.exercice3_21.Location = new System.Drawing.Point(0, 0);
            this.exercice3_21.Name = "exercice3_21";
            this.exercice3_21.Size = new System.Drawing.Size(975, 629);
            this.exercice3_21.TabIndex = 6;
            this.exercice3_21.Tag = "Réaliser un programme permettant de faire défiler le message précédent de droite " +
    "à gauche";
            this.exercice3_21.Visible = false;
            // 
            // exercice31
            // 
            this.exercice31.Location = new System.Drawing.Point(0, 0);
            this.exercice31.Name = "exercice31";
            this.exercice31.Size = new System.Drawing.Size(975, 632);
            this.exercice31.TabIndex = 7;
            this.exercice31.Tag = "Réaliser l’affichage suivant :";
            this.exercice31.Visible = false;
            // 
            // exercice21
            // 
            this.exercice21.Location = new System.Drawing.Point(0, 0);
            this.exercice21.Name = "exercice21";
            this.exercice21.Size = new System.Drawing.Size(975, 632);
            this.exercice21.TabIndex = 6;
            this.exercice21.Tag = "Réaliser un programme permettant de compter de 0 à 9 avec l’afficheur 7 segments " +
    "AFF1";
            this.exercice21.Visible = false;
            // 
            // exercice11
            // 
            this.exercice11.Location = new System.Drawing.Point(0, 0);
            this.exercice11.Name = "exercice11";
            this.exercice11.Size = new System.Drawing.Size(976, 632);
            this.exercice11.TabIndex = 0;
            this.exercice11.Tag = "Réaliser un programme permettant de faire clignoter la LED JAUNE D2 à la vitesse " +
    "de 1s";
            this.exercice11.Load += new System.EventHandler(this.exercice11_Load);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Transparent;
            this.button_back.BackgroundImage = global::PresentationTPArduino.Properties.Resources.button_back;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Location = new System.Drawing.Point(19, 614);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(109, 41);
            this.button_back.TabIndex = 4;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Transparent;
            this.button_next.BackgroundImage = global::PresentationTPArduino.Properties.Resources.button_next;
            this.button_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_next.FlatAppearance.BorderSize = 0;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Location = new System.Drawing.Point(131, 614);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(109, 41);
            this.button_next.TabIndex = 5;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // presentationarduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationTPArduino.Properties.Resources.presentationarduino_background;
            this.ClientSize = new System.Drawing.Size(1234, 665);
            this.ControlBox = false;
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.DPanel_Exercice);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.sQuestion);
            this.Controls.Add(this.TitleExercice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "presentationarduino";
            this.Tag = "Réaliser un programme permettant de faire clignoter la LED JAUNE D2 à la vitesse " +
    "de 1s";
            this.Text = "Présentation Arduino - Yanis AZOUAOUI";
            this.DPanel_Exercice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleExercice;
        private Label sQuestion;
        private Button button_close;
        private Panel DPanel_Exercice;
        private Button button_back;
        private Button button_next;
        private exercice1 exercice11;
        private exercice2 exercice21;
        private exercice3 exercice31;
        private exercice3_2 exercice3_21;
        private exercice4 exercice41;
        private exercice5 exercice51;
    }
}