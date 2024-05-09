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
    public partial class CuboidCalc : Form
    {
        private double baseInput;
        private double heightInput;
        private double depthInput;
        public string cbSelectedValue;

        public double BaseInput
        {
            get { return baseInput; }
            set { baseInput = value; }
        }

        public double HeightInput
        {
            get { return heightInput; }
            set { heightInput = value; }
        }

        public double DepthInput
        {
            get { return depthInput; }
            set { depthInput = value; }
        }

        public CuboidCalc()
        {
            InitializeComponent();

            cb_units_tri.Items.Add("m");
            cb_units_tri.Items.Add("cm");
            cb_units_tri.Items.Add("mm");
        }

        private void btn_mainmenu_cub_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void btn_submit_tri_Click(object sender, EventArgs e)
        {
            baseInput = double.Parse(tb_base.Text);
            heightInput = double.Parse(tb_height.Text);
            depthInput = double.Parse(tb_depth.Text);

            string powerOfThreeSymbol = "\u00B3";

            string answer = ((baseInput * HeightInput) * depthInput).ToString("0.00");

            // Displays output to the user in the answer box.
            tb_answer.Text = $"{answer}{cb_units_tri.Text}{powerOfThreeSymbol}";
        }
        }
    }
}
