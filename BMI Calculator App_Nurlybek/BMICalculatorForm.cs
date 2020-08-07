using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator_App_Nurlybek
{
    public partial class BMICalculatorForm : Form
    {
        //INITIALIZE FORM
        public BMICalculatorForm()
        {
            InitializeComponent();
        }
        //CALCULATE BUTTON
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            //IF INPUT ON BOTH MY HEIGHT AND MY WEIGHT TEXTBOXES ARE EMPTY
            //THROW MESSAGE TO ENTER VALUES
            if (MyHeightInput.Text == String.Empty && MyHeightInput.Text == String.Empty)
            {
                CalculatedResult.Text = "Please enter values";
            }
            else
            {
                double HeightInMeters;
                double HeightInInches;
                double WeightInPounds;
                double WeightInKilograms;
                double result =0.0;
                //CHECK WHICH RADIOBUTTON IS CHECKED
                if (MetricRadioButton.Checked)
                {
                    HeightInMeters = Convert.ToDouble(MyHeightInput.Text);
                    WeightInKilograms = Convert.ToDouble(MyWeightInput.Text);
                    result = (WeightInKilograms * 703) / (HeightInMeters * HeightInMeters);
                }
                else if (ImperialRadioButton.Checked)
                {
                    HeightInInches = Convert.ToDouble(MyHeightInput.Text);
                    WeightInPounds = Convert.ToDouble(MyWeightInput.Text);
                    result = (WeightInPounds * 703) / (HeightInInches * HeightInInches);
                }
                //RETURN RESULT TO THE MULTILINE TEXTBOX
                CalculatedResult.Text = $"{result}";
            }  
        }

        //ALLOWS TO ENTER ONLY NUMBERS AND IF A USER TRIES TO TYPE SOMETHING THAT IS NOT
        //NUMBER MAKE THE TEXTBOX EMPTY
        private void MyHeightInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(MyHeightInput.Text, "  ^ [0-9]"))
            {
                MyHeightInput.Text = "";
            }
        }
        
        private void MyWeightInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(MyWeightInput.Text, "  ^ [0-9]"))
            {
                MyWeightInput.Text = "";
            }
        }

        private void MyHeightInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void MyWeightInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
