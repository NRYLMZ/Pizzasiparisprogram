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
        int[] cal = { 100, 125, 125, 140, 15, 10, 25, 40, 10 };
        double[] price = { 7.50, 8.50, 10.00, 9.50, 0.25, 0.15, 0.25, 0.35, 0.15 };

        int total_cal,total_cal_num,index,index1;
        double unit_price,total_price,total_price_num;

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
                pictureBox1.Image = imageList1.Images[0];
            index = 0;
            groupAdd.Enabled = true;
            buttonInsert.Enabled = true;
            group.Enabled = true;
            checkBoxGreen.Checked = false;
            checkBoxTomato.Checked = false;
            checkBoxPickle.Checked = false;
            checkBoxMushroom.Checked = false;
            checkBoxOlive.Checked = false;
            listrow[0] = "Sicilian";
            numericUpDown1.Value = 1;
            calculate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                pictureBox1.Image = imageList1.Images[1];
            index = 1;
            groupAdd.Enabled = true;
            buttonInsert.Enabled = true;
            group.Enabled = true;
            checkBoxGreen.Checked = false;
            checkBoxTomato.Checked = false;
            checkBoxPickle.Checked = false;
            checkBoxMushroom.Checked = false;
            checkBoxOlive.Checked = false;
            listrow[0] = "Marine";
            numericUpDown1.Value = 1;
            calculate();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                pictureBox1.Image = imageList1.Images[2];
            index = 2;
            groupAdd.Enabled = true;
            buttonInsert.Enabled = true;
            group.Enabled = true;
            checkBoxGreen.Checked = false;
            checkBoxTomato.Checked = false;
            checkBoxPickle.Checked = false;
            checkBoxMushroom.Checked = false;
            checkBoxOlive.Checked = false;
            listrow[0] = "Napoliten";
            numericUpDown1.Value = 1;
            calculate();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                pictureBox1.Image = imageList1.Images[3];
            index = 3;
            groupAdd.Enabled = true;
            buttonInsert.Enabled = true;
            group.Enabled = true;
            checkBoxGreen.Checked = false;
            checkBoxTomato.Checked = false;
            checkBoxPickle.Checked = false;
            checkBoxMushroom.Checked = false;
            checkBoxOlive.Checked = false;
            listrow[0] = "Mixed";
            numericUpDown1.Value = 1;
            calculate();
        }
        private void checkBoxGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGreen.Checked == true)
            {
                index = 4;
                numericUpDown1.Value = 1;
                calculate();
            }
            else
            {
                index = 9;
                index1 = 4;
                numericUpDown1.Value = 1;
                calculate();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            total_cal_num = total_cal;
            total_price_num = total_price;
            total_cal_num *= int.Parse(numericUpDown1.Value.ToString());
            total_price_num *= int.Parse(numericUpDown1.Value.ToString());
            textTotal.Text = total_price_num.ToString();
            textAmoCal.Text = total_cal_num.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxTomato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTomato.Checked == true)
            {
                index = 5;
                numericUpDown1.Value = 1;
                calculate();
            }
            else
            {
                index=9;
                index1=5;
                numericUpDown1.Value = 1;
                calculate();
            }
        }

        private void checkBoxPickle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPickle.Checked == true)
            {
                index = 6;
                numericUpDown1.Value = 1;
                calculate();
            }
            else
            {
                index=9;
                index1=6;
                numericUpDown1.Value = 1;
                calculate();
            }
        }

        private void checkBoxMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMushroom.Checked == true)
            {
                index = 7;
                numericUpDown1.Value = 1;
                calculate();
            }
            else
            {
                index=9;
                index1=7;
                numericUpDown1.Value = 1;
                calculate();
            }
        }

        private void checkBoxOlive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOlive.Checked == true)
            {
                index = 8;
                numericUpDown1.Value = 1;
                calculate();
            }
            else
            {
                index=9;
                index1 = 8;
                numericUpDown1.Value = 1;
                calculate();
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            groupOrder.Enabled = true;
            listrow[1] = numericUpDown1.Value.ToString();
            listrow[2] = textUnit.Text;
            listrow[3] = textTotal.Text;
            listView1.Items.Add(listrow[0]);
            int count = listView1.Items.Count;
            for (int i = 1; i < 4; i++)
                listView1.Items[count - 1].SubItems.Add(listrow[i]);
            listView1.Enabled = true;
            grandtotal();
            buttonNew.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            checkBoxGreen.Checked = false;
            checkBoxMushroom.Checked = false;
            checkBoxOlive.Checked = false;
            checkBoxPickle.Checked = false;
            checkBoxTomato.Checked = false;
            textUnit.Clear();
            numericUpDown1.Value = 1;
            textTotal.Clear();
            textAmoCal.Clear();
            groupType.Enabled = false;
            groupAdd.Enabled = false;
            group.Enabled = false;
            buttonInsert.Enabled = false;
        }
        private void calculate()
        {
            if (index < 4)
            {
                total_cal = cal[index];
                unit_price=price[index];
                total_price = unit_price;
                textUnit.Text = price[index].ToString();
                textAmoCal.Text = cal[index].ToString();
                textTotal.Text = price[index].ToString();
            }
            if(index>=4&&index<9)
            {
                total_cal += cal[index];
                total_price += price[index];
                textUnit.Text = total_price.ToString();
                textAmoCal.Text = total_cal.ToString();
                textTotal.Text = total_price.ToString();

            }
            if (index == 9)
            {
                total_cal -= cal[index1];
                total_price -= price[index1];
                textUnit.Text = total_price.ToString();
                textAmoCal.Text = total_cal.ToString();
                textTotal.Text = total_price.ToString();
 
            }

        }
        private void grandtotal()
        {
            double grandtotal = 0;
            for (int i = 0; i <= ((listView1.Items.Count) - 1); i++)
            {
                grandtotal += double.Parse(listView1.Items[i].SubItems[3].Text);
                textGrand.Text = grandtotal.ToString();

            }
            if (listView1.Items.Count == 0)
                textGrand.Text = "0";
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            groupCustomer.Enabled = false;
            groupType.Enabled = true;
            buttonNew.Enabled = false;
        }

        private void buttonNewc_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            grandtotal();
            textName.Clear();
            textAddress.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            checkBoxGreen.Checked = false;
            checkBoxMushroom.Checked = false;
            checkBoxOlive.Checked = false;
            checkBoxPickle.Checked = false;
            checkBoxTomato.Checked = false;
            groupAdd.Enabled = false;
            textUnit.Clear();
            numericUpDown1.Value = 1;
            textTotal.Clear();
            textAmoCal.Clear();
            groupType.Enabled = false;
            group.Enabled = false;
            buttonNew.Enabled = false;
            textName.Focus();
            
        }
    }
}
