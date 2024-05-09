namespace CalculatorApplication
{
    partial class CircleCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircleCalc));
            btn_mainmenu_cir = new Button();
            lbl_units = new Label();
            cb_units_cir = new ComboBox();
            lbl_base_tri = new Label();
            lbl_answer = new Label();
            tb_answer = new TextBox();
            btn_submit_cir = new Button();
            tb_radius = new TextBox();
            pb_circle = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_circle).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 109);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 29;
            label1.Text = "Area Calculator - Circle";
            // 
            // btn_mainmenu_cir
            // 
            btn_mainmenu_cir.Location = new Point(12, 12);
            btn_mainmenu_cir.Name = "btn_mainmenu_cir";
            btn_mainmenu_cir.Size = new Size(78, 23);
            btn_mainmenu_cir.TabIndex = 32;
            btn_mainmenu_cir.Text = "Main Menu";
            btn_mainmenu_cir.UseVisualStyleBackColor = true;
            btn_mainmenu_cir.Click += btn_mainmenu_cir_Click_1;
            // 
            // lbl_units
            // 
            lbl_units.AutoSize = true;
            lbl_units.Location = new Point(306, 156);
            lbl_units.Name = "lbl_units";
            lbl_units.Size = new Size(37, 15);
            lbl_units.TabIndex = 31;
            lbl_units.Text = "Units:";
            // 
            // cb_units_cir
            // 
            cb_units_cir.FormattingEnabled = true;
            cb_units_cir.Location = new Point(345, 152);
            cb_units_cir.Name = "cb_units_cir";
            cb_units_cir.Size = new Size(142, 23);
            cb_units_cir.TabIndex = 30;
            cb_units_cir.Text = "(Not Selected)";
            // 
            // lbl_base_tri
            // 
            lbl_base_tri.AutoSize = true;
            lbl_base_tri.Location = new Point(299, 205);
            lbl_base_tri.Name = "lbl_base_tri";
            lbl_base_tri.Size = new Size(42, 15);
            lbl_base_tri.TabIndex = 28;
            lbl_base_tri.Text = "Radius";
            // 
            // lbl_answer
            // 
            lbl_answer.AutoSize = true;
            lbl_answer.Location = new Point(292, 290);
            lbl_answer.Name = "lbl_answer";
            lbl_answer.Size = new Size(49, 15);
            lbl_answer.TabIndex = 26;
            lbl_answer.Text = "Answer:";
            // 
            // tb_answer
            // 
            tb_answer.Enabled = false;
            tb_answer.Location = new Point(343, 287);
            tb_answer.Name = "tb_answer";
            tb_answer.ReadOnly = true;
            tb_answer.Size = new Size(116, 23);
            tb_answer.TabIndex = 25;
            tb_answer.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_submit_cir
            // 
            btn_submit_cir.Location = new Point(343, 239);
            btn_submit_cir.Name = "btn_submit_cir";
            btn_submit_cir.Size = new Size(67, 23);
            btn_submit_cir.TabIndex = 24;
            btn_submit_cir.Text = "Submit";
            btn_submit_cir.UseVisualStyleBackColor = true;
            btn_submit_cir.Click += btn_submit_cir_Click_1;
            // 
            // tb_radius
            // 
            tb_radius.Location = new Point(343, 200);
            tb_radius.Name = "tb_radius";
            tb_radius.Size = new Size(67, 23);
            tb_radius.TabIndex = 22;
            tb_radius.TextAlign = HorizontalAlignment.Center;
            // 
            // pb_circle
            // 
            pb_circle.Image = (Image)resources.GetObject("pb_circle.Image");
            pb_circle.Location = new Point(76, 105);
            pb_circle.Name = "pb_circle";
            pb_circle.Size = new Size(200, 200);
            pb_circle.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_circle.TabIndex = 33;
            pb_circle.TabStop = false;
            // 
            // CircleCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pb_circle);
            Controls.Add(btn_mainmenu_cir);
            Controls.Add(lbl_units);
            Controls.Add(cb_units_cir);
            Controls.Add(label1);
            Controls.Add(lbl_base_tri);
            Controls.Add(lbl_answer);
            Controls.Add(tb_answer);
            Controls.Add(btn_submit_cir);
            Controls.Add(tb_radius);
            Name = "CircleCalc";
            Text = "Area Calculator - Circle";
            ((System.ComponentModel.ISupportInitialize)pb_circle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mainmenu_cir;
        private Label lbl_units;
        private ComboBox cb_units_cir;
        private Label lbl_base_tri;
        private Label lbl_answer;
        private TextBox tb_answer;
        private Button btn_submit_cir;
        private TextBox tb_radius;
        private PictureBox pb_circle;
    }
}