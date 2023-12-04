using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_From_Hell
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.helloButton.Click += new EventHandler(HelloButton__Click);

            this.checkBox1.CheckedChanged += new EventHandler(CheckBox__Checked);

            this.radioButton1.CheckedChanged += new EventHandler(Trapped__Checked);
            this.radioButton2.CheckedChanged += new EventHandler(Curious__Checked);
            this.radioButton3.CheckedChanged += new EventHandler(Defeat__Checked);
            this.radioButton3.CheckedChanged += new EventHandler(Work__Checked);

            this.timer1.Tick += new EventHandler(Timer__Tick);
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.progressBar1.Value; 


            if(this.progressBar1.Value == 0)
            {
                MessageBox.Show("Oops you're done");
                Application.Exit();
            }
        }

        private void HelloButton__Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.progressBar1.Visible = true;
            this.textBox1.Visible = true;
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.helloButton.Visible = false;

            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.textBox5.Visible = false;
            this.textBox6.Visible = false;
            this.textBox7.Visible = false;
            this.textBox8.Visible = false;
            this.textBox9.Visible = false;
            this.textBox10.Visible = false;
            this.textBox11.Visible = false;
            this.textBox12.Visible = false;
            this.textBox13.Visible = false;
            this.textBox14.Visible = false;
            this.pictureBox.Visible = false;
        }

        private void CheckBox__Checked(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                MessageBox.Show("Really your name is actually " + this.textBox1.Text);
            }
        }

        private void Trapped__Checked(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
            this.progressBar1.Visible = false;
            this.textBox1.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.helloButton.Visible = true;

            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.textBox5.Visible = false;
            this.textBox6.Visible = false;
            this.textBox7.Visible = false;
            this.textBox8.Visible = false;
            this.textBox9.Visible = false;
            this.textBox10.Visible = false;
            this.textBox11.Visible = false;
            this.textBox12.Visible = false;
            this.textBox13.Visible = false;
            this.textBox14.Visible = false;
            this.pictureBox.Visible = false;
        }

        private void Curious__Checked(object sender, EventArgs e)
        {
            this.textBox3.Visible = true;
            this.textBox4.Visible = true;
            this.textBox5.Visible = true;
            this.textBox6.Visible = true;
            this.textBox7.Visible = true;
            this.textBox8.Visible = true;
            this.textBox9.Visible = true;
            this.textBox10.Visible = true;
            this.textBox11.Visible = true;
            this.textBox12.Visible = true;
            this.textBox13.Visible = true;
            this.textBox14.Visible = true;
            this.pictureBox.Visible = true;
        }

        private void Defeat__Checked(Object sender, EventArgs e)
        {
            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.textBox5.Visible = false;
            this.textBox6.Visible = false;
            this.textBox7.Visible = false;
            this.textBox8.Visible = false;
            this.textBox9.Visible = false;
            this.textBox10.Visible = false;
            this.textBox11.Visible = false;
            this.textBox12.Visible = false;
            this.textBox13.Visible = false;
            this.textBox14.Visible = false;
            this.pictureBox.Visible = false;

            MessageBox.Show("YOU REALLY THINK YOU CAN DEFEAT ME. you can't you just got defeated.");
            this.Close();

        }

        private void Work__Checked(Object sender, EventArgs e)
        {
            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.textBox5.Visible = false;
            this.textBox6.Visible = false;
            this.textBox7.Visible = false;
            this.textBox8.Visible = false;
            this.textBox9.Visible = false;
            this.textBox10.Visible = false;
            this.textBox11.Visible = false;
            this.textBox12.Visible = false;
            this.textBox13.Visible = false;
            this.textBox14.Visible = false;
            this.pictureBox.Visible = false;

            WorkForm workForm = new WorkForm();
            workForm.Show();

            this.Close();
        }
    }
}
