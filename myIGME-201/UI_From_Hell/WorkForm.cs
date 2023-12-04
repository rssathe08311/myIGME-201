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
    public partial class WorkForm : Form
    {
        public WorkForm()
        {
            InitializeComponent();

            this.button1.Click += new EventHandler(Submit__Click);
            this.radioButton1.CheckedChanged += new EventHandler(Pay__CheckedChanged);
        }

        private void Submit__Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text == null)
            {
                MessageBox.Show("Come on you gotta at least try");
                MessageBox.Show("Come on you gotta at least try");
                MessageBox.Show("Like fr fill it in");
            }

            MessageBox.Show("After much deliberation...nah I work alone");

            this.Close();
        }

        private void Pay__CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("LMAOOO YOU THOUGHT!");
            Application.Exit();
        }
    }
}
