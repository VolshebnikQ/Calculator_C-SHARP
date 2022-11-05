namespace Sem2810
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.button_diff = new System.Windows.Forms.Button();
            this.button_multi = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_pow = new System.Windows.Forms.Button();
            this.button_fact = new System.Windows.Forms.Button();
            this.button_con = new System.Windows.Forms.Button();
            this.button_dis = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_one = new System.Windows.Forms.Button();
            this.button_two = new System.Windows.Forms.Button();
            this.button_three = new System.Windows.Forms.Button();
            this.button_six = new System.Windows.Forms.Button();
            this.button_five = new System.Windows.Forms.Button();
            this.button_four = new System.Windows.Forms.Button();
            this.button_nine = new System.Windows.Forms.Button();
            this.button_eight = new System.Windows.Forms.Button();
            this.button_seven = new System.Windows.Forms.Button();
            this.button_com = new System.Windows.Forms.Button();
            this.button_zero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_input.Location = new System.Drawing.Point(20, 14);
            this.textBox_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(492, 61);
            this.textBox_input.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.Location = new System.Drawing.Point(20, 172);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(71, 83);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_result.Location = new System.Drawing.Point(20, 97);
            this.label_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(39, 41);
            this.label_result.TabIndex = 2;
            this.label_result.Text = "=";
            // 
            // button_diff
            // 
            this.button_diff.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_diff.Location = new System.Drawing.Point(20, 265);
            this.button_diff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_diff.Name = "button_diff";
            this.button_diff.Size = new System.Drawing.Size(71, 83);
            this.button_diff.TabIndex = 3;
            this.button_diff.Text = "-";
            this.button_diff.UseVisualStyleBackColor = true;
            this.button_diff.Click += new System.EventHandler(this.button_diff_Click);
            // 
            // button_multi
            // 
            this.button_multi.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_multi.Location = new System.Drawing.Point(20, 358);
            this.button_multi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_multi.Name = "button_multi";
            this.button_multi.Size = new System.Drawing.Size(71, 83);
            this.button_multi.TabIndex = 4;
            this.button_multi.Text = "*";
            this.button_multi.UseVisualStyleBackColor = true;
            this.button_multi.Click += new System.EventHandler(this.button_multi_Click);
            // 
            // button_division
            // 
            this.button_division.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_division.Location = new System.Drawing.Point(20, 451);
            this.button_division.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(71, 83);
            this.button_division.TabIndex = 5;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // button_pow
            // 
            this.button_pow.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_pow.Location = new System.Drawing.Point(99, 265);
            this.button_pow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_pow.Name = "button_pow";
            this.button_pow.Size = new System.Drawing.Size(71, 83);
            this.button_pow.TabIndex = 6;
            this.button_pow.Text = "^";
            this.button_pow.UseVisualStyleBackColor = true;
            this.button_pow.Click += new System.EventHandler(this.button_pow_Click);
            // 
            // button_fact
            // 
            this.button_fact.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_fact.Location = new System.Drawing.Point(99, 172);
            this.button_fact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_fact.Name = "button_fact";
            this.button_fact.Size = new System.Drawing.Size(71, 83);
            this.button_fact.TabIndex = 7;
            this.button_fact.Text = "!";
            this.button_fact.UseVisualStyleBackColor = true;
            this.button_fact.Click += new System.EventHandler(this.button_fact_Click);
            // 
            // button_con
            // 
            this.button_con.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_con.Location = new System.Drawing.Point(99, 358);
            this.button_con.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_con.Name = "button_con";
            this.button_con.Size = new System.Drawing.Size(71, 83);
            this.button_con.TabIndex = 8;
            this.button_con.Text = "And";
            this.button_con.UseVisualStyleBackColor = true;
            this.button_con.Click += new System.EventHandler(this.button_con_Click);
            // 
            // button_dis
            // 
            this.button_dis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_dis.Location = new System.Drawing.Point(99, 451);
            this.button_dis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_dis.Name = "button_dis";
            this.button_dis.Size = new System.Drawing.Size(71, 83);
            this.button_dis.TabIndex = 9;
            this.button_dis.Text = "Or";
            this.button_dis.UseVisualStyleBackColor = true;
            this.button_dis.Click += new System.EventHandler(this.button_dis_Click);
            // 
            // button_equal
            // 
            this.button_equal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_equal.Location = new System.Drawing.Point(441, 172);
            this.button_equal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(71, 83);
            this.button_equal.TabIndex = 10;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_one
            // 
            this.button_one.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_one.Location = new System.Drawing.Point(191, 172);
            this.button_one.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_one.Name = "button_one";
            this.button_one.Size = new System.Drawing.Size(71, 83);
            this.button_one.TabIndex = 11;
            this.button_one.Text = "1";
            this.button_one.UseVisualStyleBackColor = true;
            this.button_one.Click += new System.EventHandler(this.button_one_Click);
            // 
            // button_two
            // 
            this.button_two.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_two.Location = new System.Drawing.Point(270, 172);
            this.button_two.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(71, 83);
            this.button_two.TabIndex = 12;
            this.button_two.Text = "2";
            this.button_two.UseVisualStyleBackColor = true;
            this.button_two.Click += new System.EventHandler(this.button_two_Click);
            // 
            // button_three
            // 
            this.button_three.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_three.Location = new System.Drawing.Point(349, 172);
            this.button_three.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_three.Name = "button_three";
            this.button_three.Size = new System.Drawing.Size(71, 83);
            this.button_three.TabIndex = 13;
            this.button_three.Text = "3";
            this.button_three.UseVisualStyleBackColor = true;
            this.button_three.Click += new System.EventHandler(this.button_three_Click);
            // 
            // button_six
            // 
            this.button_six.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_six.Location = new System.Drawing.Point(349, 265);
            this.button_six.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_six.Name = "button_six";
            this.button_six.Size = new System.Drawing.Size(71, 83);
            this.button_six.TabIndex = 16;
            this.button_six.Text = "6";
            this.button_six.UseVisualStyleBackColor = true;
            this.button_six.Click += new System.EventHandler(this.button_six_Click);
            // 
            // button_five
            // 
            this.button_five.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_five.Location = new System.Drawing.Point(270, 265);
            this.button_five.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_five.Name = "button_five";
            this.button_five.Size = new System.Drawing.Size(71, 83);
            this.button_five.TabIndex = 15;
            this.button_five.Text = "5";
            this.button_five.UseVisualStyleBackColor = true;
            this.button_five.Click += new System.EventHandler(this.button_five_Click);
            // 
            // button_four
            // 
            this.button_four.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_four.Location = new System.Drawing.Point(191, 265);
            this.button_four.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_four.Name = "button_four";
            this.button_four.Size = new System.Drawing.Size(71, 83);
            this.button_four.TabIndex = 14;
            this.button_four.Text = "4";
            this.button_four.UseVisualStyleBackColor = true;
            this.button_four.Click += new System.EventHandler(this.button_four_Click);
            // 
            // button_nine
            // 
            this.button_nine.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_nine.Location = new System.Drawing.Point(349, 358);
            this.button_nine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_nine.Name = "button_nine";
            this.button_nine.Size = new System.Drawing.Size(71, 83);
            this.button_nine.TabIndex = 19;
            this.button_nine.Text = "9";
            this.button_nine.UseVisualStyleBackColor = true;
            this.button_nine.Click += new System.EventHandler(this.button_nine_Click);
            // 
            // button_eight
            // 
            this.button_eight.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_eight.Location = new System.Drawing.Point(270, 358);
            this.button_eight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_eight.Name = "button_eight";
            this.button_eight.Size = new System.Drawing.Size(71, 83);
            this.button_eight.TabIndex = 18;
            this.button_eight.Text = "8";
            this.button_eight.UseVisualStyleBackColor = true;
            this.button_eight.Click += new System.EventHandler(this.button_eight_Click);
            // 
            // button_seven
            // 
            this.button_seven.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_seven.Location = new System.Drawing.Point(191, 358);
            this.button_seven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_seven.Name = "button_seven";
            this.button_seven.Size = new System.Drawing.Size(71, 83);
            this.button_seven.TabIndex = 17;
            this.button_seven.Text = "7";
            this.button_seven.UseVisualStyleBackColor = true;
            this.button_seven.Click += new System.EventHandler(this.button_seven_Click);
            // 
            // button_com
            // 
            this.button_com.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_com.Location = new System.Drawing.Point(349, 451);
            this.button_com.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_com.Name = "button_com";
            this.button_com.Size = new System.Drawing.Size(71, 83);
            this.button_com.TabIndex = 22;
            this.button_com.Text = ",";
            this.button_com.UseVisualStyleBackColor = true;
            this.button_com.Click += new System.EventHandler(this.button_com_Click);
            // 
            // button_zero
            // 
            this.button_zero.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_zero.Location = new System.Drawing.Point(270, 451);
            this.button_zero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_zero.Name = "button_zero";
            this.button_zero.Size = new System.Drawing.Size(71, 83);
            this.button_zero.TabIndex = 21;
            this.button_zero.Text = "0";
            this.button_zero.UseVisualStyleBackColor = true;
            this.button_zero.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 592);
            this.Controls.Add(this.button_com);
            this.Controls.Add(this.button_zero);
            this.Controls.Add(this.button_nine);
            this.Controls.Add(this.button_eight);
            this.Controls.Add(this.button_seven);
            this.Controls.Add(this.button_six);
            this.Controls.Add(this.button_five);
            this.Controls.Add(this.button_four);
            this.Controls.Add(this.button_three);
            this.Controls.Add(this.button_two);
            this.Controls.Add(this.button_one);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_dis);
            this.Controls.Add(this.button_con);
            this.Controls.Add(this.button_fact);
            this.Controls.Add(this.button_pow);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_multi);
            this.Controls.Add(this.button_diff);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_input;
        private Button button_add;
        private Label label_result;
        private Button button_diff;
        private Button button_multi;
        private Button button_division;
        private Button button_pow;
        private Button button_fact;
        private Button button_con;
        private Button button_dis;
        private Button button_equal;
        private Button button_one;
        private Button button_two;
        private Button button_three;
        private Button button_six;
        private Button button_five;
        private Button button_four;
        private Button button_nine;
        private Button button_eight;
        private Button button_seven;
        private Button button_com;
        private Button button_zero;
    }
}