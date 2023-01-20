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
	public partial class Form10 : Form
	{
		public Form10()
		{
			InitializeComponent();
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			ReturnBook(guna2TextBox1.Text, Int32.Parse(guna2TextBox2.Text));
		}
		private void ReturnBook(string isbn, int memberId)
		{
			// Load the XML file
			XmlDocument doc = new XmlDocument();
			doc.Load("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

			// Find the book with the specified ISBN
			XmlNode bookNode = doc.SelectSingleNode("/library/books/book[isbn='" + isbn + "']");

			// Check if the book is borrowed
			XmlNode borrowedByNode = bookNode.SelectSingleNode("borrowedBy");
			if (borrowedByNode == null)
			{
				MessageBox.Show("Sorry, this book is not borrowed.");
				return;
			}

			// Find the member who borrowed the book
			XmlNode userNode = borrowedByNode.SelectSingleNode("user[id='" + memberId + "']");
			if (userNode == null)
			{
				MessageBox.Show("Sorry, this book is not borrowed by this member.");
				return;
			}

			// Update the book information
			borrowedByNode.RemoveChild(userNode);
			if (borrowedByNode.ChildNodes.Count == 0)
			{
				bookNode.RemoveChild(borrowedByNode);
			}
			bookNode["availableCopies"].InnerText = (int.Parse(bookNode["availableCopies"].InnerText) + 1).ToString();

			MessageBox.Show("Book returned successfully");
			guna2TextBox1.Text = " ";
			guna2TextBox2.Text = " ";

			// Save the updated XML file
			doc.Save("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");
		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();
		}
	}
}
