using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace PythonIntegrationSample
{
    public partial class MainForm : Form
    {
        private PythonHandler pythonHandler;

        public MainForm()
        {
            this.pythonHandler = new PythonHandler();
            InitializeComponent();
            
        }

        private void ValidateInput()
        {
            if (!chbRepetition.Checked && nudP.Value > nudN.Value)
                btnCalculate.Enabled = false;
            else
                btnCalculate.Enabled = true;
      
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ValidateInput(); 
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            BigInteger result;
            int n = Decimal.ToInt32(nudN.Value);
            int p = Decimal.ToInt32(nudP.Value);
            bool repeat = chbRepetition.Checked;

            try
            {
                if (rdbCombination.Checked)
                    result = new BigInteger(pythonHandler.Combination(n, p, repeat));
                else
                    result = new BigInteger(pythonHandler.Permutation(n, p, repeat));

                txbResult.Text = Convert.ToString(result);
            }
            catch
            {
                txbResult.Text = "Result too large";
            }

        }

        private void chbRepetition_CheckedChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void nudN_ValueChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }
    }
}
