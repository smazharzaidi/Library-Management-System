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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			// Load the XML file
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

			// Check if a book with the same ISBN already exists
			XmlNode existingBook = xmlDoc.SelectSingleNode("/library/books/book[isbn='" + guna2TextBox1.Text + "']");
			if (existingBook != null)
			{
				// Display an error message if the book already exists
				MessageBox.Show("A book with same ISBN already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Create the new book element
			XmlElement newBook = xmlDoc.CreateElement("book");

			// Create the ISBN element and set its value
			XmlElement isbn = xmlDoc.CreateElement("isbn");
			isbn.InnerText = guna2TextBox1.Text;

			// Create the title element and set its value
			XmlElement title = xmlDoc.CreateElement("title");
			title.InnerText = guna2TextBox2.Text;

			// Create the author element and set its value
			XmlElement author = xmlDoc.CreateElement("author");
			author.InnerText = guna2TextBox3.Text;

			// Create the totalCopies element and set its value
			XmlElement totalCopies = xmlDoc.CreateElement("totalCopies");
			totalCopies.InnerText = guna2TextBox4.Text;

			// Create the availableCopies element and set its value
			XmlElement availableCopies = xmlDoc.CreateElement("availableCopies");
			availableCopies.InnerText = guna2TextBox5.Text;

			// Append the elements to the new book element
			newBook.AppendChild(isbn);
			newBook.AppendChild(title);
			newBook.AppendChild(author);
			newBook.AppendChild(totalCopies);
			newBook.AppendChild(availableCopies);

			// Find the books element and append the new book element to it
			XmlNode booksNode = xmlDoc.SelectSingleNode("library/books");
			booksNode.AppendChild(newBook);

			// Save the changes to the XML file
			xmlDoc.Save("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

			MessageBox.Show("The book has been added.");
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
