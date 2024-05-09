namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     When each button is clicked on the form, an event handler instances
        ///     the relavent class. For example, when the rectangle calculator is clicked,
        ///     the rectangle calculator is launched.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_rec_Click(object sender, EventArgs e)
        {
            // This is the event handler that instances the 'RectangleCalc' class
            this.Hide();

            RectangleCalc rectangleCalculator = new RectangleCalc();
            rectangleCalculator.Show();
        }

        private void btn_tri_Click(object sender, EventArgs e)
        {
            // This is the event handler that instances the 'TriangleCalc' class
            this.Hide();

            TriangleCalc triangleCalculator = new TriangleCalc();
            triangleCalculator.Show();
        }

        private void btn_cir_Click(object sender, EventArgs e)
        {
            // This is the event handler that instances the 'CircleCalc' class
            this.Hide();

            CircleCalc circleCalculator = new CircleCalc();
            circleCalculator.Show();
        }

        private void btn_cub_Click(object sender, EventArgs e)
        {
            // This is the event handler that instances the 'CuboidCalc' class
            this.Hide();

            CuboidCalc cuboidCalculator = new CuboidCalc();
            cuboidCalculator.Show();
        }

        private void btn_sqrpyr_Click(object sender, EventArgs e)
        {
            // This is the event handler that instances the 'SquareBasedPyCalc' class
            this.Hide();

            SquareBasedPyCalc squareBasedPyCalculator = new SquareBasedPyCalc();
            squareBasedPyCalculator.Show();
        }

        private void btn_tripyr_Click(object sender, EventArgs e)
        {
            // This is the event handler that instances the 'TriangularBasedPyCalc' class
            this.Hide();

            TriangularBasedPyCalc triangleBasedPyCalculator = new TriangularBasedPyCalc();
            triangleBasedPyCalculator.Show();
        }
    }
}
