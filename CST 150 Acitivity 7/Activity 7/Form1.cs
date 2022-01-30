using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class ApproximatePi : Form
    {
        public ApproximatePi()
        {
            InitializeComponent();
        }

        private void ApproximatePi_Load(object sender, EventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            int n;
            double piVal = 4, num = 4, den = 3;
            n = Convert.ToInt32(NumTerms_Text.Text);

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    piVal -= num / den;
                }
                else
                {
                    piVal += num / den;
                }
                den += 2;
            }

            label1.Text = "Approximate value of pi after " + n + " terms";
            label3.Text = "= " + piVal;
      
            
            }
        }
}

