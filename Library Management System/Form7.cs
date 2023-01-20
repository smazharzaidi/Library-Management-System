using Guna.UI2.WinForms;
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
	public partial class Form7 : Form
	{
		public Form7()
		{
			InitializeComponent();
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			// Load the XML file
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

			// Find the member element to remove
			XmlNode memberToRemove = xmlDoc.SelectSingleNode("/library/members/member[id='" + guna2TextBox1.Text + "']");

			// Check if the member element was found
			if (memberToRemove != null)
			{
				// Find the book elements that are borrowed by the member
				XmlNodeList borrowedBooks = xmlDoc.SelectNodes("/library/books/book[borrowedBy/user/id='" + guna2TextBox1.Text + "']");

				// Return the books borrowed by the member
				foreach (XmlNode book in borrowedBooks)
				{
					XmlElement availableCopiesElement = (XmlElement)book.SelectSingleNode("availableCopies");
					int availableCopies = Convert.ToInt32(availableCopiesElement.InnerText);
					availableCopiesElement.InnerText = (availableCopies + 1).ToString();
				}

				// Remove the member element from the XML file
				memberToRemove.ParentNode.RemoveChild(memberToRemove);

				// Save the changes to the XML file
				xmlDoc.Save("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

				MessageBox.Show("The member has been removed and their borrowed books have been returned.");
				guna2TextBox1.Text = " ";
			}
			else
			{
				MessageBox.Show("This member isn't available in the library", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();
		}
	}
}
