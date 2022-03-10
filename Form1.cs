namespace SimpleChat
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new Form2(this);
            form2.Show();
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
        }

        public void process_text(string s)
        {
            textBoxOutput.Text += "User2: " + s + Environment.NewLine;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text != "")
            {
                textBoxOutput.Text += "User1: " + textBoxInput.Text + Environment.NewLine;
                form2.process_text(textBoxInput.Text);
            }
        }
    }
}