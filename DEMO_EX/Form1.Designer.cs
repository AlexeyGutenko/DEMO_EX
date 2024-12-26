namespace DEMO_EX
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
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            logIn = new Button();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(71, 123);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 23);
            textBoxPassword.TabIndex = 14;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(71, 69);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(150, 23);
            textBoxLogin.TabIndex = 13;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 123);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 12;
            label2.Text = "пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 72);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 11;
            label1.Text = "логин";
            // 
            // logIn
            // 
            logIn.Location = new Point(89, 152);
            logIn.Name = "logIn";
            logIn.Size = new Size(75, 23);
            logIn.TabIndex = 10;
            logIn.Text = "войти";
            logIn.UseVisualStyleBackColor = true;
            logIn.Click += logIn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 246);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logIn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label label2;
        private Label label1;
        private Button logIn;
    }
}
