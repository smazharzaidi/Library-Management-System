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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			// Load the XML file
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

			// Find the book element to remove
			XmlNode bookToRemove = xmlDoc.SelectSingleNode(xpath: "/library/books/book[isbn='" + guna2TextBox1.Text + "']");

			// Check if the book element was found
			if (bookToRemove != null)
			{
				// Convert the number of copies from the textbox to an integer
				int numCopies = Convert.ToInt32(guna2TextBox2.Text);

				// Check if there are enough copies available to remove
				XmlElement availableCopiesElement = (XmlElement)bookToRemove.SelectSingleNode("availableCopies");
				XmlElement totalCopiesElement = (XmlElement)bookToRemove.SelectSingleNode("totalCopies");
				int availableCopies = Convert.ToInt32(availableCopiesElement.InnerText);
				if (availableCopies < numCopies)
				{
					// Display an error message if there are not enough copies available to remove
					MessageBox.Show("Cannot remove " + numCopies + " copies. Only " + availableCopies + " copies are available.");
				}
				else
				{
					// Update the availableCopies and totalCopies elements with the new number of copies
					int newTotalCopies = Convert.ToInt32(totalCopiesElement.InnerText) - numCopies;
					int newAvailableCopies = Convert.ToInt32(availableCopiesElement.InnerText) - numCopies;
					totalCopiesElement.InnerText = newTotalCopies.ToString();
					availableCopiesElement.InnerText = newAvailableCopies.ToString();
					if (newTotalCopies == 0)
					{
						// Remove the book element if there are no more copies left
						bookToRemove.ParentNode.RemoveChild(bookToRemove);
					}
					// Save the changes to the XML file
					xmlDoc.Save("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

					MessageBox.Show("The collection has been updated.");
					guna2TextBox1.Text = " ";
					guna2TextBox2.Text = " ";
				}
			}
			else
			{
				MessageBox.Show("This book isn't available in the library", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
