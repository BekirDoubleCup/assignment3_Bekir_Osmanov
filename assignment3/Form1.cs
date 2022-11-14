using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            height_txt.Text = "";
            weight_txt.Text = "";
            result_box.Text = "";
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(weight_txt.Text);
            double height = Convert.ToDouble(height_txt.Text);
            double result = 0.0;
            string result2 = "";

            result = 703 * (weight / (height * height));

            

            if (result < 18.5)
            {
            result2 = "You are underweight";
            }
            else
                if (result < 25)
            {
                result2 = "You have normal weight";
            }
            else
                if (result < 30)
            {
                result2 = "You are overweight";
            }
            result_box.Text = "Your BMI is: " + result.ToString("#.#") + "\r\n" + result2;
        }
    }
}
