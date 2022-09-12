using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem;

public class userBookSearch : Form
{
	private SqlConnection con;

	private SqlCommand cmd;

	public int userid;

	public string password;

	private IContainer components = null;

	private Panel panel1;

	private Button usrBookSearchBtnLogout;

	private Button UserBookSearchBtnSearch;

	private TextBox UserBookSearchTbxQuery;

	private RadioButton userBookSearchRbBoth;

	private RadioButton userBookSearchRbAuthor;

	private RadioButton userBookSearchRbTitle;

	private Label userBookSearchLblSearch;

	private DataGridView userBookSearchDgv;

	private Button button2;

	private Button button1;

	private void userBookSearch_Load(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		userid = login.userid;
		password = login.password;
		string text = ((object)ConfigurationManager.get_ConnectionStrings().get_Item("LibraryManagementSystem.Properties.Settings.LibraryDB")).ToString();
		con = new SqlConnection(text);
		cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books order by book_id asc", con);
		SqlDataAdapter val = new SqlDataAdapter(cmd);
		DataSet dataSet = new DataSet();
		((DataAdapter)(object)val).Fill(dataSet);
		userBookSearchDgv.set_DataSource((object)dataSet.Tables[0]);
		userBookSearchDgv.set_ReadOnly(true);
		((Control)userBookSearchRbBoth).Select();
	}

	private void UserBookSearchBtnSearch_Click(object sender, EventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		if (((DbConnection)(object)con).State == ConnectionState.Closed)
		{
			((DbConnection)(object)con).Open();
		}
		if (userBookSearchRbBoth.get_Checked())
		{
			cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where title like @searchQuery or author like @searchQuery", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)UserBookSearchTbxQuery).get_Text() + "%"));
			SqlDataAdapter val = new SqlDataAdapter(cmd);
			DataSet dataSet = new DataSet();
			((DataAdapter)(object)val).Fill(dataSet);
			userBookSearchDgv.set_DataSource((object)dataSet.Tables[0]);
		}
		else if (userBookSearchRbTitle.get_Checked())
		{
			cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where title like @searchQuery", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)UserBookSearchTbxQuery).get_Text() + "%"));
			SqlDataAdapter val2 = new SqlDataAdapter(cmd);
			DataSet dataSet2 = new DataSet();
			((DataAdapter)(object)val2).Fill(dataSet2);
			userBookSearchDgv.set_DataSource((object)dataSet2.Tables[0]);
		}
		else if (userBookSearchRbAuthor.get_Checked())
		{
			cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where author like @searchQuery", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)UserBookSearchTbxQuery).get_Text() + "%"));
			SqlDataAdapter val3 = new SqlDataAdapter(cmd);
			DataSet dataSet3 = new DataSet();
			((DataAdapter)(object)val3).Fill(dataSet3);
			userBookSearchDgv.set_DataSource((object)dataSet3.Tables[0]);
		}
	}

	private void userBookSeacrhBtnChangePassword_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		changePassword changePassword2 = new changePassword();
		((Control)changePassword2).Show();
	}

	private void UserBookSearchBtnLogout_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		login login2 = new login();
		((Control)login2).Show();
	}

	public userBookSearch()
	{
		InitializeComponent();
	}

	private void usrBookSearchBtnIssuedBooks_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		usrIssuedBooks usrIssuedBooks2 = new usrIssuedBooks();
		((Control)usrIssuedBooks2).Show();
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
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		panel1 = new Panel();
		usrBookSearchBtnLogout = new Button();
		UserBookSearchBtnSearch = new Button();
		UserBookSearchTbxQuery = new TextBox();
		userBookSearchRbBoth = new RadioButton();
		userBookSearchRbAuthor = new RadioButton();
		userBookSearchRbTitle = new RadioButton();
		userBookSearchLblSearch = new Label();
		userBookSearchDgv = new DataGridView();
		button1 = new Button();
		button2 = new Button();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)userBookSearchDgv).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)usrBookSearchBtnLogout);
		((Control)panel1).get_Controls().Add((Control)(object)UserBookSearchBtnSearch);
		((Control)panel1).get_Controls().Add((Control)(object)UserBookSearchTbxQuery);
		((Control)panel1).get_Controls().Add((Control)(object)userBookSearchRbBoth);
		((Control)panel1).get_Controls().Add((Control)(object)userBookSearchRbAuthor);
		((Control)panel1).get_Controls().Add((Control)(object)userBookSearchRbTitle);
		((Control)panel1).get_Controls().Add((Control)(object)userBookSearchLblSearch);
		((Control)panel1).get_Controls().Add((Control)(object)userBookSearchDgv);
		((Control)panel1).set_Location(new Point(43, 47));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(1277, 722));
		((Control)panel1).set_TabIndex(0);
		((Control)usrBookSearchBtnLogout).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)usrBookSearchBtnLogout).set_Location(new Point(1051, 85));
		((Control)usrBookSearchBtnLogout).set_Name("usrBookSearchBtnLogout");
		((Control)usrBookSearchBtnLogout).set_Size(new Size(75, 35));
		((Control)usrBookSearchBtnLogout).set_TabIndex(21);
		((Control)usrBookSearchBtnLogout).set_Text("Logout");
		((ButtonBase)usrBookSearchBtnLogout).set_UseVisualStyleBackColor(true);
		((Control)usrBookSearchBtnLogout).add_Click((EventHandler)UserBookSearchBtnLogout_Click);
		((Control)UserBookSearchBtnSearch).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)UserBookSearchBtnSearch).set_Location(new Point(460, 121));
		((Control)UserBookSearchBtnSearch).set_Name("UserBookSearchBtnSearch");
		((Control)UserBookSearchBtnSearch).set_Size(new Size(88, 33));
		((Control)UserBookSearchBtnSearch).set_TabIndex(19);
		((Control)UserBookSearchBtnSearch).set_Text("Search");
		((ButtonBase)UserBookSearchBtnSearch).set_UseVisualStyleBackColor(true);
		((Control)UserBookSearchBtnSearch).add_Click((EventHandler)UserBookSearchBtnSearch_Click);
		((Control)UserBookSearchTbxQuery).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)UserBookSearchTbxQuery).set_Location(new Point(221, 92));
		((Control)UserBookSearchTbxQuery).set_Name("UserBookSearchTbxQuery");
		((Control)UserBookSearchTbxQuery).set_Size(new Size(327, 23));
		((Control)UserBookSearchTbxQuery).set_TabIndex(18);
		((Control)userBookSearchRbBoth).set_AutoSize(true);
		((Control)userBookSearchRbBoth).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)userBookSearchRbBoth).set_Location(new Point(364, 121));
		((Control)userBookSearchRbBoth).set_Name("userBookSearchRbBoth");
		((Control)userBookSearchRbBoth).set_Size(new Size(61, 24));
		((Control)userBookSearchRbBoth).set_TabIndex(17);
		userBookSearchRbBoth.set_TabStop(true);
		((Control)userBookSearchRbBoth).set_Text("Both");
		((ButtonBase)userBookSearchRbBoth).set_UseVisualStyleBackColor(true);
		((Control)userBookSearchRbAuthor).set_AutoSize(true);
		((Control)userBookSearchRbAuthor).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)userBookSearchRbAuthor).set_Location(new Point(283, 121));
		((Control)userBookSearchRbAuthor).set_Name("userBookSearchRbAuthor");
		((Control)userBookSearchRbAuthor).set_Size(new Size(75, 24));
		((Control)userBookSearchRbAuthor).set_TabIndex(16);
		userBookSearchRbAuthor.set_TabStop(true);
		((Control)userBookSearchRbAuthor).set_Text("Author");
		((ButtonBase)userBookSearchRbAuthor).set_UseVisualStyleBackColor(true);
		((Control)userBookSearchRbTitle).set_AutoSize(true);
		((Control)userBookSearchRbTitle).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)userBookSearchRbTitle).set_Location(new Point(221, 121));
		((Control)userBookSearchRbTitle).set_Name("userBookSearchRbTitle");
		((Control)userBookSearchRbTitle).set_Size(new Size(56, 24));
		((Control)userBookSearchRbTitle).set_TabIndex(15);
		userBookSearchRbTitle.set_TabStop(true);
		((Control)userBookSearchRbTitle).set_Text("Title");
		((ButtonBase)userBookSearchRbTitle).set_UseVisualStyleBackColor(true);
		((Control)userBookSearchLblSearch).set_AutoSize(true);
		((Control)userBookSearchLblSearch).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)userBookSearchLblSearch).set_Location(new Point(151, 95));
		((Control)userBookSearchLblSearch).set_Name("userBookSearchLblSearch");
		((Control)userBookSearchLblSearch).set_Size(new Size(64, 20));
		((Control)userBookSearchLblSearch).set_TabIndex(14);
		((Control)userBookSearchLblSearch).set_Text("Search:");
		userBookSearchDgv.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		userBookSearchDgv.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Control);
		val.set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		userBookSearchDgv.set_ColumnHeadersDefaultCellStyle(val);
		userBookSearchDgv.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)userBookSearchDgv).set_Location(new Point(157, 207));
		((Control)userBookSearchDgv).set_Name("userBookSearchDgv");
		((Control)userBookSearchDgv).set_Size(new Size(969, 481));
		((Control)userBookSearchDgv).set_TabIndex(13);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)button1).set_Location(new Point(980, 46));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(146, 35));
		((Control)button1).set_TabIndex(22);
		((Control)button1).set_Text("Change Password");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)userBookSeacrhBtnChangePassword_Click);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)button2).set_Location(new Point(980, 166));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(146, 35));
		((Control)button2).set_TabIndex(23);
		((Control)button2).set_Text("Issued Books");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)usrBookSearchBtnIssuedBooks_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1352, 781));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("userBookSearch");
		((Control)this).set_Text("Search Books");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)userBookSearch_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((ISupportInitialize)userBookSearchDgv).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
