using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class xn : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("GroupPanel1")]
	private GroupPanel _GroupPanel1;

	[AccessedThroughProperty("GroupPanel2")]
	private GroupPanel _GroupPanel2;

	[AccessedThroughProperty("GroupPanel3")]
	private GroupPanel _GroupPanel3;

	[AccessedThroughProperty("GroupPanel4")]
	private GroupPanel _GroupPanel4;

	[AccessedThroughProperty("lbzb")]
	private ListBox _lbzb;

	[AccessedThroughProperty("lbfb")]
	private ListBox _lbfb;

	[AccessedThroughProperty("lbtb")]
	private ListBox _lbtb;

	[AccessedThroughProperty("lbcq")]
	private ListBox _lbcq;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("btntemp")]
	private ButtonX _btntemp;

	[AccessedThroughProperty("btnsaveopt")]
	private ButtonX _btnsaveopt;

	[AccessedThroughProperty("btngb")]
	private ButtonX _btngb;

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

	internal virtual GroupPanel GroupPanel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupPanel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupPanel3 = value;
		}
	}

	internal virtual GroupPanel GroupPanel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupPanel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupPanel4 = value;
		}
	}

	internal virtual ListBox lbzb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbzb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbzb = value;
		}
	}

	internal virtual ListBox lbfb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbfb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbfb = value;
		}
	}

	internal virtual ListBox lbtb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbtb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbtb = value;
		}
	}

	internal virtual ListBox lbcq
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbcq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbcq = value;
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

	internal virtual ButtonX btntemp
	{
		[DebuggerNonUserCode]
		get
		{
			return _btntemp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btntemp_Click;
			if (_btntemp != null)
			{
				((Control)_btntemp).remove_Click(eventHandler);
			}
			_btntemp = value;
			if (_btntemp != null)
			{
				((Control)_btntemp).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnsaveopt
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnsaveopt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnsaveopt_Click;
			if (_btnsaveopt != null)
			{
				((Control)_btnsaveopt).remove_Click(eventHandler);
			}
			_btnsaveopt = value;
			if (_btnsaveopt != null)
			{
				((Control)_btnsaveopt).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btngb
	{
		[DebuggerNonUserCode]
		get
		{
			return _btngb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btngb_Click;
			if (_btngb != null)
			{
				((Control)_btngb).remove_Click(eventHandler);
			}
			_btngb = value;
			if (_btngb != null)
			{
				((Control)_btngb).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public xn()
	{
		((Form)this).add_Load((EventHandler)xn_Load);
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
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected O, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected O, but got Unknown
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Expected O, but got Unknown
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Expected O, but got Unknown
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be1: Expected O, but got Unknown
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7b: Expected O, but got Unknown
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Expected O, but got Unknown
		//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddb: Expected O, but got Unknown
		//IL_0e77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e81: Expected O, but got Unknown
		//IL_0f3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f45: Expected O, but got Unknown
		GroupPanel1 = new GroupPanel();
		lbzb = new ListBox();
		GroupPanel2 = new GroupPanel();
		lbfb = new ListBox();
		GroupPanel3 = new GroupPanel();
		lbtb = new ListBox();
		GroupPanel4 = new GroupPanel();
		lbcq = new ListBox();
		LabelX1 = new LabelX();
		btntemp = new ButtonX();
		btnsaveopt = new ButtonX();
		btngb = new ButtonX();
		((Control)GroupPanel1).SuspendLayout();
		((Control)GroupPanel2).SuspendLayout();
		((Control)GroupPanel3).SuspendLayout();
		((Control)GroupPanel4).SuspendLayout();
		((Control)this).SuspendLayout();
		((PanelControl)GroupPanel1).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)lbzb);
		((Control)GroupPanel1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		GroupPanel groupPanel = GroupPanel1;
		Point location = new Point(4, 5);
		((Control)groupPanel).set_Location(location);
		((Control)GroupPanel1).set_Name("GroupPanel1");
		GroupPanel groupPanel2 = GroupPanel1;
		Size size = new Size(154, 238);
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
		((Control)GroupPanel1).set_TabIndex(0);
		((PanelControl)GroupPanel1).set_Text("主臂");
		lbzb.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		lbzb.set_ItemHeight(12);
		ListBox obj = lbzb;
		location = new Point(5, 3);
		((Control)obj).set_Location(location);
		((Control)lbzb).set_Name("lbzb");
		ListBox obj2 = lbzb;
		size = new Size(136, 208);
		((Control)obj2).set_Size(size);
		((Control)lbzb).set_TabIndex(1);
		((PanelControl)GroupPanel2).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel2).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)lbfb);
		((Control)GroupPanel2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		GroupPanel groupPanel3 = GroupPanel2;
		location = new Point(164, 5);
		((Control)groupPanel3).set_Location(location);
		((Control)GroupPanel2).set_Name("GroupPanel2");
		GroupPanel groupPanel4 = GroupPanel2;
		size = new Size(149, 238);
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
		((Control)GroupPanel2).set_TabIndex(0);
		((PanelControl)GroupPanel2).set_Text("副臂");
		lbfb.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		lbfb.set_ItemHeight(12);
		ListBox obj3 = lbfb;
		location = new Point(3, 3);
		((Control)obj3).set_Location(location);
		((Control)lbfb).set_Name("lbfb");
		ListBox obj4 = lbfb;
		size = new Size(136, 208);
		((Control)obj4).set_Size(size);
		((Control)lbfb).set_TabIndex(1);
		((PanelControl)GroupPanel3).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel3).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel3).get_Controls().Add((Control)(object)lbtb);
		((Control)GroupPanel3).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		GroupPanel groupPanel5 = GroupPanel3;
		location = new Point(319, 5);
		((Control)groupPanel5).set_Location(location);
		((Control)GroupPanel3).set_Name("GroupPanel3");
		GroupPanel groupPanel6 = GroupPanel3;
		size = new Size(149, 238);
		((Control)groupPanel6).set_Size(size);
		((PanelControl)GroupPanel3).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)GroupPanel3).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)GroupPanel3).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)GroupPanel3).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)GroupPanel3).get_Style().set_BorderBottomWidth(1);
		((PanelControl)GroupPanel3).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)GroupPanel3).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)GroupPanel3).get_Style().set_BorderLeftWidth(1);
		((PanelControl)GroupPanel3).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)GroupPanel3).get_Style().set_BorderRightWidth(1);
		((PanelControl)GroupPanel3).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)GroupPanel3).get_Style().set_BorderTopWidth(1);
		((PanelControl)GroupPanel3).get_Style().set_Class("");
		((PanelControl)GroupPanel3).get_Style().set_CornerDiameter(4);
		((PanelControl)GroupPanel3).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)GroupPanel3).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)GroupPanel3).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)GroupPanel3).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)GroupPanel3).get_StyleMouseDown().set_Class("");
		((PanelControl)GroupPanel3).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)GroupPanel3).get_StyleMouseOver().set_Class("");
		((PanelControl)GroupPanel3).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)GroupPanel3).set_TabIndex(0);
		((PanelControl)GroupPanel3).set_Text("塔臂");
		lbtb.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		lbtb.set_ItemHeight(12);
		ListBox obj5 = lbtb;
		location = new Point(3, 3);
		((Control)obj5).set_Location(location);
		((Control)lbtb).set_Name("lbtb");
		ListBox obj6 = lbtb;
		size = new Size(136, 208);
		((Control)obj6).set_Size(size);
		((Control)lbtb).set_TabIndex(1);
		((PanelControl)GroupPanel4).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel4).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel4).get_Controls().Add((Control)(object)lbcq);
		((Control)GroupPanel4).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		GroupPanel groupPanel7 = GroupPanel4;
		location = new Point(474, 5);
		((Control)groupPanel7).set_Location(location);
		((Control)GroupPanel4).set_Name("GroupPanel4");
		GroupPanel groupPanel8 = GroupPanel4;
		size = new Size(150, 238);
		((Control)groupPanel8).set_Size(size);
		((PanelControl)GroupPanel4).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)GroupPanel4).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)GroupPanel4).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)GroupPanel4).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)GroupPanel4).get_Style().set_BorderBottomWidth(1);
		((PanelControl)GroupPanel4).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)GroupPanel4).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)GroupPanel4).get_Style().set_BorderLeftWidth(1);
		((PanelControl)GroupPanel4).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)GroupPanel4).get_Style().set_BorderRightWidth(1);
		((PanelControl)GroupPanel4).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)GroupPanel4).get_Style().set_BorderTopWidth(1);
		((PanelControl)GroupPanel4).get_Style().set_Class("");
		((PanelControl)GroupPanel4).get_Style().set_CornerDiameter(4);
		((PanelControl)GroupPanel4).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)GroupPanel4).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)GroupPanel4).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)GroupPanel4).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)GroupPanel4).get_StyleMouseDown().set_Class("");
		((PanelControl)GroupPanel4).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)GroupPanel4).get_StyleMouseOver().set_Class("");
		((PanelControl)GroupPanel4).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)GroupPanel4).set_TabIndex(0);
		((PanelControl)GroupPanel4).set_Text("超起");
		lbcq.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		lbcq.set_ItemHeight(12);
		ListBox obj7 = lbcq;
		location = new Point(3, 3);
		((Control)obj7).set_Location(location);
		((Control)lbcq).set_Name("lbcq");
		ListBox obj8 = lbcq;
		size = new Size(137, 208);
		((Control)obj8).set_Size(size);
		((Control)lbcq).set_TabIndex(1);
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		location = new Point(4, 249);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(271, 68);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(1);
		LabelX1.set_Text("说明:\r\nnew 列存放的是为当前参数文件中已保存的参数;\r\n300/400/500/.. .为库中存放的产品参数.");
		((Control)btntemp).set_AccessibleRole((AccessibleRole)43);
		btntemp.set_ColorTable((eButtonColor)3);
		((Control)btntemp).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj9 = btntemp;
		location = new Point(474, 249);
		((Control)obj9).set_Location(location);
		((Control)btntemp).set_Name("btntemp");
		ButtonX obj10 = btntemp;
		size = new Size(150, 31);
		((Control)obj10).set_Size(size);
		((PopupItemControl)btntemp).set_Style((eDotNetBarStyle)7);
		((Control)btntemp).set_TabIndex(2);
		btntemp.set_Text("继续编辑当前列");
		((Control)btnsaveopt).set_AccessibleRole((AccessibleRole)43);
		btnsaveopt.set_ColorTable((eButtonColor)3);
		((Control)btnsaveopt).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj11 = btnsaveopt;
		location = new Point(474, 286);
		((Control)obj11).set_Location(location);
		((Control)btnsaveopt).set_Name("btnsaveopt");
		ButtonX obj12 = btnsaveopt;
		size = new Size(150, 31);
		((Control)obj12).set_Size(size);
		((PopupItemControl)btnsaveopt).set_Style((eDotNetBarStyle)7);
		((Control)btnsaveopt).set_TabIndex(2);
		btnsaveopt.set_Text("替换当前参数列");
		((Control)btngb).set_AccessibleRole((AccessibleRole)43);
		btngb.set_ColorTable((eButtonColor)3);
		btngb.set_DialogResult((DialogResult)2);
		((Control)btngb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj13 = btngb;
		location = new Point(474, 323);
		((Control)obj13).set_Location(location);
		((Control)btngb).set_Name("btngb");
		ButtonX obj14 = btngb;
		size = new Size(150, 31);
		((Control)obj14).set_Size(size);
		((PopupItemControl)btngb).set_Style((eDotNetBarStyle)7);
		((Control)btngb).set_TabIndex(2);
		btngb.set_Text("关闭窗口");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btngb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(630, 365);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)btngb);
		((Control)this).get_Controls().Add((Control)(object)btnsaveopt);
		((Control)this).get_Controls().Add((Control)(object)btntemp);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel4);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel2);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel3);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("xn");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("请指定当前参数值来源ID");
		((Control)GroupPanel1).ResumeLayout(false);
		((Control)GroupPanel2).ResumeLayout(false);
		((Control)GroupPanel3).ResumeLayout(false);
		((Control)GroupPanel4).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void xn_Load(object sender, EventArgs e)
	{
		lbzb.get_Items().Clear();
		lbfb.get_Items().Clear();
		lbtb.get_Items().Clear();
		lbcq.get_Items().Clear();
		lisID("主臂", lbzb);
		lisID("副臂", lbfb);
		lisID("塔臂", lbtb);
		lisID("超起", lbcq);
		lbzb.set_SelectedIndex(0);
		lbfb.set_SelectedIndex(0);
		lbtb.set_SelectedIndex(0);
		lbcq.set_SelectedIndex(0);
	}

	private void lisID(string whichi, ListBox whichlb)
	{
		Mod1.excelsheet = (Worksheet)Mod1.wb.Worksheets[whichi];
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
			while (enumerator.MoveNext())
			{
				Excel.Range range = (Excel.Range)enumerator.Current;
				string text = Conversions.ToString(range.get_Value((object)Missing.Value));
				if (Operators.CompareString(Strings.Trim(text), "", false) == 0)
				{
					break;
				}
				if ((Strings.InStr(1, text, "ID", (CompareMethod)0) > 1) & (Strings.InStr(1, text, "temp", (CompareMethod)0) < 1))
				{
					whichlb.get_Items().Add((object)text);
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

	private void lisIDreplace(string whichi, string whichID)
	{
		int count = Mod1.wb.Worksheets.Count;
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			int column = default(int);
			IEnumerator enumerator2 = default(IEnumerator);
			int column2 = default(int);
			for (int i = 1; i <= count; i++)
			{
				Mod1.excelsheet = (Worksheet)Mod1.wb.Worksheets.get_Item((object)i);
				MyProject.Forms.jinduclxd.PBZ.set_Maximum(Mod1.wb.Worksheets.Count);
				MyProject.Forms.jinduclxd.PBZ.set_Value(i);
				if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Mod1.wb.Worksheets.get_Item((object)i), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)whichi, false))
				{
					continue;
				}
				Excel.Range range;
				try
				{
					enumerator = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
					while (enumerator.MoveNext())
					{
						range = (Excel.Range)enumerator.Current;
						string text = Conversions.ToString(range.get_Value((object)Missing.Value));
						if (Operators.CompareString(Strings.UCase(Strings.Trim(text)), Strings.UCase(Strings.Trim(whichID)), false) == 0)
						{
							column = range.Column;
							break;
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
				string[] array = Strings.Split(whichID, "_", -1, (CompareMethod)0);
				try
				{
					enumerator2 = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						range = (Excel.Range)enumerator2.Current;
						string text = Conversions.ToString(range.get_Value((object)Missing.Value));
						if (Operators.CompareString(Strings.UCase(Strings.Trim(text)), Strings.UCase(Strings.Trim(array[1])), false) == 0)
						{
							column2 = range.Column;
							break;
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				if (!unchecked(column > 4 && column < 200))
				{
					continue;
				}
				range = (Excel.Range)Mod1.excelsheet.Cells[Mod1.excelsheet.Cells.Rows.Count, column];
				int row = range.get_End(XlDirection.xlUp).Row;
				range = (Excel.Range)Mod1.excelsheet.Cells[Mod1.excelsheet.Cells.Rows.Count, 8];
				int row2 = range.get_End(XlDirection.xlUp).Row;
				MyProject.Forms.jinduclxd.PBD.set_Maximum(row);
				range = (Excel.Range)Mod1.excelsheet.Cells[Mod1.excelsheet.Cells.Columns.Count, column];
				_ = range.get_End(XlDirection.xlUp).Column;
				int num = row2;
				for (int j = 2; j <= num; j++)
				{
					NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[j, 3], (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[j, 7], (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[j, 8], (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null, false, true);
				}
				int num2 = row;
				for (int k = 2; k <= num2; k++)
				{
					if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[k, column], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0)
					{
						NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[k, 3], (Type)null, "value", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[k, column2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[k, 7], (Type)null, "value", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[k, column2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[k, 8], (Type)null, "value", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
						MyProject.Forms.jinduclxd.PBD.set_Value(k);
						MyProject.Forms.jinduclxd.xx.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"当前工作表：", NewLateBinding.LateGet(Mod1.wb.Worksheets.get_Item((object)i), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" "), (object)"替换的数值："), NewLateBinding.LateGet(Mod1.excelsheet.Cells[k, column2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
						((Control)MyProject.Forms.jinduclxd).Refresh();
					}
				}
			}
		}
	}

	private void btngb_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btntemp_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Mod1.str1 = "";
		((Form)MyProject.Forms.cslr2).ShowDialog();
	}

	private void btnsaveopt_Click(object sender, EventArgs e)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		((Component)(object)MyProject.Forms.cslr2).Dispose();
		((Control)MyProject.Forms.jinduclxd).Show();
		((Control)MyProject.Forms.jinduclxd).Refresh();
		lisIDreplace("主臂", lbzb.get_Text());
		lisIDreplace("副臂", lbfb.get_Text());
		lisIDreplace("塔臂", lbtb.get_Text());
		lisIDreplace("超起", lbcq.get_Text());
		((Component)(object)MyProject.Forms.jinduclxd).Dispose();
		Mod1.str1 = "";
		((Form)MyProject.Forms.cslr2).ShowDialog();
		((Component)(object)MyProject.Forms.cslr2).Dispose();
	}
}
