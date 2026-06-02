using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConverterApp
{
    public partial class Form1 : Form
    {
        Dictionary<string, Dictionary<string, double>> cats;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cats = new Dictionary<string, Dictionary<string, double>>();

            var length = new Dictionary<string, double>();
            length["Meter"] = 1;
            length["Kilometer"] = 1000;
            length["Centimeter"] = 0.01;
            length["Millimeter"] = 0.001;
            length["Mile"] = 1609.34;
            length["Foot"] = 0.3048;
            length["Inch"] = 0.0254;
            cats["Length"] = length;

            var mass = new Dictionary<string, double>();
            mass["Gram"] = 1;
            mass["Kilogram"] = 1000;
            mass["Milligram"] = 0.001;
            mass["Ton"] = 1000000;
            mass["Pound"] = 453.592;
            mass["Ounce"] = 28.3495;
            cats["Mass"] = mass;

            var area = new Dictionary<string, double>();
            area["Sq Meter"] = 1;
            area["Sq Kilometer"] = 1000000;
            area["Sq Centimeter"] = 0.0001;
            area["Hectare"] = 10000;
            area["Acre"] = 4046.86;
            area["Sq Foot"] = 0.092903;
            cats["Area"] = area;

            var volume = new Dictionary<string, double>();
            volume["Liter"] = 1;
            volume["Milliliter"] = 0.001;
            volume["Cubic Meter"] = 1000;
            volume["Gallon"] = 3.78541;
            volume["Quart"] = 0.946353;
            volume["Pint"] = 0.473176;
            cats["Volume"] = volume;


            var temp = new Dictionary<string, double>();
            temp["Celsius"] = 0;
            temp["Fahrenheit"] = 1;
            temp["Kelvin"] = 2;
            cats["Temperature"] = temp;

            foreach (var cat in cats.Keys)
                comboBox1.Items.Add(cat);

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string cat = comboBox1.SelectedItem.ToString();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            foreach (var unit in cats[cat].Keys)
            {
                comboBox2.Items.Add(unit);
                comboBox3.Items.Add(unit);
            }

            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = comboBox2.Items.Count > 1 ? 1 : 0;
            }

            label5.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Enter a number!");
                    return;
                }

                double val;
                if (!double.TryParse(textBox1.Text, out val))
                {
                    MessageBox.Show("Invalid number! Use comma or dot");
                    textBox1.Text = "";
                    return;
                }

                string cat = comboBox1.SelectedItem.ToString();
                string from = comboBox2.SelectedItem.ToString();
                string to = comboBox3.SelectedItem.ToString();

                double result;

                if (cat == "Temperature")
                {
                    result = ConvertTemp(val, from, to);
                }
                else
                {
                    double inBase = val * cats[cat][from];
                    result = inBase / cats[cat][to];
                }

                label5.Text = result.ToString("N4");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private double ConvertTemp(double val, string from, string to)
        {
            double celsius = 0;

            if (from == "Celsius") celsius = val;
            if (from == "Fahrenheit") celsius = (val - 32) * 5 / 9;
            if (from == "Kelvin") celsius = val - 273.15;

            if (to == "Celsius") return celsius;
            if (to == "Fahrenheit") return celsius * 9 / 5 + 32;
            return celsius + 273.15;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.')
                e.Handled = true;
        }
    }
}