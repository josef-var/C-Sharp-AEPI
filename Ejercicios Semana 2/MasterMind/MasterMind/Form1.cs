using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        public string number;
        public string matches = "";
        int numbermatches = 0;
        public int counter = 1;
        public int dup = 0;
        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            HashSet<int> hash = new HashSet<int>();
            while (hash.Count < 4)
            {
                hash.Add(r.Next(0, 10));
            }
            number = string.Join("", hash.ToArray());
            //Debug show number
            MessageBox.Show(number, "!Solo para depurar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //number = "2222";
            string numbers = (number1.Text + number2.Text + number3.Text + number4.Text);
            if (number == numbers)
            {
                MessageBox.Show($"Succes!\r\n{number} is correct!\r\nPlay again!");
                Attempts.Items.Clear();
                Matches.Items.Clear();
                Random r = new Random();
                HashSet<int> hash = new HashSet<int>();
                while (hash.Count < 4)
                {
                    hash.Add(r.Next(0, 10));
                }
                number = string.Join("", hash.ToArray());
                number1.Text = "";
                number2.Text = "";
                number3.Text = "";
                number4.Text = "";
                number1.Select();
                //Close();
            }
            else
            {
                Regex objFourNumbers = new Regex("([0-9]{4})");
                if (objFourNumbers.Match(numbers).Success == true)
                {
                    Attempts.Items.Add(counter+": " + number1.Text + " " + number2.Text + " " + number3.Text + " " + number4.Text);
                    Attempts.SelectedIndex = Attempts.Items.Count - 1;
                    counter++;
                    matches = "";
                    numbermatches = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        if (number[i] == numbers[i])  { matches = matches + "X"; }
                        else { matches = matches + "O"; }
                    }

                    foreach (var c in number)
                    {
                        if (numbers.Contains(c)) { numbermatches++; }
                    }
                    if (radioButton2.Checked) Matches.Items.Add(numbermatches);
                    else Matches.Items.Add(matches);
                    Matches.SelectedIndex = Matches.Items.Count - 1;
                    number1.Text = "";
                    number2.Text = "";
                    number3.Text = "";
                    number4.Text = "";
                    number1.Select();
                }
                else MessageBox.Show("Four numbers!");
            }
        }

        private void WriteNumber(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Regex objNumber = new Regex("([0-9])");
            if (objNumber.Match(tb.Text).Success == true) SendKeys.Send("{TAB}");
            else if (tb.Text == "") { }
            else MessageBox.Show("Only numbers!");
        }
    }
}
