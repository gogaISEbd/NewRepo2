namespace HostelProduct
{
    partial class FormBuh
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
            menuStrip1 = new MenuStrip();
            оРазработкичкахToolStripMenuItem = new ToolStripMenuItem();
            buttonTask = new Button();
            buttonStaff = new Button();
            buttonRooms = new Button();
            buttonServis = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { оРазработкичкахToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(340, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // оРазработкичкахToolStripMenuItem
            // 
            оРазработкичкахToolStripMenuItem.Name = "оРазработкичкахToolStripMenuItem";
            оРазработкичкахToolStripMenuItem.Size = new Size(119, 20);
            оРазработкичкахToolStripMenuItem.Text = "О Разработкичках";
            оРазработкичкахToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // buttonTask
            // 
            buttonTask.Location = new Point(55, 34);
            buttonTask.Margin = new Padding(3, 2, 3, 2);
            buttonTask.Name = "buttonTask";
            buttonTask.Size = new Size(241, 22);
            buttonTask.TabIndex = 1;
            buttonTask.Text = "Раздел задач";
            buttonTask.UseVisualStyleBackColor = true;
            buttonTask.Click += buttonTasks_Click;
            // 
            // buttonStaff
            // 
            buttonStaff.Location = new Point(55, 61);
            buttonStaff.Margin = new Padding(3, 2, 3, 2);
            buttonStaff.Name = "buttonStaff";
            buttonStaff.Size = new Size(241, 22);
            buttonStaff.TabIndex = 2;
            buttonStaff.Text = "Штат компании";
            buttonStaff.UseVisualStyleBackColor = true;
            buttonStaff.Click += buttonStaff_Click;
            // 
            // buttonRooms
            // 
            buttonRooms.Location = new Point(55, 87);
            buttonRooms.Margin = new Padding(3, 2, 3, 2);
            buttonRooms.Name = "buttonRooms";
            buttonRooms.Size = new Size(241, 22);
            buttonRooms.TabIndex = 3;
            buttonRooms.Text = "Перечень номеров";
            buttonRooms.UseVisualStyleBackColor = true;
            buttonRooms.Click += buttonRoom_Click;
            // 
            // buttonServis
            // 
            buttonServis.Location = new Point(55, 113);
            buttonServis.Margin = new Padding(3, 2, 3, 2);
            buttonServis.Name = "buttonServis";
            buttonServis.Size = new Size(241, 22);
            buttonServis.TabIndex = 4;
            buttonServis.Text = "Перечень дополнительных услуг";
            buttonServis.UseVisualStyleBackColor = true;
            buttonServis.Click += buttonService_Click;
            // 
            // FormBuh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 173);
            Controls.Add(buttonServis);
            Controls.Add(buttonRooms);
            Controls.Add(buttonStaff);
            Controls.Add(buttonTask);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormBuh";
            Text = "FormBuh";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem оРазработкичкахToolStripMenuItem;
        private Button buttonTask;
        private Button buttonStaff;
        private Button buttonRooms;
        private Button buttonServis;
    }
}