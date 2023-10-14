namespace HostelProduct
{
    partial class FormEntry
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
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonEntry = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(55, 26);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(37, 15);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(51, 53);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(121, 24);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(110, 23);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(121, 53);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(110, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonEntry
            // 
            buttonEntry.Location = new Point(122, 94);
            buttonEntry.Margin = new Padding(3, 2, 3, 2);
            buttonEntry.Name = "buttonEntry";
            buttonEntry.Size = new Size(82, 22);
            buttonEntry.TabIndex = 4;
            buttonEntry.Text = "Entry";
            buttonEntry.UseVisualStyleBackColor = true;
            buttonEntry.Click += buttonEntry_Click;
            // 
            // FormEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 160);
            Controls.Add(buttonEntry);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEntry";
            Text = "Entry";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonEntry;
    }
}