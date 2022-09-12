using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem;

public class admReturn : Form
{
	private SqlConnection con;

	private SqlCommand cmd;

	private IContainer components = null;

	private Button admReturnBooksBtnLogout;

	private Button admReturnBooksBtnBack;

	private Label label1;

	private Button admReturnBtnSearch;

	private TextBox admReturnTbxSearchQuery;

	private Label admBookSearchLblSearch;

	private DataGridView admReturnDgvTable;

	private Label label7;

	private Button admReturnBtnReturn;

	private TextBox admReturnTbxUserID;

	private TextBox amdReturnTbxBookID;

	private Label admReturnLblUserID;

	private Label admReturnLblBookID;

	private Panel panel1;

	private Label admReturnBooksLblFine;

	private Label label;

	public admReturn()
	{
		InitializeComponent();
	}

	private void admReturn_Load(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		string text = ((object)ConfigurationManager.get_ConnectionStrings().get_Item("LibraryManagementSystem.Properties.Settings.LibraryDB")).ToString();
		con = new SqlConnection(text);
		display();
	}

	private void clear()
	{
		((Control)admReturnTbxSearchQuery).set_Text(string.Empty);
		((Control)admReturnTbxUserID).set_Text(string.Empty);
		((Control)amdReturnTbxBookID).set_Text(string.Empty);
		((Control)admReturnBooksLblFine).set_Text(string.Empty);
	}

	public void display()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		cmd = new SqlCommand("select user_id as 'User ID', name as 'Name', book_id as 'Book ID', title as 'Title', date_issued as 'Date Issued', DATEDIFF(day, date_issued, CONVERT(date, GETDATE())) as 'Days Passed' from issue, users, books where i_user_id = user_id and i_book_id = book_id", con);
		SqlDataAdapter val = new SqlDataAdapter(cmd);
		DataSet dataSet = new DataSet();
		((DataAdapter)(object)val).Fill(dataSet);
		admReturnDgvTable.set_DataSource((object)dataSet.Tables[0]);
		admReturnDgvTable.set_ReadOnly(true);
	}

	private void admReturnDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.get_RowIndex() != -1 && e.get_RowIndex() != admReturnDgvTable.get_Rows().get_Count() - 1)
		{
			int num = Convert.ToInt32(admReturnDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(2)
				.get_Value());
			int num2 = Convert.ToInt32(admReturnDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(0)
				.get_Value());
			((Control)amdReturnTbxBookID).set_Text(Convert.ToString(num));
			((Control)admReturnTbxUserID).set_Text(Convert.ToString(num2));
			int num3 = 0;
			int num4 = Convert.ToInt32(admReturnDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(5)
				.get_Value());
			if (num4 > 15)
			{
				num3 = num4 - 15;
			}
			((Control)admReturnBooksLblFine).set_Text(Convert.ToString(num3 + " Rs."));
		}
	}

	private void admReturnBtnSearch_Click(object sender, EventArgs e)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (((DbConnection)(object)con).State == ConnectionState.Closed)
		{
			((DbConnection)(object)con).Open();
		}
		try
		{
			if (((Control)admReturnTbxSearchQuery).get_Text() == string.Empty)
			{
				display();
				return;
			}
			cmd = new SqlCommand("select user_id as 'User ID', name as 'Name', book_id as 'Book ID', title as 'Title', date_issued as 'Date Issued', DATEDIFF(day, date_issued, CONVERT(date, GETDATE())) as 'Days Passed' from issue, users, books where i_user_id = user_id and i_book_id = book_id and ( book_id = @searchQuery or user_id = @searchQuery )", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)Convert.ToInt32(((Control)admReturnTbxSearchQuery).get_Text()));
			SqlDataAdapter val = new SqlDataAdapter(cmd);
			DataSet dataSet = new DataSet();
			((DataAdapter)(object)val).Fill(dataSet);
			admReturnDgvTable.set_DataSource((object)dataSet.Tables[0]);
		}
		catch
		{
			MessageBox.Show("Please make sure that you enter only an integer in the search box.");
		}
	}

	private void admReturnBtnReturn_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		if (((DbConnection)(object)con).State == ConnectionState.Closed)
		{
			((DbConnection)(object)con).Open();
		}
		int num = 0;
		int num2 = 0;
		bool flag = true;
		try
		{
			num = int.Parse(((Control)amdReturnTbxBookID).get_Text());
		}
		catch
		{
			MessageBox.Show("Book ID should be an integer.");
			flag = false;
		}
		try
		{
			num2 = int.Parse(((Control)admReturnTbxUserID).get_Text());
		}
		catch
		{
			MessageBox.Show("User ID should be an interger.");
			flag = false;
		}
		if (!flag)
		{
			return;
		}
		try
		{
			cmd = new SqlCommand("delete from issue where i_book_id = @book_id and i_user_id = @user_id", con);
			cmd.get_Parameters().AddWithValue("@book_id", (object)num);
			cmd.get_Parameters().AddWithValue("@user_id", (object)num2);
			int num3 = ((DbCommand)(object)cmd).ExecuteNonQuery();
			if (num3 == 0)
			{
				MessageBox.Show("Please enter a valid User ID and Book ID.\nInvalid Input.");
			}
			if (num3 == 1)
			{
				MessageBox.Show("Book successfully returned.");
				clear();
				display();
			}
		}
		catch
		{
			MessageBox.Show("Internal system error.\nPlease contact the developer.");
		}
	}

	private void admReturnBooksBtnBack_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		admStartPage admStartPage2 = new admStartPage();
		((Control)admStartPage2).Show();
	}

	private void admReturnBooksBtnLogout_Click(object sender, EventArgs e)
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
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected O, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected O, but got Unknown
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected O, but got Unknown
		admReturnBooksBtnLogout = new Button();
		admReturnBooksBtnBack = new Button();
		label1 = new Label();
		admReturnBtnSearch = new Button();
		admReturnTbxSearchQuery = new TextBox();
		admBookSearchLblSearch = new Label();
		admReturnDgvTable = new DataGridView();
		label7 = new Label();
		admReturnBtnReturn = new Button();
		admReturnTbxUserID = new TextBox();
		amdReturnTbxBookID = new TextBox();
		admReturnLblUserID = new Label();
		admReturnLblBookID = new Label();
		panel1 = new Panel();
		admReturnBooksLblFine = new Label();
		label = new Label();
		((ISupportInitialize)admReturnDgvTable).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)admReturnBooksBtnLogout).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admReturnBooksBtnLogout).set_Location(new Point(717, 17));
		((Control)admReturnBooksBtnLogout).set_Name("admReturnBooksBtnLogout");
		((Control)admReturnBooksBtnLogout).set_Size(new Size(77, 30));
		((Control)admReturnBooksBtnLogout).set_TabIndex(68);
		((Control)admReturnBooksBtnLogout).set_Text("Logout");
		((ButtonBase)admReturnBooksBtnLogout).set_UseVisualStyleBackColor(true);
		((Control)admReturnBooksBtnLogout).add_Click((EventHandler)admReturnBooksBtnLogout_Click);
		((Control)admReturnBooksBtnBack).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admReturnBooksBtnBack).set_Location(new Point(25, 17));
		((Control)admReturnBooksBtnBack).set_Name("admReturnBooksBtnBack");
		((Control)admReturnBooksBtnBack).set_Size(new Size(77, 30));
		((Control)admReturnBooksBtnBack).set_TabIndex(67);
		((Control)admReturnBooksBtnBack).set_Text("Back");
		((ButtonBase)admReturnBooksBtnBack).set_UseVisualStyleBackColor(true);
		((Control)admReturnBooksBtnBack).add_Click((EventHandler)admReturnBooksBtnBack_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(317, 314));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(144, 13));
		((Control)label1).set_TabIndex(65);
		((Control)label1).set_Text("( Only books that are issued )");
		((Control)admReturnBtnSearch).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admReturnBtnSearch).set_Location(new Point(552, 264));
		((Control)admReturnBtnSearch).set_Name("admReturnBtnSearch");
		((Control)admReturnBtnSearch).set_Size(new Size(88, 33));
		((Control)admReturnBtnSearch).set_TabIndex(64);
		((Control)admReturnBtnSearch).set_Text("Search");
		((ButtonBase)admReturnBtnSearch).set_UseVisualStyleBackColor(true);
		((Control)admReturnBtnSearch).add_Click((EventHandler)admReturnBtnSearch_Click);
		((Control)admReturnTbxSearchQuery).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admReturnTbxSearchQuery).set_Location(new Point(199, 235));
		((Control)admReturnTbxSearchQuery).set_Name("admReturnTbxSearchQuery");
		((Control)admReturnTbxSearchQuery).set_Size(new Size(441, 23));
		((Control)admReturnTbxSearchQuery).set_TabIndex(63);
		((Control)admBookSearchLblSearch).set_AutoSize(true);
		((Control)admBookSearchLblSearch).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admBookSearchLblSearch).set_Location(new Point(41, 238));
		((Control)admBookSearchLblSearch).set_Name("admBookSearchLblSearch");
		((Control)admBookSearchLblSearch).set_Size(new Size(152, 20));
		((Control)admBookSearchLblSearch).set_TabIndex(59);
		((Control)admBookSearchLblSearch).set_Text("User ID or Book ID :");
		admReturnDgvTable.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)admReturnDgvTable).set_Location(new Point(25, 340));
		((Control)admReturnDgvTable).set_Name("admReturnDgvTable");
		((Control)admReturnDgvTable).set_Size(new Size(769, 405));
		((Control)admReturnDgvTable).set_TabIndex(58);
		admReturnDgvTable.add_CellClick(new DataGridViewCellEventHandler(admReturnDgvTable_CellClick));
		label7.set_BorderStyle((BorderStyle)2);
		((Control)label7).set_Location(new Point(25, 210));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(769, 2));
		((Control)label7).set_TabIndex(57);
		((Control)admReturnBtnReturn).set_Font(new Font("Microsoft Sans Serif", 15.75f));
		((Control)admReturnBtnReturn).set_Location(new Point(340, 156));
		((Control)admReturnBtnReturn).set_Name("admReturnBtnReturn");
		((Control)admReturnBtnReturn).set_Size(new Size(96, 33));
		((Control)admReturnBtnReturn).set_TabIndex(19);
		((Control)admReturnBtnReturn).set_Text("Return");
		((ButtonBase)admReturnBtnReturn).set_UseVisualStyleBackColor(true);
		((Control)admReturnBtnReturn).add_Click((EventHandler)admReturnBtnReturn_Click);
		((Control)admReturnTbxUserID).set_Font(new Font("Microsoft Sans Serif", 15.75f));
		((Control)admReturnTbxUserID).set_Location(new Point(374, 65));
		((Control)admReturnTbxUserID).set_Name("admReturnTbxUserID");
		((Control)admReturnTbxUserID).set_Size(new Size(151, 31));
		((Control)admReturnTbxUserID).set_TabIndex(18);
		((Control)amdReturnTbxBookID).set_Font(new Font("Microsoft Sans Serif", 15.75f));
		((Control)amdReturnTbxBookID).set_Location(new Point(374, 19));
		((Control)amdReturnTbxBookID).set_Name("amdReturnTbxBookID");
		((Control)amdReturnTbxBookID).set_Size(new Size(151, 31));
		((Control)amdReturnTbxBookID).set_TabIndex(17);
		((Control)admReturnLblUserID).set_AutoSize(true);
		((Control)admReturnLblUserID).set_Font(new Font("Microsoft Sans Serif", 15.75f));
		((Control)admReturnLblUserID).set_Location(new Point(267, 68));
		((Control)admReturnLblUserID).set_Name("admReturnLblUserID");
		((Control)admReturnLblUserID).set_Size(new Size(95, 25));
		((Control)admReturnLblUserID).set_TabIndex(16);
		((Control)admReturnLblUserID).set_Text("User ID: ");
		((Control)admReturnLblBookID).set_AutoSize(true);
		((Control)admReturnLblBookID).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admReturnLblBookID).set_Location(new Point(263, 22));
		((Control)admReturnLblBookID).set_Name("admReturnLblBookID");
		((Control)admReturnLblBookID).set_Size(new Size(99, 25));
		((Control)admReturnLblBookID).set_TabIndex(15);
		((Control)admReturnLblBookID).set_Text("Book ID: ");
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).get_Controls().Add((Control)(object)admReturnBooksLblFine);
		((Control)panel1).get_Controls().Add((Control)(object)label);
		((Control)panel1).get_Controls().Add((Control)(object)admReturnBooksBtnLogout);
		((Control)panel1).get_Controls().Add((Control)(object)admReturnBooksBtnBack);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)admReturnBtnSearch);
		((Control)panel1).get_Controls().Add((Control)(object)admReturnTbxSearchQuery);
		((Control)panel1).get_Controls().Add((Control)(object)admBookSearchLblSearch);
		((Control)panel1).get_Controls().Add((Control)(object)admReturnDgvTable);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)admReturnBtnReturn);
		((Control)panel1).get_Controls().Add((Control)(object)admReturnTbxUserID);
		((Control)panel1).get_Controls().Add((Control)(object)amdReturnTbxBookID);
		((Control)panel1).get_Controls().Add((Control)(object)admReturnLblUserID);
		((Control)panel1).get_Controls().Add((Control)(object)admReturnLblBookID);
		((Control)panel1).set_Location(new Point(38, 12));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(811, 767));
		((Control)panel1).set_TabIndex(1);
		((Control)admReturnBooksLblFine).set_AutoSize(true);
		((Control)admReturnBooksLblFine).set_Font(new Font("Microsoft Sans Serif", 15.75f));
		((Control)admReturnBooksLblFine).set_Location(new Point(369, 109));
		((Control)admReturnBooksLblFine).set_Name("admReturnBooksLblFine");
		((Control)admReturnBooksLblFine).set_Size(new Size(0, 25));
		((Control)admReturnBooksLblFine).set_TabIndex(70);
		((Control)label).set_AutoSize(true);
		((Control)label).set_Font(new Font("Microsoft Sans Serif", 15.75f));
		((Control)label).set_Location(new Point(290, 109));
		((Control)label).set_Name("label");
		((Control)label).set_Size(new Size(72, 25));
		((Control)label).set_TabIndex(69);
		((Control)label).set_Text("Fine : ");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(887, 791));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("admReturn");
		((Control)this).set_Text("Return Books");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)admReturn_Load);
		((ISupportInitialize)admReturnDgvTable).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
