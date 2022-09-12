using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem;

public class admBookSearch : Form
{
	private SqlConnection con;

	private SqlCommand cmd;

	public int userid;

	public string password;

	private IContainer components = null;

	private Panel panel1;

	private Button admBookSearchBtnLogout;

	private Button admBookSearchBtnSearch;

	private TextBox admBookSearchTbxQuery;

	private RadioButton admBookSearchRbBoth;

	private RadioButton admBookSearchRbAuthor;

	private RadioButton admBookSearchRbTitle;

	private Label admBookSearchLblSearch;

	private DataGridView admBookSearchDgv;

	private Button admBookSearchBtnBack;

	public admBookSearch()
	{
		InitializeComponent();
	}

	private void admBookSearch_Load(object sender, EventArgs e)
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
		cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', i_user_id as 'User ID', name as 'User Name', date_issued as 'Date Issued', DATEDIFF(day, date_issued, CONVERT(date, GETDATE()))  as 'Total days passed', publisher as 'Publisher', year_of_pub as 'Year of Pub', genres as 'Genres' from books left join issue on i_book_id = book_id left join users on i_user_id = user_id", con);
		SqlDataAdapter val = new SqlDataAdapter(cmd);
		DataSet dataSet = new DataSet();
		((DataAdapter)(object)val).Fill(dataSet);
		admBookSearchDgv.set_DataSource((object)dataSet.Tables[0]);
		admBookSearchDgv.set_ReadOnly(true);
		((Control)admBookSearchRbBoth).Select();
	}

	private void admBookSearchBtnLogout_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		login login2 = new login();
		((Control)login2).Show();
	}

	private void admBookSearchBtnSearch_Click(object sender, EventArgs e)
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
		if (admBookSearchRbBoth.get_Checked())
		{
			cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', i_user_id as 'User ID', name as 'User Name', date_issued as 'Date Issued', DATEDIFF(day, date_issued, CONVERT(date, GETDATE())) as 'Total days passed', publisher as 'Publisher', year_of_pub as 'Year of Pub', genres as 'Genres' from books left join issue on i_book_id = book_id left join users on i_user_id = user_id where title like @searchQuery or author like @searchQuery", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)admBookSearchTbxQuery).get_Text() + "%"));
			SqlDataAdapter val = new SqlDataAdapter(cmd);
			DataSet dataSet = new DataSet();
			((DataAdapter)(object)val).Fill(dataSet);
			admBookSearchDgv.set_DataSource((object)dataSet.Tables[0]);
		}
		else if (admBookSearchRbTitle.get_Checked())
		{
			cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', i_user_id as 'User ID', name as 'User Name', date_issued as 'Date Issued', DATEDIFF(day, date_issued, CONVERT(date, GETDATE()))  as 'Total days passed', publisher as 'Publisher', year_of_pub as 'Year of Pub', genres as 'Genres' from books left join issue on i_book_id = book_id left join users on i_user_id = user_id where title like @searchQuery", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)admBookSearchTbxQuery).get_Text() + "%"));
			SqlDataAdapter val2 = new SqlDataAdapter(cmd);
			DataSet dataSet2 = new DataSet();
			((DataAdapter)(object)val2).Fill(dataSet2);
			admBookSearchDgv.set_DataSource((object)dataSet2.Tables[0]);
		}
		else if (admBookSearchRbAuthor.get_Checked())
		{
			cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', i_user_id as 'User ID', name as 'User Name', date_issued as 'Date Issued', DATEDIFF(day, date_issued, CONVERT(date, GETDATE()))  as 'Total days passed', publisher as 'Publisher', year_of_pub as 'Year of Pub', genres as 'Genres' from books left join issue on i_book_id = book_id left join users on i_user_id = user_id where author like @searchQuery", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)admBookSearchTbxQuery).get_Text() + "%"));
			SqlDataAdapter val3 = new SqlDataAdapter(cmd);
			DataSet dataSet3 = new DataSet();
			((DataAdapter)(object)val3).Fill(dataSet3);
			admBookSearchDgv.set_DataSource((object)dataSet3.Tables[0]);
		}
	}

	private void admBookSearchBtnBack_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		admStartPage admStartPage2 = new admStartPage();
		((Control)admStartPage2).Show();
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
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected O, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		panel1 = new Panel();
		admBookSearchBtnBack = new Button();
		admBookSearchBtnLogout = new Button();
		admBookSearchBtnSearch = new Button();
		admBookSearchTbxQuery = new TextBox();
		admBookSearchRbBoth = new RadioButton();
		admBookSearchRbAuthor = new RadioButton();
		admBookSearchRbTitle = new RadioButton();
		admBookSearchLblSearch = new Label();
		admBookSearchDgv = new DataGridView();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)admBookSearchDgv).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).get_Controls().Add((Control)(object)admBookSearchBtnBack);
		((Control)panel1).get_Controls().Add((Control)(object)admBookSearchBtnLogout);
		((Control)panel1).get_Controls().Add((Control)(object)admBookSearchBtnSearch);
		((Control)panel1).get_Controls().Add((Control)(object)admBookSearchTbxQuery);
		((Control)panel1).get_Controls().Add((Control)(object)admBookSearchRbBoth);
		((Control)panel1).get_Controls().Add((Control)(object)admBookSearchRbAuthor);
		((Control)panel1).get_Controls().Add((Control)(object)admBookSearchRbTitle);
		((Control)panel1).get_Controls().Add((Control)(object)admBookSearchLblSearch);
		((Control)panel1).get_Controls().Add((Control)(object)admBookSearchDgv);
		((Control)panel1).set_Location(new Point(89, 44));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(1314, 703));
		((Control)panel1).set_TabIndex(0);
		((Control)admBookSearchBtnBack).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)admBookSearchBtnBack).set_Location(new Point(18, 22));
		((Control)admBookSearchBtnBack).set_Name("admBookSearchBtnBack");
		((Control)admBookSearchBtnBack).set_Size(new Size(75, 35));
		((Control)admBookSearchBtnBack).set_TabIndex(33);
		((Control)admBookSearchBtnBack).set_Text("Back");
		((ButtonBase)admBookSearchBtnBack).set_UseVisualStyleBackColor(true);
		((Control)admBookSearchBtnBack).add_Click((EventHandler)admBookSearchBtnBack_Click);
		((Control)admBookSearchBtnLogout).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)admBookSearchBtnLogout).set_Location(new Point(1219, 22));
		((Control)admBookSearchBtnLogout).set_Name("admBookSearchBtnLogout");
		((Control)admBookSearchBtnLogout).set_Size(new Size(75, 35));
		((Control)admBookSearchBtnLogout).set_TabIndex(32);
		((Control)admBookSearchBtnLogout).set_Text("Logout");
		((ButtonBase)admBookSearchBtnLogout).set_UseVisualStyleBackColor(true);
		((Control)admBookSearchBtnLogout).add_Click((EventHandler)admBookSearchBtnLogout_Click);
		((Control)admBookSearchBtnSearch).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admBookSearchBtnSearch).set_Location(new Point(423, 97));
		((Control)admBookSearchBtnSearch).set_Name("admBookSearchBtnSearch");
		((Control)admBookSearchBtnSearch).set_Size(new Size(88, 33));
		((Control)admBookSearchBtnSearch).set_TabIndex(30);
		((Control)admBookSearchBtnSearch).set_Text("Search");
		((ButtonBase)admBookSearchBtnSearch).set_UseVisualStyleBackColor(true);
		((Control)admBookSearchBtnSearch).add_Click((EventHandler)admBookSearchBtnSearch_Click);
		((Control)admBookSearchTbxQuery).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admBookSearchTbxQuery).set_Location(new Point(133, 72));
		((Control)admBookSearchTbxQuery).set_Name("admBookSearchTbxQuery");
		((Control)admBookSearchTbxQuery).set_Size(new Size(378, 23));
		((Control)admBookSearchTbxQuery).set_TabIndex(29);
		((Control)admBookSearchRbBoth).set_AutoSize(true);
		((Control)admBookSearchRbBoth).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admBookSearchRbBoth).set_Location(new Point(276, 101));
		((Control)admBookSearchRbBoth).set_Name("admBookSearchRbBoth");
		((Control)admBookSearchRbBoth).set_Size(new Size(61, 24));
		((Control)admBookSearchRbBoth).set_TabIndex(28);
		admBookSearchRbBoth.set_TabStop(true);
		((Control)admBookSearchRbBoth).set_Text("Both");
		((ButtonBase)admBookSearchRbBoth).set_UseVisualStyleBackColor(true);
		((Control)admBookSearchRbAuthor).set_AutoSize(true);
		((Control)admBookSearchRbAuthor).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admBookSearchRbAuthor).set_Location(new Point(195, 101));
		((Control)admBookSearchRbAuthor).set_Name("admBookSearchRbAuthor");
		((Control)admBookSearchRbAuthor).set_Size(new Size(75, 24));
		((Control)admBookSearchRbAuthor).set_TabIndex(27);
		admBookSearchRbAuthor.set_TabStop(true);
		((Control)admBookSearchRbAuthor).set_Text("Author");
		((ButtonBase)admBookSearchRbAuthor).set_UseVisualStyleBackColor(true);
		((Control)admBookSearchRbTitle).set_AutoSize(true);
		((Control)admBookSearchRbTitle).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admBookSearchRbTitle).set_Location(new Point(133, 101));
		((Control)admBookSearchRbTitle).set_Name("admBookSearchRbTitle");
		((Control)admBookSearchRbTitle).set_Size(new Size(56, 24));
		((Control)admBookSearchRbTitle).set_TabIndex(26);
		admBookSearchRbTitle.set_TabStop(true);
		((Control)admBookSearchRbTitle).set_Text("Title");
		((ButtonBase)admBookSearchRbTitle).set_UseVisualStyleBackColor(true);
		((Control)admBookSearchLblSearch).set_AutoSize(true);
		((Control)admBookSearchLblSearch).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admBookSearchLblSearch).set_Location(new Point(14, 75));
		((Control)admBookSearchLblSearch).set_Name("admBookSearchLblSearch");
		((Control)admBookSearchLblSearch).set_Size(new Size(113, 20));
		((Control)admBookSearchLblSearch).set_TabIndex(25);
		((Control)admBookSearchLblSearch).set_Text("Search Books:");
		admBookSearchDgv.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		admBookSearchDgv.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Control);
		val.set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		admBookSearchDgv.set_ColumnHeadersDefaultCellStyle(val);
		admBookSearchDgv.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)admBookSearchDgv).set_Location(new Point(20, 187));
		((Control)admBookSearchDgv).set_Name("admBookSearchDgv");
		((Control)admBookSearchDgv).set_Size(new Size(1274, 484));
		((Control)admBookSearchDgv).set_TabIndex(23);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1415, 815));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("admBookSearch");
		((Control)this).set_Text("Admin Book Search");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)admBookSearch_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((ISupportInitialize)admBookSearchDgv).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
