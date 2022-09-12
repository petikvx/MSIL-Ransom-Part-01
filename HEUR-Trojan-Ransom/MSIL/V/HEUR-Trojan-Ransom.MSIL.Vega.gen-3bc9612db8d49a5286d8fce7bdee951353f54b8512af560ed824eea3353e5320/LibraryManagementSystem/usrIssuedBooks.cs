using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem;

public class usrIssuedBooks : Form
{
	private SqlConnection con;

	private SqlCommand cmd;

	public int userid;

	public string password;

	private IContainer components = null;

	private Panel panel1;

	private Button usrIssuedBooksBtnBack;

	private DataGridView usrIssuedBooksDgvBooks;

	public usrIssuedBooks()
	{
		InitializeComponent();
	}

	private void usrIssuedBooks_Load(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		userid = login.userid;
		password = login.password;
		string text = ((object)ConfigurationManager.get_ConnectionStrings().get_Item("LibraryManagementSystem.Properties.Settings.LibraryDB")).ToString();
		con = new SqlConnection(text);
		cmd = new SqlCommand("select date_issued as 'Date Issued', DATEDIFF(day, date_issued, CONVERT(date, GETDATE()))  as 'Total days passed', book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Year of Publication', genres as 'Genres' from issue, books where i_user_id = @user_id and i_book_id = book_id", con);
		cmd.get_Parameters().AddWithValue("@user_id", (object)userid);
		SqlDataAdapter val = new SqlDataAdapter(cmd);
		DataSet dataSet = new DataSet();
		((DataAdapter)(object)val).Fill(dataSet);
		usrIssuedBooksDgvBooks.set_DataSource((object)dataSet.Tables[0]);
		usrIssuedBooksDgvBooks.set_ReadOnly(true);
	}

	private void usrIssuedBooksBtnBack_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		userBookSearch userBookSearch2 = new userBookSearch();
		((Control)userBookSearch2).Show();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		panel1 = new Panel();
		usrIssuedBooksBtnBack = new Button();
		usrIssuedBooksDgvBooks = new DataGridView();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)usrIssuedBooksDgvBooks).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).get_Controls().Add((Control)(object)usrIssuedBooksBtnBack);
		((Control)panel1).get_Controls().Add((Control)(object)usrIssuedBooksDgvBooks);
		((Control)panel1).set_Location(new Point(23, 35));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(1069, 640));
		((Control)panel1).set_TabIndex(0);
		((Control)usrIssuedBooksBtnBack).set_Anchor((AnchorStyles)8);
		((Control)usrIssuedBooksBtnBack).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)usrIssuedBooksBtnBack).set_Location(new Point(923, 28));
		((Control)usrIssuedBooksBtnBack).set_Name("usrIssuedBooksBtnBack");
		((Control)usrIssuedBooksBtnBack).set_Size(new Size(106, 41));
		((Control)usrIssuedBooksBtnBack).set_TabIndex(3);
		((Control)usrIssuedBooksBtnBack).set_Text("Back");
		((ButtonBase)usrIssuedBooksBtnBack).set_UseVisualStyleBackColor(true);
		((Control)usrIssuedBooksBtnBack).add_Click((EventHandler)usrIssuedBooksBtnBack_Click);
		((Control)usrIssuedBooksDgvBooks).set_Anchor((AnchorStyles)12);
		usrIssuedBooksDgvBooks.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		usrIssuedBooksDgvBooks.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Window);
		val.set_Font(new Font("Microsoft Sans Serif", 15f));
		val.set_ForeColor(SystemColors.ControlText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		usrIssuedBooksDgvBooks.set_DefaultCellStyle(val);
		((Control)usrIssuedBooksDgvBooks).set_Location(new Point(19, 102));
		((Control)usrIssuedBooksDgvBooks).set_Name("usrIssuedBooksDgvBooks");
		usrIssuedBooksDgvBooks.get_RowTemplate().set_Height(30);
		((Control)usrIssuedBooksDgvBooks).set_Size(new Size(1034, 510));
		((Control)usrIssuedBooksDgvBooks).set_TabIndex(2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1123, 699));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("usrIssuedBooks");
		((Control)this).set_Text("Issued Books");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)usrIssuedBooks_Load);
		((Control)panel1).ResumeLayout(false);
		((ISupportInitialize)usrIssuedBooksDgvBooks).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
