namespace OOPLR1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(134, 32);
            label1.Name = "label1";
            label1.Size = new Size(504, 38);
            label1.TabIndex = 0;
            label1.Text = "Не кажи гоп, поки не перестрибнеш";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(69, 91);
            button1.Name = "button1";
            button1.Size = new Size(217, 43);
            button1.TabIndex = 1;
            button1.Text = "Історія №1:";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(69, 140);
            button2.Name = "button2";
            button2.Size = new Size(217, 43);
            button2.TabIndex = 2;
            button2.Text = "Історія №2:";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(69, 202);
            button3.Name = "button3";
            button3.Size = new Size(217, 43);
            button3.TabIndex = 3;
            button3.Text = "Історія №3:";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(69, 263);
            button4.Name = "button4";
            button4.Size = new Size(217, 43);
            button4.TabIndex = 4;
            button4.Text = "Історія №4:";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(69, 328);
            button5.Name = "button5";
            button5.Size = new Size(217, 43);
            button5.TabIndex = 5;
            button5.Text = "Історія №5:";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(530, 395);
            button6.Name = "button6";
            button6.Size = new Size(217, 43);
            button6.TabIndex = 6;
            button6.Text = "Вийти";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Вас вітає ПІ221 Мовчанець  В'ячеслав Романович";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}