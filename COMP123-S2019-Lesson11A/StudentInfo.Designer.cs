namespace COMP123_S2019_Lesson11A
{
    partial class StudentInfo
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdDataLabel = new System.Windows.Forms.Label();
            this.StudentIdLabel = new System.Windows.Forms.Label();
            this.StudentIdDataLabel = new System.Windows.Forms.Label();
            this.FirstNamelabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(16, 25);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(199, 48);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdDataLabel
            // 
            this.IdDataLabel.BackColor = System.Drawing.Color.White;
            this.IdDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdDataLabel.Location = new System.Drawing.Point(244, 25);
            this.IdDataLabel.Name = "IdDataLabel";
            this.IdDataLabel.Size = new System.Drawing.Size(131, 48);
            this.IdDataLabel.TabIndex = 0;
            this.IdDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentIdLabel
            // 
            this.StudentIdLabel.Location = new System.Drawing.Point(16, 86);
            this.StudentIdLabel.Name = "StudentIdLabel";
            this.StudentIdLabel.Size = new System.Drawing.Size(199, 48);
            this.StudentIdLabel.TabIndex = 0;
            this.StudentIdLabel.Text = "STUDENT_ID";
            this.StudentIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentIdDataLabel
            // 
            this.StudentIdDataLabel.BackColor = System.Drawing.Color.White;
            this.StudentIdDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentIdDataLabel.Location = new System.Drawing.Point(244, 86);
            this.StudentIdDataLabel.Name = "StudentIdDataLabel";
            this.StudentIdDataLabel.Size = new System.Drawing.Size(131, 48);
            this.StudentIdDataLabel.TabIndex = 0;
            this.StudentIdDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.Location = new System.Drawing.Point(16, 156);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(199, 48);
            this.FirstNamelabel.TabIndex = 0;
            this.FirstNamelabel.Text = "FIRST_NAME";
            this.FirstNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.White;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameDataLabel.Location = new System.Drawing.Point(244, 156);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(328, 48);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(16, 217);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(199, 48);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "LAST_NAME";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.BackColor = System.Drawing.Color.White;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameDataLabel.Location = new System.Drawing.Point(244, 217);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(328, 48);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(22, 374);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(182, 45);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 439);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LastNameDataLabel);
            this.Controls.Add(this.StudentIdDataLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameDataLabel);
            this.Controls.Add(this.StudentIdLabel);
            this.Controls.Add(this.FirstNamelabel);
            this.Controls.Add(this.IdDataLabel);
            this.Controls.Add(this.IdLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "StudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info Form";
            this.Activated += new System.EventHandler(this.StudentInfo_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentInfo_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label IdDataLabel;
        private System.Windows.Forms.Label StudentIdLabel;
        private System.Windows.Forms.Label StudentIdDataLabel;
        private System.Windows.Forms.Label FirstNamelabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Button BackButton;
    }
}