using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChat
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2()
        {
            InitializeComponent();
            form1 = new Form1();
        }
        
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
        }

        public void process_text(string s)
        {
            textBoxOutput.Text += "User1: " + s + Environment.NewLine;
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text != "")
            {
                textBoxOutput.Text += "User2: " + textBoxInput.Text + Environment.NewLine;
                form1.process_text(textBoxInput.Text);
            }
        }
    }
}
