namespace Lab2_if9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_answer = new System.Windows.Forms.Label();
            this.button_solution = new System.Windows.Forms.Button();
            this.textBox_firstNum = new System.Windows.Forms.TextBox();
            this.textBox_secondNum = new System.Windows.Forms.TextBox();
            this.textBox_thirdNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Составить программу нахождения произведения двух наименьших из трех различных чис" +
    "ел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Первое число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Второе число";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Третье число";
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_answer.Location = new System.Drawing.Point(50, 250);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(0, 25);
            this.label_answer.TabIndex = 4;
            // 
            // button_solution
            // 
            this.button_solution.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_solution.Location = new System.Drawing.Point(175, 300);
            this.button_solution.Name = "button_solution";
            this.button_solution.Size = new System.Drawing.Size(150, 50);
            this.button_solution.TabIndex = 5;
            this.button_solution.Text = "Решить";
            this.button_solution.UseVisualStyleBackColor = true;
            this.button_solution.Click += new System.EventHandler(this.button_solution_Click);
            // 
            // textBox_firstNum
            // 
            this.textBox_firstNum.Location = new System.Drawing.Point(200, 90);
            this.textBox_firstNum.MaxLength = 20;
            this.textBox_firstNum.Name = "textBox_firstNum";
            this.textBox_firstNum.Size = new System.Drawing.Size(150, 23);
            this.textBox_firstNum.TabIndex = 6;
            this.textBox_firstNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_firstNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox_secondNum
            // 
            this.textBox_secondNum.Location = new System.Drawing.Point(200, 140);
            this.textBox_secondNum.Name = "textBox_secondNum";
            this.textBox_secondNum.Size = new System.Drawing.Size(150, 23);
            this.textBox_secondNum.TabIndex = 7;
            this.textBox_secondNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_secondNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox_thirdNum
            // 
            this.textBox_thirdNum.Location = new System.Drawing.Point(200, 190);
            this.textBox_thirdNum.Name = "textBox_thirdNum";
            this.textBox_thirdNum.Size = new System.Drawing.Size(150, 23);
            this.textBox_thirdNum.TabIndex = 8;
            this.textBox_thirdNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_thirdNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.textBox_thirdNum);
            this.Controls.Add(this.textBox_secondNum);
            this.Controls.Add(this.textBox_firstNum);
            this.Controls.Add(this.button_solution);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Задача на if";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Button button_solution;
        private System.Windows.Forms.TextBox textBox_firstNum;
        private System.Windows.Forms.TextBox textBox_secondNum;
        private System.Windows.Forms.TextBox textBox_thirdNum;
    }
}

