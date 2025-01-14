namespace ProiectPoo.WinForms
{
    partial class login
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
            username = new TextBox();
            label2 = new Label();
            label3 = new Label();
            password = new TextBox();
            returnbutton = new Button();
            loginbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 110);
            label1.Name = "label1";
            label1.Size = new Size(830, 81);
            label1.TabIndex = 0;
            label1.Text = "Please enter your information.";
            label1.Click += label1_Click;
            // 
            // username
            // 
            username.Location = new Point(327, 241);
            username.Name = "username";
            username.Size = new Size(329, 27);
            username.TabIndex = 1;
            username.TextChanged += username_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 244);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 294);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(327, 291);
            password.Name = "password";
            password.Size = new Size(329, 27);
            password.TabIndex = 3;
            
            // 
            // returnbutton
            // 
            returnbutton.Location = new Point(46, 410);
            returnbutton.Name = "returnbutton";
            returnbutton.Size = new Size(106, 68);
            returnbutton.TabIndex = 5;
            returnbutton.Text = "Return";
            returnbutton.UseVisualStyleBackColor = true;
            returnbutton.Click += returnbutton_Click;
            // 
            // loginbutton
            // 
            loginbutton.Location = new Point(404, 360);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(144, 95);
            loginbutton.TabIndex = 6;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += button1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 548);
            Controls.Add(loginbutton);
            Controls.Add(returnbutton);
            Controls.Add(label3);
            Controls.Add(password);
            Controls.Add(label2);
            Controls.Add(username);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox username;
        private Label label2;
        private Label label3;
        private TextBox password;
        private Button returnbutton;
        private Button loginbutton;
    }
}