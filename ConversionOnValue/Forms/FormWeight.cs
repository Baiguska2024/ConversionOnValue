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
    public partial class FormWeight : Form
    {
        public FormWeight()
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
            double pounds = 0;
            double weight;
            pounds = Convert.ToInt32(textBox3.Text);
            Convert.ToInt32(textBox3.Text);
            weight = Convert.ToInt32(textBox3.Text);
            Convert.ToInt32(textBox3.Text);
            //Kilograms
            //Pounds
            if (cmb5.Text == "Kilograms" && cmb6.Text == "Kilograms")
            {
                weight = pounds;
                label5.Text = weight.ToString() + " kg";
            }
            else if (cmb5.Text == "Kilograms" && cmb6.Text == "Pounds")
            {
                 weight =   (double)pounds/2.20462;


                label5.Text = weight.ToString() + " lbs";
            }
            else if (cmb5.Text == "Pounds" && cmb6.Text == "Kilograms")
            {
                 weight = 2.20462 * (double)pounds ;
             

                label5.Text = weight.ToString() + " kg";
            }
            else if (cmb5.Text == "Pounds" && cmb6.Text == "Pounds")
            {
                weight = pounds;
                label5.Text = weight.ToString() + " lbs";
            }
        }

        private void cmb5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
