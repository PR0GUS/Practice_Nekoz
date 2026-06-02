using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, List<ConverterUnit>> data = new Dictionary<string, List<ConverterUnit>>();

        private void LoadData() // Виклич цей метод у Form1() після InitializeComponent
        {
            if (!File.Exists("units.txt")) return;
            foreach (string line in File.ReadAllLines("units.txt"))
            {
                var p = line.Split(';');
                if (p.Length < 3) continue;
                if (!data.ContainsKey(p[0]))
                {
                    data[p[0]] = new List<ConverterUnit>();
                    comboBox1.Items.Add(p[0]);
                }
                data[p[0]].Add(new ConverterUnit(p[1], double.Parse(p[2])));
            }
        }

        // Події для кнопок і списків (створи їх через дабл-клік у дизайнері)
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFrom.Items.Clear();
            comboBoxTo.Items.Clear();
            foreach (var u in data[comboBox1.SelectedItem.ToString()])
            {
                comboBoxFrom.Items.Add(u.Name);
                comboBoxTo.Items.Add(u.Name);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double val))
            {
                var from = data[comboBox1.SelectedItem.ToString()][comboBoxFrom.SelectedIndex];
                var to = data[comboBox1.SelectedItem.ToString()][comboBoxTo.SelectedIndex];
                labelResult.Text = ((val * from.Ratio) / to.Ratio).ToString();
            }
        }

        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            comboBoxFrom = new ComboBox();
            comboBoxTo = new ComboBox();
            textBoxInput = new TextBox();
            labelResult = new Label();
            buttonConvert = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(163, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Location = new Point(286, 119);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(121, 23);
            comboBoxFrom.TabIndex = 1;
            // 
            // comboBoxTo
            // 
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Location = new Point(286, 175);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(121, 23);
            comboBoxTo.TabIndex = 2;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(73, 119);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 3;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(73, 175);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(38, 15);
            labelResult.TabIndex = 4;
            labelResult.Text = "label1";
            // 
            // buttonConvert
            // 
            buttonConvert.Location = new Point(185, 237);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(75, 23);
            buttonConvert.TabIndex = 5;
            buttonConvert.Text = "button1";
            buttonConvert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(492, 351);
            Controls.Add(buttonConvert);
            Controls.Add(labelResult);
            Controls.Add(textBoxInput);
            Controls.Add(comboBoxTo);
            Controls.Add(comboBoxFrom);
            Controls.Add(comboBox1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }
        private ComboBox comboBox1;
        private ComboBox comboBoxFrom; private ComboBox comboBoxTo;
        private TextBox textBoxInput;
        private Label labelResult;
        private Button buttonConvert;