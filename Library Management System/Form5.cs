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
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			// Load the XML file
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

			// Find the book element to update
			XmlNode bookToUpdate = xmlDoc.SelectSingleNode(xpath: "/library/books/book[isbn='" + guna2TextBox1.Text + "']"); ;

			// Check if the book element was found
			if (bookToUpdate != null)
			{
				// Convert the number of books from the textbox to an integer
				int numBooks = Convert.ToInt32(guna2TextBox2.Text);

				// Find the totalCopies element and update its value
				XmlNode totalCopiesNode = bookToUpdate.SelectSingleNode("totalCopies");
				int totalCopies = Convert.ToInt32(totalCopiesNode.InnerText);
				totalCopiesNode.InnerText = (totalCopies + numBooks).ToString();

				// Find the availableCopies element and update its value
				XmlNode availableCopiesNode = bookToUpdate.SelectSingleNode("availableCopies");
				int availableCopies = Convert.ToInt32(availableCopiesNode.InnerText);
				availableCopiesNode.InnerText = (availableCopies + numBooks).ToString();

				// Save the changes to the XML file
				xmlDoc.Save("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

				MessageBox.Show("The collection has been updated.");
				guna2TextBox1.Text = " ";
				guna2TextBox2.Text = " ";

			}
			else
			{
				// Display an error message if the book was not found
				MessageBox.Show("This book isn't available in the library", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				guna2TextBox1.Text = " ";
				guna2TextBox2.Text = " ";
			}
		}
	}
}
