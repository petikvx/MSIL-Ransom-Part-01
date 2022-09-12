using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem;

public class admStartPage : Form
{
	private IContainer components = null;

	private Button admStartPageBtnBookSearch;

	private Button admStartPageBtnEditBookDB;

	private Button admStartPageBtnReturn;

	private Button admStartPageBtnIssue;

	private Button admStartPageBtnEditStudentDB;

	private Panel panel1;

	private Button admStartPageBtnLogout;

	private Button admStartPageBtnChangePassword;

	public admStartPage()
	{
		InitializeComponent();
	}

	private void admStartPage_Load(object sender, EventArgs e)
	{
	}

	private void admStartPageBtnLogout_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		login login2 = new login();
		((Control)login2).Show();
	}

	private void admStartPageBtnChangePassword_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		changePassword changePassword2 = new changePassword();
		((Control)changePassword2).Show();
	}

	private void admStartPageBtnBookSearch_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		admBookSearch admBookSearch2 = new admBookSearch();
		((Control)admBookSearch2).Show();
	}

	private void admStartPageBtnEditBookDB_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		admEditBookDB admEditBookDB2 = new admEditBookDB();
		((Control)admEditBookDB2).Show();
	}

	private void admStartPageBtnEditStudentDB_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		admEditStudentDB admEditStudentDB2 = new admEditStudentDB();
		((Control)admEditStudentDB2).Show();
	}

	private void admStartPageBtnIssue_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		admIssue admIssue2 = new admIssue();
		((Control)admIssue2).Show();
	}

	private void admStartPageBtnReturn_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		admReturn admReturn2 = new admReturn();
		((Control)admReturn2).Show();
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
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected O, but got Unknown
		admStartPageBtnBookSearch = new Button();
		admStartPageBtnEditBookDB = new Button();
		admStartPageBtnReturn = new Button();
		admStartPageBtnIssue = new Button();
		admStartPageBtnEditStudentDB = new Button();
		panel1 = new Panel();
		admStartPageBtnChangePassword = new Button();
		admStartPageBtnLogout = new Button();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)admStartPageBtnBookSearch).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)admStartPageBtnBookSearch).set_Location(new Point(38, 52));
		((Control)admStartPageBtnBookSearch).set_Name("admStartPageBtnBookSearch");
		((Control)admStartPageBtnBookSearch).set_Size(new Size(178, 96));
		((Control)admStartPageBtnBookSearch).set_TabIndex(0);
		((Control)admStartPageBtnBookSearch).set_Text("Book Search");
		((ButtonBase)admStartPageBtnBookSearch).set_UseVisualStyleBackColor(true);
		((Control)admStartPageBtnBookSearch).add_Click((EventHandler)admStartPageBtnBookSearch_Click);
		((Control)admStartPageBtnEditBookDB).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)admStartPageBtnEditBookDB).set_Location(new Point(146, 177));
		((Control)admStartPageBtnEditBookDB).set_Name("admStartPageBtnEditBookDB");
		((Control)admStartPageBtnEditBookDB).set_Size(new Size(178, 96));
		((Control)admStartPageBtnEditBookDB).set_TabIndex(1);
		((Control)admStartPageBtnEditBookDB).set_Text("Edit Book DB");
		((ButtonBase)admStartPageBtnEditBookDB).set_UseVisualStyleBackColor(true);
		((Control)admStartPageBtnEditBookDB).add_Click((EventHandler)admStartPageBtnEditBookDB_Click);
		((Control)admStartPageBtnReturn).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)admStartPageBtnReturn).set_Location(new Point(454, 52));
		((Control)admStartPageBtnReturn).set_Name("admStartPageBtnReturn");
		((Control)admStartPageBtnReturn).set_Size(new Size(178, 96));
		((Control)admStartPageBtnReturn).set_TabIndex(2);
		((Control)admStartPageBtnReturn).set_Text("Return");
		((ButtonBase)admStartPageBtnReturn).set_UseVisualStyleBackColor(true);
		((Control)admStartPageBtnReturn).add_Click((EventHandler)admStartPageBtnReturn_Click);
		((Control)admStartPageBtnIssue).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)admStartPageBtnIssue).set_Location(new Point(242, 52));
		((Control)admStartPageBtnIssue).set_Name("admStartPageBtnIssue");
		((Control)admStartPageBtnIssue).set_Size(new Size(178, 96));
		((Control)admStartPageBtnIssue).set_TabIndex(3);
		((Control)admStartPageBtnIssue).set_Text("Issue");
		((ButtonBase)admStartPageBtnIssue).set_UseVisualStyleBackColor(true);
		((Control)admStartPageBtnIssue).add_Click((EventHandler)admStartPageBtnIssue_Click);
		((Control)admStartPageBtnEditStudentDB).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)admStartPageBtnEditStudentDB).set_Location(new Point(350, 177));
		((Control)admStartPageBtnEditStudentDB).set_Name("admStartPageBtnEditStudentDB");
		((Control)admStartPageBtnEditStudentDB).set_Size(new Size(178, 96));
		((Control)admStartPageBtnEditStudentDB).set_TabIndex(4);
		((Control)admStartPageBtnEditStudentDB).set_Text("Edit User DB");
		((ButtonBase)admStartPageBtnEditStudentDB).set_UseVisualStyleBackColor(true);
		((Control)admStartPageBtnEditStudentDB).add_Click((EventHandler)admStartPageBtnEditStudentDB_Click);
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).get_Controls().Add((Control)(object)admStartPageBtnChangePassword);
		((Control)panel1).get_Controls().Add((Control)(object)admStartPageBtnLogout);
		((Control)panel1).get_Controls().Add((Control)(object)admStartPageBtnIssue);
		((Control)panel1).get_Controls().Add((Control)(object)admStartPageBtnEditStudentDB);
		((Control)panel1).get_Controls().Add((Control)(object)admStartPageBtnBookSearch);
		((Control)panel1).get_Controls().Add((Control)(object)admStartPageBtnEditBookDB);
		((Control)panel1).get_Controls().Add((Control)(object)admStartPageBtnReturn);
		((Control)panel1).set_Location(new Point(458, 264));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(679, 522));
		((Control)panel1).set_TabIndex(5);
		((Control)admStartPageBtnChangePassword).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)admStartPageBtnChangePassword).set_Location(new Point(38, 329));
		((Control)admStartPageBtnChangePassword).set_Name("admStartPageBtnChangePassword");
		((Control)admStartPageBtnChangePassword).set_Size(new Size(167, 35));
		((Control)admStartPageBtnChangePassword).set_TabIndex(14);
		((Control)admStartPageBtnChangePassword).set_Text("Change Password");
		((ButtonBase)admStartPageBtnChangePassword).set_UseVisualStyleBackColor(true);
		((Control)admStartPageBtnChangePassword).add_Click((EventHandler)admStartPageBtnChangePassword_Click);
		((Control)admStartPageBtnLogout).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)admStartPageBtnLogout).set_Location(new Point(557, 329));
		((Control)admStartPageBtnLogout).set_Name("admStartPageBtnLogout");
		((Control)admStartPageBtnLogout).set_Size(new Size(75, 35));
		((Control)admStartPageBtnLogout).set_TabIndex(13);
		((Control)admStartPageBtnLogout).set_Text("Logout");
		((ButtonBase)admStartPageBtnLogout).set_UseVisualStyleBackColor(true);
		((Control)admStartPageBtnLogout).add_Click((EventHandler)admStartPageBtnLogout_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1542, 865));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("admStartPage");
		((Control)this).set_Text("Admin Start Pag");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)admStartPage_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
