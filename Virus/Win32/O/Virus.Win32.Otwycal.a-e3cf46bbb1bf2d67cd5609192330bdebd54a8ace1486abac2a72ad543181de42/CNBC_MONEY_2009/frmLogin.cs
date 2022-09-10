using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CNBC.DAL;
using CNBC_MONEY_2009.My;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinToolTip;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmLogin : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("txtUser")]
	private UltraTextEditor _txtUser;

	[AccessedThroughProperty("txtPassword")]
	private UltraTextEditor _txtPassword;

	[AccessedThroughProperty("UltraPictureBox1")]
	private UltraPictureBox _UltraPictureBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("btnLogin")]
	private UltraButton _btnLogin;

	[AccessedThroughProperty("btnClose")]
	private UltraButton _btnClose;

	[AccessedThroughProperty("UltraToolTipManager1")]
	private UltraToolTipManager _UltraToolTipManager1;

	[AccessedThroughProperty("chkUserName")]
	private UltraCheckEditor _chkUserName;

	[AccessedThroughProperty("UltraPictureBox2")]
	private UltraPictureBox _UltraPictureBox2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	private Money_Splash splash;

	private clsEquity objEquity;

	internal virtual UltraTextEditor txtUser
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtUser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_txtUser != null)
			{
				((Control)_txtUser).remove_Enter((EventHandler)txtUser_Enter);
			}
			_txtUser = value;
			if (_txtUser != null)
			{
				((Control)_txtUser).add_Enter((EventHandler)txtUser_Enter);
			}
		}
	}

	internal virtual UltraTextEditor txtPassword
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_txtPassword != null)
			{
				((Control)_txtPassword).remove_Enter((EventHandler)txtPassword_Enter);
				((Control)_txtPassword).remove_KeyDown(new KeyEventHandler(txtPassword_KeyDown));
			}
			_txtPassword = value;
			if (_txtPassword != null)
			{
				((Control)_txtPassword).add_Enter((EventHandler)txtPassword_Enter);
				((Control)_txtPassword).add_KeyDown(new KeyEventHandler(txtPassword_KeyDown));
			}
		}
	}

	internal virtual UltraPictureBox UltraPictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraPictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraPictureBox1 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual UltraButton btnLogin
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnLogin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btnLogin != null)
			{
				((Control)_btnLogin).remove_Click((EventHandler)btnLogin_Click);
			}
			_btnLogin = value;
			if (_btnLogin != null)
			{
				((Control)_btnLogin).add_Click((EventHandler)btnLogin_Click);
			}
		}
	}

	internal virtual UltraButton btnClose
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btnClose != null)
			{
				((Control)_btnClose).remove_Click((EventHandler)btnClose_Click);
			}
			_btnClose = value;
			if (_btnClose != null)
			{
				((Control)_btnClose).add_Click((EventHandler)btnClose_Click);
			}
		}
	}

	internal virtual UltraToolTipManager UltraToolTipManager1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraToolTipManager1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraToolTipManager1 = value;
		}
	}

	internal virtual UltraCheckEditor chkUserName
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkUserName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkUserName = value;
		}
	}

	internal virtual UltraPictureBox UltraPictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraPictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraPictureBox2 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	public frmLogin()
	{
		((Form)this).add_Load((EventHandler)frmLogin_Load);
		__ENCList.Add(new WeakReference(this));
		splash = new Money_Splash();
		objEquity = new clsEquity();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected O, but got Unknown
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmLogin));
		Appearance val = new Appearance();
		Appearance val2 = new Appearance();
		Appearance val3 = new Appearance();
		txtUser = new UltraTextEditor();
		txtPassword = new UltraTextEditor();
		UltraPictureBox1 = new UltraPictureBox();
		Label1 = new Label();
		Label2 = new Label();
		btnLogin = new UltraButton();
		btnClose = new UltraButton();
		UltraToolTipManager1 = new UltraToolTipManager(components);
		chkUserName = new UltraCheckEditor();
		UltraPictureBox2 = new UltraPictureBox();
		Label3 = new Label();
		((ISupportInitialize)txtUser).BeginInit();
		((ISupportInitialize)txtPassword).BeginInit();
		((Control)this).SuspendLayout();
		((TextEditorControlBase)txtUser).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)txtUser).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraTextEditor obj = txtUser;
		Point location = new Point(173, 259);
		((Control)obj).set_Location(location);
		((Control)txtUser).set_Name("txtUser");
		UltraTextEditor obj2 = txtUser;
		Size size = new Size(229, 25);
		((Control)obj2).set_Size(size);
		((Control)txtUser).set_TabIndex(0);
		((TextEditorControlBase)txtPassword).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)txtPassword).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraTextEditor obj3 = txtPassword;
		location = new Point(173, 305);
		((Control)obj3).set_Location(location);
		((Control)txtPassword).set_Name("txtPassword");
		txtPassword.set_PasswordChar('•');
		UltraTextEditor obj4 = txtPassword;
		size = new Size(229, 25);
		((Control)obj4).set_Size(size);
		((Control)txtPassword).set_TabIndex(1);
		UltraPictureBox1.set_AutoSize(true);
		UltraPictureBox1.set_BorderShadowColor(Color.Empty);
		UltraPictureBox1.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("UltraPictureBox1.Image")));
		UltraPictureBox1.set_ImageTransparentColor(Color.FromArgb(255, 255, 192));
		UltraPictureBox ultraPictureBox = UltraPictureBox1;
		location = new Point(139, 81);
		((Control)ultraPictureBox).set_Location(location);
		((Control)UltraPictureBox1).set_Name("UltraPictureBox1");
		UltraPictureBox ultraPictureBox2 = UltraPictureBox1;
		size = new Size(300, 164);
		((Control)ultraPictureBox2).set_Size(size);
		((Control)UltraPictureBox1).set_TabIndex(6);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Verdana", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		location = new Point(123, 263);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(43, 17);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(7);
		Label1.set_Text("User");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Verdana", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label3 = Label2;
		location = new Point(82, 309);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(84, 17);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(8);
		Label2.set_Text("Password");
		val.set_BorderColor(Color.Black);
		val.set_BorderColor2(Color.Black);
		((ControlBase)btnLogin).set_Appearance((AppearanceBase)(object)val);
		((UltraButtonBase)btnLogin).set_ButtonStyle((UIElementButtonStyle)17);
		((Control)btnLogin).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj5 = btnLogin;
		location = new Point(173, 370);
		((Control)obj5).set_Location(location);
		((Control)btnLogin).set_Name("btnLogin");
		UltraButton obj6 = btnLogin;
		size = new Size(98, 23);
		((Control)obj6).set_Size(size);
		((Control)btnLogin).set_TabIndex(3);
		((ControlBase)btnLogin).set_Text("LOGIN");
		val2.set_BorderColor(Color.Black);
		val2.set_BorderColor2(Color.Black);
		((ControlBase)btnClose).set_Appearance((AppearanceBase)(object)val2);
		((UltraButtonBase)btnClose).set_ButtonStyle((UIElementButtonStyle)17);
		((UltraButtonBase)btnClose).set_DialogResult((DialogResult)2);
		((Control)btnClose).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj7 = btnClose;
		location = new Point(304, 370);
		((Control)obj7).set_Location(location);
		((Control)btnClose).set_Name("btnClose");
		UltraButton obj8 = btnClose;
		size = new Size(98, 23);
		((Control)obj8).set_Size(size);
		((Control)btnClose).set_TabIndex(4);
		((ControlBase)btnClose).set_Text("CLOSE");
		UltraToolTipManager1.set_AutoPopDelay(6000);
		UltraToolTipManager1.set_ContainingControl((Control)(object)this);
		UltraToolTipManager1.set_DisplayStyle((ToolTipDisplayStyle)2);
		UltraToolTipManager1.set_InitialDelay(10);
		UltraToolTipManager1.set_ToolTipImage((ToolTipImage)4);
		UltraToolTipManager1.set_ToolTipTitle("Caps Lock is On\r\n");
		val3.get_FontData().set_Name("Verdana");
		chkUserName.set_Appearance((AppearanceBase)(object)val3);
		chkUserName.set_BackColor(Color.Transparent);
		chkUserName.set_BackColorInternal(Color.Transparent);
		chkUserName.set_ButtonStyle((UIElementButtonStyle)17);
		UltraCheckEditor obj9 = chkUserName;
		location = new Point(173, 341);
		((Control)obj9).set_Location(location);
		((Control)chkUserName).set_Name("chkUserName");
		UltraCheckEditor obj10 = chkUserName;
		size = new Size(120, 20);
		((Control)obj10).set_Size(size);
		((Control)chkUserName).set_TabIndex(2);
		chkUserName.set_Text("Remember User");
		((UltraControlBase)chkUserName).set_UseFlatMode((DefaultableBoolean)1);
		UltraPictureBox2.set_AutoSize(true);
		UltraPictureBox2.set_BorderShadowColor(Color.Empty);
		UltraPictureBox2.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("UltraPictureBox2.Image")));
		UltraPictureBox2.set_ImageTransparentColor(Color.Transparent);
		UltraPictureBox ultraPictureBox3 = UltraPictureBox2;
		location = new Point(-2, -4);
		((Control)ultraPictureBox3).set_Location(location);
		((Control)UltraPictureBox2).set_Name("UltraPictureBox2");
		UltraPictureBox ultraPictureBox4 = UltraPictureBox2;
		size = new Size(56, 104);
		((Control)ultraPictureBox4).set_Size(size);
		((Control)UltraPictureBox2).set_TabIndex(9);
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label5 = Label3;
		location = new Point(62, 429);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(527, 39);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(10);
		Label3.set_Text(componentResourceManager.GetString("Label3.Text"));
		Label3.set_TextAlign((ContentAlignment)32);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnLogin);
		((Form)this).set_AutoSize(true);
		((Form)this).set_BackColor(Color.AliceBlue);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_CancelButton((IButtonControl)(object)btnClose);
		size = new Size(798, 499);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)UltraPictureBox2);
		((Control)this).get_Controls().Add((Control)(object)chkUserName);
		((Control)this).get_Controls().Add((Control)(object)btnClose);
		((Control)this).get_Controls().Add((Control)(object)txtUser);
		((Control)this).get_Controls().Add((Control)(object)UltraPictureBox1);
		((Control)this).get_Controls().Add((Control)(object)btnLogin);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtPassword);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("frmLogin");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CNBC Money 2010 :: Login");
		((ISupportInitialize)txtUser).EndInit();
		((ISupportInitialize)txtPassword).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmLogin_Load(object sender, EventArgs e)
	{
		Money_Splash money_Splash = new Money_Splash();
		((Control)money_Splash).Show();
		((Control)money_Splash).Refresh();
		if (Operators.ConditionalCompareObjectNotEqual(((ApplicationSettingsBase)MySettingsProperty.Settings).get_Item("USERNAME"), (object)"", false))
		{
			chkUserName.set_Checked(true);
		}
		((TextEditorControlBase)txtUser).set_Text(Conversions.ToString(((ApplicationSettingsBase)MySettingsProperty.Settings).get_Item("USERNAME")));
		objEquity = new clsEquity();
		string myIP = objEquity.getMyIP();
		if ((Strings.InStr(myIP, "192.168.23.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.24.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.26.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.27.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.28.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.3.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.1.", (CompareMethod)0) > 0))
		{
			((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("strCON", (object)mdlMain.INIRead(Application.get_StartupPath() + "/MONEY_CONFIG.INI", mdlMain.gMain, "CON_220", ""));
		}
		else
		{
			((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("strCON", (object)mdlMain.INIRead(Application.get_StartupPath() + "/MONEY_CONFIG.INI", mdlMain.gMain, "CON_166", ""));
		}
		((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		if (Operators.CompareString(((TextEditorControlBase)txtUser).get_Text(), "", false) != 0)
		{
			((Control)txtUser).set_TabIndex(5);
		}
		((Form)money_Splash).Close();
	}

	private void btnLogin_Click(object sender, EventArgs e)
	{
		try
		{
			if (((Control)splash).get_IsDisposed())
			{
				splash = new Money_Splash();
				((Control)splash).Show();
				((Control)splash).Refresh();
			}
			string dOMAINNAME = MySettingsProperty.Settings.DOMAINNAME1;
			string dOMAINNAME2 = MySettingsProperty.Settings.DOMAINNAME2;
			if (IsAuthenticated(dOMAINNAME2, dOMAINNAME, Strings.Trim(((TextEditorControlBase)txtUser).get_Text()), Strings.Trim(((TextEditorControlBase)txtPassword).get_Text())))
			{
				mdlMain.gUserName = ((TextEditorControlBase)txtUser).get_Text();
				UpdateLogin();
				if (IsUserActive())
				{
					objEquity = new clsEquity();
					string myIP = objEquity.getMyIP();
					if ((Strings.InStr(myIP, "192.168.23.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.24.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.26.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.27.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.28.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.3.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.1.", (CompareMethod)0) > 0))
					{
						mdlMain.gConnection = mdlMain.INIRead(Application.get_StartupPath() + "/MONEY_CONFIG.INI", mdlMain.gMain, "CON_220", "");
					}
					else
					{
						mdlMain.gConnection = mdlMain.INIRead(Application.get_StartupPath() + "/MONEY_CONFIG.INI", mdlMain.gMain, "CON_166", "");
					}
					((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("strCON", (object)mdlMain.gConnection);
					UpdateUser_IP();
					if (chkUserName.get_Checked())
					{
						((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("USERNAME", (object)((TextEditorControlBase)txtUser).get_Text());
					}
					else
					{
						((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("USERNAME", (object)"");
					}
					((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
					if (!((Control)splash).get_IsDisposed())
					{
						((Form)splash).Close();
					}
					((Form)this).Close();
				}
			}
			else
			{
				if (!((Control)splash).get_IsDisposed())
				{
					((Form)splash).Close();
				}
				mdlMain.ShowMessage("Login failed.");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (!((Control)splash).get_IsDisposed())
			{
				((Form)splash).Close();
			}
			ProjectData.ClearProjectError();
		}
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	private void txtPassword_Enter(object sender, EventArgs e)
	{
		if (Control.IsKeyLocked((Keys)20))
		{
			ShowToolTip();
		}
		else
		{
			UltraToolTipManager1.HideToolTip();
		}
	}

	private void txtPassword_KeyDown(object sender, KeyEventArgs e)
	{
		if (Control.IsKeyLocked((Keys)20))
		{
			ShowToolTip();
		}
		else
		{
			UltraToolTipManager1.HideToolTip();
		}
	}

	private void ShowToolTip()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		try
		{
			UltraToolTipInfo val = new UltraToolTipInfo();
			val.set_Enabled((DefaultableBoolean)1);
			val.set_ToolTipText("Having Caps Lock on may cause you to enter your password\r\n incorrectly.\r\n\r\nYou should press Caps Lock to turn it off before entering \r\n your password.");
			UltraToolTipManager1.SetUltraToolTip((Control)(object)txtPassword, val);
			Point point = default(Point);
			point.X = 388;
			point.Y = 60;
			UltraToolTipManager1.ShowToolTip((Control)(object)txtPassword, true, ((Control)this).PointToScreen(point));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void txtUser_Enter(object sender, EventArgs e)
	{
		UltraToolTipManager1.HideToolTip();
	}

	private bool IsUserActive()
	{
		try
		{
			string text = "SELECT NULL FROM CNBCMONEY_LOGINS WHERE USERNAME = '" + ((TextEditorControlBase)txtUser).get_Text() + "' AND ISBLOCKED = 0";
			DataTable dataTable = new DataTable();
			dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, text).Tables[0];
			if (dataTable.Rows.Count == 0)
			{
				if (!((Control)splash).get_IsDisposed())
				{
					((Form)splash).Close();
				}
				mdlMain.ShowMessage("Ooops.. you don't have enough rights for CNBC Money 2010");
				return false;
			}
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (!((Control)splash).get_IsDisposed())
			{
				((Form)splash).Close();
			}
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool IsAuthenticated(string domain1, string domain, string username, string pwd)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		bool result = default(bool);
		try
		{
			if (mdlMain.gExternal)
			{
				mdlMain.gDomain = "bom";
				result = true;
				return result;
			}
			string lDAP_SERVER = MySettingsProperty.Settings.LDAP_SERVER1;
			string lDAP_SERVER2 = MySettingsProperty.Settings.LDAP_SERVER2;
			string text = domain + "\\" + username;
			string text2 = domain1 + "\\" + username;
			DirectoryEntry val = new DirectoryEntry("LDAP://" + lDAP_SERVER, text, pwd);
			DirectoryEntry val2 = new DirectoryEntry("LDAP://" + lDAP_SERVER2, text2, pwd);
			bool flag;
			try
			{
				flag = true;
				RuntimeHelpers.GetObjectValue(val.get_NativeObject());
				DirectorySearcher val3 = new DirectorySearcher(val);
				val3.set_Filter("(SAMAccountName=" + username + ")");
				val3.get_PropertiesToLoad().Add("cn");
				SearchResult val4 = val3.FindOne();
				mdlMain.gDomain = domain;
				if (val4 != null)
				{
					val4.get_Path();
					Conversions.ToString(val4.get_Properties().get_Item("cn").get_Item(0));
					goto IL_01b9;
				}
				mdlMain.gDomain = "";
				flag = false;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				flag = false;
				ProjectData.ClearProjectError();
			}
			try
			{
				flag = true;
				RuntimeHelpers.GetObjectValue(val2.get_NativeObject());
				DirectorySearcher val5 = new DirectorySearcher(val2);
				val5.set_Filter("(SAMAccountName=" + username + ")");
				val5.get_PropertiesToLoad().Add("cn");
				SearchResult val6 = val5.FindOne();
				mdlMain.gDomain = domain1;
				if (val6 == null)
				{
					mdlMain.gDomain = "";
					flag = false;
				}
				val6.get_Path();
				Conversions.ToString(val6.get_Properties().get_Item("cn").get_Item(0));
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				flag = false;
				ProjectData.ClearProjectError();
			}
			goto IL_01b9;
			IL_01b9:
			if (!flag)
			{
				result = false;
				return result;
			}
			result = true;
			return result;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void UpdateUser_IP()
	{
		try
		{
			objEquity = new clsEquity();
			string text = "UPDATE CNBCMONEY_USERS_MST SET IP = '" + objEquity.getMyIP() + "' WHERE USERNAME = '" + mdlMain.gUserName + "'";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, text);
			text = "SELECT TOP 1 MKT_START_TIME, MKT_END_TIME FROM MARKET_CONFIG";
			DataTable dataTable = new DataTable();
			dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, text).Tables[0];
			if (dataTable.Rows.Count > 0)
			{
				mdlMain.gMktstartTime = Conversions.ToString(dataTable.Rows[0]["MKT_START_TIME"]);
				mdlMain.gMktEndTime = Conversions.ToString(dataTable.Rows[0]["MKT_END_TIME"]);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void FTP_Downloadfile(object Filename, object ss)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		clsFTP clsFTP2 = new clsFTP("192.168.30.152", "RTUpdate", "bse_ftp", "bse!ftp", 21);
		try
		{
			if (clsFTP2.Login())
			{
				try
				{
					clsFTP2.SetBinaryMode(bMode: true);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					clsFTP2.DownloadFile(Conversions.ToString(Filename));
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					Interaction.MsgBox((object)(Information.Err().get_Description() + " Please contact systems Administrator"), (MsgBoxStyle)0, (object)null);
					ProjectData.EndApp();
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			Interaction.MsgBox((object)(Information.Err().get_Description() + " Please contact systems Administrator"), (MsgBoxStyle)0, (object)null);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		clsFTP2.CloseConnection();
		if (Operators.ConditionalCompareObjectEqual(ss, (object)"1", false))
		{
			Type typeFromHandle = typeof(Process);
			object[] array = new object[1] { RuntimeHelpers.GetObjectValue(Filename) };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall((object)null, typeFromHandle, "Start", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				Filename = RuntimeHelpers.GetObjectValue(array[0]);
			}
		}
	}

	private void UpdateLogin()
	{
		try
		{
			string text = "IF NOT EXISTS (SELECT NULL FROM CNBCMONEY_LOGINS WHERE USERNAME = '" + mdlMain.gUserName + "') BEGIN  INSERT INTO CNBCMONEY_LOGINS (USERNAME) VALUES ('" + mdlMain.gUserName + "') END ";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, text);
			text = "SELECT LOGINID FROM CNBCMONEY_LOGINS WHERE USERNAME = '" + mdlMain.gUserName + "'";
			mdlMain.gLoginID = Conversions.ToInteger(SqlHelper.ExecuteScalar(MySettingsProperty.Settings.strCON, CommandType.Text, text));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
