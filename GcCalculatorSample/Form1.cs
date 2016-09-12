using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GcCalculatorSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gcCalculator1_OutputTextChanged(object sender, EventArgs e)
        {
            this.label2.Text = this.gcCalculator1.Value.ToString();
        }
    }
}
