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
    public partial class SquareBasedPyCalc : Form
    {
        private double baseEdgeInput;
        private double perpendicularHeightInput;
        public string cbSelectedValue;

        public double BaseInput
        {
            get { return baseEdgeInput; }
            set { baseEdgeInput = value; }
        }

        public double PerpendicularHeightInput
        {
            get { return perpendicularHeightInput; }
            set { perpendicularHeightInput = value; }
        }

        public SquareBasedPyCalc()
        {
            InitializeComponent();

            cb_units_tri.Items.Add("m");
            cb_units_tri.Items.Add("cm");
            cb_units_tri.Items.Add("mm");
        }

        private void btn_mainmenu_sqpy_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void btn_submit_tri_Click(object sender, EventArgs e)
        {
            baseEdgeInput = double.Parse(tb_base.Text);
            perpendicularHeightInput = double.Parse(tb_height.Text);

            string powerOfThreeSymbol = "\u00B3";

            _3DShape _3DShapeCalculation = new _3DShape();
            string answer = _3DShapeCalculation.sqrBasedPy(baseEdgeInput, perpendicularHeightInput);

            cbSelectedValue = cb_units_tri.Text;

            if (cb_units_tri.Text != "(Not Selected)")
            {
                // Displays output to the user in the answer box.
                tb_answer.Text = $"{answer}{cb_units_tri.Text}{powerOfThreeSymbol}";
            }
            else
            {
                tb_answer.Text = "ERROR: Please Select Unit";
            }
        }
    }
}
