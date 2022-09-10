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
using Microsoft.Office.Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class cslr2 : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("btncsyz")]
	private ButtonX _btncsyz;

	[AccessedThroughProperty("btntqjl")]
	private ButtonX _btntqjl;

	[AccessedThroughProperty("btngb")]
	private ButtonX _btngb;

	[AccessedThroughProperty("btnbcjg")]
	private ButtonX _btnbcjg;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("tbdqid")]
	private TextBoxX _tbdqid;

	[AccessedThroughProperty("cbsddqid")]
	private CheckBoxX _cbsddqid;

	[AccessedThroughProperty("GroupPanel1")]
	private GroupPanel _GroupPanel1;

	[AccessedThroughProperty("lbid")]
	private ListBox _lbid;

	[AccessedThroughProperty("lbcsx")]
	private ListBox _lbcsx;

	[AccessedThroughProperty("ll_btncurjmcheck")]
	private ButtonX _ll_btncurjmcheck;

	[AccessedThroughProperty("lslog")]
	private ListBox _lslog;

	[AccessedThroughProperty("PBX1")]
	private ProgressBarX _PBX1;

	[AccessedThroughProperty("CBX1")]
	private CheckBoxX _CBX1;

	[AccessedThroughProperty("lbrows")]
	private ListBox _lbrows;

	[AccessedThroughProperty("DGV")]
	private DataGridViewX _DGV;

	[AccessedThroughProperty("Tool")]
	private ToolTip _Tool;

	[AccessedThroughProperty("CBchanzhao")]
	private CheckBoxX _CBchanzhao;

	private string[] filename;

	private bool @bool;

	public bool bcscheckok;

	public string id;

	private string cstxt;

	private bool bj;

	private string a;

	private bool bjzt;

	public string csmc0;

	public string str2;

	internal virtual ButtonX btncsyz
	{
		[DebuggerNonUserCode]
		get
		{
			return _btncsyz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btncsyz_Click;
			if (_btncsyz != null)
			{
				((Control)_btncsyz).remove_Click(eventHandler);
			}
			_btncsyz = value;
			if (_btncsyz != null)
			{
				((Control)_btncsyz).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btntqjl
	{
		[DebuggerNonUserCode]
		get
		{
			return _btntqjl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btntqjl_Click;
			if (_btntqjl != null)
			{
				((Control)_btntqjl).remove_Click(eventHandler);
			}
			_btntqjl = value;
			if (_btntqjl != null)
			{
				((Control)_btntqjl).add_Click(eventHandler);
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

	public virtual ButtonX btnbcjg
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnbcjg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnbcjg_Click;
			if (_btnbcjg != null)
			{
				((Control)_btnbcjg).remove_Click(eventHandler);
			}
			_btnbcjg = value;
			if (_btnbcjg != null)
			{
				((Control)_btnbcjg).add_Click(eventHandler);
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

	internal virtual TextBoxX tbdqid
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbdqid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbdqid = value;
		}
	}

	internal virtual CheckBoxX cbsddqid
	{
		[DebuggerNonUserCode]
		get
		{
			return _cbsddqid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cbsddqid_CheckedChanged;
			if (_cbsddqid != null)
			{
				_cbsddqid.remove_CheckedChanged(eventHandler);
			}
			_cbsddqid = value;
			if (_cbsddqid != null)
			{
				_cbsddqid.add_CheckedChanged(eventHandler);
			}
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

	internal virtual ListBox lbid
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbid_SelectedIndexChanged;
			if (_lbid != null)
			{
				_lbid.remove_SelectedIndexChanged(eventHandler);
			}
			_lbid = value;
			if (_lbid != null)
			{
				_lbid.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public virtual ListBox lbcsx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbcsx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = lbcsx_SelectedIndexChanged;
			MouseEventHandler val = new MouseEventHandler(lbcsx_MouseUp);
			if (_lbcsx != null)
			{
				_lbcsx.remove_SelectedIndexChanged(eventHandler);
				((Control)_lbcsx).remove_MouseUp(val);
			}
			_lbcsx = value;
			if (_lbcsx != null)
			{
				_lbcsx.add_SelectedIndexChanged(eventHandler);
				((Control)_lbcsx).add_MouseUp(val);
			}
		}
	}

	public virtual ButtonX ll_btncurjmcheck
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncurjmcheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncurjmcheck_Click;
			if (_ll_btncurjmcheck != null)
			{
				((Control)_ll_btncurjmcheck).remove_Click(eventHandler);
			}
			_ll_btncurjmcheck = value;
			if (_ll_btncurjmcheck != null)
			{
				((Control)_ll_btncurjmcheck).add_Click(eventHandler);
			}
		}
	}

	public virtual ListBox lslog
	{
		[DebuggerNonUserCode]
		get
		{
			return _lslog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lslog_DoubleClick;
			if (_lslog != null)
			{
				((Control)_lslog).remove_DoubleClick(eventHandler);
			}
			_lslog = value;
			if (_lslog != null)
			{
				((Control)_lslog).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual ProgressBarX PBX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PBX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PBX1 = value;
		}
	}

	public virtual CheckBoxX CBX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CBX1_CheckedChanged;
			if (_CBX1 != null)
			{
				_CBX1.remove_CheckedChanged(eventHandler);
			}
			_CBX1 = value;
			if (_CBX1 != null)
			{
				_CBX1.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox lbrows
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbrows;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbrows = value;
		}
	}

	public virtual DataGridViewX DGV
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			EventHandler eventHandler = DGV_DoubleClick;
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(DGV_CellValueChanged);
			ScrollEventHandler val2 = new ScrollEventHandler(DGV_Scroll);
			EventHandler eventHandler2 = DGV_Click;
			DataGridViewCellEventHandler val3 = new DataGridViewCellEventHandler(DGV_RowEnter);
			DataGridViewCellEventHandler val4 = new DataGridViewCellEventHandler(DGV_CellClick);
			if (_DGV != null)
			{
				((Control)_DGV).remove_DoubleClick(eventHandler);
				((DataGridView)_DGV).remove_CellValueChanged(val);
				((DataGridView)_DGV).remove_Scroll(val2);
				((Control)_DGV).remove_Click(eventHandler2);
				((DataGridView)_DGV).remove_RowEnter(val3);
				((DataGridView)_DGV).remove_CellClick(val4);
			}
			_DGV = value;
			if (_DGV != null)
			{
				((Control)_DGV).add_DoubleClick(eventHandler);
				((DataGridView)_DGV).add_CellValueChanged(val);
				((DataGridView)_DGV).add_Scroll(val2);
				((Control)_DGV).add_Click(eventHandler2);
				((DataGridView)_DGV).add_RowEnter(val3);
				((DataGridView)_DGV).add_CellClick(val4);
			}
		}
	}

	internal virtual ToolTip Tool
	{
		[DebuggerNonUserCode]
		get
		{
			return _Tool;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Tool = value;
		}
	}

	public virtual CheckBoxX CBchanzhao
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBchanzhao;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CBchanzhao_CheckedChanged;
			if (_CBchanzhao != null)
			{
				_CBchanzhao.remove_CheckedChanged(eventHandler);
			}
			_CBchanzhao = value;
			if (_CBchanzhao != null)
			{
				_CBchanzhao.add_CheckedChanged(eventHandler);
			}
		}
	}

	public cslr2()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(cslr2_FormClosed));
		((Form)this).add_Load((EventHandler)cslr2_Load);
		@bool = false;
		bcscheckok = true;
		cstxt = Application.get_StartupPath() + "\\Temp\\cs.txt";
		bj = false;
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
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected O, but got Unknown
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Expected O, but got Unknown
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected O, but got Unknown
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected O, but got Unknown
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected O, but got Unknown
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected O, but got Unknown
		//IL_0e25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2f: Expected O, but got Unknown
		//IL_0f83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8d: Expected O, but got Unknown
		//IL_108f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1099: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		btncsyz = new ButtonX();
		btntqjl = new ButtonX();
		btngb = new ButtonX();
		btnbcjg = new ButtonX();
		LabelX1 = new LabelX();
		LabelX3 = new LabelX();
		tbdqid = new TextBoxX();
		cbsddqid = new CheckBoxX();
		GroupPanel1 = new GroupPanel();
		lbid = new ListBox();
		lbcsx = new ListBox();
		ll_btncurjmcheck = new ButtonX();
		DGV = new DataGridViewX();
		lslog = new ListBox();
		PBX1 = new ProgressBarX();
		CBX1 = new CheckBoxX();
		lbrows = new ListBox();
		Tool = new ToolTip(components);
		CBchanzhao = new CheckBoxX();
		((Control)GroupPanel1).SuspendLayout();
		((ISupportInitialize)DGV).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btncsyz).set_AccessibleRole((AccessibleRole)43);
		((Control)btncsyz).set_Anchor((AnchorStyles)4);
		btncsyz.set_ColorTable((eButtonColor)3);
		((Control)btncsyz).set_Enabled(false);
		((Control)btncsyz).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj = btncsyz;
		Point location = new Point(16, 345);
		((Control)obj).set_Location(location);
		((Control)btncsyz).set_Name("btncsyz");
		ButtonX obj2 = btncsyz;
		Size size = new Size(168, 32);
		((Control)obj2).set_Size(size);
		((PopupItemControl)btncsyz).set_Style((eDotNetBarStyle)7);
		((Control)btncsyz).set_TabIndex(36);
		btncsyz.set_Text("参数关系必要性验证");
		((Control)btntqjl).set_AccessibleRole((AccessibleRole)43);
		((Control)btntqjl).set_Anchor((AnchorStyles)4);
		btntqjl.set_ColorTable((eButtonColor)3);
		((Control)btntqjl).set_Enabled(false);
		((Control)btntqjl).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj3 = btntqjl;
		location = new Point(16, 383);
		((Control)obj3).set_Location(location);
		((Control)btntqjl).set_Name("btntqjl");
		ButtonX obj4 = btntqjl;
		size = new Size(168, 32);
		((Control)obj4).set_Size(size);
		((PopupItemControl)btntqjl).set_Style((eDotNetBarStyle)7);
		((Control)btntqjl).set_TabIndex(37);
		btntqjl.set_Text("提取验证结果到记录");
		((Control)btngb).set_AccessibleRole((AccessibleRole)43);
		((Control)btngb).set_Anchor((AnchorStyles)4);
		btngb.set_ColorTable((eButtonColor)3);
		btngb.set_DialogResult((DialogResult)2);
		((Control)btngb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj5 = btngb;
		location = new Point(16, 498);
		((Control)obj5).set_Location(location);
		((Control)btngb).set_Name("btngb");
		ButtonX obj6 = btngb;
		size = new Size(168, 32);
		((Control)obj6).set_Size(size);
		((PopupItemControl)btngb).set_Style((eDotNetBarStyle)7);
		((Control)btngb).set_TabIndex(35);
		btngb.set_Text("关闭当前窗口(ESC)");
		((Control)btnbcjg).set_AccessibleRole((AccessibleRole)43);
		((Control)btnbcjg).set_Anchor((AnchorStyles)4);
		btnbcjg.set_ColorTable((eButtonColor)3);
		((Control)btnbcjg).set_Enabled(false);
		((Control)btnbcjg).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj7 = btnbcjg;
		location = new Point(16, 460);
		((Control)obj7).set_Location(location);
		((Control)btnbcjg).set_Name("btnbcjg");
		ButtonX obj8 = btnbcjg;
		size = new Size(168, 32);
		((Control)obj8).set_Size(size);
		((PopupItemControl)btnbcjg).set_Style((eDotNetBarStyle)7);
		((Control)btnbcjg).set_TabIndex(38);
		btnbcjg.set_Text("保存截面数据到SET");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		location = new Point(7, 166);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(42, 14);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(26);
		LabelX1.set_Text("ID选择");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX3).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX3 = LabelX3;
		location = new Point(7, 1);
		((Control)labelX3).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX4 = LabelX3;
		size = new Size(168, 14);
		((Control)labelX4).set_Size(size);
		((Control)LabelX3).set_TabIndex(25);
		LabelX3.set_Text("参数页面");
		((TextBoxBase)tbdqid).set_BackColor(SystemColors.AppWorkspace);
		tbdqid.get_Border().set_Class("TextBoxBorder");
		tbdqid.get_Border().set_CornerType((eCornerType)1);
		((TextBoxBase)tbdqid).set_ForeColor(Color.White);
		TextBoxX obj9 = tbdqid;
		location = new Point(52, 159);
		((Control)obj9).set_Location(location);
		((Control)tbdqid).set_Name("tbdqid");
		((TextBoxBase)tbdqid).set_ReadOnly(true);
		TextBoxX obj10 = tbdqid;
		size = new Size(123, 21);
		((Control)obj10).set_Size(size);
		((Control)tbdqid).set_TabIndex(24);
		((Control)cbsddqid).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)cbsddqid).get_BackgroundStyle().set_Class("");
		((BaseItemControl)cbsddqid).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((BaseItemControl)cbsddqid).set_FocusCuesEnabled(false);
		CheckBoxX obj11 = cbsddqid;
		location = new Point(52, 183);
		((Control)obj11).set_Location(location);
		((Control)cbsddqid).set_Name("cbsddqid");
		CheckBoxX obj12 = cbsddqid;
		size = new Size(100, 20);
		((Control)obj12).set_Size(size);
		((BaseItemControl)cbsddqid).set_Style((eDotNetBarStyle)7);
		((Control)cbsddqid).set_TabIndex(2);
		cbsddqid.set_Text("锁定当前ID");
		((PanelControl)GroupPanel1).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX1);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX3);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)tbdqid);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)cbsddqid);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)lbid);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)lbcsx);
		GroupPanel groupPanel = GroupPanel1;
		location = new Point(6, 3);
		((Control)groupPanel).set_Location(location);
		((Control)GroupPanel1).set_Name("GroupPanel1");
		GroupPanel groupPanel2 = GroupPanel1;
		size = new Size(187, 281);
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
		((Control)GroupPanel1).set_TabIndex(31);
		lbid.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbid).set_FormattingEnabled(true);
		lbid.set_ItemHeight(12);
		ListBox obj13 = lbid;
		location = new Point(7, 208);
		((Control)obj13).set_Location(location);
		((Control)lbid).set_Name("lbid");
		ListBox obj14 = lbid;
		size = new Size(168, 64);
		((Control)obj14).set_Size(size);
		((Control)lbid).set_TabIndex(1);
		lbcsx.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbcsx).set_FormattingEnabled(true);
		lbcsx.set_ItemHeight(12);
		ListBox obj15 = lbcsx;
		location = new Point(7, 17);
		((Control)obj15).set_Location(location);
		((Control)lbcsx).set_Name("lbcsx");
		ListBox obj16 = lbcsx;
		size = new Size(168, 136);
		((Control)obj16).set_Size(size);
		((Control)lbcsx).set_TabIndex(0);
		((Control)ll_btncurjmcheck).set_AccessibleRole((AccessibleRole)43);
		((Control)ll_btncurjmcheck).set_Anchor((AnchorStyles)4);
		ll_btncurjmcheck.set_ColorTable((eButtonColor)3);
		((Control)ll_btncurjmcheck).set_Enabled(false);
		((Control)ll_btncurjmcheck).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj17 = ll_btncurjmcheck;
		location = new Point(16, 422);
		((Control)obj17).set_Location(location);
		((Control)ll_btncurjmcheck).set_Name("ll_btncurjmcheck");
		ButtonX obj18 = ll_btncurjmcheck;
		size = new Size(168, 32);
		((Control)obj18).set_Size(size);
		((PopupItemControl)ll_btncurjmcheck).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncurjmcheck).set_TabIndex(39);
		ll_btncurjmcheck.set_Text("当前截面示意图查看");
		((DataGridView)DGV).set_AllowUserToAddRows(false);
		((DataGridView)DGV).set_AllowUserToDeleteRows(false);
		((DataGridView)DGV).set_AllowUserToResizeRows(false);
		((Control)DGV).set_Anchor((AnchorStyles)15);
		((DataGridView)DGV).set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)1);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Window);
		val.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val.set_ForeColor(SystemColors.ControlText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.ControlText);
		val.set_WrapMode((DataGridViewTriState)2);
		((DataGridView)DGV).set_DefaultCellStyle(val);
		((DataGridView)DGV).set_GridColor(Color.FromArgb(208, 215, 229));
		DataGridViewX dGV = DGV;
		location = new Point(199, 4);
		((Control)dGV).set_Location(location);
		((DataGridView)DGV).set_MultiSelect(false);
		((Control)DGV).set_Name("DGV");
		((DataGridView)DGV).get_RowTemplate().set_Height(23);
		((DataGridView)DGV).set_SelectionMode((DataGridViewSelectionMode)1);
		DataGridViewX dGV2 = DGV;
		size = new Size(679, 444);
		((Control)dGV2).set_Size(size);
		((Control)DGV).set_TabIndex(44);
		((Control)lslog).set_Anchor((AnchorStyles)14);
		lslog.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lslog).set_FormattingEnabled(true);
		lslog.set_ItemHeight(12);
		ListBox obj19 = lslog;
		location = new Point(199, 492);
		((Control)obj19).set_Location(location);
		((Control)lslog).set_Name("lslog");
		ListBox obj20 = lslog;
		size = new Size(679, 76);
		((Control)obj20).set_Size(size);
		((Control)lslog).set_TabIndex(45);
		((Control)PBX1).set_Anchor((AnchorStyles)14);
		((BaseItemControl)PBX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)PBX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		ProgressBarX pBX = PBX1;
		location = new Point(199, 457);
		((Control)pBX).set_Location(location);
		((Control)PBX1).set_Name("PBX1");
		ProgressBarX pBX2 = PBX1;
		size = new Size(679, 29);
		((Control)pBX2).set_Size(size);
		((Control)PBX1).set_TabIndex(46);
		((Control)PBX1).set_Text("ProgressBarX1");
		((Control)CBX1).set_Anchor((AnchorStyles)4);
		((BaseItemControl)CBX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)CBX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((BaseItemControl)CBX1).set_FocusCuesEnabled(false);
		CheckBoxX cBX = CBX1;
		location = new Point(16, 290);
		((Control)cBX).set_Location(location);
		((Control)CBX1).set_Name("CBX1");
		CheckBoxX cBX2 = CBX1;
		size = new Size(123, 23);
		((Control)cBX2).set_Size(size);
		((BaseItemControl)CBX1).set_Style((eDotNetBarStyle)7);
		((Control)CBX1).set_TabIndex(47);
		CBX1.set_Text("显示参数示意图");
		lbrows.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbrows).set_FormattingEnabled(true);
		lbrows.set_ItemHeight(12);
		ListBox obj21 = lbrows;
		location = new Point(375, 165);
		((Control)obj21).set_Location(location);
		((Control)lbrows).set_Name("lbrows");
		ListBox obj22 = lbrows;
		size = new Size(168, 64);
		((Control)obj22).set_Size(size);
		((Control)lbrows).set_TabIndex(1);
		((Control)CBchanzhao).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)CBchanzhao).get_BackgroundStyle().set_Class("");
		((BaseItemControl)CBchanzhao).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((BaseItemControl)CBchanzhao).set_FocusCuesEnabled(false);
		CheckBoxX cBchanzhao = CBchanzhao;
		location = new Point(16, 319);
		((Control)cBchanzhao).set_Location(location);
		((Control)CBchanzhao).set_Name("CBchanzhao");
		CheckBoxX cBchanzhao2 = CBchanzhao;
		size = new Size(100, 20);
		((Control)cBchanzhao2).set_Size(size);
		((BaseItemControl)CBchanzhao).set_Style((eDotNetBarStyle)7);
		((Control)CBchanzhao).set_TabIndex(2);
		CBchanzhao.set_Text("启用参照列");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btngb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(886, 573);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)CBX1);
		((Control)this).get_Controls().Add((Control)(object)PBX1);
		((Control)this).get_Controls().Add((Control)(object)lslog);
		((Control)this).get_Controls().Add((Control)(object)CBchanzhao);
		((Control)this).get_Controls().Add((Control)(object)btncsyz);
		((Control)this).get_Controls().Add((Control)(object)btntqjl);
		((Control)this).get_Controls().Add((Control)(object)btngb);
		((Control)this).get_Controls().Add((Control)(object)btnbcjg);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel1);
		((Control)this).get_Controls().Add((Control)(object)ll_btncurjmcheck);
		((Control)this).get_Controls().Add((Control)(object)DGV);
		((Control)this).get_Controls().Add((Control)(object)lbrows);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Control)this).set_Name("cslr2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("参数录入界面");
		((Control)GroupPanel1).ResumeLayout(false);
		((ISupportInitialize)DGV).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cslr2_Load(object sender, EventArgs e)
	{
		((Control)LabelX1).set_BackColor(Color.Transparent);
		((Control)LabelX3).set_BackColor(Color.Transparent);
		if (Operators.CompareString(MyProject.Forms.FrmOf.qyx, "qyxxn", false) == 0)
		{
			((Control)CBchanzhao).set_Enabled(true);
		}
		else
		{
			((Control)CBchanzhao).set_Enabled(false);
		}
		((Control)this).set_Cursor(Cursors.get_AppStarting());
		try
		{
			Mod1.excelapp.DisplayAlerts = false;
			if (lbcsx.get_Items().get_Count() == 0)
			{
				if (Operators.CompareString(Mod1.pathh, "", false) != 0)
				{
					Sheets();
					Mod1.filename = Convert.ToString(Mod1.pathh.Substring(checked(Mod1.pathh.LastIndexOf("\\") + 1)));
				}
				if (lbcsx.get_Items().get_Count() != 0)
				{
					lbcsx.set_SelectedIndex(0);
				}
			}
			if (Operators.CompareString(((TextBox)tbdqid).get_Text(), "", false) != 0)
			{
				Mod1.curjmID = ((TextBox)tbdqid).get_Text();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		((Control)this).set_Cursor(Cursors.get_Arrow());
	}

	public void Sheets()
	{
		lbcsx.get_Items().Clear();
		Mod1.SheetsCount = Mod1.wb.Sheets.Count;
		int sheetsCount = Mod1.SheetsCount;
		for (int i = 1; i <= sheetsCount; i = checked(i + 1))
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Mod1.wb.Sheets[i], (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"参数校验", false))
			{
				((Control)btncsyz).set_Enabled(true);
			}
			else
			{
				((Control)btncsyz).set_Enabled(false);
			}
			lbcsx.get_Items().Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.wb.Sheets[i], (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
	}

	public void Cbmp()
	{
		if (Mod1.excelsheet.Shapes.Count == 0)
		{
			return;
		}
		checked
		{
			int num = Mod1.excelsheet.Shapes.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (File.Exists(Application.get_StartupPath() + "\\Temp\\" + lbcsx.get_Text() + "Picture " + Conversions.ToString(i) + ".gif"))
				{
					continue;
				}
				float num2 = Conversions.ToSingle(NewLateBinding.LateGet(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null));
				float num3 = Conversions.ToSingle(NewLateBinding.LateGet(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null));
				float num4 = Conversions.ToSingle(Operators.DivideObject(NewLateBinding.LateGet(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)((Control)MyProject.Forms.Pic.PictureBox1).get_Height()));
				float num5 = Conversions.ToSingle(Operators.DivideObject(NewLateBinding.LateGet(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), (object)((Control)MyProject.Forms.Pic.PictureBox1).get_Width()));
				bool[] array3;
				if ((num2 < (float)((Control)MyProject.Forms.Pic.PictureBox1).get_Height()) & (num3 < (float)((Control)MyProject.Forms.Pic.PictureBox1).get_Width()))
				{
					NewLateBinding.LateCall(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "Copy", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					object obj = Mod1.excelsheet.ChartObjects(Missing.Value);
					object[] array = new object[4] { 0, 0, num3, num2 };
					object[] array2 = array;
					array3 = new bool[4] { false, false, true, true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Add", array2, (string[])null, (Type[])null, array3);
					if (array3[2])
					{
						num3 = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(float));
					}
					if (array3[3])
					{
						num2 = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[3]), typeof(float));
					}
					object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "Chart", new object[0], (string[])null, (Type[])null, (bool[])null);
					NewLateBinding.LateCall(obj3, (Type)null, "Paste", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(obj3, (Type)null, "Export", new object[2]
					{
						Application.get_StartupPath() + "\\Temp\\" + lbcsx.get_Text() + "Picture " + Conversions.ToString(i) + ".gif",
						"gif"
					}, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(NewLateBinding.LateGet(obj3, (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					obj3 = null;
					continue;
				}
				NewLateBinding.LateSetComplex(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "LockAspectRatio", new object[1] { MsoTriState.msoTrue }, (string[])null, (Type[])null, false, true);
				float num7;
				float num6;
				if (num4 > num5)
				{
					num6 = ((Control)MyProject.Forms.Pic.PictureBox1).get_Height();
					num7 = num3 / num4;
				}
				else
				{
					num7 = ((Control)MyProject.Forms.Pic.PictureBox1).get_Width();
					num6 = num2 / num5;
				}
				NewLateBinding.LateCall(Mod1.excelsheet.Shapes.Cast<object>().ElementAtOrDefault(i), (Type)null, "Copy", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				object obj4 = Mod1.excelsheet.ChartObjects(Missing.Value);
				object[] array4 = new object[4] { 0, 0, num7, num6 };
				object[] array5 = array4;
				array3 = new bool[4] { false, false, true, true };
				object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "Add", array5, (string[])null, (Type[])null, array3);
				if (array3[2])
				{
					num7 = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[2]), typeof(float));
				}
				if (array3[3])
				{
					num6 = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[3]), typeof(float));
				}
				object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "Chart", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateCall(obj6, (Type)null, "Paste", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(obj6, (Type)null, "Export", new object[2]
				{
					Application.get_StartupPath() + "\\Temp\\" + lbcsx.get_Text() + "Picture " + Conversions.ToString(i) + ".gif",
					"gif"
				}, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(obj6, (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				obj6 = null;
			}
		}
	}

	public void dislplay1()
	{
		lbid.get_Items().Clear();
		Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)Mod1.o);
		Mod1.excelsheet.Activate();
		Mod1.lie();
		checked
		{
			if (Operators.CompareString(MyProject.Forms.FrmOf.qyx, "qyxxn", false) == 0)
			{
				int num = Mod1.countL - 1;
				int num2 = 5;
				while (true)
				{
					if (num2 <= num)
					{
						Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, num2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)));
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, num2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "性能计算ID_temp", false) == 0)
						{
							break;
						}
						num2++;
						continue;
					}
					return;
				}
				lbid.get_Items().Add((object)Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, num2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
			}
			else
			{
				int num3 = Mod1.countL - 1;
				for (int num2 = 5; num2 <= num3; num2++)
				{
					Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, num2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)));
					lbid.get_Items().Add((object)Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, num2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
				}
			}
		}
	}

	public void dislplayID()
	{
		Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)Mod1.o);
		Mod1.hang(ref Mod1.ba);
		PBX1.set_Maximum(Mod1.countH);
		((Control)this).set_Cursor(Cursors.get_AppStarting());
		xiancheng();
		((Control)this).set_Cursor(Cursors.get_Arrow());
	}

	public void xiancheng()
	{
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected O, but got Unknown
		int num = 1;
		checked
		{
			do
			{
				((DataGridView)DGV).get_Columns().Add(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, num], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, num], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
				num++;
			}
			while (num <= 4);
			((DataGridView)DGV).get_Columns().Add("", Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, Mod1.countL], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
			((DataGridView)DGV).get_Columns().get_Item(0).set_ReadOnly(true);
			((DataGridView)DGV).get_Columns().get_Item(1).set_ReadOnly(true);
			((DataGridView)DGV).get_Columns().get_Item(3).set_ReadOnly(true);
			((DataGridView)DGV).get_Columns().get_Item(((BaseCollection)((DataGridView)DGV).get_Columns()).get_Count() - 1).set_ReadOnly(true);
			((DataGridView)DGV).get_Columns().get_Item(((BaseCollection)((DataGridView)DGV).get_Columns()).get_Count() - 1).set_Width(300);
			if (Operators.CompareString(lbcsx.get_Text(), "参数校验", false) == 0)
			{
				((DataGridView)DGV).get_Columns().get_Item(2).set_ReadOnly(true);
			}
			int num2 = 0;
			int countH = Mod1.countH;
			int num3 = default(int);
			for (int i = 1; i <= countH; i++)
			{
				if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, Mod1.ba], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) != 0)
				{
					continue;
				}
				if (NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)
				{
					((DataGridView)DGV).get_Rows().Add();
					((DataGridView)DGV).get_Rows().get_Item(num2).get_Cells()
						.get_Item(0)
						.set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 1], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)));
					((DataGridView)DGV).get_Rows().get_Item(num2).get_Cells()
						.get_Item(1)
						.set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)));
					if (NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
					{
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) == 0)
						{
							((DataGridView)DGV).get_Rows().get_Item(num2).get_Cells()
								.get_Item(2)
								.set_Value((object)"");
						}
					}
					else
					{
						((DataGridView)DGV).get_Rows().get_Item(num2).get_Cells()
							.get_Item(2)
							.set_Value((object)Strings.Trim(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Replace("\t", " ")));
					}
					((DataGridView)DGV).get_Rows().get_Item(num2).get_Cells()
						.get_Item(3)
						.set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 4], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)));
					((DataGridView)DGV).get_Rows().get_Item(num2).get_Cells()
						.get_Item(((BaseCollection)((DataGridView)DGV).get_Columns()).get_Count() - 1)
						.set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, Mod1.countL], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)));
					num2++;
					num3++;
					lbrows.get_Items().Add((object)i);
				}
				if (num3 == 30)
				{
					((Control)DGV).Refresh();
				}
				PBX1.set_Value(i);
			}
			PBX1.set_Value(0);
			if (((DataGridView)DGV).get_Rows().get_Count() != 0)
			{
				csmc0 = Conversions.ToString(((DataGridView)DGV).get_Rows().get_Item(0).get_Cells()
					.get_Item(1)
					.get_Value());
			}
			DataGridView datagv = (DataGridView)(object)DGV;
			Mod1.Jzpx(ref datagv);
			DGV = (DataGridViewX)datagv;
		}
	}

	private void lbcsx_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(Mod1.str1, lbcsx.get_Text(), false) != 0)
		{
			if ((Operators.CompareString(lbcsx.get_Text(), "动参数", false) == 0) | (Operators.CompareString(lbcsx.get_Text(), "动参数2", false) == 0))
			{
				Tool.SetToolTip((Control)(object)lbcsx, "右键功能");
			}
			MyProject.Forms.Pic.lblog.set_Text("");
			((Control)MyProject.Forms.Pic.lblog).Refresh();
			Mod1.str1 = lbcsx.get_Text();
			str2 = "";
			Mod1.o = checked(lbcsx.get_SelectedIndex() + 1);
			dislplay1();
			lbid.Refresh();
			Cbmp();
			if (!MyProject.Forms.Pic.ll_chkbmpfilter.get_Checked())
			{
				Addpic();
			}
			MyProject.Forms.Pic.lbtplb.Refresh();
			Application.DoEvents();
			if (!cbsddqid.get_Checked() && lbid.get_Items().get_Count() > 0)
			{
				lbid.set_SelectedIndex(0);
			}
			if (cbsddqid.get_Checked())
			{
				lbid_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (MyProject.Forms.Pic.lbtplb.get_Items().get_Count() == 0)
			{
				MyProject.Forms.Pic.PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
			}
			if (MyProject.Forms.Pic.ll_chkbmpfilter.get_Checked())
			{
				MyProject.Forms.Pic.lbtplb.get_Items().Clear();
				MyProject.Forms.Pic.ll_chkbmpfilter_CheckedChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}
	}

	private void lbid_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!cbsddqid.get_Checked())
		{
			((TextBox)tbdqid).set_Text(lbid.get_Text());
			((Control)tbdqid).Refresh();
		}
		id = ((TextBox)tbdqid).get_Text();
		checked
		{
			if (Operators.CompareString(str2, ((TextBox)tbdqid).get_Text(), false) != 0)
			{
				bjzt = false;
				((DataGridView)DGV).get_Columns().Clear();
				((DataGridView)DGV).get_Rows().Clear();
				lbrows.get_Items().Clear();
				str2 = ((TextBox)tbdqid).get_Text();
				int num = Mod1.countL - 1;
				Mod1.ba = 5;
				while (Mod1.ba <= num && !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, Mod1.ba], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)id, false))
				{
					Mod1.ba++;
				}
				dislplayID();
			}
			if (Operators.CompareString(((TextBox)tbdqid).get_Text(), "", false) != 0)
			{
				Mod1.curjmID = ((TextBox)tbdqid).get_Text();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void btncsyz_Click(object sender, EventArgs e)
	{
		if (File.Exists(Application.get_StartupPath() + "\\Temp\\check.ans"))
		{
			FileSystem.Kill(Application.get_StartupPath() + "\\Temp\\check.ans");
		}
		if (File.Exists(Application.get_StartupPath() + "\\Temp\\check.out"))
		{
			FileSystem.Kill(Application.get_StartupPath() + "\\Temp\\check.out");
		}
		if (File.Exists(Application.get_StartupPath() + "\\Temp\\cs.txt"))
		{
			FileSystem.Kill(Application.get_StartupPath() + "\\Temp\\cs.txt");
		}
		if (File.Exists(Application.get_StartupPath() + "\\Temp\\check.inf"))
		{
			FileSystem.Kill(Application.get_StartupPath() + "\\Temp\\check.inf");
		}
		string text = Strings.Trim(((TextBox)tbdqid).get_Text());
		string text2 = "当前验证的ID:" + text;
		lslog.get_Items().Add((object)text2);
		Mod1.wr = new StreamWriter(cstxt, append: false, Encoding.Default);
		int count = Mod1.wb.Worksheets.Count;
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			int H = default(int);
			for (int i = 1; i <= count; i++)
			{
				Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)i);
				if (!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(NewLateBinding.LateGet(Mod1.wb.Sheets[i], (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"动参数临时", false), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(Mod1.wb.Sheets[i], (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"参数校验", false))))
				{
					continue;
				}
				bool flag = true;
				try
				{
					enumerator = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
					while (enumerator.MoveNext())
					{
						Excel.Range range = (Excel.Range)enumerator.Current;
						string text3 = Conversions.ToString(range.get_Value((object)Missing.Value));
						if (Operators.CompareString(Strings.Trim(text3), "", false) != 0)
						{
							if (Operators.CompareString(Strings.UCase(Strings.Trim(text3)), Strings.UCase(Strings.Trim(((TextBox)tbdqid).get_Text())), false) == 0)
							{
								H = range.Column;
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
				Mod1.hang(ref H);
				if (unchecked(flag && H > 4 && H < 200))
				{
					int countH = Mod1.countH;
					for (int j = 2; j <= countH; j++)
					{
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, H], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0 && ((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0) & (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)))
						{
							Mod1.wr.WriteLine(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))) + "=" + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
						}
					}
				}
				Mod1.wr.WriteLine("");
			}
			Mod1.wr.Close();
			Mod1.wr.Dispose();
			lslog.get_Items().Add((object)"输出当前参数到文本文件:[双击可查看当前文件]");
			lslog.get_Items().Add((object)cstxt);
			StreamWriter streamWriter = new StreamWriter(Application.get_StartupPath() + "\\Temp\\check.ans", append: false, Encoding.Default);
			streamWriter.WriteLine("/input," + cstxt);
			streamWriter.WriteLine("*cfopen," + Application.get_StartupPath() + "\\Temp\\check.inf");
			int count2 = Mod1.wb.Worksheets.Count;
			IEnumerator enumerator2 = default(IEnumerator);
			for (int k = 1; k <= count2; k++)
			{
				Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)k);
				if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Mod1.wb.Sheets[k], (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"参数校验", false))
				{
					continue;
				}
				try
				{
					enumerator2 = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Excel.Range range = (Excel.Range)enumerator2.Current;
						string text3 = Conversions.ToString(range.get_Value((object)Missing.Value));
						if (Operators.CompareString(Strings.UCase(Strings.Trim(text3)), Strings.UCase(Strings.Trim(((TextBox)tbdqid).get_Text())), false) == 0)
						{
							H = range.Column;
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
				Mod1.hang(ref H);
				if (unchecked(H > 4 && H < 200))
				{
					int countH2 = Mod1.countH;
					for (int l = 2; l <= countH2; l++)
					{
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, H], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0 && ((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0) & (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0) & (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, 4], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)))
						{
							streamWriter.WriteLine("*if," + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))) + "," + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))) + "," + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, 4], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))) + ",then");
							streamWriter.WriteLine("*cfwrite,/com," + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[l, Mod1.countL], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
							streamWriter.WriteLine("*endif");
						}
					}
				}
				streamWriter.WriteLine("\r\n");
				break;
			}
			streamWriter.WriteLine("*cfclos");
			streamWriter.WriteLine("/exit");
			streamWriter.Close();
			streamWriter.Dispose();
			lslog.get_Items().Add((object)"输出当前参数到文本文件:[双击可查看当前文件]");
			lslog.get_Items().Add((object)(Application.get_StartupPath() + "\\Temp\\check.ans"));
			string text4 = Application.get_StartupPath() + "\\Temp\\check.inf";
			if (File.Exists(text4))
			{
				FileSystem.Kill(text4);
			}
			Interaction.Shell(Application.get_StartupPath() + "\\config\\csCheck.bat " + Application.get_StartupPath() + "\\Temp", (AppWinStyle)2, false, -1);
			text4 = Application.get_StartupPath() + "\\Temp\\check.out";
			text2 = "验证结果见文件:[双击可查看当前文件]";
			lslog.get_Items().Add((object)text2);
			text2 = text4;
			lslog.get_Items().Add((object)text2);
			text4 = Application.get_StartupPath() + "\\Temp\\check.inf";
			text2 = "验证结果见文件:[双击可查看当前文件]";
			lslog.get_Items().Add((object)text2);
			text2 = text4;
			lslog.get_Items().Add((object)text4);
			((Control)btntqjl).set_Enabled(true);
			if (lslog.get_Items().get_Count() != 0)
			{
				lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
			}
		}
	}

	private void btntqjl_Click(object sender, EventArgs e)
	{
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		string text = Application.get_StartupPath() + "\\Temp";
		string text2 = "";
		string path = text + "\\check.inf";
		int num = 0;
		checked
		{
			if (File.Exists(path))
			{
				Mod1.lr = new StreamReader(path, Encoding.Default);
				while (!Information.IsNothing((object)text2))
				{
					text2 = Mod1.lr.ReadLine();
					if (Information.IsNothing((object)text2))
					{
						break;
					}
					if (Operators.CompareString(text2, "", false) != 0)
					{
						lslog.get_Items().Add((object)text2);
						num++;
					}
				}
				Mod1.lr.Close();
				Mod1.lr.Dispose();
				if (num >= 1)
				{
					if (Operators.CompareString(Mod1.cswj, "截面i.xls", false) != 0)
					{
						((Control)btnbcjg).set_Enabled(false);
					}
					else
					{
						Mod1.Saved = true;
						((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(false);
					}
					string text3 = "共有" + Conversions.ToString(num) + "条参数关系不合理,请仔细检查录入的参数值.";
					lslog.get_Items().Add((object)text3);
					Interaction.MsgBox((object)(text3 + "详细的不合理信息见操作记录."), (MsgBoxStyle)48, (object)"提示");
					bcscheckok = false;
					((Control)btnbcjg).set_Enabled(false);
				}
				else
				{
					string text3 = "录入的参数值关系经初步检验是合理的.可以尝试进行模型驱动来进一步验证参数的合理性.";
					lslog.get_Items().Add((object)text3);
					if (Operators.CompareString(Mod1.cswj, "截面i.xls", false) != 0)
					{
						((Control)btnbcjg).set_Enabled(false);
						((Control)ll_btncurjmcheck).set_Enabled(false);
					}
					else
					{
						((Control)ll_btncurjmcheck).set_Enabled(true);
						((Control)btnbcjg).set_Enabled(true);
					}
					bcscheckok = true;
					Interaction.MsgBox((object)text3, (MsgBoxStyle)64, (object)"提示");
				}
			}
			else
			{
				lslog.get_Items().Add((object)"结果文件 check.inf 没有生成");
				((Control)ll_btncurjmcheck).set_Enabled(false);
				bcscheckok = false;
				((Control)btnbcjg).set_Enabled(false);
				Mod1.Saved = true;
				((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(false);
			}
			if (lslog.get_Items().get_Count() != 0)
			{
				lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
			}
		}
	}

	private void ll_btncurjmcheck_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (!bcscheckok)
		{
			Interaction.MsgBox((object)"当前参数校验没有通过,保存操作不能继续.", (MsgBoxStyle)64, (object)"提示");
			lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前参数校验没有通过,保存操作不能继续."));
			if (lslog.get_Items().get_Count() != 0)
			{
				lslog.set_SelectedIndex(checked(lslog.get_Items().get_Count() - 1));
			}
		}
		else
		{
			((Form)MyProject.Forms.ll_ufjmcheck).ShowDialog();
			((Component)(object)MyProject.Forms.ll_ufjmcheck).Dispose();
		}
	}

	private void btnbcjg_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (!bcscheckok)
		{
			Interaction.MsgBox((object)"当前参数校验没有通过,保存操作不能继续.", (MsgBoxStyle)64, (object)"提示");
			lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前参数校验没有通过,保存操作不能继续."));
			if (lslog.get_Items().get_Count() != 0)
			{
				lslog.set_SelectedIndex(checked(lslog.get_Items().get_Count() - 1));
			}
		}
		else
		{
			((Form)MyProject.Forms.jmsaveinfo).ShowDialog();
		}
	}

	private void btngb_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!bcscheckok && (int)MessageBox.Show("当前参数关系校验没有通过或没有进行,后续的处理向导操作将被禁止.", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64) == 6)
			{
				lslog.get_Items().Clear();
				((Form)this).Close();
				MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了参数编辑对话框"));
			}
			checked
			{
				if (lslog.get_Items().get_Count() != 0)
				{
					int num = lslog.get_Items().get_Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						MyProject.Forms.Main.lslog.get_Items().Add(RuntimeHelpers.GetObjectValue(lslog.get_Items().get_Item(i)));
					}
					if (!Mod1.Saved)
					{
						Interaction.MsgBox((object)"参数值已被修改，请及时保存！", (MsgBoxStyle)64, (object)"参数修改");
						((Form)this).Close();
					}
				}
				lslog.get_Items().Clear();
				((Form)this).Close();
				((Control)MyProject.Forms.canzhaolie).Hide();
				MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了参数编辑对话框"));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Addpic()
	{
		MyProject.Forms.Pic.lbtplb.get_Items().Clear();
		filename = Directory.GetFiles(Application.get_StartupPath() + "\\Temp\\", "*.GIF", SearchOption.AllDirectories);
		if (filename.Count() == 0)
		{
			return;
		}
		checked
		{
			int num = filename.Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = filename[i];
				text = text.Substring(text.LastIndexOf("\\") + 1);
				if (Strings.InStr(text, lbcsx.get_Text() + "Picture", (CompareMethod)0) != 0)
				{
					MyProject.Forms.Pic.lbtplb.get_Items().Add((object)text);
					MyProject.Forms.Pic.lbtplb.set_SelectedIndex(0);
				}
			}
		}
	}

	private void DGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		if (!bjzt)
		{
			return;
		}
		string text = Conversions.ToString(((DataGridView)DGV).get_Rows().get_Item(e.get_RowIndex()).get_Cells()
			.get_Item(0)
			.get_Value());
		string rowIndex = Conversions.ToString(lbrows.get_Items().get_Item(e.get_RowIndex()));
		string text2 = Strings.Trim(Conversions.ToString(((DataGridView)DGV).get_Rows().get_Item(e.get_RowIndex()).get_Cells()
			.get_Item(2)
			.get_Value()));
		checked
		{
			try
			{
				if (!Information.IsNothing((object)text2))
				{
					if (Operators.CompareString(Strings.Trim(text2), "", false) != 0)
					{
						Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)Mod1.o);
						Mod1.excelsheet.Activate();
						if (lslog.get_Items().get_Count() == 0)
						{
							MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前操作员对参数文件的修改如下："));
							lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 部件：" + Mod1.bjlb1 + " 的参数文件 " + Mod1.cswj + " 已被修改"));
						}
						lslog.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Conversions.ToString(DateTime.Now) + " 工作表：", "【"), lbcsx.get_Text()), "】"), " ID为："), lbid.get_Text()), " 第 "), text), " 行 "), "参数名称 "), csmc0), " 参数值 "), NewLateBinding.LateGet(Mod1.excelsheet.Cells[rowIndex, 3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" --> "), (object)text2));
						if (lslog.get_Items().get_Count() != 0)
						{
							lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
						}
						if (Operators.CompareString(MyProject.Forms.FrmOf.qyx, "qyxxn", false) == 0)
						{
							NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[rowIndex, 3], (Type)null, "Value", new object[1] { Strings.Trim(text2) }, (string[])null, (Type[])null, false, true);
							NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[rowIndex, 7], (Type)null, "Value", new object[1] { Strings.Trim(text2) }, (string[])null, (Type[])null, false, true);
						}
						else
						{
							NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[rowIndex, 3], (Type)null, "Value", new object[1] { Strings.Trim(text2) }, (string[])null, (Type[])null, false, true);
						}
						Mod1.biaoji = "";
						((Control)btnbcjg).set_Enabled(false);
						((Control)btntqjl).set_Enabled(false);
						((Control)ll_btncurjmcheck).set_Enabled(false);
						Mod1.Saved = false;
						((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(true);
						if (Operators.CompareString(Mod1.cswj, "截面i.xls", false) == 0)
						{
							Mod1.Saved = true;
							((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(false);
						}
						if (((Control)btncsyz).get_Enabled())
						{
							bcscheckok = false;
						}
					}
					else
					{
						bjzt = false;
						((DataGridView)DGV).get_Rows().get_Item(e.get_RowIndex()).get_Cells()
							.get_Item(2)
							.set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[rowIndex, 3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
						Interaction.MsgBox((object)"请输入一个有效的值！！", (MsgBoxStyle)64, (object)"提示");
					}
				}
				else
				{
					bjzt = false;
					((DataGridView)DGV).get_Rows().get_Item(e.get_RowIndex()).get_Cells()
						.get_Item(2)
						.set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[rowIndex, 3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
					Interaction.MsgBox((object)"请输入一个有效的值！！", (MsgBoxStyle)64, (object)"提示");
				}
				if (lslog.get_Items().get_Count() != 0)
				{
					lslog.set_SelectedIndex(lslog.get_Items().get_Count() - 1);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DGV_DoubleClick(object sender, EventArgs e)
	{
		bjzt = true;
	}

	private void CBX1_CheckedChanged(object sender, EventArgs e)
	{
		if (CBX1.get_Checked())
		{
			if (MyProject.Forms.Pic.lbtplb.get_Items().get_Count() == 0)
			{
				Addpic();
			}
			if (MyProject.Forms.Pic.lbtplb.get_Items().get_Count() != 0)
			{
				MyProject.Forms.Pic.PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\Temp\\" + MyProject.Forms.Pic.lbtplb.get_Text());
			}
			else
			{
				MyProject.Forms.Pic.PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
			}
			((Control)MyProject.Forms.Pic).Show();
		}
		else
		{
			((Control)MyProject.Forms.Pic).Hide();
		}
	}

	private void lslog_DoubleClick(object sender, EventArgs e)
	{
		if (File.Exists(lslog.get_Text()))
		{
			Process.Start(Interaction.Environ("windir") + "\\NOTEPAD.EXE", lslog.get_Text());
		}
	}

	private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.get_RowIndex() != -1)
		{
			csmc0 = Conversions.ToString(((DataGridView)DGV).get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(1)
				.get_Value());
		}
		if (MyProject.Forms.Pic.ll_chkbmpfilter.get_Checked())
		{
			MyProject.Forms.Pic.lblog.set_Text("");
			((Control)MyProject.Forms.Pic.lblog).Refresh();
			MyProject.Forms.Pic.ll_chkbmpfilter_CheckedChanged(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
		}
		if (((Control)CBchanzhao).get_Enabled() && Operators.CompareString(lbcsx.get_Text(), ((Form)MyProject.Forms.canzhaolie).get_Text(), false) == 0 && e.get_RowIndex() != -1 && ((DataGridView)MyProject.Forms.canzhaolie.CZDGV).get_Rows().get_Count() != 0)
		{
			((DataGridView)MyProject.Forms.canzhaolie.CZDGV).get_Rows().get_Item(e.get_RowIndex()).set_Selected(true);
		}
	}

	private void DGV_RowEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (((Control)CBchanzhao).get_Enabled() && Operators.CompareString(lbcsx.get_Text(), ((Form)MyProject.Forms.canzhaolie).get_Text(), false) == 0 && e.get_RowIndex() != -1 && ((DataGridView)MyProject.Forms.canzhaolie.CZDGV).get_Rows().get_Count() != 0)
		{
			((DataGridView)MyProject.Forms.canzhaolie.CZDGV).get_Rows().get_Item(e.get_RowIndex()).set_Selected(true);
		}
		DGV_CellClick(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cslr2_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Component)(object)MyProject.Forms.Pic).Dispose();
	}

	private void DGV_Click(object sender, EventArgs e)
	{
		bjzt = true;
	}

	private void cbsddqid_CheckedChanged(object sender, EventArgs e)
	{
		if (!cbsddqid.get_Checked())
		{
			if (Operators.CompareString(lbid.get_Text(), "", false) != 0)
			{
				((TextBox)tbdqid).set_Text(lbid.get_Text());
			}
			else
			{
				lbid.set_SelectedIndex(0);
			}
		}
	}

	private void lbcsx_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		if (((int)e.get_Button() == 2097152) & (Operators.CompareString(lbcsx.get_Text(), "动参数", false) == 0))
		{
			if ((int)MessageBox.Show("在创建的 [动参数] 表中进行当前数据的处理,继续吗?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) != 7)
			{
				string text = Application.get_StartupPath() + "\\config\\主臂动参数列表.ini";
				if (!File.Exists(text))
				{
					Interaction.MsgBox((object)("不存在文件" + text), (MsgBoxStyle)0, (object)"提示");
					return;
				}
				lslog.get_Items().Add((object)"【动参数】编辑功能启动.");
				((Form)MyProject.Forms.ll_ufzbdcsenhance).ShowDialog();
				((Component)(object)MyProject.Forms.ll_ufzbdcsenhance).Dispose();
			}
		}
		else if ((((int)e.get_Button() == 2097152) & (Operators.CompareString(lbcsx.get_Text(), "动参数2", false) == 0)) && (int)MessageBox.Show("继承 [动参数] 表中的相关参数值到 [动参数2], 是吗?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) != 7)
		{
			string text = Application.get_StartupPath() + "\\config\\主臂动参数列表2.ini";
			if (!File.Exists(text))
			{
				Interaction.MsgBox((object)("不存在文件" + text), (MsgBoxStyle)0, (object)"提示");
				return;
			}
			lslog.get_Items().Add((object)"【动参数2】编辑功能启动.即继承来自【动参数】中的参数值.");
			((Form)MyProject.Forms.ll_ufzbdcs2enhance).ShowDialog();
			((Component)(object)MyProject.Forms.ll_ufzbdcs2enhance).Dispose();
		}
	}

	private void CBchanzhao_CheckedChanged(object sender, EventArgs e)
	{
		if (CBchanzhao.get_Checked())
		{
			((Control)MyProject.Forms.canzhaolie).Show();
		}
		else
		{
			((Control)MyProject.Forms.canzhaolie).Hide();
		}
	}

	private void DGV_Scroll(object sender, ScrollEventArgs e)
	{
		if (Operators.CompareString(lbcsx.get_Text(), ((Form)MyProject.Forms.canzhaolie).get_Text(), false) == 0 && ((((DataGridView)MyProject.Forms.canzhaolie.CZDGV).get_Rows().get_Count() != 0) & (((DataGridView)MyProject.Forms.canzhaolie.CZDGV).get_FirstDisplayedScrollingRowIndex() != -1)))
		{
			((DataGridView)MyProject.Forms.canzhaolie.CZDGV).set_FirstDisplayedScrollingRowIndex(((DataGridView)DGV).get_FirstDisplayedScrollingRowIndex());
		}
	}
}
