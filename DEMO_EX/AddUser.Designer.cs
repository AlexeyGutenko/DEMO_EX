namespace DEMO_EX
{
    partial class AddUser
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
            comboBoxRole = new ComboBox();
            button1 = new Button();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPatrnymic = new TextBox();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            print_all_user = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "user", "admin" });
            comboBoxRole.Location = new Point(911, 81);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(198, 23);
            comboBoxRole.TabIndex = 39;
            // 
            // button1
            // 
            button1.Location = new Point(863, 313);
            button1.Name = "button1";
            button1.Size = new Size(193, 75);
            button1.TabIndex = 37;
            button1.Text = "добавить пользователя";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(910, 121);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(199, 23);
            textBoxName.TabIndex = 34;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(910, 165);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(199, 23);
            textBoxSurname.TabIndex = 33;
            // 
            // textBoxPatrnymic
            // 
            textBoxPatrnymic.Location = new Point(910, 209);
            textBoxPatrnymic.Name = "textBoxPatrnymic";
            textBoxPatrnymic.Size = new Size(199, 23);
            textBoxPatrnymic.TabIndex = 32;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(910, 44);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(199, 23);
            textBoxPassword.TabIndex = 30;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(910, 9);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(199, 23);
            textBoxLogin.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(801, 217);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 28;
            label7.Text = "Отчество";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(801, 165);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 27;
            label6.Text = "Фамилия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(801, 129);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 26;
            label5.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(805, 78);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 24;
            label3.Text = "Роль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(805, 47);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 23;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(800, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 22;
            label1.Text = "Логин";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-80, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(854, 622);
            dataGridView1.TabIndex = 21;
            // 
            // print_all_user
            // 
            print_all_user.Location = new Point(863, 407);
            print_all_user.Name = "print_all_user";
            print_all_user.Size = new Size(193, 75);
            print_all_user.TabIndex = 40;
            print_all_user.Text = "вывод всех пользователей";
            print_all_user.UseVisualStyleBackColor = true;
            print_all_user.Click += print_all_user_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 620);
            Controls.Add(print_all_user);
            Controls.Add(comboBoxRole);
            Controls.Add(button1);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxPatrnymic);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "AddUser";
            Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxRole;
        private Button button1;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPatrnymic;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button print_all_user;
    }
}