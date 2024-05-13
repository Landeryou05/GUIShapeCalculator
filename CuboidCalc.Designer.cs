namespace CalculatorApplication
{
    partial class CuboidCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuboidCalc));
            btn_mainmenu_cub = new Button();
            lbl_units = new Label();
            cb_units_tri = new ComboBox();
            label1 = new Label();
            lbl_base_tri = new Label();
            lbl_height_cub = new Label();
            lbl_answer = new Label();
            tb_answer = new TextBox();
            btn_submit_tri = new Button();
            tb_height = new TextBox();
            tb_base = new TextBox();
            label2 = new Label();
            tb_depth = new TextBox();
            pb_cuboid = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_cuboid).BeginInit();
            SuspendLayout();
            // 
            // btn_mainmenu_cub
            // 
            btn_mainmenu_cub.Location = new Point(8, 8);
            btn_mainmenu_cub.Name = "btn_mainmenu_cub";
            btn_mainmenu_cub.Size = new Size(78, 23);
            btn_mainmenu_cub.TabIndex = 32;
            btn_mainmenu_cub.Text = "Main Menu";
            btn_mainmenu_cub.UseVisualStyleBackColor = true;
            btn_mainmenu_cub.Click += btn_mainmenu_cub_Click;
            // 
            // lbl_units
            // 
            lbl_units.AutoSize = true;
            lbl_units.Location = new Point(314, 144);
            lbl_units.Name = "lbl_units";
            lbl_units.Size = new Size(37, 15);
            lbl_units.TabIndex = 31;
            lbl_units.Text = "Units:";
            // 
            // cb_units_tri
            // 
            cb_units_tri.FormattingEnabled = true;
            cb_units_tri.Location = new Point(353, 142);
            cb_units_tri.Name = "cb_units_tri";
            cb_units_tri.Size = new Size(142, 23);
            cb_units_tri.TabIndex = 30;
            cb_units_tri.Text = "(Not Selected)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 98);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 29;
            label1.Text = "Volume Calculator - Cuboid";
            // 
            // lbl_base_tri
            // 
            lbl_base_tri.AutoSize = true;
            lbl_base_tri.Location = new Point(316, 190);
            lbl_base_tri.Name = "lbl_base_tri";
            lbl_base_tri.Size = new Size(34, 15);
            lbl_base_tri.TabIndex = 28;
            lbl_base_tri.Text = "Base:";
            // 
            // lbl_height_cub
            // 
            lbl_height_cub.AutoSize = true;
            lbl_height_cub.Location = new Point(303, 223);
            lbl_height_cub.Name = "lbl_height_cub";
            lbl_height_cub.Size = new Size(46, 15);
            lbl_height_cub.TabIndex = 27;
            lbl_height_cub.Text = "Height:";
            // 
            // lbl_answer
            // 
            lbl_answer.AutoSize = true;
            lbl_answer.Location = new Point(300, 324);
            lbl_answer.Name = "lbl_answer";
            lbl_answer.Size = new Size(49, 15);
            lbl_answer.TabIndex = 26;
            lbl_answer.Text = "Answer:";
            // 
            // tb_answer
            // 
            tb_answer.Enabled = false;
            tb_answer.Location = new Point(351, 320);
            tb_answer.Name = "tb_answer";
            tb_answer.ReadOnly = true;
            tb_answer.Size = new Size(163, 23);
            tb_answer.TabIndex = 25;
            tb_answer.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_submit_tri
            // 
            btn_submit_tri.Location = new Point(350, 277);
            btn_submit_tri.Name = "btn_submit_tri";
            btn_submit_tri.Size = new Size(67, 23);
            btn_submit_tri.TabIndex = 24;
            btn_submit_tri.Text = "Submit";
            btn_submit_tri.UseVisualStyleBackColor = true;
            btn_submit_tri.Click += btn_submit_tri_Click;
            // 
            // tb_height
            // 
            tb_height.Location = new Point(351, 218);
            tb_height.Name = "tb_height";
            tb_height.Size = new Size(67, 23);
            tb_height.TabIndex = 23;
            tb_height.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_base
            // 
            tb_base.Location = new Point(351, 190);
            tb_base.Name = "tb_base";
            tb_base.Size = new Size(67, 23);
            tb_base.TabIndex = 22;
            tb_base.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 252);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 34;
            label2.Text = "Depth:";
            // 
            // tb_depth
            // 
            tb_depth.Location = new Point(351, 247);
            tb_depth.Name = "tb_depth";
            tb_depth.Size = new Size(67, 23);
            tb_depth.TabIndex = 33;
            tb_depth.TextAlign = HorizontalAlignment.Center;
            // 
            // pb_cuboid
            // 
            pb_cuboid.Image = (Image)resources.GetObject("pb_cuboid.Image");
            pb_cuboid.Location = new Point(49, 139);
            pb_cuboid.Name = "pb_cuboid";
            pb_cuboid.Size = new Size(200, 200);
            pb_cuboid.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_cuboid.TabIndex = 35;
            pb_cuboid.TabStop = false;
            // 
            // CuboidCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pb_cuboid);
            Controls.Add(label2);
            Controls.Add(tb_depth);
            Controls.Add(btn_mainmenu_cub);
            Controls.Add(lbl_units);
            Controls.Add(cb_units_tri);
            Controls.Add(label1);
            Controls.Add(lbl_base_tri);
            Controls.Add(lbl_height_cub);
            Controls.Add(lbl_answer);
            Controls.Add(tb_answer);
            Controls.Add(btn_submit_tri);
            Controls.Add(tb_height);
            Controls.Add(tb_base);
            Margin = new Padding(2);
            Name = "CuboidCalc";
            Text = "Volume Calculator - Cuboid";
            ((System.ComponentModel.ISupportInitialize)pb_cuboid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mainmenu_cub;
        private Label lbl_units;
        private ComboBox cb_units_tri;
        private Label label1;
        private Label lbl_base_tri;
        private Label lbl_height_cub;
        private Label lbl_answer;
        private TextBox tb_answer;
        private Button btn_submit_tri;
        private TextBox tb_height;
        private TextBox tb_base;
        private Label label2;
        private TextBox tb_depth;
        private PictureBox pb_cuboid;
    }
}