namespace DEMO_EX
{
    partial class AdminForm
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
            dataGridView = new DataGridView();
            print_All = new Button();
            textBoxExecutor = new TextBox();
            textBoxDateCreate = new TextBox();
            labledate = new Label();
            DeskriptionTextBox = new TextBox();
            desckription = new Label();
            textBoxPriority = new TextBox();
            priority = new Label();
            labelIdBook = new Label();
            textBoxNumberTask = new TextBox();
            label1 = new Label();
            add_task = new Button();
            status = new TextBox();
            label2 = new Label();
            alter_the_status = new Button();
            textBoxID = new TextBox();
            label3 = new Label();
            assign_executor = new Button();
            textBoxUserID = new TextBox();
            label4 = new Label();
            change_the_description = new Button();
            get_task_find_by_prioryty = new Button();
            get_task_find_by_status = new Button();
            get_task_for_number = new Button();
            exit = new Button();
            addUSer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(628, 468);
            dataGridView.TabIndex = 0;
            // 
            // print_All
            // 
            print_All.Location = new Point(646, 284);
            print_All.Name = "print_All";
            print_All.Size = new Size(145, 45);
            print_All.TabIndex = 1;
            print_All.Text = "вывести все";
            print_All.UseVisualStyleBackColor = true;
            print_All.Click += print_All_Click;
            // 
            // textBoxExecutor
            // 
            textBoxExecutor.Location = new Point(910, 187);
            textBoxExecutor.Multiline = true;
            textBoxExecutor.Name = "textBoxExecutor";
            textBoxExecutor.Size = new Size(255, 37);
            textBoxExecutor.TabIndex = 31;
            textBoxExecutor.TextChanged += textBoxExecutor_TextChanged;
            // 
            // textBoxDateCreate
            // 
            textBoxDateCreate.Location = new Point(910, 58);
            textBoxDateCreate.Multiline = true;
            textBoxDateCreate.Name = "textBoxDateCreate";
            textBoxDateCreate.Size = new Size(255, 37);
            textBoxDateCreate.TabIndex = 30;
            textBoxDateCreate.TextChanged += textBoxDateCreate_TextChanged;
            // 
            // labledate
            // 
            labledate.AutoSize = true;
            labledate.Location = new Point(803, 61);
            labledate.Name = "labledate";
            labledate.Size = new Size(83, 15);
            labledate.TabIndex = 29;
            labledate.Text = "дата создания";
            // 
            // DeskriptionTextBox
            // 
            DeskriptionTextBox.Location = new Point(910, 101);
            DeskriptionTextBox.Multiline = true;
            DeskriptionTextBox.Name = "DeskriptionTextBox";
            DeskriptionTextBox.Size = new Size(255, 37);
            DeskriptionTextBox.TabIndex = 28;
            DeskriptionTextBox.TextChanged += DeskriptionTextBox_TextChanged;
            // 
            // desckription
            // 
            desckription.AutoSize = true;
            desckription.Location = new Point(806, 104);
            desckription.Name = "desckription";
            desckription.Size = new Size(60, 15);
            desckription.TabIndex = 27;
            desckription.Text = "описание";
            // 
            // textBoxPriority
            // 
            textBoxPriority.Location = new Point(910, 144);
            textBoxPriority.Multiline = true;
            textBoxPriority.Name = "textBoxPriority";
            textBoxPriority.Size = new Size(255, 37);
            textBoxPriority.TabIndex = 26;
            textBoxPriority.TextChanged += textBoxPriority_TextChanged;
            // 
            // priority
            // 
            priority.AutoSize = true;
            priority.Location = new Point(827, 147);
            priority.Name = "priority";
            priority.Size = new Size(65, 15);
            priority.TabIndex = 25;
            priority.Text = "приоритет";
            // 
            // labelIdBook
            // 
            labelIdBook.AutoSize = true;
            labelIdBook.Location = new Point(825, 190);
            labelIdBook.Name = "labelIdBook";
            labelIdBook.Size = new Size(79, 15);
            labelIdBook.TabIndex = 24;
            labelIdBook.Text = "исполнитель";
            // 
            // textBoxNumberTask
            // 
            textBoxNumberTask.Location = new Point(910, 12);
            textBoxNumberTask.Multiline = true;
            textBoxNumberTask.Name = "textBoxNumberTask";
            textBoxNumberTask.Size = new Size(255, 37);
            textBoxNumberTask.TabIndex = 23;
            textBoxNumberTask.TextChanged += textBoxNumberTask_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(804, 15);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 22;
            label1.Text = "номер задачи";
            label1.Click += label1_Click;
            // 
            // add_task
            // 
            add_task.Location = new Point(646, 335);
            add_task.Name = "add_task";
            add_task.Size = new Size(145, 45);
            add_task.TabIndex = 32;
            add_task.Text = "добавить задачу";
            add_task.UseVisualStyleBackColor = true;
            add_task.Click += add_task_Click;
            // 
            // status
            // 
            status.Location = new Point(910, 230);
            status.Multiline = true;
            status.Name = "status";
            status.Size = new Size(255, 37);
            status.TabIndex = 34;
            status.TextChanged += status_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(825, 233);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 33;
            label2.Text = "статус";
            // 
            // alter_the_status
            // 
            alter_the_status.Location = new Point(646, 386);
            alter_the_status.Name = "alter_the_status";
            alter_the_status.Size = new Size(145, 45);
            alter_the_status.TabIndex = 35;
            alter_the_status.Text = "изменить статус";
            alter_the_status.UseVisualStyleBackColor = true;
            alter_the_status.Click += alter_the_status_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(910, 284);
            textBoxID.Multiline = true;
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(255, 37);
            textBoxID.TabIndex = 37;
            textBoxID.TextChanged += textBoxID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(825, 287);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 36;
            label3.Text = "ID";
            // 
            // assign_executor
            // 
            assign_executor.Location = new Point(646, 435);
            assign_executor.Name = "assign_executor";
            assign_executor.Size = new Size(145, 45);
            assign_executor.TabIndex = 38;
            assign_executor.Text = "Назначить исполнителя";
            assign_executor.UseVisualStyleBackColor = true;
            assign_executor.Click += assign_executor_Click;
            // 
            // textBoxUserID
            // 
            textBoxUserID.Location = new Point(910, 335);
            textBoxUserID.Multiline = true;
            textBoxUserID.Name = "textBoxUserID";
            textBoxUserID.Size = new Size(255, 37);
            textBoxUserID.TabIndex = 40;
            textBoxUserID.TextChanged += textBoxUserID_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(825, 338);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 39;
            label4.Text = "ID_user";
            // 
            // change_the_description
            // 
            change_the_description.Location = new Point(646, 230);
            change_the_description.Name = "change_the_description";
            change_the_description.Size = new Size(145, 45);
            change_the_description.TabIndex = 41;
            change_the_description.Text = "изменить описание";
            change_the_description.UseVisualStyleBackColor = true;
            change_the_description.Click += change_the_description_Click;
            // 
            // get_task_find_by_prioryty
            // 
            get_task_find_by_prioryty.Location = new Point(646, 179);
            get_task_find_by_prioryty.Name = "get_task_find_by_prioryty";
            get_task_find_by_prioryty.Size = new Size(145, 45);
            get_task_find_by_prioryty.TabIndex = 42;
            get_task_find_by_prioryty.Text = "сортировать по приоритету";
            get_task_find_by_prioryty.UseVisualStyleBackColor = true;
            get_task_find_by_prioryty.Click += get_task_find_by_prioryty_Click;
            // 
            // get_task_find_by_status
            // 
            get_task_find_by_status.Location = new Point(646, 128);
            get_task_find_by_status.Name = "get_task_find_by_status";
            get_task_find_by_status.Size = new Size(145, 45);
            get_task_find_by_status.TabIndex = 43;
            get_task_find_by_status.Text = "сортировать по статусу";
            get_task_find_by_status.UseVisualStyleBackColor = true;
            get_task_find_by_status.Click += get_task_find_by_status_Click;
            // 
            // get_task_for_number
            // 
            get_task_for_number.Location = new Point(646, 77);
            get_task_for_number.Name = "get_task_for_number";
            get_task_for_number.Size = new Size(145, 45);
            get_task_for_number.TabIndex = 44;
            get_task_for_number.Text = "сортировать по номеру\r\n";
            get_task_for_number.UseVisualStyleBackColor = true;
            get_task_for_number.Click += get_task_for_number_Click;
            // 
            // exit
            // 
            exit.Location = new Point(1103, 457);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 45;
            exit.Text = "выход";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // addUSer
            // 
            addUSer.Location = new Point(646, 15);
            addUSer.Name = "addUSer";
            addUSer.Size = new Size(145, 45);
            addUSer.TabIndex = 46;
            addUSer.Text = "Добавить пользоватея";
            addUSer.UseVisualStyleBackColor = true;
            addUSer.Click += addUSer_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 492);
            Controls.Add(addUSer);
            Controls.Add(exit);
            Controls.Add(get_task_for_number);
            Controls.Add(get_task_find_by_status);
            Controls.Add(get_task_find_by_prioryty);
            Controls.Add(change_the_description);
            Controls.Add(textBoxUserID);
            Controls.Add(label4);
            Controls.Add(assign_executor);
            Controls.Add(textBoxID);
            Controls.Add(label3);
            Controls.Add(alter_the_status);
            Controls.Add(status);
            Controls.Add(label2);
            Controls.Add(add_task);
            Controls.Add(textBoxExecutor);
            Controls.Add(textBoxDateCreate);
            Controls.Add(labledate);
            Controls.Add(DeskriptionTextBox);
            Controls.Add(desckription);
            Controls.Add(textBoxPriority);
            Controls.Add(priority);
            Controls.Add(labelIdBook);
            Controls.Add(textBoxNumberTask);
            Controls.Add(label1);
            Controls.Add(print_All);
            Controls.Add(dataGridView);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button print_All;
        private TextBox textBoxExecutor;
        private TextBox textBoxDateCreate;
        private Label labledate;
        private TextBox DeskriptionTextBox;
        private Label desckription;
        private TextBox textBoxPriority;
        private Label priority;
        private Label labelIdBook;
        private TextBox textBoxNumberTask;
        private Label label1;
        private Button add_task;
        private TextBox status;
        private Label label2;
        private Button alter_the_status;
        private TextBox textBoxID;
        private Label label3;
        private Button assign_executor;
        private TextBox textBoxUserID;
        private Label label4;
        private Button change_the_description;
        private Button get_task_find_by_prioryty;
        private Button get_task_find_by_status;
        private Button get_task_for_number;
        private Button exit;
        private Button addUSer;
    }
}