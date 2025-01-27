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
    public partial class FormProducts : Form
    {
        public FormProducts()
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
        private void button2_Click(object sender, EventArgs e)
        {
            double num = 0;
            double add;
            double num2 = 0;
            double add2;
            double tempreture;
            num = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox1.Text);
            Convert.ToInt32(textBox1.Text);
            tempreture = Convert.ToInt32(textBox1.Text);
            Convert.ToInt32(textBox1.Text);

            textBox1.Text = "0";

            if (cmb1.Text == "Metars" && cmb2.Text == "Metars")
            {
                add = num;
                label5.Text = add.ToString() + " m";
            }
            else if (cmb1.Text == "Metars" && cmb2.Text == "Kilometars")
            {
                add = num / 1000;
                label5.Text = add.ToString() + " km";
            }
            else if (cmb1.Text == "Metars" && cmb2.Text == "Miles")
            {
                add = num / 1609.344;
                label5.Text = add.ToString() + " miles";
            }
            else if (cmb1.Text == "Kilometars" && cmb2.Text == "Metars")
            {
                add = num * 1000;
                label5.Text = add.ToString() + " m";
            }
            else if (cmb1.Text == "Kilometars" && cmb2.Text == "Kilometars")
            {
                add = num;
                label5.Text = add.ToString() + " km";
            }
            else if (cmb1.Text == "Kilometars" && cmb2.Text == "Miles")
            {
                add = num * 0.621371192;
                label5.Text = add.ToString() + " miles";
            }
            else if (cmb1.Text == "Miles" && cmb2.Text == "Metars")
            {
                add = num * 1609.344;
                label5.Text = add.ToString() + " m";
            }
            else if (cmb1.Text == "Miles" && cmb2.Text == "Kilometars")
            {
                add = num * 1.609344;
                label5.Text = add.ToString() + " km";
            }
            else if (cmb1.Text == "Miles" && cmb2.Text == "Miles")
            {
                add = num;
                label5.Text = add.ToString() + " miles";
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



}
