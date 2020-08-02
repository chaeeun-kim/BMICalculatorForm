using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculatorForm
{
    public partial class BMICalculatorForm : Form
    {
        public double height { get; set; }
        public double weight { get; set; }
        public double result { get; set; }
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            weight = Convert.ToDouble(WeightTextBox.Text);
            height = Convert.ToDouble(HeightTextbox.Text);
            
            if (ImperialButton.Checked)
            {
                result = (weight*703 )/( height * height);
                BMITextBox.Text = Convert.ToString(result);
                if (result < 18.5)
                { MultilineTextBox.Text = "underweight"; }
                else if (result >= 18.5 || result <= 24.9)
                { MultilineTextBox.Text = "normal"; }
                else if (result >= 25 || result <= 29.9)
                {
                    MultilineTextBox.Text = "overweight";

                }
                else if (result > 30)
                { MultilineTextBox.Text = "obese"; }
            }
            else if (MetricButton.Checked)
            {
                result = weight /( height * height);
                BMITextBox.Text = Convert.ToString(result);
                if (result < 18.5)
                { MultilineTextBox.Text = "underweight"; }
                else if (result >= 18.5 || result <= 24.9)
                { MultilineTextBox.Text = "normal"; }
                else if (result >= 25 || result <= 29.9)
                {
                    MultilineTextBox.Text = "overweight";

                }
                else if (result > 30)
                {
                    MultilineTextBox.Text = "obese";

                }
            }
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            WeightTextBox.Text = null;
            HeightTextbox.Text = null;
            MultilineTextBox.Text = null;
            BMITextBox.Text = null;
            ImperialButton.Checked = false;
            MetricButton.Checked = false;
        }
    }
}
