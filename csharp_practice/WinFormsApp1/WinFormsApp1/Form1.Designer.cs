namespace ConverterApp
{
    partial class Form1
    {
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;

        private void InitializeComponent()
        {
            this.comboBox1 = new ComboBox();
            this.comboBox2 = new ComboBox();
            this.comboBox3 = new ComboBox();
            this.textBox1 = new TextBox();
            this.button1 = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.SuspendLayout();

            this.Text = "Unit Converter";
            this.ClientSize = new System.Drawing.Size(450, 380);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.label1.Text = "Category:";
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Size = new System.Drawing.Size(80, 25);

            this.comboBox1.Location = new System.Drawing.Point(120, 28);
            this.comboBox1.Size = new System.Drawing.Size(300, 28);
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);

            this.label2.Text = "From:";
            this.label2.Location = new System.Drawing.Point(30, 80);

            this.comboBox2.Location = new System.Drawing.Point(120, 78);
            this.comboBox2.Size = new System.Drawing.Size(300, 28);
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            this.label3.Text = "To:";
            this.label3.Location = new System.Drawing.Point(30, 120);

            this.comboBox3.Location = new System.Drawing.Point(120, 118);
            this.comboBox3.Size = new System.Drawing.Size(300, 28);
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

            this.label4.Text = "Value:";
            this.label4.Location = new System.Drawing.Point(30, 170);

            this.textBox1.Location = new System.Drawing.Point(120, 168);
            this.textBox1.Size = new System.Drawing.Size(300, 26);
            this.textBox1.Text = "0";
            this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);

            this.button1.Text = "CONVERT";
            this.button1.Location = new System.Drawing.Point(120, 220);
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Click += new EventHandler(this.button1_Click);

            this.label5.Text = "0";
            this.label5.Location = new System.Drawing.Point(120, 290);
            this.label5.Size = new System.Drawing.Size(300, 40);
            this.label5.Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
            this.label5.BorderStyle = BorderStyle.FixedSingle;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.BackColor = System.Drawing.Color.White;

            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);

            this.ResumeLayout(false);
        }
    }
}