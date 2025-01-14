namespace ProiectPoo.WinForms
{
    partial class CreateAccount
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
            label2 = new Label();
            createaccountbutton = new Button();
            returnbutton = new Button();
            label3 = new Label();
            password = new TextBox();
            label4 = new Label();
            username = new TextBox();
            da = new Label();
            Email = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 65);
            label2.Name = "label2";
            label2.Size = new Size(922, 62);
            label2.TabIndex = 1;
            label2.Text = "Please enter your information down below.";
            label2.Click += label2_Click;
            // 
            // createaccountbutton
            // 
            createaccountbutton.Location = new Point(437, 370);
            createaccountbutton.Name = "createaccountbutton";
            createaccountbutton.Size = new Size(144, 95);
            createaccountbutton.TabIndex = 12;
            createaccountbutton.Text = "Create Account";
            createaccountbutton.UseVisualStyleBackColor = true;
            // 
            // returnbutton
            // 
            returnbutton.Location = new Point(79, 420);
            returnbutton.Name = "returnbutton";
            returnbutton.Size = new Size(106, 68);
            returnbutton.TabIndex = 11;
            returnbutton.Text = "Return";
            returnbutton.UseVisualStyleBackColor = true;
            returnbutton.Click += returnbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 304);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(360, 301);
            password.Name = "password";
            password.Size = new Size(329, 27);
            password.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 254);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // username
            // 
            username.Location = new Point(360, 251);
            username.Name = "username";
            username.Size = new Size(329, 27);
            username.TabIndex = 7;
            // 
            // da
            // 
            da.AutoSize = true;
            da.Location = new Point(282, 207);
            da.Name = "da";
            da.Size = new Size(46, 20);
            da.TabIndex = 14;
            da.Text = "Email";
            // 
            // Email
            // 
            Email.Location = new Point(360, 204);
            Email.Name = "Email";
            Email.Size = new Size(329, 27);
            Email.TabIndex = 13;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 523);
            Controls.Add(da);
            Controls.Add(Email);
            Controls.Add(createaccountbutton);
            Controls.Add(returnbutton);
            Controls.Add(label3);
            Controls.Add(password);
            Controls.Add(label4);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateAccount";
            Text = "CreateAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button createaccountbutton;
        private Button returnbutton;
        private Label label3;
        private TextBox password;
        private Label label4;
        private TextBox username;
        private Label da;
        private TextBox Email;
    }
}