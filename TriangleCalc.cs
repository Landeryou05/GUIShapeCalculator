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
    public partial class TriangleCalc : Form
    {
        // As we are calculating different shape's areas, we need different
        // inputs from the user.
        private double baseInput;
        private double perpendicularHeightInput;
        public string cbSelectedValue;

        public double BaseInput
        {
            get { return baseInput; }
            set { baseInput = value; }
        }

        public double PerpendicularHeightInput
        {
            get { return perpendicularHeightInput; }
            set { perpendicularHeightInput = value; }
        }

        public TriangleCalc()
        {
            InitializeComponent();

            cb_units_tri.Items.Add("m");
            cb_units_tri.Items.Add("cm");
            cb_units_tri.Items.Add("mm");
        }

        private void btn_mainmenu_tri_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void btn_submit_tri_Click(object sender, EventArgs e)
        {
            baseInput = double.Parse(tb_base.Text);
            perpendicularHeightInput = double.Parse(tb_height.Text);

            // The equation for the calculation is different as it is for a triangle
            _2DShape _2DShapeCalculation = new _2DShape();
            string answer = _2DShapeCalculation.traingleCalculation(baseInput, perpendicularHeightInput);

            string squaredSymbol = "\u00B2";

            if (cb_units_tri.Text != "(Not Selected)")
            {
                // Displays output to the user in the answer box.
                tb_answer.Text = $"{answer}{cb_units_tri.Text}{squaredSymbol}";
            }
            else
            {
                tb_answer.Text = "ERROR: Please Select Unit";
            }
        }
    }
}
