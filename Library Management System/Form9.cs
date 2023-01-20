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
	public partial class Form9 : Form
	{
		public Form9()
		{
			InitializeComponent();
		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();
		}
		private void BorrowBook(string isbn, int memberId)
		{
			// Load the XML file
			XmlDocument doc = new XmlDocument();
			doc.Load("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");

			// Find the book with the specified ISBN
			XmlNode bookNode = doc.SelectSingleNode("/library/books/book[isbn='" + isbn + "']");

			// Check if the book is available
			if (bookNode == null)
			{
				MessageBox.Show("Sorry, the book with the specified ISBN was not found.");
				return;
			}
			if (bookNode["availableCopies"].InnerText == "0")
			{
				MessageBox.Show("Sorry, this book is not available.");
				return;
			}

			// Find the member with the specified ID
			XmlNode memberNode = doc.SelectSingleNode("/library/members/member[id='" + memberId + "']");

			if (memberNode == null)
			{
				MessageBox.Show("Sorry, the member with the specified ID was not found.");
				return;
			}

			// Update the book information
			XmlNode borrowedByNode = bookNode.SelectSingleNode("borrowedBy");
			if (borrowedByNode == null)
			{
				borrowedByNode = doc.CreateElement("borrowedBy");
				bookNode.AppendChild(borrowedByNode);
			}
			XmlNode userNode = doc.CreateElement("user");
			borrowedByNode.AppendChild(userNode);
			XmlNode idNode = doc.CreateElement("id");
			idNode.InnerText = memberId.ToString();
			userNode.AppendChild(idNode);
			XmlNode nameNode = doc.CreateElement("name");
			nameNode.InnerText = memberNode["name"].InnerText;
			userNode.AppendChild(nameNode);
			XmlNode borrowedDateNode = doc.CreateElement("borrowedDate");
			borrowedDateNode.InnerText = DateTime.Now.ToString("yyyy-MM-dd");
			userNode.AppendChild(borrowedDateNode);
			XmlNode dueDateNode = doc.CreateElement("dueDate");
			dueDateNode.InnerText = DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd");
			userNode.AppendChild(dueDateNode);
			bookNode["availableCopies"].InnerText = (int.Parse(bookNode["availableCopies"].InnerText) - 1).ToString();

			MessageBox.Show("Book borrowed successfully");
			guna2TextBox1.Text = "";
			guna2TextBox2.Text = "";

			// Save the updated XML file
			doc.Save("C:\\Users\\MSI\\source\\repos\\Library Management System\\Library Management System\\XMLFile1.xml");
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			BorrowBook(guna2TextBox1.Text, Int32.Parse(guna2TextBox2.Text));
		}
	}
}
