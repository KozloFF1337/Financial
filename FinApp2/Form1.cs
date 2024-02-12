using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinApp2
{
    public partial class Form1 : Form
    {
        int monitor;
        public Form1()
        {
            InitializeComponent();
        }

        Screen[] screens = Screen.AllScreens;
        private void Form1_Load(object sender, EventArgs e)
        {
            Label tempLab;
            for (int i = 0; i < screens.Length; i++)
            {
                tempLab = new Label();
                tempLab.Size = new System.Drawing.Size(200, 50);
                tempLab.Location = new System.Drawing.Point(0, 50 + 50 * i);
                tempLab.Text = screens[i].DeviceName.ToString() +"      "+ screens[i].Bounds.Width.ToString() + "     " + screens[i].Bounds.Height.ToString();
                Controls.Add(tempLab);
                switch (i)
                {
                    case 0:
                        checkBox1.Enabled = true;
                        checkBox1.Visible = true;
                        checkBox1.Text = screens[i].DeviceName.ToString();
                        checkBox1.Location = new System.Drawing.Point(200, 50 + 50 * i);
                        break;
                    case 1:
                        checkBox2.Enabled = true;
                        checkBox2.Visible = true;
                        checkBox2.Text = screens[i].DeviceName.ToString();
                        checkBox2.Location = new System.Drawing.Point(200, 50 + 50 * i);
                        break;
                    case 2:
                        checkBox3.Enabled = true;
                        checkBox3.Visible = true;
                        checkBox3.Text = screens[i].DeviceName.ToString();
                        checkBox3.Location = new System.Drawing.Point(200, 50 + 50 * i);
                        break;
                    case 3:
                        checkBox4.Enabled = true;
                        checkBox4.Visible = true;
                        checkBox4.Text = screens[i].DeviceName.ToString();
                        checkBox4.Location = new System.Drawing.Point(200, 50 + 50 * i);
                        break;
                    case 4:
                        checkBox5.Enabled = true;
                        checkBox5.Visible = true;
                        checkBox5.Text = screens[i].DeviceName.ToString();
                        checkBox5.Location = new System.Drawing.Point(200, 50 + 50 * i);
                        break;
                    case 5:
                        checkBox6.Enabled = true;
                        checkBox6.Visible = true;
                        checkBox6.Text = screens[i].DeviceName.ToString();
                        checkBox6.Location = new System.Drawing.Point(200, 50 + 50 * i);
                        break;
                    default:
                        MessageBox.Show("Наличие 7 подключенных мониторов непредусмотренно программой");
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                monitor = 0;
            if (checkBox2.Checked)
                monitor = 1;
            if (checkBox3.Checked)
                monitor = 2;
            if (checkBox4.Checked)
                monitor = 3;
            if (checkBox5.Checked)
                monitor = 4;
            if (checkBox6.Checked)
                monitor = 5;
            Screen[] sc;
            sc = Screen.AllScreens;
            MainForm fr2 = new MainForm();
            fr2.Left = sc[monitor].Bounds.Width;
            fr2.Top = sc[monitor].Bounds.Height;
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = sc[monitor].Bounds.Location;
            Point p = new Point(sc[monitor].Bounds.Location.X, sc[monitor].Bounds.Location.Y);
            fr2.Location = p;
            fr2.Show();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox1.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox1.Checked = false;
            checkBox6.Checked = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox1.Checked = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddItemToListBox(string item)
        {
            textBox1.Text = item;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
