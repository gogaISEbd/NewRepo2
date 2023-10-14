namespace HostelProduct
{
    partial class FormRoom
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
            textBoxNameRoom = new TextBox();
            textBoxCost = new TextBox();
            textBoxLocation = new TextBox();
            textBoxRooms = new TextBox();
            textBoxSize = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 36);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(507, 286);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // textBoxNameRoom
            // 
            textBoxNameRoom.Location = new Point(639, 59);
            textBoxNameRoom.Margin = new Padding(3, 2, 3, 2);
            textBoxNameRoom.Name = "textBoxNameRoom";
            textBoxNameRoom.Size = new Size(110, 23);
            textBoxNameRoom.TabIndex = 1;
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(639, 84);
            textBoxCost.Margin = new Padding(3, 2, 3, 2);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(110, 23);
            textBoxCost.TabIndex = 2;
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(639, 109);
            textBoxLocation.Margin = new Padding(3, 2, 3, 2);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(110, 23);
            textBoxLocation.TabIndex = 3;
            // 
            // textBoxRooms
            // 
            textBoxRooms.Location = new Point(639, 134);
            textBoxRooms.Margin = new Padding(3, 2, 3, 2);
            textBoxRooms.Name = "textBoxRooms";
            textBoxRooms.Size = new Size(110, 23);
            textBoxRooms.TabIndex = 4;
            // 
            // textBoxSize
            // 
            textBoxSize.Location = new Point(639, 161);
            textBoxSize.Margin = new Padding(3, 2, 3, 2);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(110, 23);
            textBoxSize.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(522, 59);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 6;
            label1.Text = "Наменование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 89);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(522, 114);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 8;
            label3.Text = "Расположение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(522, 139);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 9;
            label4.Text = "Кол-во Комнат";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(522, 166);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 10;
            label5.Text = "Площадь";
            // 
            // button1
            // 
            button1.Location = new Point(565, 214);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 11;
            button1.Text = "Добавление";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(666, 214);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 12;
            button2.Text = "Редактирование";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonEdit_Click;
            // 
            // button3
            // 
            button3.Location = new Point(620, 255);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 13;
            button3.Text = "Удаление";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonDelete_Click;
            // 
            // FormRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 367);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSize);
            Controls.Add(textBoxRooms);
            Controls.Add(textBoxLocation);
            Controls.Add(textBoxCost);
            Controls.Add(textBoxNameRoom);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormRoom";
            Text = "FormRoom";
            Load += FormRoom_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxNameRoom;
        private TextBox textBoxCost;
        private TextBox textBoxLocation;
        private TextBox textBoxRooms;
        private TextBox textBoxSize;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}