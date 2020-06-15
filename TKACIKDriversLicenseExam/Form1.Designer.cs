namespace TKACIKDriversLicenseExam
{
    partial class Form1
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
            this.readbutton = new System.Windows.Forms.Button();
            this.passFailLabel = new System.Windows.Forms.Label();
            this.incorrectLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listOfWrong = new System.Windows.Forms.ListBox();
            this.correctLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // readbutton
            // 
            this.readbutton.Location = new System.Drawing.Point(78, 34);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(188, 77);
            this.readbutton.TabIndex = 0;
            this.readbutton.Text = "Submit File";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // passFailLabel
            // 
            this.passFailLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passFailLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passFailLabel.Location = new System.Drawing.Point(103, 132);
            this.passFailLabel.Name = "passFailLabel";
            this.passFailLabel.Size = new System.Drawing.Size(141, 23);
            this.passFailLabel.TabIndex = 1;
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.incorrectLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.incorrectLabel.Location = new System.Drawing.Point(93, 175);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(42, 23);
            this.incorrectLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(141, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "out of 20 incorrect";
            // 
            // listOfWrong
            // 
            this.listOfWrong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listOfWrong.FormattingEnabled = true;
            this.listOfWrong.ItemHeight = 16;
            this.listOfWrong.Location = new System.Drawing.Point(93, 254);
            this.listOfWrong.Name = "listOfWrong";
            this.listOfWrong.ScrollAlwaysVisible = true;
            this.listOfWrong.Size = new System.Drawing.Size(163, 84);
            this.listOfWrong.TabIndex = 4;
            // 
            // correctLabel
            // 
            this.correctLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.correctLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.correctLabel.Location = new System.Drawing.Point(93, 210);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(42, 23);
            this.correctLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(141, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "out of 20 correct";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.listOfWrong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incorrectLabel);
            this.Controls.Add(this.passFailLabel);
            this.Controls.Add(this.readbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.Label passFailLabel;
        private System.Windows.Forms.Label incorrectLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listOfWrong;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

