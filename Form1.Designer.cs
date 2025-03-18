namespace LoginApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            Usernamelabel = new Label();
            UsernametextBox = new TextBox();
            Passwordlabel = new Label();
            PasswordtextBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(198, 185);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Usernamelabel
            // 
            Usernamelabel.AutoSize = true;
            Usernamelabel.Font = new Font("Segoe UI", 12F);
            Usernamelabel.Location = new Point(83, 70);
            Usernamelabel.Name = "Usernamelabel";
            Usernamelabel.Size = new Size(108, 28);
            Usernamelabel.TabIndex = 1;
            Usernamelabel.Text = "User Name";
            // 
            // UsernametextBox
            // 
            UsernametextBox.Location = new Point(210, 74);
            UsernametextBox.Name = "UsernametextBox";
            UsernametextBox.Size = new Size(204, 27);
            UsernametextBox.TabIndex = 2;
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Font = new Font("Segoe UI", 12F);
            Passwordlabel.Location = new Point(83, 126);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(93, 28);
            Passwordlabel.TabIndex = 3;
            Passwordlabel.Text = "Password";
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(210, 130);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(204, 27);
            PasswordtextBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 256);
            Controls.Add(PasswordtextBox);
            Controls.Add(Passwordlabel);
            Controls.Add(UsernametextBox);
            Controls.Add(Usernamelabel);
            Controls.Add(button1);
            Name = "Form1";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Usernamelabel;
        private TextBox UsernametextBox;
        private Label Passwordlabel;
        private TextBox PasswordtextBox;
    }
}
