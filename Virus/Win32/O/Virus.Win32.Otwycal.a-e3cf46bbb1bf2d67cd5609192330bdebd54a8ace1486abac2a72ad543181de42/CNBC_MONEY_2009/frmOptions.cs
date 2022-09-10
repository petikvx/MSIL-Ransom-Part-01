using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CNBC.DAL;
using CNBC_MONEY_2009.My;
using Dart.PowerTCP.Sockets;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using Infragistics.Win.UltraWinToolbars;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmOptions : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("ugOptions")]
	private UltraGrid _ugOptions;

	[AccessedThroughProperty("OpenFile")]
	private OpenFileDialog _OpenFile;

	[AccessedThroughProperty("SaveFile")]
	private SaveFileDialog _SaveFile;

	[AccessedThroughProperty("UltraGridExcelExporter1")]
	private UltraGridExcelExporter _UltraGridExcelExporter1;

	[AccessedThroughProperty("PowerUDP")]
	private Udp _PowerUDP;

	[AccessedThroughProperty("UltraToolbarsManager1")]
	private UltraToolbarsManager _UltraToolbarsManager1;

	[AccessedThroughProperty("_frmOptions_Toolbars_Dock_Area_Left")]
	private UltraToolbarsDockArea __frmOptions_Toolbars_Dock_Area_Left;

	[AccessedThroughProperty("_frmOptions_Toolbars_Dock_Area_Right")]
	private UltraToolbarsDockArea __frmOptions_Toolbars_Dock_Area_Right;

	[AccessedThroughProperty("_frmOptions_Toolbars_Dock_Area_Top")]
	private UltraToolbarsDockArea __frmOptions_Toolbars_Dock_Area_Top;

	[AccessedThroughProperty("_frmOptions_Toolbars_Dock_Area_Bottom")]
	private UltraToolbarsDockArea __frmOptions_Toolbars_Dock_Area_Bottom;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2_ReSort")]
	private Timer _Timer2_ReSort;

	private clsEquity objEquity;

	private string strSQL;

	private DataTable dt;

	private int i;

	private DateTime datetime_LastSort;

	private string strSortColumn;

	private bool strSort;

	private DataTable dtOptions;

	private bool _IsActive;

	[AccessedThroughProperty("OptionsNewStock")]
	private frmNewOptionsStock _OptionsNewStock;

	internal virtual UltraGrid ugOptions
	{
		[DebuggerNonUserCode]
		get
		{
			return _ugOptions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_ugOptions != null)
			{
				_ugOptions.remove_InitializeLayout(new InitializeLayoutEventHandler(ugOptions_InitializeLayout));
				((UltraGridBase)_ugOptions).remove_AfterSortChange(new BandEventHandler(ugOptions_AfterSortChange));
			}
			_ugOptions = value;
			if (_ugOptions != null)
			{
				_ugOptions.add_InitializeLayout(new InitializeLayoutEventHandler(ugOptions_InitializeLayout));
				((UltraGridBase)_ugOptions).add_AfterSortChange(new BandEventHandler(ugOptions_AfterSortChange));
			}
		}
	}

	internal virtual OpenFileDialog OpenFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OpenFile = value;
		}
	}

	internal virtual SaveFileDialog SaveFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaveFile = value;
		}
	}

	internal virtual UltraGridExcelExporter UltraGridExcelExporter1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraGridExcelExporter1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraGridExcelExporter1 = value;
		}
	}

	internal virtual Udp PowerUDP
	{
		[DebuggerNonUserCode]
		get
		{
			return _PowerUDP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_PowerUDP != null)
			{
				_PowerUDP.remove_EndReceive(new DatagramEventHandler(PowerUDP_EndReceive));
			}
			_PowerUDP = value;
			if (_PowerUDP != null)
			{
				_PowerUDP.add_EndReceive(new DatagramEventHandler(PowerUDP_EndReceive));
			}
		}
	}

	internal virtual UltraToolbarsManager UltraToolbarsManager1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraToolbarsManager1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_UltraToolbarsManager1 != null)
			{
				_UltraToolbarsManager1.remove_ToolClick(new ToolClickEventHandler(UltraToolbarsManager1_ToolClick));
			}
			_UltraToolbarsManager1 = value;
			if (_UltraToolbarsManager1 != null)
			{
				_UltraToolbarsManager1.add_ToolClick(new ToolClickEventHandler(UltraToolbarsManager1_ToolClick));
			}
		}
	}

	internal virtual UltraToolbarsDockArea _frmOptions_Toolbars_Dock_Area_Left
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmOptions_Toolbars_Dock_Area_Left;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmOptions_Toolbars_Dock_Area_Left = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmOptions_Toolbars_Dock_Area_Right
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmOptions_Toolbars_Dock_Area_Right;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmOptions_Toolbars_Dock_Area_Right = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmOptions_Toolbars_Dock_Area_Top
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmOptions_Toolbars_Dock_Area_Top;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmOptions_Toolbars_Dock_Area_Top = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmOptions_Toolbars_Dock_Area_Bottom
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmOptions_Toolbars_Dock_Area_Bottom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmOptions_Toolbars_Dock_Area_Bottom = value;
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick((EventHandler)Timer1_Tick);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick((EventHandler)Timer1_Tick);
			}
		}
	}

	internal virtual Timer Timer2_ReSort
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2_ReSort;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Timer2_ReSort != null)
			{
				_Timer2_ReSort.remove_Tick((EventHandler)Timer2_ReSort_Tick);
			}
			_Timer2_ReSort = value;
			if (_Timer2_ReSort != null)
			{
				_Timer2_ReSort.add_Tick((EventHandler)Timer2_ReSort_Tick);
			}
		}
	}

	public bool IsActive
	{
		get
		{
			return _IsActive;
		}
		set
		{
			_IsActive = value;
		}
	}

	private virtual frmNewOptionsStock OptionsNewStock
	{
		[DebuggerNonUserCode]
		get
		{
			return _OptionsNewStock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_OptionsNewStock != null)
			{
				_OptionsNewStock.StockAdded -= OptionsNewStock_StockAdded;
			}
			_OptionsNewStock = value;
			if (_OptionsNewStock != null)
			{
				_OptionsNewStock.StockAdded += OptionsNewStock_StockAdded;
			}
		}
	}

	public frmOptions()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)frmOptions_Load);
		((Form)this).add_FormClosed(new FormClosedEventHandler(frmOptions_FormClosed));
		__ENCList.Add(new WeakReference(this));
		datetime_LastSort = DateAndTime.get_Now();
		strSortColumn = "";
		strSort = true;
		OptionsNewStock = new frmNewOptionsStock();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Expected O, but got Unknown
		components = new Container();
		UltraGridBand val = new UltraGridBand("Band 0", -1);
		UltraGridColumn val2 = new UltraGridColumn("Exchange Symbol");
		UltraGridColumn val3 = new UltraGridColumn("Bridge Symbol");
		UltraGridColumn val4 = new UltraGridColumn("Scrip Name");
		UltraGridColumn val5 = new UltraGridColumn("Expiry Date");
		UltraGridColumn val6 = new UltraGridColumn("Strike Price");
		UltraGridColumn val7 = new UltraGridColumn("Option Type");
		UltraGridColumn val8 = new UltraGridColumn("Last Price");
		UltraGridColumn val9 = new UltraGridColumn("Change");
		UltraGridColumn val10 = new UltraGridColumn("% Change");
		UltraGridColumn val11 = new UltraGridColumn("Volume");
		UltraGridColumn val12 = new UltraGridColumn("OI");
		UltraGridColumn val13 = new UltraGridColumn("Change OI");
		UltraGridColumn val14 = new UltraGridColumn("Buy Price");
		UltraGridColumn val15 = new UltraGridColumn("Buy Qty");
		UltraGridColumn val16 = new UltraGridColumn("Sell Price");
		UltraGridColumn val17 = new UltraGridColumn("Sell Qty");
		UltraGridColumn val18 = new UltraGridColumn("Open");
		UltraGridColumn val19 = new UltraGridColumn("High");
		UltraGridColumn val20 = new UltraGridColumn("Low");
		UltraGridColumn val21 = new UltraGridColumn("Market Type");
		UltraGridColumn val22 = new UltraGridColumn("Prev Day Close");
		UltraGridColumn val23 = new UltraGridColumn("Prev Day OI");
		Appearance val24 = new Appearance();
		Appearance val25 = new Appearance();
		Appearance val26 = new Appearance();
		Appearance val27 = new Appearance();
		Appearance val28 = new Appearance();
		Appearance val29 = new Appearance();
		UltraToolbar val30 = new UltraToolbar("UltraToolbar1");
		PopupMenuTool val31 = new PopupMenuTool("File");
		PopupMenuTool val32 = new PopupMenuTool("ManualAdd");
		PopupMenuTool val33 = new PopupMenuTool("Help");
		PopupMenuTool val34 = new PopupMenuTool("File");
		ButtonTool val35 = new ButtonTool("New");
		ButtonTool val36 = new ButtonTool("Open");
		ButtonTool val37 = new ButtonTool("SaveAs");
		ButtonTool val38 = new ButtonTool("Refresh");
		ButtonTool val39 = new ButtonTool("Export To Excel");
		ButtonTool val40 = new ButtonTool("New");
		Appearance val41 = new Appearance();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmOptions));
		ButtonTool val42 = new ButtonTool("Open");
		Appearance val43 = new Appearance();
		ButtonTool val44 = new ButtonTool("SaveAs");
		Appearance val45 = new Appearance();
		ButtonTool val46 = new ButtonTool("Refresh");
		Appearance val47 = new Appearance();
		ButtonTool val48 = new ButtonTool("Export To Excel");
		Appearance val49 = new Appearance();
		PopupMenuTool val50 = new PopupMenuTool("ManualAdd");
		ButtonTool val51 = new ButtonTool("NewOption");
		ButtonTool val52 = new ButtonTool("NewOption");
		Appearance val53 = new Appearance();
		PopupMenuTool val54 = new PopupMenuTool("Help");
		ButtonTool val55 = new ButtonTool("HelpShortcuts");
		ButtonTool val56 = new ButtonTool("About CNBC Money 2010");
		ButtonTool val57 = new ButtonTool("HelpShortcuts");
		ButtonTool val58 = new ButtonTool("About CNBC Money 2010");
		ugOptions = new UltraGrid();
		OpenFile = new OpenFileDialog();
		SaveFile = new SaveFileDialog();
		UltraGridExcelExporter1 = new UltraGridExcelExporter(components);
		PowerUDP = new Udp(components);
		UltraToolbarsManager1 = new UltraToolbarsManager(components);
		_frmOptions_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
		_frmOptions_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
		_frmOptions_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
		_frmOptions_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
		Timer1 = new Timer(components);
		Timer2_ReSort = new Timer(components);
		((ISupportInitialize)ugOptions).BeginInit();
		((ISupportInitialize)UltraToolbarsManager1).BeginInit();
		((Control)this).SuspendLayout();
		val2.get_Header().set_VisiblePosition(0);
		val3.get_Header().set_VisiblePosition(1);
		val4.get_Header().set_VisiblePosition(2);
		val5.get_Header().set_VisiblePosition(3);
		val6.get_Header().set_VisiblePosition(4);
		val7.get_Header().set_VisiblePosition(5);
		val8.get_Header().set_VisiblePosition(6);
		val9.get_Header().set_VisiblePosition(7);
		val10.get_Header().set_VisiblePosition(8);
		val11.get_Header().set_VisiblePosition(9);
		val12.get_Header().set_VisiblePosition(11);
		val13.get_Header().set_VisiblePosition(13);
		val14.get_Header().set_VisiblePosition(14);
		val15.get_Header().set_VisiblePosition(15);
		val16.get_Header().set_VisiblePosition(16);
		val17.get_Header().set_VisiblePosition(17);
		val18.get_Header().set_VisiblePosition(18);
		val19.get_Header().set_VisiblePosition(19);
		val20.get_Header().set_VisiblePosition(20);
		val21.get_Header().set_VisiblePosition(21);
		val22.get_Header().set_VisiblePosition(10);
		val23.get_Header().set_VisiblePosition(12);
		val.get_Columns().AddRange(new object[22]
		{
			val2, val3, val4, val5, val6, val7, val8, val9, val10, val11,
			val12, val13, val14, val15, val16, val17, val18, val19, val20, val21,
			val22, val23
		});
		val24.set_BackColor(Color.Purple);
		val24.set_BackColor2(Color.Purple);
		val.get_Override().set_SelectedCellAppearance((AppearanceBase)(object)val24);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_BandsSerializer().Add((object)val);
		((UltraGridBase)ugOptions).get_DisplayLayout().set_CaptionVisible((DefaultableBoolean)2);
		((UltraGridBase)ugOptions).get_DisplayLayout().set_MaxColScrollRegions(1);
		((UltraGridBase)ugOptions).get_DisplayLayout().set_MaxRowScrollRegions(1);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Override().set_AllowRowFiltering((DefaultableBoolean)1);
		val25.set_BackColor(Color.Transparent);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val25);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Override().set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Override().set_FilterOperatorLocation((FilterOperatorLocation)3);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Override().set_FilterUIType((FilterUIType)2);
		val26.set_BackColor(Color.FromArgb(89, 135, 214));
		val26.set_BackColor2(Color.FromArgb(7, 59, 150));
		val26.set_BackGradientStyle((GradientStyle)2);
		val26.get_FontData().set_BoldAsString("True");
		val26.get_FontData().set_Name("Arial");
		val26.get_FontData().set_SizeInPoints(10f);
		val26.set_ForeColor(Color.White);
		val26.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val26);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Override().set_HeaderClickAction((HeaderClickAction)2);
		val27.set_BackGradientAlignment((GradientAlignment)3);
		val27.set_BackGradientStyle((GradientStyle)2);
		val27.set_BackHatchStyle((BackHatchStyle)2);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Override().set_RowAppearance((AppearanceBase)(object)val27);
		val28.set_BackColor(Color.FromArgb(89, 135, 214));
		val28.set_BackColor2(Color.FromArgb(7, 59, 150));
		val28.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val28);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Override().set_RowSelectorNumberStyle((RowSelectorNumberStyle)3);
		val29.set_BackColor(Color.FromArgb(251, 230, 148));
		val29.set_BackColor2(Color.FromArgb(238, 149, 21));
		val29.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val29);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Override().set_SelectTypeRow((SelectType)2);
		((UltraGridBase)ugOptions).get_DisplayLayout().set_ScrollBounds((ScrollBounds)0);
		((Control)ugOptions).set_Dock((DockStyle)5);
		((Control)ugOptions).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraGrid obj = ugOptions;
		Point location = new Point(4, 50);
		((Control)obj).set_Location(location);
		((Control)ugOptions).set_Name("ugOptions");
		UltraGrid obj2 = ugOptions;
		Size size = new Size(1163, 527);
		((Control)obj2).set_Size(size);
		((Control)ugOptions).set_TabIndex(5);
		((FileDialog)OpenFile).set_DefaultExt("TV18");
		((FileDialog)OpenFile).set_Filter("Text files (*.TV_FNO18)|*.TVFNO18|\" & \"All files|*.*");
		PowerUDP.set_Editor((object)PowerUDP);
		UltraToolbarsManager1.set_DesignerFlags(1);
		UltraToolbarsManager1.set_DockWithinContainer((Control)(object)this);
		UltraToolbarsManager1.set_Office2007UICompatibility(false);
		UltraToolbarsManager1.get_Ribbon().get_ApplicationMenu().set_Visible(false);
		UltraToolbarsManager1.get_Ribbon().get_QuickAccessToolbar().set_Visible(false);
		UltraToolbarsManager1.get_Ribbon().set_Visible(true);
		UltraToolbarsManager1.set_ShowFullMenusDelay(500);
		val30.set_DockedColumn(0);
		val30.set_DockedRow(0);
		val30.set_Text("UltraToolbar1");
		((ToolsCollectionBase)((UltraToolbarBase)val30).get_Tools()).AddRange((ToolBase[])(object)new ToolBase[3]
		{
			(ToolBase)val31,
			(ToolBase)val32,
			(ToolBase)val33
		});
		UltraToolbarsManager1.get_Toolbars().AddRange((UltraToolbar[])(object)new UltraToolbar[1] { val30 });
		((ToolPropsBase)((ToolBase)val34).get_SharedProps()).set_Caption("File");
		((ToolsCollectionBase)val34.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[5]
		{
			(ToolBase)val35,
			(ToolBase)val36,
			(ToolBase)val37,
			(ToolBase)val38,
			(ToolBase)val39
		});
		val41.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance7.Image")));
		((ToolPropsBase)((ToolBase)val40).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val41);
		((ToolPropsBase)((ToolBase)val40).get_SharedProps()).set_Caption("New");
		((ToolBase)val40).get_SharedProps().set_Shortcut((Shortcut)131150);
		val43.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance8.Image")));
		((ToolPropsBase)((ToolBase)val42).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val43);
		((ToolPropsBase)((ToolBase)val42).get_SharedProps()).set_Caption("Open");
		((ToolBase)val42).get_SharedProps().set_Shortcut((Shortcut)131151);
		val45.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance9.Image")));
		((ToolPropsBase)((ToolBase)val44).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val45);
		((ToolPropsBase)((ToolBase)val44).get_SharedProps()).set_Caption("Save As");
		((ToolBase)val44).get_SharedProps().set_Shortcut((Shortcut)131155);
		val47.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance10.Image")));
		((ToolPropsBase)((ToolBase)val46).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val47);
		((ToolPropsBase)((ToolBase)val46).get_SharedProps()).set_Caption("Refresh");
		((ToolBase)val46).get_SharedProps().set_Shortcut((Shortcut)116);
		val49.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance11.Image")));
		((ToolPropsBase)((ToolBase)val48).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val49);
		((ToolPropsBase)((ToolBase)val48).get_SharedProps()).set_Caption("Export To Excel");
		((ToolBase)val48).get_SharedProps().set_Shortcut((Shortcut)131141);
		((ToolPropsBase)((ToolBase)val50).get_SharedProps()).set_Caption("Manual Add");
		((ToolsCollectionBase)val50.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[1] { (ToolBase)val51 });
		val53.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance12.Image")));
		((ToolPropsBase)((ToolBase)val52).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val53);
		((ToolPropsBase)((ToolBase)val52).get_SharedProps()).set_Caption("New Option");
		((ToolBase)val52).get_SharedProps().set_Shortcut((Shortcut)117);
		((ToolPropsBase)((ToolBase)val54).get_SharedProps()).set_Caption("Help");
		((ToolsCollectionBase)val54.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[2]
		{
			(ToolBase)val55,
			(ToolBase)val56
		});
		((ToolPropsBase)((ToolBase)val57).get_SharedProps()).set_Caption("Help Shortcuts");
		((ToolBase)val57).get_SharedProps().set_Shortcut((Shortcut)112);
		((ToolPropsBase)((ToolBase)val58).get_SharedProps()).set_Caption("About CNBC Money 2010");
		UltraToolbarsManager1.get_Tools().AddRange((ToolBase[])(object)new ToolBase[11]
		{
			(ToolBase)val34,
			(ToolBase)val40,
			(ToolBase)val42,
			(ToolBase)val44,
			(ToolBase)val46,
			(ToolBase)val48,
			(ToolBase)val50,
			(ToolBase)val52,
			(ToolBase)val54,
			(ToolBase)val57,
			(ToolBase)val58
		});
		((Control)_frmOptions_Toolbars_Dock_Area_Left).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmOptions_Toolbars_Dock_Area_Left).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmOptions_Toolbars_Dock_Area_Left.set_DockedPosition((DockedPosition)2);
		((Control)_frmOptions_Toolbars_Dock_Area_Left).set_ForeColor(SystemColors.ControlText);
		_frmOptions_Toolbars_Dock_Area_Left.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmOptions_Toolbars_Dock_Area_Left = _frmOptions_Toolbars_Dock_Area_Left;
		location = new Point(0, 50);
		((Control)frmOptions_Toolbars_Dock_Area_Left).set_Location(location);
		((Control)_frmOptions_Toolbars_Dock_Area_Left).set_Name("_frmOptions_Toolbars_Dock_Area_Left");
		UltraToolbarsDockArea frmOptions_Toolbars_Dock_Area_Left2 = _frmOptions_Toolbars_Dock_Area_Left;
		size = new Size(4, 527);
		((Control)frmOptions_Toolbars_Dock_Area_Left2).set_Size(size);
		_frmOptions_Toolbars_Dock_Area_Left.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmOptions_Toolbars_Dock_Area_Right).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmOptions_Toolbars_Dock_Area_Right).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmOptions_Toolbars_Dock_Area_Right.set_DockedPosition((DockedPosition)3);
		((Control)_frmOptions_Toolbars_Dock_Area_Right).set_ForeColor(SystemColors.ControlText);
		_frmOptions_Toolbars_Dock_Area_Right.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmOptions_Toolbars_Dock_Area_Right = _frmOptions_Toolbars_Dock_Area_Right;
		location = new Point(1167, 50);
		((Control)frmOptions_Toolbars_Dock_Area_Right).set_Location(location);
		((Control)_frmOptions_Toolbars_Dock_Area_Right).set_Name("_frmOptions_Toolbars_Dock_Area_Right");
		UltraToolbarsDockArea frmOptions_Toolbars_Dock_Area_Right2 = _frmOptions_Toolbars_Dock_Area_Right;
		size = new Size(4, 527);
		((Control)frmOptions_Toolbars_Dock_Area_Right2).set_Size(size);
		_frmOptions_Toolbars_Dock_Area_Right.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmOptions_Toolbars_Dock_Area_Top).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmOptions_Toolbars_Dock_Area_Top).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmOptions_Toolbars_Dock_Area_Top.set_DockedPosition((DockedPosition)0);
		((Control)_frmOptions_Toolbars_Dock_Area_Top).set_ForeColor(SystemColors.ControlText);
		UltraToolbarsDockArea frmOptions_Toolbars_Dock_Area_Top = _frmOptions_Toolbars_Dock_Area_Top;
		location = new Point(0, 0);
		((Control)frmOptions_Toolbars_Dock_Area_Top).set_Location(location);
		((Control)_frmOptions_Toolbars_Dock_Area_Top).set_Name("_frmOptions_Toolbars_Dock_Area_Top");
		UltraToolbarsDockArea frmOptions_Toolbars_Dock_Area_Top2 = _frmOptions_Toolbars_Dock_Area_Top;
		size = new Size(1171, 50);
		((Control)frmOptions_Toolbars_Dock_Area_Top2).set_Size(size);
		_frmOptions_Toolbars_Dock_Area_Top.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmOptions_Toolbars_Dock_Area_Bottom).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmOptions_Toolbars_Dock_Area_Bottom).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmOptions_Toolbars_Dock_Area_Bottom.set_DockedPosition((DockedPosition)1);
		((Control)_frmOptions_Toolbars_Dock_Area_Bottom).set_ForeColor(SystemColors.ControlText);
		_frmOptions_Toolbars_Dock_Area_Bottom.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmOptions_Toolbars_Dock_Area_Bottom = _frmOptions_Toolbars_Dock_Area_Bottom;
		location = new Point(0, 577);
		((Control)frmOptions_Toolbars_Dock_Area_Bottom).set_Location(location);
		((Control)_frmOptions_Toolbars_Dock_Area_Bottom).set_Name("_frmOptions_Toolbars_Dock_Area_Bottom");
		UltraToolbarsDockArea frmOptions_Toolbars_Dock_Area_Bottom2 = _frmOptions_Toolbars_Dock_Area_Bottom;
		size = new Size(1171, 4);
		((Control)frmOptions_Toolbars_Dock_Area_Bottom2).set_Size(size);
		_frmOptions_Toolbars_Dock_Area_Bottom.set_ToolbarsManager(UltraToolbarsManager1);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(300000);
		Timer2_ReSort.set_Interval(5000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(1171, 581);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ugOptions);
		((Control)this).get_Controls().Add((Control)(object)_frmOptions_Toolbars_Dock_Area_Left);
		((Control)this).get_Controls().Add((Control)(object)_frmOptions_Toolbars_Dock_Area_Right);
		((Control)this).get_Controls().Add((Control)(object)_frmOptions_Toolbars_Dock_Area_Top);
		((Control)this).get_Controls().Add((Control)(object)_frmOptions_Toolbars_Dock_Area_Bottom);
		((Control)this).set_Name("frmOptions");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_Text("Options");
		((ISupportInitialize)ugOptions).EndInit();
		((ISupportInitialize)UltraToolbarsManager1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmOptions_Load(object sender, EventArgs e)
	{
		try
		{
			objEquity = new clsEquity();
			strSQL = "SELECT ISNULL(SORT_COLUMN,'') AS SORT_COLUMN, ISNULL(SORT_INDICATOR,0) AS SORT_INDICATOR FROM CNBCMONEY_USERS_MST  WHERE USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX = -2 ";
			dt = new DataTable();
			dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
			if (dt.Rows.Count > 0 && Operators.ConditionalCompareObjectNotEqual(dt.Rows[0]["SORT_COLUMN"], (object)"", false))
			{
				strSortColumn = Conversions.ToString(dt.Rows[0]["SORT_COLUMN"]);
				if (Operators.ConditionalCompareObjectEqual(dt.Rows[0]["SORT_INDICATOR"], (object)1, false))
				{
					strSort = false;
				}
				else
				{
					strSort = true;
				}
			}
			BindGridData();
			objEquity = new clsEquity();
			objEquity.Update_ConnectedUsers(-2);
			((Control)ugOptions).Focus();
			PowerUDP_Connect();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void frmOptions_FormClosed(object sender, FormClosedEventArgs e)
	{
		try
		{
			objEquity = new clsEquity();
			objEquity.DeActivateTab(-2, strSortColumn, Conversions.ToString(strSort));
			PowerUDP.Close();
			((Component)(object)PowerUDP).Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void OptionsNewStock_StockAdded(string strBridgeSymbol)
	{
		AddOptionsNewStock(strBridgeSymbol, 0, isAddnew: true);
	}

	private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		switch (Strings.UCase(((ToolEventArgs)e).get_Tool().get_Key()))
		{
		case "NEW":
			File_New();
			break;
		case "OPEN":
			File_Open();
			break;
		case "SAVEAS":
			Save_Options();
			break;
		case "EXPORTTOEXCEL":
			((FileDialog)SaveFile).set_Filter("xls (*.xls)|*.xls|All files|*.*");
			((CommonDialog)SaveFile).ShowDialog();
			break;
		case "NEWOPTION":
			OptionsNewStock = new frmNewOptionsStock();
			((Form)OptionsNewStock).ShowDialog();
			break;
		case "REFRESH":
			BindGridData();
			break;
		case "HELPSHORTCUTS":
		{
			frmHelp frmHelp2 = new frmHelp();
			((Control)frmHelp2).Show();
			break;
		}
		}
	}

	private void ugOptions_AfterSortChange(object sender, BandEventArgs e)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		try
		{
			if (((DisposableObjectCollectionBase)e.get_Band().get_SortedColumns()).get_Count() != 0)
			{
				strSortColumn = e.get_Band().get_SortedColumns().get_Item(0)
					.ToString();
				if ((int)e.get_Band().get_SortedColumns().get_Item(0)
					.get_SortIndicator() == 1)
				{
					strSort = false;
				}
				else
				{
					strSort = true;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ugOptions_InitializeLayout(object sender, InitializeLayoutEventArgs e)
	{
		e.get_Layout().get_Override().set_CellClickAction((CellClickAction)3);
		checked
		{
			int num = ((DisposableObjectCollectionBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()).get_Count() - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				e.get_Layout().get_Bands().get_Item(0)
					.get_Columns()
					.get_Item(num2)
					.set_CellActivation((Activation)3);
				if (num2 > 3)
				{
					e.get_Layout().get_Bands().get_Item(0)
						.get_Columns()
						.get_Item(num2)
						.get_CellAppearance()
						.set_TextHAlign((HAlign)3);
					e.get_Layout().get_Bands().get_Item(0)
						.get_Columns()
						.get_Item(num2)
						.set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)6);
				}
				else
				{
					e.get_Layout().get_Bands().get_Item(0)
						.get_Columns()
						.get_Item(num2)
						.get_CellAppearance()
						.set_TextHAlign((HAlign)1);
					e.get_Layout().get_Bands().get_Item(0)
						.get_Columns()
						.get_Item(num2)
						.set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
				}
				num2++;
			}
			UltraGridBand val = e.get_Layout().get_Bands().get_Item(0);
			val.get_Columns().get_Item("% Change").set_Format("0.00");
			val.get_Columns().get_Item("Change").set_Format("0.00");
			val.get_Columns().get_Item("Exchange Symbol").set_Hidden(true);
			val.get_Columns().get_Item("Bridge Symbol").set_Hidden(true);
			val.get_Columns().get_Item("Expiry Date").set_Format("dd-MM-yyyy");
			val = null;
		}
	}

	private void PowerUDP_EndReceive(object sender, DatagramEventArgs e)
	{
		byte[] array = new byte[251];
		try
		{
			objEquity = new clsEquity();
			clsEquity obj = objEquity;
			byte[] Data = e.get_Datagram().get_Buffer();
			string text = obj.BytesToString(ref Data);
			text = Strings.Trim(text.Replace("\r\n", ""));
			if (Strings.Len(text) > 0)
			{
				CrunchData(text);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		PowerUDP.BeginReceive(array);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.set_Enabled(false);
		objEquity = new clsEquity();
		objEquity.Update_DateTime(-2);
		Timer1.set_Enabled(true);
	}

	private void Timer2_ReSort_Tick(object sender, EventArgs e)
	{
		Timer2_ReSort.set_Enabled(false);
		((UltraGridBase)ugOptions).get_DisplayLayout().get_Bands().get_Item(0)
			.get_SortedColumns()
			.RefreshSort(false);
		Timer2_ReSort.set_Enabled(true);
	}

	public void BindGridData()
	{
		Money_Splash money_Splash = new Money_Splash();
		try
		{
			((Control)money_Splash).Show();
			((Control)money_Splash).Refresh();
			objEquity = new clsEquity();
			objEquity.GetSettingsFromDB(-1);
			strSQL = "Select ExchangeSymbol AS [Exchange Symbol], newBridgesymbol AS [Bridge Symbol]   ,[Scrip Name] = isnull((Select top 1 Name from VehicleType VT Join vehicle_exchange b on VT.code=b.code where b.Series='FNO' and b.ExchangeSymbol=A.ExchangeSymbol),A.ExchangeSymbol)  ,Expiry_Date AS [Expiry Date], Strike_price AS [Strike Price] , Option_type AS [Option Type]   ,Market_type AS [Market Type]   ,ISNULL(Buy_price,'0') as [Buy Price] ,ISNULL(Buy_QTY,'0') as [Buy Qty],ISNULL(SELL_PRICE,'0') AS [Sell Price],ISNULL(SELL_qty,'0') AS [Sell Qty],ISNULL(Lastprice,'0') AS [Last Price] ,ISNULL(volume,'0') AS Volume   ,ISNULL([OPEN],'0') AS [Open],ISNULL(high,'0') AS High,ISNULL([LOW],'0') AS [Low],ISNULL([CLOSE],'0') AS [Prev Day Close],ISNULL(open_interest,'0') AS  [OI]   ,ISNULL(prevday_open_interest,'0') AS  [Prev Day OI],0.00 AS [Change OI], 0.00 As [% Change]   ,Lastprice - [Close] AS Change   from OPTIONS_transaction_data A   where  UPPER(newBridgeSymbol) IN (SELECT UPPER(BRIDGESYMBOL) FROM vw_CNBCMONEY_DETAILS WHERE TABINDEX = -2 AND   USERNAME = '" + mdlMain.gUserName + "') and [CLOSE]>0   and Bridgesymbol is not NULL   and ExchangeSymbol is not NULL   and Expiry_date is not NULL   and option_type is not NULL   and Market_type is not NULL ";
			dtOptions = new DataTable();
			dtOptions = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
			((UltraGridBase)ugOptions).set_DataSource((object)dtOptions);
			if (Operators.CompareString(strSortColumn, "", false) != 0)
			{
				((UltraGridBase)ugOptions).get_DisplayLayout().get_Bands().get_Item(0)
					.get_Columns()
					.get_Item(strSortColumn)
					.set_SortIndicator((SortIndicator)Conversions.ToInteger(Interaction.IIf(strSort, (object)(SortIndicator)2, (object)(SortIndicator)1)));
			}
			Loop_InitializeRow();
			((UltraGridBase)ugOptions).UpdateData();
			((Form)money_Splash).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Form)money_Splash).Close();
			ProjectData.ClearProjectError();
		}
	}

	private void File_New()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		try
		{
			if (((UltraGridBase)ugOptions).get_Rows().get_Count() > 0)
			{
				MsgBoxResult val = Interaction.MsgBox((object)" The Current item list has unsaved changes.Would you like to save them now?", (MsgBoxStyle)3, (object)null);
				if ((int)val == 6)
				{
					Save_Options();
				}
				objEquity = new clsEquity();
				objEquity.DeletePortFolio("OPTIONS", -2);
				BindGridData();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void File_Open()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		try
		{
			OpenFileDialog openFile = OpenFile;
			if ((int)((CommonDialog)openFile).ShowDialog() == 1)
			{
				new StreamReader(openFile.OpenFile());
				StreamReader streamReader = new StreamReader(((FileDialog)openFile).get_FileName());
				string text = streamReader.ReadLine();
				objEquity = new clsEquity();
				objEquity.DeletePortFolio("FNO", -1);
				while (text != null)
				{
					string text2 = text;
					strSQL = "SELECT ExchangeSymbol FROM Vehicle_Exchange WHERE Series = 'Equity' AND Symbol = '" + Strings.Mid(text2, 1, checked(Strings.Len(text2) - 5)) + "'";
					string strExchangeSymbol = Conversions.ToString(SqlHelper.ExecuteScalar(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL));
					objEquity = new clsEquity();
					objEquity.AddLookUp(text2, strExchangeSymbol, "FNO", -1);
					text = streamReader.ReadLine();
				}
				streamReader.Close();
			}
			openFile = null;
			BindGridData();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Save_Options()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		StreamWriter streamWriter = null;
		string text = "";
		try
		{
			SaveFileDialog saveFile = SaveFile;
			((FileDialog)saveFile).set_Filter("Text files (*.TV_FNO18)|*.TVFNO18|All files|*.*");
			if ((int)((CommonDialog)saveFile).ShowDialog() == 1)
			{
				streamWriter = new StreamWriter(((FileDialog)saveFile).get_FileName());
				RowEnumerator enumerator = ((UltraGridBase)ugOptions).get_Rows().GetEnumerator();
				while (enumerator.MoveNext())
				{
					UltraGridRow current = enumerator.get_Current();
					try
					{
						text = text + Strings.UCase(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Bridge symbol").get_Value()))) + "\r\n";
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				streamWriter.Write(text);
			}
			if ((Operators.CompareString(text, "", false) != 0) & (Operators.CompareString(((FileDialog)saveFile).get_FileName(), "", false) != 0))
			{
				mdlMain.ShowMessage("Data Saved to :" + ((FileDialog)saveFile).get_FileName());
			}
			saveFile = null;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		finally
		{
			streamWriter?.Close();
		}
	}

	private bool AddOptionsNewStock(string strBridgeSymbol, int rowID = 0, bool isAddnew = false)
	{
		checked
		{
			bool result = default(bool);
			try
			{
				strSQL = "Select ExchangeSymbol AS [Exchange Symbol], newBridgesymbol AS [Bridge Symbol]   ,[Scrip Name] = isnull((Select top 1 Name from VehicleType VT Join vehicle_exchange b on VT.code=b.code where b.series = 'FNO' and b.ExchangeSymbol=A.ExchangeSymbol),A.ExchangeSymbol)  ,Expiry_Date AS [Expiry Date], Strike_price AS [Strike Price] , Option_type AS [Option Type], Market_type AS [Market Type]   ,ISNULL(Buy_price,'0') as [Buy Price] ,ISNULL(Buy_QTY,'0') as [BUY QTY],ISNULL(SELL_PRICE,'0') AS [SELL PRICE],ISNULL(SELL_qty,'0') AS [SELL QTY],ISNULL(Lastprice,'0') AS [Last Price] ,ISNULL(volume,'0') AS volume   ,ISNULL([OPEN],'0') AS [OPEN],ISNULL(high,'0') AS high,ISNULL([LOW],'0') AS [LOW],ISNULL([CLOSE],'0') AS [Prev Day Close],ISNULL(open_interest,'0') AS  [OI]   ,ISNULL(prevday_open_interest,'0') AS  [Prev Day OI], 0.00 As [% Change]   ,Lastprice - [Close] AS Change   from OPTIONS_transaction_data A   where  [CLOSE]>0   and newBridgesymbol is not NULL   and ExchangeSymbol is not NULL   and Expiry_date is not NULL   and option_type is not NULL   and Market_type is not NULL ";
				if ((Operators.CompareString(strBridgeSymbol, "", false) != 0) & (Operators.CompareString(strBridgeSymbol, "All", false) != 0))
				{
					strSQL = strSQL + " AND UPPER(newBridgeSymbol)  = '" + Strings.UCase(strBridgeSymbol) + "'";
				}
				dt = new DataTable();
				dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				if (dt.Rows.Count == 0)
				{
					result = false;
					return result;
				}
				if (isAddnew)
				{
					int num = dt.Rows.Count - 1;
					i = 0;
					while (true)
					{
						int num2 = i;
						int num3 = num;
						if (num2 <= num3)
						{
							DataRow dataRow = dtOptions.NewRow();
							dataRow.ItemArray = dt.Rows[i].ItemArray;
							dtOptions.Rows.Add(dataRow);
							i++;
							continue;
						}
						break;
					}
				}
				else
				{
					int num4 = dt.Columns.Count - 1;
					i = 1;
					while (true)
					{
						int num5 = i;
						int num3 = num4;
						if (num5 > num3)
						{
							break;
						}
						((UltraGridBase)ugOptions).get_Rows().get_Item(rowID).get_Cells()
							.get_Item(dt.Columns[i].ColumnName)
							.set_Value(RuntimeHelpers.GetObjectValue(dt.Rows[0][dt.Columns[i].ColumnName]));
						i++;
					}
				}
				Loop_InitializeRow();
				((UltraGridBase)ugOptions).UpdateData();
				result = true;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void PowerUDP_Connect()
	{
		try
		{
			objEquity = new clsEquity();
			PowerUDP.Open(objEquity.getMyIP(), 15009);
			byte[] array = new byte[257];
			PowerUDP.BeginReceive(array);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	private void CrunchData(string aa)
	{
		try
		{
			aa = Strings.Replace(aa, "##", "", 1, -1, (CompareMethod)0);
			if (Strings.InStr(1, aa, "AAA", (CompareMethod)0) <= 0)
			{
				return;
			}
			Array array = Strings.Split(aa, "AAA", -1, (CompareMethod)0);
			int num = Information.UBound(array, 1);
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Strings.InStr(1, Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num2 }, (string[])null))), "|", (CompareMethod)0) > 0)
				{
					Array array2 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num2 }, (string[])null)), "|", -1, (CompareMethod)0);
					if (Strings.InStr(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))), "-", (CompareMethod)0) <= 0)
					{
						break;
					}
					Array array3 = Strings.Split(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))), "-", -1, (CompareMethod)0);
					string text = Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null)));
					if (Operators.CompareString(Strings.Mid(text, 1, 1), "0", false) == 0)
					{
						text = Strings.Mid(text, 2, Strings.Len(text));
					}
					string text2 = Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 0 }, (string[])null)));
					if (Operators.CompareString(Strings.Mid(text2, 1, 1), "0", false) == 0)
					{
						text2 = Strings.Mid(text2, 2, Strings.Len(text2));
					}
					string text3 = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(string.Concat(text2 + "-", text), "-"), NewLateBinding.LateIndexGet((object)array3, new object[1] { 2 }, (string[])null)));
					RowEnumerator enumerator = ((UltraGridBase)ugOptions).get_Rows().GetEnumerator();
					while (enumerator.MoveNext())
					{
						UltraGridRow current = enumerator.get_Current();
						if (!((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "FN", (CompareMethod)0) > 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(current.get_Cells().get_Item("Exchange Symbol").get_Text())), Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false) == 0) & (Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)), "OPT", (CompareMethod)0) > 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(current.get_Cells().get_Item("Strike Price").get_Text())), Strings.Trim(Strings.Replace(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 4 }, (string[])null)), ".00", "", 1, -1, (CompareMethod)0)), false) == 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(current.get_Cells().get_Item("Option Type").get_Text())), Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 5 }, (string[])null))), false) == 0)) || Operators.CompareString(Strings.Trim(Strings.Replace(current.get_Cells().get_Item("Expiry Date").get_Text(), "/", "-", 1, -1, (CompareMethod)0)), Strings.Trim(text3), false) != 0)
						{
							if (((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "FI", (CompareMethod)0) > 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(current.get_Cells().get_Item("Exchange Symbol").get_Text())), Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false) == 0) & (Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)), "OPT", (CompareMethod)0) > 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(current.get_Cells().get_Item("Strike Price").get_Text())), Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 4 }, (string[])null))), false) == 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(current.get_Cells().get_Item("Option Type").get_Text())), Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 5 }, (string[])null))), false) == 0)) && Operators.CompareString(Strings.Trim(Strings.Replace(current.get_Cells().get_Item("Expiry Date").get_Text(), "/", "-", 1, -1, (CompareMethod)0)), Strings.Trim(text3), false) == 0)
							{
								current.get_Cells().get_Item("OI").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("Change OI").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Prev Day OI").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								InitializeRow(current);
								break;
							}
							continue;
						}
						if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Last Price").get_Value(), (object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false))
						{
							current.get_Cells().get_Item("Last Price").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
							current.get_Cells().get_Item("Change").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Operators.SubtractObject(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Prev Day Close").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
							current.get_Cells().get_Item("% Change").set_Value((object)Strings.FormatNumber(Operators.MultiplyObject(Operators.DivideObject(current.get_Cells().get_Item("Change").get_Value(), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Prev Day Close").get_Value()))), (object)100), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
						}
						if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Volume").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 12 }, (string[])null)))), false))
						{
							current.get_Cells().get_Item("Volume").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 12 }, (string[])null)))));
						}
						if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Buy Price").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 7 }, (string[])null)))), false))
						{
							current.get_Cells().get_Item("Buy Price").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 7 }, (string[])null)))));
						}
						if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Buy Price").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 7 }, (string[])null)))), false))
						{
							current.get_Cells().get_Item("Buy Price").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 7 }, (string[])null)))));
						}
						if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Buy Qty").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null)))), false))
						{
							current.get_Cells().get_Item("Buy Qty").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null)))));
						}
						if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Sell Price").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null)))), false))
						{
							current.get_Cells().get_Item("Sell Price").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null)))));
						}
						if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Sell Qty").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 10 }, (string[])null)))), false))
						{
							current.get_Cells().get_Item("Sell Qty").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 10 }, (string[])null)))));
						}
						if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Open").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 14 }, (string[])null)))), false))
						{
							current.get_Cells().get_Item("Open").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 14 }, (string[])null)))));
						}
						if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("High").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 15 }, (string[])null)))), false))
						{
							current.get_Cells().get_Item("High").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 15 }, (string[])null)))));
						}
						if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Low").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 16 }, (string[])null)))), false))
						{
							current.get_Cells().get_Item("Low").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 16 }, (string[])null)))));
						}
						if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Prev Day Close").get_Value()))) > 0.0)
						{
							current.get_Cells().get_Item("Change").set_Value(RuntimeHelpers.GetObjectValue(current.get_Cells().get_Item("Change").get_Value()));
							current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
						}
						else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Prev Day Close").get_Value()))) < 0.0)
						{
							current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
						}
						else
						{
							current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
						}
						InitializeRow(current);
						break;
					}
				}
				num2 = checked(num2 + 1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void InitializeRow(UltraGridRow dRow)
	{
		try
		{
			UltraGridRow val = dRow;
			val.get_Cells().get_Item("Change").set_Value(Operators.SubtractObject(val.get_Cells().get_Item("Last Price").get_Value(), val.get_Cells().get_Item("Prev Day Close").get_Value()));
			object value = val.get_Cells().get_Item("Change").get_Value();
			if (Operators.ConditionalCompareObjectEqual(value, (object)0, false))
			{
				val.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
			}
			else if (Operators.ConditionalCompareObjectGreater(value, (object)0, false))
			{
				val.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
			}
			else if (Operators.ConditionalCompareObjectLess(value, (object)0, false))
			{
				val.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
			}
			val.get_Cells().get_Item("% Change").set_Value(Operators.DivideObject(Operators.SubtractObject(val.get_Cells().get_Item("Last Price").get_Value(), val.get_Cells().get_Item("Prev Day Close").get_Value()), (object)100));
			val.get_Cells().get_Item("Change OI").set_Value(Operators.SubtractObject(val.get_Cells().get_Item("OI").get_Value(), val.get_Cells().get_Item("Prev Day OI").get_Value()));
			object value2 = val.get_Cells().get_Item("% Change").get_Value();
			if (Operators.ConditionalCompareObjectEqual(value2, (object)0, false))
			{
				val.get_Cells().get_Item("% Change").get_Appearance()
					.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
			}
			else if (Operators.ConditionalCompareObjectGreater(value2, (object)0, false))
			{
				val.get_Cells().get_Item("% Change").get_Appearance()
					.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
			}
			else if (Operators.ConditionalCompareObjectLess(value2, (object)0, false))
			{
				val.get_Cells().get_Item("% Change").get_Appearance()
					.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
			}
			val.get_Cells().get_Item("Change").set_Value(Operators.SubtractObject(val.get_Cells().get_Item("Last Price").get_Value(), val.get_Cells().get_Item("Prev Day Close").get_Value()));
			if (DateAndTime.DateDiff((DateInterval)9, datetime_LastSort, DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1) > 9L)
			{
				((UltraGridBase)ugOptions).get_DisplayLayout().get_Bands().get_Item(0)
					.get_SortedColumns()
					.RefreshSort(false);
				datetime_LastSort = DateAndTime.get_Now();
			}
			val = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Loop_InitializeRow()
	{
		checked
		{
			try
			{
				int num = ((UltraGridBase)ugOptions).get_Rows().get_Count() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						InitializeRow(((UltraGridBase)ugOptions).get_Rows().get_Item(num2));
						num2++;
						continue;
					}
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
