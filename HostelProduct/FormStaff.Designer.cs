namespace HostelProduct
{
    partial class FormStaff
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
            label3 = new Label();
            label4 = new Label();
            textBoxFIO = new TextBox();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            comboBoxRole = new ComboBox();
            buttonAdd = new Button();
            buttonChange = new Button();
            buttonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 20);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(422, 296);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 20);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Фио";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 50);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 80);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 118);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 4;
            label4.Text = "Роль";
            // 
            // textBoxFIO
            // 
            textBoxFIO.Location = new Point(550, 17);
            textBoxFIO.Margin = new Padding(3, 2, 3, 2);
            textBoxFIO.Name = "textBoxFIO";
            textBoxFIO.Size = new Size(110, 23);
            textBoxFIO.TabIndex = 5;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(550, 48);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(110, 23);
            textBoxLogin.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(550, 80);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(110, 23);
            textBoxPassword.TabIndex = 7;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Бухгалтер", "Консьерж" });
            comboBoxRole.Location = new Point(528, 112);
            comboBoxRole.Margin = new Padding(3, 2, 3, 2);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(133, 23);
            comboBoxRole.TabIndex = 8;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(438, 178);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(82, 22);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonChange
            // 
            buttonChange.Location = new Point(528, 178);
            buttonChange.Margin = new Padding(3, 2, 3, 2);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(82, 22);
            buttonChange.TabIndex = 10;
            buttonChange.Text = "Изменить";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonEdit_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(615, 178);
            buttonDel.Margin = new Padding(3, 2, 3, 2);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(82, 22);
            buttonDel.TabIndex = 11;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDelete_Click;
            // 
            // FormStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonDel);
            Controls.Add(buttonChange);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxFIO);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormStaff";
            Text = "FormStaff";
            Load += FormStaff_Load;
            Click += buttonDelete_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxFIO;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private ComboBox comboBoxRole;
        private Button buttonAdd;
        private Button buttonChange;
        private Button buttonDel;
    }
}