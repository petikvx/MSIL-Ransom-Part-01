using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem;

public class admEditStudentDB : Form
{
	private SqlConnection con;

	private SqlCommand cmd;

	private int selected_user_id;

	private IContainer components = null;

	private Button editStudentDBBtnDelete;

	private Button editStudentDBBtnSave;

	private Button editStudentDBBtnSearch;

	private TextBox editStudentDBTbxSearch;

	private Label userBookSearchLblSearch;

	private DataGridView editStudentDBDgvTable;

	private TextBox editStudentDBTbxEmail;

	private TextBox admStudentDBTbxName;

	private Panel panel1;

	private Label label7;

	private TextBox editStudentDBTbxAddress;

	private TextBox editStudentDBTbxPassword;

	private TextBox editStudentDBTbxUserID;

	private Label label6;

	private Label label5;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button editStudentDBBtnLogout;

	private Button editStudentDBBtnBack;

	private Button editStudentDBBtnAddToDB;

	private Button admEditStudentDBBtnClear;

	private CheckBox admStudentDBCbAdmin;

	private void admEditStudentDB_Load(object sender, EventArgs e)
	{
		displayUsers();
	}

	public admEditStudentDB()
	{
		InitializeComponent();
	}

	public void displayUsers()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = ((object)ConfigurationManager.get_ConnectionStrings().get_Item("LibraryManagementSystem.Properties.Settings.LibraryDB")).ToString();
		con = new SqlConnection(text);
		cmd = new SqlCommand("select user_id as 'User ID', admin as 'Admin ?', name as 'Name', address as 'Address', password as 'Password', email as 'E-mail' from users order by user_id asc", con);
		SqlDataAdapter val = new SqlDataAdapter(cmd);
		DataSet dataSet = new DataSet();
		((DataAdapter)(object)val).Fill(dataSet);
		editStudentDBDgvTable.set_DataSource((object)dataSet.Tables[0]);
		editStudentDBDgvTable.set_ReadOnly(true);
		editStudentDBDgvTable.get_Columns().get_Item(1).set_SortMode((DataGridViewColumnSortMode)1);
	}

	public void clearFields()
	{
		((Control)editStudentDBTbxUserID).set_Text(string.Empty);
		((Control)admStudentDBTbxName).set_Text(string.Empty);
		((Control)editStudentDBTbxAddress).set_Text(string.Empty);
		((Control)editStudentDBTbxPassword).set_Text(string.Empty);
		((Control)editStudentDBTbxEmail).set_Text(string.Empty);
		admStudentDBCbAdmin.set_Checked(false);
	}

	private void editStudentDBBtnBack_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		admStartPage admStartPage2 = new admStartPage();
		((Control)admStartPage2).Show();
	}

	private void editStudentDBBtnLogout_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		login login2 = new login();
		((Control)login2).Show();
	}

	private void editStudentDBBtnSearch_Click(object sender, EventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		if (((DbConnection)(object)con).State == ConnectionState.Closed)
		{
			((DbConnection)(object)con).Open();
		}
		try
		{
			int num = int.Parse(((Control)editStudentDBTbxSearch).get_Text());
			cmd = new SqlCommand("select user_id as 'User ID', admin as 'Admin ?', name as 'Name', address as 'Address', password as 'Password', email as 'E-mail' from users where user_id = @searchQuery", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)num);
		}
		catch
		{
			cmd = new SqlCommand("select user_id as 'User ID', admin as 'Admin ?', name as 'Name', address as 'Address', password as 'Password', email as 'E-mail' from users where name like @searchQuery", con);
			cmd.get_Parameters().AddWithValue("@searchQuery", (object)("%" + ((Control)editStudentDBTbxSearch).get_Text() + "%"));
		}
		SqlDataAdapter val = new SqlDataAdapter(cmd);
		DataSet dataSet = new DataSet();
		((DataAdapter)(object)val).Fill(dataSet);
		editStudentDBDgvTable.set_DataSource((object)dataSet.Tables[0]);
	}

	private void editStudentDBDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.get_RowIndex() != -1 && e.get_RowIndex() != editStudentDBDgvTable.get_Rows().get_Count() - 1)
		{
			selected_user_id = Convert.ToInt32(editStudentDBDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(0)
				.get_Value());
			bool @checked = Convert.ToBoolean(editStudentDBDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(1)
				.get_Value());
			string text = Convert.ToString(editStudentDBDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(2)
				.get_Value());
			string text2 = Convert.ToString(editStudentDBDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(3)
				.get_Value());
			string text3 = Convert.ToString(editStudentDBDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(4)
				.get_Value());
			string text4 = Convert.ToString(editStudentDBDgvTable.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(5)
				.get_Value());
			((Control)editStudentDBTbxUserID).set_Text(Convert.ToString(selected_user_id));
			admStudentDBCbAdmin.set_Checked(@checked);
			((Control)admStudentDBTbxName).set_Text(text);
			((Control)editStudentDBTbxAddress).set_Text(text2);
			((Control)editStudentDBTbxPassword).set_Text(text3);
			((Control)editStudentDBTbxEmail).set_Text(text4);
		}
	}

	private void admEditStudentDBBtnClear_Click(object sender, EventArgs e)
	{
		clearFields();
	}

	private void editStudentDBBtnSave_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		bool flag = true;
		if (((DbConnection)(object)con).State == ConnectionState.Closed)
		{
			((DbConnection)(object)con).Open();
		}
		try
		{
			num = Convert.ToInt32(((Control)editStudentDBTbxUserID).get_Text());
		}
		catch
		{
			MessageBox.Show("Please make sure that the UserID is an interger.");
			flag = false;
		}
		bool @checked = admStudentDBCbAdmin.get_Checked();
		string text = ((Control)admStudentDBTbxName).get_Text();
		string text2 = ((Control)editStudentDBTbxAddress).get_Text();
		string text3 = ((Control)editStudentDBTbxPassword).get_Text();
		string text4 = ((Control)editStudentDBTbxEmail).get_Text();
		if (!flag)
		{
			return;
		}
		try
		{
			cmd = new SqlCommand("update users set user_id = @user_id, admin = @admin, name = @name, address = @address, password = @password, email = @email where user_id = @selected_user_id", con);
			cmd.get_Parameters().AddWithValue("@user_id", (object)num);
			cmd.get_Parameters().AddWithValue("@admin", (object)@checked);
			cmd.get_Parameters().AddWithValue("@name", (object)text);
			cmd.get_Parameters().AddWithValue("@address", (object)text2);
			cmd.get_Parameters().AddWithValue("@password", (object)text3);
			cmd.get_Parameters().AddWithValue("@email", (object)text4);
			cmd.get_Parameters().AddWithValue("@selected_user_id", (object)selected_user_id);
			int num2 = ((DbCommand)(object)cmd).ExecuteNonQuery();
			if (num2 == 1)
			{
				MessageBox.Show("Changes successfully saved.");
				clearFields();
			}
			displayUsers();
		}
		catch
		{
			MessageBox.Show("There is already a user with this UserID.\nUserID's have to be distinct.");
		}
	}

	private void editStudentDBBtnAddToDB_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		bool flag = true;
		if (((DbConnection)(object)con).State == ConnectionState.Closed)
		{
			((DbConnection)(object)con).Open();
		}
		try
		{
			num = Convert.ToInt32(((Control)editStudentDBTbxUserID).get_Text());
		}
		catch
		{
			MessageBox.Show("Please make sure that the UserID is an interger.");
			flag = false;
		}
		bool @checked = admStudentDBCbAdmin.get_Checked();
		string text = ((Control)admStudentDBTbxName).get_Text();
		string text2 = ((Control)editStudentDBTbxAddress).get_Text();
		string text3 = ((Control)editStudentDBTbxPassword).get_Text();
		string text4 = ((Control)editStudentDBTbxEmail).get_Text();
		if (!flag)
		{
			return;
		}
		try
		{
			cmd = new SqlCommand("insert into users values(@user_id, @admin, @name, @address, @password, @email) ", con);
			cmd.get_Parameters().AddWithValue("@user_id", (object)num);
			cmd.get_Parameters().AddWithValue("@admin", (object)@checked);
			cmd.get_Parameters().AddWithValue("@name", (object)text);
			cmd.get_Parameters().AddWithValue("@address", (object)text2);
			cmd.get_Parameters().AddWithValue("@password", (object)text3);
			cmd.get_Parameters().AddWithValue("@email", (object)text4);
			int num2 = ((DbCommand)(object)cmd).ExecuteNonQuery();
			if (num2 == 1)
			{
				MessageBox.Show("User successfully added.");
				clearFields();
			}
			displayUsers();
		}
		catch
		{
			MessageBox.Show("There is already a user with this UserID.\nUserID's have to be distinct.");
		}
	}

	private void editStudentDBBtnDelete_Click(object sender, EventArgs e)
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
			num = Convert.ToInt32(((Control)editStudentDBTbxUserID).get_Text());
		}
		catch
		{
			MessageBox.Show("Please make sure that the UserID is an interger.");
			flag = false;
		}
		if (!flag)
		{
			return;
		}
		try
		{
			cmd = new SqlCommand("delete from users where user_id = @user_id", con);
			cmd.get_Parameters().AddWithValue("@user_id", (object)num);
			int num2 = ((DbCommand)(object)cmd).ExecuteNonQuery();
			if (num2 == 1)
			{
				MessageBox.Show("User successfully deleted.");
				clearFields();
			}
			displayUsers();
		}
		catch
		{
			MessageBox.Show("Cannot delete a user with an issued book.\nPlease make sure that he has returned the book before deleting him.");
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
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected O, but got Unknown
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected O, but got Unknown
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected O, but got Unknown
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a04: Expected O, but got Unknown
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected O, but got Unknown
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Expected O, but got Unknown
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected O, but got Unknown
		//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected O, but got Unknown
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Expected O, but got Unknown
		//IL_0cb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Expected O, but got Unknown
		//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d43: Expected O, but got Unknown
		//IL_0dab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db5: Expected O, but got Unknown
		//IL_0e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4a: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		editStudentDBBtnDelete = new Button();
		editStudentDBBtnSave = new Button();
		editStudentDBBtnSearch = new Button();
		editStudentDBTbxSearch = new TextBox();
		userBookSearchLblSearch = new Label();
		editStudentDBDgvTable = new DataGridView();
		editStudentDBTbxEmail = new TextBox();
		admStudentDBTbxName = new TextBox();
		panel1 = new Panel();
		admStudentDBCbAdmin = new CheckBox();
		admEditStudentDBBtnClear = new Button();
		editStudentDBBtnAddToDB = new Button();
		label7 = new Label();
		editStudentDBTbxAddress = new TextBox();
		editStudentDBTbxPassword = new TextBox();
		editStudentDBTbxUserID = new TextBox();
		label6 = new Label();
		label5 = new Label();
		label4 = new Label();
		label2 = new Label();
		label1 = new Label();
		editStudentDBBtnLogout = new Button();
		editStudentDBBtnBack = new Button();
		((ISupportInitialize)editStudentDBDgvTable).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)editStudentDBBtnDelete).set_Font(new Font("Microsoft Sans Serif", 18f));
		((Control)editStudentDBBtnDelete).set_Location(new Point(745, 654));
		((Control)editStudentDBBtnDelete).set_Name("editStudentDBBtnDelete");
		((Control)editStudentDBBtnDelete).set_Size(new Size(125, 54));
		((Control)editStudentDBBtnDelete).set_TabIndex(65);
		((Control)editStudentDBBtnDelete).set_Text("Delete");
		((ButtonBase)editStudentDBBtnDelete).set_UseVisualStyleBackColor(true);
		((Control)editStudentDBBtnDelete).add_Click((EventHandler)editStudentDBBtnDelete_Click);
		((Control)editStudentDBBtnSave).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)editStudentDBBtnSave).set_Location(new Point(485, 654));
		((Control)editStudentDBBtnSave).set_Name("editStudentDBBtnSave");
		((Control)editStudentDBBtnSave).set_Size(new Size(142, 54));
		((Control)editStudentDBBtnSave).set_TabIndex(64);
		((Control)editStudentDBBtnSave).set_Text("Save Edit");
		((ButtonBase)editStudentDBBtnSave).set_UseVisualStyleBackColor(true);
		((Control)editStudentDBBtnSave).add_Click((EventHandler)editStudentDBBtnSave_Click);
		((Control)editStudentDBBtnSearch).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)editStudentDBBtnSearch).set_Location(new Point(689, 148));
		((Control)editStudentDBBtnSearch).set_Name("editStudentDBBtnSearch");
		((Control)editStudentDBBtnSearch).set_Size(new Size(88, 33));
		((Control)editStudentDBBtnSearch).set_TabIndex(63);
		((Control)editStudentDBBtnSearch).set_Text("Search");
		((ButtonBase)editStudentDBBtnSearch).set_UseVisualStyleBackColor(true);
		((Control)editStudentDBBtnSearch).add_Click((EventHandler)editStudentDBBtnSearch_Click);
		((Control)editStudentDBTbxSearch).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)editStudentDBTbxSearch).set_Location(new Point(261, 119));
		((Control)editStudentDBTbxSearch).set_Name("editStudentDBTbxSearch");
		((Control)editStudentDBTbxSearch).set_Size(new Size(516, 23));
		((Control)editStudentDBTbxSearch).set_TabIndex(62);
		((Control)userBookSearchLblSearch).set_AutoSize(true);
		((Control)userBookSearchLblSearch).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)userBookSearchLblSearch).set_Location(new Point(99, 122));
		((Control)userBookSearchLblSearch).set_Name("userBookSearchLblSearch");
		((Control)userBookSearchLblSearch).set_Size(new Size(156, 20));
		((Control)userBookSearchLblSearch).set_TabIndex(58);
		((Control)userBookSearchLblSearch).set_Text("Search (name or id) :");
		editStudentDBDgvTable.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		editStudentDBDgvTable.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Control);
		val.set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		editStudentDBDgvTable.set_ColumnHeadersDefaultCellStyle(val);
		editStudentDBDgvTable.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)editStudentDBDgvTable).set_Location(new Point(102, 206));
		((Control)editStudentDBDgvTable).set_Name("editStudentDBDgvTable");
		((Control)editStudentDBDgvTable).set_Size(new Size(969, 169));
		((Control)editStudentDBDgvTable).set_TabIndex(57);
		editStudentDBDgvTable.add_CellClick(new DataGridViewCellEventHandler(editStudentDBDgvTable_CellClick));
		((Control)editStudentDBTbxEmail).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)editStudentDBTbxEmail).set_Location(new Point(427, 573));
		((Control)editStudentDBTbxEmail).set_Name("editStudentDBTbxEmail");
		((Control)editStudentDBTbxEmail).set_Size(new Size(479, 23));
		((Control)editStudentDBTbxEmail).set_TabIndex(55);
		((Control)admStudentDBTbxName).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)admStudentDBTbxName).set_Location(new Point(186, 492));
		((Control)admStudentDBTbxName).set_Name("admStudentDBTbxName");
		((Control)admStudentDBTbxName).set_Size(new Size(514, 23));
		((Control)admStudentDBTbxName).set_TabIndex(54);
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).get_Controls().Add((Control)(object)admStudentDBCbAdmin);
		((Control)panel1).get_Controls().Add((Control)(object)admEditStudentDBBtnClear);
		((Control)panel1).get_Controls().Add((Control)(object)editStudentDBBtnAddToDB);
		((Control)panel1).get_Controls().Add((Control)(object)editStudentDBBtnDelete);
		((Control)panel1).get_Controls().Add((Control)(object)editStudentDBBtnSave);
		((Control)panel1).get_Controls().Add((Control)(object)editStudentDBBtnSearch);
		((Control)panel1).get_Controls().Add((Control)(object)editStudentDBTbxSearch);
		((Control)panel1).get_Controls().Add((Control)(object)userBookSearchLblSearch);
		((Control)panel1).get_Controls().Add((Control)(object)editStudentDBDgvTable);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)editStudentDBTbxEmail);
		((Control)panel1).get_Controls().Add((Control)(object)admStudentDBTbxName);
		((Control)panel1).get_Controls().Add((Control)(object)editStudentDBTbxAddress);
		((Control)panel1).get_Controls().Add((Control)(object)editStudentDBTbxPassword);
		((Control)panel1).get_Controls().Add((Control)(object)editStudentDBTbxUserID);
		((Control)panel1).get_Controls().Add((Control)(object)label6);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)editStudentDBBtnLogout);
		((Control)panel1).get_Controls().Add((Control)(object)editStudentDBBtnBack);
		((Control)panel1).set_Location(new Point(39, 12));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(1181, 717));
		((Control)panel1).set_TabIndex(1);
		((Control)admStudentDBCbAdmin).set_AutoSize(true);
		((Control)admStudentDBCbAdmin).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)admStudentDBCbAdmin).set_Location(new Point(799, 495));
		((Control)admStudentDBCbAdmin).set_Name("admStudentDBCbAdmin");
		((Control)admStudentDBCbAdmin).set_Size(new Size(73, 24));
		((Control)admStudentDBCbAdmin).set_TabIndex(69);
		((Control)admStudentDBCbAdmin).set_Text("Admin");
		((ButtonBase)admStudentDBCbAdmin).set_UseVisualStyleBackColor(true);
		((Control)admEditStudentDBBtnClear).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admEditStudentDBBtnClear).set_Location(new Point(940, 586));
		((Control)admEditStudentDBBtnClear).set_Name("admEditStudentDBBtnClear");
		((Control)admEditStudentDBBtnClear).set_Size(new Size(131, 39));
		((Control)admEditStudentDBBtnClear).set_TabIndex(68);
		((Control)admEditStudentDBBtnClear).set_Text("Clear Values");
		((ButtonBase)admEditStudentDBBtnClear).set_UseVisualStyleBackColor(true);
		((Control)admEditStudentDBBtnClear).add_Click((EventHandler)admEditStudentDBBtnClear_Click);
		((Control)editStudentDBBtnAddToDB).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)editStudentDBBtnAddToDB).set_Location(new Point(251, 654));
		((Control)editStudentDBBtnAddToDB).set_Name("editStudentDBBtnAddToDB");
		((Control)editStudentDBBtnAddToDB).set_Size(new Size(149, 54));
		((Control)editStudentDBBtnAddToDB).set_TabIndex(67);
		((Control)editStudentDBBtnAddToDB).set_Text("Add to DB");
		((ButtonBase)editStudentDBBtnAddToDB).set_UseVisualStyleBackColor(true);
		((Control)editStudentDBBtnAddToDB).add_Click((EventHandler)editStudentDBBtnAddToDB_Click);
		label7.set_BorderStyle((BorderStyle)2);
		((Control)label7).set_Location(new Point(102, 416));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(969, 2));
		((Control)label7).set_TabIndex(56);
		((Control)editStudentDBTbxAddress).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)editStudentDBTbxAddress).set_Location(new Point(186, 530));
		((Control)editStudentDBTbxAddress).set_Name("editStudentDBTbxAddress");
		((Control)editStudentDBTbxAddress).set_Size(new Size(514, 23));
		((Control)editStudentDBTbxAddress).set_TabIndex(52);
		((Control)editStudentDBTbxPassword).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)editStudentDBTbxPassword).set_Location(new Point(880, 533));
		((Control)editStudentDBTbxPassword).set_Name("editStudentDBTbxPassword");
		((Control)editStudentDBTbxPassword).set_Size(new Size(191, 23));
		((Control)editStudentDBTbxPassword).set_TabIndex(51);
		((Control)editStudentDBTbxUserID).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)editStudentDBTbxUserID).set_Location(new Point(186, 458));
		((Control)editStudentDBTbxUserID).set_Name("editStudentDBTbxUserID");
		((Control)editStudentDBTbxUserID).set_Size(new Size(79, 23));
		((Control)editStudentDBTbxUserID).set_TabIndex(50);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)label6).set_Location(new Point(98, 530));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(76, 20));
		((Control)label6).set_TabIndex(49);
		((Control)label6).set_Text("Address :");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)label5).set_Location(new Point(99, 458));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(72, 20));
		((Control)label5).set_TabIndex(48);
		((Control)label5).set_Text("User ID :");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)label4).set_Location(new Point(361, 573));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(60, 20));
		((Control)label4).set_TabIndex(47);
		((Control)label4).set_Text("E mail :");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)label2).set_Location(new Point(795, 533));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(86, 20));
		((Control)label2).set_TabIndex(45);
		((Control)label2).set_Text("Password :");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)label1).set_Location(new Point(99, 495));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(59, 20));
		((Control)label1).set_TabIndex(44);
		((Control)label1).set_Text("Name :");
		((Control)editStudentDBBtnLogout).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)editStudentDBBtnLogout).set_Location(new Point(996, 80));
		((Control)editStudentDBBtnLogout).set_Name("editStudentDBBtnLogout");
		((Control)editStudentDBBtnLogout).set_Size(new Size(75, 35));
		((Control)editStudentDBBtnLogout).set_TabIndex(43);
		((Control)editStudentDBBtnLogout).set_Text("Logout");
		((ButtonBase)editStudentDBBtnLogout).set_UseVisualStyleBackColor(true);
		((Control)editStudentDBBtnLogout).add_Click((EventHandler)editStudentDBBtnLogout_Click);
		((Control)editStudentDBBtnBack).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)editStudentDBBtnBack).set_Location(new Point(99, 63));
		((Control)editStudentDBBtnBack).set_Name("editStudentDBBtnBack");
		((Control)editStudentDBBtnBack).set_Size(new Size(82, 35));
		((Control)editStudentDBBtnBack).set_TabIndex(42);
		((Control)editStudentDBBtnBack).set_Text("Back");
		((ButtonBase)editStudentDBBtnBack).set_UseVisualStyleBackColor(true);
		((Control)editStudentDBBtnBack).add_Click((EventHandler)editStudentDBBtnBack_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1253, 845));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("admEditStudentDB");
		((Control)this).set_Text("Edit User DB");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)admEditStudentDB_Load);
		((ISupportInitialize)editStudentDBDgvTable).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
