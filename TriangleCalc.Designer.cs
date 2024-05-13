namespace CalculatorApplication
{
    partial class TriangleCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleCalc));
            lbl_units = new Label();
            cb_units_tri = new ComboBox();
            label1 = new Label();
            lbl_base_tri = new Label();
            lbl_height_tri = new Label();
            lbl_answer = new Label();
            tb_answer = new TextBox();
            btn_submit_tri = new Button();
            tb_height = new TextBox();
            tb_base = new TextBox();
            btn_mainmenu_tri = new Button();
            pb_triangle = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_triangle).BeginInit();
            SuspendLayout();
            // 
            // lbl_units
            // 
            lbl_units.AutoSize = true;
            lbl_units.Location = new Point(318, 148);
            lbl_units.Name = "lbl_units";
            lbl_units.Size = new Size(37, 15);
            lbl_units.TabIndex = 20;
            lbl_units.Text = "Units:";
            // 
            // cb_units_tri
            // 
            cb_units_tri.FormattingEnabled = true;
            cb_units_tri.Location = new Point(357, 146);
            cb_units_tri.Name = "cb_units_tri";
            cb_units_tri.Size = new Size(142, 23);
            cb_units_tri.TabIndex = 19;
            cb_units_tri.Text = "(Not Selected)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 103);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 18;
            label1.Text = "Area Calculator - Triangle";
            // 
            // lbl_base_tri
            // 
            lbl_base_tri.AutoSize = true;
            lbl_base_tri.Location = new Point(320, 195);
            lbl_base_tri.Name = "lbl_base_tri";
            lbl_base_tri.Size = new Size(34, 15);
            lbl_base_tri.TabIndex = 17;
            lbl_base_tri.Text = "Base:";
            // 
            // lbl_height_tri
            // 
            lbl_height_tri.AutoSize = true;
            lbl_height_tri.Location = new Point(231, 224);
            lbl_height_tri.Name = "lbl_height_tri";
            lbl_height_tri.Size = new Size(122, 15);
            lbl_height_tri.TabIndex = 16;
            lbl_height_tri.Text = "Perpendicular Height:";
            // 
            // lbl_answer
            // 
            lbl_answer.AutoSize = true;
            lbl_answer.Location = new Point(304, 328);
            lbl_answer.Name = "lbl_answer";
            lbl_answer.Size = new Size(49, 15);
            lbl_answer.TabIndex = 15;
            lbl_answer.Text = "Answer:";
            // 
            // tb_answer
            // 
            tb_answer.Enabled = false;
            tb_answer.Location = new Point(355, 325);
            tb_answer.Name = "tb_answer";
            tb_answer.ReadOnly = true;
            tb_answer.Size = new Size(158, 23);
            tb_answer.TabIndex = 14;
            tb_answer.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_submit_tri
            // 
            btn_submit_tri.Location = new Point(355, 263);
            btn_submit_tri.Name = "btn_submit_tri";
            btn_submit_tri.Size = new Size(67, 23);
            btn_submit_tri.TabIndex = 13;
            btn_submit_tri.Text = "Submit";
            btn_submit_tri.UseVisualStyleBackColor = true;
            btn_submit_tri.Click += btn_submit_tri_Click;
            // 
            // tb_height
            // 
            tb_height.Location = new Point(355, 223);
            tb_height.Name = "tb_height";
            tb_height.Size = new Size(67, 23);
            tb_height.TabIndex = 12;
            tb_height.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_base
            // 
            tb_base.Location = new Point(355, 194);
            tb_base.Name = "tb_base";
            tb_base.Size = new Size(67, 23);
            tb_base.TabIndex = 11;
            tb_base.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_mainmenu_tri
            // 
            btn_mainmenu_tri.Location = new Point(12, 12);
            btn_mainmenu_tri.Name = "btn_mainmenu_tri";
            btn_mainmenu_tri.Size = new Size(78, 23);
            btn_mainmenu_tri.TabIndex = 21;
            btn_mainmenu_tri.Text = "Main Menu";
            btn_mainmenu_tri.UseVisualStyleBackColor = true;
            btn_mainmenu_tri.Click += btn_mainmenu_tri_Click;
            // 
            // pb_triangle
            // 
            pb_triangle.Image = (Image)resources.GetObject("pb_triangle.Image");
            pb_triangle.Location = new Point(25, 115);
            pb_triangle.Name = "pb_triangle";
            pb_triangle.Size = new Size(200, 200);
            pb_triangle.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_triangle.TabIndex = 22;
            pb_triangle.TabStop = false;
            // 
            // TriangleCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pb_triangle);
            Controls.Add(btn_mainmenu_tri);
            Controls.Add(lbl_units);
            Controls.Add(cb_units_tri);
            Controls.Add(label1);
            Controls.Add(lbl_base_tri);
            Controls.Add(lbl_height_tri);
            Controls.Add(lbl_answer);
            Controls.Add(tb_answer);
            Controls.Add(btn_submit_tri);
            Controls.Add(tb_height);
            Controls.Add(tb_base);
            Name = "TriangleCalc";
            Text = "Area Calculator - Triangle";
            ((System.ComponentModel.ISupportInitialize)pb_triangle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_units;
        private ComboBox cb_units_tri;
        private Label label1;
        private Label lbl_base_tri;
        private Label lbl_height_tri;
        private Label lbl_answer;
        private TextBox tb_answer;
        private Button btn_submit_tri;
        private TextBox tb_height;
        private TextBox tb_base;
        private Button btn_mainmenu_tri;
        private PictureBox pb_triangle;
    }
}