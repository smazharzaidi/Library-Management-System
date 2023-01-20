namespace Library_Management_System
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if ((textBox1.Text == "admin") && (textBox2.Text == "12345"))
			{
				Form2 f2= new Form2();
				f2.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Wrong Credentials");
			}
		}
	}
}