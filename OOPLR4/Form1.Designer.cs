﻿namespace OOPLR3
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(63, 33);
            button1.Name = "button1";
            button1.Size = new Size(130, 40);
            button1.TabIndex = 0;
            button1.Text = "Використання абстрактного класу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(63, 92);
            button2.Name = "button2";
            button2.Size = new Size(130, 55);
            button2.TabIndex = 1;
            button2.Text = "Овоч по замовчуванню";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(63, 153);
            button3.Name = "button3";
            button3.Size = new Size(130, 49);
            button3.TabIndex = 2;
            button3.Text = "Фрукт по замовчуванню";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(441, 153);
            button4.Name = "button4";
            button4.Size = new Size(130, 49);
            button4.TabIndex = 4;
            button4.Text = "Фрукт з параметрами";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(441, 92);
            button5.Name = "button5";
            button5.Size = new Size(130, 55);
            button5.TabIndex = 3;
            button5.Text = "Овоч з параметрами";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(441, 33);
            button6.Name = "button6";
            button6.Size = new Size(130, 40);
            button6.TabIndex = 5;
            button6.Text = "Поточна кількість об'єктів";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(253, 265);
            button7.Name = "button7";
            button7.Size = new Size(127, 43);
            button7.TabIndex = 6;
            button7.Text = "Завершити роботу";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(63, 208);
            button8.Name = "button8";
            button8.Size = new Size(130, 44);
            button8.TabIndex = 7;
            button8.Text = "Створити нову кнопку";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(441, 209);
            button9.Name = "button9";
            button9.Size = new Size(130, 43);
            button9.TabIndex = 8;
            button9.Text = "Розкидати все";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(253, 137);
            button10.Name = "button10";
            button10.Size = new Size(130, 43);
            button10.TabIndex = 9;
            button10.Text = "Перемістити все вліво";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 320);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "OOPLR4";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}