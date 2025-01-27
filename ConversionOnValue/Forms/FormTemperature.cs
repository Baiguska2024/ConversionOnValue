using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConversionOnValue.Forms
{
    public partial class FormDistance : Form
    {



        public FormDistance()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(System.Windows.Forms.Button))
                {
                    var btn = (System.Windows.Forms.Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num2 = 0;
            double add2;
            double tempreture;
            num2 = Convert.ToInt32(textBox1.Text);
            Convert.ToInt32(textBox1.Text);
            tempreture = Convert.ToInt32(textBox1.Text);
            Convert.ToInt32(textBox1.Text);
            if (cmb3.Text == "Celsius" && cmb4.Text == "Celsius")
            {
                tempreture = num2;
                label5.Text = tempreture.ToString() + " ∘C";
            }
            else if (cmb3.Text == "Celsius" && cmb4.Text == "Fahrenheit")
            {
                tempreture = (9.0 / 5.0) * (double)num2 + 32;


                label5.Text = tempreture.ToString() + " ∘F";
            }
            else if (cmb3.Text == "Fahrenheit" && cmb4.Text == "Celsius")
            {

                tempreture = (5.0 / 9.0) * ((double)num2 - 32);

                label5.Text = tempreture.ToString() + " ∘F";
            }
            else if (cmb3.Text == "Fahrenheit" && cmb4.Text == "Fahrenheit")
            {
                tempreture = num2;
                label5.Text = tempreture.ToString() + " ∘F";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
