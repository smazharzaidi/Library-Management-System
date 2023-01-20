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
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			// Load the XML file
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

			// Check if a member with the same ID already exists
			XmlNode existingMember = xmlDoc.SelectSingleNode("/library/members/member[id='" + guna2TextBox1.Text + "']");
			if (existingMember != null)
			{
				// Display an error message if the member already exists
				MessageBox.Show("A student with same ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Create the new member element
			XmlElement newMember = xmlDoc.CreateElement("member");

			// Create the ID element and set its value
			XmlElement id = xmlDoc.CreateElement("id");
			id.InnerText = guna2TextBox1.Text;

			// Create the name element and set its value
			XmlElement name = xmlDoc.CreateElement("name");
			name.InnerText = guna2TextBox2.Text;

			// Create the email element and set its value
			XmlElement email = xmlDoc.CreateElement("email");
			email.InnerText = guna2TextBox3.Text;

			// Create the phone element and set its value
			XmlElement phone = xmlDoc.CreateElement("phone");
			phone.InnerText = guna2TextBox4.Text;

			// Create the address element and set its value
			XmlElement address = xmlDoc.CreateElement("address");
			address.InnerText = guna2TextBox5.Text;

			// Append the elements to the new member element
			newMember.AppendChild(id);
			newMember.AppendChild(name);
			newMember.AppendChild(email);
			newMember.AppendChild(phone);
			newMember.AppendChild(address);

			// Find the members element and append the new member element to it
			XmlNode membersNode = xmlDoc.SelectSingleNode("library/members");
			membersNode.AppendChild(newMember);

			// Save the changes to the XML file
			xmlDoc.Save("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

			MessageBox.Show("The member has been added.");
			guna2TextBox1.Text = " ";
			guna2TextBox2.Text = " ";
			guna2TextBox3.Text = " ";
			guna2TextBox4.Text = " ";
			guna2TextBox5.Text = " ";
		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();
		}
	}
}
