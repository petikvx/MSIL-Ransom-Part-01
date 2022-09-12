using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem;

public class admEditBookDB : Form
{
	private SqlConnection con;

	private SqlCommand cmd;

	private int selected_book_id;

	private IContainer components = null;

	private Panel panel1;

	private Button editBookDBBtnSearch;

	private TextBox editBookDBTbxSearch;

	private RadioButton admEditBookDBRbBoth;

	private RadioButton admEditBookDBRbAuthor;

	private RadioButton admEditBookDBRbTitle;

	private Label editBookDBLblSearch;

	private DataGridView editBookDBDgvTable;

	private Label label7;

	private TextBox editBookDBTbxGenres;

	private TextBox editBookDBTbxTitle;

	private TextBox editBookDBTbxAuthor;

	private TextBox editBookDBTbxPublisher;

	private TextBox editBookDBTbxYop;

	private TextBox editBookDBTbxBookID;

	private Label label6;

	private Label label5;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label1;

	private Button admEditBookDBBtnLogout;

	private Button admEditBookDBBtnBack;

	private Button editBookDBBtnDelete;

	private Button editBookDBBtnSave;

	private Button editBookDBBtnAddToDB;

	private Button admEditBookDBBtnClear;

	private void admEditBookDB_Load(object sender, EventArgs e)
	{
		displayBooks();
		((Control)admEditBookDBRbBoth).Select();
	}

	public void displayBooks()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = ((object)ConfigurationManager.get_ConnectionStrings().get_Item("LibraryManagementSystem.Properties.Settings.LibraryDB")).ToString();
		con = new SqlConnection(text);
		cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Year of Publication', genres as 'Genres' from books order by book_id asc", con);
		SqlDataAdapter val = new SqlDataAdapter(cmd);
		DataSet dataSet = new DataSet();
		((DataAdapter)(object)val).Fill(dataSet);
		editBookDBDgvTable.set_DataSource((object)dataSet.Tables[0]);
		editBookDBDgvTable.set_ReadOnly(true);
	}

	public void clearFields()
	{
		((Control)editBookDBTbxBookID).set_Text(string.Empty);
		((Control)editBookDBTbxTitle).set_Text(string.Empty);
		((Control)editBookDBTbxAuthor).set_Text(string.Empty);
		((Control)editBookDBTbxPublisher).set_Text(string.Empty);
		((Control)editBookDBTbxYop).set_Text(string.Empty);
		((Control)editBookDBTbxGenres).set_Text(string.Empty);
	}

	public admEditBookDB()
	{
		InitializeComponent();
	}

	private void admEditBookDBBtnBack_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		admStartPage admStartPage2 = new admStartPage();
		((Control)admStartPage2).Show();
	}

	private void admEditBookDBBtnLogout_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		login login2 = new login();
		((Control)login2).Show();
	}

	private void editBookDBBtnSearch_Click(object sender, EventArgs e)
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
		if (admEditBookDBRbBoth.get_Checked())
		{
			cmd = new SqlCommand("select * from books where title like @searchQuery or author like @searchQuery", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)editBookDBTbxSearch).get_Text() + "%"));
			SqlDataAdapter val = new SqlDataAdapter(cmd);
			DataSet dataSet = new DataSet();
			((DataAdapter)(object)val).Fill(dataSet);
			editBookDBDgvTable.set_DataSource((object)dataSet.Tables[0]);
		}
		else if (admEditBookDBRbTitle.get_Checked())
		{
			cmd = new SqlCommand("select * from books where title like @searchQuery", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)editBookDBTbxSearch).get_Text() + "%"));
			SqlDataAdapter val2 = new SqlDataAdapter(cmd);
			DataSet dataSet2 = new DataSet();
			((DataAdapter)(object)val2).Fill(dataSet2);
			editBookDBDgvTable.set_DataSource((object)dataSet2.Tables[0]);
		}
		else if (admEditBookDBRbAuthor.get_Checked())
		{
			cmd = new SqlCommand("select * from books where author like @searchQuery", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)editBookDBTbxSearch).get_Text() + "%"));
			SqlDataAdapter val3 = new SqlDataAdapter(cmd);
			DataSet dataSet3 = new DataSet();
			((DataAdapter)(object)val3).Fill(dataSet3);
			editBookDBDgvTable.set_DataSource((object)dataSet3.Tables[0]);
		}
	}

	private void admEditBookDBBtnClear_Click(object sender, EventArgs e)
	{
		clearFields();
	}

	private void editBookDBDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.get_RowIndex() != -1 && e.get_RowIndex() != editBookDBDgvTable.get_Rows().get_Count() - 1)
		{
			selected_book_id = Convert.ToInt32(editBookDBDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(0)
				.get_Value());
			string text = Convert.ToString(editBookDBDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(1)
				.get_Value());
			string text2 = Convert.ToString(editBookDBDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(2)
				.get_Value());
			string text3 = Convert.ToString(editBookDBDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(3)
				.get_Value());
			int num = Convert.ToInt32(editBookDBDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(4)
				.get_Value());
			string text4 = Convert.ToString(editBookDBDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(5)
				.get_Value());
			((Control)editBookDBTbxBookID).set_Text(Convert.ToString(selected_book_id));
			((Control)editBookDBTbxTitle).set_Text(text);
			((Control)editBookDBTbxAuthor).set_Text(text2);
			((Control)editBookDBTbxPublisher).set_Text(text3);
			((Control)editBookDBTbxYop).set_Text(Convert.ToString(num));
			((Control)editBookDBTbxGenres).set_Text(text4);
		}
	}

	private void editBookDBBtnSave_Click(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		bool flag = true;
		if (((DbConnection)(object)con).State == ConnectionState.Closed)
		{
			((DbConnection)(object)con).Open();
		}
		try
		{
			num = Convert.ToInt32(((Control)editBookDBTbxBookID).get_Text());
		}
		catch
		{
			MessageBox.Show("Please make sure that the BookID is an interger.");
			flag = false;
		}
		string text = ((Control)editBookDBTbxTitle).get_Text();
		string text2 = ((Control)editBookDBTbxAuthor).get_Text();
		string text3 = ((Control)editBookDBTbxPublisher).get_Text();
		try
		{
			num2 = Convert.ToInt32(((Control)editBookDBTbxYop).get_Text());
		}
		catch
		{
			MessageBox.Show("Please make sure that the Year of Publication is an interger.");
			flag = false;
		}
		string text4 = ((Control)editBookDBTbxGenres).get_Text();
		if (!flag)
		{
			return;
		}
		try
		{
			cmd = new SqlCommand("update books set book_id = @book_id, title = @title, author = @author, publisher = @publisher, year_of_pub = @year_of_pub, genres = @genres where book_id = @selected_book_id", con);
			cmd.get_Parameters().AddWithValue("@book_id", (object)num);
			cmd.get_Parameters().AddWithValue("@title", (object)text);
			cmd.get_Parameters().AddWithValue("@author", (object)text2);
			cmd.get_Parameters().AddWithValue("@publisher", (object)text3);
			cmd.get_Parameters().AddWithValue("@year_of_pub", (object)num2);
			cmd.get_Parameters().AddWithValue("@genres", (object)text4);
			cmd.get_Parameters().AddWithValue("@selected_book_id", (object)selected_book_id);
			int num3 = ((DbCommand)(object)cmd).ExecuteNonQuery();
			if (num3 == 1)
			{
				MessageBox.Show("Changes successfully saved.");
				clearFields();
			}
			displayBooks();
		}
		catch
		{
			MessageBox.Show("There is already a book with this BookID.\nBookID's have to be distinct.");
		}
	}

	private void editBookDBBtnAddToDB_Click(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		bool flag = true;
		if (((DbConnection)(object)con).State == ConnectionState.Closed)
		{
			((DbConnection)(object)con).Open();
		}
		try
		{
			num = Convert.ToInt32(((Control)editBookDBTbxBookID).get_Text());
		}
		catch
		{
			MessageBox.Show("Please make sure that the BookID is an interger.");
			flag = false;
		}
		string text = ((Control)editBookDBTbxTitle).get_Text();
		string text2 = ((Control)editBookDBTbxAuthor).get_Text();
		string text3 = ((Control)editBookDBTbxPublisher).get_Text();
		try
		{
			num2 = Convert.ToInt32(((Control)editBookDBTbxYop).get_Text());
		}
		catch
		{
			MessageBox.Show("Please make sure that the Year of Publication is an interger.");
			flag = false;
		}
		string text4 = ((Control)editBookDBTbxGenres).get_Text();
		if (!flag)
		{
			return;
		}
		try
		{
			cmd = new SqlCommand("insert into books values (@book_id, @title, @author, @publisher, @year_of_pub, @genres)", con);
			cmd.get_Parameters().AddWithValue("@book_id", (object)num);
			cmd.get_Parameters().AddWithValue("@title", (object)text);
			cmd.get_Parameters().AddWithValue("@author", (object)text2);
			cmd.get_Parameters().AddWithValue("@publisher", (object)text3);
			cmd.get_Parameters().AddWithValue("@year_of_pub", (object)num2);
			cmd.get_Parameters().AddWithValue("@genres", (object)text4);
			int num3 = ((DbCommand)(object)cmd).ExecuteNonQuery();
			if (num3 == 1)
			{
				MessageBox.Show("Book successfully added.");
				clearFields();
			}
			displayBooks();
		}
		catch
		{
			MessageBox.Show("There is already a book with this BookID.\nBookID's have to be distinct.");
		}
	}

	private void editBookDBBtnDelete_Click(object sender, EventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		bool flag = true;
		if (((DbConnection)(object)con).State == ConnectionState.Closed)
		{
			((DbConnection)(object)con).Open();
		}
		try
		{
			num = Convert.ToInt32(((Control)editBookDBTbxBookID).get_Text());
		}
		catch
		{
			MessageBox.Show("Please make sure that the BookID is an interger.");
			flag = false;
		}
		if (!flag)
		{
			return;
		}
		try
		{
			cmd = new SqlCommand("delete from books where book_id = @book_id", con);
			cmd.get_Parameters().AddWithValue("@book_id", (object)num);
			int num2 = ((DbCommand)(object)cmd).ExecuteNonQuery();
			if (num2 == 1)
			{
				MessageBox.Show("Book successfully deleted.");
				clearFields();
			}
			displayBooks();
		}
		catch
		{
			MessageBox.Show("Cannot delete an issued book.\nPlease make sure the book is not issued to a student before deleting it.");
		}
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
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected O, but got Unknown
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected O, but got Unknown
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected O, but got Unknown
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected O, but got Unknown
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected O, but got Unknown
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected O, but got Unknown
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Expected O, but got Unknown
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected O, but got Unknown
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected O, but got Unknown
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b64: Expected O, but got Unknown
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Expected O, but got Unknown
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected O, but got Unknown
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Expected O, but got Unknown
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Expected O, but got Unknown
		//IL_0d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d72: Expected O, but got Unknown
		//IL_0de6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df0: Expected O, but got Unknown
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6e: Expected O, but got Unknown
		//IL_0ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eec: Expected O, but got Unknown
		//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6d: Expected O, but got Unknown
		//IL_0fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff1: Expected O, but got Unknown
		//IL_1059: Unknown result type (might be due to invalid IL or missing references)
		//IL_1063: Expected O, but got Unknown
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f8: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		panel1 = new Panel();
		admEditBookDBBtnClear = new Button();
		editBookDBBtnAddToDB = new Button();
		editBookDBBtnDelete = new Button();
		editBookDBBtnSave = new Button();
		editBookDBBtnSearch = new Button();
		editBookDBTbxSearch = new TextBox();
		admEditBookDBRbBoth = new RadioButton();
		admEditBookDBRbAuthor = new RadioButton();
		admEditBookDBRbTitle = new RadioButton();
		editBookDBLblSearch = new Label();
		editBookDBDgvTable = new DataGridView();
		label7 = new Label();
		editBookDBTbxGenres = new TextBox();
		editBookDBTbxTitle = new TextBox();
		editBookDBTbxAuthor = new TextBox();
		editBookDBTbxPublisher = new TextBox();
		editBookDBTbxYop = new TextBox();
		editBookDBTbxBookID = new TextBox();
		label6 = new Label();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		admEditBookDBBtnLogout = new Button();
		admEditBookDBBtnBack = new Button();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)editBookDBDgvTable).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).get_Controls().Add((Control)(object)admEditBookDBBtnClear);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBBtnAddToDB);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBBtnDelete);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBBtnSave);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBBtnSearch);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBTbxSearch);
		((Control)panel1).get_Controls().Add((Control)(object)admEditBookDBRbBoth);
		((Control)panel1).get_Controls().Add((Control)(object)admEditBookDBRbAuthor);
		((Control)panel1).get_Controls().Add((Control)(object)admEditBookDBRbTitle);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBLblSearch);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBDgvTable);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBTbxGenres);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBTbxTitle);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBTbxAuthor);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBTbxPublisher);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBTbxYop);
		((Control)panel1).get_Controls().Add((Control)(object)editBookDBTbxBookID);
		((Control)panel1).get_Controls().Add((Control)(object)label6);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)admEditBookDBBtnLogout);
		((Control)panel1).get_Controls().Add((Control)(object)admEditBookDBBtnBack);
		((Control)panel1).set_Location(new Point(39, 5));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(1181, 771));
		((Control)panel1).set_TabIndex(0);
		((Control)admEditBookDBBtnClear).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admEditBookDBBtnClear).set_Location(new Point(880, 564));
		((Control)admEditBookDBBtnClear).set_Name("admEditBookDBBtnClear");
		((Control)admEditBookDBBtnClear).set_Size(new Size(131, 39));
		((Control)admEditBookDBBtnClear).set_TabIndex(67);
		((Control)admEditBookDBBtnClear).set_Text("Clear Boxes");
		((ButtonBase)admEditBookDBBtnClear).set_UseVisualStyleBackColor(true);
		((Control)admEditBookDBBtnClear).add_Click((EventHandler)admEditBookDBBtnClear_Click);
		((Control)editBookDBBtnAddToDB).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)editBookDBBtnAddToDB).set_Location(new Point(264, 654));
		((Control)editBookDBBtnAddToDB).set_Name("editBookDBBtnAddToDB");
		((Control)editBookDBBtnAddToDB).set_Size(new Size(149, 54));
		((Control)editBookDBBtnAddToDB).set_TabIndex(56);
		((Control)editBookDBBtnAddToDB).set_Text("Add to DB");
		((ButtonBase)editBookDBBtnAddToDB).set_UseVisualStyleBackColor(true);
		((Control)editBookDBBtnAddToDB).add_Click((EventHandler)editBookDBBtnAddToDB_Click);
		((Control)editBookDBBtnDelete).set_Font(new Font("Microsoft Sans Serif", 18f));
		((Control)editBookDBBtnDelete).set_Location(new Point(726, 654));
		((Control)editBookDBBtnDelete).set_Name("editBookDBBtnDelete");
		((Control)editBookDBBtnDelete).set_Size(new Size(147, 54));
		((Control)editBookDBBtnDelete).set_TabIndex(56);
		((Control)editBookDBBtnDelete).set_Text("Delete");
		((ButtonBase)editBookDBBtnDelete).set_UseVisualStyleBackColor(true);
		((Control)editBookDBBtnDelete).add_Click((EventHandler)editBookDBBtnDelete_Click);
		((Control)editBookDBBtnSave).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)editBookDBBtnSave).set_Location(new Point(501, 654));
		((Control)editBookDBBtnSave).set_Name("editBookDBBtnSave");
		((Control)editBookDBBtnSave).set_Size(new Size(142, 54));
		((Control)editBookDBBtnSave).set_TabIndex(56);
		((Control)editBookDBBtnSave).set_Text("Save Edit");
		((ButtonBase)editBookDBBtnSave).set_UseVisualStyleBackColor(true);
		((Control)editBookDBBtnSave).add_Click((EventHandler)editBookDBBtnSave_Click);
		((Control)editBookDBBtnSearch).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)editBookDBBtnSearch).set_Location(new Point(689, 148));
		((Control)editBookDBBtnSearch).set_Name("editBookDBBtnSearch");
		((Control)editBookDBBtnSearch).set_Size(new Size(88, 33));
		((Control)editBookDBBtnSearch).set_TabIndex(2);
		((Control)editBookDBBtnSearch).set_Text("Search");
		((ButtonBase)editBookDBBtnSearch).set_UseVisualStyleBackColor(true);
		((Control)editBookDBBtnSearch).add_Click((EventHandler)editBookDBBtnSearch_Click);
		((Control)editBookDBTbxSearch).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)editBookDBTbxSearch).set_Location(new Point(175, 119));
		((Control)editBookDBTbxSearch).set_Name("editBookDBTbxSearch");
		((Control)editBookDBTbxSearch).set_Size(new Size(602, 23));
		((Control)editBookDBTbxSearch).set_TabIndex(1);
		((Control)admEditBookDBRbBoth).set_AutoSize(true);
		((Control)admEditBookDBRbBoth).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admEditBookDBRbBoth).set_Location(new Point(318, 148));
		((Control)admEditBookDBRbBoth).set_Name("admEditBookDBRbBoth");
		((Control)admEditBookDBRbBoth).set_Size(new Size(61, 24));
		((Control)admEditBookDBRbBoth).set_TabIndex(61);
		admEditBookDBRbBoth.set_TabStop(true);
		((Control)admEditBookDBRbBoth).set_Text("Both");
		((ButtonBase)admEditBookDBRbBoth).set_UseVisualStyleBackColor(true);
		((Control)admEditBookDBRbAuthor).set_AutoSize(true);
		((Control)admEditBookDBRbAuthor).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admEditBookDBRbAuthor).set_Location(new Point(237, 148));
		((Control)admEditBookDBRbAuthor).set_Name("admEditBookDBRbAuthor");
		((Control)admEditBookDBRbAuthor).set_Size(new Size(75, 24));
		((Control)admEditBookDBRbAuthor).set_TabIndex(60);
		admEditBookDBRbAuthor.set_TabStop(true);
		((Control)admEditBookDBRbAuthor).set_Text("Author");
		((ButtonBase)admEditBookDBRbAuthor).set_UseVisualStyleBackColor(true);
		((Control)admEditBookDBRbTitle).set_AutoSize(true);
		((Control)admEditBookDBRbTitle).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admEditBookDBRbTitle).set_Location(new Point(175, 148));
		((Control)admEditBookDBRbTitle).set_Name("admEditBookDBRbTitle");
		((Control)admEditBookDBRbTitle).set_Size(new Size(56, 24));
		((Control)admEditBookDBRbTitle).set_TabIndex(59);
		admEditBookDBRbTitle.set_TabStop(true);
		((Control)admEditBookDBRbTitle).set_Text("Title");
		((ButtonBase)admEditBookDBRbTitle).set_UseVisualStyleBackColor(true);
		((Control)editBookDBLblSearch).set_AutoSize(true);
		((Control)editBookDBLblSearch).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)editBookDBLblSearch).set_Location(new Point(99, 122));
		((Control)editBookDBLblSearch).set_Name("editBookDBLblSearch");
		((Control)editBookDBLblSearch).set_Size(new Size(64, 20));
		((Control)editBookDBLblSearch).set_TabIndex(58);
		((Control)editBookDBLblSearch).set_Text("Search:");
		editBookDBDgvTable.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		editBookDBDgvTable.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Control);
		val.set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		editBookDBDgvTable.set_ColumnHeadersDefaultCellStyle(val);
		editBookDBDgvTable.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)editBookDBDgvTable).set_Location(new Point(102, 206));
		((Control)editBookDBDgvTable).set_Name("editBookDBDgvTable");
		((Control)editBookDBDgvTable).set_Size(new Size(969, 169));
		((Control)editBookDBDgvTable).set_TabIndex(57);
		editBookDBDgvTable.add_CellClick(new DataGridViewCellEventHandler(editBookDBDgvTable_CellClick));
		label7.set_BorderStyle((BorderStyle)2);
		((Control)label7).set_Location(new Point(102, 416));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(969, 2));
		((Control)label7).set_TabIndex(56);
		((Control)editBookDBTbxGenres).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)editBookDBTbxGenres).set_Location(new Point(186, 573));
		((Control)editBookDBTbxGenres).set_Name("editBookDBTbxGenres");
		((Control)editBookDBTbxGenres).set_Size(new Size(514, 23));
		((Control)editBookDBTbxGenres).set_TabIndex(53);
		((Control)editBookDBTbxTitle).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)editBookDBTbxTitle).set_Location(new Point(186, 492));
		((Control)editBookDBTbxTitle).set_Name("editBookDBTbxTitle");
		((Control)editBookDBTbxTitle).set_Size(new Size(514, 23));
		((Control)editBookDBTbxTitle).set_TabIndex(51);
		((Control)editBookDBTbxAuthor).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)editBookDBTbxAuthor).set_Location(new Point(880, 495));
		((Control)editBookDBTbxAuthor).set_Name("editBookDBTbxAuthor");
		((Control)editBookDBTbxAuthor).set_Size(new Size(200, 23));
		((Control)editBookDBTbxAuthor).set_TabIndex(54);
		((Control)editBookDBTbxPublisher).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)editBookDBTbxPublisher).set_Location(new Point(186, 530));
		((Control)editBookDBTbxPublisher).set_Name("editBookDBTbxPublisher");
		((Control)editBookDBTbxPublisher).set_Size(new Size(514, 23));
		((Control)editBookDBTbxPublisher).set_TabIndex(52);
		((Control)editBookDBTbxYop).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)editBookDBTbxYop).set_Location(new Point(965, 533));
		((Control)editBookDBTbxYop).set_Name("editBookDBTbxYop");
		((Control)editBookDBTbxYop).set_Size(new Size(115, 23));
		((Control)editBookDBTbxYop).set_TabIndex(55);
		((Control)editBookDBTbxBookID).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)editBookDBTbxBookID).set_Location(new Point(186, 458));
		((Control)editBookDBTbxBookID).set_Name("editBookDBTbxBookID");
		((Control)editBookDBTbxBookID).set_Size(new Size(79, 23));
		((Control)editBookDBTbxBookID).set_TabIndex(50);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)label6).set_Location(new Point(98, 530));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(82, 20));
		((Control)label6).set_TabIndex(49);
		((Control)label6).set_Text("Publisher :");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)label5).set_Location(new Point(99, 458));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(75, 20));
		((Control)label5).set_TabIndex(48);
		((Control)label5).set_Text("Book ID :");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)label4).set_Location(new Point(98, 573));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(70, 20));
		((Control)label4).set_TabIndex(47);
		((Control)label4).set_Text("Genres :");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)label3).set_Location(new Point(795, 495));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(65, 20));
		((Control)label3).set_TabIndex(46);
		((Control)label3).set_Text("Author :");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)label2).set_Location(new Point(795, 533));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(150, 20));
		((Control)label2).set_TabIndex(45);
		((Control)label2).set_Text("Year of Publication :");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)label1).set_Location(new Point(99, 495));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(46, 20));
		((Control)label1).set_TabIndex(44);
		((Control)label1).set_Text("Title :");
		((Control)admEditBookDBBtnLogout).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)admEditBookDBBtnLogout).set_Location(new Point(996, 80));
		((Control)admEditBookDBBtnLogout).set_Name("admEditBookDBBtnLogout");
		((Control)admEditBookDBBtnLogout).set_Size(new Size(75, 35));
		((Control)admEditBookDBBtnLogout).set_TabIndex(43);
		((Control)admEditBookDBBtnLogout).set_Text("Logout");
		((ButtonBase)admEditBookDBBtnLogout).set_UseVisualStyleBackColor(true);
		((Control)admEditBookDBBtnLogout).add_Click((EventHandler)admEditBookDBBtnLogout_Click);
		((Control)admEditBookDBBtnBack).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)admEditBookDBBtnBack).set_Location(new Point(99, 63));
		((Control)admEditBookDBBtnBack).set_Name("admEditBookDBBtnBack");
		((Control)admEditBookDBBtnBack).set_Size(new Size(82, 35));
		((Control)admEditBookDBBtnBack).set_TabIndex(42);
		((Control)admEditBookDBBtnBack).set_Text("Back");
		((ButtonBase)admEditBookDBBtnBack).set_UseVisualStyleBackColor(true);
		((Control)admEditBookDBBtnBack).add_Click((EventHandler)admEditBookDBBtnBack_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1253, 845));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("admEditBookDB");
		((Control)this).set_Text("Edit Book DB");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)admEditBookDB_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((ISupportInitialize)editBookDBDgvTable).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
