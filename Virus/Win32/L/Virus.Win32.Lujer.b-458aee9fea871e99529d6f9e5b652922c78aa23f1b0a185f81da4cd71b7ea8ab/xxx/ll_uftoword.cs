using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Excel;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class ll_uftoword : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("ll_btnxlspath")]
	private ButtonX _ll_btnxlspath;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("ll_lbecurpath")]
	private LabelX _ll_lbecurpath;

	[AccessedThroughProperty("ll_lbxlslist")]
	private ListBox _ll_lbxlslist;

	[AccessedThroughProperty("ll_btntoword")]
	private ButtonX _ll_btntoword;

	[AccessedThroughProperty("ll_btnwordformat")]
	private ButtonX _ll_btnwordformat;

	[AccessedThroughProperty("ll_btnlookword")]
	private ButtonX _ll_btnlookword;

	[AccessedThroughProperty("ll_btnchecklog")]
	private ButtonX _ll_btnchecklog;

	[AccessedThroughProperty("ll_btnall")]
	private ButtonX _ll_btnall;

	[AccessedThroughProperty("ll_btnallother")]
	private ButtonX _ll_btnallother;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("ll_lbliucheng")]
	private ListBox _ll_lbliucheng;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("ll_lbecurpro")]
	private LabelX _ll_lbecurpro;

	[AccessedThroughProperty("LabelProgress")]
	private ProgressBarX _LabelProgress;

	[AccessedThroughProperty("FrameProgress")]
	private LabelX _FrameProgress;

	[AccessedThroughProperty("cldisplay")]
	private CheckBoxX _cldisplay;

	private int limitcols;

	private string limitbt;

	private bool limitcolsFind;

	private string testdoc;

	private string testlog;

	private object wdmyrange;

	private Style wdstyle;

	private Microsoft.Office.Interop.Word.Application wdapp;

	private Document wdDoc;

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

	internal virtual LabelX LabelX2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX2 = value;
		}
	}

	internal virtual ButtonX ll_btnxlspath
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnxlspath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnxlspath_Click;
			if (_ll_btnxlspath != null)
			{
				((Control)_ll_btnxlspath).remove_Click(eventHandler);
			}
			_ll_btnxlspath = value;
			if (_ll_btnxlspath != null)
			{
				((Control)_ll_btnxlspath).add_Click(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX3
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX3 = value;
		}
	}

	internal virtual LabelX ll_lbecurpath
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbecurpath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbecurpath = value;
		}
	}

	internal virtual ListBox ll_lbxlslist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbxlslist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbxlslist_SelectedIndexChanged;
			if (_ll_lbxlslist != null)
			{
				_ll_lbxlslist.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbxlslist = value;
			if (_ll_lbxlslist != null)
			{
				_ll_lbxlslist.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btntoword
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btntoword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btntoword_Click;
			if (_ll_btntoword != null)
			{
				((Control)_ll_btntoword).remove_Click(eventHandler);
			}
			_ll_btntoword = value;
			if (_ll_btntoword != null)
			{
				((Control)_ll_btntoword).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnwordformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnwordformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnwordformat_Click;
			if (_ll_btnwordformat != null)
			{
				((Control)_ll_btnwordformat).remove_Click(eventHandler);
			}
			_ll_btnwordformat = value;
			if (_ll_btnwordformat != null)
			{
				((Control)_ll_btnwordformat).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnlookword
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnlookword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnlookword_Click;
			if (_ll_btnlookword != null)
			{
				((Control)_ll_btnlookword).remove_Click(eventHandler);
			}
			_ll_btnlookword = value;
			if (_ll_btnlookword != null)
			{
				((Control)_ll_btnlookword).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnchecklog
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnchecklog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnchecklog_Click;
			if (_ll_btnchecklog != null)
			{
				((Control)_ll_btnchecklog).remove_Click(eventHandler);
			}
			_ll_btnchecklog = value;
			if (_ll_btnchecklog != null)
			{
				((Control)_ll_btnchecklog).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnall
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnall_Click;
			if (_ll_btnall != null)
			{
				((Control)_ll_btnall).remove_Click(eventHandler);
			}
			_ll_btnall = value;
			if (_ll_btnall != null)
			{
				((Control)_ll_btnall).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnallother
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnallother;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnallother_Click;
			if (_ll_btnallother != null)
			{
				((Control)_ll_btnallother).remove_Click(eventHandler);
			}
			_ll_btnallother = value;
			if (_ll_btnallother != null)
			{
				((Control)_ll_btnallother).add_Click(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX5
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX5 = value;
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

	internal virtual LabelX LabelX4
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX4 = value;
		}
	}

	internal virtual LabelX ll_lbecurpro
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbecurpro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbecurpro = value;
		}
	}

	internal virtual ProgressBarX LabelProgress
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelProgress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelProgress = value;
		}
	}

	internal virtual LabelX FrameProgress
	{
		[DebuggerNonUserCode]
		get
		{
			return _FrameProgress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FrameProgress = value;
		}
	}

	internal virtual CheckBoxX cldisplay
	{
		[DebuggerNonUserCode]
		get
		{
			return _cldisplay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cldisplay_CheckedChanged;
			if (_cldisplay != null)
			{
				_cldisplay.remove_CheckedChanged(eventHandler);
			}
			_cldisplay = value;
			if (_cldisplay != null)
			{
				_cldisplay.add_CheckedChanged(eventHandler);
			}
		}
	}

	public ll_uftoword()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(ll_uftoword_FormClosed));
		((Form)this).add_Load((EventHandler)ll_uftoword_Load);
		Guid clsid = new Guid("000209FF-0000-0000-C000-000000000046");
		wdapp = (Microsoft.Office.Interop.Word.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba3: Expected O, but got Unknown
		//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ll_uftoword));
		LabelX1 = new LabelX();
		LabelX2 = new LabelX();
		ll_btnxlspath = new ButtonX();
		LabelX3 = new LabelX();
		ll_lbecurpath = new LabelX();
		ll_lbxlslist = new ListBox();
		ll_btntoword = new ButtonX();
		ll_btnwordformat = new ButtonX();
		ll_btnlookword = new ButtonX();
		ll_btnchecklog = new ButtonX();
		ll_btnall = new ButtonX();
		ll_btnallother = new ButtonX();
		LabelX5 = new LabelX();
		ll_lbliucheng = new ListBox();
		ll_btnexit = new ButtonX();
		LabelX4 = new LabelX();
		ll_lbecurpro = new LabelX();
		LabelProgress = new ProgressBarX();
		FrameProgress = new LabelX();
		cldisplay = new CheckBoxX();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(12, 12);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(62, 16);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("说明：");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(12, 41);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(727, 159);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(0);
		LabelX2.set_Text(componentResourceManager.GetString("LabelX2.Text"));
		LabelX2.set_TextLineAlignment((StringAlignment)0);
		LabelX2.set_WordWrap(true);
		((Control)ll_btnxlspath).set_AccessibleRole((AccessibleRole)43);
		ll_btnxlspath.set_ColorTable((eButtonColor)3);
		ButtonX obj = ll_btnxlspath;
		location = new Point(12, 206);
		((Control)obj).set_Location(location);
		((Control)ll_btnxlspath).set_Name("ll_btnxlspath");
		ButtonX obj2 = ll_btnxlspath;
		size = new Size(148, 23);
		((Control)obj2).set_Size(size);
		((PopupItemControl)ll_btnxlspath).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnxlspath).set_TabIndex(1);
		ll_btnxlspath.set_Text("指定待处理的xls文件夹");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX3;
		location = new Point(166, 206);
		((Control)labelX5).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX6 = LabelX3;
		size = new Size(99, 23);
		((Control)labelX6).set_Size(size);
		((Control)LabelX3).set_TabIndex(0);
		LabelX3.set_Text("当前处理路径:");
		((BaseItemControl)ll_lbecurpath).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbecurpath).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj3 = ll_lbecurpath;
		location = new Point(271, 206);
		((Control)obj3).set_Location(location);
		((Control)ll_lbecurpath).set_Name("ll_lbecurpath");
		LabelX obj4 = ll_lbecurpath;
		size = new Size(449, 23);
		((Control)obj4).set_Size(size);
		((Control)ll_lbecurpath).set_TabIndex(0);
		((ListControl)ll_lbxlslist).set_FormattingEnabled(true);
		ll_lbxlslist.set_ItemHeight(12);
		ListBox obj5 = ll_lbxlslist;
		location = new Point(12, 235);
		((Control)obj5).set_Location(location);
		((Control)ll_lbxlslist).set_Name("ll_lbxlslist");
		ll_lbxlslist.set_SelectionMode((SelectionMode)2);
		ListBox obj6 = ll_lbxlslist;
		size = new Size(552, 112);
		((Control)obj6).set_Size(size);
		((Control)ll_lbxlslist).set_TabIndex(2);
		((Control)ll_btntoword).set_AccessibleRole((AccessibleRole)43);
		ll_btntoword.set_ColorTable((eButtonColor)3);
		ButtonX obj7 = ll_btntoword;
		location = new Point(583, 235);
		((Control)obj7).set_Location(location);
		((Control)ll_btntoword).set_Name("ll_btntoword");
		ButtonX obj8 = ll_btntoword;
		size = new Size(148, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)ll_btntoword).set_Style((eDotNetBarStyle)7);
		((Control)ll_btntoword).set_TabIndex(1);
		ll_btntoword.set_Text("ToWord");
		((Control)ll_btnwordformat).set_AccessibleRole((AccessibleRole)43);
		ll_btnwordformat.set_ColorTable((eButtonColor)3);
		ButtonX obj9 = ll_btnwordformat;
		location = new Point(583, 264);
		((Control)obj9).set_Location(location);
		((Control)ll_btnwordformat).set_Name("ll_btnwordformat");
		ButtonX obj10 = ll_btnwordformat;
		size = new Size(148, 23);
		((Control)obj10).set_Size(size);
		((PopupItemControl)ll_btnwordformat).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnwordformat).set_TabIndex(1);
		ll_btnwordformat.set_Text("Word格式处理");
		((Control)ll_btnlookword).set_AccessibleRole((AccessibleRole)43);
		ll_btnlookword.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = ll_btnlookword;
		location = new Point(583, 293);
		((Control)obj11).set_Location(location);
		((Control)ll_btnlookword).set_Name("ll_btnlookword");
		ButtonX obj12 = ll_btnlookword;
		size = new Size(148, 23);
		((Control)obj12).set_Size(size);
		((PopupItemControl)ll_btnlookword).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnlookword).set_TabIndex(1);
		ll_btnlookword.set_Text("浏览Word文件夹");
		((Control)ll_btnchecklog).set_AccessibleRole((AccessibleRole)43);
		ll_btnchecklog.set_ColorTable((eButtonColor)3);
		ButtonX obj13 = ll_btnchecklog;
		location = new Point(583, 322);
		((Control)obj13).set_Location(location);
		((Control)ll_btnchecklog).set_Name("ll_btnchecklog");
		ButtonX obj14 = ll_btnchecklog;
		size = new Size(148, 23);
		((Control)obj14).set_Size(size);
		((PopupItemControl)ll_btnchecklog).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnchecklog).set_TabIndex(1);
		ll_btnchecklog.set_Text("查看log文件");
		((Control)ll_btnall).set_AccessibleRole((AccessibleRole)43);
		ll_btnall.set_ColorTable((eButtonColor)3);
		ButtonX obj15 = ll_btnall;
		location = new Point(72, 353);
		((Control)obj15).set_Location(location);
		((Control)ll_btnall).set_Name("ll_btnall");
		ButtonX obj16 = ll_btnall;
		size = new Size(148, 23);
		((Control)obj16).set_Size(size);
		((PopupItemControl)ll_btnall).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnall).set_TabIndex(1);
		ll_btnall.set_Text("全选");
		((Control)ll_btnallother).set_AccessibleRole((AccessibleRole)43);
		ll_btnallother.set_ColorTable((eButtonColor)3);
		ButtonX obj17 = ll_btnallother;
		location = new Point(226, 353);
		((Control)obj17).set_Location(location);
		((Control)ll_btnallother).set_Name("ll_btnallother");
		ButtonX obj18 = ll_btnallother;
		size = new Size(148, 23);
		((Control)obj18).set_Size(size);
		((PopupItemControl)ll_btnallother).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnallother).set_TabIndex(1);
		ll_btnallother.set_Text("反选");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX7 = LabelX5;
		location = new Point(12, 386);
		((Control)labelX7).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX8 = LabelX5;
		size = new Size(148, 23);
		((Control)labelX8).set_Size(size);
		((Control)LabelX5).set_TabIndex(0);
		LabelX5.set_Text("当前操作记录");
		((ListControl)ll_lbliucheng).set_FormattingEnabled(true);
		ll_lbliucheng.set_ItemHeight(12);
		ListBox obj19 = ll_lbliucheng;
		location = new Point(12, 415);
		((Control)obj19).set_Location(location);
		((Control)ll_lbliucheng).set_Name("ll_lbliucheng");
		ListBox obj20 = ll_lbliucheng;
		size = new Size(719, 112);
		((Control)obj20).set_Size(size);
		((Control)ll_lbliucheng).set_TabIndex(2);
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ll_btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj21 = ll_btnexit;
		location = new Point(380, 353);
		((Control)obj21).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj22 = ll_btnexit;
		size = new Size(148, 23);
		((Control)obj22).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(1);
		ll_btnexit.set_Text("关闭");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX9 = LabelX4;
		location = new Point(12, 533);
		((Control)labelX9).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX10 = LabelX4;
		size = new Size(62, 23);
		((Control)labelX10).set_Size(size);
		((Control)LabelX4).set_TabIndex(0);
		LabelX4.set_Text("当前进程:");
		((BaseItemControl)ll_lbecurpro).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbecurpro).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj23 = ll_lbecurpro;
		location = new Point(80, 533);
		((Control)obj23).set_Location(location);
		((Control)ll_lbecurpro).set_Name("ll_lbecurpro");
		LabelX obj24 = ll_lbecurpro;
		size = new Size(140, 23);
		((Control)obj24).set_Size(size);
		((Control)ll_lbecurpro).set_TabIndex(0);
		((BaseItemControl)LabelProgress).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelProgress).get_BackgroundStyle().set_CornerType((eCornerType)1);
		ProgressBarX labelProgress = LabelProgress;
		location = new Point(226, 533);
		((Control)labelProgress).set_Location(location);
		((Control)LabelProgress).set_Name("LabelProgress");
		ProgressBarX labelProgress2 = LabelProgress;
		size = new Size(465, 23);
		((Control)labelProgress2).set_Size(size);
		((Control)LabelProgress).set_TabIndex(3);
		((Control)LabelProgress).set_Text("ProgressBarX1");
		((BaseItemControl)FrameProgress).get_BackgroundStyle().set_Class("");
		((BaseItemControl)FrameProgress).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX frameProgress = FrameProgress;
		location = new Point(699, 533);
		((Control)frameProgress).set_Location(location);
		((Control)FrameProgress).set_Name("FrameProgress");
		LabelX frameProgress2 = FrameProgress;
		size = new Size(32, 23);
		((Control)frameProgress2).set_Size(size);
		((Control)FrameProgress).set_TabIndex(0);
		FrameProgress.set_Text("0%");
		((BaseItemControl)cldisplay).get_BackgroundStyle().set_Class("");
		((BaseItemControl)cldisplay).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj25 = cldisplay;
		location = new Point(583, 353);
		((Control)obj25).set_Location(location);
		((Control)cldisplay).set_Name("cldisplay");
		CheckBoxX obj26 = cldisplay;
		size = new Size(115, 23);
		((Control)obj26).set_Size(size);
		((BaseItemControl)cldisplay).set_Style((eDotNetBarStyle)7);
		((Control)cldisplay).set_TabIndex(8);
		cldisplay.set_Text("处理过程可见");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(743, 564);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)cldisplay);
		((Control)this).get_Controls().Add((Control)(object)LabelProgress);
		((Control)this).get_Controls().Add((Control)(object)ll_lbliucheng);
		((Control)this).get_Controls().Add((Control)(object)ll_lbxlslist);
		((Control)this).get_Controls().Add((Control)(object)ll_btnchecklog);
		((Control)this).get_Controls().Add((Control)(object)ll_btnlookword);
		((Control)this).get_Controls().Add((Control)(object)ll_btnwordformat);
		((Control)this).get_Controls().Add((Control)(object)ll_btntoword);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_btnallother);
		((Control)this).get_Controls().Add((Control)(object)ll_btnall);
		((Control)this).get_Controls().Add((Control)(object)ll_btnxlspath);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)ll_lbecurpath);
		((Control)this).get_Controls().Add((Control)(object)FrameProgress);
		((Control)this).get_Controls().Add((Control)(object)ll_lbecurpro);
		((Control)this).get_Controls().Add((Control)(object)LabelX4);
		((Control)this).get_Controls().Add((Control)(object)LabelX5);
		((Control)this).get_Controls().Add((Control)(object)LabelX3);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_uftoword");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("转换xls表到word中.. .");
		((Control)this).ResumeLayout(false);
	}

	private void ll_btnxlspath_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				FolderBrowserDialog val = new FolderBrowserDialog();
				val.set_Description("请指定某文件夹,要求其中含有Ansys11.0 性能计算成功后输出的基本数据csv文件");
				((CommonDialog)val).ShowDialog();
				string selectedPath = val.get_SelectedPath();
				if (Operators.CompareString(selectedPath, "", false) == 0)
				{
					return;
				}
				string text = selectedPath;
				if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
				{
					ll_lbecurpath.set_Text(text);
					ll_lbliucheng.get_Items().Add((object)("当前要处理的xls路径:" + text));
					string path = ll_lbecurpath.get_Text() + "\\";
					ll_lbxlslist.get_Items().Clear();
					string[] files = Directory.GetFiles(path, "*.xls", SearchOption.AllDirectories);
					int num = files.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						ll_lbxlslist.get_Items().Add((object)files[i]);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ll_btnall_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ll_lbxlslist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				ll_lbxlslist.SetSelected(i, true);
			}
		}
	}

	private void ll_btnallother_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ll_lbxlslist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				if (ll_lbxlslist.GetSelected(i))
				{
					ll_lbxlslist.SetSelected(i, false);
				}
				else
				{
					ll_lbxlslist.SetSelected(i, true);
				}
			}
		}
	}

	private void ll_btnexit_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (ll_lbliucheng.get_Items().get_Count() != 0)
				{
					int num = ll_lbliucheng.get_Items().get_Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						MyProject.Forms.Main.lslog.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_lbliucheng.get_Items().get_Item(i)));
					}
				}
				MyProject.Forms.Main.lslog.set_SelectedIndex(MyProject.Forms.Main.lslog.get_Items().get_Count() - 1);
				if (wdapp != null)
				{
					Microsoft.Office.Interop.Word.Application application = wdapp;
					object SaveChanges = Missing.Value;
					object OriginalFormat = Missing.Value;
					object RouteDocument = Missing.Value;
					application.Quit(ref SaveChanges, ref OriginalFormat, ref RouteDocument);
					wdapp = null;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			((Form)this).Close();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void ll_btntoword_Click(object sender, EventArgs e)
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		Workbook workbook = default(Workbook);
		Worksheet worksheet = default(Worksheet);
		string index = default(string);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		string text = default(string);
		string[] array = default(string[]);
		int num11 = default(int);
		string[] array2 = default(string[]);
		int num12 = default(int);
		string text2 = default(string);
		string text3 = default(string);
		Workbook workbook2 = default(Workbook);
		Worksheet worksheet2 = default(Worksheet);
		Excel.Font font = default(Excel.Font);
		Excel.Range range = default(Excel.Range);
		int num13 = default(int);
		bool flag = default(bool);
		int count = default(int);
		string text4 = default(string);
		Microsoft.Office.Interop.Word.Application application = default(Microsoft.Office.Interop.Word.Application);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					Documents documents;
					Document document;
					Document document2;
					Documents documents2;
					object InsertLineBreaks;
					object Encoding;
					object SaveAsAOCELetter;
					object SaveFormsData;
					object SaveNativePictureFormat;
					object EmbedTrueTypeFonts;
					object ReadOnlyRecommended;
					object WritePassword;
					object AddToRecentFiles;
					object Visible;
					object DocumentType;
					object NewTemplate;
					object Template;
					Selection selection;
					Documents documents3;
					Styles styles;
					Selection selection2;
					Styles styles2;
					Document activeDocument;
					object AddBiDiMarks;
					object LineEnding;
					object AllowSubstitutions;
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						if (ll_lbxlslist.get_Items().get_Count() == 0)
						{
							goto IL_0016;
						}
						goto IL_0034;
					case 3255:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0016;
							case 4:
							case 5:
								goto IL_0034;
							case 6:
								goto IL_003a;
							case 7:
								goto IL_005a;
							case 8:
								goto IL_006c;
							case 9:
							case 10:
								goto IL_0075;
							case 11:
								goto IL_0081;
							case 12:
								goto IL_008a;
							case 14:
							case 15:
								goto IL_00a9;
							case 16:
								goto IL_00bd;
							case 17:
								goto IL_00dc;
							case 18:
								goto IL_00fb;
							case 19:
								goto IL_010c;
							case 22:
								goto IL_012a;
							case 23:
								goto IL_012e;
							case 21:
							case 24:
							case 25:
							case 26:
								goto IL_013d;
							case 27:
								goto IL_0149;
							case 28:
								goto IL_0156;
							case 29:
							case 30:
								goto IL_0161;
							case 31:
								goto IL_016c;
							case 32:
								goto IL_017c;
							case 33:
								goto IL_0185;
							case 34:
								goto IL_01c3;
							case 35:
								goto IL_0270;
							case 36:
								goto IL_029a;
							case 37:
								goto IL_02a3;
							case 38:
								goto IL_0356;
							case 39:
								goto IL_03c0;
							case 40:
								goto IL_03dc;
							case 41:
								goto IL_03e7;
							case 42:
								goto IL_03f3;
							case 43:
								goto IL_0404;
							case 44:
								goto IL_041e;
							case 45:
								goto IL_0425;
							case 46:
								goto IL_0449;
							case 47:
								goto IL_045f;
							case 48:
								goto IL_0472;
							case 49:
								goto IL_048e;
							case 50:
								goto IL_04a1;
							case 51:
								goto IL_04a8;
							case 52:
								goto IL_04b5;
							case 53:
								goto IL_04c5;
							case 54:
								goto IL_04d1;
							case 55:
								goto IL_04db;
							case 56:
								goto IL_050b;
							case 57:
								goto IL_052b;
							case 58:
								goto IL_0537;
							case 59:
								goto IL_054a;
							case 60:
								goto IL_0560;
							case 61:
								goto IL_05bc;
							case 62:
								goto IL_05d5;
							case 63:
								goto IL_05ef;
							case 64:
								goto IL_0609;
							case 65:
								goto IL_061b;
							case 66:
								goto IL_062b;
							case 67:
								goto IL_063b;
							case 68:
								goto IL_064d;
							case 69:
								goto IL_0662;
							case 70:
								goto IL_0665;
							case 71:
								goto IL_067b;
							case 72:
								goto IL_0691;
							case 73:
								goto IL_06b3;
							case 74:
								goto IL_06cf;
							case 75:
								goto IL_06eb;
							case 76:
								goto IL_06f1;
							case 77:
								goto IL_070f;
							case 78:
								goto IL_0748;
							case 79:
								goto IL_075f;
							case 84:
								goto IL_076a;
							case 85:
							case 86:
								goto IL_079c;
							case 81:
							case 82:
								goto IL_07ab;
							case 87:
								goto IL_07ba;
							case 88:
								goto IL_07c6;
							case 89:
								goto IL_07e0;
							case 90:
								goto IL_07fc;
							case 91:
								goto IL_0814;
							case 92:
								goto IL_083e;
							case 93:
							case 94:
								goto IL_0849;
							case 95:
								goto IL_085a;
							case 96:
								goto IL_0866;
							case 97:
								goto IL_08a4;
							case 98:
								goto IL_08b5;
							case 99:
								goto IL_08e3;
							case 100:
								goto IL_08f3;
							case 101:
								goto IL_0906;
							case 102:
								goto IL_0909;
							case 103:
							case 104:
								goto IL_0910;
							case 80:
							case 83:
								goto IL_091f;
							case 105:
								goto IL_092e;
							case 106:
								goto IL_093e;
							case 107:
								goto IL_094c;
							case 108:
								goto IL_095a;
							case 109:
								goto IL_0969;
							case 110:
								goto IL_0983;
							case 111:
								goto IL_0997;
							case 112:
								goto IL_09c6;
							case 113:
								goto IL_09d1;
							case 114:
								goto IL_09dd;
							case 115:
								goto IL_09f1;
							case 116:
								goto IL_0a22;
							case 117:
								goto IL_0a43;
							case 118:
								goto IL_0a4f;
							case 119:
								goto IL_0a64;
							case 120:
							case 121:
								goto IL_0a78;
							case 122:
								goto IL_0a88;
							case 123:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 3:
							case 13:
							case 20:
							case 124:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0a88:
						num = 122;
						((Control)ll_btnwordformat).set_ForeColor(Color.Green);
						break;
						IL_0a78:
						num = 121;
						((Control)ll_btnwordformat).set_Enabled(true);
						goto IL_0a88;
						IL_0016:
						num = 2;
						ll_lbliucheng.get_Items().Add((object)"当前没有任何可处理的表格.");
						goto end_IL_0000_3;
						IL_0034:
						num = 5;
						num5 = 0;
						goto IL_003a;
						IL_003a:
						num = 6;
						num6 = ll_lbxlslist.get_Items().get_Count() - 1;
						num7 = 0;
						goto IL_0054;
						IL_0054:
						if (num7 <= num6)
						{
							goto IL_005a;
						}
						goto IL_0081;
						IL_005a:
						num = 7;
						if (ll_lbxlslist.GetSelected(num7))
						{
							goto IL_006c;
						}
						goto IL_0075;
						IL_006c:
						num = 8;
						num5++;
						goto IL_0075;
						IL_0075:
						num = 10;
						num7++;
						goto IL_0054;
						IL_0081:
						num = 11;
						if (num5 == 0)
						{
							goto IL_008a;
						}
						goto IL_00a9;
						IL_008a:
						num = 12;
						ll_lbliucheng.get_Items().Add((object)"当前没有选择任何要处理的表格.");
						goto end_IL_0000_3;
						IL_00a9:
						num = 15;
						ll_lbecurpro.set_Text("集成xls文件为word");
						goto IL_00bd;
						IL_00bd:
						num = 16;
						testlog = ll_lbecurpath.get_Text() + "\\test.log";
						goto IL_00dc;
						IL_00dc:
						num = 17;
						testdoc = ll_lbecurpath.get_Text() + "\\test.doc";
						goto IL_00fb;
						IL_00fb:
						num = 18;
						if (File.Exists(testdoc))
						{
							goto IL_010c;
						}
						goto IL_013d;
						IL_010c:
						num = 19;
						if (unchecked((int)MessageBox.Show("是否覆盖当前已有的文件?", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64)) == 7)
						{
							goto end_IL_0000_3;
						}
						goto IL_012a;
						IL_012a:
						num = 22;
						goto IL_012e;
						IL_012e:
						num = 23;
						FileSystem.Kill(testdoc);
						goto IL_013d;
						IL_013d:
						num = 26;
						limitcols = 15;
						goto IL_0149;
						IL_0149:
						num = 27;
						if (limitcols == 0)
						{
							goto IL_0156;
						}
						goto IL_0161;
						IL_0156:
						num = 28;
						limitcols = 1;
						goto IL_0161;
						IL_0161:
						num = 30;
						limitcolsFind = false;
						goto IL_016c;
						IL_016c:
						num = 31;
						UpdateProgress(0);
						goto IL_017c;
						IL_017c:
						num = 32;
						Application.DoEvents();
						goto IL_0185;
						IL_0185:
						num = 33;
						documents = wdapp.Documents;
						Template = Missing.Value;
						NewTemplate = Missing.Value;
						DocumentType = Missing.Value;
						Visible = Missing.Value;
						wdDoc = documents.Add(ref Template, ref NewTemplate, ref DocumentType, ref Visible);
						goto IL_01c3;
						IL_01c3:
						num = 34;
						document = wdDoc;
						Visible = testdoc;
						DocumentType = Missing.Value;
						NewTemplate = Missing.Value;
						Template = Missing.Value;
						AddToRecentFiles = Missing.Value;
						WritePassword = Missing.Value;
						ReadOnlyRecommended = Missing.Value;
						EmbedTrueTypeFonts = Missing.Value;
						SaveNativePictureFormat = Missing.Value;
						SaveFormsData = Missing.Value;
						SaveAsAOCELetter = Missing.Value;
						Encoding = Missing.Value;
						InsertLineBreaks = Missing.Value;
						AllowSubstitutions = Missing.Value;
						LineEnding = Missing.Value;
						AddBiDiMarks = Missing.Value;
						document.SaveAs(ref Visible, ref DocumentType, ref NewTemplate, ref Template, ref AddToRecentFiles, ref WritePassword, ref ReadOnlyRecommended, ref EmbedTrueTypeFonts, ref SaveNativePictureFormat, ref SaveFormsData, ref SaveAsAOCELetter, ref Encoding, ref InsertLineBreaks, ref AllowSubstitutions, ref LineEnding, ref AddBiDiMarks);
						testdoc = Conversions.ToString(Visible);
						goto IL_0270;
						IL_0270:
						num = 35;
						document2 = wdDoc;
						AddBiDiMarks = Missing.Value;
						LineEnding = Missing.Value;
						AllowSubstitutions = Missing.Value;
						document2.Close(ref AddBiDiMarks, ref LineEnding, ref AllowSubstitutions);
						goto IL_029a;
						IL_029a:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_02a3;
						IL_02a3:
						num = 37;
						documents2 = wdapp.Documents;
						AddBiDiMarks = testdoc;
						LineEnding = Missing.Value;
						AllowSubstitutions = Missing.Value;
						InsertLineBreaks = Missing.Value;
						Encoding = Missing.Value;
						SaveAsAOCELetter = Missing.Value;
						SaveFormsData = Missing.Value;
						SaveNativePictureFormat = Missing.Value;
						EmbedTrueTypeFonts = Missing.Value;
						ReadOnlyRecommended = Missing.Value;
						WritePassword = Missing.Value;
						AddToRecentFiles = Missing.Value;
						Visible = Missing.Value;
						DocumentType = Missing.Value;
						NewTemplate = Missing.Value;
						Template = Missing.Value;
						documents2.Open(ref AddBiDiMarks, ref LineEnding, ref AllowSubstitutions, ref InsertLineBreaks, ref Encoding, ref SaveAsAOCELetter, ref SaveFormsData, ref SaveNativePictureFormat, ref EmbedTrueTypeFonts, ref ReadOnlyRecommended, ref WritePassword, ref AddToRecentFiles, ref Visible, ref DocumentType, ref NewTemplate, ref Template);
						testdoc = Conversions.ToString(AddBiDiMarks);
						goto IL_0356;
						IL_0356:
						num = 38;
						workbook = Mod1.excelapp.Workbooks.Open(Application.get_StartupPath() + "\\config\\ALL.XLS", Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
						goto IL_03c0;
						IL_03c0:
						num = 39;
						worksheet = (Worksheet)workbook.Worksheets["ALL"];
						goto IL_03dc;
						IL_03dc:
						num = 40;
						index = "性能数据表";
						goto IL_03e7;
						IL_03e7:
						num = 41;
						worksheet.Visible = XlSheetVisibility.xlSheetVisible;
						goto IL_03f3;
						IL_03f3:
						num = 42;
						LabelProgress.set_Maximum(num5);
						goto IL_0404;
						IL_0404:
						num = 43;
						Mod1.wr = new StreamWriter(testlog, append: true, System.Text.Encoding.Default);
						goto IL_041e;
						IL_041e:
						num = 44;
						num8 = 0;
						goto IL_0425;
						IL_0425:
						num = 45;
						num9 = ll_lbxlslist.get_Items().get_Count() - 1;
						num10 = 0;
						goto IL_0440;
						IL_0440:
						if (num10 <= num9)
						{
							goto IL_0449;
						}
						goto IL_092e;
						IL_0449:
						num = 46;
						if (ll_lbxlslist.GetSelected(num10))
						{
							goto IL_045f;
						}
						goto IL_0910;
						IL_045f:
						num = 47;
						LabelProgress.set_Value(num10 + 1);
						goto IL_0472;
						IL_0472:
						num = 48;
						text = Conversions.ToString(ll_lbxlslist.get_Items().get_Item(num10));
						goto IL_048e;
						IL_048e:
						num = 49;
						array = Strings.Split(text, "\\", -1, (CompareMethod)0);
						goto IL_04a1;
						IL_04a1:
						num = 50;
						num11 = 0;
						goto IL_04a8;
						IL_04a8:
						num = 51;
						array2 = array;
						num12 = 0;
						goto IL_04c9;
						IL_04c9:
						if (num12 < array2.Length)
						{
							goto IL_04b5;
						}
						goto IL_04d1;
						IL_04d1:
						num = 54;
						num8++;
						goto IL_04db;
						IL_04db:
						num = 55;
						Mod1.excelapp.Application.StatusBar = "当前正在进行:" + Conversions.ToString(num8) + "/" + Conversions.ToString(num5);
						goto IL_050b;
						IL_050b:
						num = 56;
						UpdateProgress((double)num8 / (double)num5 * 1.0);
						goto IL_052b;
						IL_052b:
						num = 57;
						text2 = array[num11 - 1];
						goto IL_0537;
						IL_0537:
						num = 58;
						text3 = Strings.Left(text2, Strings.Len(text2) - 4);
						goto IL_054a;
						IL_054a:
						num = 59;
						worksheet.Cells.Delete(Missing.Value);
						goto IL_0560;
						IL_0560:
						num = 60;
						workbook2 = Mod1.excelapp.Workbooks.Open(text, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
						goto IL_05bc;
						IL_05bc:
						num = 61;
						worksheet2 = (Worksheet)workbook2.Worksheets[index];
						goto IL_05d5;
						IL_05d5:
						num = 62;
						worksheet2.Cells.HorizontalAlignment = Constants.xlCenter;
						goto IL_05ef;
						IL_05ef:
						num = 63;
						worksheet2.Cells.VerticalAlignment = Constants.xlCenter;
						goto IL_0609;
						IL_0609:
						num = 64;
						font = worksheet2.Cells.Font;
						goto IL_061b;
						IL_061b:
						num = 65;
						font.Name = "宋体";
						goto IL_062b;
						IL_062b:
						num = 66;
						font.FontStyle = "常规";
						goto IL_063b;
						IL_063b:
						num = 67;
						font.Size = 10;
						goto IL_064d;
						IL_064d:
						num = 68;
						font.ColorIndex = Constants.xlAutomatic;
						goto IL_0662;
						IL_0662:
						font = null;
						goto IL_0665;
						IL_0665:
						num = 70;
						worksheet2.Cells.EntireColumn.AutoFit();
						goto IL_067b;
						IL_067b:
						num = 71;
						worksheet2.Cells.EntireRow.AutoFit();
						goto IL_0691;
						IL_0691:
						num = 72;
						worksheet2.Cells.Copy(((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value));
						goto IL_06b3;
						IL_06b3:
						num = 73;
						range = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
						goto IL_06cf;
						IL_06cf:
						num = 74;
						num13 = range.Rows.Count - 1;
						goto IL_06e3;
						IL_06e3:
						if (num13 >= 2)
						{
							goto IL_06eb;
						}
						goto IL_07ba;
						IL_06eb:
						num = 75;
						flag = true;
						goto IL_06f1;
						IL_06f1:
						num = 76;
						count = range.Columns.Count;
						num11 = 2;
						goto IL_0706;
						IL_0706:
						if (num11 <= count)
						{
							goto IL_070f;
						}
						goto IL_091f;
						IL_070f:
						num = 77;
						text4 = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[num13, num11], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
						goto IL_0748;
						IL_0748:
						num = 78;
						if ((double)Conversions.ToSingle(text4) > 1E-05)
						{
							goto IL_075f;
						}
						goto IL_07ab;
						IL_075f:
						num = 79;
						flag = false;
						goto IL_091f;
						IL_07ab:
						num = 82;
						num11++;
						goto IL_0706;
						IL_091f:
						num = 83;
						if (flag)
						{
							goto IL_076a;
						}
						goto IL_079c;
						IL_076a:
						num = 84;
						NewLateBinding.LateCall(worksheet.Rows[num13, Missing.Value], (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						goto IL_079c;
						IL_079c:
						num = 86;
						num13 += -1;
						goto IL_06e3;
						IL_07ba:
						num = 87;
						workbook2.Saved = true;
						goto IL_07c6;
						IL_07c6:
						num = 88;
						workbook2.Close(Missing.Value, Missing.Value, Missing.Value);
						goto IL_07e0;
						IL_07e0:
						num = 89;
						range = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
						goto IL_07fc;
						IL_07fc:
						num = 90;
						if (range.Columns.Count > limitcols)
						{
							goto IL_0814;
						}
						goto IL_0849;
						IL_0814:
						num = 91;
						Mod1.wr.WriteLine(text3 + ",表格列数:" + Conversions.ToString(range.Columns.Count));
						goto IL_083e;
						IL_083e:
						num = 92;
						limitcolsFind = true;
						goto IL_0849;
						IL_0849:
						num = 94;
						range.Copy(Missing.Value);
						goto IL_085a;
						IL_085a:
						num = 95;
						application = wdapp;
						goto IL_0866;
						IL_0866:
						num = 96;
						selection = application.Selection;
						documents3 = application.Documents;
						LineEnding = 1;
						styles = documents3[ref LineEnding].Styles;
						AllowSubstitutions = 1;
						AddBiDiMarks = styles[ref AllowSubstitutions];
						selection.Style = ref AddBiDiMarks;
						goto IL_08a4;
						IL_08a4:
						num = 97;
						application.Selection.TypeText(text3);
						goto IL_08b5;
						IL_08b5:
						num = 98;
						selection2 = application.Selection;
						styles2 = application.ActiveDocument.Styles;
						LineEnding = "标题 1";
						AddBiDiMarks = styles2[ref LineEnding];
						selection2.Style = ref AddBiDiMarks;
						goto IL_08e3;
						IL_08e3:
						num = 99;
						application.Selection.TypeParagraph();
						goto IL_08f3;
						IL_08f3:
						num = 100;
						application.Selection.PasteExcelTable(LinkedToExcel: false, WordFormatting: false, RTF: true);
						goto IL_0906;
						IL_0906:
						application = null;
						goto IL_0909;
						IL_0909:
						num = 102;
						range = null;
						goto IL_0910;
						IL_04b5:
						num = 52;
						num11++;
						num12++;
						goto IL_04c5;
						IL_04c5:
						num = 53;
						goto IL_04c9;
						IL_0910:
						num = 104;
						num10++;
						goto IL_0440;
						IL_092e:
						num = 105;
						wdapp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
						goto IL_093e;
						IL_093e:
						num = 106;
						Mod1.wr.Close();
						goto IL_094c;
						IL_094c:
						num = 107;
						Mod1.wr.Dispose();
						goto IL_095a;
						IL_095a:
						num = 108;
						Mod1.excelapp.DisplayAlerts = false;
						goto IL_0969;
						IL_0969:
						num = 109;
						workbook.Close(Missing.Value, Missing.Value, Missing.Value);
						goto IL_0983;
						IL_0983:
						num = 110;
						wdapp.ActiveDocument.Save();
						goto IL_0997;
						IL_0997:
						num = 111;
						activeDocument = wdapp.ActiveDocument;
						AddBiDiMarks = Missing.Value;
						LineEnding = Missing.Value;
						AllowSubstitutions = Missing.Value;
						activeDocument.Close(ref AddBiDiMarks, ref LineEnding, ref AllowSubstitutions);
						goto IL_09c6;
						IL_09c6:
						num = 112;
						wdDoc = null;
						goto IL_09d1;
						IL_09d1:
						num = 113;
						worksheet.Visible = XlSheetVisibility.xlSheetHidden;
						goto IL_09dd;
						IL_09dd:
						num = 114;
						((Control)ll_btnchecklog).set_ForeColor(Color.Green);
						goto IL_09f1;
						IL_09f1:
						num = 115;
						ll_lbliucheng.get_Items().Add((object)("共处理了" + Conversions.ToString(num8) + "个xls文件!请查看文件;" + testdoc));
						goto IL_0a22;
						IL_0a22:
						num = 116;
						ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
						goto IL_0a43;
						IL_0a43:
						num = 117;
						if (limitcolsFind)
						{
							goto IL_0a4f;
						}
						goto IL_0a78;
						IL_0a4f:
						num = 118;
						Interaction.MsgBox((object)"找到表格列数超过15列的表格!如有必要请仔细查看相应表格.", (MsgBoxStyle)0, (object)"提示");
						goto IL_0a64;
						IL_0a64:
						num = 119;
						((Control)ll_btnchecklog).set_ForeColor(Color.Red);
						goto IL_0a78;
						end_IL_0000_2:
						break;
					}
					num = 123;
					((Control)ll_btntoword).set_ForeColor(Color.Green);
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 3255;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void ll_uftoword_Load(object sender, EventArgs e)
	{
		((Control)ll_btnxlspath).set_ForeColor(Color.Green);
		((Control)ll_btntoword).set_ForeColor(Color.Red);
		((Control)ll_btnwordformat).set_Enabled(false);
	}

	private void UpdateProgress(object Pct)
	{
		ll_uftoword ll_uftoword2 = this;
		ll_uftoword2.FrameProgress.set_Text(Strings.Format(RuntimeHelpers.GetObjectValue(Pct), "0%"));
		((Control)ll_uftoword2).Refresh();
		ll_uftoword2 = null;
	}

	private void ll_btnwordformat_Click(object sender, EventArgs e)
	{
		LabelProgress.set_Maximum(100);
		WordFormatEnhance();
	}

	private void WordFormatEnhance()
	{
		//IL_0b06: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		object obj = default(object);
		object objectValue = default(object);
		IEnumerator enumerator = default(IEnumerator);
		Microsoft.Office.Interop.Word.Application application = default(Microsoft.Office.Interop.Word.Application);
		IEnumerator enumerator2 = default(IEnumerator);
		int num6 = default(int);
		object obj2 = default(object);
		object obj3 = default(object);
		object obj4 = default(object);
		object obj5 = default(object);
		object obj6 = default(object);
		object obj7 = default(object);
		object obj8 = default(object);
		Options options = default(Options);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					Documents documents;
					object FileName;
					object ConfirmConversions;
					object ReadOnly;
					object AddToRecentFiles;
					object PasswordDocument;
					object PasswordTemplate;
					object Revert;
					object WritePasswordDocument;
					object WritePasswordTemplate;
					object Format;
					object Encoding;
					object Visible;
					object OpenAndRepair;
					Document activeDocument;
					object XMLTransform;
					object NoEncodingDialog;
					object DocumentDirection;
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						if (!File.Exists(testdoc))
						{
							goto IL_0010;
						}
						goto IL_0059;
					case 3199:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0010;
							case 3:
								goto IL_0034;
							case 5:
							case 6:
								goto IL_0059;
							case 7:
								goto IL_006c;
							case 8:
								goto IL_006f;
							case 9:
								goto IL_0072;
							case 10:
								goto IL_007b;
							case 11:
								goto IL_012e;
							case 12:
								goto IL_0146;
							case 13:
								goto IL_0157;
							case 14:
								goto IL_0171;
							case 15:
								goto IL_0177;
							case 16:
								goto IL_01a5;
							case 17:
								goto IL_01ad;
							case 18:
								goto IL_01f8;
							case 19:
								goto IL_0236;
							case 20:
								goto IL_025f;
							case 21:
								goto IL_028c;
							case 22:
								goto IL_028f;
							case 23:
								goto IL_02b4;
							case 24:
								goto IL_02cc;
							case 25:
								goto IL_02dd;
							case 26:
								goto IL_02e9;
							case 27:
								goto IL_031e;
							case 28:
								goto IL_0326;
							case 29:
								goto IL_0368;
							case 30:
								goto IL_03a7;
							case 31:
								goto IL_03d1;
							case 34:
								goto IL_03f7;
							case 35:
								goto IL_0422;
							case 36:
								goto IL_044b;
							case 37:
								goto IL_0474;
							case 38:
								goto IL_049d;
							case 39:
								goto IL_04a0;
							case 40:
								goto IL_04cb;
							case 41:
								goto IL_04f4;
							case 42:
								goto IL_051d;
							case 43:
								goto IL_0546;
							case 44:
								goto IL_0549;
							case 45:
								goto IL_0573;
							case 46:
								goto IL_059c;
							case 47:
								goto IL_05c5;
							case 48:
								goto IL_05ee;
							case 49:
								goto IL_05f1;
							case 50:
								goto IL_061c;
							case 51:
								goto IL_0645;
							case 52:
								goto IL_066e;
							case 53:
								goto IL_0697;
							case 54:
								goto IL_069a;
							case 55:
								goto IL_06c5;
							case 56:
								goto IL_06ee;
							case 57:
								goto IL_0717;
							case 58:
								goto IL_0740;
							case 59:
								goto IL_0743;
							case 60:
								goto IL_076e;
							case 61:
								goto IL_0797;
							case 62:
								goto IL_07c0;
							case 63:
								goto IL_07e9;
							case 64:
								goto IL_07ec;
							case 65:
								goto IL_0838;
							case 66:
								goto IL_0884;
							case 67:
								goto IL_08c1;
							case 68:
								goto IL_08c4;
							case 69:
								goto IL_08d1;
							case 70:
								goto IL_08dd;
							case 71:
								goto IL_08e9;
							case 72:
								goto IL_08f5;
							case 73:
								goto IL_08f8;
							case 74:
								goto IL_0922;
							case 75:
								goto IL_0973;
							case 76:
								goto IL_09cc;
							case 77:
								goto IL_0a1d;
							case 32:
							case 33:
								goto IL_0a26;
							case 78:
								goto IL_0a48;
							case 79:
								goto IL_0a60;
							case 80:
								goto IL_0a71;
							case 81:
								goto IL_0a74;
							case 82:
								goto IL_0a84;
							case 83:
								goto IL_0a95;
							case 84:
								goto IL_0aa9;
							case 85:
								goto IL_0abd;
							case 86:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 4:
							case 87:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_01a5:
						num = 16;
						num5++;
						goto IL_01ad;
						IL_01f8:
						num = 18;
						obj = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Rows", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Shading", new object[0], (string[])null, (Type[])null, (bool[])null);
						goto IL_0236;
						IL_0010:
						num = 2;
						ll_lbliucheng.get_Items().Add((object)("没有找到新生成的word文件." + testdoc));
						goto IL_0034;
						IL_0034:
						num = 3;
						ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
						goto end_IL_0000_3;
						IL_0059:
						num = 6;
						ll_lbecurpro.set_Text("word表格处理");
						goto IL_006c;
						IL_006c:
						num = 7;
						goto IL_006f;
						IL_006f:
						num = 8;
						goto IL_0072;
						IL_0072:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_007b;
						IL_007b:
						num = 10;
						documents = wdapp.Documents;
						FileName = testdoc;
						ConfirmConversions = Missing.Value;
						ReadOnly = Missing.Value;
						AddToRecentFiles = Missing.Value;
						PasswordDocument = Missing.Value;
						PasswordTemplate = Missing.Value;
						Revert = Missing.Value;
						WritePasswordDocument = Missing.Value;
						WritePasswordTemplate = Missing.Value;
						Format = Missing.Value;
						Encoding = Missing.Value;
						Visible = Missing.Value;
						OpenAndRepair = Missing.Value;
						DocumentDirection = Missing.Value;
						NoEncodingDialog = Missing.Value;
						XMLTransform = Missing.Value;
						documents.Open(ref FileName, ref ConfirmConversions, ref ReadOnly, ref AddToRecentFiles, ref PasswordDocument, ref PasswordTemplate, ref Revert, ref WritePasswordDocument, ref WritePasswordTemplate, ref Format, ref Encoding, ref Visible, ref OpenAndRepair, ref DocumentDirection, ref NoEncodingDialog, ref XMLTransform);
						testdoc = Conversions.ToString(FileName);
						goto IL_012e;
						IL_012e:
						num = 11;
						UpdateProgress(0.2);
						goto IL_0146;
						IL_0146:
						num = 12;
						LabelProgress.set_Value(20);
						goto IL_0157;
						IL_0157:
						num = 13;
						_ = wdapp.ActiveDocument.Tables.Count;
						goto IL_0171;
						IL_0171:
						num = 14;
						num5 = 0;
						goto IL_0177;
						IL_0177:
						num = 15;
						enumerator = wdapp.ActiveDocument.Tables.GetEnumerator();
						goto IL_0293;
						IL_0293:
						if (enumerator.MoveNext())
						{
							objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
							goto IL_01a5;
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						goto IL_02b4;
						IL_01ad:
						num = 17;
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Rows", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "HeadingFormat", new object[1] { true }, (string[])null, (Type[])null, false, true);
						goto IL_01f8;
						IL_0236:
						num = 19;
						NewLateBinding.LateSetComplex(obj, (Type)null, "Texture", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
						goto IL_025f;
						IL_02b4:
						num = 23;
						UpdateProgress(0.6);
						goto IL_02cc;
						IL_02cc:
						num = 24;
						LabelProgress.set_Value(60);
						goto IL_02dd;
						IL_02dd:
						num = 25;
						application = wdapp;
						goto IL_02e9;
						IL_02e9:
						num = 26;
						enumerator2 = wdapp.ActiveDocument.Tables.GetEnumerator();
						goto IL_0304;
						IL_0304:
						if (enumerator2.MoveNext())
						{
							objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
							goto IL_031e;
						}
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
						goto IL_0a48;
						IL_025f:
						num = 20;
						NewLateBinding.LateSetComplex(obj, (Type)null, "BackgroundPatternColor", new object[1] { 12632256 }, (string[])null, (Type[])null, false, true);
						goto IL_028c;
						IL_031e:
						num = 27;
						num6++;
						goto IL_0326;
						IL_0326:
						num = 28;
						Mod1.excelapp.Application.StatusBar = "当前正在处理表格边框:" + Conversions.ToString(num6) + "/" + Conversions.ToString(wdapp.ActiveDocument.Tables.Count);
						goto IL_0368;
						IL_0368:
						num = 29;
						if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
						{
							goto IL_03a7;
						}
						goto IL_0a26;
						IL_03a7:
						num = 30;
						ll_lbliucheng.get_Items().Add((object)("当前文件中第 " + Conversions.ToString(num6) + " 张表的列数 < 2 ,请检查..."));
						goto IL_03d1;
						IL_03d1:
						num = 31;
						ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
						goto IL_0a26;
						IL_0a26:
						num = 33;
						obj2 = objectValue;
						goto IL_03f7;
						IL_03f7:
						num = 34;
						obj3 = NewLateBinding.LateGet(obj2, (Type)null, "Borders", new object[1] { -2 }, (string[])null, (Type[])null, (bool[])null);
						goto IL_0422;
						IL_0422:
						num = 35;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "LineStyle", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
						goto IL_044b;
						IL_044b:
						num = 36;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "LineWidth", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
						goto IL_0474;
						IL_0474:
						num = 37;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "Color", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
						goto IL_049d;
						IL_049d:
						obj3 = null;
						goto IL_04a0;
						IL_04a0:
						num = 39;
						obj4 = NewLateBinding.LateGet(obj2, (Type)null, "Borders", new object[1] { -4 }, (string[])null, (Type[])null, (bool[])null);
						goto IL_04cb;
						IL_04cb:
						num = 40;
						NewLateBinding.LateSetComplex(obj4, (Type)null, "LineStyle", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
						goto IL_04f4;
						IL_04f4:
						num = 41;
						NewLateBinding.LateSetComplex(obj4, (Type)null, "LineWidth", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
						goto IL_051d;
						IL_051d:
						num = 42;
						NewLateBinding.LateSetComplex(obj4, (Type)null, "Color", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
						goto IL_0546;
						IL_0546:
						obj4 = null;
						goto IL_0549;
						IL_0549:
						num = 44;
						obj5 = NewLateBinding.LateGet(obj2, (Type)null, "Borders", new object[1] { -1 }, (string[])null, (Type[])null, (bool[])null);
						goto IL_0573;
						IL_0573:
						num = 45;
						NewLateBinding.LateSetComplex(obj5, (Type)null, "LineStyle", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
						goto IL_059c;
						IL_059c:
						num = 46;
						NewLateBinding.LateSetComplex(obj5, (Type)null, "LineWidth", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
						goto IL_05c5;
						IL_05c5:
						num = 47;
						NewLateBinding.LateSetComplex(obj5, (Type)null, "Color", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
						goto IL_05ee;
						IL_05ee:
						obj5 = null;
						goto IL_05f1;
						IL_05f1:
						num = 49;
						obj6 = NewLateBinding.LateGet(obj2, (Type)null, "Borders", new object[1] { -3 }, (string[])null, (Type[])null, (bool[])null);
						goto IL_061c;
						IL_061c:
						num = 50;
						NewLateBinding.LateSetComplex(obj6, (Type)null, "LineStyle", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
						goto IL_0645;
						IL_0645:
						num = 51;
						NewLateBinding.LateSetComplex(obj6, (Type)null, "LineWidth", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
						goto IL_066e;
						IL_066e:
						num = 52;
						NewLateBinding.LateSetComplex(obj6, (Type)null, "Color", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
						goto IL_0697;
						IL_0697:
						obj6 = null;
						goto IL_069a;
						IL_069a:
						num = 54;
						obj7 = NewLateBinding.LateGet(obj2, (Type)null, "Borders", new object[1] { -5 }, (string[])null, (Type[])null, (bool[])null);
						goto IL_06c5;
						IL_06c5:
						num = 55;
						NewLateBinding.LateSetComplex(obj7, (Type)null, "LineStyle", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
						goto IL_06ee;
						IL_06ee:
						num = 56;
						NewLateBinding.LateSetComplex(obj7, (Type)null, "LineWidth", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
						goto IL_0717;
						IL_0717:
						num = 57;
						NewLateBinding.LateSetComplex(obj7, (Type)null, "Color", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
						goto IL_0740;
						IL_0740:
						obj7 = null;
						goto IL_0743;
						IL_0743:
						num = 59;
						obj8 = NewLateBinding.LateGet(obj2, (Type)null, "Borders", new object[1] { -6 }, (string[])null, (Type[])null, (bool[])null);
						goto IL_076e;
						IL_076e:
						num = 60;
						NewLateBinding.LateSetComplex(obj8, (Type)null, "LineStyle", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
						goto IL_0797;
						IL_0797:
						num = 61;
						NewLateBinding.LateSetComplex(obj8, (Type)null, "LineWidth", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
						goto IL_07c0;
						IL_07c0:
						num = 62;
						NewLateBinding.LateSetComplex(obj8, (Type)null, "Color", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
						goto IL_07e9;
						IL_07e9:
						obj8 = null;
						goto IL_07ec;
						IL_07ec:
						num = 64;
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Borders", new object[1] { -7 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "LineStyle", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
						goto IL_0838;
						IL_0838:
						num = 65;
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Borders", new object[1] { -8 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "LineStyle", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
						goto IL_0884;
						IL_0884:
						num = 66;
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Borders", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Shadow", new object[1] { false }, (string[])null, (Type[])null, false, true);
						goto IL_08c1;
						IL_08c1:
						obj2 = null;
						goto IL_08c4;
						IL_08c4:
						num = 68;
						options = application.Options;
						goto IL_08d1;
						IL_08d1:
						num = 69;
						options.DefaultBorderLineStyle = WdLineStyle.wdLineStyleSingle;
						goto IL_08dd;
						IL_08dd:
						num = 70;
						options.DefaultBorderLineWidth = WdLineWidth.wdLineWidth050pt;
						goto IL_08e9;
						IL_08e9:
						num = 71;
						options.DefaultBorderColor = WdColor.wdColorBlack;
						goto IL_08f5;
						IL_08f5:
						options = null;
						goto IL_08f8;
						IL_08f8:
						num = 73;
						NewLateBinding.LateCall(objectValue, (Type)null, "AutoFitBehavior", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null, true);
						goto IL_0922;
						IL_0922:
						num = 74;
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Range", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParagraphFormat", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Alignment", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
						goto IL_0973;
						IL_0973:
						num = 75;
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Range", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Size", new object[1] { 10.5 }, (string[])null, (Type[])null, false, true);
						goto IL_09cc;
						IL_09cc:
						num = 76;
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Range", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Color", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
						goto IL_0a1d;
						IL_0a1d:
						num = 77;
						goto IL_0304;
						IL_028c:
						obj = null;
						goto IL_028f;
						IL_028f:
						num = 22;
						goto IL_0293;
						IL_0a48:
						num = 78;
						UpdateProgress(0.8);
						goto IL_0a60;
						IL_0a60:
						num = 79;
						LabelProgress.set_Value(80);
						goto IL_0a71;
						IL_0a71:
						application = null;
						goto IL_0a74;
						IL_0a74:
						num = 81;
						UpdateProgress(1);
						goto IL_0a84;
						IL_0a84:
						num = 82;
						LabelProgress.set_Value(100);
						goto IL_0a95;
						IL_0a95:
						num = 83;
						Mod1.excelapp.Application.ScreenUpdating = true;
						goto IL_0aa9;
						IL_0aa9:
						num = 84;
						wdapp.ActiveDocument.Save();
						goto IL_0abd;
						IL_0abd:
						num = 85;
						activeDocument = wdapp.ActiveDocument;
						XMLTransform = Missing.Value;
						NoEncodingDialog = Missing.Value;
						DocumentDirection = Missing.Value;
						activeDocument.Close(ref XMLTransform, ref NoEncodingDialog, ref DocumentDirection);
						break;
						end_IL_0000_2:
						break;
					}
					num = 86;
					Interaction.MsgBox((object)("处理完毕!请查看文件;" + testdoc), (MsgBoxStyle)0, (object)"提示");
					break;
				}
				end_IL_0000:;
			}
			catch (object obj9) when (obj9 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj9);
				try0000_dispatch = 3199;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void SetFormat()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(wdmyrange);
		object obj = wdstyle;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(objectValue, (Type)null, "Paragraphs", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
				if (Strings.Len(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, (Type)null, "Range", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))) > 1)
				{
					NewLateBinding.LateSet(objectValue2, (Type)null, "Style", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null);
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

	private void ll_btnlookword_Click(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		if (Operators.CompareString(ll_lbecurpath.get_Text(), "", false) != 0 && (int)MessageBox.Show("当前Word文件所在路径为:" + ll_lbecurpath.get_Text() + ",是否浏览该文件夹?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
		{
			Process.Start(ll_lbecurpath.get_Text());
		}
	}

	private void ll_btnchecklog_Click(object sender, EventArgs e)
	{
		if (File.Exists(testlog))
		{
			Mod1.str1 = "notepad.exe " + testlog;
			Interaction.Shell(Mod1.str1, (AppWinStyle)1, false, -1);
		}
	}

	private void cldisplay_CheckedChanged(object sender, EventArgs e)
	{
		if (cldisplay.get_Checked())
		{
			Mod1.excelapp.Visible = true;
			wdapp.Visible = true;
		}
		else
		{
			Mod1.excelapp.Visible = false;
			wdapp.Visible = false;
		}
	}

	private void ll_lbxlslist_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(ll_lbxlslist.get_Text(), "", false) != 0)
		{
			((Control)ll_btntoword).set_ForeColor(Color.Green);
		}
		else
		{
			((Control)ll_btntoword).set_ForeColor(Color.Red);
		}
	}

	private void ll_uftoword_FormClosed(object sender, FormClosedEventArgs e)
	{
		try
		{
			if (wdapp != null)
			{
				Microsoft.Office.Interop.Word.Application application = wdapp;
				object SaveChanges = Missing.Value;
				object OriginalFormat = Missing.Value;
				object RouteDocument = Missing.Value;
				application.Quit(ref SaveChanges, ref OriginalFormat, ref RouteDocument);
				wdapp = null;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
