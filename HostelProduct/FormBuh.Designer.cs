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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оРазработкичкахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonTask = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.buttonServis = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оРазработкичкахToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оРазработкичкахToolStripMenuItem
            // 
            this.оРазработкичкахToolStripMenuItem.Name = "оРазработкичкахToolStripMenuItem";
            this.оРазработкичкахToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.оРазработкичкахToolStripMenuItem.Text = "О Разработкичках";
            this.оРазработкичкахToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // buttonTask
            // 
            this.buttonTask.Location = new System.Drawing.Point(63, 46);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(140, 29);
            this.buttonTask.TabIndex = 1;
            this.buttonTask.Text = "Раздел задач";
            this.buttonTask.UseVisualStyleBackColor = true;
            this.buttonTask.Click += new System.EventHandler(this.buttonTasks_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.Location = new System.Drawing.Point(63, 81);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(140, 29);
            this.buttonStaff.TabIndex = 2;
            this.buttonStaff.Text = "Штат компании";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonRooms
            // 
            this.buttonRooms.Location = new System.Drawing.Point(63, 116);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Size = new System.Drawing.Size(198, 29);
            this.buttonRooms.TabIndex = 3;
            this.buttonRooms.Text = "Перечень номеров";
            this.buttonRooms.UseVisualStyleBackColor = true;
            this.buttonRooms.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonServis
            // 
            this.buttonServis.Location = new System.Drawing.Point(63, 151);
            this.buttonServis.Name = "buttonServis";
            this.buttonServis.Size = new System.Drawing.Size(275, 29);
            this.buttonServis.TabIndex = 4;
            this.buttonServis.Text = "Перечень дополнительных услуг";
            this.buttonServis.UseVisualStyleBackColor = true;
            this.buttonServis.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // FormBuh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonServis);
            this.Controls.Add(this.buttonRooms);
            this.Controls.Add(this.buttonStaff);
            this.Controls.Add(this.buttonTask);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBuh";
            this.Text = "FormBuh";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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