using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_12_13_GUI_Assignment_2
{
    public partial class FormUnitConverstion : Form
    {
        string heightFromUnit;
        double heightInput, heightOutput;

        public FormUnitConverstion()
        {
            InitializeComponent();
        }

        private void radFromHH_CheckedChanged(object sender, EventArgs e)
        {
            heightFromUnit = "hh";
            lblHeightFrom.Text = heightFromUnit;
        }

        private void radFromFeet_CheckedChanged(object sender, EventArgs e)
        {
            heightFromUnit = "ft";
            lblHeightFrom.Text = heightFromUnit;
        }

        private void radFromInches_CheckedChanged(object sender, EventArgs e)
        {
            heightFromUnit = "in";
            lblHeightFrom.Text = heightFromUnit;
        }

        private void radFromCM_CheckedChanged(object sender, EventArgs e)
        {
            heightFromUnit = "cm";
            lblHeightFrom.Text = heightFromUnit;
        }

        private void radfromMeters_CheckedChanged(object sender, EventArgs e)
        {
            heightFromUnit = "m";
            lblHeightFrom.Text = heightFromUnit;
        }

        private void radToHH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormUnitConverstion_Load(object sender, EventArgs e)
        {
            radFromHH.Checked = true;
            radToHH.Checked = true;
            this.BackgroundImage = Properties.Resources.Barn;
        }

        private void radToFeet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            heightInput = Convert.ToDouble(txtHeightInput.Text);

            // To HH
            if (heightFromUnit == "hh" && radToHH.Checked)
            {
                heightOutput = heightInput;
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " hh";
            }
            else if (heightFromUnit == "ft" && radToHH.Checked)
            {
                heightOutput = (heightInput * 3);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " hh";
            }
            else if (heightFromUnit == "in" && radToHH.Checked)
            {
                heightOutput = (heightInput / 4);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " hh";
            }
            else if (heightFromUnit == "cm" && radToHH.Checked)
            {
                heightOutput = (heightInput / 10.2);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " hh";
            }
            else if (heightFromUnit == "m" && radToHH.Checked)
            {
                heightOutput = (heightInput * 9.842519685);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " hh";
            }
            // To feet
            else if (heightFromUnit == "hh" && radToFeet.Checked)
            {
                heightOutput = (heightInput / 3);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " ft";
            }
            else if (heightFromUnit == "ft" && radToFeet.Checked)
            {
                heightOutput = (heightInput);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " ft";
            }
            else if (heightFromUnit == "in" && radToFeet.Checked)
            {
                heightOutput = (heightInput / 12);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " ft";
            }
            else if (heightFromUnit == "cm" && radToFeet.Checked)
            {
                heightOutput = (heightInput * 0.0328084);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " ft";
            }
            else if (heightFromUnit == "m" && radToFeet.Checked)
            {
                heightOutput = (heightInput * 3.2808399);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " ft";
            }
            // To inches
            else if (heightFromUnit == "hh" && radToInches.Checked)
            {
                heightOutput = (heightInput * 4);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " in";
            }
            else if (heightFromUnit == "ft" && radToInches.Checked)
            {
                heightOutput = (heightInput * 12);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " in";
            }
            else if (heightFromUnit == "in" && radToInches.Checked)
            {
                heightOutput = (heightInput);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " in";
            }
            else if (heightFromUnit == "cm" && radToInches.Checked)
            {
                heightOutput = (heightInput * 0.39370079);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " in";
            }
            else if (heightFromUnit == "m" && radToInches.Checked)
            {
                heightOutput = (heightInput * 39.3700787);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " in";
            }
            // To CM
            else if (heightFromUnit == "hh" && radToCM.Checked)
            {
                heightOutput = (heightInput * 10.2);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " cm";
            }
            else if (heightFromUnit == "ft" && radToCM.Checked)
            {
                heightOutput = (heightInput / 0.0328084);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " cm";
            }
            else if (heightFromUnit == "in" && radToCM.Checked)
            {
                heightOutput = (heightInput / 0.39370079);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " cm";
            }
            else if (heightFromUnit == "cm" && radToCM.Checked)
            {
                heightOutput = (heightInput);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " cm";
            }
            else if (heightFromUnit == "m" && radToCM.Checked)
            {
                heightOutput = (heightInput / 100);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " cm";
            }
            //To meters
            else if (heightFromUnit == "hh" && radToMeters.Checked)
            {
                heightOutput = (heightInput / 9.842519685);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " m";
            }
            else if (heightFromUnit == "ft" && radToMeters.Checked)
            {
                heightOutput = (heightInput / 3.2808399);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " m";
            }
            else if (heightFromUnit == "in" && radToMeters.Checked)
            {
                heightOutput = (heightInput / 39.3700787);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " m";
            }
            else if (heightFromUnit == "cm" && radToMeters.Checked)
            {
                heightOutput = (heightInput * 100);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " m";
            }
            else if (heightFromUnit == "m" && radToMeters.Checked)
            {
                heightOutput = (heightInput);
                lblHeightTo.Text = "= " + Math.Round(heightOutput, 2) + " m";
            }
        }

        private void lblHeightFrom_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
