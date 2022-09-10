using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class ll_ufxnbsearchini : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_btnspecialxnlibs")]
	private ButtonX _ll_btnspecialxnlibs;

	[AccessedThroughProperty("ll_txtxnlibspath")]
	private TextBoxX _ll_txtxnlibspath;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ll_lbJieGouXingShi")]
	private ListBox _ll_lbJieGouXingShi;

	[AccessedThroughProperty("ll_lbepz")]
	private LabelX _ll_lbepz;

	[AccessedThroughProperty("ll_lbpz")]
	private ListBox _ll_lbpz;

	[AccessedThroughProperty("ll_lbeztkj")]
	private LabelX _ll_lbeztkj;

	[AccessedThroughProperty("ll_lbztkj")]
	private ListBox _ll_lbztkj;

	[AccessedThroughProperty("ll_lbefbzbl")]
	private LabelX _ll_lbefbzbl;

	[AccessedThroughProperty("ll_lbfbzbl")]
	private ListBox _ll_lbfbzbl;

	[AccessedThroughProperty("ll_lbefbfbl")]
	private LabelX _ll_lbefbfbl;

	[AccessedThroughProperty("ll_lbfbfbl")]
	private ListBox _ll_lbfbfbl;

	[AccessedThroughProperty("ll_lbefbzbxt")]
	private LabelX _ll_lbefbzbxt;

	[AccessedThroughProperty("ll_lbfbzbxt")]
	private ListBox _ll_lbfbzbxt;

	[AccessedThroughProperty("ll_lbefbzbfixxt")]
	private LabelX _ll_lbefbzbfixxt;

	[AccessedThroughProperty("ll_lbfbzbfixxt")]
	private ListBox _ll_lbfbzbfixxt;

	[AccessedThroughProperty("ll_btnsearchini")]
	private ButtonX _ll_btnsearchini;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	[AccessedThroughProperty("LabelX8")]
	private LabelX _LabelX8;

	[AccessedThroughProperty("ll_lbliucheng")]
	private ListBox _ll_lbliucheng;

	private string curxnlibs;

	private string curjgxs;

	private string curstrpath;

	private string stryx;

	private string strxt;

	internal virtual ButtonX ll_btnspecialxnlibs
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnspecialxnlibs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnspecialxnlibs_Click;
			if (_ll_btnspecialxnlibs != null)
			{
				((Control)_ll_btnspecialxnlibs).remove_Click(eventHandler);
			}
			_ll_btnspecialxnlibs = value;
			if (_ll_btnspecialxnlibs != null)
			{
				((Control)_ll_btnspecialxnlibs).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBoxX ll_txtxnlibspath
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtxnlibspath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtxnlibspath = value;
		}
	}

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

	internal virtual ListBox ll_lbJieGouXingShi
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbJieGouXingShi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbJieGouXingShi = value;
		}
	}

	internal virtual LabelX ll_lbepz
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbepz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbepz = value;
		}
	}

	internal virtual ListBox ll_lbpz
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbpz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbpz = value;
		}
	}

	internal virtual LabelX ll_lbeztkj
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbeztkj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbeztkj = value;
		}
	}

	internal virtual ListBox ll_lbztkj
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbztkj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbztkj = value;
		}
	}

	internal virtual LabelX ll_lbefbzbl
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbefbzbl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbefbzbl = value;
		}
	}

	internal virtual ListBox ll_lbfbzbl
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbfbzbl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbfbzbl = value;
		}
	}

	internal virtual LabelX ll_lbefbfbl
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbefbfbl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbefbfbl = value;
		}
	}

	internal virtual ListBox ll_lbfbfbl
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbfbfbl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbfbfbl = value;
		}
	}

	internal virtual LabelX ll_lbefbzbxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbefbzbxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbefbzbxt = value;
		}
	}

	internal virtual ListBox ll_lbfbzbxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbfbzbxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbfbzbxt = value;
		}
	}

	internal virtual LabelX ll_lbefbzbfixxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbefbzbfixxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbefbzbfixxt = value;
		}
	}

	internal virtual ListBox ll_lbfbzbfixxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbfbzbfixxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbfbzbfixxt = value;
		}
	}

	internal virtual ButtonX ll_btnsearchini
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnsearchini;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnsearchini_Click;
			if (_ll_btnsearchini != null)
			{
				((Control)_ll_btnsearchini).remove_Click(eventHandler);
			}
			_ll_btnsearchini = value;
			if (_ll_btnsearchini != null)
			{
				((Control)_ll_btnsearchini).add_Click(eventHandler);
			}
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

	internal virtual LabelX LabelX8
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX8 = value;
		}
	}

	internal virtual ListBox ll_lbliucheng
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbliucheng;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbliucheng = value;
		}
	}

	[DebuggerNonUserCode]
	public ll_ufxnbsearchini()
	{
		((Form)this).add_Load((EventHandler)ll_ufxnbsearchini_Load);
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
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a79: Expected O, but got Unknown
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Expected O, but got Unknown
		ll_btnspecialxnlibs = new ButtonX();
		ll_txtxnlibspath = new TextBoxX();
		LabelX1 = new LabelX();
		ll_lbJieGouXingShi = new ListBox();
		ll_lbepz = new LabelX();
		ll_lbpz = new ListBox();
		ll_lbeztkj = new LabelX();
		ll_lbztkj = new ListBox();
		ll_lbefbzbl = new LabelX();
		ll_lbfbzbl = new ListBox();
		ll_lbefbfbl = new LabelX();
		ll_lbfbfbl = new ListBox();
		ll_lbefbzbxt = new LabelX();
		ll_lbfbzbxt = new ListBox();
		ll_lbefbzbfixxt = new LabelX();
		ll_lbfbzbfixxt = new ListBox();
		ll_btnsearchini = new ButtonX();
		ll_btnexit = new ButtonX();
		LabelX8 = new LabelX();
		ll_lbliucheng = new ListBox();
		((Control)this).SuspendLayout();
		((Control)ll_btnspecialxnlibs).set_AccessibleRole((AccessibleRole)43);
		ll_btnspecialxnlibs.set_ColorTable((eButtonColor)3);
		ButtonX obj = ll_btnspecialxnlibs;
		Point location = new Point(12, 5);
		((Control)obj).set_Location(location);
		((Control)ll_btnspecialxnlibs).set_Name("ll_btnspecialxnlibs");
		ButtonX obj2 = ll_btnspecialxnlibs;
		Size size = new Size(122, 23);
		((Control)obj2).set_Size(size);
		((PopupItemControl)ll_btnspecialxnlibs).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnspecialxnlibs).set_TabIndex(0);
		ll_btnspecialxnlibs.set_Text("指定性能库文件夹");
		ll_txtxnlibspath.get_Border().set_Class("TextBoxBorder");
		ll_txtxnlibspath.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj3 = ll_txtxnlibspath;
		location = new Point(12, 34);
		((Control)obj3).set_Location(location);
		((Control)ll_txtxnlibspath).set_Name("ll_txtxnlibspath");
		TextBoxX obj4 = ll_txtxnlibspath;
		size = new Size(797, 21);
		((Control)obj4).set_Size(size);
		((Control)ll_txtxnlibspath).set_TabIndex(1);
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		location = new Point(12, 61);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(75, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(2);
		LabelX1.set_Text("结构形式");
		((ListControl)ll_lbJieGouXingShi).set_FormattingEnabled(true);
		ll_lbJieGouXingShi.set_ItemHeight(12);
		ListBox obj5 = ll_lbJieGouXingShi;
		location = new Point(12, 90);
		((Control)obj5).set_Location(location);
		((Control)ll_lbJieGouXingShi).set_Name("ll_lbJieGouXingShi");
		ListBox obj6 = ll_lbJieGouXingShi;
		size = new Size(163, 208);
		((Control)obj6).set_Size(size);
		((Control)ll_lbJieGouXingShi).set_TabIndex(3);
		((BaseItemControl)ll_lbepz).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbepz).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj7 = ll_lbepz;
		location = new Point(181, 61);
		((Control)obj7).set_Location(location);
		((Control)ll_lbepz).set_Name("ll_lbepz");
		LabelX obj8 = ll_lbepz;
		size = new Size(75, 23);
		((Control)obj8).set_Size(size);
		((Control)ll_lbepz).set_TabIndex(2);
		ll_lbepz.set_Text("配重");
		((ListControl)ll_lbpz).set_FormattingEnabled(true);
		ll_lbpz.set_ItemHeight(12);
		ListBox obj9 = ll_lbpz;
		location = new Point(181, 90);
		((Control)obj9).set_Location(location);
		((Control)ll_lbpz).set_Name("ll_lbpz");
		ListBox obj10 = ll_lbpz;
		size = new Size(82, 208);
		((Control)obj10).set_Size(size);
		((Control)ll_lbpz).set_TabIndex(3);
		((BaseItemControl)ll_lbeztkj).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbeztkj).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj11 = ll_lbeztkj;
		location = new Point(269, 61);
		((Control)obj11).set_Location(location);
		((Control)ll_lbeztkj).set_Name("ll_lbeztkj");
		LabelX obj12 = ll_lbeztkj;
		size = new Size(75, 23);
		((Control)obj12).set_Size(size);
		((Control)ll_lbeztkj).set_TabIndex(2);
		ll_lbeztkj.set_Text("支腿跨距");
		((ListControl)ll_lbztkj).set_FormattingEnabled(true);
		ll_lbztkj.set_ItemHeight(12);
		ListBox obj13 = ll_lbztkj;
		location = new Point(269, 90);
		((Control)obj13).set_Location(location);
		((Control)ll_lbztkj).set_Name("ll_lbztkj");
		ListBox obj14 = ll_lbztkj;
		size = new Size(82, 208);
		((Control)obj14).set_Size(size);
		((Control)ll_lbztkj).set_TabIndex(3);
		((BaseItemControl)ll_lbefbzbl).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbefbzbl).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj15 = ll_lbefbzbl;
		location = new Point(357, 61);
		((Control)obj15).set_Location(location);
		((Control)ll_lbefbzbl).set_Name("ll_lbefbzbl");
		LabelX obj16 = ll_lbefbzbl;
		size = new Size(107, 23);
		((Control)obj16).set_Size(size);
		((Control)ll_lbefbzbl).set_TabIndex(2);
		ll_lbefbzbl.set_Text("副臂主臂长度列表");
		((ListControl)ll_lbfbzbl).set_FormattingEnabled(true);
		ll_lbfbzbl.set_ItemHeight(12);
		ListBox obj17 = ll_lbfbzbl;
		location = new Point(357, 90);
		((Control)obj17).set_Location(location);
		((Control)ll_lbfbzbl).set_Name("ll_lbfbzbl");
		ListBox obj18 = ll_lbfbzbl;
		size = new Size(107, 208);
		((Control)obj18).set_Size(size);
		((Control)ll_lbfbzbl).set_TabIndex(3);
		((BaseItemControl)ll_lbefbfbl).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbefbfbl).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj19 = ll_lbefbfbl;
		location = new Point(470, 61);
		((Control)obj19).set_Location(location);
		((Control)ll_lbefbfbl).set_Name("ll_lbefbfbl");
		LabelX obj20 = ll_lbefbfbl;
		size = new Size(106, 23);
		((Control)obj20).set_Size(size);
		((Control)ll_lbefbfbl).set_TabIndex(2);
		ll_lbefbfbl.set_Text("副臂副臂长度列表");
		((ListControl)ll_lbfbfbl).set_FormattingEnabled(true);
		ll_lbfbfbl.set_ItemHeight(12);
		ListBox obj21 = ll_lbfbfbl;
		location = new Point(470, 90);
		((Control)obj21).set_Location(location);
		((Control)ll_lbfbfbl).set_Name("ll_lbfbfbl");
		ListBox obj22 = ll_lbfbfbl;
		size = new Size(106, 208);
		((Control)obj22).set_Size(size);
		((Control)ll_lbfbfbl).set_TabIndex(3);
		((BaseItemControl)ll_lbefbzbxt).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbefbzbxt).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj23 = ll_lbefbzbxt;
		location = new Point(582, 61);
		((Control)obj23).set_Location(location);
		((Control)ll_lbefbzbxt).set_Name("ll_lbefbzbxt");
		LabelX obj24 = ll_lbefbzbxt;
		size = new Size(104, 23);
		((Control)obj24).set_Size(size);
		((Control)ll_lbefbzbxt).set_TabIndex(2);
		ll_lbefbzbxt.set_Text("副臂主臂仰角列表");
		((ListControl)ll_lbfbzbxt).set_FormattingEnabled(true);
		ll_lbfbzbxt.set_ItemHeight(12);
		ListBox obj25 = ll_lbfbzbxt;
		location = new Point(582, 90);
		((Control)obj25).set_Location(location);
		((Control)ll_lbfbzbxt).set_Name("ll_lbfbzbxt");
		ListBox obj26 = ll_lbfbzbxt;
		size = new Size(104, 208);
		((Control)obj26).set_Size(size);
		((Control)ll_lbfbzbxt).set_TabIndex(3);
		((BaseItemControl)ll_lbefbzbfixxt).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbefbzbfixxt).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj27 = ll_lbefbzbfixxt;
		location = new Point(692, 61);
		((Control)obj27).set_Location(location);
		((Control)ll_lbefbzbfixxt).set_Name("ll_lbefbzbfixxt");
		LabelX obj28 = ll_lbefbzbfixxt;
		size = new Size(117, 23);
		((Control)obj28).set_Size(size);
		((Control)ll_lbefbzbfixxt).set_TabIndex(2);
		ll_lbefbzbfixxt.set_Text("副臂主臂安装角列表");
		((ListControl)ll_lbfbzbfixxt).set_FormattingEnabled(true);
		ll_lbfbzbfixxt.set_ItemHeight(12);
		ListBox obj29 = ll_lbfbzbfixxt;
		location = new Point(692, 90);
		((Control)obj29).set_Location(location);
		((Control)ll_lbfbzbfixxt).set_Name("ll_lbfbzbfixxt");
		ListBox obj30 = ll_lbfbzbfixxt;
		size = new Size(117, 208);
		((Control)obj30).set_Size(size);
		((Control)ll_lbfbzbfixxt).set_TabIndex(3);
		((Control)ll_btnsearchini).set_AccessibleRole((AccessibleRole)43);
		ll_btnsearchini.set_ColorTable((eButtonColor)3);
		ButtonX obj31 = ll_btnsearchini;
		location = new Point(582, 304);
		((Control)obj31).set_Location(location);
		((Control)ll_btnsearchini).set_Name("ll_btnsearchini");
		ButtonX obj32 = ll_btnsearchini;
		size = new Size(104, 23);
		((Control)obj32).set_Size(size);
		((PopupItemControl)ll_btnsearchini).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnsearchini).set_TabIndex(0);
		ll_btnsearchini.set_Text("搜索生成ini");
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ButtonX obj33 = ll_btnexit;
		location = new Point(692, 304);
		((Control)obj33).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj34 = ll_btnexit;
		size = new Size(113, 23);
		((Control)obj34).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(0);
		ll_btnexit.set_Text("关闭");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX8;
		location = new Point(12, 304);
		((Control)labelX3).set_Location(location);
		((Control)LabelX8).set_Name("LabelX8");
		LabelX labelX4 = LabelX8;
		size = new Size(105, 23);
		((Control)labelX4).set_Size(size);
		((Control)LabelX8).set_TabIndex(2);
		LabelX8.set_Text("操作流程信息");
		((ListControl)ll_lbliucheng).set_FormattingEnabled(true);
		ll_lbliucheng.set_ItemHeight(12);
		ListBox obj35 = ll_lbliucheng;
		location = new Point(12, 333);
		((Control)obj35).set_Location(location);
		((Control)ll_lbliucheng).set_Name("ll_lbliucheng");
		ListBox obj36 = ll_lbliucheng;
		size = new Size(797, 148);
		((Control)obj36).set_Size(size);
		((Control)ll_lbliucheng).set_TabIndex(3);
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(817, 497);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ll_lbfbzbfixxt);
		((Control)this).get_Controls().Add((Control)(object)ll_lbefbzbfixxt);
		((Control)this).get_Controls().Add((Control)(object)ll_lbfbzbxt);
		((Control)this).get_Controls().Add((Control)(object)ll_lbefbzbxt);
		((Control)this).get_Controls().Add((Control)(object)ll_lbfbfbl);
		((Control)this).get_Controls().Add((Control)(object)ll_lbefbfbl);
		((Control)this).get_Controls().Add((Control)(object)ll_lbfbzbl);
		((Control)this).get_Controls().Add((Control)(object)ll_lbefbzbl);
		((Control)this).get_Controls().Add((Control)(object)ll_lbztkj);
		((Control)this).get_Controls().Add((Control)(object)ll_lbeztkj);
		((Control)this).get_Controls().Add((Control)(object)ll_lbpz);
		((Control)this).get_Controls().Add((Control)(object)ll_lbepz);
		((Control)this).get_Controls().Add((Control)(object)ll_lbliucheng);
		((Control)this).get_Controls().Add((Control)(object)ll_lbJieGouXingShi);
		((Control)this).get_Controls().Add((Control)(object)LabelX8);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)ll_txtxnlibspath);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_btnsearchini);
		((Control)this).get_Controls().Add((Control)(object)ll_btnspecialxnlibs);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufxnbsearchini");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("性能表ini信息文件创建...");
		((Control)this).ResumeLayout(false);
	}

	private void ll_btnspecialxnlibs_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("请指定单项性能表所在路径");
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			Mod1.strpath = val.get_SelectedPath();
		}
		checked
		{
			if (Operators.CompareString(Strings.Trim(Mod1.strpath), "", false) != 0)
			{
				int num = Strings.InStrRev(Mod1.strpath, "\\", -1, (CompareMethod)0);
				string text = Strings.Right(Mod1.strpath, Strings.Len(Mod1.strpath) - num);
				switch (Strings.Trim(text))
				{
				case "主臂":
				case "主臂+固定副臂":
				case "主臂+塔式副臂":
				case "主臂+超起":
				case "主臂+固定副臂+超起":
				case "主臂+塔式副臂+超起":
					Mod1.strpath = Strings.Left(Mod1.strpath, num - 1);
					Interaction.MsgBox((object)("当前选择的路径不合适,以自动更改为：" + Mod1.strpath), (MsgBoxStyle)0, (object)null);
					break;
				}
				curxnlibs = Mod1.strpath;
				((TextBox)ll_txtxnlibspath).set_Text(Mod1.strpath);
				ll_lbliucheng.get_Items().Add((object)"");
				ll_lbliucheng.get_Items().Add((object)("当前搜索路径为:" + curxnlibs));
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				ll_lbJieGouXingShi.get_Items().Clear();
				ll_lbpz.get_Items().Clear();
				ll_lbztkj.get_Items().Clear();
				ll_lbfbzbl.get_Items().Clear();
				ll_lbfbfbl.get_Items().Clear();
				ll_lbfbzbxt.get_Items().Clear();
				ll_lbfbzbfixxt.get_Items().Clear();
				if (Directory.Exists(curxnlibs + "\\主臂"))
				{
					ll_lbJieGouXingShi.get_Items().Add((object)"主臂");
				}
				if (Directory.Exists(curxnlibs + "\\主臂+固定副臂"))
				{
					ll_lbJieGouXingShi.get_Items().Add((object)"主臂+固定副臂");
				}
				if (Directory.Exists(curxnlibs + "\\主臂+塔式副臂"))
				{
					ll_lbJieGouXingShi.get_Items().Add((object)"主臂+塔式副臂");
				}
				if (Directory.Exists(curxnlibs + "\\主臂+超起"))
				{
					ll_lbJieGouXingShi.get_Items().Add((object)"主臂+超起");
				}
				if (Directory.Exists(curxnlibs + "\\主臂+固定副臂+超起"))
				{
					ll_lbJieGouXingShi.get_Items().Add((object)"主臂+固定副臂+超起");
				}
				if (Directory.Exists(curxnlibs + "\\主臂+塔式副臂+超起"))
				{
					ll_lbJieGouXingShi.get_Items().Add((object)"主臂+塔式副臂+超起");
				}
				((Control)ll_btnspecialxnlibs).set_ForeColor(Color.Green);
			}
		}
	}

	private void ll_ufxnbsearchini_Load(object sender, EventArgs e)
	{
		((Control)ll_btnspecialxnlibs).set_ForeColor(Color.Red);
	}

	public void fbinfo(bool bfbyx)
	{
		string text = curstrpath + "\\" + stryx + "\\" + strxt + "\\半伸_支腿.xls";
		if (File.Exists(text))
		{
			add2curlis(ll_lbztkj, "半伸");
			fbpzandother(text, bfbyx, bpz: true);
		}
		text = curstrpath + "\\" + stryx + "\\" + strxt + "\\全伸_支腿.xls";
		if (File.Exists(text))
		{
			add2curlis(ll_lbztkj, "全伸");
			fbpzandother(text, bfbyx, bpz: true);
		}
		text = curstrpath + "\\" + stryx + "\\" + strxt + "\\半伸_倾翻.xls";
		if (File.Exists(text))
		{
			add2curlis(ll_lbztkj, "半伸");
			fbpzandother(text, bfbyx, bpz: true);
		}
		text = curstrpath + "\\" + stryx + "\\" + strxt + "\\全伸_倾翻.xls";
		if (File.Exists(text))
		{
			add2curlis(ll_lbztkj, "全伸");
			fbpzandother(text, bfbyx, bpz: true);
		}
		text = curstrpath + "\\" + stryx + "\\" + strxt + "\\回转支承.xls";
		if (File.Exists(text))
		{
			fbpzandother(text, bfbyx, bpz: true);
		}
		text = curstrpath + "\\" + stryx + "\\" + strxt + "\\强度.xls";
		if (File.Exists(text))
		{
			fbpzandother(text, bfbyx, bpz: false);
		}
		text = curstrpath + "\\" + stryx + "\\" + strxt + "\\刚度.xls";
		if (File.Exists(text))
		{
			fbpzandother(text, bfbyx, bpz: false);
		}
		text = curstrpath + "\\" + stryx + "\\" + strxt + "\\变幅缸.xls";
		if (File.Exists(text))
		{
			fbpzandother(text, bfbyx, bpz: false);
		}
		text = curstrpath + "\\" + stryx + "\\" + strxt + "\\超起钢丝绳.xls";
		if (File.Exists(text))
		{
			fbpzandother(text, bfbyx, bpz: false);
		}
	}

	private void add2curlis(ListBox curlb2, string curv)
	{
		Application.DoEvents();
		bool flag = false;
		checked
		{
			int num = curlb2.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(Strings.Trim(Conversions.ToString(curlb2.get_Items().get_Item(i))), Strings.Trim(curv), false) == 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag & (Operators.CompareString(Strings.Trim(curv), "", false) != 0))
			{
				curlb2.get_Items().Add((object)curv);
			}
		}
	}

	private void inputini2cur(string fname)
	{
		ll_lbpz.get_Items().Clear();
		ll_lbztkj.get_Items().Clear();
		ll_lbfbzbl.get_Items().Clear();
		ll_lbfbfbl.get_Items().Clear();
		ll_lbfbzbxt.get_Items().Clear();
		ll_lbfbzbfixxt.get_Items().Clear();
		((Control)ll_lbepz).set_ForeColor(Color.Green);
		((Control)ll_lbeztkj).set_ForeColor(Color.Green);
		((Control)ll_lbefbzbl).set_ForeColor(Color.Green);
		((Control)ll_lbefbfbl).set_ForeColor(Color.Green);
		((Control)ll_lbefbzbxt).set_ForeColor(Color.Green);
		((Control)ll_lbefbzbfixxt).set_ForeColor(Color.Green);
		if (!File.Exists(fname))
		{
			return;
		}
		Mod1.lr = new StreamReader(fname, Encoding.Default);
		checked
		{
			while (true)
			{
				string text = Mod1.lr.ReadLine();
				if (Operators.CompareString(text, "", false) == 0)
				{
					break;
				}
				string[] array = Strings.Split(text, "_", -1, (CompareMethod)0);
				if (Operators.CompareString(array[0], "配重", false) == 0)
				{
					((Control)ll_lbepz).set_ForeColor(Color.Green);
					string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
					string[] array3 = array2;
					for (int i = 0; i < array3.Length; i++)
					{
						text = array3[i];
						ll_lbpz.get_Items().Add((object)text);
					}
				}
				if (Operators.CompareString(array[0], "支腿跨距", false) == 0)
				{
					((Control)ll_lbeztkj).set_BackColor(Color.Green);
					string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
					string[] array4 = array2;
					for (int j = 0; j < array4.Length; j++)
					{
						text = array4[j];
						ll_lbztkj.get_Items().Add((object)text);
					}
				}
				if (Operators.CompareString(array[0], "副臂主臂长度列表", false) == 0)
				{
					((Control)ll_lbefbzbl).set_BackColor(Color.Green);
					string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
					string[] array5 = array2;
					for (int k = 0; k < array5.Length; k++)
					{
						text = array5[k];
						ll_lbfbzbl.get_Items().Add((object)text);
					}
				}
				if (Operators.CompareString(array[0], "副臂副臂长度列表", false) == 0)
				{
					((Control)ll_lbefbfbl).set_BackColor(Color.Green);
					string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
					string[] array6 = array2;
					for (int l = 0; l < array6.Length; l++)
					{
						text = array6[l];
						ll_lbfbfbl.get_Items().Add((object)text);
					}
				}
				if (Operators.CompareString(array[0], "副臂主臂仰角列表", false) == 0)
				{
					((Control)ll_lbefbzbxt).set_BackColor(Color.Green);
					string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
					string[] array7 = array2;
					for (int m = 0; m < array7.Length; m++)
					{
						text = array7[m];
						ll_lbfbzbxt.get_Items().Add((object)text);
					}
				}
				if (Operators.CompareString(array[0], "副臂主臂安装角列表", false) == 0)
				{
					((Control)ll_lbefbzbfixxt).set_BackColor(Color.Green);
					string[] array2 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
					string[] array8 = array2;
					for (int n = 0; n < array8.Length; n++)
					{
						text = array8[n];
						ll_lbfbzbfixxt.get_Items().Add((object)text);
					}
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void fbsubpathsearch(object curlb, string stryx)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		Mod1.strpath = curstrpath + "\\" + stryx;
		if (Operators.CompareString(Strings.Right(Mod1.strpath, 1), "\\", false) != 0)
		{
			Mod1.strpath += "\\";
		}
		string text = FileSystem.Dir(Mod1.strpath, (FileAttribute)16);
		while (Operators.CompareString(text, "", false) != 0)
		{
			if ((FileSystem.GetAttr(Mod1.strpath + text) & 0x10) == 16 && ((Operators.CompareString(text, ".", false) != 0) & (Operators.CompareString(text, "..", false) != 0)))
			{
				add2curlis((ListBox)curlb, text);
			}
			text = FileSystem.Dir();
		}
	}

	private string lis2str(ListBox curlb2)
	{
		string text = "";
		checked
		{
			if (curlb2.get_Items().get_Count() != 0)
			{
				text = Strings.Trim(Conversions.ToString(curlb2.get_Items().get_Item(0)));
				int num = curlb2.get_Items().get_Count() - 1;
				for (int i = 1; i <= num; i++)
				{
					text = text + "," + Strings.Trim(Conversions.ToString(curlb2.get_Items().get_Item(i)));
				}
			}
			return text;
		}
	}

	private void fbpzandother(string fname, bool bfbyx, bool bpz)
	{
		checked
		{
			Workbook workbook = default(Workbook);
			if (File.Exists(fname))
			{
				workbook = Mod1.excelapp.Workbooks.Open(fname, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = workbook.Worksheets.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Worksheet worksheet = (Worksheet)enumerator.Current;
						if (!((Operators.CompareString(worksheet.Name, "ALL", false) != 0) & (Operators.CompareString(worksheet.Name, "ALLTEMP", false) != 0)))
						{
							continue;
						}
						int num = Strings.InStr(1, worksheet.Name, "_", (CompareMethod)0);
						if (num <= 0)
						{
							continue;
						}
						string[] array = Strings.Split(worksheet.Name, "_", -1, (CompareMethod)0);
						if (bpz)
						{
							add2curlis(ll_lbpz, array[0]);
						}
						if (bfbyx)
						{
							add2curlis(ll_lbfbfbl, array[1]);
							int count = worksheet.Columns.Count;
							int num2 = count;
							for (int i = 1; i <= num2; i++)
							{
								add2curlis(ll_lbfbzbl, Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[1, i], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
							}
						}
						else
						{
							add2curlis(ll_lbfbzbl, array[1]);
							int count = worksheet.Columns.Count;
							int num3 = count;
							for (int j = 1; j <= num3; j++)
							{
								add2curlis(ll_lbfbfbl, Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[1, j], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
							}
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			workbook.Saved = true;
			workbook.Close(Missing.Value, Missing.Value, Missing.Value);
			ll_lbliucheng.get_Items().Add((object)("搜索了文件:" + fname));
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	private void zbpz(string fname)
	{
		Workbook workbook = default(Workbook);
		if (File.Exists(fname))
		{
			workbook = Mod1.excelapp.Workbooks.Open(fname, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = workbook.Worksheets.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Worksheet worksheet = (Worksheet)enumerator.Current;
					if ((Operators.CompareString(worksheet.Name, "ALL", false) != 0) & (Operators.CompareString(worksheet.Name, "ALLTEMP", false) != 0))
					{
						add2curlis(ll_lbpz, worksheet.Name);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		workbook.Saved = true;
		workbook.Close(Missing.Value, Missing.Value, Missing.Value);
		ll_lbliucheng.get_Items().Add((object)("搜索了文件:" + fname));
		ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
	}

	private void ll_btnsearchini_Click(object sender, EventArgs e)
	{
		if (ll_lbJieGouXingShi.get_SelectedIndex() == -1)
		{
			return;
		}
		ll_lbliucheng.get_Items().Add((object)("当前处理的结构形式为:" + ll_lbJieGouXingShi.get_Text()));
		checked
		{
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
			ll_lbpz.get_Items().Clear();
			ll_lbztkj.get_Items().Clear();
			ll_lbfbzbl.get_Items().Clear();
			ll_lbfbfbl.get_Items().Clear();
			ll_lbfbzbxt.get_Items().Clear();
			ll_lbfbzbfixxt.get_Items().Clear();
			((Control)ll_lbepz).set_ForeColor(Color.Green);
			((Control)ll_lbeztkj).set_ForeColor(Color.Green);
			((Control)ll_lbefbzbl).set_ForeColor(Color.Green);
			((Control)ll_lbefbfbl).set_ForeColor(Color.Green);
			((Control)ll_lbefbzbfixxt).set_ForeColor(Color.Green);
			curjgxs = ll_lbJieGouXingShi.get_Text();
			curxnlibs = ((TextBox)ll_txtxnlibspath).get_Text();
			curstrpath = curxnlibs + "\\" + curjgxs;
			string text = default(string);
			switch (curjgxs)
			{
			default:
				ll_lbliucheng.get_Items().Add((object)("不合法的结构形式:" + ll_lbJieGouXingShi.get_Text()));
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				break;
			case "主臂+塔式副臂":
			case "主臂+塔式副臂+超起":
				((Control)ll_lbepz).set_ForeColor(Color.Green);
				((Control)ll_lbeztkj).set_ForeColor(Color.Green);
				((Control)ll_lbefbzbl).set_ForeColor(Color.Green);
				((Control)ll_lbefbfbl).set_ForeColor(Color.Green);
				((Control)ll_lbefbzbxt).set_ForeColor(Color.Green);
				stryx = "副臂优先";
				if (Directory.Exists(curstrpath + "\\" + stryx))
				{
					fbsubpathsearch(ll_lbfbzbxt, stryx);
				}
				stryx = "主臂优先";
				if (Directory.Exists(curstrpath + "\\" + stryx))
				{
					fbsubpathsearch(ll_lbfbzbxt, stryx);
				}
				stryx = "副臂优先";
				if (Directory.Exists(curstrpath + "\\" + stryx))
				{
					int num = ll_lbfbzbxt.get_Items().get_Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						strxt = Conversions.ToString(ll_lbfbzbxt.get_Items().get_Item(i));
						fbinfo(bfbyx: true);
					}
				}
				stryx = "主臂优先";
				if (Directory.Exists(curstrpath + "\\" + stryx))
				{
					int num2 = ll_lbfbzbxt.get_Items().get_Count() - 1;
					for (int j = 0; j <= num2; j++)
					{
						strxt = Conversions.ToString(ll_lbfbzbxt.get_Items().get_Item(j));
						fbinfo(bfbyx: false);
					}
				}
				text = curstrpath + "\\" + curjgxs + ".ini";
				Mod1.wr = new StreamWriter(text, append: false, Encoding.Default);
				Mod1.wr.WriteLine(ll_lbefbzbxt.get_Text() + "_" + lis2str(ll_lbfbzbxt) + ",ALL");
				Mod1.wr.WriteLine(ll_lbefbfbl.get_Text() + "_" + lis2str(ll_lbfbfbl) + ",ALL");
				Mod1.wr.WriteLine(ll_lbefbzbl.get_Text() + "_" + lis2str(ll_lbfbzbl) + ",ALL");
				Mod1.wr.WriteLine(ll_lbepz.get_Text() + "_" + lis2str(ll_lbpz) + ",ALL");
				Mod1.wr.WriteLine(ll_lbeztkj.get_Text() + "_" + lis2str(ll_lbztkj) + ",ALL");
				Mod1.wr.Close();
				Mod1.wr.Dispose();
				((Control)ll_lbepz).set_ForeColor(Color.Green);
				((Control)ll_lbeztkj).set_ForeColor(Color.Green);
				((Control)ll_lbefbzbl).set_ForeColor(Color.Green);
				((Control)ll_lbefbfbl).set_ForeColor(Color.Green);
				((Control)ll_lbefbzbxt).set_ForeColor(Color.Green);
				break;
			case "主臂+固定副臂":
			case "主臂+固定副臂+超起":
				((Control)ll_lbepz).set_ForeColor(Color.Green);
				((Control)ll_lbeztkj).set_ForeColor(Color.Green);
				((Control)ll_lbefbzbl).set_ForeColor(Color.Green);
				((Control)ll_lbefbfbl).set_ForeColor(Color.Green);
				((Control)ll_lbefbzbfixxt).set_ForeColor(Color.Green);
				stryx = "副臂优先";
				if (Directory.Exists(curstrpath + "\\" + stryx))
				{
					fbsubpathsearch(ll_lbfbzbfixxt, stryx);
				}
				stryx = "主臂优先";
				if (Directory.Exists(curstrpath + "\\" + stryx))
				{
					fbsubpathsearch(ll_lbfbzbfixxt, stryx);
				}
				stryx = "副臂优先";
				if (Directory.Exists(curstrpath + "\\" + stryx))
				{
					int num3 = ll_lbfbzbfixxt.get_Items().get_Count() - 1;
					for (int k = 0; k <= num3; k++)
					{
						strxt = Conversions.ToString(ll_lbfbzbfixxt.get_Items().get_Item(k));
						fbinfo(bfbyx: true);
					}
				}
				stryx = "主臂优先";
				if (Directory.Exists(curstrpath + "\\" + stryx))
				{
					int num4 = ll_lbfbzbfixxt.get_Items().get_Count() - 1;
					for (int l = 0; l <= num4; l++)
					{
						strxt = Conversions.ToString(ll_lbfbzbfixxt.get_Items().get_Item(l));
						fbinfo(bfbyx: false);
					}
				}
				text = curstrpath + "\\" + curjgxs + ".ini";
				Mod1.wr = new StreamWriter(text, append: false, Encoding.Default);
				Mod1.wr.WriteLine(ll_lbefbzbfixxt.get_Text() + "_" + lis2str(ll_lbfbzbfixxt) + ",ALL");
				Mod1.wr.WriteLine(ll_lbefbfbl.get_Text() + "_" + lis2str(ll_lbfbfbl) + ",ALL");
				Mod1.wr.WriteLine(ll_lbefbzbl.get_Text() + "_" + lis2str(ll_lbfbzbl) + ",ALL");
				Mod1.wr.WriteLine(ll_lbepz.get_Text() + "_" + lis2str(ll_lbpz) + ",ALL");
				Mod1.wr.WriteLine(ll_lbeztkj.get_Text() + "_" + lis2str(ll_lbztkj) + ",ALL");
				Mod1.wr.Close();
				Mod1.wr.Dispose();
				((Control)ll_lbepz).set_ForeColor(Color.Green);
				((Control)ll_lbeztkj).set_ForeColor(Color.Green);
				((Control)ll_lbefbzbl).set_ForeColor(Color.Green);
				((Control)ll_lbefbfbl).set_ForeColor(Color.Green);
				((Control)ll_lbefbzbfixxt).set_ForeColor(Color.Green);
				break;
			case "主臂":
			case "主臂+超起":
				((Control)ll_lbepz).set_ForeColor(Color.Green);
				((Control)ll_lbeztkj).set_ForeColor(Color.Green);
				text = curstrpath + "\\半伸_支腿.xls";
				if (File.Exists(text))
				{
					add2curlis(ll_lbztkj, "半伸");
					zbpz(text);
				}
				text = curstrpath + "\\全伸_支腿.xls";
				if (File.Exists(text))
				{
					add2curlis(ll_lbztkj, "全伸");
					zbpz(text);
				}
				text = curstrpath + "\\半伸_倾翻.xls";
				if (File.Exists(text))
				{
					add2curlis(ll_lbztkj, "半伸");
					zbpz(text);
				}
				text = curstrpath + "\\全伸_倾翻.xls";
				if (File.Exists(text))
				{
					add2curlis(ll_lbztkj, "全伸");
					zbpz(text);
				}
				text = curstrpath + "\\回转支承.xls";
				if (File.Exists(text))
				{
					zbpz(text);
				}
				text = curstrpath + "\\" + curjgxs + ".ini";
				Mod1.wr = new StreamWriter(text, append: false, Encoding.Default);
				Mod1.wr.WriteLine(ll_lbepz.get_Text() + "_" + lis2str(ll_lbpz) + ",ALL");
				Mod1.wr.WriteLine(ll_lbeztkj.get_Text() + "_" + lis2str(ll_lbztkj) + ",ALL");
				Mod1.wr.Close();
				Mod1.wr.Dispose();
				((Control)ll_lbepz).set_ForeColor(Color.Green);
				((Control)ll_lbeztkj).set_ForeColor(Color.Green);
				break;
			}
			ll_lbliucheng.get_Items().Add((object)"");
			ll_lbliucheng.get_Items().Add((object)("生成了ini信息文件:" + text));
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	private void ll_btnexit_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lbliucheng.get_Items().get_Count() != 0)
			{
				int num = ll_lbliucheng.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.Main.lslog.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_lbliucheng.get_Items().get_Item(i)));
				}
			}
			((Form)this).Close();
		}
	}
}
