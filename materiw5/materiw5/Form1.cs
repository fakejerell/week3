namespace materiw5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label5.ForeColor = Color.Red;
            }
            else
            {
                label5.ForeColor = Color.Black;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBox1.Text)) {
                MessageBox.Show("Input Kembar");
            }
            else {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton1.ForeColor = Color.Red;
                radioButton2.ForeColor = Color.Blue;

            }
            else
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dipilih = listBox1.GetItemText(listBox1.SelectedItem);
            label5.Text = dipilih;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label5.ForeColor = Color.Blue;
            }
            else
            {
                label5.ForeColor = Color.Black;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label5.Text = "Text";
            textBox1.Clear();
            label5.ForeColor = Color.Black;
        }
    }
}