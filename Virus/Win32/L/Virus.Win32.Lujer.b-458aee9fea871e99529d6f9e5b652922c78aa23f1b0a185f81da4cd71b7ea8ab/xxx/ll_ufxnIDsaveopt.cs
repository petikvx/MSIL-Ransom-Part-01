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
public class ll_ufxnIDsaveopt : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_frmcqID")]
	private GroupPanel _ll_frmcqID;

	[AccessedThroughProperty("ll_lbcqID")]
	private ListBox _ll_lbcqID;

	[AccessedThroughProperty("ll_frmfbID")]
	private GroupPanel _ll_frmfbID;

	[AccessedThroughProperty("ll_lbfbID")]
	private ListBox _ll_lbfbID;

	[AccessedThroughProperty("ll_frmtbID")]
	private GroupPanel _ll_frmtbID;

	[AccessedThroughProperty("ll_lbtbID")]
	private ListBox _ll_lbtbID;

	[AccessedThroughProperty("ll_frmzbID")]
	private GroupPanel _ll_frmzbID;

	[AccessedThroughProperty("ll_lbzbID")]
	private ListBox _ll_lbzbID;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ll_btnlookzb")]
	private ButtonX _ll_btnlookzb;

	[AccessedThroughProperty("ll_btnlookfb")]
	private ButtonX _ll_btnlookfb;

	[AccessedThroughProperty("ll_btnlooktb")]
	private ButtonX _ll_btnlooktb;

	[AccessedThroughProperty("ll_btnlookcq")]
	private ButtonX _ll_btnlookcq;

	[AccessedThroughProperty("ll_btnsaveopt")]
	private ButtonX _ll_btnsaveopt;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	internal virtual GroupPanel ll_frmcqID
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_frmcqID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_frmcqID = value;
		}
	}

	internal virtual ListBox ll_lbcqID
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbcqID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbcqID = value;
		}
	}

	internal virtual GroupPanel ll_frmfbID
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_frmfbID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_frmfbID = value;
		}
	}

	internal virtual ListBox ll_lbfbID
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbfbID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbfbID = value;
		}
	}

	internal virtual GroupPanel ll_frmtbID
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_frmtbID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_frmtbID = value;
		}
	}

	internal virtual ListBox ll_lbtbID
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbtbID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbtbID = value;
		}
	}

	internal virtual GroupPanel ll_frmzbID
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_frmzbID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_frmzbID = value;
		}
	}

	internal virtual ListBox ll_lbzbID
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbzbID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbzbID = value;
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

	internal virtual ButtonX ll_btnlookzb
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnlookzb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnlookzb_Click;
			if (_ll_btnlookzb != null)
			{
				((Control)_ll_btnlookzb).remove_Click(eventHandler);
			}
			_ll_btnlookzb = value;
			if (_ll_btnlookzb != null)
			{
				((Control)_ll_btnlookzb).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnlookfb
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnlookfb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnlookfb_Click;
			if (_ll_btnlookfb != null)
			{
				((Control)_ll_btnlookfb).remove_Click(eventHandler);
			}
			_ll_btnlookfb = value;
			if (_ll_btnlookfb != null)
			{
				((Control)_ll_btnlookfb).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnlooktb
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnlooktb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnlookfb_Click;
			if (_ll_btnlooktb != null)
			{
				((Control)_ll_btnlooktb).remove_Click(eventHandler);
			}
			_ll_btnlooktb = value;
			if (_ll_btnlooktb != null)
			{
				((Control)_ll_btnlooktb).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnlookcq
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnlookcq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnlookcq_Click;
			if (_ll_btnlookcq != null)
			{
				((Control)_ll_btnlookcq).remove_Click(eventHandler);
			}
			_ll_btnlookcq = value;
			if (_ll_btnlookcq != null)
			{
				((Control)_ll_btnlookcq).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnsaveopt
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnsaveopt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnsaveopt_Click;
			if (_ll_btnsaveopt != null)
			{
				((Control)_ll_btnsaveopt).remove_Click(eventHandler);
			}
			_ll_btnsaveopt = value;
			if (_ll_btnsaveopt != null)
			{
				((Control)_ll_btnsaveopt).add_Click(eventHandler);
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
	public ll_ufxnIDsaveopt()
	{
		((Form)this).add_Load((EventHandler)ll_ufxnIDsaveopt_Load);
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
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected O, but got Unknown
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected O, but got Unknown
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected O, but got Unknown
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5f: Expected O, but got Unknown
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Expected O, but got Unknown
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Expected O, but got Unknown
		//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d43: Expected O, but got Unknown
		//IL_0de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ded: Expected O, but got Unknown
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e97: Expected O, but got Unknown
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f41: Expected O, but got Unknown
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff7: Expected O, but got Unknown
		//IL_109a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a4: Expected O, but got Unknown
		//IL_1191: Unknown result type (might be due to invalid IL or missing references)
		//IL_119b: Expected O, but got Unknown
		ll_frmcqID = new GroupPanel();
		ll_lbcqID = new ListBox();
		ll_frmfbID = new GroupPanel();
		ll_lbfbID = new ListBox();
		ll_frmtbID = new GroupPanel();
		ll_lbtbID = new ListBox();
		ll_frmzbID = new GroupPanel();
		ll_lbzbID = new ListBox();
		LabelX1 = new LabelX();
		ll_btnlookzb = new ButtonX();
		ll_btnlookfb = new ButtonX();
		ll_btnlooktb = new ButtonX();
		ll_btnlookcq = new ButtonX();
		ll_btnsaveopt = new ButtonX();
		ll_btnexit = new ButtonX();
		((Control)ll_frmcqID).SuspendLayout();
		((Control)ll_frmfbID).SuspendLayout();
		((Control)ll_frmtbID).SuspendLayout();
		((Control)ll_frmzbID).SuspendLayout();
		((Control)this).SuspendLayout();
		((PanelControl)ll_frmcqID).set_CanvasColor(SystemColors.Control);
		((PanelControl)ll_frmcqID).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)ll_frmcqID).get_Controls().Add((Control)(object)ll_lbcqID);
		((Control)ll_frmcqID).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		GroupPanel obj = ll_frmcqID;
		Point location = new Point(475, 4);
		((Control)obj).set_Location(location);
		((Control)ll_frmcqID).set_Name("ll_frmcqID");
		GroupPanel obj2 = ll_frmcqID;
		Size size = new Size(150, 238);
		((Control)obj2).set_Size(size);
		((PanelControl)ll_frmcqID).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)ll_frmcqID).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)ll_frmcqID).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)ll_frmcqID).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)ll_frmcqID).get_Style().set_BorderBottomWidth(1);
		((PanelControl)ll_frmcqID).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)ll_frmcqID).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)ll_frmcqID).get_Style().set_BorderLeftWidth(1);
		((PanelControl)ll_frmcqID).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)ll_frmcqID).get_Style().set_BorderRightWidth(1);
		((PanelControl)ll_frmcqID).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)ll_frmcqID).get_Style().set_BorderTopWidth(1);
		((PanelControl)ll_frmcqID).get_Style().set_Class("");
		((PanelControl)ll_frmcqID).get_Style().set_CornerDiameter(4);
		((PanelControl)ll_frmcqID).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)ll_frmcqID).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)ll_frmcqID).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)ll_frmcqID).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)ll_frmcqID).get_StyleMouseDown().set_Class("");
		((PanelControl)ll_frmcqID).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)ll_frmcqID).get_StyleMouseOver().set_Class("");
		((PanelControl)ll_frmcqID).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)ll_frmcqID).set_TabIndex(3);
		((PanelControl)ll_frmcqID).set_Text("超起");
		ll_lbcqID.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ll_lbcqID.set_ItemHeight(12);
		ListBox obj3 = ll_lbcqID;
		location = new Point(3, 3);
		((Control)obj3).set_Location(location);
		((Control)ll_lbcqID).set_Name("ll_lbcqID");
		ListBox obj4 = ll_lbcqID;
		size = new Size(137, 208);
		((Control)obj4).set_Size(size);
		((Control)ll_lbcqID).set_TabIndex(1);
		((PanelControl)ll_frmfbID).set_CanvasColor(SystemColors.Control);
		((PanelControl)ll_frmfbID).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)ll_frmfbID).get_Controls().Add((Control)(object)ll_lbfbID);
		((Control)ll_frmfbID).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		GroupPanel obj5 = ll_frmfbID;
		location = new Point(165, 4);
		((Control)obj5).set_Location(location);
		((Control)ll_frmfbID).set_Name("ll_frmfbID");
		GroupPanel obj6 = ll_frmfbID;
		size = new Size(149, 238);
		((Control)obj6).set_Size(size);
		((PanelControl)ll_frmfbID).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)ll_frmfbID).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)ll_frmfbID).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)ll_frmfbID).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)ll_frmfbID).get_Style().set_BorderBottomWidth(1);
		((PanelControl)ll_frmfbID).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)ll_frmfbID).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)ll_frmfbID).get_Style().set_BorderLeftWidth(1);
		((PanelControl)ll_frmfbID).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)ll_frmfbID).get_Style().set_BorderRightWidth(1);
		((PanelControl)ll_frmfbID).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)ll_frmfbID).get_Style().set_BorderTopWidth(1);
		((PanelControl)ll_frmfbID).get_Style().set_Class("");
		((PanelControl)ll_frmfbID).get_Style().set_CornerDiameter(4);
		((PanelControl)ll_frmfbID).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)ll_frmfbID).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)ll_frmfbID).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)ll_frmfbID).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)ll_frmfbID).get_StyleMouseDown().set_Class("");
		((PanelControl)ll_frmfbID).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)ll_frmfbID).get_StyleMouseOver().set_Class("");
		((PanelControl)ll_frmfbID).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)ll_frmfbID).set_TabIndex(4);
		((PanelControl)ll_frmfbID).set_Text("副臂");
		ll_lbfbID.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ll_lbfbID.set_ItemHeight(12);
		ListBox obj7 = ll_lbfbID;
		location = new Point(3, 3);
		((Control)obj7).set_Location(location);
		((Control)ll_lbfbID).set_Name("ll_lbfbID");
		ListBox obj8 = ll_lbfbID;
		size = new Size(136, 208);
		((Control)obj8).set_Size(size);
		((Control)ll_lbfbID).set_TabIndex(1);
		((PanelControl)ll_frmtbID).set_CanvasColor(SystemColors.Control);
		((PanelControl)ll_frmtbID).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)ll_frmtbID).get_Controls().Add((Control)(object)ll_lbtbID);
		((Control)ll_frmtbID).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		GroupPanel obj9 = ll_frmtbID;
		location = new Point(320, 4);
		((Control)obj9).set_Location(location);
		((Control)ll_frmtbID).set_Name("ll_frmtbID");
		GroupPanel obj10 = ll_frmtbID;
		size = new Size(149, 238);
		((Control)obj10).set_Size(size);
		((PanelControl)ll_frmtbID).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)ll_frmtbID).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)ll_frmtbID).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)ll_frmtbID).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)ll_frmtbID).get_Style().set_BorderBottomWidth(1);
		((PanelControl)ll_frmtbID).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)ll_frmtbID).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)ll_frmtbID).get_Style().set_BorderLeftWidth(1);
		((PanelControl)ll_frmtbID).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)ll_frmtbID).get_Style().set_BorderRightWidth(1);
		((PanelControl)ll_frmtbID).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)ll_frmtbID).get_Style().set_BorderTopWidth(1);
		((PanelControl)ll_frmtbID).get_Style().set_Class("");
		((PanelControl)ll_frmtbID).get_Style().set_CornerDiameter(4);
		((PanelControl)ll_frmtbID).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)ll_frmtbID).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)ll_frmtbID).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)ll_frmtbID).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)ll_frmtbID).get_StyleMouseDown().set_Class("");
		((PanelControl)ll_frmtbID).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)ll_frmtbID).get_StyleMouseOver().set_Class("");
		((PanelControl)ll_frmtbID).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)ll_frmtbID).set_TabIndex(1);
		((PanelControl)ll_frmtbID).set_Text("塔臂");
		ll_lbtbID.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ll_lbtbID.set_ItemHeight(12);
		ListBox obj11 = ll_lbtbID;
		location = new Point(3, 3);
		((Control)obj11).set_Location(location);
		((Control)ll_lbtbID).set_Name("ll_lbtbID");
		ListBox obj12 = ll_lbtbID;
		size = new Size(136, 208);
		((Control)obj12).set_Size(size);
		((Control)ll_lbtbID).set_TabIndex(1);
		((PanelControl)ll_frmzbID).set_CanvasColor(SystemColors.Control);
		((PanelControl)ll_frmzbID).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)ll_frmzbID).get_Controls().Add((Control)(object)ll_lbzbID);
		((Control)ll_frmzbID).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		GroupPanel obj13 = ll_frmzbID;
		location = new Point(5, 4);
		((Control)obj13).set_Location(location);
		((Control)ll_frmzbID).set_Name("ll_frmzbID");
		GroupPanel obj14 = ll_frmzbID;
		size = new Size(154, 238);
		((Control)obj14).set_Size(size);
		((PanelControl)ll_frmzbID).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)ll_frmzbID).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)ll_frmzbID).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)ll_frmzbID).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)ll_frmzbID).get_Style().set_BorderBottomWidth(1);
		((PanelControl)ll_frmzbID).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)ll_frmzbID).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)ll_frmzbID).get_Style().set_BorderLeftWidth(1);
		((PanelControl)ll_frmzbID).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)ll_frmzbID).get_Style().set_BorderRightWidth(1);
		((PanelControl)ll_frmzbID).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)ll_frmzbID).get_Style().set_BorderTopWidth(1);
		((PanelControl)ll_frmzbID).get_Style().set_Class("");
		((PanelControl)ll_frmzbID).get_Style().set_CornerDiameter(4);
		((PanelControl)ll_frmzbID).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)ll_frmzbID).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)ll_frmzbID).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)ll_frmzbID).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)ll_frmzbID).get_StyleMouseDown().set_Class("");
		((PanelControl)ll_frmzbID).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)ll_frmzbID).get_StyleMouseOver().set_Class("");
		((PanelControl)ll_frmzbID).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)ll_frmzbID).set_TabIndex(2);
		((PanelControl)ll_frmzbID).set_Text("主臂");
		ll_lbzbID.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ll_lbzbID.set_ItemHeight(12);
		ListBox obj15 = ll_lbzbID;
		location = new Point(5, 3);
		((Control)obj15).set_Location(location);
		((Control)ll_lbzbID).set_Name("ll_lbzbID");
		ListBox obj16 = ll_lbzbID;
		size = new Size(136, 208);
		((Control)obj16).set_Size(size);
		((Control)ll_lbzbID).set_TabIndex(1);
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		location = new Point(6, 277);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(301, 55);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(5);
		LabelX1.set_Text("说明:\r\n[1] new 列存放的是为当前参数文件中已保存的参数; \r\n[2] temp 列存放的是当前正在编辑的参数;\r\n[3] 300/400/500/.. . 为库中存放的产品参数.");
		((Control)ll_btnlookzb).set_AccessibleRole((AccessibleRole)43);
		ll_btnlookzb.set_ColorTable((eButtonColor)3);
		((Control)ll_btnlookzb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj17 = ll_btnlookzb;
		location = new Point(13, 248);
		((Control)obj17).set_Location(location);
		((Control)ll_btnlookzb).set_Name("ll_btnlookzb");
		ButtonX obj18 = ll_btnlookzb;
		size = new Size(136, 23);
		((Control)obj18).set_Size(size);
		((PopupItemControl)ll_btnlookzb).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnlookzb).set_TabIndex(6);
		ll_btnlookzb.set_Text("查看主臂参数");
		((Control)ll_btnlookfb).set_AccessibleRole((AccessibleRole)43);
		ll_btnlookfb.set_ColorTable((eButtonColor)3);
		((Control)ll_btnlookfb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj19 = ll_btnlookfb;
		location = new Point(171, 248);
		((Control)obj19).set_Location(location);
		((Control)ll_btnlookfb).set_Name("ll_btnlookfb");
		ButtonX obj20 = ll_btnlookfb;
		size = new Size(136, 23);
		((Control)obj20).set_Size(size);
		((PopupItemControl)ll_btnlookfb).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnlookfb).set_TabIndex(6);
		ll_btnlookfb.set_Text("查看副臂参数");
		((Control)ll_btnlooktb).set_AccessibleRole((AccessibleRole)43);
		ll_btnlooktb.set_ColorTable((eButtonColor)3);
		((Control)ll_btnlooktb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj21 = ll_btnlooktb;
		location = new Point(326, 248);
		((Control)obj21).set_Location(location);
		((Control)ll_btnlooktb).set_Name("ll_btnlooktb");
		ButtonX obj22 = ll_btnlooktb;
		size = new Size(136, 23);
		((Control)obj22).set_Size(size);
		((PopupItemControl)ll_btnlooktb).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnlooktb).set_TabIndex(6);
		ll_btnlooktb.set_Text("查看塔臂参数");
		((Control)ll_btnlookcq).set_AccessibleRole((AccessibleRole)43);
		ll_btnlookcq.set_ColorTable((eButtonColor)3);
		((Control)ll_btnlookcq).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj23 = ll_btnlookcq;
		location = new Point(481, 248);
		((Control)obj23).set_Location(location);
		((Control)ll_btnlookcq).set_Name("ll_btnlookcq");
		ButtonX obj24 = ll_btnlookcq;
		size = new Size(137, 23);
		((Control)obj24).set_Size(size);
		((PopupItemControl)ll_btnlookcq).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnlookcq).set_TabIndex(6);
		ll_btnlookcq.set_Text("查看超起参数");
		((Control)ll_btnsaveopt).set_AccessibleRole((AccessibleRole)43);
		ll_btnsaveopt.set_ColorTable((eButtonColor)3);
		((Control)ll_btnsaveopt).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj25 = ll_btnsaveopt;
		location = new Point(326, 300);
		((Control)obj25).set_Location(location);
		((Control)ll_btnsaveopt).set_Name("ll_btnsaveopt");
		ButtonX obj26 = ll_btnsaveopt;
		size = new Size(136, 23);
		((Control)obj26).set_Size(size);
		((PopupItemControl)ll_btnsaveopt).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnsaveopt).set_TabIndex(6);
		ll_btnsaveopt.set_Text("生成参数文本");
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ll_btnexit.set_DialogResult((DialogResult)2);
		((Control)ll_btnexit).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj27 = ll_btnexit;
		location = new Point(482, 300);
		((Control)obj27).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj28 = ll_btnexit;
		size = new Size(136, 23);
		((Control)obj28).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(6);
		ll_btnexit.set_Text("关闭");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_AutoValidate((AutoValidate)0);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(630, 339);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_btnsaveopt);
		((Control)this).get_Controls().Add((Control)(object)ll_btnlookcq);
		((Control)this).get_Controls().Add((Control)(object)ll_btnlooktb);
		((Control)this).get_Controls().Add((Control)(object)ll_btnlookfb);
		((Control)this).get_Controls().Add((Control)(object)ll_btnlookzb);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)ll_frmcqID);
		((Control)this).get_Controls().Add((Control)(object)ll_frmfbID);
		((Control)this).get_Controls().Add((Control)(object)ll_frmtbID);
		((Control)this).get_Controls().Add((Control)(object)ll_frmzbID);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufxnIDsaveopt");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("性能计算ID选项");
		((Control)ll_frmcqID).ResumeLayout(false);
		((Control)ll_frmfbID).ResumeLayout(false);
		((Control)ll_frmtbID).ResumeLayout(false);
		((Control)ll_frmzbID).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void ll_ufxnIDsaveopt_Load(object sender, EventArgs e)
	{
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		ll_lbzbID.get_Items().Clear();
		ll_lbfbID.get_Items().Clear();
		ll_lbtbID.get_Items().Clear();
		ll_lbcqID.get_Items().Clear();
		((Control)ll_frmzbID).set_Enabled(false);
		((Control)ll_frmfbID).set_Enabled(false);
		((Control)ll_frmtbID).set_Enabled(false);
		((Control)ll_frmcqID).set_Enabled(false);
		((Control)ll_btnlookzb).set_Enabled(false);
		((Control)ll_btnlookfb).set_Enabled(false);
		((Control)ll_btnlooktb).set_Enabled(false);
		((Control)ll_btnlookcq).set_Enabled(false);
		lisID("主臂", ll_lbzbID);
		lisID("副臂", ll_lbfbID);
		lisID("塔臂", ll_lbtbID);
		lisID("超起", ll_lbcqID);
		ll_lbzbID.set_SelectedIndex(1);
		ll_lbfbID.set_SelectedIndex(1);
		ll_lbtbID.set_SelectedIndex(1);
		ll_lbcqID.set_SelectedIndex(1);
		switch (Strings.LCase(Mod1.curxnpartname))
		{
		case "zb":
			((Control)ll_frmzbID).set_Enabled(true);
			((Control)ll_btnlookzb).set_Enabled(true);
			break;
		case "fb":
			((Control)ll_frmzbID).set_Enabled(true);
			((Control)ll_frmfbID).set_Enabled(true);
			((Control)ll_btnlookzb).set_Enabled(true);
			((Control)ll_btnlookfb).set_Enabled(true);
			break;
		case "tb":
			((Control)ll_frmzbID).set_Enabled(true);
			((Control)ll_frmtbID).set_Enabled(true);
			((Control)ll_btnlookzb).set_Enabled(true);
			((Control)ll_btnlooktb).set_Enabled(true);
			break;
		case "cqzb":
			((Control)ll_frmzbID).set_Enabled(true);
			((Control)ll_frmcqID).set_Enabled(true);
			((Control)ll_btnlookzb).set_Enabled(true);
			((Control)ll_btnlookcq).set_Enabled(true);
			break;
		case "cqfb":
			((Control)ll_frmzbID).set_Enabled(true);
			((Control)ll_frmfbID).set_Enabled(true);
			((Control)ll_frmcqID).set_Enabled(true);
			((Control)ll_btnlookzb).set_Enabled(true);
			((Control)ll_btnlookfb).set_Enabled(true);
			((Control)ll_btnlookcq).set_Enabled(true);
			break;
		case "cqtb":
			((Control)ll_frmzbID).set_Enabled(true);
			((Control)ll_frmtbID).set_Enabled(true);
			((Control)ll_frmcqID).set_Enabled(true);
			((Control)ll_btnlookzb).set_Enabled(true);
			((Control)ll_btnlooktb).set_Enabled(true);
			((Control)ll_btnlookcq).set_Enabled(true);
			break;
		default:
			Interaction.MsgBox((object)("当前性能计算结构不存在. " + Mod1.curxnpartname), (MsgBoxStyle)0, (object)null);
			break;
		}
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
				if (Strings.InStr(1, text, "ID", (CompareMethod)0) > 1)
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

	private void lisIDsave(string whichi, string whichID, string whichiname)
	{
		string[] array = new string[6]
		{
			Mod1.path1,
			"\\xn\\",
			null,
			null,
			null,
			null
		};
		string[] array2 = array;
		ListBox lbsl = MyProject.Forms.clxd.lbsl;
		string text = lbsl.get_Text();
		string text2 = Mod1.toen(ref text);
		lbsl.set_Text(text);
		array2[2] = text2;
		array[3] = "\\source\\mac\\varinfo_";
		array[4] = whichiname;
		array[5] = ".mac";
		Mod1.curtxtfname = string.Concat(array);
		Mod1.wr = new StreamWriter(Mod1.curtxtfname, append: false, Encoding.Default);
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
						string text3 = Conversions.ToString(range.get_Value((object)Missing.Value));
						if (Operators.CompareString(Strings.UCase(Strings.Trim(text3)), Strings.UCase(Strings.Trim(whichID)), false) == 0)
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
				string[] array3 = Strings.Split(whichID, "_", -1, (CompareMethod)0);
				try
				{
					enumerator2 = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						range = (Excel.Range)enumerator2.Current;
						string text3 = Conversions.ToString(range.get_Value((object)Missing.Value));
						if (Operators.CompareString(Strings.UCase(Strings.Trim(text3)), Strings.UCase(Strings.Trim(array3[1])), false) == 0)
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
				range = (Excel.Range)Mod1.excelsheet.Cells[1, Mod1.excelsheet.Cells.Columns.Count];
				int column3 = range.get_End(XlDirection.xlToLeft).Column;
				MyProject.Forms.jinduclxd.PBD.set_Maximum(row);
				int num = row;
				for (int j = 2; j <= num; j++)
				{
					if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, column], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0 && ((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0) & (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, column2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)))
					{
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, column3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)
						{
							Mod1.wr.WriteLine(Strings.Trim(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Replace("\t", " ")) + "=" + Strings.Trim(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, column2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Replace("\t", " ")) + "!" + Strings.Trim(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, column3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Replace("\t", " ")));
						}
						else
						{
							Mod1.wr.WriteLine(Strings.Trim(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Replace("\t", " ")) + "=" + Strings.Trim(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, column2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Replace("\t", " ")) + "!");
						}
						MyProject.Forms.jinduclxd.PBD.set_Value(j);
						MyProject.Forms.jinduclxd.xx.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"当前工作表：", NewLateBinding.LateGet(Mod1.wb.Sheets.get_Item((object)i), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" "), (object)"参数名称："), (object)Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, column2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))))));
						((Control)MyProject.Forms.jinduclxd).Refresh();
					}
				}
			}
			Mod1.wr.Close();
			Mod1.wr.Dispose();
			string text4 = "【生成参数文本】--已更新当前参数信息文件. " + whichi + " " + whichID;
			MyProject.Forms.clxd.lblog.get_Items().Add((object)text4);
			text4 = "所在路径(双击路径浏览文件):";
			MyProject.Forms.clxd.lblog.get_Items().Add((object)text4);
			MyProject.Forms.clxd.lblog.get_Items().Add((object)Mod1.curtxtfname);
			MyProject.Forms.clxd.lblog.set_SelectedIndex(MyProject.Forms.clxd.lblog.get_Items().get_Count() - 1);
		}
	}

	private void ll_btnexit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ll_btnlookzb_Click(object sender, EventArgs e)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		string path = Mod1.path1;
		ListBox lbsl = MyProject.Forms.clxd.lbsl;
		string text = lbsl.get_Text();
		string text2 = Mod1.toen(ref text);
		lbsl.set_Text(text);
		Mod1.curtxtfname = path + "\\xn\\" + text2 + "\\source\\mac\\varinfo_zb.mac";
		if (File.Exists(Mod1.curtxtfname))
		{
			((Form)MyProject.Forms.ll_ufshowtxtinfo).ShowDialog();
			((Component)(object)MyProject.Forms.ll_ufshowtxtinfo).Dispose();
		}
	}

	private void ll_btnlookfb_Click(object sender, EventArgs e)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		string path = Mod1.path1;
		ListBox lbsl = MyProject.Forms.clxd.lbsl;
		string text = lbsl.get_Text();
		string text2 = Mod1.toen(ref text);
		lbsl.set_Text(text);
		Mod1.curtxtfname = path + "\\xn\\" + text2 + "\\source\\mac\\varinfo_fb.mac";
		if (File.Exists(Mod1.curtxtfname))
		{
			((Form)MyProject.Forms.ll_ufshowtxtinfo).ShowDialog();
			((Component)(object)MyProject.Forms.ll_ufshowtxtinfo).Dispose();
		}
	}

	private void ll_btnlookcq_Click(object sender, EventArgs e)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		string path = Mod1.path1;
		ListBox lbsl = MyProject.Forms.clxd.lbsl;
		string text = lbsl.get_Text();
		string text2 = Mod1.toen(ref text);
		lbsl.set_Text(text);
		Mod1.curtxtfname = path + "\\xn\\" + text2 + "\\source\\mac\\varinfo_cq.mac";
		if (File.Exists(Mod1.curtxtfname))
		{
			((Form)MyProject.Forms.ll_ufshowtxtinfo).ShowDialog();
			((Component)(object)MyProject.Forms.ll_ufshowtxtinfo).Dispose();
		}
	}

	private void ll_btnsaveopt_Click(object sender, EventArgs e)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		string text = "在相应mac文件夹下,生成了参数文本:";
		((Control)MyProject.Forms.jinduclxd).Show();
		((Control)MyProject.Forms.jinduclxd).Refresh();
		if (((Control)ll_frmzbID).get_Enabled())
		{
			lisIDsave("主臂", ll_lbzbID.get_Text(), "zb");
			text += " varinfo_zb.mac";
		}
		if (((Control)ll_frmfbID).get_Enabled())
		{
			lisIDsave("副臂", ll_lbfbID.get_Text(), "fb");
			text += " varinfo_fb.mac";
		}
		if (((Control)ll_frmtbID).get_Enabled())
		{
			lisIDsave("塔臂", ll_lbtbID.get_Text(), "fb");
			text += " varinfo_fb.mac";
		}
		if (((Control)ll_frmcqID).get_Enabled())
		{
			lisIDsave("超起", ll_lbcqID.get_Text(), "cq");
			text += " varinfo_cq.mac";
		}
		((Component)(object)MyProject.Forms.jinduclxd).Dispose();
		Interaction.MsgBox((object)text, (MsgBoxStyle)64, (object)"提示");
	}
}
