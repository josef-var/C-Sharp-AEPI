using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseCoordinates
{
    public partial class Form1 : Form
    {
        /*
        * 1. En un formulario se debe mostrar la coordenada X y
        * la coordenada Y del ratón. Y evidentemente cambia con el movimiento
        */
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Form1_MouseMove);
        }

        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            label1.Text = string.Format("X={0}", e.X);
            label2.Text = string.Format("Y={0}", e.Y);
        }
    }
}