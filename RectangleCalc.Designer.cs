namespace CalculatorApplication
{
    partial class RectangleCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectangleCalc));
            btn_mainmenu_rec = new Button();
            tb_base = new TextBox();
            tb_height = new TextBox();
            btn_submit_rec = new Button();
            tb_answer = new TextBox();
            lbl_answer = new Label();
            lbl_height_rec = new Label();
            lbl_base_rec = new Label();
            label1 = new Label();
            cb_units_rec = new ComboBox();
            lbl_units = new Label();
            pb_rectangle = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_rectangle).BeginInit();
            SuspendLayout();
            // 
            // btn_mainmenu_rec
            // 
            btn_mainmenu_rec.Location = new Point(12, 12);
            btn_mainmenu_rec.Name = "btn_mainmenu_rec";
            btn_mainmenu_rec.Size = new Size(78, 23);
            btn_mainmenu_rec.TabIndex = 0;
            btn_mainmenu_rec.Text = "Main Menu";
            btn_mainmenu_rec.UseVisualStyleBackColor = true;
            btn_mainmenu_rec.Click += btn_mainmenu_rec_Click;
            // 
            // tb_base
            // 
            tb_base.Location = new Point(380, 205);
            tb_base.Name = "tb_base";
            tb_base.Size = new Size(67, 23);
            tb_base.TabIndex = 1;
            tb_base.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_height
            // 
            tb_height.Location = new Point(380, 234);
            tb_height.Name = "tb_height";
            tb_height.Size = new Size(67, 23);
            tb_height.TabIndex = 2;
            tb_height.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_submit_rec
            // 
            btn_submit_rec.Location = new Point(380, 274);
            btn_submit_rec.Name = "btn_submit_rec";
            btn_submit_rec.Size = new Size(67, 23);
            btn_submit_rec.TabIndex = 3;
            btn_submit_rec.Text = "Submit";
            btn_submit_rec.UseVisualStyleBackColor = true;
            btn_submit_rec.Click += btn_submit_rec_Click;
            // 
            // tb_answer
            // 
            tb_answer.Enabled = false;
            tb_answer.Location = new Point(380, 336);
            tb_answer.Name = "tb_answer";
            tb_answer.ReadOnly = true;
            tb_answer.Size = new Size(152, 23);
            tb_answer.TabIndex = 4;
            tb_answer.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_answer
            // 
            lbl_answer.AutoSize = true;
            lbl_answer.Location = new Point(329, 339);
            lbl_answer.Name = "lbl_answer";
            lbl_answer.Size = new Size(49, 15);
            lbl_answer.TabIndex = 5;
            lbl_answer.Text = "Answer:";
            // 
            // lbl_height_rec
            // 
            lbl_height_rec.AutoSize = true;
            lbl_height_rec.Location = new Point(333, 239);
            lbl_height_rec.Name = "lbl_height_rec";
            lbl_height_rec.Size = new Size(46, 15);
            lbl_height_rec.TabIndex = 6;
            lbl_height_rec.Text = "Height:";
            // 
            // lbl_base_rec
            // 
            lbl_base_rec.AutoSize = true;
            lbl_base_rec.Location = new Point(345, 210);
            lbl_base_rec.Name = "lbl_base_rec";
            lbl_base_rec.Size = new Size(34, 15);
            lbl_base_rec.TabIndex = 7;
            lbl_base_rec.Text = "Base:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 114);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 8;
            label1.Text = "Area Calculator - Rectangle";
            // 
            // cb_units_rec
            // 
            cb_units_rec.FormattingEnabled = true;
            cb_units_rec.Location = new Point(382, 157);
            cb_units_rec.Name = "cb_units_rec";
            cb_units_rec.Size = new Size(142, 23);
            cb_units_rec.TabIndex = 9;
            cb_units_rec.Text = "(Not Selected)";
            // 
            // lbl_units
            // 
            lbl_units.AutoSize = true;
            lbl_units.Location = new Point(343, 161);
            lbl_units.Name = "lbl_units";
            lbl_units.Size = new Size(37, 15);
            lbl_units.TabIndex = 10;
            lbl_units.Text = "Units:";
            // 
            // pb_rectangle
            // 
            pb_rectangle.Image = (Image)resources.GetObject("pb_rectangle.Image");
            pb_rectangle.Location = new Point(50, 114);
            pb_rectangle.Name = "pb_rectangle";
            pb_rectangle.Size = new Size(200, 200);
            pb_rectangle.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_rectangle.TabIndex = 11;
            pb_rectangle.TabStop = false;
            // 
            // RectangleCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pb_rectangle);
            Controls.Add(lbl_units);
            Controls.Add(cb_units_rec);
            Controls.Add(label1);
            Controls.Add(lbl_base_rec);
            Controls.Add(lbl_height_rec);
            Controls.Add(lbl_answer);
            Controls.Add(tb_answer);
            Controls.Add(btn_submit_rec);
            Controls.Add(tb_height);
            Controls.Add(tb_base);
            Controls.Add(btn_mainmenu_rec);
            Name = "RectangleCalc";
            Text = "Area Calculator - Rectangle";
            ((System.ComponentModel.ISupportInitialize)pb_rectangle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mainmenu_rec;
        private TextBox tb_base;
        private TextBox tb_height;
        private Button btn_submit_rec;
        private TextBox tb_answer;
        private Label lbl_answer;
        private Label lbl_height_rec;
        private Label lbl_base_rec;
        private Label label1;
        private ComboBox cb_units_rec;
        private Label lbl_units;
        private PictureBox pb_rectangle;
    }
}