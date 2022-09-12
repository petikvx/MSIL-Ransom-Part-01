using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem;

public class changePassword : Form
{
	private SqlConnection con;

	private SqlCommand cmd;

	public int userid;

	public string password;

	private IContainer components = null;

	private Panel panel1;

	private Label label3;

	private Label label2;

	private Label label1;

	private TextBox chnagePassTbxConfirmPass;

	private TextBox chnagePassTbxNewPass;

	private TextBox chnagePassTbxCurPass;

	private Button chnagePassbtnSubmit;

	private Button changePassBtnCancel;

	public changePassword()
	{
		InitializeComponent();
	}

	private void changePassword_Load(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		clear();
		userid = login.userid;
		password = login.password;
		string text = ((object)ConfigurationManager.get_ConnectionStrings().get_Item("LibraryManagementSystem.Properties.Settings.LibraryDB")).ToString();
		con = new SqlConnection(text);
	}

	public void clear()
	{
		((Control)chnagePassTbxConfirmPass).set_Text(string.Empty);
		((Control)chnagePassTbxCurPass).set_Text(string.Empty);
		((Control)chnagePassTbxNewPass).set_Text(string.Empty);
	}

	private void chnagePassbtnSubmit_Click(object sender, EventArgs e)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (password == ((Control)chnagePassTbxCurPass).get_Text())
		{
			if (((Control)chnagePassTbxNewPass).get_Text() == ((Control)chnagePassTbxConfirmPass).get_Text())
			{
				if (((DbConnection)(object)con).State == ConnectionState.Closed)
				{
					((DbConnection)(object)con).Open();
				}
				cmd = new SqlCommand("update users set password = @password where user_id = @user_id", con);
				cmd.get_Parameters().AddWithValue("@password", (object)((Control)chnagePassTbxNewPass).get_Text());
				cmd.get_Parameters().AddWithValue("@user_id", (object)userid);
				int num = ((DbCommand)(object)cmd).ExecuteNonQuery();
				if (num == 1)
				{
					MessageBox.Show("Password successfully updated.\nPlease login with the new credentials on the new screen.");
					((Control)this).Hide();
					login login2 = new login();
					((Control)login2).Show();
				}
			}
			else
			{
				MessageBox.Show("Please make sure the new passwords should match.");
			}
		}
		else
		{
			MessageBox.Show("Please make sure the 'current password' matches your current password.");
		}
	}

	private void changePassBtnCancel_Click(object sender, EventArgs e)
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
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		panel1 = new Panel();
		chnagePassbtnSubmit = new Button();
		chnagePassTbxConfirmPass = new TextBox();
		chnagePassTbxNewPass = new TextBox();
		chnagePassTbxCurPass = new TextBox();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		changePassBtnCancel = new Button();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).get_Controls().Add((Control)(object)changePassBtnCancel);
		((Control)panel1).get_Controls().Add((Control)(object)chnagePassbtnSubmit);
		((Control)panel1).get_Controls().Add((Control)(object)chnagePassTbxConfirmPass);
		((Control)panel1).get_Controls().Add((Control)(object)chnagePassTbxNewPass);
		((Control)panel1).get_Controls().Add((Control)(object)chnagePassTbxCurPass);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).set_Location(new Point(260, 181));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(616, 346));
		((Control)panel1).set_TabIndex(0);
		((Control)chnagePassbtnSubmit).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)chnagePassbtnSubmit).set_Location(new Point(312, 246));
		((Control)chnagePassbtnSubmit).set_Name("chnagePassbtnSubmit");
		((Control)chnagePassbtnSubmit).set_Size(new Size(167, 45));
		((Control)chnagePassbtnSubmit).set_TabIndex(6);
		((Control)chnagePassbtnSubmit).set_Text("Submit");
		((ButtonBase)chnagePassbtnSubmit).set_UseVisualStyleBackColor(true);
		((Control)chnagePassbtnSubmit).add_Click((EventHandler)chnagePassbtnSubmit_Click);
		((Control)chnagePassTbxConfirmPass).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)chnagePassTbxConfirmPass).set_Location(new Point(297, 172));
		((Control)chnagePassTbxConfirmPass).set_Name("chnagePassTbxConfirmPass");
		chnagePassTbxConfirmPass.set_PasswordChar('*');
		((Control)chnagePassTbxConfirmPass).set_Size(new Size(198, 27));
		((Control)chnagePassTbxConfirmPass).set_TabIndex(5);
		((Control)chnagePassTbxNewPass).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)chnagePassTbxNewPass).set_Location(new Point(297, 127));
		((Control)chnagePassTbxNewPass).set_Name("chnagePassTbxNewPass");
		chnagePassTbxNewPass.set_PasswordChar('*');
		((Control)chnagePassTbxNewPass).set_Size(new Size(198, 27));
		((Control)chnagePassTbxNewPass).set_TabIndex(4);
		((Control)chnagePassTbxCurPass).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)chnagePassTbxCurPass).set_Location(new Point(297, 85));
		((Control)chnagePassTbxCurPass).set_Name("chnagePassTbxCurPass");
		chnagePassTbxCurPass.set_PasswordChar('*');
		((Control)chnagePassTbxCurPass).set_Size(new Size(198, 27));
		((Control)chnagePassTbxCurPass).set_TabIndex(3);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Consolas", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(49, 172));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(230, 22));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Conform New Password :");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Consolas", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(49, 127));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(150, 22));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("New Password :");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Consolas", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(49, 85));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(190, 22));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Current Password :");
		((Control)changePassBtnCancel).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)changePassBtnCancel).set_Location(new Point(124, 248));
		((Control)changePassBtnCancel).set_Name("changePassBtnCancel");
		((Control)changePassBtnCancel).set_Size(new Size(75, 45));
		((Control)changePassBtnCancel).set_TabIndex(14);
		((Control)changePassBtnCancel).set_Text("Cancel");
		((ButtonBase)changePassBtnCancel).set_UseVisualStyleBackColor(true);
		((Control)changePassBtnCancel).add_Click((EventHandler)changePassBtnCancel_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1086, 709));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("changePassword");
		((Control)this).set_Text("Chnage Password");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)changePassword_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
