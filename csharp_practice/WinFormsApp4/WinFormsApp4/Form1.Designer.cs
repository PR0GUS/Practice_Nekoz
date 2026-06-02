namespace lab4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();

      
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(210, 12);
            this.pictureBox1.Size = new System.Drawing.Size(560, 430);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);


            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Size = new System.Drawing.Size(180, 21);

   
            this.numericUpDown1.Location = new System.Drawing.Point(12, 45);
            this.numericUpDown1.Size = new System.Drawing.Size(180, 20);
            this.numericUpDown1.Value = 25;

       
            this.btnFillColor.Location = new System.Drawing.Point(12, 80);
            this.btnFillColor.Size = new System.Drawing.Size(180, 23);
            this.btnFillColor.Text = "Колір зафарбування";
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);

            this.btnLineColor.Location = new System.Drawing.Point(12, 110);
            this.btnLineColor.Size = new System.Drawing.Size(180, 23);
            this.btnLineColor.Text = "Колір границі";
            this.btnLineColor.Click += new System.EventHandler(this.btnLineColor_Click);

    
            this.btnDraw.Location = new System.Drawing.Point(12, 150);
            this.btnDraw.Size = new System.Drawing.Size(180, 40);
            this.btnDraw.Text = "ПОБУДУВАТИ";
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);


            this.listBox1.Location = new System.Drawing.Point(12, 210);
            this.listBox1.Size = new System.Drawing.Size(180, 160);


            this.btnDelete.Location = new System.Drawing.Point(12, 380);
            this.btnDelete.Size = new System.Drawing.Size(180, 23);
            this.btnDelete.Text = "Вилучити вибране";
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteSelected_Click);

            this.btnClear.Location = new System.Drawing.Point(12, 410);
            this.btnClear.Size = new System.Drawing.Size(180, 23);
            this.btnClear.Text = "Очистити все";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);


            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnFillColor);
            this.Controls.Add(this.btnLineColor);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Text = "Зірки";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}