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
public class jmsaveinfo : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_lbenhance")]
	private ListBox _ll_lbenhance;

	[AccessedThroughProperty("ll_lbshilifile")]
	private ListBox _ll_lbshilifile;

	[AccessedThroughProperty("ll_lbjmfilename")]
	private ListBox _ll_lbjmfilename;

	[AccessedThroughProperty("ll_btndeljmfile")]
	private ButtonX _ll_btndeljmfile;

	[AccessedThroughProperty("ll_btninput5var")]
	private ButtonX _ll_btninput5var;

	[AccessedThroughProperty("ll_btnsearchjm123")]
	private ButtonX _ll_btnsearchjm123;

	[AccessedThroughProperty("ll_lbliucheng")]
	private ListBox _ll_lbliucheng;

	[AccessedThroughProperty("GroupPanel1")]
	private GroupPanel _GroupPanel1;

	[AccessedThroughProperty("ll_opt2")]
	private RadioButton _ll_opt2;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("ll_opt1")]
	private RadioButton _ll_opt1;

	[AccessedThroughProperty("ll_lbb12_i")]
	private ListBox _ll_lbb12_i;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("ll_btnok")]
	private ButtonX _ll_btnok;

	[AccessedThroughProperty("LabelX6")]
	private LabelX _LabelX6;

	[AccessedThroughProperty("ll_lbjm123")]
	private ListBox _ll_lbjm123;

	[AccessedThroughProperty("LabelX7")]
	private LabelX _LabelX7;

	[AccessedThroughProperty("GroupPanel2")]
	private GroupPanel _GroupPanel2;

	[AccessedThroughProperty("ll_btnjmcheck")]
	private ButtonX _ll_btnjmcheck;

	public string fname;

	public string f;

	public int jb;

	public string lj;

	public string sourcefilepath;

	private int enhancecurListNumber;

	private string[] enhanceNameCh;

	private string CurWD4;

	private string JM_style;

	private string strtemp;

	private int curb12;

	internal virtual ListBox ll_lbenhance
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbenhance;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbenhance_SelectedIndexChanged;
			if (_ll_lbenhance != null)
			{
				_ll_lbenhance.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbenhance = value;
			if (_ll_lbenhance != null)
			{
				_ll_lbenhance.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbshilifile
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbshilifile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbshilifile_SelectedIndexChanged;
			if (_ll_lbshilifile != null)
			{
				_ll_lbshilifile.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbshilifile = value;
			if (_ll_lbshilifile != null)
			{
				_ll_lbshilifile.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbjmfilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbjmfilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbjmfilename_DoubleClick;
			EventHandler eventHandler2 = ll_lbjmfilename_SelectedIndexChanged;
			if (_ll_lbjmfilename != null)
			{
				((Control)_ll_lbjmfilename).remove_DoubleClick(eventHandler);
				_ll_lbjmfilename.remove_SelectedIndexChanged(eventHandler2);
			}
			_ll_lbjmfilename = value;
			if (_ll_lbjmfilename != null)
			{
				((Control)_ll_lbjmfilename).add_DoubleClick(eventHandler);
				_ll_lbjmfilename.add_SelectedIndexChanged(eventHandler2);
			}
		}
	}

	internal virtual ButtonX ll_btndeljmfile
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btndeljmfile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_btndeljmfile = value;
		}
	}

	internal virtual ButtonX ll_btninput5var
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btninput5var;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btninput5var_Click;
			if (_ll_btninput5var != null)
			{
				((Control)_ll_btninput5var).remove_Click(eventHandler);
			}
			_ll_btninput5var = value;
			if (_ll_btninput5var != null)
			{
				((Control)_ll_btninput5var).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnsearchjm123
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnsearchjm123;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnsearchjm123_Click;
			if (_ll_btnsearchjm123 != null)
			{
				((Control)_ll_btnsearchjm123).remove_Click(eventHandler);
			}
			_ll_btnsearchjm123 = value;
			if (_ll_btnsearchjm123 != null)
			{
				((Control)_ll_btnsearchjm123).add_Click(eventHandler);
			}
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

	internal virtual GroupPanel GroupPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupPanel1 = value;
		}
	}

	internal virtual RadioButton ll_opt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_opt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_opt2_Click;
			if (_ll_opt2 != null)
			{
				((Control)_ll_opt2).remove_Click(eventHandler);
			}
			_ll_opt2 = value;
			if (_ll_opt2 != null)
			{
				((Control)_ll_opt2).add_Click(eventHandler);
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

	internal virtual RadioButton ll_opt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_opt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_opt1_Click;
			if (_ll_opt1 != null)
			{
				((Control)_ll_opt1).remove_Click(eventHandler);
			}
			_ll_opt1 = value;
			if (_ll_opt1 != null)
			{
				((Control)_ll_opt1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbb12_i
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbb12_i;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbb12_i_SelectedIndexChanged;
			if (_ll_lbb12_i != null)
			{
				_ll_lbb12_i.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbb12_i = value;
			if (_ll_lbb12_i != null)
			{
				_ll_lbb12_i.add_SelectedIndexChanged(eventHandler);
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

	internal virtual ButtonX ll_btnok
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnok;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnok_Click;
			if (_ll_btnok != null)
			{
				((Control)_ll_btnok).remove_Click(eventHandler);
			}
			_ll_btnok = value;
			if (_ll_btnok != null)
			{
				((Control)_ll_btnok).add_Click(eventHandler);
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

	internal virtual ListBox ll_lbjm123
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbjm123;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbjm123_SelectedIndexChanged;
			if (_ll_lbjm123 != null)
			{
				_ll_lbjm123.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbjm123 = value;
			if (_ll_lbjm123 != null)
			{
				_ll_lbjm123.add_SelectedIndexChanged(eventHandler);
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

	internal virtual GroupPanel GroupPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupPanel2 = value;
		}
	}

	internal virtual ButtonX ll_btnjmcheck
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnjmcheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnjmcheck_Click;
			if (_ll_btnjmcheck != null)
			{
				((Control)_ll_btnjmcheck).remove_Click(eventHandler);
			}
			_ll_btnjmcheck = value;
			if (_ll_btnjmcheck != null)
			{
				((Control)_ll_btnjmcheck).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public jmsaveinfo()
	{
		((Form)this).add_Load((EventHandler)jmsaveinfo_Load);
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
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_1045: Unknown result type (might be due to invalid IL or missing references)
		//IL_104f: Expected O, but got Unknown
		//IL_1189: Unknown result type (might be due to invalid IL or missing references)
		//IL_1193: Expected O, but got Unknown
		ll_lbenhance = new ListBox();
		ll_lbshilifile = new ListBox();
		ll_lbjmfilename = new ListBox();
		ll_btndeljmfile = new ButtonX();
		ll_btninput5var = new ButtonX();
		ll_btnsearchjm123 = new ButtonX();
		ll_lbliucheng = new ListBox();
		GroupPanel1 = new GroupPanel();
		ll_btnok = new ButtonX();
		ll_opt2 = new RadioButton();
		LabelX5 = new LabelX();
		ll_opt1 = new RadioButton();
		ll_lbb12_i = new ListBox();
		ll_btnexit = new ButtonX();
		LabelX1 = new LabelX();
		LabelX2 = new LabelX();
		LabelX3 = new LabelX();
		LabelX4 = new LabelX();
		LabelX6 = new LabelX();
		ll_lbjm123 = new ListBox();
		LabelX7 = new LabelX();
		GroupPanel2 = new GroupPanel();
		ll_btnjmcheck = new ButtonX();
		((Control)GroupPanel1).SuspendLayout();
		((Control)GroupPanel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((ListControl)ll_lbenhance).set_FormattingEnabled(true);
		ll_lbenhance.set_ItemHeight(12);
		ListBox obj = ll_lbenhance;
		Point location = new Point(8, 57);
		((Control)obj).set_Location(location);
		((Control)ll_lbenhance).set_Name("ll_lbenhance");
		ListBox obj2 = ll_lbenhance;
		Size size = new Size(126, 256);
		((Control)obj2).set_Size(size);
		((Control)ll_lbenhance).set_TabIndex(0);
		((ListControl)ll_lbshilifile).set_FormattingEnabled(true);
		ll_lbshilifile.set_ItemHeight(12);
		ListBox obj3 = ll_lbshilifile;
		location = new Point(137, 57);
		((Control)obj3).set_Location(location);
		((Control)ll_lbshilifile).set_Name("ll_lbshilifile");
		ListBox obj4 = ll_lbshilifile;
		size = new Size(126, 256);
		((Control)obj4).set_Size(size);
		((Control)ll_lbshilifile).set_TabIndex(0);
		((ListControl)ll_lbjmfilename).set_FormattingEnabled(true);
		ll_lbjmfilename.set_ItemHeight(12);
		ListBox obj5 = ll_lbjmfilename;
		location = new Point(266, 57);
		((Control)obj5).set_Location(location);
		((Control)ll_lbjmfilename).set_Name("ll_lbjmfilename");
		ListBox obj6 = ll_lbjmfilename;
		size = new Size(419, 256);
		((Control)obj6).set_Size(size);
		((Control)ll_lbjmfilename).set_TabIndex(0);
		((Control)ll_btndeljmfile).set_AccessibleRole((AccessibleRole)43);
		ll_btndeljmfile.set_ColorTable((eButtonColor)3);
		((Control)ll_btndeljmfile).set_Enabled(false);
		ButtonX obj7 = ll_btndeljmfile;
		location = new Point(117, 319);
		((Control)obj7).set_Location(location);
		((Control)ll_btndeljmfile).set_Name("ll_btndeljmfile");
		ButtonX obj8 = ll_btndeljmfile;
		size = new Size(192, 31);
		((Control)obj8).set_Size(size);
		((PopupItemControl)ll_btndeljmfile).set_Style((eDotNetBarStyle)7);
		((Control)ll_btndeljmfile).set_TabIndex(1);
		ll_btndeljmfile.set_Text("在硬盘上删除当前显示的截面文件");
		((Control)ll_btninput5var).set_AccessibleRole((AccessibleRole)43);
		ll_btninput5var.set_ColorTable((eButtonColor)3);
		ButtonX obj9 = ll_btninput5var;
		location = new Point(315, 319);
		((Control)obj9).set_Location(location);
		((Control)ll_btninput5var).set_Name("ll_btninput5var");
		ButtonX obj10 = ll_btninput5var;
		size = new Size(160, 31);
		((Control)obj10).set_Size(size);
		((PopupItemControl)ll_btninput5var).set_Style((eDotNetBarStyle)7);
		((Control)ll_btninput5var).set_TabIndex(1);
		ll_btninput5var.set_Text("提取当前文件信息到参数表");
		((Control)ll_btnsearchjm123).set_AccessibleRole((AccessibleRole)43);
		ll_btnsearchjm123.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = ll_btnsearchjm123;
		location = new Point(592, 319);
		((Control)obj11).set_Location(location);
		((Control)ll_btnsearchjm123).set_Name("ll_btnsearchjm123");
		ButtonX obj12 = ll_btnsearchjm123;
		size = new Size(115, 31);
		((Control)obj12).set_Size(size);
		((PopupItemControl)ll_btnsearchjm123).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnsearchjm123).set_TabIndex(1);
		ll_btnsearchjm123.set_Text("搜索截面类型");
		((ListControl)ll_lbliucheng).set_FormattingEnabled(true);
		ll_lbliucheng.set_ItemHeight(12);
		ListBox obj13 = ll_lbliucheng;
		location = new Point(4, 3);
		((Control)obj13).set_Location(location);
		((Control)ll_lbliucheng).set_Name("ll_lbliucheng");
		ListBox obj14 = ll_lbliucheng;
		size = new Size(488, 160);
		((Control)obj14).set_Size(size);
		((Control)ll_lbliucheng).set_TabIndex(0);
		((PanelControl)GroupPanel1).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_btnok);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_opt2);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX5);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_opt1);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_lbb12_i);
		GroupPanel groupPanel = GroupPanel1;
		location = new Point(514, 358);
		((Control)groupPanel).set_Location(location);
		((Control)GroupPanel1).set_Name("GroupPanel1");
		GroupPanel groupPanel2 = GroupPanel1;
		size = new Size(193, 207);
		((Control)groupPanel2).set_Size(size);
		((PanelControl)GroupPanel1).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)GroupPanel1).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)GroupPanel1).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)GroupPanel1).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)GroupPanel1).get_Style().set_BorderBottomWidth(1);
		((PanelControl)GroupPanel1).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)GroupPanel1).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)GroupPanel1).get_Style().set_BorderLeftWidth(1);
		((PanelControl)GroupPanel1).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)GroupPanel1).get_Style().set_BorderRightWidth(1);
		((PanelControl)GroupPanel1).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)GroupPanel1).get_Style().set_BorderTopWidth(1);
		((PanelControl)GroupPanel1).get_Style().set_Class("");
		((PanelControl)GroupPanel1).get_Style().set_CornerDiameter(4);
		((PanelControl)GroupPanel1).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)GroupPanel1).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)GroupPanel1).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)GroupPanel1).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)GroupPanel1).get_StyleMouseDown().set_Class("");
		((PanelControl)GroupPanel1).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)GroupPanel1).get_StyleMouseOver().set_Class("");
		((PanelControl)GroupPanel1).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)GroupPanel1).set_TabIndex(2);
		((Control)ll_btnok).set_AccessibleRole((AccessibleRole)43);
		ll_btnok.set_ColorTable((eButtonColor)3);
		ButtonX obj15 = ll_btnok;
		location = new Point(16, 163);
		((Control)obj15).set_Location(location);
		((Control)ll_btnok).set_Name("ll_btnok");
		ButtonX obj16 = ll_btnok;
		size = new Size(141, 32);
		((Control)obj16).set_Size(size);
		((PopupItemControl)ll_btnok).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnok).set_TabIndex(1);
		ll_btnok.set_Text("保存");
		((ButtonBase)ll_opt2).set_AutoSize(true);
		((Control)ll_opt2).set_ForeColor(SystemColors.MenuHighlight);
		RadioButton obj17 = ll_opt2;
		location = new Point(16, 97);
		((Control)obj17).set_Location(location);
		((Control)ll_opt2).set_Name("ll_opt2");
		RadioButton obj18 = ll_opt2;
		size = new Size(53, 16);
		((Control)obj18).set_Size(size);
		((Control)ll_opt2).set_TabIndex(0);
		ll_opt2.set_TabStop(true);
		((ButtonBase)ll_opt2).set_Text("2号臂");
		((ButtonBase)ll_opt2).set_UseVisualStyleBackColor(true);
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX5;
		location = new Point(100, 1);
		((Control)labelX).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX2 = LabelX5;
		size = new Size(42, 16);
		((Control)labelX2).set_Size(size);
		((Control)LabelX5).set_TabIndex(3);
		LabelX5.set_Text("臂节i");
		((ButtonBase)ll_opt1).set_AutoSize(true);
		((Control)ll_opt1).set_ForeColor(SystemColors.MenuHighlight);
		RadioButton obj19 = ll_opt1;
		location = new Point(16, 56);
		((Control)obj19).set_Location(location);
		((Control)ll_opt1).set_Name("ll_opt1");
		RadioButton obj20 = ll_opt1;
		size = new Size(53, 16);
		((Control)obj20).set_Size(size);
		((Control)ll_opt1).set_TabIndex(0);
		ll_opt1.set_TabStop(true);
		((ButtonBase)ll_opt1).set_Text("1号臂");
		((ButtonBase)ll_opt1).set_UseVisualStyleBackColor(true);
		((ListControl)ll_lbb12_i).set_FormattingEnabled(true);
		ll_lbb12_i.set_ItemHeight(12);
		ListBox obj21 = ll_lbb12_i;
		location = new Point(87, 21);
		((Control)obj21).set_Location(location);
		((Control)ll_lbb12_i).set_Name("ll_lbb12_i");
		ListBox obj22 = ll_lbb12_i;
		size = new Size(68, 136);
		((Control)obj22).set_Size(size);
		((Control)ll_lbb12_i).set_TabIndex(0);
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ll_btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj23 = ll_btnexit;
		location = new Point(344, 165);
		((Control)obj23).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj24 = ll_btnexit;
		size = new Size(148, 32);
		((Control)obj24).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(1);
		ll_btnexit.set_Text("关闭");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX1;
		location = new Point(8, 35);
		((Control)labelX3).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX4 = LabelX1;
		size = new Size(75, 16);
		((Control)labelX4).set_Size(size);
		((Control)LabelX1).set_TabIndex(3);
		LabelX1.set_Text("处理选项");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX2;
		location = new Point(137, 36);
		((Control)labelX5).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX6 = LabelX2;
		size = new Size(75, 16);
		((Control)labelX6).set_Size(size);
		((Control)LabelX2).set_TabIndex(3);
		LabelX2.set_Text("实例名称");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX7 = LabelX3;
		location = new Point(269, 36);
		((Control)labelX7).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX8 = LabelX3;
		size = new Size(197, 16);
		((Control)labelX8).set_Size(size);
		((Control)LabelX3).set_TabIndex(3);
		LabelX3.set_Text("截面文件名[双击查看]");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX9 = LabelX4;
		location = new Point(12, 334);
		((Control)labelX9).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX10 = LabelX4;
		size = new Size(99, 16);
		((Control)labelX10).set_Size(size);
		((Control)LabelX4).set_TabIndex(3);
		LabelX4.set_Text("操作流程记录..");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX11 = LabelX6;
		location = new Point(12, 9);
		((Control)labelX11).set_Location(location);
		((Control)LabelX6).set_Name("LabelX6");
		LabelX labelX12 = LabelX6;
		size = new Size(212, 16);
		((Control)labelX12).set_Size(size);
		((Control)LabelX6).set_TabIndex(3);
		LabelX6.set_Text("当前已存在截面数据文件");
		ll_lbjm123.set_BackColor(Color.Gray);
		ll_lbjm123.set_ForeColor(Color.White);
		((ListControl)ll_lbjm123).set_FormattingEnabled(true);
		ll_lbjm123.set_ItemHeight(12);
		ListBox obj25 = ll_lbjm123;
		location = new Point(688, 57);
		((Control)obj25).set_Location(location);
		((Control)ll_lbjm123).set_Name("ll_lbjm123");
		ListBox obj26 = ll_lbjm123;
		size = new Size(19, 256);
		((Control)obj26).set_Size(size);
		((Control)ll_lbjm123).set_TabIndex(0);
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX13 = LabelX7;
		location = new Point(683, 36);
		((Control)labelX13).set_Location(location);
		((Control)LabelX7).set_Name("LabelX7");
		LabelX labelX14 = LabelX7;
		size = new Size(36, 16);
		((Control)labelX14).set_Size(size);
		((Control)LabelX7).set_TabIndex(3);
		LabelX7.set_Text("截面i");
		((PanelControl)GroupPanel2).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel2).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_lbliucheng);
		GroupPanel groupPanel3 = GroupPanel2;
		location = new Point(8, 356);
		((Control)groupPanel3).set_Location(location);
		((Control)GroupPanel2).set_Name("GroupPanel2");
		GroupPanel groupPanel4 = GroupPanel2;
		size = new Size(503, 209);
		((Control)groupPanel4).set_Size(size);
		((PanelControl)GroupPanel2).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)GroupPanel2).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)GroupPanel2).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)GroupPanel2).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)GroupPanel2).get_Style().set_BorderBottomWidth(1);
		((PanelControl)GroupPanel2).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)GroupPanel2).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)GroupPanel2).get_Style().set_BorderLeftWidth(1);
		((PanelControl)GroupPanel2).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)GroupPanel2).get_Style().set_BorderRightWidth(1);
		((PanelControl)GroupPanel2).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)GroupPanel2).get_Style().set_BorderTopWidth(1);
		((PanelControl)GroupPanel2).get_Style().set_Class("");
		((PanelControl)GroupPanel2).get_Style().set_CornerDiameter(4);
		((PanelControl)GroupPanel2).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)GroupPanel2).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)GroupPanel2).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)GroupPanel2).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)GroupPanel2).get_StyleMouseDown().set_Class("");
		((PanelControl)GroupPanel2).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)GroupPanel2).get_StyleMouseOver().set_Class("");
		((PanelControl)GroupPanel2).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)GroupPanel2).set_TabIndex(4);
		((Control)ll_btnjmcheck).set_AccessibleRole((AccessibleRole)43);
		ll_btnjmcheck.set_ColorTable((eButtonColor)3);
		ButtonX obj27 = ll_btnjmcheck;
		location = new Point(481, 319);
		((Control)obj27).set_Location(location);
		((Control)ll_btnjmcheck).set_Name("ll_btnjmcheck");
		ButtonX obj28 = ll_btnjmcheck;
		size = new Size(105, 31);
		((Control)obj28).set_Size(size);
		((PopupItemControl)ll_btnjmcheck).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnjmcheck).set_TabIndex(1);
		ll_btnjmcheck.set_Text("查看系列截面");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(729, 571);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)LabelX4);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel2);
		((Control)this).get_Controls().Add((Control)(object)LabelX3);
		((Control)this).get_Controls().Add((Control)(object)LabelX7);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)ll_lbjm123);
		((Control)this).get_Controls().Add((Control)(object)LabelX6);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel1);
		((Control)this).get_Controls().Add((Control)(object)ll_btnjmcheck);
		((Control)this).get_Controls().Add((Control)(object)ll_btnsearchjm123);
		((Control)this).get_Controls().Add((Control)(object)ll_btninput5var);
		((Control)this).get_Controls().Add((Control)(object)ll_btndeljmfile);
		((Control)this).get_Controls().Add((Control)(object)ll_lbjmfilename);
		((Control)this).get_Controls().Add((Control)(object)ll_lbshilifile);
		((Control)this).get_Controls().Add((Control)(object)ll_lbenhance);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("jmsaveinfo");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("截面数据保存信息...");
		((Control)GroupPanel1).ResumeLayout(false);
		((Control)GroupPanel1).PerformLayout();
		((Control)GroupPanel2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void jmsaveinfo_Load(object sender, EventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		((Control)LabelX5).set_BackColor(Color.Transparent);
		((ButtonBase)ll_opt1).set_BackColor(Color.Transparent);
		((ButtonBase)ll_opt2).set_BackColor(Color.Transparent);
		ll_lbenhance.get_Items().Clear();
		ll_lbjm123.get_Items().Clear();
		if (!File.Exists(Mod1.cshlis))
		{
			Interaction.MsgBox((object)("不存在文件:" + Mod1.cshlis), (MsgBoxStyle)64, (object)"提示");
			return;
		}
		string text = Mod1.cshh.Substring(checked(Mod1.cshh.LastIndexOf("\\") + 1));
		text = Mod1.cshh + "\\" + text + ".lis";
		Mod1.lr = new StreamReader(text, Encoding.Default);
		f = "";
		while (!Information.IsNothing((object)f))
		{
			f = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)f))
			{
				break;
			}
			ll_lbenhance.get_Items().Add((object)f);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		if (ll_lbenhance.get_Items().get_Count() != 0)
		{
			ll_lbenhance.set_SelectedIndex(0);
		}
		ll_opt1.set_Checked(true);
		ll_opt1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		((Control)ll_btnok).set_Enabled(false);
		jb = ll_lbb12_i.get_Items().get_Count();
	}

	private void ll_lbshilifile_SelectedIndexChanged(object sender, EventArgs e)
	{
		ll_lbjmfilename.get_Items().Clear();
		if ((ll_lbshilifile.get_SelectedIndex() != -1) & (ll_lbshilifile.get_Items().get_Count() > 0))
		{
			((Control)ll_btnsearchjm123).set_Enabled(true);
		}
		else
		{
			((Control)ll_btnsearchjm123).set_Enabled(false);
		}
		ListBox val = ll_lbenhance;
		string text = val.get_Text();
		string text2 = Mod1.toen(ref text);
		val.set_Text(text);
		if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(ll_lbshilifile.get_Text(), "", false) != 0))
		{
			string[] array = new string[6]
			{
				Mod1.cshh,
				"\\",
				null,
				null,
				null,
				null
			};
			ListBox val2 = ll_lbenhance;
			string text3 = val2.get_Text();
			string text4 = Mod1.toen(ref text3);
			val2.set_Text(text3);
			array[2] = text4;
			array[3] = "\\";
			array[4] = ll_lbshilifile.get_Text();
			array[5] = "\\source\\Var\\Sect";
			lj = string.Concat(array);
			Addvar(ref lj);
		}
		ll_btnsearchjm123_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ll_lbenhance_SelectedIndexChanged(object sender, EventArgs e)
	{
		ll_lbshilifile.get_Items().Clear();
		ll_lbjmfilename.get_Items().Clear();
		string cshh = Mod1.cshh;
		ListBox val = ll_lbenhance;
		string text = val.get_Text();
		string text2 = Mod1.toen(ref text);
		val.set_Text(text);
		string[] directories = Directory.GetDirectories(cshh + "\\" + text2);
		checked
		{
			int num = directories.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text3 = directories[i].Substring(directories[i].LastIndexOf("\\") + 1);
				ll_lbshilifile.get_Items().Add((object)text3);
			}
			if (ll_lbshilifile.get_Items().get_Count() != 0)
			{
				ll_lbshilifile.set_SelectedIndex(0);
			}
		}
	}

	public void Addvar(ref string path)
	{
		string[] files = Directory.GetFiles(path, "*.var", SearchOption.TopDirectoryOnly);
		checked
		{
			int num = files.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				ll_lbjmfilename.get_Items().Add((object)files[i]);
			}
		}
	}

	private void ll_btninput5var_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Invalid comparison between Unknown and I4
		checked
		{
			string text;
			if (ll_lbjmfilename.get_Items().get_Count() == 0)
			{
				text = "当前截面文件列表为空.";
				Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"提示");
				ll_lbliucheng.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text));
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				return;
			}
			if (ll_lbjmfilename.get_SelectedIndex() == -1)
			{
				text = "请选择某截面文件.";
				Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"提示");
				ll_lbliucheng.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text));
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				return;
			}
			if (ll_lbjm123.get_Items().get_Count() == 0)
			{
				text = "当前截面i列表为空,请点击[搜索截面类型].";
				Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"提示");
				ll_lbliucheng.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text));
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				return;
			}
			fname = Conversions.ToString(ll_lbjmfilename.get_Items().get_Item(ll_lbjmfilename.get_SelectedIndex()));
			string text2 = Conversions.ToString(Operators.ConcatenateObject((object)"截面ID_", ll_lbjm123.get_Items().get_Item(ll_lbjmfilename.get_SelectedIndex())));
			if (!File.Exists(fname))
			{
				return;
			}
			if (unchecked((int)MessageBox.Show("是否使用当前文件覆盖当前参数表xls中已存在的截面信息?", "提示 :截面类型为" + text2, (MessageBoxButtons)4, (MessageBoxIcon)64)) == 7)
			{
				text = "当前更新过程终止.";
				ll_lbliucheng.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text));
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				return;
			}
			((Control)MyProject.Forms.jinduclxd).Show();
			MyProject.Forms.jinduclxd.PBZ.set_Maximum(Mod1.wb.Worksheets.Count);
			int count = Mod1.wb.Worksheets.Count;
			IEnumerator enumerator = default(IEnumerator);
			int column = default(int);
			for (int i = 1; i <= count; i++)
			{
				Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)i);
				MyProject.Forms.jinduclxd.PBZ.set_Value(i);
				if (!((Operators.CompareString(Mod1.excelsheet.Name, "动参数临时", false) != 0) & (Operators.CompareString(Mod1.excelsheet.Name, "参数校验", false) != 0)))
				{
					continue;
				}
				bool flag = true;
				Excel.Range range;
				try
				{
					enumerator = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
					while (enumerator.MoveNext())
					{
						range = (Excel.Range)enumerator.Current;
						string text3 = Conversions.ToString(range.get_Value((object)Missing.Value));
						if (Operators.CompareString(Strings.Trim(text3), "", false) != 0)
						{
							if (Operators.CompareString(Strings.UCase(Strings.Trim(text3)), Strings.UCase(Strings.Trim(text2)), false) == 0)
							{
								column = range.Column;
								break;
							}
							continue;
						}
						flag = false;
						break;
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (!unchecked(flag && column > 4 && column < 200))
				{
					continue;
				}
				range = (Excel.Range)Mod1.excelsheet.Cells[Mod1.excelsheet.Cells.Rows.Count, column];
				int row = range.get_End(XlDirection.xlUp).Row;
				MyProject.Forms.jinduclxd.PBD.set_Maximum(row);
				Mod1.lr = new StreamReader(fname, Encoding.Default);
				f = "";
				while (!Information.IsNothing((object)f))
				{
					f = Mod1.lr.ReadLine();
					if (Information.IsNothing((object)f))
					{
						break;
					}
					if (Operators.CompareString(Strings.Trim(f), "", false) == 0)
					{
						continue;
					}
					string[] array = Strings.Split(Strings.Trim(f), "=", -1, (CompareMethod)0);
					if (Information.UBound((Array)array, 1) < 1)
					{
						continue;
					}
					int num = row;
					for (int j = 2; j <= num; j++)
					{
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, column], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0 && Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)))), Strings.UCase(Strings.Trim(array[0])), false) == 0)
						{
							NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[j, 3], (Type)null, "value", new object[1] { Strings.Trim(array[1]) }, (string[])null, (Type[])null, false, true);
							MyProject.Forms.jinduclxd.PBD.set_Value(j);
							MyProject.Forms.jinduclxd.xx.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat("当前替换的参数名：" + f, " 值："), NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
							((Control)MyProject.Forms.jinduclxd).Refresh();
						}
					}
				}
				Mod1.lr.Close();
				Mod1.lr.Dispose();
			}
			((Component)(object)MyProject.Forms.jinduclxd).Dispose();
			text = "当前参数表已被更新." + fname + " 截面类型为" + text2;
			ll_lbliucheng.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text));
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	private void ll_btnsearchjm123_Click(object sender, EventArgs e)
	{
		ll_lbjm123.get_Items().Clear();
		checked
		{
			int num = ll_lbjmfilename.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				bool flag = false;
				string path = Conversions.ToString(ll_lbjmfilename.get_Items().get_Item(i));
				if (File.Exists(path))
				{
					Mod1.lr = new StreamReader(path, Encoding.Default);
					f = "";
					while (!Information.IsNothing((object)f))
					{
						f = Mod1.lr.ReadLine();
						if (Information.IsNothing((object)f))
						{
							break;
						}
						if (Operators.CompareString(Strings.Trim(f), "", false) != 0 && Operators.CompareString(Strings.Left(f, 1), "!", false) != 0)
						{
							string[] array = Strings.Split(f, "=", -1, (CompareMethod)0);
							if (Information.UBound((Array)array, 1) >= 1 && Operators.CompareString(Strings.UCase(Strings.Trim(array[0])), "JM_STYLE", false) == 0)
							{
								ll_lbjm123.get_Items().Add((object)Strings.Trim(array[1]));
								flag = true;
								break;
							}
						}
					}
					Mod1.lr.Close();
					Mod1.lr.Dispose();
				}
				if (!flag)
				{
					ll_lbjm123.get_Items().Add((object)"0");
				}
			}
			if (ll_lbjmfilename.get_SelectedIndex() != -1)
			{
				ll_lbjm123.set_SelectedIndex(ll_lbjmfilename.get_SelectedIndex());
			}
		}
	}

	private void ll_opt1_Click(object sender, EventArgs e)
	{
		ll_lbb12_i.get_Items().Clear();
		((Control)ll_btnok).set_Enabled(false);
		checked
		{
			if (ll_opt1.get_Checked())
			{
				int num = 1;
				do
				{
					ll_lbb12_i.get_Items().Add((object)num);
					num++;
				}
				while (num <= 6);
			}
			else
			{
				int num2 = 1;
				do
				{
					ll_lbb12_i.get_Items().Add((object)num2);
					num2++;
				}
				while (num2 <= 5);
			}
		}
	}

	private void ll_opt2_Click(object sender, EventArgs e)
	{
		ll_lbb12_i.get_Items().Clear();
		((Control)ll_btnok).set_Enabled(false);
		checked
		{
			if (ll_opt2.get_Checked())
			{
				int num = 1;
				do
				{
					ll_lbb12_i.get_Items().Add((object)num);
					num++;
				}
				while (num <= 5);
			}
			else
			{
				int num2 = 1;
				do
				{
					ll_lbb12_i.get_Items().Add((object)num2);
					num2++;
				}
				while (num2 <= 6);
			}
		}
	}

	private void ll_btnok_Click(object sender, EventArgs e)
	{
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Invalid comparison between Unknown and I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		enhancecurListNumber = ll_lbenhance.get_SelectedIndex();
		ListBox val = ll_lbenhance;
		string text = val.get_Text();
		string curWD = Mod1.toen(ref text);
		val.set_Text(text);
		CurWD4 = curWD;
		string[] array = new string[5]
		{
			Mod1.cshh,
			"\\",
			null,
			null,
			null
		};
		val = ll_lbenhance;
		text = val.get_Text();
		string text2 = Mod1.toen(ref text);
		val.set_Text(text);
		array[2] = text2;
		array[3] = "\\";
		array[4] = ll_lbshilifile.get_Text();
		sourcefilepath = string.Concat(array);
		switch (Mod1.curjmID)
		{
		case "截面ID_1":
			JM_style = "JM_style = 1";
			goto IL_00e6;
		case "截面ID_2":
			JM_style = " JM_style = 2";
			goto IL_00e6;
		case "截面ID_3":
			{
				JM_style = "JM_style = 3";
				goto IL_00e6;
			}
			IL_00e6:
			curb12 = 1;
			if (ll_opt2.get_Checked())
			{
				curb12 = 2;
			}
			fname = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(sourcefilepath + "\\source\\var\\sect\\Z", Conversions.ToString(curb12)), "_"), ll_lbb12_i.get_Items().get_Item(ll_lbb12_i.get_SelectedIndex())), (object)".VAR"));
			if (File.Exists(fname))
			{
				if ((int)MessageBox.Show("是否覆盖当前已存在的截面信息文件? " + fname, "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 7)
				{
					strtemp = "当前保存过程终止.";
					ll_lbliucheng.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + strtemp));
					ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
					return;
				}
				xievar();
			}
			else
			{
				xievar();
			}
			ll_btnsearchjm123_Click(RuntimeHelpers.GetObjectValue(sender), e);
			return;
		}
		strtemp = "当前截面ID不正确!! !" + Mod1.curjmID;
		Interaction.MsgBox((object)strtemp, (MsgBoxStyle)0, (object)"提示");
		ll_lbliucheng.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + strtemp));
		ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
	}

	private void ll_lbb12_i_SelectedIndexChanged(object sender, EventArgs e)
	{
		ll_lbjmfilename.set_SelectedIndex(-1);
		checked
		{
			if (ll_opt1.get_Checked())
			{
				int num = ll_lbjmfilename.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = Conversions.ToString(ll_lbjmfilename.get_Items().get_Item(i));
					text = text.Substring(text.LastIndexOf("\\") + 1);
					if (Operators.CompareString(text.ToUpper(), "Z1_" + ll_lbb12_i.get_Text() + ".VAR", false) == 0)
					{
						ll_lbjmfilename.set_SelectedIndex(i);
						break;
					}
				}
			}
			else
			{
				int num2 = ll_lbjmfilename.get_Items().get_Count() - 1;
				for (int j = 0; j <= num2; j++)
				{
					string text = Conversions.ToString(ll_lbjmfilename.get_Items().get_Item(j));
					text = text.Substring(text.LastIndexOf("\\") + 1);
					if (Operators.CompareString(text.ToUpper(), "Z2_" + ll_lbb12_i.get_Text() + ".VAR", false) == 0)
					{
						ll_lbjmfilename.set_SelectedIndex(j);
						break;
					}
				}
			}
			((Control)ll_btnok).set_Enabled(true);
		}
	}

	private void ll_lbjmfilename_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ll_lbjm123.get_Items().get_Count() != 0)
		{
			ll_lbjm123.set_SelectedIndex(ll_lbjmfilename.get_SelectedIndex());
		}
	}

	private void ll_lbjmfilename_DoubleClick(object sender, EventArgs e)
	{
		if (ll_lbjmfilename.get_SelectedIndex() != -1)
		{
			string text = Conversions.ToString(ll_lbjmfilename.get_Items().get_Item(ll_lbjmfilename.get_SelectedIndex()));
			if (File.Exists(text))
			{
				Process.Start(Interaction.Environ("windir") + "\\NOTEPAD.EXE", text);
			}
		}
	}

	private void ll_lbjm123_SelectedIndexChanged(object sender, EventArgs e)
	{
		if ((ll_lbjmfilename.get_Items().get_Count() != 0) & (ll_lbjm123.get_SelectedIndex() != -1))
		{
			ll_lbjmfilename.set_SelectedIndex(ll_lbjm123.get_SelectedIndex());
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
					MyProject.Forms.cslr2.lslog.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_lbliucheng.get_Items().get_Item(i)));
				}
			}
			((Form)this).Close();
			((Component)(object)this).Dispose();
		}
	}

	public void xievar()
	{
		Mod1.wr = new StreamWriter(fname, append: false, Encoding.Default);
		int count = Mod1.wb.Worksheets.Count;
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			int column = default(int);
			for (int i = 1; i <= count; i++)
			{
				Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)i);
				if (!((Operators.CompareString(Mod1.excelsheet.Name, "动参数临时", false) != 0) & (Operators.CompareString(Mod1.excelsheet.Name, "参数校验", false) != 0)))
				{
					continue;
				}
				bool flag = true;
				Excel.Range range;
				try
				{
					enumerator = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
					while (enumerator.MoveNext())
					{
						range = (Excel.Range)enumerator.Current;
						string text = Conversions.ToString(range.get_Value((object)Missing.Value));
						if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
						{
							if (Operators.CompareString(Strings.UCase(Strings.Trim(text)), Strings.UCase(Strings.Trim(Mod1.curjmID)), false) == 0)
							{
								column = range.Column;
								break;
							}
							continue;
						}
						flag = false;
						break;
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (!unchecked(flag && column > 4 && column < 200))
				{
					continue;
				}
				range = (Excel.Range)Mod1.excelsheet.Cells[Mod1.excelsheet.Cells.Rows.Count, column];
				int row = range.get_End(XlDirection.xlUp).Row;
				int num = row;
				for (int j = 2; j <= num; j++)
				{
					if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, column], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0 && ((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0) & (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)))
					{
						Mod1.wr.WriteLine(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))) + "=" + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
					}
				}
			}
			Mod1.wr.Close();
			Mod1.wr.Dispose();
			strtemp = "当前已保存." + fname;
			ll_lbliucheng.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + strtemp));
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	private void ll_btnjmcheck_Click(object sender, EventArgs e)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		Conversions.ToString(ll_lbshilifile.get_Items().get_Item(ll_lbshilifile.get_SelectedIndex()));
		enhancecurListNumber = ll_lbenhance.get_SelectedIndex();
		string[] array = new string[5]
		{
			Mod1.cshh,
			"\\",
			null,
			null,
			null
		};
		ListBox val = ll_lbenhance;
		string text = val.get_Text();
		string text2 = Mod1.toen(ref text);
		val.set_Text(text);
		array[2] = text2;
		array[3] = "\\";
		array[4] = ll_lbshilifile.get_Text();
		sourcefilepath = string.Concat(array);
		((Form)MyProject.Forms.ll_ufjmcheckall).ShowDialog();
		((Component)(object)MyProject.Forms.ll_ufjmcheckall).Dispose();
	}
}
