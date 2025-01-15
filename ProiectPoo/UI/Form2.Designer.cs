namespace ProiectPoo.UI
{
    partial class Form2
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            makeComanda1 = new MakeComanda();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 80);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(941, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 74);
            button2.TabIndex = 1;
            button2.Text = "Admin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1059, 3);
            button1.Name = "button1";
            button1.Size = new Size(112, 74);
            button1.TabIndex = 0;
            button1.Text = "MyAccount";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // makeComanda1
            // 
            makeComanda1.Location = new Point(12, 89);
            makeComanda1.Name = "makeComanda1";
            makeComanda1.Size = new Size(1160, 560);
            makeComanda1.TabIndex = 1;
            makeComanda1.Load += makeComanda1_Load;
            // 
            // Form2
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(makeComanda1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private MakeComanda makeComanda1;
    }
}