using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<ConverterUnit>> data = new Dictionary<string, List<ConverterUnit>>();

        public Form1()
        {
            InitializeComponent();
            LoadDataFromFile();
        }

        private void LoadDataFromFile()
        {
            string filePath = "units.txt";
            if (!File.Exists(filePath)) return;


            foreach (string line in File.ReadAllLines("units.txt", System.Text.Encoding.UTF8))
            {
                var p = line.Split(';');
                if (p.Length < 3) continue;

                string category = p[0];
                string name = p[1];


                if (double.TryParse(p[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double ratio))
                {
                    if (!data.ContainsKey(category))
                    {
                        data[category] = new List<ConverterUnit>();
                        comboBox1.Items.Add(category);
                    }
                    data[category].Add(new ConverterUnit(name, ratio));
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            comboBoxFrom.Items.Clear();
            comboBoxTo.Items.Clear();

            foreach (var unit in data[comboBox1.SelectedItem.ToString()])
            {
                comboBoxFrom.Items.Add(unit.Name);
                comboBoxTo.Items.Add(unit.Name);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {

            string input = textBoxInput.Text.Replace(',', '.');

            if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
            {
                if (comboBox1.SelectedIndex == -1 || comboBoxFrom.SelectedIndex == -1 || comboBoxTo.SelectedIndex == -1) return;

                var list = data[comboBox1.SelectedItem.ToString()];
                var fromUnit = list[comboBoxFrom.SelectedIndex];
                var toUnit = list[comboBoxTo.SelectedIndex];

                double result = (val * fromUnit.Ratio) / toUnit.Ratio;
                labelResult.Text = result.ToString("G10");
            }
            else
            {
                MessageBox.Show("Введіть коректне число!");
            }
        }
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Button buttonConvert;
        private Label labelResult;
        private System.Windows.Forms.TextBox textBoxInput;

        private void InitializeComponent()
        {
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBoxFrom = new System.Windows.Forms.ComboBox();
            comboBoxTo = new System.Windows.Forms.ComboBox();
            buttonConvert = new System.Windows.Forms.Button();
            labelResult = new Label();
            textBoxInput = new System.Windows.Forms.TextBox();
            SuspendLayout();
          
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(233, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Location = new Point(434, 110);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(184, 23);
            comboBoxFrom.TabIndex = 1;
         
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Location = new Point(434, 173);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(184, 23);
            comboBoxTo.TabIndex = 2;
           
            buttonConvert.Location = new Point(271, 302);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(176, 24);
            buttonConvert.TabIndex = 3;
            buttonConvert.Text = "Конвертувати";
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += buttonConvert_Click;
         
            labelResult.AutoSize = true;
            labelResult.Location = new Point(123, 173);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(60, 15);
            labelResult.TabIndex = 4;
            labelResult.Text = "Результат";
            labelResult.Click += labelResult_Click;
           
            textBoxInput.Location = new Point(93, 110);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(155, 23);
            textBoxInput.TabIndex = 5;
           
            ClientSize = new Size(763, 439);
            Controls.Add(textBoxInput);
            Controls.Add(labelResult);
            Controls.Add(buttonConvert);
            Controls.Add(comboBoxTo);
            Controls.Add(comboBoxFrom);
            Controls.Add(comboBox1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }

    public class ConverterUnit
    {
        public string Name;
        public double Ratio;
        public ConverterUnit(string n, double r) { Name = n; Ratio = r; }
    }
}