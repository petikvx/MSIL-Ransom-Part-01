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
using DevComponents.Editors;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class ll_ufzbdcsenhance : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ll_txtnbj")]
	private IntegerInput _ll_txtnbj;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("ll_txtnx")]
	private IntegerInput _ll_txtnx;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("ll_txtns")]
	private IntegerInput _ll_txtns;

	[AccessedThroughProperty("ll_btnok")]
	private ButtonX _ll_btnok;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("tc1")]
	private TabControl _tc1;

	[AccessedThroughProperty("TabControlPanel1")]
	private TabControlPanel _TabControlPanel1;

	[AccessedThroughProperty("DGVNXN")]
	private DataGridViewX _DGVNXN;

	[AccessedThroughProperty("NXN")]
	private TabItem _NXN;

	[AccessedThroughProperty("TabControlPanel2")]
	private TabControlPanel _TabControlPanel2;

	[AccessedThroughProperty("DGVNXX")]
	private DataGridViewX _DGVNXX;

	[AccessedThroughProperty("NXX")]
	private TabItem _NXX;

	[AccessedThroughProperty("TabControlPanel3")]
	private TabControlPanel _TabControlPanel3;

	[AccessedThroughProperty("DGVNX")]
	private DataGridViewX _DGVNX;

	[AccessedThroughProperty("NX")]
	private TabItem _NX;

	[AccessedThroughProperty("TabControlPanel4")]
	private TabControlPanel _TabControlPanel4;

	[AccessedThroughProperty("DGVNS")]
	private DataGridViewX _DGVNS;

	[AccessedThroughProperty("NS")]
	private TabItem _NS;

	[AccessedThroughProperty("TabControlPanel5")]
	private TabControlPanel _TabControlPanel5;

	[AccessedThroughProperty("DGVBX")]
	private DataGridViewX _DGVBX;

	[AccessedThroughProperty("BX")]
	private TabItem _BX;

	[AccessedThroughProperty("ll_btnupdate2xls")]
	private ButtonX _ll_btnupdate2xls;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	[AccessedThroughProperty("ll_btnxls2cur")]
	private ButtonX _ll_btnxls2cur;

	private int curnbj;

	private int curns;

	private int curnx;

	private const string cntwidths = "50";

	private string[] ll_dcsname;

	private int curn;

	private bool bupdatenbj;

	private bool bupdatens;

	private bool bupdatenx;

	private int kk;

	private Worksheet sh;

	private int iitotal;

	private string[] nids;

	private string[] nids2xls;

	private Hashtable hax;

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

	internal virtual IntegerInput ll_txtnbj
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtnbj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtnbj = value;
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

	internal virtual IntegerInput ll_txtnx
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtnx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtnx = value;
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

	internal virtual IntegerInput ll_txtns
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtns;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtns = value;
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

	internal virtual TabControl tc1
	{
		[DebuggerNonUserCode]
		get
		{
			return _tc1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tc1 = value;
		}
	}

	internal virtual TabControlPanel TabControlPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControlPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControlPanel1 = value;
		}
	}

	internal virtual DataGridViewX DGVNXN
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVNXN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGVNXN = value;
		}
	}

	internal virtual TabItem NXN
	{
		[DebuggerNonUserCode]
		get
		{
			return _NXN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NXN = value;
		}
	}

	internal virtual TabControlPanel TabControlPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControlPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControlPanel2 = value;
		}
	}

	internal virtual DataGridViewX DGVNXX
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVNXX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGVNXX = value;
		}
	}

	internal virtual TabItem NXX
	{
		[DebuggerNonUserCode]
		get
		{
			return _NXX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NXX = value;
		}
	}

	internal virtual TabControlPanel TabControlPanel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControlPanel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControlPanel3 = value;
		}
	}

	internal virtual DataGridViewX DGVNX
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVNX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGVNX = value;
		}
	}

	internal virtual TabItem NX
	{
		[DebuggerNonUserCode]
		get
		{
			return _NX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NX = value;
		}
	}

	internal virtual TabControlPanel TabControlPanel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControlPanel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControlPanel4 = value;
		}
	}

	internal virtual DataGridViewX DGVNS
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVNS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGVNS = value;
		}
	}

	internal virtual TabItem NS
	{
		[DebuggerNonUserCode]
		get
		{
			return _NS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NS = value;
		}
	}

	internal virtual TabControlPanel TabControlPanel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControlPanel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControlPanel5 = value;
		}
	}

	internal virtual DataGridViewX DGVBX
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVBX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGVBX = value;
		}
	}

	internal virtual TabItem BX
	{
		[DebuggerNonUserCode]
		get
		{
			return _BX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BX = value;
		}
	}

	internal virtual ButtonX ll_btnupdate2xls
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnupdate2xls;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnupdate2xls_Click;
			if (_ll_btnupdate2xls != null)
			{
				((Control)_ll_btnupdate2xls).remove_Click(eventHandler);
			}
			_ll_btnupdate2xls = value;
			if (_ll_btnupdate2xls != null)
			{
				((Control)_ll_btnupdate2xls).add_Click(eventHandler);
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

	internal virtual ButtonX ll_btnxls2cur
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnxls2cur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnxls2cur_Click;
			if (_ll_btnxls2cur != null)
			{
				((Control)_ll_btnxls2cur).remove_Click(eventHandler);
			}
			_ll_btnxls2cur = value;
			if (_ll_btnxls2cur != null)
			{
				((Control)_ll_btnxls2cur).add_Click(eventHandler);
			}
		}
	}

	public ll_ufzbdcsenhance()
	{
		((Form)this).add_Load((EventHandler)ll_ufzbdcsenhance_Load);
		hax = new Hashtable();
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected O, but got Unknown
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Expected O, but got Unknown
		//IL_0c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7d: Expected O, but got Unknown
		//IL_0ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1030: Unknown result type (might be due to invalid IL or missing references)
		//IL_103a: Expected O, but got Unknown
		//IL_119f: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f7: Expected O, but got Unknown
		//IL_145c: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b7: Expected O, but got Unknown
		//IL_18c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d1: Expected O, but got Unknown
		//IL_19d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e3: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		LabelX1 = new LabelX();
		ll_txtnbj = new IntegerInput();
		LabelX2 = new LabelX();
		ll_txtnx = new IntegerInput();
		LabelX3 = new LabelX();
		ll_txtns = new IntegerInput();
		ll_btnok = new ButtonX();
		LabelX4 = new LabelX();
		LabelX5 = new LabelX();
		tc1 = new TabControl();
		TabControlPanel4 = new TabControlPanel();
		DGVNS = new DataGridViewX();
		NS = new TabItem(components);
		TabControlPanel5 = new TabControlPanel();
		DGVBX = new DataGridViewX();
		BX = new TabItem(components);
		TabControlPanel3 = new TabControlPanel();
		DGVNX = new DataGridViewX();
		NX = new TabItem(components);
		TabControlPanel1 = new TabControlPanel();
		DGVNXN = new DataGridViewX();
		NXN = new TabItem(components);
		TabControlPanel2 = new TabControlPanel();
		DGVNXX = new DataGridViewX();
		NXX = new TabItem(components);
		ll_btnupdate2xls = new ButtonX();
		ll_btnexit = new ButtonX();
		ll_btnxls2cur = new ButtonX();
		((ISupportInitialize)ll_txtnbj).BeginInit();
		((ISupportInitialize)ll_txtnx).BeginInit();
		((ISupportInitialize)ll_txtns).BeginInit();
		((ISupportInitialize)tc1).BeginInit();
		((Control)tc1).SuspendLayout();
		((Control)TabControlPanel4).SuspendLayout();
		((ISupportInitialize)DGVNS).BeginInit();
		((Control)TabControlPanel5).SuspendLayout();
		((ISupportInitialize)DGVBX).BeginInit();
		((Control)TabControlPanel3).SuspendLayout();
		((ISupportInitialize)DGVNX).BeginInit();
		((Control)TabControlPanel1).SuspendLayout();
		((ISupportInitialize)DGVNXN).BeginInit();
		((Control)TabControlPanel2).SuspendLayout();
		((ISupportInitialize)DGVNXX).BeginInit();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(12, 12);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(75, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("臂节数量");
		((VisualControlBase)ll_txtnbj).get_BackgroundStyle().set_Class("DateTimeInputBackground");
		((VisualControlBase)ll_txtnbj).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((NumericInputBase)ll_txtnbj).get_ButtonFreeText().set_Shortcut((eShortcut)113);
		IntegerInput obj = ll_txtnbj;
		location = new Point(70, 12);
		((Control)obj).set_Location(location);
		ll_txtnbj.set_MaxValue(9);
		ll_txtnbj.set_MinValue(3);
		((Control)ll_txtnbj).set_Name("ll_txtnbj");
		((NumericInputBase)ll_txtnbj).set_ShowUpDown(true);
		IntegerInput obj2 = ll_txtnbj;
		size = new Size(83, 21);
		((Control)obj2).set_Size(size);
		((Control)ll_txtnbj).set_TabIndex(1);
		ll_txtnbj.set_Value(7);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(12, 41);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(141, 23);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(0);
		LabelX2.set_Text("所有下盖板最多分段数量");
		((VisualControlBase)ll_txtnx).get_BackgroundStyle().set_Class("DateTimeInputBackground");
		((VisualControlBase)ll_txtnx).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((NumericInputBase)ll_txtnx).get_ButtonFreeText().set_Shortcut((eShortcut)113);
		IntegerInput obj3 = ll_txtnx;
		location = new Point(159, 41);
		((Control)obj3).set_Location(location);
		ll_txtnx.set_MaxValue(4);
		ll_txtnx.set_MinValue(1);
		((Control)ll_txtnx).set_Name("ll_txtnx");
		((NumericInputBase)ll_txtnx).set_ShowUpDown(true);
		IntegerInput obj4 = ll_txtnx;
		size = new Size(83, 21);
		((Control)obj4).set_Size(size);
		((Control)ll_txtnx).set_TabIndex(1);
		ll_txtnx.set_Value(3);
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX3;
		location = new Point(12, 70);
		((Control)labelX5).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX6 = LabelX3;
		size = new Size(141, 23);
		((Control)labelX6).set_Size(size);
		((Control)LabelX3).set_TabIndex(0);
		LabelX3.set_Text("所有上盖板最多分段数量");
		((VisualControlBase)ll_txtns).get_BackgroundStyle().set_Class("DateTimeInputBackground");
		((VisualControlBase)ll_txtns).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((NumericInputBase)ll_txtns).get_ButtonFreeText().set_Shortcut((eShortcut)113);
		IntegerInput obj5 = ll_txtns;
		location = new Point(159, 68);
		((Control)obj5).set_Location(location);
		ll_txtns.set_MaxValue(3);
		ll_txtns.set_MinValue(1);
		((Control)ll_txtns).set_Name("ll_txtns");
		((NumericInputBase)ll_txtns).set_ShowUpDown(true);
		IntegerInput obj6 = ll_txtns;
		size = new Size(83, 21);
		((Control)obj6).set_Size(size);
		((Control)ll_txtns).set_TabIndex(1);
		ll_txtns.set_Value(1);
		((Control)ll_btnok).set_AccessibleRole((AccessibleRole)43);
		ll_btnok.set_ColorTable((eButtonColor)3);
		ButtonX obj7 = ll_btnok;
		location = new Point(159, 99);
		((Control)obj7).set_Location(location);
		((Control)ll_btnok).set_Name("ll_btnok");
		ButtonX obj8 = ll_btnok;
		size = new Size(83, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)ll_btnok).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnok).set_TabIndex(2);
		ll_btnok.set_Text("创建");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX7 = LabelX4;
		location = new Point(248, 51);
		((Control)labelX7).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX8 = LabelX4;
		size = new Size(634, 42);
		((Control)labelX8).set_Size(size);
		((Control)LabelX4).set_TabIndex(0);
		LabelX4.set_Text("说明:\r\n创建成功后,编辑动参数的过程中充分运用[读入.. .]和[更新.. .]功能,对当前数据进行及时的保存和更新.");
		LabelX4.set_WordWrap(true);
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX9 = LabelX5;
		location = new Point(12, 99);
		((Control)labelX9).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX10 = LabelX5;
		size = new Size(95, 23);
		((Control)labelX10).set_Size(size);
		((Control)LabelX5).set_TabIndex(0);
		LabelX5.set_Text("动参数编辑区");
		((Control)tc1).set_Anchor((AnchorStyles)15);
		tc1.set_BackColor(Color.FromArgb(194, 217, 247));
		tc1.set_CanReorderTabs(true);
		((Control)tc1).get_Controls().Add((Control)(object)TabControlPanel5);
		((Control)tc1).get_Controls().Add((Control)(object)TabControlPanel4);
		((Control)tc1).get_Controls().Add((Control)(object)TabControlPanel1);
		((Control)tc1).get_Controls().Add((Control)(object)TabControlPanel3);
		((Control)tc1).get_Controls().Add((Control)(object)TabControlPanel2);
		TabControl obj9 = tc1;
		location = new Point(12, 128);
		((Control)obj9).set_Location(location);
		((Control)tc1).set_Name("tc1");
		tc1.set_SelectedTabFont(new Font("宋体", 9f, (FontStyle)1));
		tc1.set_SelectedTabIndex(4);
		TabControl obj10 = tc1;
		size = new Size(874, 328);
		((Control)obj10).set_Size(size);
		((Control)tc1).set_TabIndex(3);
		tc1.set_TabLayoutType((eTabLayoutType)1);
		tc1.get_Tabs().Add(NXN);
		tc1.get_Tabs().Add(NXX);
		tc1.get_Tabs().Add(NX);
		tc1.get_Tabs().Add(NS);
		tc1.get_Tabs().Add(BX);
		((Control)TabControlPanel4).get_Controls().Add((Control)(object)DGVNS);
		TabControlPanel4.set_Dock((DockStyle)5);
		TabControlPanel tabControlPanel = TabControlPanel4;
		location = new Point(0, 26);
		((Control)tabControlPanel).set_Location(location);
		((Control)TabControlPanel4).set_Name("TabControlPanel4");
		TabControlPanel tabControlPanel2 = TabControlPanel4;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(1);
		((Control)tabControlPanel2).set_Padding(padding);
		TabControlPanel tabControlPanel3 = TabControlPanel4;
		size = new Size(874, 302);
		((Control)tabControlPanel3).set_Size(size);
		((PanelEx)TabControlPanel4).get_Style().get_BackColor1().set_Color(Color.FromArgb(142, 179, 231));
		((PanelEx)TabControlPanel4).get_Style().get_BackColor2().set_Color(Color.FromArgb(223, 237, 254));
		((PanelEx)TabControlPanel4).get_Style().set_Border((eBorderType)1);
		((PanelEx)TabControlPanel4).get_Style().get_BorderColor().set_Color(Color.FromArgb(59, 97, 156));
		((PanelEx)TabControlPanel4).get_Style().set_BorderSide((eBorderSide)11);
		((PanelEx)TabControlPanel4).get_Style().set_GradientAngle(90);
		((Control)TabControlPanel4).set_TabIndex(4);
		TabControlPanel4.set_TabItem(NS);
		((DataGridView)DGVNS).set_AllowUserToAddRows(false);
		((DataGridView)DGVNS).set_AllowUserToDeleteRows(false);
		((DataGridView)DGVNS).set_AllowUserToResizeRows(false);
		((Control)DGVNS).set_Anchor((AnchorStyles)15);
		((DataGridView)DGVNS).set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)1);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Window);
		val.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val.set_ForeColor(SystemColors.ControlText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.ControlText);
		val.set_WrapMode((DataGridViewTriState)2);
		((DataGridView)DGVNS).set_DefaultCellStyle(val);
		((DataGridView)DGVNS).set_GridColor(Color.FromArgb(208, 215, 229));
		DataGridViewX dGVNS = DGVNS;
		location = new Point(4, 1);
		((Control)dGVNS).set_Location(location);
		((DataGridView)DGVNS).set_MultiSelect(false);
		((Control)DGVNS).set_Name("DGVNS");
		((DataGridView)DGVNS).get_RowTemplate().set_Height(23);
		((DataGridView)DGVNS).set_SelectionMode((DataGridViewSelectionMode)1);
		DataGridViewX dGVNS2 = DGVNS;
		size = new Size(866, 298);
		((Control)dGVNS2).set_Size(size);
		((Control)DGVNS).set_TabIndex(5);
		((Control)DGVNS).set_Tag((object)"3");
		NS.set_AttachedControl((Control)(object)TabControlPanel4);
		NS.set_Name("NS");
		NS.set_Text("[ns]");
		((Control)TabControlPanel5).get_Controls().Add((Control)(object)DGVBX);
		TabControlPanel5.set_Dock((DockStyle)5);
		TabControlPanel tabControlPanel4 = TabControlPanel5;
		location = new Point(0, 26);
		((Control)tabControlPanel4).set_Location(location);
		((Control)TabControlPanel5).set_Name("TabControlPanel5");
		TabControlPanel tabControlPanel5 = TabControlPanel5;
		((Padding)(ref padding))._002Ector(1);
		((Control)tabControlPanel5).set_Padding(padding);
		TabControlPanel tabControlPanel6 = TabControlPanel5;
		size = new Size(874, 302);
		((Control)tabControlPanel6).set_Size(size);
		((PanelEx)TabControlPanel5).get_Style().get_BackColor1().set_Color(Color.FromArgb(142, 179, 231));
		((PanelEx)TabControlPanel5).get_Style().get_BackColor2().set_Color(Color.FromArgb(223, 237, 254));
		((PanelEx)TabControlPanel5).get_Style().set_Border((eBorderType)1);
		((PanelEx)TabControlPanel5).get_Style().get_BorderColor().set_Color(Color.FromArgb(59, 97, 156));
		((PanelEx)TabControlPanel5).get_Style().set_BorderSide((eBorderSide)11);
		((PanelEx)TabControlPanel5).get_Style().set_GradientAngle(90);
		((Control)TabControlPanel5).set_TabIndex(5);
		TabControlPanel5.set_TabItem(BX);
		((DataGridView)DGVBX).set_AllowUserToAddRows(false);
		((DataGridView)DGVBX).set_AllowUserToDeleteRows(false);
		((DataGridView)DGVBX).set_AllowUserToResizeRows(false);
		((Control)DGVBX).set_Anchor((AnchorStyles)15);
		((DataGridView)DGVBX).set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)1);
		val2.set_Alignment((DataGridViewContentAlignment)16);
		val2.set_BackColor(SystemColors.Window);
		val2.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val2.set_ForeColor(SystemColors.ControlText);
		val2.set_SelectionBackColor(SystemColors.Highlight);
		val2.set_SelectionForeColor(SystemColors.ControlText);
		val2.set_WrapMode((DataGridViewTriState)2);
		((DataGridView)DGVBX).set_DefaultCellStyle(val2);
		((DataGridView)DGVBX).set_GridColor(Color.FromArgb(208, 215, 229));
		DataGridViewX dGVBX = DGVBX;
		location = new Point(4, 1);
		((Control)dGVBX).set_Location(location);
		((DataGridView)DGVBX).set_MultiSelect(false);
		((Control)DGVBX).set_Name("DGVBX");
		((DataGridView)DGVBX).get_RowTemplate().set_Height(23);
		((DataGridView)DGVBX).set_SelectionMode((DataGridViewSelectionMode)1);
		DataGridViewX dGVBX2 = DGVBX;
		size = new Size(866, 298);
		((Control)dGVBX2).set_Size(size);
		((Control)DGVBX).set_TabIndex(5);
		((Control)DGVBX).set_Tag((object)"4");
		BX.set_AttachedControl((Control)(object)TabControlPanel5);
		BX.set_Name("BX");
		BX.set_Text("[bx]");
		((Control)TabControlPanel3).get_Controls().Add((Control)(object)DGVNX);
		TabControlPanel3.set_Dock((DockStyle)5);
		TabControlPanel tabControlPanel7 = TabControlPanel3;
		location = new Point(0, 26);
		((Control)tabControlPanel7).set_Location(location);
		((Control)TabControlPanel3).set_Name("TabControlPanel3");
		TabControlPanel tabControlPanel8 = TabControlPanel3;
		((Padding)(ref padding))._002Ector(1);
		((Control)tabControlPanel8).set_Padding(padding);
		TabControlPanel tabControlPanel9 = TabControlPanel3;
		size = new Size(874, 302);
		((Control)tabControlPanel9).set_Size(size);
		((PanelEx)TabControlPanel3).get_Style().get_BackColor1().set_Color(Color.FromArgb(142, 179, 231));
		((PanelEx)TabControlPanel3).get_Style().get_BackColor2().set_Color(Color.FromArgb(223, 237, 254));
		((PanelEx)TabControlPanel3).get_Style().set_Border((eBorderType)1);
		((PanelEx)TabControlPanel3).get_Style().get_BorderColor().set_Color(Color.FromArgb(59, 97, 156));
		((PanelEx)TabControlPanel3).get_Style().set_BorderSide((eBorderSide)11);
		((PanelEx)TabControlPanel3).get_Style().set_GradientAngle(90);
		((Control)TabControlPanel3).set_TabIndex(3);
		TabControlPanel3.set_TabItem(NX);
		((DataGridView)DGVNX).set_AllowUserToAddRows(false);
		((DataGridView)DGVNX).set_AllowUserToDeleteRows(false);
		((DataGridView)DGVNX).set_AllowUserToResizeRows(false);
		((Control)DGVNX).set_Anchor((AnchorStyles)15);
		((DataGridView)DGVNX).set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)1);
		val3.set_Alignment((DataGridViewContentAlignment)16);
		val3.set_BackColor(SystemColors.Window);
		val3.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val3.set_ForeColor(SystemColors.ControlText);
		val3.set_SelectionBackColor(SystemColors.Highlight);
		val3.set_SelectionForeColor(SystemColors.ControlText);
		val3.set_WrapMode((DataGridViewTriState)2);
		((DataGridView)DGVNX).set_DefaultCellStyle(val3);
		((DataGridView)DGVNX).set_GridColor(Color.FromArgb(208, 215, 229));
		DataGridViewX dGVNX = DGVNX;
		location = new Point(4, 1);
		((Control)dGVNX).set_Location(location);
		((DataGridView)DGVNX).set_MultiSelect(false);
		((Control)DGVNX).set_Name("DGVNX");
		((DataGridView)DGVNX).get_RowTemplate().set_Height(23);
		((DataGridView)DGVNX).set_SelectionMode((DataGridViewSelectionMode)1);
		DataGridViewX dGVNX2 = DGVNX;
		size = new Size(866, 298);
		((Control)dGVNX2).set_Size(size);
		((Control)DGVNX).set_TabIndex(4);
		((Control)DGVNX).set_Tag((object)"2");
		NX.set_AttachedControl((Control)(object)TabControlPanel3);
		NX.set_Name("NX");
		NX.set_Text("[nx]");
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)DGVNXN);
		TabControlPanel1.set_Dock((DockStyle)5);
		TabControlPanel tabControlPanel10 = TabControlPanel1;
		location = new Point(0, 26);
		((Control)tabControlPanel10).set_Location(location);
		((Control)TabControlPanel1).set_Name("TabControlPanel1");
		TabControlPanel tabControlPanel11 = TabControlPanel1;
		((Padding)(ref padding))._002Ector(1);
		((Control)tabControlPanel11).set_Padding(padding);
		TabControlPanel tabControlPanel12 = TabControlPanel1;
		size = new Size(874, 302);
		((Control)tabControlPanel12).set_Size(size);
		((PanelEx)TabControlPanel1).get_Style().get_BackColor1().set_Color(Color.FromArgb(142, 179, 231));
		((PanelEx)TabControlPanel1).get_Style().get_BackColor2().set_Color(Color.FromArgb(223, 237, 254));
		((PanelEx)TabControlPanel1).get_Style().set_Border((eBorderType)1);
		((PanelEx)TabControlPanel1).get_Style().get_BorderColor().set_Color(Color.FromArgb(59, 97, 156));
		((PanelEx)TabControlPanel1).get_Style().set_BorderSide((eBorderSide)11);
		((PanelEx)TabControlPanel1).get_Style().set_GradientAngle(90);
		((Control)TabControlPanel1).set_TabIndex(1);
		TabControlPanel1.set_TabItem(NXN);
		((DataGridView)DGVNXN).set_AllowUserToAddRows(false);
		((DataGridView)DGVNXN).set_AllowUserToDeleteRows(false);
		((DataGridView)DGVNXN).set_AllowUserToResizeRows(false);
		((Control)DGVNXN).set_Anchor((AnchorStyles)15);
		((DataGridView)DGVNXN).set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)1);
		val4.set_Alignment((DataGridViewContentAlignment)16);
		val4.set_BackColor(SystemColors.Window);
		val4.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val4.set_ForeColor(SystemColors.ControlText);
		val4.set_SelectionBackColor(SystemColors.Highlight);
		val4.set_SelectionForeColor(SystemColors.ControlText);
		val4.set_WrapMode((DataGridViewTriState)2);
		((DataGridView)DGVNXN).set_DefaultCellStyle(val4);
		((DataGridView)DGVNXN).set_GridColor(Color.FromArgb(208, 215, 229));
		DataGridViewX dGVNXN = DGVNXN;
		location = new Point(4, 1);
		((Control)dGVNXN).set_Location(location);
		((DataGridView)DGVNXN).set_MultiSelect(false);
		((Control)DGVNXN).set_Name("DGVNXN");
		((DataGridView)DGVNXN).get_RowTemplate().set_Height(23);
		((DataGridView)DGVNXN).set_SelectionMode((DataGridViewSelectionMode)1);
		DataGridViewX dGVNXN2 = DGVNXN;
		size = new Size(866, 298);
		((Control)dGVNXN2).set_Size(size);
		((Control)DGVNXN).set_TabIndex(0);
		((Control)DGVNXN).set_Tag((object)"0");
		NXN.set_AttachedControl((Control)(object)TabControlPanel1);
		NXN.set_Name("NXN");
		NXN.set_Text("[nxn]");
		((Control)TabControlPanel2).get_Controls().Add((Control)(object)DGVNXX);
		TabControlPanel2.set_Dock((DockStyle)5);
		TabControlPanel tabControlPanel13 = TabControlPanel2;
		location = new Point(0, 26);
		((Control)tabControlPanel13).set_Location(location);
		((Control)TabControlPanel2).set_Name("TabControlPanel2");
		TabControlPanel tabControlPanel14 = TabControlPanel2;
		((Padding)(ref padding))._002Ector(1);
		((Control)tabControlPanel14).set_Padding(padding);
		TabControlPanel tabControlPanel15 = TabControlPanel2;
		size = new Size(874, 302);
		((Control)tabControlPanel15).set_Size(size);
		((PanelEx)TabControlPanel2).get_Style().get_BackColor1().set_Color(Color.FromArgb(142, 179, 231));
		((PanelEx)TabControlPanel2).get_Style().get_BackColor2().set_Color(Color.FromArgb(223, 237, 254));
		((PanelEx)TabControlPanel2).get_Style().set_Border((eBorderType)1);
		((PanelEx)TabControlPanel2).get_Style().get_BorderColor().set_Color(Color.FromArgb(59, 97, 156));
		((PanelEx)TabControlPanel2).get_Style().set_BorderSide((eBorderSide)11);
		((PanelEx)TabControlPanel2).get_Style().set_GradientAngle(90);
		((Control)TabControlPanel2).set_TabIndex(2);
		TabControlPanel2.set_TabItem(NXX);
		((DataGridView)DGVNXX).set_AllowUserToAddRows(false);
		((DataGridView)DGVNXX).set_AllowUserToDeleteRows(false);
		((DataGridView)DGVNXX).set_AllowUserToResizeRows(false);
		((Control)DGVNXX).set_Anchor((AnchorStyles)15);
		((DataGridView)DGVNXX).set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)1);
		val5.set_Alignment((DataGridViewContentAlignment)16);
		val5.set_BackColor(SystemColors.Window);
		val5.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val5.set_ForeColor(SystemColors.ControlText);
		val5.set_SelectionBackColor(SystemColors.Highlight);
		val5.set_SelectionForeColor(SystemColors.ControlText);
		val5.set_WrapMode((DataGridViewTriState)2);
		((DataGridView)DGVNXX).set_DefaultCellStyle(val5);
		((DataGridView)DGVNXX).set_GridColor(Color.FromArgb(208, 215, 229));
		DataGridViewX dGVNXX = DGVNXX;
		location = new Point(4, 1);
		((Control)dGVNXX).set_Location(location);
		((DataGridView)DGVNXX).set_MultiSelect(false);
		((Control)DGVNXX).set_Name("DGVNXX");
		((DataGridView)DGVNXX).get_RowTemplate().set_Height(23);
		((DataGridView)DGVNXX).set_SelectionMode((DataGridViewSelectionMode)1);
		DataGridViewX dGVNXX2 = DGVNXX;
		size = new Size(866, 298);
		((Control)dGVNXX2).set_Size(size);
		((Control)DGVNXX).set_TabIndex(1);
		((Control)DGVNXX).set_Tag((object)"1");
		NXX.set_AttachedControl((Control)(object)TabControlPanel2);
		NXX.set_Name("NXX");
		NXX.set_Text("[nxx]");
		((Control)ll_btnupdate2xls).set_AccessibleRole((AccessibleRole)43);
		((Control)ll_btnupdate2xls).set_Anchor((AnchorStyles)10);
		ll_btnupdate2xls.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = ll_btnupdate2xls;
		location = new Point(559, 461);
		((Control)obj11).set_Location(location);
		((Control)ll_btnupdate2xls).set_Name("ll_btnupdate2xls");
		ButtonX obj12 = ll_btnupdate2xls;
		size = new Size(177, 26);
		((Control)obj12).set_Size(size);
		((PopupItemControl)ll_btnupdate2xls).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnupdate2xls).set_TabIndex(2);
		ll_btnupdate2xls.set_Text("更新当前数据至动参数表中");
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		((Control)ll_btnexit).set_Anchor((AnchorStyles)10);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ll_btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj13 = ll_btnexit;
		location = new Point(742, 461);
		((Control)obj13).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj14 = ll_btnexit;
		size = new Size(144, 26);
		((Control)obj14).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(2);
		ll_btnexit.set_Text("关闭");
		((Control)ll_btnxls2cur).set_AccessibleRole((AccessibleRole)43);
		((Control)ll_btnxls2cur).set_Anchor((AnchorStyles)10);
		ll_btnxls2cur.set_ColorTable((eButtonColor)3);
		ButtonX obj15 = ll_btnxls2cur;
		location = new Point(376, 461);
		((Control)obj15).set_Location(location);
		((Control)ll_btnxls2cur).set_Name("ll_btnxls2cur");
		ButtonX obj16 = ll_btnxls2cur;
		size = new Size(177, 26);
		((Control)obj16).set_Size(size);
		((PopupItemControl)ll_btnxls2cur).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnxls2cur).set_TabIndex(2);
		ll_btnxls2cur.set_Text("读入动参数表中数据到当前");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(898, 491);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)tc1);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_btnxls2cur);
		((Control)this).get_Controls().Add((Control)(object)ll_btnupdate2xls);
		((Control)this).get_Controls().Add((Control)(object)ll_btnok);
		((Control)this).get_Controls().Add((Control)(object)ll_txtns);
		((Control)this).get_Controls().Add((Control)(object)ll_txtnx);
		((Control)this).get_Controls().Add((Control)(object)ll_txtnbj);
		((Control)this).get_Controls().Add((Control)(object)LabelX5);
		((Control)this).get_Controls().Add((Control)(object)LabelX3);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX4);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Control)this).set_Name("ll_ufzbdcsenhance");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("动参数页面创建.. .");
		((ISupportInitialize)ll_txtnbj).EndInit();
		((ISupportInitialize)ll_txtnx).EndInit();
		((ISupportInitialize)ll_txtns).EndInit();
		((ISupportInitialize)tc1).EndInit();
		tc1.ResumeLayout(false);
		((Control)TabControlPanel4).ResumeLayout(false);
		((ISupportInitialize)DGVNS).EndInit();
		((Control)TabControlPanel5).ResumeLayout(false);
		((ISupportInitialize)DGVBX).EndInit();
		((Control)TabControlPanel3).ResumeLayout(false);
		((ISupportInitialize)DGVNX).EndInit();
		((Control)TabControlPanel1).ResumeLayout(false);
		((ISupportInitialize)DGVNXN).EndInit();
		((Control)TabControlPanel2).ResumeLayout(false);
		((ISupportInitialize)DGVNXX).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void ll_ufzbdcsenhance_Load(object sender, EventArgs e)
	{
		tc1.set_SelectedTabIndex(0);
	}

	private void ll_btnok_Click(object sender, EventArgs e)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Invalid comparison between Unknown and I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Invalid comparison between Unknown and I4
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c14: Expected O, but got Unknown
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected O, but got Unknown
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4c: Expected O, but got Unknown
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c68: Expected O, but got Unknown
		//IL_0c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected O, but got Unknown
		bupdatenbj = false;
		bupdatens = false;
		bupdatenx = false;
		if (curnbj == 0)
		{
			curnbj = ll_txtnbj.get_Value();
			curnx = ll_txtnx.get_Value();
			curns = ll_txtns.get_Value();
			bupdatenbj = true;
			bupdatens = true;
			bupdatenx = true;
		}
		else
		{
			if (curnbj != ll_txtnbj.get_Value())
			{
				bupdatenbj = true;
			}
			if (curns != ll_txtns.get_Value())
			{
				bupdatens = true;
			}
			if (curnx != ll_txtnx.get_Value())
			{
				bupdatenx = true;
			}
			if (bupdatenbj)
			{
				if ((int)MessageBox.Show("当前 [臂节数量] 已更新,继续操作将会重建当前所有数据库.. .", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32) == 7)
				{
					ll_txtnbj.set_Value(curnbj);
					return;
				}
				curnbj = ll_txtnbj.get_Value();
				curnx = ll_txtnx.get_Value();
				curns = ll_txtns.get_Value();
				((DataGridView)DGVNXN).get_Columns().Clear();
				((DataGridView)DGVBX).get_Columns().Clear();
				((DataGridView)DGVNS).get_Columns().Clear();
				((DataGridView)DGVNX).get_Columns().Clear();
				((DataGridView)DGVNXX).get_Columns().Clear();
			}
			else
			{
				if (bupdatenx)
				{
					if ((int)MessageBox.Show("当前 [所有下盖板最多分段数量] 已更新,继续操作将会重建当前 [nx] 数据库.. .", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32) == 7)
					{
						ll_txtnx.set_Value(curnx);
						return;
					}
					curnx = ll_txtnx.get_Value();
					((DataGridView)DGVNXN).get_Columns().Clear();
					((DataGridView)DGVBX).get_Columns().Clear();
					((DataGridView)DGVNS).get_Columns().Clear();
					((DataGridView)DGVNX).get_Columns().Clear();
					((DataGridView)DGVNXX).get_Columns().Clear();
				}
				if (bupdatens)
				{
					if ((int)MessageBox.Show("当前 [所有上盖板最多分段数量] 已更新,继续操作将会重建当前 [ns] 数据库.. .", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32) == 7)
					{
						ll_txtns.set_Value(curns);
						return;
					}
					curns = ll_txtns.get_Value();
					((DataGridView)DGVNXN).get_Columns().Clear();
					((DataGridView)DGVBX).get_Columns().Clear();
					((DataGridView)DGVNS).get_Columns().Clear();
					((DataGridView)DGVNX).get_Columns().Clear();
					((DataGridView)DGVNXX).get_Columns().Clear();
				}
			}
		}
		if (!bupdatens & !bupdatenx & !bupdatenbj)
		{
			return;
		}
		bupdatens = true;
		bupdatenx = true;
		bupdatenbj = true;
		string text = Application.get_StartupPath() + "\\config\\主臂动参数列表.ini";
		if (!File.Exists(text))
		{
			Interaction.MsgBox((object)("文件不存在!" + text), (MsgBoxStyle)0, (object)"提示");
			return;
		}
		((DataGridView)DGVNXN).get_Columns().Add("参数名称", "参数名称");
		((DataGridView)DGVNXN).get_Columns().get_Item(0).set_ReadOnly(true);
		((DataGridView)DGVBX).get_Columns().Add("参数名称", "参数名称");
		((DataGridView)DGVBX).get_Columns().get_Item(0).set_ReadOnly(true);
		((DataGridView)DGVNS).get_Columns().Add("参数名称", "参数名称");
		((DataGridView)DGVNS).get_Columns().get_Item(0).set_ReadOnly(true);
		((DataGridView)DGVNX).get_Columns().Add("参数名称", "参数名称");
		((DataGridView)DGVNX).get_Columns().get_Item(0).set_ReadOnly(true);
		((DataGridView)DGVNXX).get_Columns().Add("参数名称", "参数名称");
		((DataGridView)DGVNXX).get_Columns().get_Item(0).set_ReadOnly(true);
		int num = curnbj;
		checked
		{
			for (int i = 1; i <= num; i++)
			{
				((DataGridView)DGVNXN).get_Columns().Add("臂节" + Conversions.ToString(i), "臂节" + Conversions.ToString(i));
				((DataGridView)DGVBX).get_Columns().Add("臂节" + Conversions.ToString(i), "臂节" + Conversions.ToString(i));
				((DataGridView)DGVNS).get_Columns().Add("臂节" + Conversions.ToString(i), "臂节" + Conversions.ToString(i));
				((DataGridView)DGVNX).get_Columns().Add("臂节" + Conversions.ToString(i), "臂节" + Conversions.ToString(i));
				((DataGridView)DGVNXX).get_Columns().Add("臂节" + Conversions.ToString(i), "臂节" + Conversions.ToString(i));
			}
			((DataGridView)DGVNXN).get_Columns().Add("备注", "备注");
			((DataGridView)DGVNXN).get_Columns().get_Item(curnbj + 1).set_ReadOnly(true);
			((DataGridView)DGVBX).get_Columns().Add("备注", "备注");
			((DataGridView)DGVBX).get_Columns().get_Item(curnbj + 1).set_ReadOnly(true);
			((DataGridView)DGVNS).get_Columns().Add("备注", "备注");
			((DataGridView)DGVNS).get_Columns().get_Item(curnbj + 1).set_ReadOnly(true);
			((DataGridView)DGVNX).get_Columns().Add("备注", "备注");
			((DataGridView)DGVNX).get_Columns().get_Item(curnbj + 1).set_ReadOnly(true);
			((DataGridView)DGVNXX).get_Columns().Add("备注", "备注");
			((DataGridView)DGVNXX).get_Columns().get_Item(curnbj + 1).set_ReadOnly(true);
			Mod1.lr = new StreamReader(text, Encoding.Default);
			string text2 = "";
			while (!Information.IsNothing((object)text2))
			{
				text2 = Mod1.lr.ReadLine();
				if (Information.IsNothing((object)text2))
				{
					break;
				}
				if (Operators.CompareString(Strings.Trim(text2), "", false) == 0)
				{
					continue;
				}
				string[] array = Strings.Split(text2, "=", -1, (CompareMethod)0);
				if (Information.UBound((Array)array, 1) < 1 || Conversions.ToInteger(array[1]) == 0)
				{
					continue;
				}
				switch (Strings.LCase(Strings.Trim(array[0])))
				{
				case "[nid]":
				{
					int num2 = Conversions.ToInteger(array[1]);
					nids = new string[num2 - 1 + 1];
					int num4 = num2 - 1;
					for (int k = 0; k <= num4; k++)
					{
						nids[k] = Mod1.lr.ReadLine();
					}
					break;
				}
				case "[nids2xls]":
				{
					int num2 = Conversions.ToInteger(array[1]);
					nids2xls = new string[num2 - 1 + 1];
					int num10 = num2 - 1;
					for (int num11 = 0; num11 <= num10; num11++)
					{
						nids2xls[num11] = Mod1.lr.ReadLine();
					}
					break;
				}
				case "[nxn]":
					if (bupdatenbj)
					{
						int num2 = Conversions.ToInteger(array[1]);
						int num5 = num2 - 1;
						for (int l = 0; l <= num5; l++)
						{
							text2 = Mod1.lr.ReadLine();
							array = Strings.Split(text2, ",", -1, (CompareMethod)0);
							((DataGridView)DGVNXN).get_Rows().Add();
							((DataGridView)DGVNXN).get_Rows().get_Item(l).get_Cells()
								.get_Item(0)
								.set_Value((object)array[0]);
							((DataGridView)DGVNXN).get_Rows().get_Item(l).get_Cells()
								.get_Item(curnbj + 1)
								.set_Value((object)array[1]);
						}
					}
					break;
				case "[nxx]":
					if (bupdatenbj)
					{
						int num2 = Conversions.ToInteger(array[1]);
						int num8 = num2 - 1;
						for (int num9 = 0; num9 <= num8; num9++)
						{
							text2 = Mod1.lr.ReadLine();
							array = Strings.Split(text2, ",", -1, (CompareMethod)0);
							((DataGridView)DGVNXX).get_Rows().Add();
							((DataGridView)DGVNXX).get_Rows().get_Item(num9).get_Cells()
								.get_Item(0)
								.set_Value((object)array[0]);
							((DataGridView)DGVNXX).get_Rows().get_Item(num9).get_Cells()
								.get_Item(curnbj + 1)
								.set_Value((object)array[1]);
						}
					}
					break;
				case "[nx]":
				{
					if (!(bupdatenx | bupdatenbj))
					{
						break;
					}
					int num2 = Conversions.ToInteger(array[1]);
					kk = 0;
					int num12 = num2 - 1;
					for (int num13 = 0; num13 <= num12; num13++)
					{
						text2 = Mod1.lr.ReadLine();
						array = Strings.Split(text2, ",", -1, (CompareMethod)0);
						int num14 = curnx;
						for (int num15 = 1; num15 <= num14; num15++)
						{
							((DataGridView)DGVNX).get_Rows().Add();
							((DataGridView)DGVNX).get_Rows().get_Item(kk).get_Cells()
								.get_Item(0)
								.set_Value((object)Strings.Replace(array[0], "j", Conversions.ToString(num15), 1, -1, (CompareMethod)0));
							((DataGridView)DGVNX).get_Rows().get_Item(kk).get_Cells()
								.get_Item(curnbj + 1)
								.set_Value((object)array[1]);
							kk++;
						}
					}
					break;
				}
				case "[ns]":
				{
					if (!(bupdatens | bupdatenbj))
					{
						break;
					}
					int num2 = Conversions.ToInteger(array[1]);
					kk = 0;
					int num6 = num2 - 1;
					for (int m = 0; m <= num6; m++)
					{
						text2 = Mod1.lr.ReadLine();
						array = Strings.Split(text2, ",", -1, (CompareMethod)0);
						int num7 = curns;
						for (int n = 1; n <= num7; n++)
						{
							((DataGridView)DGVNS).get_Rows().Add();
							((DataGridView)DGVNS).get_Rows().get_Item(kk).get_Cells()
								.get_Item(0)
								.set_Value((object)Strings.Replace(array[0], "j", Conversions.ToString(n), 1, -1, (CompareMethod)0));
							((DataGridView)DGVNS).get_Rows().get_Item(kk).get_Cells()
								.get_Item(curnbj + 1)
								.set_Value((object)array[1]);
							kk++;
						}
					}
					break;
				}
				case "[bx]":
					if (bupdatenbj)
					{
						int num2 = Conversions.ToInteger(array[1]);
						int num3 = num2 - 1;
						for (int j = 0; j <= num3; j++)
						{
							text2 = Mod1.lr.ReadLine();
							array = Strings.Split(text2, ",", -1, (CompareMethod)0);
							((DataGridView)DGVBX).get_Rows().Add();
							((DataGridView)DGVBX).get_Rows().get_Item(j).get_Cells()
								.get_Item(0)
								.set_Value((object)array[0]);
							((DataGridView)DGVBX).get_Rows().get_Item(j).get_Cells()
								.get_Item(curnbj + 1)
								.set_Value((object)array[1]);
						}
					}
					break;
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			DataGridView datagv = (DataGridView)(object)DGVNXN;
			Mod1.Jzpx(ref datagv);
			DGVNXN = (DataGridViewX)datagv;
			datagv = (DataGridView)(object)DGVBX;
			Mod1.Jzpx(ref datagv);
			DGVBX = (DataGridViewX)datagv;
			datagv = (DataGridView)(object)DGVNS;
			Mod1.Jzpx(ref datagv);
			DGVNS = (DataGridViewX)datagv;
			datagv = (DataGridView)(object)DGVNX;
			Mod1.Jzpx(ref datagv);
			DGVNX = (DataGridViewX)datagv;
			datagv = (DataGridView)(object)DGVNXX;
			Mod1.Jzpx(ref datagv);
			DGVNXX = (DataGridViewX)datagv;
		}
	}

	private void ll_btnxls2cur_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("继续操作将会覆盖当前 [动参数] 列表中的已有数据,继续吗?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32) != 7)
		{
			hax.Clear();
			sh = (Worksheet)Mod1.excelapp.Worksheets["动参数"];
			iitotal = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(sh.Cells[sh.Cells.Rows.Count, 2], (Type)null, "End", new object[1] { XlDirection.xlUp }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null));
			int num = iitotal;
			for (int i = 2; i <= num; i = checked(i + 1))
			{
				hax.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sh.Cells[i, 2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sh.Cells[i, 3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
			}
			DataGridViewX DGV = DGVNXN;
			xls2cur(bbx: false, ref DGV);
			DGVNXN = DGV;
			DGV = DGVNXX;
			xls2cur(bbx: false, ref DGV);
			DGVNXX = DGV;
			DGV = DGVNX;
			xls2cur(bbx: false, ref DGV);
			DGVNX = DGV;
			DGV = DGVNS;
			xls2cur(bbx: false, ref DGV);
			DGVNS = DGV;
			DGV = DGVBX;
			xls2cur(bbx: true, ref DGV);
			DGVBX = DGV;
			MyProject.Forms.cslr2.lslog.get_Items().Add((object)"读取了当前 [动参数] 表中数据到当前对话框中.");
		}
	}

	private void xls2cur(bool bbx, ref DataGridViewX DGV)
	{
		checked
		{
			int num = ((DataGridView)DGV).get_Rows().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Conversions.ToString(((DataGridView)DGV).get_Rows().get_Item(i).get_Cells()
					.get_Item(0)
					.get_Value());
				if (bbx)
				{
					int num2 = curnbj - 1;
					for (int j = 1; j <= num2; j++)
					{
						string text2 = Strings.Replace(text, "j", Conversions.ToString(j + 1), 1, -1, (CompareMethod)0);
						((DataGridView)DGV).get_Rows().get_Item(i).get_Cells()
							.get_Item(j)
							.set_Value((object)searchvalue(Strings.Replace(text2, "i", Conversions.ToString(j), 1, -1, (CompareMethod)0)));
					}
				}
				else
				{
					int num3 = curnbj;
					for (int k = 1; k <= num3; k++)
					{
						((DataGridView)DGV).get_Rows().get_Item(i).get_Cells()
							.get_Item(k)
							.set_Value((object)searchvalue(Strings.Replace(text, "i", Conversions.ToString(k), 1, -1, (CompareMethod)0)));
					}
				}
			}
		}
	}

	private string searchvalue(string curcsname)
	{
		string result = "";
		int num = iitotal;
		for (int i = 2; i <= num; i = checked(i + 1))
		{
			result = Conversions.ToString(hax[Strings.Trim(curcsname)]);
		}
		return result;
	}

	private void ll_btnupdate2xls_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("继续操作将会更新参数文件中的 [动参数] 表中的已有数据,继续吗?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32) != 7)
		{
			Mod1.Saved = false;
			((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(true);
			sh = (Worksheet)Mod1.excelapp.Worksheets["动参数"];
			sh.Cells.Delete(Missing.Value);
			sh.Cells[1, 1] = "序号";
			sh.Cells[1, 2] = "参数名称";
			sh.Cells[1, 3] = "参数值";
			sh.Cells[1, 4] = "尺寸名称";
			int num = Information.UBound((Array)nids, 1);
			checked
			{
				for (int i = 0; i <= num; i++)
				{
					sh.Cells[1, 5 + i] = nids[i];
				}
				sh.Cells[1, 5 + Information.UBound((Array)nids, 1) + 1] = "备注";
				kk = 2;
				DataGridViewX DGV = DGVNXN;
				update2xls(bbx: false, ref DGV);
				DGVNXN = DGV;
				DGV = DGVNXX;
				update2xls(bbx: false, ref DGV);
				DGVNXX = DGV;
				DGV = DGVNX;
				update2xls(bbx: false, ref DGV);
				DGVNX = DGV;
				DGV = DGVNS;
				update2xls(bbx: false, ref DGV);
				DGVNS = DGV;
				DGV = DGVBX;
				update2xls(bbx: true, ref DGV);
				DGVBX = DGV;
				Interaction.MsgBox((object)("在当前参数表中共创建了" + Conversions.ToString(kk - 2) + "个参数."), (MsgBoxStyle)0, (object)"提示");
				MyProject.Forms.cslr2.lslog.get_Items().Add((object)("在当前参数表中共创建了" + Conversions.ToString(kk - 2) + "个参数."));
				MyProject.Forms.cslr2.lslog.get_Items().Add((object)(Mod1.bjlb1 + " " + Mod1.cswj + " **已被修改."));
			}
		}
	}

	private void update2xls(bool bbx, ref DataGridViewX DGV)
	{
		checked
		{
			int num = ((DataGridView)DGV).get_Rows().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = Conversions.ToString(((DataGridView)DGV).get_Rows().get_Item(i).get_Cells()
					.get_Item(0)
					.get_Value());
				NewLateBinding.LateSetComplex(sh.Cells[kk, 5 + Information.UBound((Array)nids, 1) + 1], (Type)null, "value", new object[1] { RuntimeHelpers.GetObjectValue(((DataGridView)DGV).get_Rows().get_Item(i).get_Cells()
					.get_Item(curnbj + 1)
					.get_Value()) }, (string[])null, (Type[])null, false, true);
				if (bbx)
				{
					int num2 = curnbj - 1;
					for (int j = 1; j <= num2; j++)
					{
						string text2 = Strings.Replace(text, "j", Conversions.ToString(j + 1), 1, -1, (CompareMethod)0);
						NewLateBinding.LateSetComplex(sh.Cells[kk, 1], (Type)null, "Value", new object[1] { kk - 1 }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(sh.Cells[kk, 2], (Type)null, "Value", new object[1] { Strings.Replace(text2, "i", Conversions.ToString(j), 1, -1, (CompareMethod)0) }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(sh.Cells[kk, 3], (Type)null, "Value", new object[1] { RuntimeHelpers.GetObjectValue(((DataGridView)DGV).get_Rows().get_Item(i).get_Cells()
							.get_Item(j)
							.get_Value()) }, (string[])null, (Type[])null, false, true);
						string[] array = Strings.Split(nids2xls[Conversions.ToInteger(((Control)DGV).get_Tag())], ",", -1, (CompareMethod)0);
						string[] array2 = array;
						foreach (string text3 in array2)
						{
							NewLateBinding.LateSetComplex(sh.Cells[kk, 4 + Conversions.ToInteger(text3)], (Type)null, "Value", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
						}
						kk++;
					}
					continue;
				}
				int num3 = curnbj;
				for (int l = 1; l <= num3; l++)
				{
					NewLateBinding.LateSetComplex(sh.Cells[kk, 1], (Type)null, "Value", new object[1] { kk - 1 }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(sh.Cells[kk, 2], (Type)null, "Value", new object[1] { Strings.Replace(text, "i", Conversions.ToString(l), 1, -1, (CompareMethod)0) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(sh.Cells[kk, 3], (Type)null, "Value", new object[1] { RuntimeHelpers.GetObjectValue(((DataGridView)DGV).get_Rows().get_Item(i).get_Cells()
						.get_Item(l)
						.get_Value()) }, (string[])null, (Type[])null, false, true);
					string[] array = Strings.Split(nids2xls[Conversions.ToInteger(((Control)DGV).get_Tag())], ",", -1, (CompareMethod)0);
					string[] array3 = array;
					foreach (string text4 in array3)
					{
						NewLateBinding.LateSetComplex(sh.Cells[kk, 4 + Conversions.ToInteger(text4)], (Type)null, "Value", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
					}
					kk++;
				}
			}
		}
	}

	private void ll_btnexit_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Mod1.Saved)
		{
			Interaction.MsgBox((object)"当前参数已经被替换，不要忘记保存！", (MsgBoxStyle)64, (object)"提示");
		}
		((Form)this).Close();
	}
}
