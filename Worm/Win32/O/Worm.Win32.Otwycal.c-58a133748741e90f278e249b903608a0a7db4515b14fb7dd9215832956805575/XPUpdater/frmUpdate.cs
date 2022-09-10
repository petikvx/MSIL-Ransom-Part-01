using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using XPUpdater.My;

namespace XPUpdater;

[DesignerGenerated]
public class frmUpdate : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("LinkIntil")]
	private LinkLabel _LinkIntil;

	[AccessedThroughProperty("LinkBilik")]
	private LinkLabel _LinkBilik;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	internal virtual ProgressBar ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox1 = value;
		}
	}

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

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer1 = value;
		}
	}

	[DebuggerNonUserCode]
	public frmUpdate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(frmUpdate_FormClosed));
		((Form)this).add_Load((EventHandler)frmUpdate_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmUpdate_FormClosing));
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected O, but got Unknown
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected O, but got Unknown
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected O, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmUpdate));
		ListBox1 = new ListBox();
		ProgressBar1 = new ProgressBar();
		GroupBox1 = new GroupBox();
		LinkLabel1 = new LinkLabel();
		LinkIntil = new LinkLabel();
		LinkBilik = new LinkLabel();
		Label3 = new Label();
		Label1 = new Label();
		Label4 = new Label();
		Timer1 = new Timer(components);
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox1.set_IntegralHeight(false);
		ListBox1.set_ItemHeight(17);
		ListBox listBox = ListBox1;
		Point location = new Point(12, 195);
		((Control)listBox).set_Location(location);
		ListBox listBox2 = ListBox1;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(3, 4, 3, 4);
		((Control)listBox2).set_Margin(margin);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox3 = ListBox1;
		Size size = new Size(570, 200);
		((Control)listBox3).set_Size(size);
		((Control)ListBox1).set_TabIndex(11);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(12, 177);
		((Control)progressBar).set_Location(location);
		ProgressBar progressBar2 = ProgressBar1;
		((Padding)(ref margin))._002Ector(3, 4, 3, 4);
		((Control)progressBar2).set_Margin(margin);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar1.set_RightToLeftLayout(true);
		ProgressBar progressBar3 = ProgressBar1;
		size = new Size(570, 10);
		((Control)progressBar3).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(10);
		((Control)GroupBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("GroupBox1.BackgroundImage"));
		((Control)GroupBox1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)LinkIntil);
		((Control)GroupBox1).get_Controls().Add((Control)(object)LinkBilik);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		GroupBox groupBox = GroupBox1;
		location = new Point(0, -10);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(600, 180);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(12);
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
		Timer1.set_Enabled(true);
		SizeF autoScaleDimensions = new SizeF(7f, 17f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(594, 408);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).set_Font(new Font("UKIJ Tuz Tom", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)178));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Padding)(ref margin))._002Ector(3, 4, 3, 4);
		((Form)this).set_Margin(margin);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmUpdate");
		((Control)this).set_RightToLeft((RightToLeft)1);
		((Form)this).set_RightToLeftLayout(true);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("ھازىر نۇسخا يېڭىلاۋاتىدۇ...");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
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

	private void frmUpdate_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void frmUpdate_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 1)
		{
			Application.Exit();
			ProjectData.EndApp();
		}
	}

	private void frmUpdate_Load(object sender, EventArgs e)
	{
		modMain.myTime.set_Enabled(false);
		Label1.set_UseCompatibleTextRendering(false);
		Label3.set_UseCompatibleTextRendering(false);
		Label4.set_UseCompatibleTextRendering(false);
		LinkBilik.set_UseCompatibleTextRendering(false);
		LinkIntil.set_UseCompatibleTextRendering(false);
		LinkLabel1.set_UseCompatibleTextRendering(false);
		((Control)MyProject.Forms.frmMain).set_Visible(false);
	}
}
