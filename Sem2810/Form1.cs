using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace Sem2810
{
    public partial class Form1 : Form
    {//.Replace(" ", "")    IndexOf('s') != -1
        public string input;
        public string alhabet = "1234567890+-*/!^&|,";
        public string signs = "+-*/&|";
        public Form1()
        {
            InitializeComponent();
        }
        private void fill_input(string str)
        {
            input = input.Replace(" ", "").Replace(".", ",");
            textBox_input.Text = $"{input}{str}";
        }

        private void fill_input_sign(string sign)
        {
            input = input.Replace(" ", "").Replace(".", ",");
            string new_input = "";
            if (input.Length == 0)
            {
                if (sign == "-") { new_input = $"{sign}"; }
            }
            else
            {
                string cur_sign = "";
                for (int i = 0; i < input.Length; i++)
                {
                    string str = Convert.ToString(input[i]);
                    bool is_num = int.TryParse(str, out _);
                    if (is_num || str.Equals("!")) { 
                        new_input += str;
                        cur_sign = "";
                    }
                    else
                    {
                        if (cur_sign.Length == 0) { new_input += str; }
                        cur_sign = str;
                    }
                }
                if (cur_sign.Length == 0) { new_input += $"{sign}";}
                else { new_input = $"{new_input.Substring(0, new_input.Length-1)}{sign}"; }
            }
            textBox_input.Text = $"{new_input}";
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input_sign("+");
        }
        private void button_diff_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input_sign("-");
        }
        private void button_multi_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input_sign("*");
        }
        private void button_division_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input_sign("/");
        }
        private void button_fact_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input_sign("!");
        }
        private void button_con_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input_sign("&");
        }
        private void button_dis_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input_sign("|");
        }
        private void button_pow_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input_sign("^");
        }
        private void button_one_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input("1");
        }
        private void button_two_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input("2");
        }
        private void button_three_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input("3");
        }
        private void button_four_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input("4");
        }
        private void button_five_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input("5");
        }
        private void button_six_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input("6");
        }
        private void button_seven_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input("7");
        }
        private void button_eight_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input("8");
        }
        private void button_nine_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input("9");
        }
        private void button_zero_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input("0");
        }
        private void button_com_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text);
            fill_input(",");
        }
        private void button_equal_Click(object sender, EventArgs e)
        {
            input = Convert.ToString(textBox_input.Text).Replace(" ", "").Replace(".", ",");
            label_result.Text = "=";
            if (input.Length > 0)
            {
                int len = input.Length;
                List<string> str_task = new List<string>();
                string cur_num = "";

                for (int i = 0; i < len; i++)
                {
                    char c = input[i];
                    string str = Convert.ToString(c);
                    bool is_num = int.TryParse(str, out _);
                    if (is_num) { cur_num += str; }
                    else if (str.Equals(","))
                    {
                        if (cur_num.IndexOf(',') != -1) { label_result.Text = "Не правильное число"; break; }

                        cur_num += str;
                    }
                    else
                    {
                        if (alhabet.IndexOf(c) == -1) { label_result.Text = "Посторонние символы"; break; }
                        str_task.Add(cur_num);
                        str_task.Add(str);
                        cur_num = "";
                    }
                    if (i == len-1 && cur_num.Length > 0) { str_task.Add(cur_num); }
                }
                Calculate(str_task);
            }
        }
        public double add(double a ,double b)       //  СЛОЖЕНИЕ
        {
            return a + b;
        }
        public double diff(double a, double b)      //  ВЫЧИТАНИЕ
        {
            return a - b;
        }
        public double multi(double a, double b)     //  УМНОЖЕНИЕ
        {
            return a * b;
        }
        public double division(double a, double b)  //  ДЕЛЕНИЕ
        {
            return a / b;
        }
        public double fact(long a)                  //  ФАКТОРИАЛ
        {
            double f = 1;
            for (int i = 1; i <= a; i++)
                f *= (double)i;

            return f;
        }
        public double con(long a, long b)             //  ЛОГИЧЕСКОЕ И
        {
            return a & b;
        }
        public double dis(long a, long b)             //  ЛОГИЧЕСКОЕ ИЛИ
        {
            return a | b;
        }
        public double pow(double a, double b)       //  СТЕПНЬ
        {
            return Math.Pow(a, b);
        }

        public bool Exceptions(List<string> str_task)   //  ПРОВЕРКА ВВОДА НА ПРАВИЛЬНОСТЬ
        {
            int add = str_task.LastIndexOf("+");
            int dif = str_task.LastIndexOf("-");
            int mul = str_task.LastIndexOf("*");
            int dev = str_task.LastIndexOf("/");

            int pow = str_task.LastIndexOf("^");
            int fact = str_task.LastIndexOf("!");
            int con = str_task.LastIndexOf("&");
            int dis = str_task.LastIndexOf("|");
            int len = str_task.Count();

            if (pow != -1)
            {
                if (pow + 1 >= len) { label_result.Text = "Выражение ^ не полное"; return false; }
                bool is_num = int.TryParse(str_task[pow + 1], out _);
                if (!is_num) { label_result.Text = "Только целое для ^b"; return false; }
            }
            if (fact != -1)
            {
                bool is_num = int.TryParse(str_task[fact - 1], out _);
                if (!is_num) { label_result.Text = "Только целое для a!"; return false; }
            }
            if (con != -1)
            {
                bool a_is_num = int.TryParse(str_task[con - 1], out _);
                if (con + 1 >= len) { label_result.Text = "Выражение a AND b не полное"; return false; }
                bool b_is_num = int.TryParse(str_task[con + 1], out _);
                if (!a_is_num | !b_is_num) { label_result.Text = "Только целое для a AND b"; return false; }
            }
            if (dis != -1)
            {
                bool a_is_num = int.TryParse(str_task[dis - 1], out _);
                if (dis + 1 >= len) { label_result.Text = "Выражение a OR b не полное"; return false; }
                bool b_is_num = int.TryParse(str_task[dis + 1], out _);
                if (!a_is_num | !b_is_num) { label_result.Text = "Только целое для a OR b"; return false; }
            }

            if (add != -1)
            {
                if (add + 1 >= len) { label_result.Text = "Выражение a + b не полное"; return false; }
            }
            if (dif != -1)
            {
                if (dif + 1 >= len) { label_result.Text = "Выражение a - b не полное"; return false; }
            }
            if (mul != -1)
            {
                if (mul + 1 >= len) { label_result.Text = "Выражение a * b не полное"; return false; }
            }
            if (dev != -1)
            {
                if (dev + 1 >= len) { label_result.Text = "Выражение a / b не полное"; return false; }
                if (str_task[dev+1].Equals("0")) { label_result.Text = "На 0 делить нельзя"; return false; }
            }

            return true;
        }
        public void Calculate(List<string> str_task)
        {
            if (!Exceptions(str_task)) { return; }

            int i = 0;
            while (str_task.IndexOf("^") != -1 | str_task.IndexOf("!") != -1)
            {
                var cur = str_task[i];
                if (cur.Equals("^"))
                {
                    double a = Convert.ToDouble(str_task[i - 1]); double b = Convert.ToDouble(str_task[i + 1]);
                    str_task[i - 1] = Convert.ToString(pow(a, b));
                    str_task.RemoveAt(i); str_task.RemoveAt(i); i -= 2;
                    str_task.RemoveAll(x => x == null || x.Equals(""));
                } else if (cur.Equals("!"))
                {
                    long a = Convert.ToInt64(str_task[i - 1]);
                    str_task[i - 1] = Convert.ToString(fact(a));
                    str_task.RemoveAt(i); i -= 1;
                    str_task.RemoveAll(x => x == null || x.Equals(""));
                }
                i++;
            }
            i = 0;
            while (str_task.IndexOf("*") != -1 | str_task.IndexOf("/") != -1)
            {
                var cur = str_task[i];
                if (cur.Equals("*"))
                {
                    double a = Convert.ToDouble(str_task[i - 1]); double b = Convert.ToDouble(str_task[i + 1]);
                    str_task[i - 1] = Convert.ToString(multi(a, b));
                    str_task.RemoveAt(i); str_task.RemoveAt(i); i -= 2;
                    str_task.RemoveAll(x => x == null || x.Equals(""));
                }
                else if (cur.Equals("/"))
                {
                    double a = Convert.ToDouble(str_task[i - 1]); double b = Convert.ToDouble(str_task[i + 1]);
                    str_task[i - 1] = Convert.ToString(division(a, b));
                    str_task.RemoveAt(i); str_task.RemoveAt(i); i -= 2;
                    str_task.RemoveAll(x => x == null || x.Equals(""));
                }
                i++;
            }

            i = 0;
            while (str_task.IndexOf("+") != -1 | str_task.IndexOf("-") != -1)
            {
                var cur = str_task[i];
                if (cur.Equals("+"))
                {
                    var test = str_task;
                    double a = Convert.ToDouble(str_task[i - 1]); double b = Convert.ToDouble(str_task[i + 1]);
                    str_task[i - 1] = Convert.ToString(add(a, b));
                    str_task.RemoveAt(i); str_task.RemoveAt(i); i -= 2;
                    str_task.RemoveAll(x => x == null || x.Equals(""));
                }
                else if (cur.Equals("-"))
                {
                    double a = Convert.ToDouble(str_task[i - 1]); double b = Convert.ToDouble(str_task[i + 1]);
                    str_task[i - 1] = Convert.ToString(diff(a, b));
                    str_task.RemoveAt(i); str_task.RemoveAt(i); i -= 2;
                    str_task.RemoveAll(x => x == null || x.Equals(""));
                }
                i++;
            }

            i = 0;
            while (str_task.IndexOf("&") != -1 | str_task.IndexOf("|") != -1)
            {
                var cur = str_task[i];
                if (cur.Equals("&"))
                {
                    long a = Convert.ToInt64(str_task[i - 1]); long b = Convert.ToInt64(str_task[i + 1]);
                    str_task[i - 1] = Convert.ToString(con(a, b));
                    str_task.RemoveAt(i); str_task.RemoveAt(i); i -= 2;
                    str_task.RemoveAll(x => x == null || x.Equals(""));
                }
                else if (cur.Equals("|"))
                {
                    long a = Convert.ToInt64(str_task[i - 1]); long b = Convert.ToInt64(str_task[i + 1]);
                    str_task[i - 1] = Convert.ToString(dis(a, b));
                    str_task.RemoveAt(i); str_task.RemoveAt(i); i -= 2;
                    str_task.RemoveAll(x => x == null || x.Equals(""));
                }
                i++;
            }

            label_result.Text = $"= {str_task[0]}";
        }
    }
}