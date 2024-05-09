using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class TriangularBasedPyCalc : Form
    {
        private double baseLengthInput;
        private double basePerpendicularHeightInput;
        private double perpendicularHeight;
        public string cbSelectedValue;

        public double BaseInput
        {
            get { return baseLengthInput; }
            set { baseLengthInput = value; }
        }

        public double BasePerpendicularHeightInput
        {
            get { return basePerpendicularHeightInput; }
            set { basePerpendicularHeightInput = value; }
        }

        public double PerpendicularHeight
        {
            get { return perpendicularHeight; }
            set { perpendicularHeight = value; }
        }

        public TriangularBasedPyCalc()
        {
            InitializeComponent();

            cb_units_tri.Items.Add("m");
            cb_units_tri.Items.Add("cm");
            cb_units_tri.Items.Add("mm");
        }

        private void btn_submit_tri_Click(object sender, EventArgs e)
        {
            baseLengthInput = double.Parse(tb_base.Text);
            basePerpendicularHeightInput = double.Parse(tb_height.Text);
            perpendicularHeight = double.Parse(tb_perpendicularhight.Text);

            string powerOfThreeSymbol = "\u00B3";

            string answer = ((((baseLengthInput * basePerpendicularHeightInput) / 2) * perpendicularHeight) / 3).ToString("0.00");

            // Displays output to the user in the answer box.
            tb_answer.Text = $"{answer}{cb_units_tri.Text}{powerOfThreeSymbol}";
        }

        private void btn_mainmenu_tripy_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }
    }
}
