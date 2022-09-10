using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace xxx;

[DesignerGenerated]
public class ll_ufshowtxtinfo : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ll_lblefname")]
	private LabelX _ll_lblefname;

	[AccessedThroughProperty("ll_lbtxt")]
	private ListBox _ll_lbtxt;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	internal virtual LabelX LabelX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX1 = value;
		}
	}

	internal virtual LabelX ll_lblefname
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lblefname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lblefname = value;
		}
	}

	internal virtual ListBox ll_lbtxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbtxt = value;
		}
	}

	internal virtual ButtonX ll_btnexit
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnexit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnexit_Click;
			if (_ll_btnexit != null)
			{
				((Control)_ll_btnexit).remove_Click(eventHandler);
			}
			_ll_btnexit = value;
			if (_ll_btnexit != null)
			{
				((Control)_ll_btnexit).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public ll_ufshowtxtinfo()
	{
		((Form)this).add_Load((EventHandler)ll_ufshowtxtinfo_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Office2007Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		LabelX1 = new LabelX();
		ll_lblefname = new LabelX();
		ll_lbtxt = new ListBox();
		ll_btnexit = new ButtonX();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		Point location = new Point(3, 2);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(75, 17);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("当前文件：");
		((Control)ll_lblefname).set_Anchor((AnchorStyles)15);
		((BaseItemControl)ll_lblefname).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lblefname).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)ll_lblefname).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX obj = ll_lblefname;
		location = new Point(3, 15);
		((Control)obj).set_Location(location);
		((Control)ll_lblefname).set_Name("ll_lblefname");
		LabelX obj2 = ll_lblefname;
		size = new Size(266, 28);
		((Control)obj2).set_Size(size);
		((Control)ll_lblefname).set_TabIndex(0);
		ll_lblefname.set_TextLineAlignment((StringAlignment)0);
		((Control)ll_lbtxt).set_Anchor((AnchorStyles)15);
		ll_lbtxt.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)ll_lbtxt).set_FormattingEnabled(true);
		ll_lbtxt.set_ItemHeight(12);
		ListBox obj3 = ll_lbtxt;
		location = new Point(3, 49);
		((Control)obj3).set_Location(location);
		((Control)ll_lbtxt).set_Name("ll_lbtxt");
		ListBox obj4 = ll_lbtxt;
		size = new Size(274, 292);
		((Control)obj4).set_Size(size);
		((Control)ll_lbtxt).set_TabIndex(1);
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ll_btnexit.set_DialogResult((DialogResult)2);
		((Control)ll_btnexit).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj5 = ll_btnexit;
		location = new Point(88, 347);
		((Control)obj5).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj6 = ll_btnexit;
		size = new Size(110, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(2);
		ll_btnexit.set_Text("关闭");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(281, 378);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_lbtxt);
		((Control)this).get_Controls().Add((Control)(object)ll_lblefname);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufshowtxtinfo");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("浏览文本信息..");
		((Control)this).ResumeLayout(false);
	}

	private void ll_ufshowtxtinfo_Load(object sender, EventArgs e)
	{
		Mod1.lr = new StreamReader(Mod1.curtxtfname, Encoding.Default);
		string text = default(string);
		if (Mod1.curtxtfname.Length > 40)
		{
			text = Mod1.curtxtfname.Insert(42, "<br>");
			text = text.Insert(text.Length, "</br>");
		}
		ll_lblefname.set_Text(text);
		Mod1.ff = "";
		while (!Information.IsNothing((object)Mod1.ff))
		{
			Mod1.ff = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)Mod1.ff))
			{
				break;
			}
			ll_lbtxt.get_Items().Add((object)Mod1.ff);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
	}

	private void ll_btnexit_Click(object sender, EventArgs e)
	{
		((Component)(object)this).Dispose();
	}
}
