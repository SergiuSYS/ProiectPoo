namespace ProiectPoo.WinForms
{
    partial class CREATEACCOUNT
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 60);
            label1.Name = "label1";
            label1.Size = new Size(997, 81);
            label1.TabIndex = 0;
            label1.Text = "Hello!Please complete the following:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(527, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(471, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(527, 279);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(471, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(527, 340);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(471, 27);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 227);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(436, 282);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 7;
            label3.Text = "username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 343);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "password";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(602, 448);
            button2.Name = "button2";
            button2.Size = new Size(247, 94);
            button2.TabIndex = 10;
            button2.Text = "CREATE";
            button2.UseVisualStyleBackColor = true;
            // 
            // CREATEACCOUNT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Name = "CREATEACCOUNT";
            Size = new Size(1444, 590);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}
