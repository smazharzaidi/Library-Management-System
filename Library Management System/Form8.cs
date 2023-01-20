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
	public partial class Form8 : Form
	{
		public Form8()
		{
			InitializeComponent();
		}

		private void Form8_Load(object sender, EventArgs e)
		{
		}
		
		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			// Load the XML file into an XmlDocument
			XmlDocument doc = new XmlDocument();
			doc.Load("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

			// Get the "books" element from the XML document
			XmlElement booksElement = (XmlElement)doc.SelectSingleNode("/library/books");

			// Iterate through each "book" element in the "books" element
			foreach (XmlElement bookElement in booksElement.SelectNodes("book"))
			{
				// Create a new row for the DataGridView
				int rowIndex = guna2DataGridView1.Rows.Add();
				DataGridViewRow row = guna2DataGridView1.Rows[rowIndex];

				// Get the values for each column from the "book" element
				string isbn = bookElement.SelectSingleNode("isbn").InnerText;
				string title = bookElement.SelectSingleNode("title").InnerText;
				string author = bookElement.SelectSingleNode("author").InnerText;
				int totalCopies = int.Parse(bookElement.SelectSingleNode("totalCopies").InnerText);
				int availableCopies = int.Parse(bookElement.SelectSingleNode("availableCopies").InnerText);

				// Set the values for each column in the row
				row.Cells["ISBN"].Value = isbn;
				row.Cells["Title"].Value = title;
				row.Cells["Author"].Value = author;
				row.Cells["TotalCopies"].Value = totalCopies;
				row.Cells["AvailableCopies"].Value = availableCopies;
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
