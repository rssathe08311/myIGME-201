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


namespace UI_From_Hell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.label1.Font = new Font("Arial", 15, FontStyle.Regular);

            this.fakeButton.Click += new EventHandler(FakeButton__CLick);
            this.exitButton.Click += new EventHandler(ExitButton__Click);
            this.startButton.Click += new EventHandler(StartButton__Click);

            

        }

        private void FakeButton__CLick(object sender, EventArgs e)
        {
            this.startButton.Visible = true; 
            this.label2.Visible = true;
            this.pictureBox1.Visible = true;
            this.pictureBox2.Visible = true;
            this.pictureBox3.Visible = true;
            this.pictureBox4.Visible = true;
            this.pictureBox5.Visible = true;
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "You really thought I'd let you leave");

        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.FormClosing += MainForm_FormClosing;
            mainForm.Show();

            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
