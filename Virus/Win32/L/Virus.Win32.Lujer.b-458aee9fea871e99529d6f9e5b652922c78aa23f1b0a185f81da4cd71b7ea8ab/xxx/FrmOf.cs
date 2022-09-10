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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using pfcls;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class FrmOf : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("GroupPanel1")]
	private GroupPanel _GroupPanel1;

	[AccessedThroughProperty("lbslwj")]
	private ListBox _lbslwj;

	[AccessedThroughProperty("lbjslx")]
	private ListBox _lbjslx;

	[AccessedThroughProperty("btnscsl")]
	private ButtonX _btnscsl;

	[AccessedThroughProperty("btndk")]
	private ButtonX _btndk;

	[AccessedThroughProperty("lbcswj")]
	private ListBox _lbcswj;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("lbmxtp")]
	private ListBox _lbmxtp;

	[AccessedThroughProperty("btnlldqwjj")]
	private ButtonX _btnlldqwjj;

	[AccessedThroughProperty("btnljproe")]
	private ButtonX _btnljproe;

	[AccessedThroughProperty("btnlldqproewj")]
	private ButtonX _btnlldqproewj;

	[AccessedThroughProperty("btngb")]
	private ButtonX _btngb;

	[AccessedThroughProperty("ButtonX4")]
	private ButtonX _ButtonX4;

	[AccessedThroughProperty("cmcsh")]
	private ComboBoxEx _cmcsh;

	[AccessedThroughProperty("cmbj")]
	private ComboBoxEx _cmbj;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("LabelX7")]
	private LabelX _LabelX7;

	[AccessedThroughProperty("LabelX6")]
	private LabelX _LabelX6;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("lbmxsm")]
	private LabelX _lbmxsm;

	[AccessedThroughProperty("LabelX8")]
	private LabelX _LabelX8;

	[AccessedThroughProperty("TM1")]
	private Timer _TM1;

	private string path;

	private string[] nn;

	private object list1;

	private string[] filename;

	private string bj;

	private string csh;

	private string jslx;

	private string slwj;

	public string qyx;

	public bool asm;

	public bool prt;

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

	internal virtual ListBox lbslwj
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbslwj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbslwj_SelectedIndexChanged;
			if (_lbslwj != null)
			{
				_lbslwj.remove_SelectedIndexChanged(eventHandler);
			}
			_lbslwj = value;
			if (_lbslwj != null)
			{
				_lbslwj.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox lbjslx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbjslx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbjslx_SelectedIndexChanged;
			if (_lbjslx != null)
			{
				_lbjslx.remove_SelectedIndexChanged(eventHandler);
			}
			_lbjslx = value;
			if (_lbjslx != null)
			{
				_lbjslx.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnscsl
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnscsl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnscsl_Click;
			if (_btnscsl != null)
			{
				((Control)_btnscsl).remove_Click(eventHandler);
			}
			_btnscsl = value;
			if (_btnscsl != null)
			{
				((Control)_btnscsl).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btndk
	{
		[DebuggerNonUserCode]
		get
		{
			return _btndk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btndk_Click;
			if (_btndk != null)
			{
				((Control)_btndk).remove_Click(eventHandler);
			}
			_btndk = value;
			if (_btndk != null)
			{
				((Control)_btndk).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox lbcswj
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbcswj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbcswj_DoubleClick;
			EventHandler eventHandler2 = lbcswj_SelectedIndexChanged;
			if (_lbcswj != null)
			{
				((Control)_lbcswj).remove_DoubleClick(eventHandler);
				_lbcswj.remove_SelectedIndexChanged(eventHandler2);
			}
			_lbcswj = value;
			if (_lbcswj != null)
			{
				((Control)_lbcswj).add_DoubleClick(eventHandler);
				_lbcswj.add_SelectedIndexChanged(eventHandler2);
			}
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox lbmxtp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbmxtp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbmxtp_SelectedIndexChanged;
			EventHandler eventHandler2 = lbmxtp_SelectedIndexChanged;
			if (_lbmxtp != null)
			{
				_lbmxtp.remove_SelectedIndexChanged(eventHandler);
				_lbmxtp.remove_Click(eventHandler2);
			}
			_lbmxtp = value;
			if (_lbmxtp != null)
			{
				_lbmxtp.add_SelectedIndexChanged(eventHandler);
				_lbmxtp.add_Click(eventHandler2);
			}
		}
	}

	internal virtual ButtonX btnlldqwjj
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnlldqwjj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnlldqwjj_Click;
			if (_btnlldqwjj != null)
			{
				((Control)_btnlldqwjj).remove_Click(eventHandler);
			}
			_btnlldqwjj = value;
			if (_btnlldqwjj != null)
			{
				((Control)_btnlldqwjj).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnljproe
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnljproe;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnljproe_Click;
			if (_btnljproe != null)
			{
				((Control)_btnljproe).remove_Click(eventHandler);
			}
			_btnljproe = value;
			if (_btnljproe != null)
			{
				((Control)_btnljproe).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnlldqproewj
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnlldqproewj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnlldqproewj_Click;
			if (_btnlldqproewj != null)
			{
				((Control)_btnlldqproewj).remove_Click(eventHandler);
			}
			_btnlldqproewj = value;
			if (_btnlldqproewj != null)
			{
				((Control)_btnlldqproewj).add_Click(eventHandler);
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

	internal virtual ButtonX ButtonX4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ButtonX4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ButtonX4 = value;
		}
	}

	public virtual ComboBoxEx cmcsh
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmcsh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmcsh_SelectedIndexChanged;
			if (_cmcsh != null)
			{
				((ComboBox)_cmcsh).remove_SelectedIndexChanged(eventHandler);
			}
			_cmcsh = value;
			if (_cmcsh != null)
			{
				((ComboBox)_cmcsh).add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public virtual ComboBoxEx cmbj
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbj_SelectedIndexChanged;
			if (_cmbj != null)
			{
				((ComboBox)_cmbj).remove_SelectedIndexChanged(eventHandler);
			}
			_cmbj = value;
			if (_cmbj != null)
			{
				((ComboBox)_cmbj).add_SelectedIndexChanged(eventHandler);
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

	internal virtual LabelX lbmxsm
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbmxsm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbmxsm = value;
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

	internal virtual Timer TM1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TM1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TM1_Tick;
			if (_TM1 != null)
			{
				_TM1.remove_Tick(eventHandler);
			}
			_TM1 = value;
			if (_TM1 != null)
			{
				_TM1.add_Tick(eventHandler);
			}
		}
	}

	public FrmOf()
	{
		((Form)this).add_Load((EventHandler)FrmOf_Load);
		path = "";
		list1 = new ArrayList();
		asm = false;
		prt = false;
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
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected O, but got Unknown
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected O, but got Unknown
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected O, but got Unknown
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected O, but got Unknown
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Expected O, but got Unknown
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Expected O, but got Unknown
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Expected O, but got Unknown
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected O, but got Unknown
		//IL_0ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Expected O, but got Unknown
		//IL_0d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d93: Expected O, but got Unknown
		//IL_0e30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3a: Expected O, but got Unknown
		//IL_0ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Expected O, but got Unknown
		//IL_0fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Expected O, but got Unknown
		//IL_10e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ea: Expected O, but got Unknown
		//IL_11a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ae: Expected O, but got Unknown
		//IL_126f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1279: Expected O, but got Unknown
		//IL_130b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1315: Expected O, but got Unknown
		//IL_13e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ed: Expected O, but got Unknown
		components = new Container();
		GroupPanel1 = new GroupPanel();
		lbjslx = new ListBox();
		LabelX8 = new LabelX();
		LabelX6 = new LabelX();
		LabelX4 = new LabelX();
		LabelX3 = new LabelX();
		LabelX2 = new LabelX();
		cmcsh = new ComboBoxEx();
		cmbj = new ComboBoxEx();
		lbslwj = new ListBox();
		btnscsl = new ButtonX();
		btndk = new ButtonX();
		lbcswj = new ListBox();
		PictureBox1 = new PictureBox();
		lbmxtp = new ListBox();
		btnlldqwjj = new ButtonX();
		btnljproe = new ButtonX();
		btnlldqproewj = new ButtonX();
		btngb = new ButtonX();
		ButtonX4 = new ButtonX();
		LabelX1 = new LabelX();
		LabelX7 = new LabelX();
		lbmxsm = new LabelX();
		TM1 = new Timer(components);
		((Control)GroupPanel1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((PanelControl)GroupPanel1).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)lbjslx);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX8);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX6);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX3);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX2);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)cmcsh);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)cmbj);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)lbslwj);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)btnscsl);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)btndk);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)lbcswj);
		GroupPanel groupPanel = GroupPanel1;
		Point location = new Point(4, 5);
		((Control)groupPanel).set_Location(location);
		((Control)GroupPanel1).set_Name("GroupPanel1");
		GroupPanel groupPanel2 = GroupPanel1;
		Size size = new Size(261, 491);
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
		lbjslx.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbjslx).set_FormattingEnabled(true);
		lbjslx.set_ItemHeight(12);
		ListBox obj = lbjslx;
		location = new Point(6, 224);
		((Control)obj).set_Location(location);
		((Control)lbjslx).set_Name("lbjslx");
		ListBox obj2 = lbjslx;
		size = new Size(246, 76);
		((Control)obj2).set_Size(size);
		((Control)lbjslx).set_TabIndex(10);
		((Control)LabelX8).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX8).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX8;
		location = new Point(6, 304);
		((Control)labelX).set_Location(location);
		((Control)LabelX8).set_Name("LabelX8");
		LabelX labelX2 = LabelX8;
		size = new Size(66, 15);
		((Control)labelX2).set_Size(size);
		((Control)LabelX8).set_TabIndex(14);
		LabelX8.set_Text("实例文件");
		((Control)LabelX6).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX6).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX3 = LabelX6;
		location = new Point(6, 202);
		((Control)labelX3).set_Location(location);
		((Control)LabelX6).set_Name("LabelX6");
		LabelX labelX4 = LabelX6;
		size = new Size(66, 18);
		((Control)labelX4).set_Size(size);
		((Control)LabelX6).set_TabIndex(14);
		LabelX6.set_Text("计算类型");
		((Control)LabelX4).set_BackColor(SystemColors.InactiveCaptionText);
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX4).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX5 = LabelX4;
		location = new Point(6, 89);
		((Control)labelX5).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX6 = LabelX4;
		size = new Size(68, 18);
		((Control)labelX6).set_Size(size);
		((Control)LabelX4).set_TabIndex(14);
		LabelX4.set_Text("参数文件");
		((Control)LabelX3).set_BackColor(SystemColors.InactiveCaptionText);
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX3).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX7 = LabelX3;
		location = new Point(5, 45);
		((Control)labelX7).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX8 = LabelX3;
		size = new Size(107, 18);
		((Control)labelX8).set_Size(size);
		((Control)LabelX3).set_TabIndex(14);
		LabelX3.set_Text("参数化库/实例库");
		((Control)LabelX2).set_BackColor(SystemColors.InactiveCaptionText);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX9 = LabelX2;
		location = new Point(6, -1);
		((Control)labelX9).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX10 = LabelX2;
		size = new Size(66, 21);
		((Control)labelX10).set_Size(size);
		((Control)LabelX2).set_TabIndex(14);
		LabelX2.set_Text("部件列表");
		((ListControl)cmcsh).set_DisplayMember("Text");
		((ComboBox)cmcsh).set_DrawMode((DrawMode)1);
		((ComboBox)cmcsh).set_DropDownStyle((ComboBoxStyle)2);
		((Control)cmcsh).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)cmcsh).set_FormattingEnabled(true);
		((ComboBox)cmcsh).set_ItemHeight(15);
		ComboBoxEx obj3 = cmcsh;
		location = new Point(6, 65);
		((Control)obj3).set_Location(location);
		((Control)cmcsh).set_Name("cmcsh");
		ComboBoxEx obj4 = cmcsh;
		size = new Size(246, 21);
		((Control)obj4).set_Size(size);
		cmcsh.set_Style((eDotNetBarStyle)7);
		((Control)cmcsh).set_TabIndex(12);
		((ListControl)cmbj).set_DisplayMember("Text");
		((ComboBox)cmbj).set_DrawMode((DrawMode)1);
		((ComboBox)cmbj).set_DropDownStyle((ComboBoxStyle)2);
		((Control)cmbj).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)cmbj).set_FormattingEnabled(true);
		((ComboBox)cmbj).set_ItemHeight(15);
		ComboBoxEx obj5 = cmbj;
		location = new Point(6, 22);
		((Control)obj5).set_Location(location);
		((Control)cmbj).set_Name("cmbj");
		ComboBoxEx obj6 = cmbj;
		size = new Size(246, 21);
		((Control)obj6).set_Size(size);
		cmbj.set_Style((eDotNetBarStyle)7);
		((Control)cmbj).set_TabIndex(12);
		lbslwj.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbslwj).set_FormattingEnabled(true);
		lbslwj.set_ItemHeight(12);
		ListBox obj7 = lbslwj;
		location = new Point(6, 322);
		((Control)obj7).set_Location(location);
		((Control)lbslwj).set_Name("lbslwj");
		ListBox obj8 = lbslwj;
		size = new Size(246, 124);
		((Control)obj8).set_Size(size);
		((Control)lbslwj).set_TabIndex(11);
		((Control)btnscsl).set_AccessibleRole((AccessibleRole)43);
		btnscsl.set_ColorTable((eButtonColor)3);
		((Control)btnscsl).set_Enabled(false);
		((Control)btnscsl).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj9 = btnscsl;
		location = new Point(6, 449);
		((Control)obj9).set_Location(location);
		((Control)btnscsl).set_Name("btnscsl");
		ButtonX obj10 = btnscsl;
		size = new Size(245, 32);
		((Control)obj10).set_Size(size);
		((PopupItemControl)btnscsl).set_Style((eDotNetBarStyle)7);
		((Control)btnscsl).set_TabIndex(1);
		btnscsl.set_Text("输出当前实例库文件");
		((Control)btndk).set_AccessibleRole((AccessibleRole)43);
		btndk.set_ColorTable((eButtonColor)3);
		((Control)btndk).set_Enabled(false);
		((Control)btndk).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj11 = btndk;
		location = new Point(6, 165);
		((Control)obj11).set_Location(location);
		((Control)btndk).set_Name("btndk");
		ButtonX obj12 = btndk;
		size = new Size(246, 32);
		((Control)obj12).set_Size(size);
		((PopupItemControl)btndk).set_Style((eDotNetBarStyle)7);
		((Control)btndk).set_TabIndex(1);
		btndk.set_Text("打开");
		lbcswj.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbcswj).set_FormattingEnabled(true);
		lbcswj.set_ItemHeight(12);
		ListBox obj13 = lbcswj;
		location = new Point(6, 110);
		((Control)obj13).set_Location(location);
		((Control)lbcswj).set_Name("lbcswj");
		ListBox obj14 = lbcswj;
		size = new Size(246, 52);
		((Control)obj14).set_Size(size);
		((Control)lbcswj).set_TabIndex(6);
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)0);
		PictureBox1.set_BorderStyle((BorderStyle)2);
		PictureBox pictureBox = PictureBox1;
		location = new Point(447, 30);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(396, 340);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)3);
		PictureBox1.set_TabIndex(10);
		PictureBox1.set_TabStop(false);
		lbmxtp.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbmxtp).set_FormattingEnabled(true);
		lbmxtp.set_ItemHeight(12);
		ListBox obj15 = lbmxtp;
		location = new Point(271, 30);
		((Control)obj15).set_Location(location);
		((Control)lbmxtp).set_Name("lbmxtp");
		ListBox obj16 = lbmxtp;
		size = new Size(174, 340);
		((Control)obj16).set_Size(size);
		((Control)lbmxtp).set_TabIndex(11);
		((Control)btnlldqwjj).set_AccessibleRole((AccessibleRole)43);
		btnlldqwjj.set_ColorTable((eButtonColor)3);
		((Control)btnlldqwjj).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj17 = btnlldqwjj;
		location = new Point(273, 388);
		((Control)obj17).set_Location(location);
		((Control)btnlldqwjj).set_Name("btnlldqwjj");
		ButtonX obj18 = btnlldqwjj;
		size = new Size(119, 32);
		((Control)obj18).set_Size(size);
		((PopupItemControl)btnlldqwjj).set_Style((eDotNetBarStyle)7);
		((Control)btnlldqwjj).set_TabIndex(1);
		btnlldqwjj.set_Text("浏览当前库文件夹");
		((Control)btnljproe).set_AccessibleRole((AccessibleRole)43);
		btnljproe.set_ColorTable((eButtonColor)3);
		((Control)btnljproe).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)btnljproe).set_ForeColor(Color.Red);
		ButtonX obj19 = btnljproe;
		location = new Point(422, 388);
		((Control)obj19).set_Location(location);
		((Control)btnljproe).set_Name("btnljproe");
		ButtonX obj20 = btnljproe;
		size = new Size(119, 32);
		((Control)obj20).set_Size(size);
		((PopupItemControl)btnljproe).set_Style((eDotNetBarStyle)7);
		((Control)btnljproe).set_TabIndex(1);
		btnljproe.set_Text("连接至当前PROE...");
		((Control)btnlldqproewj).set_AccessibleRole((AccessibleRole)43);
		btnlldqproewj.set_ColorTable((eButtonColor)3);
		((Control)btnlldqproewj).set_Enabled(false);
		((Control)btnlldqproewj).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj21 = btnlldqproewj;
		location = new Point(571, 388);
		((Control)obj21).set_Location(location);
		((Control)btnlldqproewj).set_Name("btnlldqproewj");
		ButtonX obj22 = btnlldqproewj;
		size = new Size(119, 32);
		((Control)obj22).set_Size(size);
		((PopupItemControl)btnlldqproewj).set_Style((eDotNetBarStyle)7);
		((Control)btnlldqproewj).set_TabIndex(1);
		btnlldqproewj.set_Text("浏览当前PROE文件");
		((Control)btngb).set_AccessibleRole((AccessibleRole)43);
		btngb.set_ColorTable((eButtonColor)3);
		btngb.set_DialogResult((DialogResult)2);
		((Control)btngb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj23 = btngb;
		location = new Point(721, 388);
		((Control)obj23).set_Location(location);
		((Control)btngb).set_Name("btngb");
		ButtonX obj24 = btngb;
		size = new Size(119, 32);
		((Control)obj24).set_Size(size);
		((PopupItemControl)btngb).set_Style((eDotNetBarStyle)7);
		((Control)btngb).set_TabIndex(1);
		btngb.set_Text("关闭(&ESC)");
		((Control)ButtonX4).set_AccessibleRole((AccessibleRole)43);
		ButtonX4.set_ColorTable((eButtonColor)3);
		ButtonX buttonX = ButtonX4;
		location = new Point(273, 388);
		((Control)buttonX).set_Location(location);
		((Control)ButtonX4).set_Name("ButtonX4");
		ButtonX buttonX2 = ButtonX4;
		size = new Size(119, 32);
		((Control)buttonX2).set_Size(size);
		((PopupItemControl)ButtonX4).set_Style((eDotNetBarStyle)7);
		((Control)ButtonX4).set_TabIndex(1);
		ButtonX4.set_Text("浏览当前库文件夹");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX11 = LabelX1;
		location = new Point(271, 5);
		((Control)labelX11).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX12 = LabelX1;
		size = new Size(91, 23);
		((Control)labelX12).set_Size(size);
		((Control)LabelX1).set_TabIndex(14);
		LabelX1.set_Text("模型实例图片");
		((Control)LabelX7).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX7).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX13 = LabelX7;
		location = new Point(271, 426);
		((Control)labelX13).set_Location(location);
		((Control)LabelX7).set_Name("LabelX7");
		LabelX labelX14 = LabelX7;
		size = new Size(246, 15);
		((Control)labelX14).set_Size(size);
		((Control)LabelX7).set_TabIndex(14);
		LabelX7.set_Text("模型说明：");
		((Control)lbmxsm).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)lbmxsm).get_BackgroundStyle().set_Class("");
		((BaseItemControl)lbmxsm).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)lbmxsm).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX obj25 = lbmxsm;
		location = new Point(271, 445);
		((Control)obj25).set_Location(location);
		((Control)lbmxsm).set_Name("lbmxsm");
		LabelX obj26 = lbmxsm;
		size = new Size(564, 62);
		((Control)obj26).set_Size(size);
		((Control)lbmxsm).set_TabIndex(14);
		lbmxsm.set_TextLineAlignment((StringAlignment)0);
		lbmxsm.set_WordWrap(true);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btngb);
		((Office2007Form)this).set_CaptionFont(new Font("Arial", 9f));
		size = new Size(847, 516);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)lbmxsm);
		((Control)this).get_Controls().Add((Control)(object)LabelX7);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)lbmxtp);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel1);
		((Control)this).get_Controls().Add((Control)(object)btngb);
		((Control)this).get_Controls().Add((Control)(object)btnlldqproewj);
		((Control)this).get_Controls().Add((Control)(object)btnljproe);
		((Control)this).get_Controls().Add((Control)(object)btnlldqwjj);
		((Control)this).set_Font(new Font("Arial", 9f));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("FrmOf");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("模型库");
		((Control)GroupPanel1).ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void FrmOf_Load(object sender, EventArgs e)
	{
		((Control)LabelX2).set_BackColor(Color.Transparent);
		((Control)LabelX3).set_BackColor(Color.Transparent);
		((Control)LabelX4).set_BackColor(Color.Transparent);
		((Control)LabelX6).set_BackColor(Color.Transparent);
		((Control)LabelX8).set_BackColor(Color.Transparent);
		((Control)btnljproe).set_ForeColor(Color.Red);
		if (Mod1.asyncConnection != null)
		{
			((Control)btnljproe).set_ForeColor(Color.SeaGreen);
		}
		else
		{
			((Control)btnljproe).set_ForeColor(Color.Red);
		}
		checked
		{
			if (cmbj.get_Items().get_Count() == 0)
			{
				bjlb();
			}
			else if (Operators.CompareString(Strings.Trim(((ComboBox)cmcsh).get_Text()), "实例模型", false) != 0 && ((Operators.CompareString(Mod1.path1, "", false) != 0) & (Operators.CompareString(((ComboBox)cmcsh).get_Text(), "", false) != 0)))
			{
				lbcswj.get_Items().Clear();
				Mod1.file = Directory.GetFiles(Mod1.path1 + "\\cs", "*.xls", SearchOption.AllDirectories);
				int num = Mod1.file.Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					Mod1.list = Mod1.file;
					lbcswj.get_Items().Add((object)Mod1.file[i].Substring(Mod1.file[i].LastIndexOf("\\") + 1));
				}
			}
			Mod1.proetime();
		}
	}

	public void bjlb()
	{
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			path = Mod1.Kulujing;
			if (Operators.CompareString(Strings.Right(path, 1), "\\", false) != 0)
			{
				path += "\\";
			}
			Mod1.path1 = path + "mlibs.lis";
			Mod1.lr = new StreamReader(Mod1.path1, Encoding.Default);
			Mod1.ff = "";
			while (!Information.IsNothing((object)Mod1.ff))
			{
				Mod1.ff = Mod1.lr.ReadLine();
				if (Information.IsNothing((object)Mod1.ff))
				{
					break;
				}
				nn = Mod1.ff.Split(new char[1] { ',' });
				cmbj.get_Items().Add((object)nn[0]);
				object obj = list1;
				object[] array = new object[1];
				string[] array2 = nn;
				int num = 1;
				array[0] = array2[1];
				object[] array3 = array;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj, (Type)null, "Add", array3, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array2[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	private void cmbj_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			csh = "";
			if ((Operators.CompareString(bj, "", false) == 0) | (Operators.CompareString(bj, ((ComboBox)cmbj).get_Text(), false) != 0))
			{
				bj = ((ComboBox)cmbj).get_Text();
				lbcswj.get_Items().Clear();
				lbjslx.get_Items().Clear();
				lbslwj.get_Items().Clear();
				cmcsh.get_Items().Clear();
				lbmxtp.get_Items().Clear();
				((Control)btnscsl).set_Enabled(false);
				lbmxsm.set_Text("");
				jslx = "";
				PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
				if (Operators.CompareString(Strings.Trim(((ComboBox)cmbj).get_Text()), "", false) != 0)
				{
					object obj = list1;
					object[] array = new object[1];
					object[] array2 = array;
					ComboBoxEx val = cmbj;
					array2[0] = ((ComboBox)val).get_SelectedIndex();
					object[] array3 = array;
					object[] array4 = array3;
					bool[] array5 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Item", array4, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						((ComboBox)val).set_SelectedIndex((int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int)));
					}
					qyx = Conversions.ToString(obj2);
					string text = path;
					object obj3 = list1;
					object[] array6 = new object[1];
					ComboBoxEx val2 = cmbj;
					array6[0] = ((ComboBox)val2).get_SelectedIndex();
					object[] array7 = array6;
					bool[] array8 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "Item", array7, (string[])null, (Type[])null, array8);
					if (array8[0])
					{
						((ComboBox)val2).set_SelectedIndex((int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(int)));
					}
					object obj5 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, obj4), (object)"\\");
					object obj6 = list1;
					array3 = new object[1];
					object[] array9 = array3;
					val = cmbj;
					array9[0] = ((ComboBox)val).get_SelectedIndex();
					array = array3;
					object[] array10 = array;
					array5 = new bool[1] { true };
					object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "Item", array10, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						((ComboBox)val).set_SelectedIndex((int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int)));
					}
					Mod1.path1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(obj5, obj7), (object)".lis"));
					Mod1.cshlis = Mod1.path1;
					Mod1.CheckLis(ref Mod1.path1);
					if (!Mod1.bcheckreport)
					{
						return;
					}
					Mod1.lr = new StreamReader(Mod1.path1, Encoding.Default);
					Mod1.ff = "";
					while (!Information.IsNothing((object)Mod1.ff))
					{
						Mod1.ff = Mod1.lr.ReadLine();
						if (Information.IsNothing((object)Mod1.ff))
						{
							break;
						}
						if ((Operators.CompareString(Mod1.ff, "参数化模型", false) == 0) | (Operators.CompareString(Mod1.ff, "实例模型", false) == 0))
						{
							cmcsh.get_Items().Add((object)Mod1.ff);
						}
					}
				}
				Mod1.lr.Close();
				Mod1.lr.Dispose();
				if (Operators.CompareString(Mod1.bjlb1, "", false) == 0)
				{
					Mod1.bjlb1 = ((ComboBox)cmbj).get_Text();
				}
			}
			((Control)btndk).set_Enabled(false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	private void cmcsh_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				slwj = "";
				jslx = "";
				if (!((Operators.CompareString(csh, "", false) == 0) | (Operators.CompareString(csh, ((ComboBox)cmcsh).get_Text(), false) != 0)))
				{
					return;
				}
				csh = ((ComboBox)cmcsh).get_Text();
				lbcswj.get_Items().Clear();
				lbjslx.get_Items().Clear();
				lbslwj.get_Items().Clear();
				lbmxtp.get_Items().Clear();
				PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
				if (Operators.CompareString(Strings.Trim(((ComboBox)cmcsh).get_Text()), "实例模型", false) == 0)
				{
					((Control)btndk).set_Enabled(false);
					((Control)btnscsl).set_Enabled(false);
					if (Mod1.wb != null)
					{
						((BaseItem)MyProject.Forms.Main.Toolsfxxd).set_Enabled(true);
						((BaseItem)MyProject.Forms.Main.ToolsInput).set_Enabled(true);
					}
					else
					{
						((BaseItem)MyProject.Forms.Main.Toolsfxxd).set_Enabled(false);
						((BaseItem)MyProject.Forms.Main.ToolsInput).set_Enabled(false);
					}
					string text = this.path;
					object obj = list1;
					object[] array = new object[1];
					object[] array2 = array;
					ComboBoxEx val = cmbj;
					array2[0] = ((ComboBox)val).get_SelectedIndex();
					object[] array3 = array;
					object[] array4 = array3;
					bool[] array5 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Item", array4, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						((ComboBox)val).set_SelectedIndex((int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int)));
					}
					object obj3 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, obj2), (object)"\\");
					ComboBoxEx val2 = cmcsh;
					string text2 = ((ComboBox)val2).get_Text();
					string text3 = Mod1.toen(ref text2);
					((ComboBox)val2).set_Text(text2);
					Mod1.path1 = Conversions.ToString(Operators.ConcatenateObject(obj3, (object)text3));
					string path = Mod1.path1;
					val = cmcsh;
					text2 = ((ComboBox)val).get_Text();
					string text4 = Mod1.toen(ref text2);
					((ComboBox)val).set_Text(text2);
					Mod1.lr = new StreamReader(path + "\\" + text4 + ".lis", Encoding.Default);
					Mod1.ff = "";
					while (!Information.IsNothing((object)Mod1.ff))
					{
						Mod1.ff = Mod1.lr.ReadLine();
						if (Information.IsNothing((object)Mod1.ff))
						{
							break;
						}
						if (Operators.CompareString(Mod1.toen(ref Mod1.ff), "", false) != 0)
						{
							lbjslx.get_Items().Add((object)Mod1.ff);
						}
					}
					Mod1.lr.Close();
					Mod1.lr.Dispose();
				}
				else
				{
					string text5 = this.path;
					object obj4 = list1;
					object[] array3 = new object[1];
					object[] array6 = array3;
					ComboBoxEx val2 = cmbj;
					array6[0] = ((ComboBox)val2).get_SelectedIndex();
					object[] array = array3;
					object[] array7 = array;
					bool[] array5 = new bool[1] { true };
					object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "Item", array7, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						((ComboBox)val2).set_SelectedIndex((int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int)));
					}
					object obj6 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)text5, obj5), (object)"\\");
					ComboBoxEx val = cmcsh;
					string text2 = ((ComboBox)val).get_Text();
					string text6 = Mod1.toen(ref text2);
					((ComboBox)val).set_Text(text2);
					Mod1.path1 = Conversions.ToString(Operators.ConcatenateObject(obj6, (object)text6));
					Mod1.cshh = Mod1.path1;
					string path2 = Mod1.path1;
					val = cmcsh;
					text2 = ((ComboBox)val).get_Text();
					string text7 = Mod1.toen(ref text2);
					((ComboBox)val).set_Text(text2);
					Mod1.cshlis = path2 + "\\" + text7 + ".lis";
					string path3 = Mod1.path1;
					val = cmcsh;
					text2 = ((ComboBox)val).get_Text();
					string text8 = Mod1.toen(ref text2);
					((ComboBox)val).set_Text(text2);
					Mod1.lr = new StreamReader(path3 + "\\" + text8 + ".lis", Encoding.Default);
					if (Directory.Exists(Mod1.path1 + "\\cs"))
					{
						Mod1.file = Directory.GetFiles(Mod1.path1 + "\\cs", "*.xls", SearchOption.AllDirectories);
						int num = Mod1.file.Count() - 1;
						for (int i = 0; i <= num; i++)
						{
							if (Mod1.file.Length != 0)
							{
								Mod1.list = Mod1.file;
								lbcswj.get_Items().Add((object)Mod1.file[i].Substring(Mod1.file[i].LastIndexOf("\\") + 1));
							}
							else
							{
								Interaction.MsgBox((object)"程序没有找到有效的参数文件xls！", (MsgBoxStyle)64, (object)"提示");
							}
						}
					}
					else
					{
						Interaction.MsgBox((object)("程序没有找到 " + Mod1.path1 + "\\cs 文件夹"), (MsgBoxStyle)64, (object)"提示");
						((Control)btndk).set_Enabled(false);
					}
					Mod1.ff = "";
					while (!Information.IsNothing((object)Mod1.ff))
					{
						Mod1.ff = Mod1.lr.ReadLine();
						if (Information.IsNothing((object)Mod1.ff))
						{
							break;
						}
						if (Operators.CompareString(Mod1.toen(ref Mod1.ff), "", false) != 0)
						{
							lbjslx.get_Items().Add((object)Mod1.ff);
						}
					}
					Mod1.xdpath = Mod1.path1;
				}
				Mod1.lr.Close();
				Mod1.lr.Dispose();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void lbslwj_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if ((Operators.CompareString(slwj, "", false) == 0) | ((Operators.CompareString(slwj, lbslwj.get_Text(), false) != 0) & (Operators.CompareString(Strings.Trim(lbslwj.get_Text()), "", false) != 0)))
				{
					slwj = lbslwj.get_Text();
					((Control)btnlldqproewj).set_Enabled(true);
					lbmxtp.get_Items().Clear();
					PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
					lbmxsm.set_Text("");
					((Control)btnscsl).set_Enabled(true);
					((Control)btnlldqproewj).set_Enabled(true);
					string[] array = new string[5]
					{
						Mod1.path1,
						"\\",
						null,
						null,
						null
					};
					string[] array2 = array;
					ListBox val = lbjslx;
					string text = val.get_Text();
					string text2 = Mod1.toen(ref text);
					val.set_Text(text);
					array2[2] = text2;
					array[3] = "\\";
					array[4] = lbslwj.get_Text();
					Mod1.file1 = Directory.GetFiles(string.Concat(array), "*.jpg", SearchOption.TopDirectoryOnly);
					if (Mod1.file1.Count() != 0)
					{
						PictureBox1.set_ImageLocation(Mod1.file1[0]);
						int num = Mod1.file1.Count() - 1;
						for (int i = 0; i <= num; i++)
						{
							lbmxtp.get_Items().Add((object)Mod1.file1[i].Substring(Mod1.file1[i].LastIndexOf("\\") + 1));
							lbmxtp.set_SelectedIndex(0);
						}
					}
					array = new string[6]
					{
						Mod1.path1,
						"\\",
						null,
						null,
						null,
						null
					};
					string[] array3 = array;
					val = lbjslx;
					text = val.get_Text();
					string text3 = Mod1.toen(ref text);
					val.set_Text(text);
					array3[2] = text3;
					array[3] = "\\";
					array[4] = lbslwj.get_Text();
					array[5] = "\\README.TXT";
					if (File.Exists(string.Concat(array)))
					{
						string[] array4 = new string[6]
						{
							Mod1.path1,
							"\\",
							null,
							null,
							null,
							null
						};
						ListBox val2 = lbjslx;
						string text4 = val2.get_Text();
						string text5 = Mod1.toen(ref text4);
						val2.set_Text(text4);
						array4[2] = text5;
						array4[3] = "\\";
						array4[4] = lbslwj.get_Text();
						array4[5] = "\\README.TXT";
						Mod1.lr = new StreamReader(string.Concat(array4), Encoding.Default);
						lbmxsm.set_Text(Mod1.lr.ReadLine());
						Mod1.lr.Close();
						Mod1.lr.Dispose();
					}
				}
				else
				{
					PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
					((Control)btnscsl).set_Enabled(false);
					if (Operators.CompareString(Strings.Trim(lbslwj.get_Text()), "", false) != 0)
					{
						((Control)btnscsl).set_Enabled(true);
					}
				}
				if (lbmxtp.get_SelectedIndex() != -1)
				{
					PictureBox1.set_ImageLocation(Mod1.file1[lbmxtp.get_SelectedIndex()]);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void lbjslx_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				slwj = "";
				if (!((Operators.CompareString(jslx, "", false) == 0) | (Operators.CompareString(jslx, lbjslx.get_Text(), false) != 0)))
				{
					return;
				}
				lbslwj.get_Items().Clear();
				lbmxtp.get_Items().Clear();
				jslx = lbjslx.get_Text();
				PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
				((Control)btnscsl).set_Enabled(false);
				((Control)btnlldqproewj).set_Enabled(false);
				lbmxsm.set_Text("");
				if (Operators.CompareString(Strings.Trim(lbjslx.get_Text()), "", false) == 0)
				{
					return;
				}
				lbslwj.get_Items().Clear();
				string path = Mod1.path1;
				ListBox val = lbjslx;
				string text = val.get_Text();
				string text2 = Mod1.toen(ref text);
				val.set_Text(text);
				Mod1.file1 = Directory.GetDirectories(path + "\\" + text2);
				int num = Mod1.file1.Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					Mod1.file1[i] = Mod1.file1[i].Substring(Mod1.file1[i].LastIndexOf("\\") + 1);
					if ((Operators.CompareString(Strings.UCase(Mod1.file1[i]), Strings.UCase("cstemp"), false) != 0) & (Operators.CompareString(Strings.UCase(Mod1.file1[i]), Strings.UCase("tempxls"), false) != 0))
					{
						lbslwj.get_Items().Add((object)Mod1.file1[i]);
					}
				}
				if (lbslwj.get_Items().get_Count() != 0)
				{
					if (lbjslx.get_SelectedIndex() < lbslwj.get_Items().get_Count())
					{
						lbslwj.set_SelectedIndex(lbjslx.get_SelectedIndex());
					}
					else
					{
						lbslwj.set_SelectedIndex(0);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void lbmxtp_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (lbmxtp.get_SelectedIndex() != -1)
		{
			Mod1.t = lbmxtp.get_SelectedIndex();
			PictureBox1.set_ImageLocation(Mod1.file1[lbmxtp.get_SelectedIndex()].ToString());
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (lbmxtp.get_Items().get_Count() != 0)
				{
					Mod1.t++;
					if (Mod1.t < Mod1.file1.Count())
					{
						lbmxtp.set_SelectedIndex(Mod1.t);
						PictureBox1.set_ImageLocation(Mod1.file1[Mod1.t].ToString());
					}
					else if (lbmxtp.get_Items().get_Count() != 0)
					{
						Mod1.t = 0;
						lbmxtp.set_SelectedIndex(0);
						PictureBox1.set_ImageLocation(Mod1.file1[Mod1.t].ToString());
					}
					else
					{
						PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void btngb_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnlldqwjj_Click(object sender, EventArgs e)
	{
		if (lbslwj.get_Items().get_Count() != 0)
		{
			string[] array = new string[5]
			{
				Mod1.path1,
				"\\",
				null,
				null,
				null
			};
			ListBox val = lbjslx;
			string text = val.get_Text();
			string text2 = Mod1.toen(ref text);
			val.set_Text(text);
			array[2] = text2;
			array[3] = "\\";
			array[4] = lbslwj.get_Text();
			Process.Start(string.Concat(array));
		}
	}

	private void btnlldqproewj_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		if (Mod1.Wait1)
		{
			Interaction.MsgBox((object)"与Pro/E模型相关的处理，请不要频繁操作，稍等片刻...", (MsgBoxStyle)64, (object)"提示");
		}
		else if (Mod1.asyncConnection == null)
		{
			Interaction.MsgBox((object)"请点击按钮[连接至当前],测试Pro/e连接是否正常!", (MsgBoxStyle)64, (object)"提示");
		}
		else if (Mod1.asyncConnection != null && !Mod1.asyncConnection.IsRunning())
		{
			Interaction.MsgBox((object)"请点击按钮[连接至当前],测试Pro/e连接是否正常!", (MsgBoxStyle)64, (object)"提示");
		}
		else
		{
			if (Operators.CompareString(Strings.Trim(lbslwj.get_Text()), "", false) == 0)
			{
				return;
			}
			try
			{
				Findfile();
				if (!asm & !prt)
				{
					Interaction.MsgBox((object)"没有找到目标文件，打开失败！！", (MsgBoxStyle)64, (object)"打开失败");
					return;
				}
				if (asm)
				{
					string[] array = new string[8]
					{
						Mod1.path1,
						"\\",
						null,
						null,
						null,
						null,
						null,
						null
					};
					string[] array2 = array;
					ListBox val = lbjslx;
					string text = val.get_Text();
					string text2 = Mod1.toen(ref text);
					val.set_Text(text);
					array2[2] = text2;
					array[3] = "\\";
					array[4] = lbslwj.get_Text();
					array[5] = "\\source\\";
					array[6] = lbslwj.get_Text();
					array[7] = ".asm";
					Mod1.flay = string.Concat(array);
				}
				else
				{
					if (!prt)
					{
						Interaction.MsgBox((object)"没有找到目标文件，打开失败！！", (MsgBoxStyle)64, (object)"打开失败");
						return;
					}
					string[] array = new string[8]
					{
						Mod1.path1,
						"\\",
						null,
						null,
						null,
						null,
						null,
						null
					};
					string[] array3 = array;
					ListBox val = lbjslx;
					string text = val.get_Text();
					string text3 = Mod1.toen(ref text);
					val.set_Text(text);
					array3[2] = text3;
					array[3] = "\\";
					array[4] = lbslwj.get_Text();
					array[5] = "\\source\\";
					array[6] = lbslwj.get_Text();
					array[7] = ".prt";
					Mod1.flay = string.Concat(array);
				}
				((Control)this).set_Cursor(Cursors.get_AppStarting());
				Mod1.shichu();
				Mod1.modeld = Mod1.cmodeld.CreateFromFileName(Mod1.flay);
				IpfcSession session = Mod1.session;
				object[] array4 = new object[1] { Mod1.modeld };
				bool[] array5 = new bool[1] { true };
				object obj = NewLateBinding.LateGet((object)session, (Type)null, "RetrieveModel", array4, (string[])null, (Type[])null, array5);
				if (array5[0])
				{
					Mod1.modeld = (IpfcModelDescriptor)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(IpfcModelDescriptor));
				}
				Mod1.model = (IpfcModel)obj;
				Mod1.win = (IpfcWindow)NewLateBinding.LateGet((object)Mod1.session, (Type)null, "CurrentWindow", new object[0], (string[])null, (Type[])null, (bool[])null);
				Mod1.model.Display();
				Mod1.win.Activate();
				Mod1.win.Repaint();
				((Control)this).set_Cursor(Cursors.get_Arrow());
				Mod1.proetime();
				Mod1.Wait1 = true;
				TM1.set_Interval(checked(Mod1.time1 * 1000));
				TM1.set_Enabled(true);
				TM1.Start();
				((Control)btnlldqproewj).set_Enabled(false);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	public object Findfile()
	{
		string[] array = new string[6]
		{
			Mod1.path1,
			"\\",
			null,
			null,
			null,
			null
		};
		ListBox val = lbjslx;
		string text = val.get_Text();
		string text2 = Mod1.toen(ref text);
		val.set_Text(text);
		array[2] = text2;
		array[3] = "\\";
		array[4] = lbslwj.get_Text();
		array[5] = "\\source\\";
		string text3 = string.Concat(array);
		if (Directory.Exists(text3))
		{
			string[] files = Directory.GetFiles(text3, lbslwj.get_Text() + ".asm.*", SearchOption.AllDirectories);
			if (files.Length != 0)
			{
				asm = true;
			}
			else
			{
				asm = false;
				files = Directory.GetFiles(text3, lbslwj.get_Text() + ".prt.*", SearchOption.AllDirectories);
				if (files.Length != 0)
				{
					prt = true;
				}
				else
				{
					prt = false;
				}
			}
		}
		else
		{
			asm = false;
			prt = false;
		}
		object result = default(object);
		return result;
	}

	private void btnscsl_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			FolderBrowserDialog val = new FolderBrowserDialog();
			val.set_Description("选择保存文件夹路径");
			((CommonDialog)val).ShowDialog();
			if (((Operators.CompareString(val.get_SelectedPath(), "", false) != 0) & (Operators.CompareString(Strings.Trim(lbjslx.get_Text()), "", false) != 0)) && Directory.Exists(val.get_SelectedPath()))
			{
				FileSystemProxy fileSystem = ((ServerComputer)MyProject.Computer).get_FileSystem();
				string[] array = new string[5]
				{
					Mod1.path1,
					"\\",
					null,
					null,
					null
				};
				ListBox val2 = lbjslx;
				string text = val2.get_Text();
				string text2 = Mod1.toen(ref text);
				val2.set_Text(text);
				array[2] = text2;
				array[3] = "\\";
				array[4] = lbslwj.get_Text();
				fileSystem.CopyDirectory(string.Concat(array), val.get_SelectedPath(), true);
				Interaction.MsgBox((object)"拷贝文件成功！", (MsgBoxStyle)64, (object)"提示");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message.ToString(), (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	private void btnljproe_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Process.GetProcessesByName("xtop").Length <= 0)
			{
				Interaction.MsgBox((object)"当前系统没有运行PRO/E，请运行后再试！", (MsgBoxStyle)64, (object)"提示");
				((Control)btnljproe).set_ForeColor(Color.Red);
				return;
			}
			if (Operators.CompareString(Environment.GetEnvironmentVariable("PRO_COMM_MSG_EXE"), "", false) == 0)
			{
				Interaction.MsgBox((object)"当前系统没有添加系统环境变量 PRO_COMM_MSG_EXE，请添加后再试！", (MsgBoxStyle)64, (object)"提示");
				((Control)btnljproe).set_ForeColor(Color.Red);
				return;
			}
			((Control)this).set_Cursor(Cursors.get_AppStarting());
			if (Mod1.asyncConnection == null)
			{
				Guid clsid = new Guid("456E0110-2031-3907-AFE5-9201C97A915E");
				Mod1.asyncConnection = ((CCpfcAsyncConnection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid))).Connect(null, null, null, null);
			}
			((Control)this).set_Cursor(Cursors.get_Arrow());
			if (Mod1.asyncConnection != null && !Mod1.asyncConnection.IsRunning())
			{
				Guid clsid = new Guid("456E0110-2031-3907-AFE5-9201C97A915E");
				Mod1.asyncConnection = ((CCpfcAsyncConnection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid))).Connect(null, null, null, null);
			}
			((Control)btnljproe).set_ForeColor(Color.Green);
			Interaction.MsgBox((object)"Pro/E 连接成功", (MsgBoxStyle)64, (object)"提示");
			Mod1.session = Mod1.asyncConnection.Session;
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet((object)Mod1.session, (Type)null, "ListModels", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				Interaction.MsgBox((object)"继续Proe相关的操作会关闭当前正在打开的Proe文件,请先行保存重要的文件!", (MsgBoxStyle)64, (object)"提示");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void btndk_Click(object sender, EventArgs e)
	{
		filename = Directory.GetFiles(Application.get_StartupPath() + "\\Temp\\", "*.GIF", SearchOption.AllDirectories);
		if (filename.Count() != 0)
		{
			FileSystem.Kill(Application.get_StartupPath() + "\\Temp\\*.*");
		}
		dakai();
		Mod1.getm = false;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void lbcswj_DoubleClick(object sender, EventArgs e)
	{
		filename = Directory.GetFiles(Application.get_StartupPath() + "\\Temp\\", "*.GIF", SearchOption.AllDirectories);
		if (filename.Count() != 0)
		{
			FileSystem.Kill(Application.get_StartupPath() + "\\Temp\\*.*");
		}
		dakai();
	}

	public void dakai()
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Invalid comparison between Unknown and I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Invalid comparison between Unknown and I4
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Invalid comparison between Unknown and I4
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!((Operators.CompareString(Strings.Trim(lbcswj.get_Text()), "", false) != 0) & (lbcswj.get_SelectedIndex() != -1)))
			{
				return;
			}
			if (!Information.IsNothing((object)Mod1.wb))
			{
				((BaseItem)MyProject.Forms.Main.Toolsfxxd).set_Enabled(true);
				if (!Mod1.Saved)
				{
					MsgBoxResult val = (MsgBoxResult)MessageBox.Show("部件：" + Mod1.bjlb1 + " 参数文件： " + Mod1.cswj + " 已经被修改，是否保存后再打开？", "重要提示", (MessageBoxButtons)3, (MessageBoxIcon)64);
					if ((int)val == 6)
					{
						Mod1.wb.Save();
						Mod1.wb.Close(Missing.Value, Missing.Value, Missing.Value);
						MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员对部件： " + Mod1.bjlb1 + " 参数文件: " + Mod1.cswj + " 进行了保存"));
						Interaction.MsgBox((object)"保存成功!", (MsgBoxStyle)64, (object)"提示");
						Mod1.wb = null;
						Mod1.Saved = true;
						Mod1.str1 = "";
						((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(false);
						((Component)(object)MyProject.Forms.cslr2).Dispose();
						if (Operators.CompareString(Strings.Trim(Mod1.pathh), "", false) != 0)
						{
							Mod1.pathh = Mod1.list[lbcswj.get_SelectedIndex()];
							Mod1.wb = Mod1.excelapp.Workbooks.Open(Mod1.pathh, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
							Interaction.MsgBox((object)(((ComboBox)cmbj).get_Text() + " 参数文件: " + lbcswj.get_Text() + " 已被打开"), (MsgBoxStyle)64, (object)"提示");
							MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开部件：" + ((ComboBox)cmbj).get_Text() + " 参数文件: " + lbcswj.get_Text()));
							Mod1.bjlb1 = ((ComboBox)cmbj).get_Text();
							Mod1.cswj = lbcswj.get_Text();
							((Form)this).Close();
						}
					}
					else if ((int)val == 7)
					{
						Mod1.str1 = "";
						Mod1.Saved = true;
						Interaction.MsgBox((object)("请注意你修改过的 " + Mod1.bjlb1 + "  参数文件：" + Mod1.cswj + " 没有保存, " + lbcswj.get_Text() + " 打开成功!"), (MsgBoxStyle)64, (object)"重要提示");
						MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员对修改的： " + Mod1.bjlb1 + " 参数文件：" + Mod1.cswj + " 没有保存"));
						Mod1.pathh = Strings.Trim(Mod1.list[lbcswj.get_SelectedIndex()]);
						if (Mod1.excelapp.Workbooks.Count != 0)
						{
							Mod1.wb.Close(Missing.Value, Missing.Value, Missing.Value);
						}
						Mod1.wb = Mod1.excelapp.Workbooks.Open(Mod1.pathh, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
						((Form)this).Close();
						MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + "  操作员打开部件：" + ((ComboBox)cmbj).get_Text() + " 参数文件: " + lbcswj.get_Text()));
						Mod1.cswj = lbcswj.get_Text();
						Mod1.bjlb1 = ((ComboBox)cmbj).get_Text();
						((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(false);
						((Component)(object)MyProject.Forms.cslr2).Dispose();
					}
				}
				else if ((int)MessageBox.Show("部件：" + Mod1.bjlb1 + " 参数文件：" + Mod1.cswj + " 已经被打开，是否打开选定的参数文件？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
				{
					Mod1.str1 = "";
					Mod1.pathh = Strings.Trim(Mod1.list[lbcswj.get_SelectedIndex()]);
					if (Mod1.excelapp.Workbooks.Count != 0)
					{
						Mod1.wb.Close(Missing.Value, Missing.Value, Missing.Value);
					}
					Mod1.wb = Mod1.excelapp.Workbooks.Open(Mod1.pathh, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
					Mod1.cswj = lbcswj.get_Text();
					Mod1.bjlb1 = ((ComboBox)cmbj).get_Text();
					MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了部件：" + Mod1.bjlb1 + " 参数文件：" + Mod1.cswj));
					((Form)this).Close();
					((Component)(object)MyProject.Forms.cslr2).Dispose();
				}
				else
				{
					Mod1.str1 = "";
				}
			}
			else if (Operators.CompareString(Mod1.pathh, (string)null, false) == 0)
			{
				((BaseItem)MyProject.Forms.Main.Toolsfxxd).set_Enabled(true);
				Mod1.cswj = lbcswj.get_Text();
				Mod1.bjlb1 = ((ComboBox)cmbj).get_Text();
				Mod1.pathh = Strings.Trim(Mod1.list[lbcswj.get_SelectedIndex()]);
				Mod1.wb = Mod1.excelapp.Workbooks.Open(Mod1.pathh, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了部件：" + Mod1.bjlb1 + " 参数文件：" + Mod1.cswj));
				((Form)this).Close();
			}
			else if ((int)MessageBox.Show("部件：" + Mod1.bjlb1 + " 参数文件：" + Mod1.cswj + " 已经被打开，是否打开选定的参数文件？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
			{
				Mod1.str1 = "";
				if (lbcswj.get_SelectedIndex() != -1)
				{
					Mod1.pathh = Strings.Trim(Mod1.list[lbcswj.get_SelectedIndex()]);
					if (Mod1.excelapp.Workbooks.Count != 0)
					{
						Mod1.wb.Close(Missing.Value, Missing.Value, Missing.Value);
					}
					Mod1.wb = Mod1.excelapp.Workbooks.Open(Mod1.pathh, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
					Mod1.cswj = lbcswj.get_Text();
					MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了部件： " + ((ComboBox)cmbj).get_Text() + " 参数文件：" + lbcswj.get_Text()));
					((Form)this).Close();
					((Component)(object)MyProject.Forms.cslr2).Dispose();
				}
			}
			else
			{
				Mod1.str1 = "";
			}
			((BaseItem)MyProject.Forms.Main.ToolsInput).set_Enabled(true);
			MyProject.Forms.Main.lbx.set_Text("当前已打开部件： " + Mod1.bjlb1 + "  参数文件：" + Mod1.cswj);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	private void lbcswj_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(lbcswj.get_Text(), "", false) != 0)
		{
			((Control)btndk).set_Enabled(true);
		}
	}

	private void TM1_Tick(object sender, EventArgs e)
	{
		Mod1.Wait1 = false;
		TM1.Stop();
	}
}
