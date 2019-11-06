using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] listrow = { "", "", "", ""};
        
        int total_cal,cal;
        double unit_price,total_price,grand_total=0;

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.KeyChar = '\0';

            if (e.KeyChar == 13 && textName.Text != "")
                textAddress.Focus();

            if (textName.Text == "" || textName.Text.EndsWith(" ") && Char.IsLetter(e.KeyChar))
                e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void textAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textAddress.Text == "" || textAddress.Text.EndsWith(" ") && Char.IsLetter(e.KeyChar))
                e.KeyChar = Char.ToUpper(e.KeyChar);
            groupType.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                pictureBox1.Image = Properties.Resources.Sicilian;
            cal = 100;
            unit_price = 7.50;
            textTotal.Text = unit_price.ToString();
            textAmoCal.Text = cal.ToString();
            textUnit.Text = unit_price.ToString();            
            groupAdd.Enabled = true;
            buttonInsert.Enabled = true;
            group.Enabled = true;
            checkBoxGreen.Checked = false;
            checkBoxTomato.Checked = false;
            checkBoxPickle.Checked = false;
            checkBoxMushroom.Checked = false;
            checkBoxOlive.Checked = false;
            listrow[0] = "Sicilian";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                pictureBox1.Image = Properties.Resources.Marine;
            cal = 125;
            unit_price = 8.50;
            textTotal.Text = unit_price.ToString();
            textAmoCal.Text = cal.ToString();
            textUnit.Text = unit_price.ToString();
            groupAdd.Enabled = true;
            buttonInsert.Enabled = true;
            group.Enabled = true;
            checkBoxGreen.Checked = false;
            checkBoxTomato.Checked = false;
            checkBoxPickle.Checked = false;
            checkBoxMushroom.Checked = false;
            checkBoxOlive.Checked = false;
            listrow[0] = "Marine";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                pictureBox1.Image = Properties.Resources.Napoliten;
            cal = 125;
            unit_price = 10.00;
            textTotal.Text = unit_price.ToString();
            textAmoCal.Text = cal.ToString();
            textUnit.Text = unit_price.ToString();  
            groupAdd.Enabled = true;
            buttonInsert.Enabled = true;
            group.Enabled = true;
            checkBoxGreen.Checked = false;
            checkBoxTomato.Checked = false;
            checkBoxPickle.Checked = false;
            checkBoxMushroom.Checked = false;
            checkBoxOlive.Checked = false;
            listrow[0] = "Napoliten";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                pictureBox1.Image = Properties.Resources.Mixed;
            cal = 140;
            unit_price = 9.50;
            textTotal.Text = unit_price.ToString();
            textAmoCal.Text = cal.ToString();
            textUnit.Text = unit_price.ToString();  
            groupAdd.Enabled = true;
            buttonInsert.Enabled = true;
            group.Enabled = true;
            checkBoxGreen.Checked = false;
            checkBoxTomato.Checked = false;
            checkBoxPickle.Checked = false;
            checkBoxMushroom.Checked = false;
            checkBoxOlive.Checked = false;
            listrow[0] = "Mixed";
        }
        private void checkBoxGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGreen.Checked == true)
            {
                cal+= 15;
                unit_price+=0.25;
                textTotal.Text = unit_price.ToString();
                textAmoCal.Text = cal.ToString();
                textUnit.Text = unit_price.ToString();  
            }
            else
            {
                cal-=15;
                unit_price-=0.25;
                textTotal.Text = unit_price.ToString();
                textAmoCal.Text = cal.ToString();
                textUnit.Text = unit_price.ToString();  
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            total_price=unit_price*int.Parse(numericUpDown1.Value.ToString());
            textTotal.Text = total_price.ToString();
            total_cal=cal* int.Parse(numericUpDown1.Value.ToString());
            textAmoCal.Text = total_cal.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxTomato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTomato.Checked == true)
            {
                cal += 10;
                unit_price += 0.15;
                textTotal.Text = unit_price.ToString();
                textAmoCal.Text = cal.ToString();
                textUnit.Text = unit_price.ToString();  
            }
            else
            {
                cal -= 10;
                unit_price -= 0.15;
                textTotal.Text = unit_price.ToString();
                textAmoCal.Text = cal.ToString();
                textUnit.Text = unit_price.ToString();  
            }
        }

        private void checkBoxPickle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPickle.Checked == true)
            {
                cal += 25;
                unit_price += 0.25;
                textTotal.Text = unit_price.ToString();
                textAmoCal.Text = cal.ToString();
                textUnit.Text = unit_price.ToString();
            }
            else
            {
                cal -= 25;
                unit_price -= 0.25;
                textTotal.Text = unit_price.ToString();
                textAmoCal.Text = cal.ToString();
                textUnit.Text = unit_price.ToString();
            }
        }

        private void checkBoxMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMushroom.Checked == true)
            {
                cal += 40;
                unit_price += 0.35;
                textTotal.Text = unit_price.ToString();
                textAmoCal.Text = cal.ToString();
                textUnit.Text = unit_price.ToString();
            }
            else
            {
                cal -= 40;
                unit_price -= 0.35;
                textTotal.Text = unit_price.ToString();
                textAmoCal.Text = cal.ToString();
                textUnit.Text = unit_price.ToString();
            }
        }

        private void checkBoxOlive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOlive.Checked == true)
            {
                cal += 10;
                unit_price += 0.1;
                textTotal.Text = unit_price.ToString();
                textAmoCal.Text = cal.ToString();
                textUnit.Text = unit_price.ToString();
            }
            else
            {
                cal -= 10;
                unit_price -= 0.1;
                textTotal.Text = unit_price.ToString();
                textAmoCal.Text = cal.ToString();
                textUnit.Text = unit_price.ToString();
            }

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            grand_total += total_price;
            textGrand.Text = grand_total.ToString();
            listrow[1] = numericUpDown1.Value.ToString();
            listrow[2] = textUnit.Text;
            listrow[3] = textTotal.Text;
            listView1.Items.Add(listrow[0]);
            int count = listView1.Items.Count;
            for (int i = 1; i < 4; i++)
                listView1.Items[count - 1].SubItems.Add(listrow[i]);

        }

    }
}
