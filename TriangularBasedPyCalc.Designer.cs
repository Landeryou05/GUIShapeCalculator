namespace CalculatorApplication
{
    partial class TriangularBasedPyCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangularBasedPyCalc));
            btn_mainmenu_tripy = new Button();
            lbl_units = new Label();
            cb_units_tri = new ComboBox();
            lbl_title_sqpy = new Label();
            lbl_base_tri = new Label();
            lbl_height_cub = new Label();
            lbl_answer = new Label();
            tb_answer = new TextBox();
            btn_submit_tri = new Button();
            tb_height = new TextBox();
            tb_base = new TextBox();
            label1 = new Label();
            tb_perpendicularhight = new TextBox();
            pb_triangularbasedpy = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_triangularbasedpy).BeginInit();
            SuspendLayout();
            // 
            // btn_mainmenu_tripy
            // 
            btn_mainmenu_tripy.Location = new Point(12, 12);
            btn_mainmenu_tripy.Name = "btn_mainmenu_tripy";
            btn_mainmenu_tripy.Size = new Size(78, 23);
            btn_mainmenu_tripy.TabIndex = 56;
            btn_mainmenu_tripy.Text = "Main Menu";
            btn_mainmenu_tripy.UseVisualStyleBackColor = true;
            btn_mainmenu_tripy.Click += btn_mainmenu_tripy_Click_1;
            // 
            // lbl_units
            // 
            lbl_units.AutoSize = true;
            lbl_units.Location = new Point(373, 150);
            lbl_units.Name = "lbl_units";
            lbl_units.Size = new Size(37, 15);
            lbl_units.TabIndex = 55;
            lbl_units.Text = "Units:";
            // 
            // cb_units_tri
            // 
            cb_units_tri.FormattingEnabled = true;
            cb_units_tri.Location = new Point(412, 146);
            cb_units_tri.Name = "cb_units_tri";
            cb_units_tri.Size = new Size(142, 23);
            cb_units_tri.TabIndex = 54;
            cb_units_tri.Text = "(Not Selected)";
            // 
            // lbl_title_sqpy
            // 
            lbl_title_sqpy.AutoSize = true;
            lbl_title_sqpy.Location = new Point(328, 102);
            lbl_title_sqpy.Name = "lbl_title_sqpy";
            lbl_title_sqpy.Size = new Size(250, 15);
            lbl_title_sqpy.TabIndex = 53;
            lbl_title_sqpy.Text = "Volume Calculator - Triangular-Based Pyramid";
            // 
            // lbl_base_tri
            // 
            lbl_base_tri.AutoSize = true;
            lbl_base_tri.Location = new Point(334, 185);
            lbl_base_tri.Name = "lbl_base_tri";
            lbl_base_tri.Size = new Size(74, 15);
            lbl_base_tri.TabIndex = 52;
            lbl_base_tri.Text = "Base Length:";
            // 
            // lbl_height_cub
            // 
            lbl_height_cub.AutoSize = true;
            lbl_height_cub.Location = new Point(259, 213);
            lbl_height_cub.Name = "lbl_height_cub";
            lbl_height_cub.Size = new Size(149, 15);
            lbl_height_cub.TabIndex = 51;
            lbl_height_cub.Text = "Base Perpendicular Height:";
            // 
            // lbl_answer
            // 
            lbl_answer.AutoSize = true;
            lbl_answer.Location = new Point(359, 313);
            lbl_answer.Name = "lbl_answer";
            lbl_answer.Size = new Size(49, 15);
            lbl_answer.TabIndex = 50;
            lbl_answer.Text = "Answer:";
            // 
            // tb_answer
            // 
            tb_answer.Enabled = false;
            tb_answer.Location = new Point(410, 309);
            tb_answer.Name = "tb_answer";
            tb_answer.ReadOnly = true;
            tb_answer.Size = new Size(144, 23);
            tb_answer.TabIndex = 49;
            tb_answer.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_submit_tri
            // 
            btn_submit_tri.Location = new Point(409, 276);
            btn_submit_tri.Name = "btn_submit_tri";
            btn_submit_tri.Size = new Size(67, 23);
            btn_submit_tri.TabIndex = 48;
            btn_submit_tri.Text = "Submit";
            btn_submit_tri.UseVisualStyleBackColor = true;
            btn_submit_tri.Click += btn_submit_tri_Click;
            // 
            // tb_height
            // 
            tb_height.Location = new Point(410, 209);
            tb_height.Name = "tb_height";
            tb_height.Size = new Size(67, 23);
            tb_height.TabIndex = 47;
            tb_height.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_base
            // 
            tb_base.Location = new Point(410, 181);
            tb_base.Name = "tb_base";
            tb_base.Size = new Size(67, 23);
            tb_base.TabIndex = 46;
            tb_base.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 242);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 58;
            label1.Text = "Perpendicular Height:";
            // 
            // tb_perpendicularhight
            // 
            tb_perpendicularhight.Location = new Point(410, 238);
            tb_perpendicularhight.Name = "tb_perpendicularhight";
            tb_perpendicularhight.Size = new Size(67, 23);
            tb_perpendicularhight.TabIndex = 57;
            tb_perpendicularhight.TextAlign = HorizontalAlignment.Center;
            // 
            // pb_triangularbasedpy
            // 
            pb_triangularbasedpy.Image = (Image)resources.GetObject("pb_triangularbasedpy.Image");
            pb_triangularbasedpy.Location = new Point(42, 114);
            pb_triangularbasedpy.Name = "pb_triangularbasedpy";
            pb_triangularbasedpy.Size = new Size(200, 200);
            pb_triangularbasedpy.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_triangularbasedpy.TabIndex = 59;
            pb_triangularbasedpy.TabStop = false;
            // 
            // TriangularBasedPyCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pb_triangularbasedpy);
            Controls.Add(label1);
            Controls.Add(tb_perpendicularhight);
            Controls.Add(btn_mainmenu_tripy);
            Controls.Add(lbl_units);
            Controls.Add(cb_units_tri);
            Controls.Add(lbl_title_sqpy);
            Controls.Add(lbl_base_tri);
            Controls.Add(lbl_height_cub);
            Controls.Add(lbl_answer);
            Controls.Add(tb_answer);
            Controls.Add(btn_submit_tri);
            Controls.Add(tb_height);
            Controls.Add(tb_base);
            Margin = new Padding(2);
            Name = "TriangularBasedPyCalc";
            Text = "Volume Calculator - Triangular-Based Pyramid";
            ((System.ComponentModel.ISupportInitialize)pb_triangularbasedpy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mainmenu_tripy;
        private Label lbl_units;
        private ComboBox cb_units_tri;
        private Label lbl_title_sqpy;
        private Label lbl_base_tri;
        private Label lbl_height_cub;
        private Label lbl_answer;
        private TextBox tb_answer;
        private Button btn_submit_tri;
        private TextBox tb_height;
        private TextBox tb_base;
        private Label label1;
        private TextBox tb_perpendicularhight;
        private PictureBox pb_triangularbasedpy;
    }
}