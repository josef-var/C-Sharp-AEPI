using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kaprekar
{
    public partial class Kaprekar : Form
    {
        public Kaprekar()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var result = chooseNumber.Text;
            Regex objFourNumbers = new Regex("([0-9]{4})");
            if (objFourNumbers.Match(result).Success == true)
            {
                resultBox.Text = "Chosen: " + result.ToString() + "\r\n";
                while (int.Parse(result) != 6174)
                {
                    var orderedmax = result.OrderByDescending(x => x);
                    var orderedmin = result.OrderBy(x => x);
                    int max = int.Parse(string.Join("", orderedmax));
                    int min = int.Parse(string.Join("", orderedmin));
                    if (min == max)
                    {
                        resultBox.AppendText("No result for this number");
                        break;
                    }
                    result = (max - min).ToString("D4");
                    resultBox.AppendText(max.ToString("D4") + " - " + min.ToString("D4") + " = " + result + "\r\n");
                }
            }
            else
            {
                MessageBox.Show("Four numbers!");
            }
        }
    }
}
