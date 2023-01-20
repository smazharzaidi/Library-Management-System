namespace Library_Management_System
{
	partial class Form8
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.xmlDataDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AvailableCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xmlDataDocumentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(305, 50);
			this.label1.TabIndex = 21;
			this.label1.Text = "VIEW BOOKS";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-24, -229);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(959, 339);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// xmlDataDocumentBindingSource
			// 
			this.xmlDataDocumentBindingSource.DataSource = typeof(System.Xml.XmlDataDocument);
			// 
			// guna2ImageButton2
			// 
			this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
			this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
			this.guna2ImageButton2.ImageRotate = 0F;
			this.guna2ImageButton2.ImageSize = new System.Drawing.Size(300, 230);
			this.guna2ImageButton2.Location = new System.Drawing.Point(5, 676);
			this.guna2ImageButton2.Name = "guna2ImageButton2";
			this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.ShadowDecoration.CustomizableEdges = customizableEdges1;
			this.guna2ImageButton2.Size = new System.Drawing.Size(110, 110);
			this.guna2ImageButton2.TabIndex = 25;
			this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
			// 
			// guna2ImageButton1
			// 
			this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
			this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
			this.guna2ImageButton1.ImageRotate = 0F;
			this.guna2ImageButton1.ImageSize = new System.Drawing.Size(300, 230);
			this.guna2ImageButton1.Location = new System.Drawing.Point(303, 676);
			this.guna2ImageButton1.Name = "guna2ImageButton1";
			this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
			this.guna2ImageButton1.Size = new System.Drawing.Size(159, 110);
			this.guna2ImageButton1.TabIndex = 24;
			this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
			// 
			// guna2DataGridView1
			// 
			this.guna2DataGridView1.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.guna2DataGridView1.ColumnHeadersHeight = 42;
			this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Title,
            this.Author,
            this.AvailableCopies,
            this.TotalCopies});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.Location = new System.Drawing.Point(12, 147);
			this.guna2DataGridView1.Name = "guna2DataGridView1";
			this.guna2DataGridView1.RowHeadersVisible = false;
			this.guna2DataGridView1.RowHeadersWidth = 51;
			this.guna2DataGridView1.RowTemplate.Height = 29;
			this.guna2DataGridView1.Size = new System.Drawing.Size(776, 306);
			this.guna2DataGridView1.TabIndex = 26;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 42;
			this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// ISBN
			// 
			this.ISBN.HeaderText = "ISBN";
			this.ISBN.MinimumWidth = 6;
			this.ISBN.Name = "ISBN";
			// 
			// Title
			// 
			this.Title.HeaderText = "Title";
			this.Title.MinimumWidth = 6;
			this.Title.Name = "Title";
			// 
			// Author
			// 
			this.Author.HeaderText = "Author";
			this.Author.MinimumWidth = 6;
			this.Author.Name = "Author";
			// 
			// AvailableCopies
			// 
			this.AvailableCopies.HeaderText = "Available Copies";
			this.AvailableCopies.MinimumWidth = 6;
			this.AvailableCopies.Name = "AvailableCopies";
			// 
			// TotalCopies
			// 
			this.TotalCopies.HeaderText = "Total Copies";
			this.TotalCopies.MinimumWidth = 6;
			this.TotalCopies.Name = "TotalCopies";
			// 
			// Form8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 790);
			this.Controls.Add(this.guna2DataGridView1);
			this.Controls.Add(this.guna2ImageButton2);
			this.Controls.Add(this.guna2ImageButton1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form8";
			this.Text = "View Books";
			this.Load += new System.EventHandler(this.Form8_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xmlDataDocumentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private PictureBox pictureBox1;
		private BindingSource xmlDataDocumentBindingSource;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
		private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
		private DataGridViewTextBoxColumn ISBN;
		private DataGridViewTextBoxColumn Title;
		private DataGridViewTextBoxColumn Author;
		private DataGridViewTextBoxColumn AvailableCopies;
		private DataGridViewTextBoxColumn TotalCopies;
	}
}