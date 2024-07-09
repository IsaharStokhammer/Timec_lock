namespace Timec_lock
{
    public partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            textBox_Tz = new TextBox();
            textBox_Password = new TextBox();
            button_Login = new Button();
            button_Change_Pass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "תעודת זהות ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 122);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "סיסמא";
            // 
            // textBox_Tz
            // 
            textBox_Tz.Location = new Point(110, 82);
            textBox_Tz.Margin = new Padding(2, 2, 2, 2);
            textBox_Tz.Name = "textBox_Tz";
            textBox_Tz.Size = new Size(193, 27);
            textBox_Tz.TabIndex = 2;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(110, 165);
            textBox_Password.Margin = new Padding(2, 2, 2, 2);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(193, 27);
            textBox_Password.TabIndex = 3;
            // 
            // button_Login
            // 
            button_Login.Location = new Point(110, 250);
            button_Login.Margin = new Padding(2, 2, 2, 2);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(192, 39);
            button_Login.TabIndex = 4;
            button_Login.Text = "כניסה";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // button_Change_Pass
            // 
            button_Change_Pass.Location = new Point(110, 343);
            button_Change_Pass.Margin = new Padding(2, 2, 2, 2);
            button_Change_Pass.Name = "button_Change_Pass";
            button_Change_Pass.Size = new Size(192, 39);
            button_Change_Pass.TabIndex = 5;
            button_Change_Pass.Text = "החלפת סיסמא";
            button_Change_Pass.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 446);
            Controls.Add(button_Change_Pass);
            Controls.Add(button_Login);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Tz);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "שעון נוכחות - מסך התחברות";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_Tz;
        private TextBox textBox_Password;
        private Button button_Login;
        private Button button_Change_Pass;
    }
}