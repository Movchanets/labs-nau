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
            button7 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button11 = new Button();
            SuspendLayout();
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
            // button1
            // 
            button1.Location = new Point(94, 42);
            button1.Name = "button1";
            button1.Size = new Size(98, 41);
            button1.TabIndex = 7;
            button1.Text = "Створення фрукту";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCreateFruit_Click;
            // 
            // button2
            // 
            button2.Location = new Point(94, 89);
            button2.Name = "button2";
            button2.Size = new Size(98, 41);
            button2.TabIndex = 8;
            button2.Text = "Редагування фрукту";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnEditFruit_Click;
            // 
            // button3
            // 
            button3.Location = new Point(94, 136);
            button3.Name = "button3";
            button3.Size = new Size(98, 58);
            button3.TabIndex = 9;
            button3.Text = "Виведення інформації про фрукт";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnInfoFruit_Click;
            // 
            // button4
            // 
            button4.Location = new Point(94, 212);
            button4.Name = "button4";
            button4.Size = new Size(98, 41);
            button4.TabIndex = 10;
            button4.Text = "Знищення фрукту";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnDestroyFruit_Click;
            // 
            // button5
            // 
            button5.Location = new Point(396, 212);
            button5.Name = "button5";
            button5.Size = new Size(98, 41);
            button5.TabIndex = 14;
            button5.Text = "Знищення овоча";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnDestroyVegetable_Click;
            // 
            // button6
            // 
            button6.Location = new Point(396, 136);
            button6.Name = "button6";
            button6.Size = new Size(98, 58);
            button6.TabIndex = 13;
            button6.Text = "Виведення інформації про овоч";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnInfoVegatable_Click;
            // 
            // button8
            // 
            button8.Location = new Point(396, 89);
            button8.Name = "button8";
            button8.Size = new Size(98, 41);
            button8.TabIndex = 12;
            button8.Text = "Редагування овоча";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnEditVegetable_Click;
            // 
            // button9
            // 
            button9.Location = new Point(396, 42);
            button9.Name = "button9";
            button9.Size = new Size(98, 41);
            button9.TabIndex = 11;
            button9.Text = "Створення овоча";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnCreateVegetable_Click;
            // 
            // button10
            // 
            button10.Location = new Point(228, 103);
            button10.Name = "button10";
            button10.Size = new Size(139, 68);
            button10.TabIndex = 15;
            button10.Text = "Порівняти фрукт і овоч за базовими параметрами продукту";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnBinaryOperators_Click;
            // 
            // button12
            // 
            button12.Location = new Point(530, 83);
            button12.Name = "button12";
            button12.Size = new Size(75, 53);
            button12.TabIndex = 17;
            button12.Text = "Збільшити кількість на 1";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnVegetableQuantityUp_Click;
            // 
            // button13
            // 
            button13.Location = new Point(12, 142);
            button13.Name = "button13";
            button13.Size = new Size(75, 53);
            button13.TabIndex = 18;
            button13.Text = "Зменшити кількість на 1";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btnFruitQuantityDown_Click;
            // 
            // button14
            // 
            button14.Location = new Point(530, 142);
            button14.Name = "button14";
            button14.Size = new Size(75, 53);
            button14.TabIndex = 19;
            button14.Text = "Зменшити кількість на 1";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btnVegetableQuantityDown_Click;
            // 
            // button11
            // 
            button11.Location = new Point(12, 83);
            button11.Name = "button11";
            button11.Size = new Size(75, 53);
            button11.TabIndex = 20;
            button11.Text = "Збільшити кількість на 1";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnFruitQuantityUp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 320);
            Controls.Add(button11);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button7);
            Name = "Form1";
            Text = "OOPLR6";
            ResumeLayout(false);
        }

        #endregion
        private Button button7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button11;
    }
}