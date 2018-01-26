using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float numero1 = 0;
        float numero2 = 0;
        float res = 0;
        string operando = "";
        bool reset = false;

        protected override void OnShown(EventArgs e)
        {
            textBox1.Focus();
            base.OnShown(e);
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void EscribeNumero(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (reset == true)
            {
                textBox1.Text = b.Text;
                reset = false;
            }
            else
            {
                textBox1.Text += b.Text;
                reset = false;
            }
        }
        private void EscribeOperando(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            numero1 = float.Parse(textBox1.Text);
            operando = b.Text;
            reset = true;
            textBox1.Focus();
        }
        private void buttoncoma_Click(object sender, EventArgs e)
        {
            string output = (textBox1.Text.Contains(",") || string.IsNullOrEmpty(textBox1.Text)) ? textBox1.Text += "" : textBox1.Text += ",";
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            float numero2 = float.Parse(textBox1.Text);
            
            if (operando == "+")
            {
                res = numero1 + numero2;
            }
            if (operando == "-")
            {
                res = numero1 - numero2;
            }
            if (operando == "*")
            {
                res = numero1 * numero2;
            }
            if (operando == "/")
            {
                res = numero1 / numero2;
            }
            if (operando == "")
            {
                res = numero2;
            }
            textBox1.Text = (Convert.ToString(res));
            operando = "";
            numero1 = float.Parse(textBox1.Text);
            numero2 = 0;
            reset = true;
        }
        private void buttonreset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void buttonsign_Click(object sender, EventArgs e)
        {
            float numerox = float.Parse(textBox1.Text);
            textBox1.Text = (Convert.ToString(numerox*-1));
        }
        private void buttonoff_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (reset != true)
            {
                Regex objNotNumberPattern = new Regex("([0-9]+|Divide+|Oemcomma+|Oemplus+|OemMinus+|ShiftKey)");
                if (!(objNotNumberPattern.IsMatch(e.KeyCode.ToString()) || Char.IsControl((char)e.KeyCode)))

                {
                    e.SuppressKeyPress = true;
                    //MessageBox.Show(e.KeyCode.ToString());

                }
                else if (e.KeyCode.ToString() == "Oemplus" && e.Modifiers == Keys.Shift)
                {
                    e.SuppressKeyPress = true;
                    numero1 = float.Parse(textBox1.Text);
                    operando = "*";
                    reset = true;
                }
                else if (e.KeyCode.ToString() == "Oemplus")
                {
                    e.SuppressKeyPress = true;
                    numero1 = float.Parse(textBox1.Text);
                    operando = "+";
                    reset = true;
                }
                else if (e.KeyCode.ToString() == "OemMinus" && (string.IsNullOrEmpty(textBox1.Text)))
                {

                }
                else if (e.KeyCode.ToString() == "OemMinus")
                {
                    e.SuppressKeyPress = true;
                    numero1 = float.Parse(textBox1.Text);
                    operando = "-";
                    reset = true;
                }
                else if (e.KeyCode.ToString() == "/" && e.Modifiers == Keys.Shift)
                {
                    MessageBox.Show(e.KeyCode.ToString());
                    e.SuppressKeyPress = true;
                    numero1 = float.Parse(textBox1.Text);
                    operando = "/";
                    reset = true;
                }

                else if (e.KeyCode.ToString() == "Oemcomma")
                {
                    if ((textBox1.Text.Contains(",")) || (string.IsNullOrEmpty(textBox1.Text))) e.SuppressKeyPress = true;
                }
                else if (e.KeyCode.ToString() == Convert.ToString(Keys.Return))
                {
                    float numero2 = float.Parse(textBox1.Text);

                    if (operando == "+")
                    {
                        res = numero1 + numero2;
                    }
                    else if (operando == "-")
                    {
                        res = numero1 - numero2;
                    }
                    else if (operando == "*")
                    {
                        res = numero1 * numero2;
                    }
                    else if (operando == "/")
                    {
                        res = numero1 / numero2;
                    }
                    else if (operando == "")
                    {
                        res = numero2;
                    }
                    textBox1.Text = (Convert.ToString(res));
                    operando = "";
                    numero1 = float.Parse(textBox1.Text);
                    numero2 = 0;
                    reset = true;
                }
            }
            else
            {
                textBox1.Text = "";
                reset = false;
            }

            
            
            /*
            numero1 = float.Parse(textBox1.Text);
            operando = b.Text;
            reset = true;
            textBox1.Focus();
            */
        }
    }
}
