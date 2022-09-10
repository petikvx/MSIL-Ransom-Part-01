using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class ll_ufxnbnameformat : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ll_lbconfig")]
	private ListBox _ll_lbconfig;

	[AccessedThroughProperty("ll_txtstruct")]
	private TextBoxX _ll_txtstruct;

	[AccessedThroughProperty("ll_txtpath")]
	private TextBoxX _ll_txtpath;

	[AccessedThroughProperty("ll_btnpath")]
	private ButtonX _ll_btnpath;

	[AccessedThroughProperty("ll_lbxnfilelis")]
	private ListBox _ll_lbxnfilelis;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("ll_lbcurname")]
	private ListBox _ll_lbcurname;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("ll_lbformatname")]
	private ListBox _ll_lbformatname;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("ll_lbformatnamev")]
	private ListBox _ll_lbformatnamev;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("ll_lbcurnamei")]
	private ListBox _ll_lbcurnamei;

	[AccessedThroughProperty("LabelX6")]
	private LabelX _LabelX6;

	[AccessedThroughProperty("ll_lbformatnamei")]
	private ListBox _ll_lbformatnamei;

	[AccessedThroughProperty("LabelX7")]
	private LabelX _LabelX7;

	[AccessedThroughProperty("ll_lbenameformatview")]
	private LabelX _ll_lbenameformatview;

	[AccessedThroughProperty("LabelX9")]
	private LabelX _LabelX9;

	[AccessedThroughProperty("ll_lbliucheng")]
	private ListBox _ll_lbliucheng;

	[AccessedThroughProperty("ll_btnnameformat")]
	private ButtonX _ll_btnnameformat;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	private string whichstruct;

	private string resxlspath;

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

	internal virtual ListBox ll_lbconfig
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbconfig;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbconfig_DoubleClick;
			if (_ll_lbconfig != null)
			{
				((Control)_ll_lbconfig).remove_DoubleClick(eventHandler);
			}
			_ll_lbconfig = value;
			if (_ll_lbconfig != null)
			{
				((Control)_ll_lbconfig).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual TextBoxX ll_txtstruct
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtstruct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtstruct = value;
		}
	}

	internal virtual TextBoxX ll_txtpath
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtpath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtpath = value;
		}
	}

	internal virtual ButtonX ll_btnpath
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnpath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnpath_Click;
			if (_ll_btnpath != null)
			{
				((Control)_ll_btnpath).remove_Click(eventHandler);
			}
			_ll_btnpath = value;
			if (_ll_btnpath != null)
			{
				((Control)_ll_btnpath).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbxnfilelis
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbxnfilelis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbxnfilelis_SelectedIndexChanged;
			if (_ll_lbxnfilelis != null)
			{
				_ll_lbxnfilelis.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbxnfilelis = value;
			if (_ll_lbxnfilelis != null)
			{
				_ll_lbxnfilelis.add_SelectedIndexChanged(eventHandler);
			}
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

	internal virtual ListBox ll_lbcurname
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbcurname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbcurname_SelectedIndexChanged;
			EventHandler eventHandler2 = ll_lbcurname_DoubleClick;
			if (_ll_lbcurname != null)
			{
				_ll_lbcurname.remove_SelectedIndexChanged(eventHandler);
				((Control)_ll_lbcurname).remove_DoubleClick(eventHandler2);
			}
			_ll_lbcurname = value;
			if (_ll_lbcurname != null)
			{
				_ll_lbcurname.add_SelectedIndexChanged(eventHandler);
				((Control)_ll_lbcurname).add_DoubleClick(eventHandler2);
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

	internal virtual ListBox ll_lbformatname
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbformatname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbformatname_SelectedIndexChanged;
			if (_ll_lbformatname != null)
			{
				_ll_lbformatname.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbformatname = value;
			if (_ll_lbformatname != null)
			{
				_ll_lbformatname.add_SelectedIndexChanged(eventHandler);
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

	internal virtual ListBox ll_lbformatnamev
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbformatnamev;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbformatnamev_SelectedIndexChanged;
			if (_ll_lbformatnamev != null)
			{
				_ll_lbformatnamev.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbformatnamev = value;
			if (_ll_lbformatnamev != null)
			{
				_ll_lbformatnamev.add_SelectedIndexChanged(eventHandler);
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

	internal virtual ListBox ll_lbcurnamei
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbcurnamei;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbcurnamei_SelectedIndexChanged;
			if (_ll_lbcurnamei != null)
			{
				_ll_lbcurnamei.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbcurnamei = value;
			if (_ll_lbcurnamei != null)
			{
				_ll_lbcurnamei.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX6
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX6 = value;
		}
	}

	internal virtual ListBox ll_lbformatnamei
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbformatnamei;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbformatnamei_SelectedIndexChanged;
			if (_ll_lbformatnamei != null)
			{
				_ll_lbformatnamei.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbformatnamei = value;
			if (_ll_lbformatnamei != null)
			{
				_ll_lbformatnamei.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX7
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX7 = value;
		}
	}

	internal virtual LabelX ll_lbenameformatview
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbenameformatview;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbenameformatview = value;
		}
	}

	internal virtual LabelX LabelX9
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX9 = value;
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

	internal virtual ButtonX ll_btnnameformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnnameformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnnameformat_Click;
			if (_ll_btnnameformat != null)
			{
				((Control)_ll_btnnameformat).remove_Click(eventHandler);
			}
			_ll_btnnameformat = value;
			if (_ll_btnnameformat != null)
			{
				((Control)_ll_btnnameformat).add_Click(eventHandler);
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

	[DebuggerNonUserCode]
	public ll_ufxnbnameformat()
	{
		((Form)this).add_Load((EventHandler)ll_ufxnbnameformat_Load);
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
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c00: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Expected O, but got Unknown
		LabelX1 = new LabelX();
		ll_lbconfig = new ListBox();
		ll_txtstruct = new TextBoxX();
		ll_txtpath = new TextBoxX();
		ll_btnpath = new ButtonX();
		ll_lbxnfilelis = new ListBox();
		LabelX2 = new LabelX();
		ll_lbcurname = new ListBox();
		LabelX3 = new LabelX();
		ll_lbformatname = new ListBox();
		LabelX4 = new LabelX();
		ll_lbformatnamev = new ListBox();
		LabelX5 = new LabelX();
		ll_lbcurnamei = new ListBox();
		LabelX6 = new LabelX();
		ll_lbformatnamei = new ListBox();
		LabelX7 = new LabelX();
		ll_lbenameformatview = new LabelX();
		LabelX9 = new LabelX();
		ll_lbliucheng = new ListBox();
		ll_btnnameformat = new ButtonX();
		ll_btnexit = new ButtonX();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(12, 12);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(111, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("结构形式列表");
		((ListControl)ll_lbconfig).set_FormattingEnabled(true);
		ll_lbconfig.set_ItemHeight(12);
		ListBox obj = ll_lbconfig;
		location = new Point(12, 41);
		((Control)obj).set_Location(location);
		((Control)ll_lbconfig).set_Name("ll_lbconfig");
		ListBox obj2 = ll_lbconfig;
		size = new Size(167, 256);
		((Control)obj2).set_Size(size);
		((Control)ll_lbconfig).set_TabIndex(1);
		ll_txtstruct.get_Border().set_Class("TextBoxBorder");
		ll_txtstruct.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj3 = ll_txtstruct;
		location = new Point(12, 303);
		((Control)obj3).set_Location(location);
		((Control)ll_txtstruct).set_Name("ll_txtstruct");
		((TextBoxBase)ll_txtstruct).set_ReadOnly(true);
		TextBoxX obj4 = ll_txtstruct;
		size = new Size(167, 21);
		((Control)obj4).set_Size(size);
		((Control)ll_txtstruct).set_TabIndex(2);
		ll_txtpath.get_Border().set_Class("TextBoxBorder");
		ll_txtpath.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj5 = ll_txtpath;
		location = new Point(371, 12);
		((Control)obj5).set_Location(location);
		((Control)ll_txtpath).set_Name("ll_txtpath");
		((TextBoxBase)ll_txtpath).set_ReadOnly(true);
		TextBoxX obj6 = ll_txtpath;
		size = new Size(454, 21);
		((Control)obj6).set_Size(size);
		((Control)ll_txtpath).set_TabIndex(3);
		((Control)ll_btnpath).set_AccessibleRole((AccessibleRole)43);
		ll_btnpath.set_ColorTable((eButtonColor)3);
		ButtonX obj7 = ll_btnpath;
		location = new Point(187, 12);
		((Control)obj7).set_Location(location);
		((Control)ll_btnpath).set_Name("ll_btnpath");
		ButtonX obj8 = ll_btnpath;
		size = new Size(178, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)ll_btnpath).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnpath).set_TabIndex(4);
		ll_btnpath.set_Text("指定待处理性能表所在路径...");
		((ListControl)ll_lbxnfilelis).set_FormattingEnabled(true);
		ll_lbxnfilelis.set_ItemHeight(12);
		ListBox obj9 = ll_lbxnfilelis;
		location = new Point(187, 41);
		((Control)obj9).set_Location(location);
		((Control)ll_lbxnfilelis).set_Name("ll_lbxnfilelis");
		ListBox obj10 = ll_lbxnfilelis;
		size = new Size(638, 124);
		((Control)obj10).set_Size(size);
		((Control)ll_lbxnfilelis).set_TabIndex(1);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(187, 168);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(111, 23);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(0);
		LabelX2.set_Text("当前名称分解");
		((ListControl)ll_lbcurname).set_FormattingEnabled(true);
		ll_lbcurname.set_ItemHeight(12);
		ListBox obj11 = ll_lbcurname;
		location = new Point(187, 197);
		((Control)obj11).set_Location(location);
		((Control)ll_lbcurname).set_Name("ll_lbcurname");
		ListBox obj12 = ll_lbcurname;
		size = new Size(202, 100);
		((Control)obj12).set_Size(size);
		((Control)ll_lbcurname).set_TabIndex(1);
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX3;
		location = new Point(406, 168);
		((Control)labelX5).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX6 = LabelX3;
		size = new Size(111, 23);
		((Control)labelX6).set_Size(size);
		((Control)LabelX3).set_TabIndex(0);
		LabelX3.set_Text("规范名称分解");
		((ListControl)ll_lbformatname).set_FormattingEnabled(true);
		ll_lbformatname.set_ItemHeight(12);
		ListBox obj13 = ll_lbformatname;
		location = new Point(406, 197);
		((Control)obj13).set_Location(location);
		((Control)ll_lbformatname).set_Name("ll_lbformatname");
		ListBox obj14 = ll_lbformatname;
		size = new Size(202, 100);
		((Control)obj14).set_Size(size);
		((Control)ll_lbformatname).set_TabIndex(1);
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX7 = LabelX4;
		location = new Point(623, 168);
		((Control)labelX7).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX8 = LabelX4;
		size = new Size(111, 23);
		((Control)labelX8).set_Size(size);
		((Control)LabelX4).set_TabIndex(0);
		LabelX4.set_Text("规范名称值");
		((ListControl)ll_lbformatnamev).set_FormattingEnabled(true);
		ll_lbformatnamev.set_ItemHeight(12);
		ListBox obj15 = ll_lbformatnamev;
		location = new Point(623, 197);
		((Control)obj15).set_Location(location);
		((Control)ll_lbformatnamev).set_Name("ll_lbformatnamev");
		ListBox obj16 = ll_lbformatnamev;
		size = new Size(202, 100);
		((Control)obj16).set_Size(size);
		((Control)ll_lbformatnamev).set_TabIndex(1);
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX9 = LabelX5;
		location = new Point(12, 332);
		((Control)labelX9).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX10 = LabelX5;
		size = new Size(69, 23);
		((Control)labelX10).set_Size(size);
		((Control)LabelX5).set_TabIndex(0);
		LabelX5.set_Text("名称项序号");
		((Control)LabelX5).set_Visible(false);
		((ListControl)ll_lbcurnamei).set_FormattingEnabled(true);
		ll_lbcurnamei.set_ItemHeight(12);
		ListBox obj17 = ll_lbcurnamei;
		location = new Point(46, 361);
		((Control)obj17).set_Location(location);
		((Control)ll_lbcurnamei).set_Name("ll_lbcurnamei");
		ListBox obj18 = ll_lbcurnamei;
		size = new Size(49, 100);
		((Control)obj18).set_Size(size);
		((Control)ll_lbcurnamei).set_TabIndex(1);
		((Control)ll_lbcurnamei).set_Visible(false);
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX11 = LabelX6;
		location = new Point(75, 332);
		((Control)labelX11).set_Location(location);
		((Control)LabelX6).set_Name("LabelX6");
		LabelX labelX12 = LabelX6;
		size = new Size(82, 23);
		((Control)labelX12).set_Size(size);
		((Control)LabelX6).set_TabIndex(0);
		LabelX6.set_Text("规范名称序号");
		((Control)LabelX6).set_Visible(false);
		((ListControl)ll_lbformatnamei).set_FormattingEnabled(true);
		ll_lbformatnamei.set_ItemHeight(12);
		ListBox obj19 = ll_lbformatnamei;
		location = new Point(97, 361);
		((Control)obj19).set_Location(location);
		((Control)ll_lbformatnamei).set_Name("ll_lbformatnamei");
		ListBox obj20 = ll_lbformatnamei;
		size = new Size(49, 100);
		((Control)obj20).set_Size(size);
		((Control)ll_lbformatnamei).set_TabIndex(1);
		((Control)ll_lbformatnamei).set_Visible(false);
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX13 = LabelX7;
		location = new Point(187, 303);
		((Control)labelX13).set_Location(location);
		((Control)LabelX7).set_Name("LabelX7");
		LabelX labelX14 = LabelX7;
		size = new Size(86, 23);
		((Control)labelX14).set_Size(size);
		((Control)LabelX7).set_TabIndex(0);
		LabelX7.set_Text("规范名称预览:");
		((BaseItemControl)ll_lbenameformatview).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbenameformatview).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj21 = ll_lbenameformatview;
		location = new Point(271, 303);
		((Control)obj21).set_Location(location);
		((Control)ll_lbenameformatview).set_Name("ll_lbenameformatview");
		LabelX obj22 = ll_lbenameformatview;
		size = new Size(554, 23);
		((Control)obj22).set_Size(size);
		((Control)ll_lbenameformatview).set_TabIndex(5);
		((BaseItemControl)LabelX9).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX9).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX15 = LabelX9;
		location = new Point(187, 332);
		((Control)labelX15).set_Location(location);
		((Control)LabelX9).set_Name("LabelX9");
		LabelX labelX16 = LabelX9;
		size = new Size(111, 23);
		((Control)labelX16).set_Size(size);
		((Control)LabelX9).set_TabIndex(0);
		LabelX9.set_Text("操作流程信息:");
		((ListControl)ll_lbliucheng).set_FormattingEnabled(true);
		ll_lbliucheng.set_ItemHeight(12);
		ListBox obj23 = ll_lbliucheng;
		location = new Point(187, 361);
		((Control)obj23).set_Location(location);
		((Control)ll_lbliucheng).set_Name("ll_lbliucheng");
		ListBox obj24 = ll_lbliucheng;
		size = new Size(638, 100);
		((Control)obj24).set_Size(size);
		((Control)ll_lbliucheng).set_TabIndex(1);
		((Control)ll_btnnameformat).set_AccessibleRole((AccessibleRole)43);
		ll_btnnameformat.set_ColorTable((eButtonColor)3);
		ButtonX obj25 = ll_btnnameformat;
		location = new Point(354, 471);
		((Control)obj25).set_Location(location);
		((Control)ll_btnnameformat).set_Name("ll_btnnameformat");
		ButtonX obj26 = ll_btnnameformat;
		size = new Size(139, 23);
		((Control)obj26).set_Size(size);
		((PopupItemControl)ll_btnnameformat).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnnameformat).set_TabIndex(4);
		ll_btnnameformat.set_Text("开始重命名...");
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ll_btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj27 = ll_btnexit;
		location = new Point(527, 471);
		((Control)obj27).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj28 = ll_btnexit;
		size = new Size(139, 23);
		((Control)obj28).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(4);
		ll_btnexit.set_Text("关闭");
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(837, 503);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ll_lbenameformatview);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_btnnameformat);
		((Control)this).get_Controls().Add((Control)(object)ll_btnpath);
		((Control)this).get_Controls().Add((Control)(object)ll_txtpath);
		((Control)this).get_Controls().Add((Control)(object)ll_txtstruct);
		((Control)this).get_Controls().Add((Control)(object)ll_lbxnfilelis);
		((Control)this).get_Controls().Add((Control)(object)ll_lbformatnamei);
		((Control)this).get_Controls().Add((Control)(object)ll_lbcurnamei);
		((Control)this).get_Controls().Add((Control)(object)ll_lbformatnamev);
		((Control)this).get_Controls().Add((Control)(object)LabelX6);
		((Control)this).get_Controls().Add((Control)(object)LabelX5);
		((Control)this).get_Controls().Add((Control)(object)ll_lbformatname);
		((Control)this).get_Controls().Add((Control)(object)LabelX4);
		((Control)this).get_Controls().Add((Control)(object)ll_lbliucheng);
		((Control)this).get_Controls().Add((Control)(object)ll_lbcurname);
		((Control)this).get_Controls().Add((Control)(object)LabelX3);
		((Control)this).get_Controls().Add((Control)(object)ll_lbconfig);
		((Control)this).get_Controls().Add((Control)(object)LabelX9);
		((Control)this).get_Controls().Add((Control)(object)LabelX7);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufxnbnameformat");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("性能表名称规范...");
		((Control)this).ResumeLayout(false);
	}

	private void ll_ufxnbnameformat_Load(object sender, EventArgs e)
	{
		string path = Application.get_StartupPath() + "\\config\\xnbnameformat\\config.ini";
		Mod1.lr = new StreamReader(path, Encoding.Default);
		while (true)
		{
			string text = Mod1.lr.ReadLine();
			if (Operators.CompareString(Strings.Trim(text), "", false) == 0)
			{
				break;
			}
			ll_lbconfig.get_Items().Add((object)text);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		ll_lbliucheng.get_Items().Add((object)"选择规范名称值列表中某项，然后双击当前名称分解列表中相应项，通过临时预览查看是否正确.");
		ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
	}

	private void ll_lbconfig_DoubleClick(object sender, EventArgs e)
	{
		if (ll_lbconfig.get_SelectedIndex() != -1)
		{
			((TextBox)ll_txtstruct).set_Text(ll_lbconfig.get_Text());
			whichstruct = ((TextBox)ll_txtstruct).get_Text();
			ll_lbliucheng.get_Items().Add((object)("当前结构形式为:" + whichstruct));
			ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
			inputnameformat(whichstruct);
		}
	}

	public void inputnameformat(string strstruct)
	{
		string text = Application.get_StartupPath() + "\\config\\xnbnameformat\\" + strstruct + ".ini";
		if (File.Exists(text))
		{
			ll_lbformatname.get_Items().Clear();
			ll_lbformatnamei.get_Items().Clear();
			ll_lbformatnamev.get_Items().Clear();
			Mod1.lr = new StreamReader(text, Encoding.Default);
			while (true)
			{
				string text2 = Mod1.lr.ReadLine();
				if (Operators.CompareString(Strings.Trim(text2), "", false) == 0)
				{
					break;
				}
				ll_lbformatname.get_Items().Add((object)text2);
				ll_lbformatnamei.get_Items().Add((object)"");
				ll_lbformatnamev.get_Items().Add((object)"");
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
		}
		else
		{
			ll_lbliucheng.get_Items().Add((object)("没有找到文件：" + text));
			ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
		}
	}

	private void ll_lbxnfilelis_SelectedIndexChanged(object sender, EventArgs e)
	{
		ll_lbcurname.get_Items().Clear();
		ll_lbcurnamei.get_Items().Clear();
		string text = ll_lbxnfilelis.get_Text();
		string[] array = Strings.Split(text, "\\", -1, (CompareMethod)0);
		text = array[Information.UBound((Array)array, 1)];
		array = Strings.Split(text, "_", -1, (CompareMethod)0);
		int num = Information.UBound((Array)array, 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			ll_lbcurname.get_Items().Add((object)array[i]);
			ll_lbcurnamei.get_Items().Add((object)i);
		}
	}

	private void ll_btnpath_Click(object sender, EventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Invalid comparison between Unknown and I4
		if (Operators.CompareString(Strings.Trim(((TextBox)ll_txtstruct).get_Text()), "", false) == 0)
		{
			Interaction.MsgBox((object)"请先选择结构形式.", (MsgBoxStyle)0, (object)"提示");
			return;
		}
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("请指定某文件夹,要求其中含有Ansys11.0 性能表浏览器操作后输出性能表xls文件");
		if ((int)((CommonDialog)val).ShowDialog() != 1)
		{
			return;
		}
		Mod1.strpath = val.get_SelectedPath();
		checked
		{
			if (Operators.CompareString(Strings.Trim(Mod1.strpath), "", false) != 0)
			{
				((TextBox)ll_txtpath).set_Text(Mod1.strpath);
				ll_lbliucheng.get_Items().Add((object)("指定的待处理xls文件夹为:" + Mod1.strpath));
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				resxlspath = Mod1.strpath + "\\results3";
				if (!Directory.Exists(resxlspath))
				{
					FileSystem.MkDir(resxlspath);
				}
				else
				{
					string text = "当前已经存在文件夹:" + resxlspath + " 是否继续?";
					if (unchecked((int)MessageBox.Show(text, "提示", (MessageBoxButtons)4, (MessageBoxIcon)64)) == 7)
					{
						ll_lbliucheng.get_Items().Add((object)("当前已经存在文件夹:" + resxlspath + "建议先删除再继续本次操作."));
						ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
						return;
					}
					ll_lbliucheng.get_Items().Add((object)("接下来的输出文件将覆盖文件夹:" + resxlspath + "中已有文件."));
					ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				}
			}
			string path = ((TextBox)ll_txtpath).get_Text() + "\\";
			ll_lbxnfilelis.get_Items().Clear();
			string[] files = Directory.GetFiles(path, "*.xls", SearchOption.TopDirectoryOnly);
			if (files.Count() != 0)
			{
				int num = files.Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = files[i];
					string[] array = Strings.Split(text2, "\\", -1, (CompareMethod)0);
					text2 = array[Information.UBound((Array)array, 1)];
					ll_lbxnfilelis.get_Items().Add((object)text2);
				}
			}
		}
	}

	private void ll_lbcurname_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)ll_lbcurnamei).set_TabIndex(((Control)ll_lbcurname).get_TabIndex());
		ll_lbcurnamei.set_SelectedIndex(ll_lbcurname.get_SelectedIndex());
	}

	private void ll_lbformatname_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)ll_lbformatnamei).set_TabIndex(((Control)ll_lbformatname).get_TabIndex());
		ll_lbformatnamei.set_SelectedIndex(ll_lbformatname.get_SelectedIndex());
		((Control)ll_lbformatnamev).set_TabIndex(((Control)ll_lbformatname).get_TabIndex());
		ll_lbformatnamev.set_SelectedIndex(ll_lbformatname.get_SelectedIndex());
	}

	private void ll_lbformatnamev_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)ll_lbformatname).set_TabIndex(((Control)ll_lbformatnamev).get_TabIndex());
		ll_lbformatname.set_SelectedIndex(ll_lbformatnamev.get_SelectedIndex());
		((Control)ll_lbformatnamei).set_TabIndex(((Control)ll_lbformatnamev).get_TabIndex());
		ll_lbformatnamei.set_SelectedIndex(ll_lbformatnamev.get_SelectedIndex());
	}

	private void ll_lbcurnamei_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)ll_lbcurname).set_TabIndex(((Control)ll_lbcurnamei).get_TabIndex());
		ll_lbcurname.set_SelectedIndex(ll_lbcurnamei.get_SelectedIndex());
	}

	private void ll_lbformatnamei_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)ll_lbformatname).set_TabIndex(((Control)ll_lbformatnamei).get_TabIndex());
		ll_lbformatname.set_SelectedIndex(ll_lbformatnamei.get_SelectedIndex());
		((Control)ll_lbformatnamev).set_TabIndex(((Control)ll_lbformatnamei).get_TabIndex());
		ll_lbformatnamev.set_SelectedIndex(ll_lbformatnamei.get_SelectedIndex());
	}

	private void ll_btnnameformat_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ll_lbxnfilelis.get_Items().get_Count() - 1;
			string text2 = default(string);
			for (int i = 0; i <= num; i++)
			{
				string text = Conversions.ToString(ll_lbxnfilelis.get_Items().get_Item(i));
				string[] array = Strings.Split(text, "_", -1, (CompareMethod)0);
				int num2 = ll_lbformatname.get_Items().get_Count() - 1;
				for (int j = 0; j <= num2; j++)
				{
					text2 = ((j != 0) ? ((Operators.CompareString(Strings.Trim(Conversions.ToString(ll_lbformatnamei.get_Items().get_Item(j))), "", false) == 0) ? Conversions.ToString(Operators.ConcatenateObject((object)(text2 + "_"), ll_lbformatname.get_Items().get_Item(j))) : Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + "_"), ll_lbformatname.get_Items().get_Item(j)), (object)array[Conversions.ToInteger(ll_lbformatnamei.get_Items().get_Item(j))]))) : ((Operators.CompareString(Strings.Trim(Conversions.ToString(ll_lbformatnamei.get_Items().get_Item(0))), "", false) == 0) ? Conversions.ToString(ll_lbformatname.get_Items().get_Item(0)) : Conversions.ToString(Operators.ConcatenateObject(ll_lbformatname.get_Items().get_Item(0), (object)array[Conversions.ToInteger(ll_lbformatnamei.get_Items().get_Item(0))]))));
				}
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(((TextBox)ll_txtpath).get_Text() + "\\" + text, resxlspath + "\\" + text2 + ".xls", true);
				ll_lbliucheng.get_Items().Add((object)(text + " ->"));
				ll_lbliucheng.get_Items().Add((object)text2);
				ll_lbliucheng.get_Items().Add((object)"");
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
			}
			ll_lbliucheng.get_Items().Add((object)"");
			ll_lbliucheng.get_Items().Add((object)("请查看结果文件夹:" + resxlspath));
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	private void ll_lbcurname_DoubleClick(object sender, EventArgs e)
	{
		if (ll_lbcurname.get_Items().get_Count() != 0 && ll_lbformatname.get_SelectedIndex() != -1)
		{
			ll_lbformatnamei.get_Items().set_Item(ll_lbformatname.get_SelectedIndex(), RuntimeHelpers.GetObjectValue(ll_lbcurnamei.get_Items().get_Item(ll_lbcurname.get_SelectedIndex())));
			ll_lbformatnamev.get_Items().set_Item(ll_lbformatname.get_SelectedIndex(), RuntimeHelpers.GetObjectValue(ll_lbcurname.get_Items().get_Item(ll_lbcurname.get_SelectedIndex())));
			ll_nameformatview();
		}
	}

	public void ll_nameformatview()
	{
		string text = Conversions.ToString(Operators.ConcatenateObject(ll_lbformatname.get_Items().get_Item(0), ll_lbformatnamev.get_Items().get_Item(0)));
		checked
		{
			int num = ll_lbformatname.get_Items().get_Count() - 1;
			for (int i = 1; i <= num; i++)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + "_"), ll_lbformatname.get_Items().get_Item(i)), ll_lbformatnamev.get_Items().get_Item(i)));
			}
			ll_lbenameformatview.set_Text(text);
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
