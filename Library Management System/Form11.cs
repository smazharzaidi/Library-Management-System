using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Library_Management_System
{
	public partial class Form11 : Form
	{
		public Form11()
		{
			InitializeComponent();
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			// Load the XML file into an XmlDocument
			XmlDocument doc = new XmlDocument();
			doc.Load("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

			// Get the "members" element from the XML document
			XmlElement membersElement = (XmlElement)doc.SelectSingleNode("/library/members");

			// Iterate through each "member" element in the "members" element
			foreach (XmlElement memberElement in membersElement.SelectNodes("member"))
			{
				// Create a new row for the DataGridView
				int rowIndex = guna2DataGridView1.Rows.Add();
				DataGridViewRow row = guna2DataGridView1.Rows[rowIndex];

				// Get the values for each column from the "member" element
				string id = memberElement.SelectSingleNode("id").InnerText;
				string name = memberElement.SelectSingleNode("name").InnerText;
				string email = memberElement.SelectSingleNode("email").InnerText;
				string phone = memberElement.SelectSingleNode("phone").InnerText;
				string address = memberElement.SelectSingleNode("address").InnerText;

				// Set the values for each column in the row
				row.Cells["ID"].Value = id;
				row.Cells["Name"].Value = name;
				row.Cells["Email"].Value = email;
				row.Cells["Phone"].Value = phone;
				row.Cells["Address"].Value = address;
			}
		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();
		}

		private void guna2ImageButton2_Click_1(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();
		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
