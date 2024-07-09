namespace Timec_lock
{
    partial class PasswordChangeForm
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
            ChngePswrdBtn = new Button();
            OldPswrdLabel = new Label();
            OldPswrdTxtBox = new TextBox();
            label1 = new Label();
            NewPswrd2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            NewPswrd1 = new TextBox();
            Tz = new Label();
            TZform = new TextBox();
            SuspendLayout();
            // 
            // ChngePswrdBtn
            // 
            ChngePswrdBtn.Location = new Point(291, 379);
            ChngePswrdBtn.Name = "ChngePswrdBtn";
            ChngePswrdBtn.Size = new Size(94, 29);
            ChngePswrdBtn.TabIndex = 0;
            ChngePswrdBtn.Text = "החלף";
            ChngePswrdBtn.UseVisualStyleBackColor = true;
            // 
            // OldPswrdLabel
            // 
            OldPswrdLabel.AutoSize = true;
            OldPswrdLabel.Location = new Point(273, 140);
            OldPswrdLabel.Name = "OldPswrdLabel";
            OldPswrdLabel.Size = new Size(127, 20);
            OldPswrdLabel.TabIndex = 3;
            OldPswrdLabel.Text = "הכנס סיסמא ישנה";
            // 
            // OldPswrdTxtBox
            // 
            OldPswrdTxtBox.Location = new Point(275, 173);
            OldPswrdTxtBox.Name = "OldPswrdTxtBox";
            OldPswrdTxtBox.Size = new Size(125, 27);
            OldPswrdTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 213);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 4;
            label1.Text = "הכנס סיסמא חדשה";
            // 
            // NewPswrd2
            // 
            NewPswrd2.Location = new Point(275, 329);
            NewPswrd2.Name = "NewPswrd2";
            NewPswrd2.Size = new Size(125, 27);
            NewPswrd2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 269);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 290);
            label3.Name = "label3";
            label3.Size = new Size(213, 20);
            label3.TabIndex = 7;
            label3.Text = "הכנס שוב סיסמא חדשה לאישור";
            // 
            // NewPswrd1
            // 
            NewPswrd1.Location = new Point(275, 249);
            NewPswrd1.Name = "NewPswrd1";
            NewPswrd1.Size = new Size(125, 27);
            NewPswrd1.TabIndex = 8;
            // 
            // Tz
            // 
            Tz.AutoSize = true;
            Tz.Location = new Point(291, 35);
            Tz.Name = "Tz";
            Tz.Size = new Size(85, 20);
            Tz.TabIndex = 10;
            Tz.Text = "תעודת זהות";
            // 
            // TZform
            // 
            TZform.Location = new Point(274, 79);
            TZform.Name = "TZform";
            TZform.Size = new Size(125, 27);
            TZform.TabIndex = 9;
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 489);
            Controls.Add(Tz);
            Controls.Add(TZform);
            Controls.Add(NewPswrd1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(NewPswrd2);
            Controls.Add(label1);
            Controls.Add(OldPswrdLabel);
            Controls.Add(OldPswrdTxtBox);
            Controls.Add(ChngePswrdBtn);
            Margin = new Padding(2, 2, 2, 2);
            Name = "PasswordChangeForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "שעון נוכחות -החלפת סיסמא";
            Load += PasswordChangeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChngePswrdBtn;
        private Label OldPswrdLabel;
        private TextBox OldPswrdTxtBox;
        private Label label1;
        private TextBox NewPswrd2;
        private TextBox textBox1;
        private Label label3;
        private TextBox NewPswrd1;
        private Label Tz;
        private TextBox TZform;
    }
}