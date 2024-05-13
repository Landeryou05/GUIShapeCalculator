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
    public partial class CircleCalc : Form
    {
        private double radiusInput;
        public string cbSelectedValue;

        public double RadiusInput
        {
            get { return radiusInput; }
            set { radiusInput = value; }
        }

        public CircleCalc()
        {
            InitializeComponent();

            cb_units_cir.Items.Add("m");
            cb_units_cir.Items.Add("cm");
            cb_units_cir.Items.Add("mm");
        }

        private void btn_submit_cir_Click_1(object sender, EventArgs e)
        {
            radiusInput = double.Parse(tb_radius.Text);

            _2DShape _2DShapeCalculation = new _2DShape();
            string answer = _2DShapeCalculation.circleCalculation(radiusInput);

            string squaredSymbol = "\u00B2";

            if (cb_units_cir.Text != "(Not Selected)")
            {
                // Displays output to the user in the answer box.
                tb_answer.Text = $"{answer}{cb_units_cir.Text}{squaredSymbol}";
            }
            else
            {
                tb_answer.Text = "ERROR: Please Select Unit";
            }
        }

        private void btn_mainmenu_cir_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }
    }
}
