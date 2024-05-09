using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    /// <summary>
    ///     This class handles the rectangle calculator's logic and event handlers.
    /// </summary>
    public partial class RectangleCalc : Form
    {
        // This is where the variables are declared.
        // They are set by getters and setters directly below.
        private double baseInput;
        private double heightInput;
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

        /// <summary>
        ///     This class handles events and items in the Rectangle Calculator that need
        ///     to be instanced when the event is called. For example, the items within the
        ///     combo box need to be there when the new form is called.
        /// </summary>
        public RectangleCalc()
        {
            InitializeComponent();

            cb_units_rec.Items.Add("m");
            cb_units_rec.Items.Add("cm");
            cb_units_rec.Items.Add("mm");
        }

        /// <summary>
        ///     This controls what happens when the submit button is clicked.
        ///     I.E. The answer is calculated and then is displayed in the answer
        ///     box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_submit_rec_Click(object sender, EventArgs e)
        {
            // Storing the user inputs from the entry box within the relavent variables.
            baseInput = double.Parse(tb_base.Text);
            heightInput = double.Parse(tb_height.Text);

            // Declaring new variables to give the formula for the answer and also its format.
            string answer = (baseInput * heightInput).ToString("0.00");
            string squaredSymbol = "\u00B2";

            // Displays output to the user in the answer box.
            tb_answer.Text = $"{answer}{cb_units_rec.Text}{squaredSymbol}";
        }

        /// <summary>
        ///     This instances Form1, which is the main menu for the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mainmenu_rec_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }
    }
}
