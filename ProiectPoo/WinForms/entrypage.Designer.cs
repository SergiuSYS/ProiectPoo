namespace ProiectPoo.WinForms
{
    partial class entrypage
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
            label1 = new Label();
            login = new Button();
            createaccount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 134);
            label1.Name = "label1";
            label1.Size = new Size(811, 81);
            label1.TabIndex = 0;
            label1.Text = "Hello!Please chose an option.";
            label1.Click += label1_Click;
            // 
            // login
            // 
            login.Location = new Point(284, 344);
            login.Name = "login";
            login.Size = new Size(213, 132);
            login.TabIndex = 1;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // createaccount
            // 
            createaccount.Location = new Point(599, 344);
            createaccount.Name = "createaccount";
            createaccount.Size = new Size(213, 132);
            createaccount.TabIndex = 2;
            createaccount.Text = "Create Account";
            createaccount.UseVisualStyleBackColor = true;
            createaccount.Click += createaccount_Click;
            // 
            // entrypage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 670);
            Controls.Add(createaccount);
            Controls.Add(login);
            Controls.Add(label1);
            Name = "entrypage";
            Text = "entrypage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button login;
        private Button createaccount;
    }
}