﻿namespace HostelProduct
{
    partial class FormPay
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
            buttonPay = new Button();
            labelText = new Label();
            textBoxDate = new TextBox();
            label1 = new Label();
            textBoxCost = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 401);
            dataGridView1.TabIndex = 0;
            // 
            // buttonPay
            // 
            buttonPay.Location = new Point(669, 118);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(75, 23);
            buttonPay.TabIndex = 1;
            buttonPay.Text = "Оплатить";
            buttonPay.UseVisualStyleBackColor = true;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(669, 27);
            labelText.Name = "labelText";
            labelText.Size = new Size(32, 15);
            labelText.TabIndex = 2;
            labelText.Text = "Дата";
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(718, 28);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(70, 23);
            textBoxDate.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(669, 73);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Оплата";
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(713, 70);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(85, 23);
            textBoxCost.TabIndex = 5;
            // 
            // FormPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxCost);
            Controls.Add(label1);
            Controls.Add(textBoxDate);
            Controls.Add(labelText);
            Controls.Add(buttonPay);
            Controls.Add(dataGridView1);
            Name = "FormPay";
            Text = "FormPay";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonPay;
        private Label labelText;
        private TextBox textBoxDate;
        private Label label1;
        private TextBox textBoxCost;
    }
}