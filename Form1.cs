using System;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;

namespace KakuroWithGui
{
    public partial class Form1 : Form
    {
        public int total, spaces;
        public string answers;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            SumValues(total, spaces, list);
            label4.Text = answers;
            answers = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        public void SumValues(int total, int spaces, List<int> used)
        {
            if (total >= 9 && !used.Contains(9) && !ContainsLessThan(9, used))
            {
                used.Add(9);
                SumValues(total - 9, spaces - 1, used);
            }
            if (total >= 8 && !used.Contains(8) && !ContainsLessThan(8, used))
            {
                used.Add(8);
                SumValues(total - 8, spaces - 1, used);
            }
            if (total >= 7 && !used.Contains(7) && !ContainsLessThan(7, used))
            {
                used.Add(7);
                SumValues(total - 7, spaces - 1, used);
            }
            if (total >= 6 && !used.Contains(6) && !ContainsLessThan(6, used))
            {
                used.Add(6);
                SumValues(total - 6, spaces - 1, used);
            }
            if (total >= 5 && !used.Contains(5) && !ContainsLessThan(5, used))
            {
                used.Add(5);
                SumValues(total - 5, spaces - 1, used);
            }
            if (total >= 4 && !used.Contains(4) && !ContainsLessThan(4, used))
            {
                used.Add(4);
                SumValues(total - 4, spaces - 1, used);
            }
            if (total >= 3 && !used.Contains(3) && !ContainsLessThan(3, used))
            {
                used.Add(3);
                SumValues(total - 3, spaces - 1, used);
            }
            if (total >= 2 && !used.Contains(2) && !ContainsLessThan(2, used))
            {
                used.Add(2);
                SumValues(total - 2, spaces - 1, used);
            }
            if (total >= 1 && !used.Contains(1) && !ContainsLessThan(1, used))
            {
                used.Add(1);
                SumValues(total - 1, spaces - 1, used);
            }

            

            if (total == 0 && spaces == 0)
            {
                

                for (int i = 0; i < used.Count - 1; i++)
                {
                    answers += $"{used[i]} + ";
                }
                if (used.Count > 0)
                {
                    answers += used[used.Count - 1] + "\n";
                }
                    
            }

            if (used.Count > 0)
            {
                used.RemoveAt(used.Count - 1);
            }

        }

        public bool ContainsLessThan(int n, List<int> l)
        {
            foreach (int i in l)
            {
                if (i < n)
                {
                    return true;
                }
            }
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = textBox1.Text;
                total = Convert.ToInt32(text);
            }
            catch
            {
                total = 0;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = textBox2.Text;
                spaces = Convert.ToInt32(text);
            } catch {
                spaces = 0;
            }
        }
    }
}