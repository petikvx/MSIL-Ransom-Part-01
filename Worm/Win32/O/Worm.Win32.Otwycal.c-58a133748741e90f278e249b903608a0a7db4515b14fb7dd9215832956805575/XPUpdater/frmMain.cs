using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using XPUpdater.My;

namespace XPUpdater;

[DesignerGenerated]
public class frmMain : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("CmdOK")]
	private Button _CmdOK;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("LinkIntil")]
	private LinkLabel _LinkIntil;

	[AccessedThroughProperty("LinkBilik")]
	private LinkLabel _LinkBilik;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	private bool manualClosed;

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
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

	internal virtual Button CmdOK
	{
		[DebuggerNonUserCode]
		get
		{
			return _CmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CmdOK != null)
			{
				((Control)_CmdOK).remove_Click((EventHandler)CmdOK_Click);
			}
			_CmdOK = value;
			if (_CmdOK != null)
			{
				((Control)_CmdOK).add_Click((EventHandler)CmdOK_Click);
			}
		}
	}

	internal virtual ComboBox ComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_ComboBox1 != null)
			{
				_ComboBox1.remove_SelectedIndexChanged((EventHandler)ComboBox1_SelectedIndexChanged);
			}
			_ComboBox1 = value;
			if (_ComboBox1 != null)
			{
				_ComboBox1.add_SelectedIndexChanged((EventHandler)ComboBox1_SelectedIndexChanged);
			}
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
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

	internal virtual LinkLabel LinkIntil
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkIntil;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_LinkIntil != null)
			{
				_LinkIntil.remove_LinkClicked(new LinkLabelLinkClickedEventHandler(LinkIntil_LinkClicked));
			}
			_LinkIntil = value;
			if (_LinkIntil != null)
			{
				_LinkIntil.add_LinkClicked(new LinkLabelLinkClickedEventHandler(LinkIntil_LinkClicked));
			}
		}
	}

	internal virtual LinkLabel LinkBilik
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkBilik;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_LinkBilik != null)
			{
				_LinkBilik.remove_LinkClicked(new LinkLabelLinkClickedEventHandler(LinkBilik_LinkClicked));
			}
			_LinkBilik = value;
			if (_LinkBilik != null)
			{
				_LinkBilik.add_LinkClicked(new LinkLabelLinkClickedEventHandler(LinkBilik_LinkClicked));
			}
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.remove_LinkClicked(new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked));
			}
			_LinkLabel1 = value;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked));
			}
		}
	}

	public frmMain()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)frmMain_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmMain_FormClosing));
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		manualClosed = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected O, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected O, but got Unknown
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected O, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		GroupBox1 = new GroupBox();
		LinkLabel1 = new LinkLabel();
		LinkIntil = new LinkLabel();
		LinkBilik = new LinkLabel();
		Label3 = new Label();
		Label1 = new Label();
		Label4 = new Label();
		CmdOK = new Button();
		ComboBox1 = new ComboBox();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("GroupBox1.BackgroundImage"));
		((Control)GroupBox1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)LinkIntil);
		((Control)GroupBox1).get_Controls().Add((Control)(object)LinkBilik);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		GroupBox groupBox = GroupBox1;
		Point location = new Point(0, -10);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		Size size = new Size(600, 180);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(7);
		GroupBox1.set_TabStop(false);
		((Label)LinkLabel1).set_AutoSize(true);
		((Control)LinkLabel1).set_BackColor(Color.Transparent);
		((Control)LinkLabel1).set_Font(new Font("UKIJ Tuz Tom", 10.5f, (FontStyle)2, (GraphicsUnit)3, (byte)178));
		LinkLabel1.set_LinkBehavior((LinkBehavior)3);
		LinkLabel1.set_LinkColor(Color.White);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(18, 20);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(80, 19);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(10);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("Bihlansoft");
		((Label)LinkIntil).set_AutoSize(true);
		((Control)LinkIntil).set_BackColor(Color.Transparent);
		((Control)LinkIntil).set_Font(new Font("UKIJ Tuz Tom", 10.5f, (FontStyle)0, (GraphicsUnit)3, (byte)178));
		LinkIntil.set_LinkColor(Color.MediumBlue);
		LinkLabel linkIntil = LinkIntil;
		location = new Point(317, 144);
		((Control)linkIntil).set_Location(location);
		((Control)LinkIntil).set_Name("LinkIntil");
		LinkLabel linkIntil2 = LinkIntil;
		size = new Size(39, 19);
		((Control)linkIntil2).set_Size(size);
		((Control)LinkIntil).set_TabIndex(9);
		((Label)LinkIntil).set_TabStop(true);
		LinkIntil.set_Text("ئىنتىل");
		((Label)LinkBilik).set_AutoSize(true);
		((Control)LinkBilik).set_BackColor(Color.Transparent);
		((Control)LinkBilik).set_Font(new Font("UKIJ Tuz Tom", 10.5f, (FontStyle)0, (GraphicsUnit)3, (byte)178));
		LinkBilik.set_LinkColor(Color.MediumBlue);
		LinkLabel linkBilik = LinkBilik;
		location = new Point(356, 144);
		((Control)linkBilik).set_Location(location);
		((Control)LinkBilik).set_Name("LinkBilik");
		LinkLabel linkBilik2 = LinkBilik;
		size = new Size(37, 19);
		((Control)linkBilik2).set_Size(size);
		((Control)LinkBilik).set_TabIndex(9);
		((Label)LinkBilik).set_TabStop(true);
		LinkBilik.set_Text("بىلىك");
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("UKIJ Tuz Tom", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)178));
		((Control)Label3).set_ForeColor(Color.White);
		Label label = Label3;
		location = new Point(27, 72);
		((Control)label).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label2 = Label3;
		size = new Size(552, 72);
		((Control)label2).set_Size(size);
		((Control)Label3).set_TabIndex(8);
		Label3.set_Text(componentResourceManager.GetString("Label3.Text"));
		Label3.set_TextAlign((ContentAlignment)16);
		Label3.set_UseMnemonic(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("UKIJ Tuz Tom", 10.5f, (FontStyle)0, (GraphicsUnit)3, (byte)178));
		((Control)Label1).set_ForeColor(Color.White);
		Label label3 = Label1;
		location = new Point(27, 144);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		size = new Size(297, 19);
		((Control)label4).set_Size(size);
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("«ئۇيغۇرچە WindowsXP تەرجىمە تەتقىقات گورۇپىسى»");
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("UKIJ Tuz Tom", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178));
		((Control)Label4).set_ForeColor(Color.White);
		Label label5 = Label4;
		location = new Point(260, 33);
		((Control)label5).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label6 = Label4;
		size = new Size(314, 29);
		((Control)label6).set_Size(size);
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("ئاپتوماتىك نۇسخا يېڭىلاش پروگراممىسى");
		((Control)CmdOK).set_Enabled(false);
		((ButtonBase)CmdOK).set_FlatStyle((FlatStyle)3);
		Button cmdOK = CmdOK;
		location = new Point(391, 189);
		((Control)cmdOK).set_Location(location);
		((Control)CmdOK).set_Name("CmdOK");
		Button cmdOK2 = CmdOK;
		size = new Size(83, 27);
		((Control)cmdOK2).set_Size(size);
		((Control)CmdOK).set_TabIndex(1);
		((ButtonBase)CmdOK).set_Text("ئىجرا قىلىش");
		((ButtonBase)CmdOK).set_UseVisualStyleBackColor(true);
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		ComboBox1.set_FlatStyle((FlatStyle)3);
		((Control)ComboBox1).set_Font(new Font("UKIJ Tuz Tom", 10.5f, (FontStyle)0, (GraphicsUnit)3, (byte)178));
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[5] { "دەرھال نۇسخا يېڭىلىسا بولىدۇ", "5 مىنۇتتىن كىيىن ئەسكەرتىپ قويسۇن", "بىر سائەتتىن كىيىن ئەسكەرتىپ قويسۇن", "24 سائەتتىن كىيىن ئەسكەرتىپ قويسۇن", "بۇندىن كىيىن ئەسكەرتمىسۇن، ئۆزۈم قوزغىتىمەن" });
		ComboBox comboBox = ComboBox1;
		location = new Point(118, 189);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(267, 27);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(7f, 17f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(594, 230);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)CmdOK);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Font(new Font("UKIJ Tuz Tom", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)178));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(3, 4, 3, 4);
		((Form)this).set_Margin(margin);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmMain");
		((Control)this).set_RightToLeft((RightToLeft)1);
		((Form)this).set_RightToLeftLayout(true);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("ئۇيغۇرچە WindowsXP ئاپتوماتىك توردىن يېڭىلاش پروگراممىسى");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)CmdOK).set_Enabled(true);
	}

	private void CmdOK_Click(object sender, EventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Invalid comparison between Unknown and I4
		cls_IniFileAccess cls_IniFileAccess2 = new cls_IniFileAccess();
		string configFile = modMain.myUpdate._ConfigFile;
		string part = "UpdateInfo";
		manualClosed = true;
		switch (ComboBox1.get_SelectedIndex())
		{
		default:
			Interaction.MsgBox((object)"Else", (MsgBoxStyle)0, (object)null);
			goto IL_0251;
		case 0:
		{
			string value = DateAndTime.get_Now().AddDays(1.0).ToString();
			cls_IniFileAccess2.SetKey(part, "NextStartTime", value, configFile);
			cls_IniFileAccess2.SetKey(part, "NextStartOn", Conversions.ToString(false), configFile);
			cls_IniFileAccess2.SetKey(part, "NextNoWarning", Conversions.ToString(false), configFile);
			((Form)this).set_DialogResult((DialogResult)1);
			goto IL_0251;
		}
		case 1:
		{
			string value = DateAndTime.get_Now().AddMinutes(5.0).ToString();
			cls_IniFileAccess2.SetKey(part, "NextStartTime", value, configFile);
			cls_IniFileAccess2.SetKey(part, "NextStartOn", Conversions.ToString(false), configFile);
			cls_IniFileAccess2.SetKey(part, "NextNoWarning", Conversions.ToString(false), configFile);
			((Form)this).set_DialogResult((DialogResult)5);
			goto IL_0251;
		}
		case 2:
		{
			string value = DateAndTime.get_Now().AddHours(1.0).ToString();
			cls_IniFileAccess2.SetKey(part, "NextStartTime", value.ToString(), configFile);
			cls_IniFileAccess2.SetKey(part, "NextStartOn", Conversions.ToString(false), configFile);
			cls_IniFileAccess2.SetKey(part, "NextNoWarning", Conversions.ToString(false), configFile);
			((Form)this).set_DialogResult((DialogResult)5);
			goto IL_0251;
		}
		case 3:
		{
			string value = DateAndTime.get_Now().AddHours(24.0).ToString();
			cls_IniFileAccess2.SetKey(part, "NextStartTime", value.ToString(), configFile);
			cls_IniFileAccess2.SetKey(part, "NextStartOn", Conversions.ToString(false), configFile);
			cls_IniFileAccess2.SetKey(part, "NextNoWarning", Conversions.ToString(false), configFile);
			((Form)this).set_DialogResult((DialogResult)5);
			goto IL_0251;
		}
		case 4:
			{
				if ((int)Interaction.MsgBox((object)"بۇندىن كىيىن نۇسخا يېڭىلاش توغرىلىق ئەسكەرتمەيدۇ، ئەگەر نۇسخا يېڭىلاشقا توغرا كەلسە چوقۇم ئۆزىڭىز قول ئارقىلىق قوزغىتىشىڭىزغا توغرا كېلىدۇ، يېنىۋالامسىز؟", (MsgBoxStyle)52, (object)null) != 6)
				{
					string value = DateAndTime.get_Now().AddDays(7.0).ToString();
					cls_IniFileAccess2.SetKey(part, "NextStartTime", value, configFile);
					cls_IniFileAccess2.SetKey(part, "NextStartOn", Convert.ToString(value: false), configFile);
					cls_IniFileAccess2.SetKey(part, "NextNoWarning", Convert.ToString(value: true), configFile);
					((Form)this).set_DialogResult((DialogResult)3);
					goto IL_0251;
				}
				break;
			}
			IL_0251:
			((Control)CmdOK).set_Enabled(false);
			((Form)this).Close();
			break;
		}
	}

	private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected I4, but got Unknown
		if (!manualClosed)
		{
			((CancelEventArgs)(object)e).Cancel = true;
			return;
		}
		switch (((Form)this).get_DialogResult() - 1)
		{
		case 0:
			modMain.StartUpdate();
			break;
		case 2:
			modMain.SysIcon.set_Visible(false);
			ProjectData.EndApp();
			return;
		case 4:
			((Form)MyProject.Forms.frmUpdate).Close();
			break;
		}
		modMain.myTime.set_Enabled(true);
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		Label1.set_UseCompatibleTextRendering(false);
		Label3.set_UseCompatibleTextRendering(false);
		Label4.set_UseCompatibleTextRendering(false);
		LinkBilik.set_UseCompatibleTextRendering(false);
		LinkIntil.set_UseCompatibleTextRendering(false);
		LinkLabel1.set_UseCompatibleTextRendering(false);
		((Control)ComboBox1).set_Enabled(true);
		ComboBox1.set_SelectedIndex(-1);
		((Control)CmdOK).set_Enabled(false);
		manualClosed = false;
		modMain.myTime.set_Enabled(false);
	}

	private void LinkBilik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.bilik.cn");
	}

	private void LinkIntil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.intil.cn");
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.bihlansoft.cn");
	}
}
