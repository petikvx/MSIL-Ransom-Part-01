using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem;

public class admIssue : Form
{
	private SqlConnection con;

	private SqlCommand cmd;

	private IContainer components = null;

	private Panel panel1;

	private Label admIssueLblUserID;

	private Label admIssueLblBookID;

	private TextBox admIssueTbxUserID;

	private TextBox amdIssueTbxBookID;

	private Button admIssueBtnIssue;

	private Label label7;

	private DataGridView admIssueDgvTable;

	private Button admIssueBtnSearch;

	private TextBox admIssueTbxSearchQuery;

	private RadioButton admIssueRbBoth;

	private RadioButton admIssueRbAuthor;

	private RadioButton admIssueRbTitle;

	private Label admBookSearchLblSearch;

	private Label label1;

	private Button admIssueBooksBtnLogout;

	private Button admIssueBooksBtnBack;

	public admIssue()
	{
		InitializeComponent();
	}

	private void admIssue_Load(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		string text = ((object)ConfigurationManager.get_ConnectionStrings().get_Item("LibraryManagementSystem.Properties.Settings.LibraryDB")).ToString();
		con = new SqlConnection(text);
		display();
		((Control)admIssueRbBoth).Select();
	}

	public void display()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where book_id not in ( select i_book_id from issue)", con);
		SqlDataAdapter val = new SqlDataAdapter(cmd);
		DataSet dataSet = new DataSet();
		((DataAdapter)(object)val).Fill(dataSet);
		admIssueDgvTable.set_DataSource((object)dataSet.Tables[0]);
		admIssueDgvTable.set_ReadOnly(true);
	}

	public void clearFields()
	{
		((Control)admIssueTbxSearchQuery).set_Text(string.Empty);
		((Control)admIssueTbxUserID).set_Text(string.Empty);
		((Control)amdIssueTbxBookID).set_Text(string.Empty);
	}

	private void admIssueDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.get_RowIndex() != -1 && e.get_RowIndex() != admIssueDgvTable.get_Rows().get_Count() - 1)
		{
			((Control)amdIssueTbxBookID).set_Text(Convert.ToString(admIssueDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(0)
				.get_Value()));
		}
	}

	private void admIssueBtnIssue_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		if (((DbConnection)(object)con).State == ConnectionState.Closed)
		{
			((DbConnection)(object)con).Open();
		}
		int num = 0;
		int num2 = 0;
		bool flag = true;
		try
		{
			num = int.Parse(((Control)admIssueTbxUserID).get_Text());
		}
		catch
		{
			MessageBox.Show("User ID should be an integer.");
			flag = false;
		}
		try
		{
			num2 = int.Parse(((Control)amdIssueTbxBookID).get_Text());
		}
		catch
		{
			MessageBox.Show("Book ID should be an interger.");
			flag = false;
		}
		cmd = new SqlCommand("select * from issue where i_user_id = @user_id", con);
		cmd.get_Parameters().AddWithValue("@user_id", (object)num);
		SqlDataAdapter val = new SqlDataAdapter(cmd);
		DataSet dataSet = new DataSet();
		((DataAdapter)(object)val).Fill(dataSet);
		int count = dataSet.Tables[0].Rows.Count;
		if (count >= 2)
		{
			MessageBox.Show("Cannot issue more books.\nA user can only issue 2 books.");
			flag = false;
		}
		cmd = new SqlCommand("select * from issue where i_book_id = @book_id", con);
		cmd.get_Parameters().AddWithValue("@book_id", (object)num2);
		SqlDataAdapter val2 = new SqlDataAdapter(cmd);
		DataSet dataSet2 = new DataSet();
		((DataAdapter)(object)val2).Fill(dataSet2);
		int count2 = dataSet2.Tables[0].Rows.Count;
		if (count2 > 0)
		{
			MessageBox.Show("The book has already been issued by someone else.\nCannot issue book.");
			flag = false;
		}
		if (!flag)
		{
			return;
		}
		try
		{
			cmd = new SqlCommand("insert into issue values(@user_id, @book_id, CONVERT(date, GETDATE()))", con);
			cmd.get_Parameters().AddWithValue("@user_id", (object)num);
			cmd.get_Parameters().AddWithValue("@book_id", (object)num2);
			int num3 = ((DbCommand)(object)cmd).ExecuteNonQuery();
			if (num3 == 1)
			{
				MessageBox.Show("Book successfully issued.");
				display();
				clearFields();
			}
		}
		catch
		{
			MessageBox.Show("Please make sure that the the Book ID and User ID is valid.\nIf you still get an error then contact the developer.");
		}
	}

	private void admIssueBtnSearch_Click(object sender, EventArgs e)
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
		if (admIssueRbBoth.get_Checked())
		{
			cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where ( title like @searchQuery or author like @searchQuery ) and book_id not in ( select i_book_id from issue)", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)admIssueTbxSearchQuery).get_Text() + "%"));
			SqlDataAdapter val = new SqlDataAdapter(cmd);
			DataSet dataSet = new DataSet();
			((DataAdapter)(object)val).Fill(dataSet);
			admIssueDgvTable.set_DataSource((object)dataSet.Tables[0]);
		}
		else if (admIssueRbTitle.get_Checked())
		{
			cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where title like @searchQuery and book_id not in ( select i_book_id from issue)", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)admIssueTbxSearchQuery).get_Text() + "%"));
			SqlDataAdapter val2 = new SqlDataAdapter(cmd);
			DataSet dataSet2 = new DataSet();
			((DataAdapter)(object)val2).Fill(dataSet2);
			admIssueDgvTable.set_DataSource((object)dataSet2.Tables[0]);
		}
		else if (admIssueRbAuthor.get_Checked())
		{
			cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where author like @searchQuery and book_id not in ( select i_book_id from issue)", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)admIssueTbxSearchQuery).get_Text() + "%"));
			SqlDataAdapter val3 = new SqlDataAdapter(cmd);
			DataSet dataSet3 = new DataSet();
			((DataAdapter)(object)val3).Fill(dataSet3);
			admIssueDgvTable.set_DataSource((object)dataSet3.Tables[0]);
		}
	}

	private void admIssueBooksBtnBack_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		admStartPage admStartPage2 = new admStartPage();
		((Control)admStartPage2).Show();
	}

	private void admIssueBooksBtnLogout_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		login login2 = new login();
		((Control)login2).Show();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected O, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected O, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected O, but got Unknown
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected O, but got Unknown
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected O, but got Unknown
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Expected O, but got Unknown
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected O, but got Unknown
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected O, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected O, but got Unknown
		panel1 = new Panel();
		admIssueBooksBtnLogout = new Button();
		admIssueBooksBtnBack = new Button();
		label1 = new Label();
		admIssueBtnSearch = new Button();
		admIssueTbxSearchQuery = new TextBox();
		admIssueRbBoth = new RadioButton();
		admIssueRbAuthor = new RadioButton();
		admIssueRbTitle = new RadioButton();
		admBookSearchLblSearch = new Label();
		admIssueDgvTable = new DataGridView();
		label7 = new Label();
		admIssueBtnIssue = new Button();
		admIssueTbxUserID = new TextBox();
		amdIssueTbxBookID = new TextBox();
		admIssueLblUserID = new Label();
		admIssueLblBookID = new Label();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)admIssueDgvTable).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).get_Controls().Add((Control)(object)admIssueBooksBtnLogout);
		((Control)panel1).get_Controls().Add((Control)(object)admIssueBooksBtnBack);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)admIssueBtnSearch);
		((Control)panel1).get_Controls().Add((Control)(object)admIssueTbxSearchQuery);
		((Control)panel1).get_Controls().Add((Control)(object)admIssueRbBoth);
		((Control)panel1).get_Controls().Add((Control)(object)admIssueRbAuthor);
		((Control)panel1).get_Controls().Add((Control)(object)admIssueRbTitle);
		((Control)panel1).get_Controls().Add((Control)(object)admBookSearchLblSearch);
		((Control)panel1).get_Controls().Add((Control)(object)admIssueDgvTable);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)admIssueBtnIssue);
		((Control)panel1).get_Controls().Add((Control)(object)admIssueTbxUserID);
		((Control)panel1).get_Controls().Add((Control)(object)amdIssueTbxBookID);
		((Control)panel1).get_Controls().Add((Control)(object)admIssueLblUserID);
		((Control)panel1).get_Controls().Add((Control)(object)admIssueLblBookID);
		((Control)panel1).set_Location(new Point(69, 24));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(811, 711));
		((Control)panel1).set_TabIndex(0);
		((Control)admIssueBooksBtnLogout).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admIssueBooksBtnLogout).set_Location(new Point(717, 17));
		((Control)admIssueBooksBtnLogout).set_Name("admIssueBooksBtnLogout");
		((Control)admIssueBooksBtnLogout).set_Size(new Size(77, 30));
		((Control)admIssueBooksBtnLogout).set_TabIndex(68);
		((Control)admIssueBooksBtnLogout).set_Text("Logout");
		((ButtonBase)admIssueBooksBtnLogout).set_UseVisualStyleBackColor(true);
		((Control)admIssueBooksBtnLogout).add_Click((EventHandler)admIssueBooksBtnLogout_Click);
		((Control)admIssueBooksBtnBack).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admIssueBooksBtnBack).set_Location(new Point(25, 17));
		((Control)admIssueBooksBtnBack).set_Name("admIssueBooksBtnBack");
		((Control)admIssueBooksBtnBack).set_Size(new Size(77, 30));
		((Control)admIssueBooksBtnBack).set_TabIndex(67);
		((Control)admIssueBooksBtnBack).set_Text("Back");
		((ButtonBase)admIssueBooksBtnBack).set_UseVisualStyleBackColor(true);
		((Control)admIssueBooksBtnBack).add_Click((EventHandler)admIssueBooksBtnBack_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(309, 254));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(162, 13));
		((Control)label1).set_TabIndex(65);
		((Control)label1).set_Text("( Only books that are not issued )");
		((Control)admIssueBtnSearch).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admIssueBtnSearch).set_Location(new Point(552, 204));
		((Control)admIssueBtnSearch).set_Name("admIssueBtnSearch");
		((Control)admIssueBtnSearch).set_Size(new Size(88, 33));
		((Control)admIssueBtnSearch).set_TabIndex(64);
		((Control)admIssueBtnSearch).set_Text("Search");
		((ButtonBase)admIssueBtnSearch).set_UseVisualStyleBackColor(true);
		((Control)admIssueBtnSearch).add_Click((EventHandler)admIssueBtnSearch_Click);
		((Control)admIssueTbxSearchQuery).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admIssueTbxSearchQuery).set_Location(new Point(199, 175));
		((Control)admIssueTbxSearchQuery).set_Name("admIssueTbxSearchQuery");
		((Control)admIssueTbxSearchQuery).set_Size(new Size(441, 23));
		((Control)admIssueTbxSearchQuery).set_TabIndex(63);
		((Control)admIssueRbBoth).set_AutoSize(true);
		((Control)admIssueRbBoth).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admIssueRbBoth).set_Location(new Point(342, 204));
		((Control)admIssueRbBoth).set_Name("admIssueRbBoth");
		((Control)admIssueRbBoth).set_Size(new Size(61, 24));
		((Control)admIssueRbBoth).set_TabIndex(62);
		admIssueRbBoth.set_TabStop(true);
		((Control)admIssueRbBoth).set_Text("Both");
		((ButtonBase)admIssueRbBoth).set_UseVisualStyleBackColor(true);
		((Control)admIssueRbAuthor).set_AutoSize(true);
		((Control)admIssueRbAuthor).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admIssueRbAuthor).set_Location(new Point(261, 204));
		((Control)admIssueRbAuthor).set_Name("admIssueRbAuthor");
		((Control)admIssueRbAuthor).set_Size(new Size(75, 24));
		((Control)admIssueRbAuthor).set_TabIndex(61);
		admIssueRbAuthor.set_TabStop(true);
		((Control)admIssueRbAuthor).set_Text("Author");
		((ButtonBase)admIssueRbAuthor).set_UseVisualStyleBackColor(true);
		((Control)admIssueRbTitle).set_AutoSize(true);
		((Control)admIssueRbTitle).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admIssueRbTitle).set_Location(new Point(199, 204));
		((Control)admIssueRbTitle).set_Name("admIssueRbTitle");
		((Control)admIssueRbTitle).set_Size(new Size(56, 24));
		((Control)admIssueRbTitle).set_TabIndex(60);
		admIssueRbTitle.set_TabStop(true);
		((Control)admIssueRbTitle).set_Text("Title");
		((ButtonBase)admIssueRbTitle).set_UseVisualStyleBackColor(true);
		((Control)admBookSearchLblSearch).set_AutoSize(true);
		((Control)admBookSearchLblSearch).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admBookSearchLblSearch).set_Location(new Point(129, 178));
		((Control)admBookSearchLblSearch).set_Name("admBookSearchLblSearch");
		((Control)admBookSearchLblSearch).set_Size(new Size(64, 20));
		((Control)admBookSearchLblSearch).set_TabIndex(59);
		((Control)admBookSearchLblSearch).set_Text("Search:");
		admIssueDgvTable.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		admIssueDgvTable.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)admIssueDgvTable).set_Location(new Point(25, 281));
		((Control)admIssueDgvTable).set_Name("admIssueDgvTable");
		((Control)admIssueDgvTable).set_Size(new Size(769, 405));
		((Control)admIssueDgvTable).set_TabIndex(58);
		admIssueDgvTable.add_CellClick(new DataGridViewCellEventHandler(admIssueDgvTable_CellClick));
		label7.set_BorderStyle((BorderStyle)2);
		((Control)label7).set_Location(new Point(25, 147));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(769, 2));
		((Control)label7).set_TabIndex(57);
		((Control)admIssueBtnIssue).set_Font(new Font("Microsoft Sans Serif", 15.75f));
		((Control)admIssueBtnIssue).set_Location(new Point(341, 102));
		((Control)admIssueBtnIssue).set_Name("admIssueBtnIssue");
		((Control)admIssueBtnIssue).set_Size(new Size(96, 33));
		((Control)admIssueBtnIssue).set_TabIndex(19);
		((Control)admIssueBtnIssue).set_Text("Issue");
		((ButtonBase)admIssueBtnIssue).set_UseVisualStyleBackColor(true);
		((Control)admIssueBtnIssue).add_Click((EventHandler)admIssueBtnIssue_Click);
		((Control)admIssueTbxUserID).set_Font(new Font("Microsoft Sans Serif", 15.75f));
		((Control)admIssueTbxUserID).set_Location(new Point(374, 65));
		((Control)admIssueTbxUserID).set_Name("admIssueTbxUserID");
		((Control)admIssueTbxUserID).set_Size(new Size(151, 31));
		((Control)admIssueTbxUserID).set_TabIndex(18);
		((Control)amdIssueTbxBookID).set_Font(new Font("Microsoft Sans Serif", 15.75f));
		((Control)amdIssueTbxBookID).set_Location(new Point(374, 19));
		((Control)amdIssueTbxBookID).set_Name("amdIssueTbxBookID");
		((Control)amdIssueTbxBookID).set_Size(new Size(151, 31));
		((Control)amdIssueTbxBookID).set_TabIndex(17);
		((Control)admIssueLblUserID).set_AutoSize(true);
		((Control)admIssueLblUserID).set_Font(new Font("Microsoft Sans Serif", 15.75f));
		((Control)admIssueLblUserID).set_Location(new Point(267, 68));
		((Control)admIssueLblUserID).set_Name("admIssueLblUserID");
		((Control)admIssueLblUserID).set_Size(new Size(95, 25));
		((Control)admIssueLblUserID).set_TabIndex(16);
		((Control)admIssueLblUserID).set_Text("User ID: ");
		((Control)admIssueLblBookID).set_AutoSize(true);
		((Control)admIssueLblBookID).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admIssueLblBookID).set_Location(new Point(263, 22));
		((Control)admIssueLblBookID).set_Name("admIssueLblBookID");
		((Control)admIssueLblBookID).set_Size(new Size(99, 25));
		((Control)admIssueLblBookID).set_TabIndex(15);
		((Control)admIssueLblBookID).set_Text("Book ID: ");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(955, 764));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("admIssue");
		((Control)this).set_Text("Issue Books");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)admIssue_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((ISupportInitialize)admIssueDgvTable).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
