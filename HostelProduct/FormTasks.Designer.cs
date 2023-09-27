namespace HostelProduct
{
    partial class FormTasks
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBoxTask = new TextBox();
            comboBoxStaff = new ComboBox();
            buttonCreate = new Button();
            buttonEdit = new Button();
            buttonDel = new Button();
            dateTimePicker = new DateTimePicker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(524, 307);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(555, 91);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Сотрудник";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(555, 120);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Задача";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(640, 120);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(119, 23);
            textBoxTask.TabIndex = 3;
            // 
            // comboBoxStaff
            // 
            comboBoxStaff.FormattingEnabled = true;
            comboBoxStaff.Location = new Point(638, 88);
            comboBoxStaff.Name = "comboBoxStaff";
            comboBoxStaff.Size = new Size(121, 23);
            comboBoxStaff.TabIndex = 4;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(663, 178);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(102, 23);
            buttonCreate.TabIndex = 5;
            buttonCreate.Text = "Выдать задачу";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(663, 207);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(102, 23);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Редактировать задачу";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(555, 207);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(102, 23);
            buttonDel.TabIndex = 7;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDelete_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(638, 149);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(143, 23);
            dateTimePicker.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 152);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 9;
            label3.Text = "Дата";
            // 
            // FormTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dateTimePicker);
            Controls.Add(buttonDel);
            Controls.Add(buttonEdit);
            Controls.Add(buttonCreate);
            Controls.Add(comboBoxStaff);
            Controls.Add(textBoxTask);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormTasks";
            Text = "FormTasks";
            Load += FormRoom_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button buttonCreate;
        private Button buttonEdit;
        private Button button3;
        private Button buttonDel;
        private TextBox textBoxTask;
        private ComboBox comboBoxStaff;
        private DateTimePicker dateTimePicker;
        private Label label3;
    }
}