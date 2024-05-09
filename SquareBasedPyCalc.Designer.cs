namespace CalculatorApplication
{
    partial class SquareBasedPyCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SquareBasedPyCalc));
            btn_mainmenu_sqpy = new Button();
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
            pb_squarebasedpy = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_squarebasedpy).BeginInit();
            SuspendLayout();
            // 
            // btn_mainmenu_sqpy
            // 
            btn_mainmenu_sqpy.Location = new Point(12, 12);
            btn_mainmenu_sqpy.Name = "btn_mainmenu_sqpy";
            btn_mainmenu_sqpy.Size = new Size(78, 23);
            btn_mainmenu_sqpy.TabIndex = 45;
            btn_mainmenu_sqpy.Text = "Main Menu";
            btn_mainmenu_sqpy.UseVisualStyleBackColor = true;
            btn_mainmenu_sqpy.Click += btn_mainmenu_sqpy_Click;
            // 
            // lbl_units
            // 
            lbl_units.AutoSize = true;
            lbl_units.Location = new Point(318, 150);
            lbl_units.Name = "lbl_units";
            lbl_units.Size = new Size(37, 15);
            lbl_units.TabIndex = 44;
            lbl_units.Text = "Units:";
            // 
            // cb_units_tri
            // 
            cb_units_tri.FormattingEnabled = true;
            cb_units_tri.Location = new Point(357, 146);
            cb_units_tri.Name = "cb_units_tri";
            cb_units_tri.Size = new Size(142, 23);
            cb_units_tri.TabIndex = 43;
            cb_units_tri.Text = "(Not Selected)";
            // 
            // lbl_title_sqpy
            // 
            lbl_title_sqpy.AutoSize = true;
            lbl_title_sqpy.Location = new Point(273, 102);
            lbl_title_sqpy.Name = "lbl_title_sqpy";
            lbl_title_sqpy.Size = new Size(234, 15);
            lbl_title_sqpy.TabIndex = 42;
            lbl_title_sqpy.Text = "Volume Calculator - Square-Based Pyramid";
            // 
            // lbl_base_tri
            // 
            lbl_base_tri.AutoSize = true;
            lbl_base_tri.Location = new Point(292, 198);
            lbl_base_tri.Name = "lbl_base_tri";
            lbl_base_tri.Size = new Size(63, 15);
            lbl_base_tri.TabIndex = 41;
            lbl_base_tri.Text = "Base Edge:";
            // 
            // lbl_height_cub
            // 
            lbl_height_cub.AutoSize = true;
            lbl_height_cub.Location = new Point(232, 226);
            lbl_height_cub.Name = "lbl_height_cub";
            lbl_height_cub.Size = new Size(122, 15);
            lbl_height_cub.TabIndex = 40;
            lbl_height_cub.Text = "Perpendicular Height:";
            // 
            // lbl_answer
            // 
            lbl_answer.AutoSize = true;
            lbl_answer.Location = new Point(304, 294);
            lbl_answer.Name = "lbl_answer";
            lbl_answer.Size = new Size(49, 15);
            lbl_answer.TabIndex = 39;
            lbl_answer.Text = "Answer:";
            // 
            // tb_answer
            // 
            tb_answer.Enabled = false;
            tb_answer.Location = new Point(355, 290);
            tb_answer.Name = "tb_answer";
            tb_answer.ReadOnly = true;
            tb_answer.Size = new Size(97, 23);
            tb_answer.TabIndex = 38;
            tb_answer.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_submit_tri
            // 
            btn_submit_tri.Location = new Point(354, 257);
            btn_submit_tri.Name = "btn_submit_tri";
            btn_submit_tri.Size = new Size(67, 23);
            btn_submit_tri.TabIndex = 37;
            btn_submit_tri.Text = "Submit";
            btn_submit_tri.UseVisualStyleBackColor = true;
            btn_submit_tri.Click += btn_submit_tri_Click;
            // 
            // tb_height
            // 
            tb_height.Location = new Point(355, 222);
            tb_height.Name = "tb_height";
            tb_height.Size = new Size(67, 23);
            tb_height.TabIndex = 36;
            tb_height.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_base
            // 
            tb_base.Location = new Point(355, 194);
            tb_base.Name = "tb_base";
            tb_base.Size = new Size(67, 23);
            tb_base.TabIndex = 35;
            tb_base.TextAlign = HorizontalAlignment.Center;
            // 
            // pb_squarebasedpy
            // 
            pb_squarebasedpy.Image = (Image)resources.GetObject("pb_squarebasedpy.Image");
            pb_squarebasedpy.Location = new Point(26, 113);
            pb_squarebasedpy.Name = "pb_squarebasedpy";
            pb_squarebasedpy.Size = new Size(200, 200);
            pb_squarebasedpy.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_squarebasedpy.TabIndex = 46;
            pb_squarebasedpy.TabStop = false;
            // 
            // SquareBasedPyCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pb_squarebasedpy);
            Controls.Add(btn_mainmenu_sqpy);
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
            Name = "SquareBasedPyCalc";
            Text = "Volume Calculator - Square-Based Pyramid";
            ((System.ComponentModel.ISupportInitialize)pb_squarebasedpy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_mainmenu_sqpy;
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
        private PictureBox pb_squarebasedpy;
    }
}