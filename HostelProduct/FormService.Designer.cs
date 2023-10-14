namespace HostelProduct
{
    partial class FormService
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
            textBoxNameService = new TextBox();
            textBoxCost = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 16);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(540, 312);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(556, 22);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(556, 94);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Стоимсоть";
            // 
            // textBoxNameService
            // 
            textBoxNameService.Location = new Point(556, 40);
            textBoxNameService.Margin = new Padding(3, 2, 3, 2);
            textBoxNameService.Name = "textBoxNameService";
            textBoxNameService.Size = new Size(110, 23);
            textBoxNameService.TabIndex = 3;
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(556, 111);
            textBoxCost.Margin = new Padding(3, 2, 3, 2);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(110, 23);
            textBoxCost.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(571, 160);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(82, 22);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(575, 196);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(82, 22);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(576, 235);
            buttonDel.Margin = new Padding(3, 2, 3, 2);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(82, 22);
            buttonDel.TabIndex = 7;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDelete_Click;
            // 
            // FormService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonDel);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxCost);
            Controls.Add(textBoxNameService);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormService";
            Text = "FormService";
            Load += FormService_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBoxNameService;
        private TextBox textBoxCost;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDel;
    }
}