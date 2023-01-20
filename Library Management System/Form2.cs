using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			label1.BackColor = Color.Transparent;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Form4 f4=new Form4();
			f4.Show();
			this.Hide();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Form3 f3 = new Form3();
			f3.Show();
			this.Hide();
		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			Form5 f5 = new Form5();
			f5.Show();
			this.Hide();
		}

		private void guna2Button4_Click(object sender, EventArgs e)
		{
			Form6 f6 = new Form6();
			f6.Show();
			this.Hide();
		}

		private void guna2Button5_Click(object sender, EventArgs e)
		{
			Form7 f7 = new Form7();
			f7.Show();
			this.Hide();
		}

		private void guna2Button6_Click(object sender, EventArgs e)
		{
			Form8 f8 = new Form8();
			f8.Show();
			this.Hide();
		}

		private void guna2Button7_Click(object sender, EventArgs e)
		{
			Form9 f9 = new Form9();
			f9.Show();
			this.Hide();
		}

		private void guna2Button8_Click(object sender, EventArgs e)
		{
			Form10 f10=new Form10();
			f10.Show();
			this.Hide();
		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			Form1 f1=new Form1();
			f1.Show();
			this.Hide();
		}

		private void guna2Button9_Click(object sender, EventArgs e)
		{
			Form11 f11 = new Form11();
			f11.Show();
			this.Hide();
		}
	}
}
