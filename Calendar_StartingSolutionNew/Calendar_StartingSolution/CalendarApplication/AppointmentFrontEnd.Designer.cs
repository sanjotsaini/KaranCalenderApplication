namespace Calendar
{
    partial class AppointmentFrontEnd
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
            this.subjectLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.startTimeComboBox = new System.Windows.Forms.ComboBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.lengthComboBox = new System.Windows.Forms.ComboBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.datelabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(39, 85);
            this.subjectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(71, 20);
            this.subjectLabel.TabIndex = 1;
            this.subjectLabel.Text = "Subject :";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(24, 153);
            this.startTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(86, 20);
            this.startTimeLabel.TabIndex = 11;
            this.startTimeLabel.Text = "StartTime :";
            // 
            // startTimeComboBox
            // 
            this.startTimeComboBox.FormattingEnabled = true;
            this.startTimeComboBox.Location = new System.Drawing.Point(137, 153);
            this.startTimeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTimeComboBox.Name = "startTimeComboBox";
            this.startTimeComboBox.Size = new System.Drawing.Size(398, 28);
            this.startTimeComboBox.TabIndex = 13;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(137, 85);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(398, 26);
            this.subjectTextBox.TabIndex = 15;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(631, 91);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(78, 20);
            this.locationLabel.TabIndex = 16;
            this.locationLabel.Text = "Location :";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(642, 170);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(67, 20);
            this.lengthLabel.TabIndex = 17;
            this.lengthLabel.Text = "Length :";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(443, 300);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(281, 35);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(835, 300);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(281, 35);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // lengthComboBox
            // 
            this.lengthComboBox.FormattingEnabled = true;
            this.lengthComboBox.Location = new System.Drawing.Point(727, 162);
            this.lengthComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lengthComboBox.Name = "lengthComboBox";
            this.lengthComboBox.Size = new System.Drawing.Size(444, 28);
            this.lengthComboBox.TabIndex = 20;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(727, 85);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(432, 26);
            this.locationTextBox.TabIndex = 21;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(537, 30);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(149, 48);
            this.datelabel.TabIndex = 22;
            this.datelabel.Text = "label1";
            this.datelabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(729, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 48);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AppointmentFrontEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 300);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.lengthComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.startTimeComboBox);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.subjectLabel);
            this.Name = "AppointmentFrontEnd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.AppointmentFrontEnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.ComboBox startTimeComboBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox lengthComboBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}