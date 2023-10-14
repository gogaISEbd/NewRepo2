namespace HostelProduct
{
    partial class FormClient
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(490, 210);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(508, 44);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 73);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Возраст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(509, 106);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "Паспорт";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 140);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "Телефон";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(581, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(581, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(581, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(581, 137);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 23);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(509, 166);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 9;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(511, 195);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 10;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(511, 222);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 11;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 276);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormClient";
            Text = "FormClient";
            Load += FormClients_Load;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}