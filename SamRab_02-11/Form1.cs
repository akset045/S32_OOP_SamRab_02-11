using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamRab_02_11
{
    public partial class Form1 : Form
    {
        int a = 0;
        string name;
        string fam;
        string group;
            public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            tabPage0.Enabled = true;
            tabPage1.Enabled = false;
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
            tabPage4.Enabled = false;
         }

        private void button6_Click(object sender, EventArgs e)
        {
            group = textBox2.Text;
            fam = textBox3.Text;
            name = textBox4.Text;
            tabControl1.SelectedIndex = 1;

            tabPage0.Enabled = false;
            tabPage1.Enabled = true;
         }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "8")
            { label9.Text = "Верно";
                a = a + 1;
            }
            else label9.Text = "Ошибка";

            tabControl1.SelectedIndex = 2;
            tabPage1.Enabled = false;
            tabPage2.Enabled = true;
         }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                label10.Text = "Верно";
                a = a + 1;
            }
            else label10.Text = "Ошибка";

            tabControl1.SelectedIndex = 3;
            tabPage2.Enabled = false;
            tabPage3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false &&
                checkBox2.Checked == true &&
                checkBox3.Checked == true)
            {
                label11.Text = "Верно";
                a = a + 1;
            }
            else label11.Text = "Ошибка";

            tabControl1.SelectedIndex = 4;

            tabPage3.Enabled = false;
            tabPage4.Enabled = true;

            label15.Text = group + " " + fam + " " + name;

            if (a == 3) label5.Text = "Отлично, правильных " + Convert.ToString(a) + " ответа";
            if (a == 2) label5.Text = "Хорошо, правильных " + Convert.ToString(a) + " ответа";
            if (a == 1) label5.Text = "Плохо, правильный только " + Convert.ToString(a) + " ответ";
            if (a == 0) label5.Text = "Неудовлетворительно, нет правильных ответов";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            a = 0;
            group = "";
            fam = "";
            name = "";

            tabControl1.SelectedIndex = 0;
            tabPage0.Enabled = true;
            tabPage4.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            textBox1.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            a = 0;

            tabControl1.SelectedIndex = 1;
            tabPage4.Enabled = false;
            tabPage1.Enabled = true;
        }
    }
}
