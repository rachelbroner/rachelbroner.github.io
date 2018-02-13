using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Zodiac_Application
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dateTimePicker1.Value;
            string name = tbName.Text.Trim();


            ZodiacCalculator.ZodiacCalculator calculator = new ZodiacCalculator.ZodiacCalculator();

            bnText.Text = calculator.BirthNumber(birthDate).ToString();
            cnText.Text = calculator.CurrentNumber(birthDate).ToString();
            nnText.Text = calculator.NameNumber(name).ToString();
            zsText.Text = calculator.ZodiacSign(birthDate);

        }
    }
}
