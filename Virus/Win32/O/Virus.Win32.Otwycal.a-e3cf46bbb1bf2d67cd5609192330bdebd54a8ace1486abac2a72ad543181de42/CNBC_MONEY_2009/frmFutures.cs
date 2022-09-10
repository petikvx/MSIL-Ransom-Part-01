using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
public class frmFutures : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("ugFutures")]
	private UltraGrid _ugFutures;

	[AccessedThroughProperty("UltraToolbarsManager1")]
	private UltraToolbarsManager _UltraToolbarsManager1;

	[AccessedThroughProperty("_frmFutures_Toolbars_Dock_Area_Left")]
	private UltraToolbarsDockArea __frmFutures_Toolbars_Dock_Area_Left;

	[AccessedThroughProperty("_frmFutures_Toolbars_Dock_Area_Right")]
	private UltraToolbarsDockArea __frmFutures_Toolbars_Dock_Area_Right;

	[AccessedThroughProperty("_frmFutures_Toolbars_Dock_Area_Top")]
	private UltraToolbarsDockArea __frmFutures_Toolbars_Dock_Area_Top;

	[AccessedThroughProperty("_frmFutures_Toolbars_Dock_Area_Bottom")]
	private UltraToolbarsDockArea __frmFutures_Toolbars_Dock_Area_Bottom;

	[AccessedThroughProperty("OpenFile")]
	private OpenFileDialog _OpenFile;

	[AccessedThroughProperty("SaveFile")]
	private SaveFileDialog _SaveFile;

	[AccessedThroughProperty("UltraGridExcelExporter1")]
	private UltraGridExcelExporter _UltraGridExcelExporter1;

	[AccessedThroughProperty("PowerUDP")]
	private Udp _PowerUDP;

	[AccessedThroughProperty("Timer2_ReSort")]
	private Timer _Timer2_ReSort;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private clsEquity objEquity;

	private string strSQL;

	private DataTable dt;

	private string mon1;

	private string mon2;

	private string mon3;

	private int i;

	private DateTime datetime_LastSort;

	private string strSortColumn;

	private bool strSort;

	private DataTable dtFutures;

	[AccessedThroughProperty("FNONewStock")]
	private frmNewFNOStock _FNONewStock;

	private bool _IsActive;

	private string _ExchangeSymbol;

	internal virtual UltraGrid ugFutures
	{
		[DebuggerNonUserCode]
		get
		{
			return _ugFutures;
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
			if (_ugFutures != null)
			{
				_ugFutures.remove_InitializeLayout(new InitializeLayoutEventHandler(ugFutures_InitializeLayout));
				((UltraGridBase)_ugFutures).remove_AfterSortChange(new BandEventHandler(ugFutures_AfterSortChange));
			}
			_ugFutures = value;
			if (_ugFutures != null)
			{
				_ugFutures.add_InitializeLayout(new InitializeLayoutEventHandler(ugFutures_InitializeLayout));
				((UltraGridBase)_ugFutures).add_AfterSortChange(new BandEventHandler(ugFutures_AfterSortChange));
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

	internal virtual UltraToolbarsDockArea _frmFutures_Toolbars_Dock_Area_Left
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmFutures_Toolbars_Dock_Area_Left;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmFutures_Toolbars_Dock_Area_Left = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmFutures_Toolbars_Dock_Area_Right
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmFutures_Toolbars_Dock_Area_Right;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmFutures_Toolbars_Dock_Area_Right = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmFutures_Toolbars_Dock_Area_Top
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmFutures_Toolbars_Dock_Area_Top;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmFutures_Toolbars_Dock_Area_Top = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmFutures_Toolbars_Dock_Area_Bottom
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmFutures_Toolbars_Dock_Area_Bottom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmFutures_Toolbars_Dock_Area_Bottom = value;
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
			if (_SaveFile != null)
			{
				((FileDialog)_SaveFile).remove_FileOk((CancelEventHandler)SaveFile_FileOk);
			}
			_SaveFile = value;
			if (_SaveFile != null)
			{
				((FileDialog)_SaveFile).add_FileOk((CancelEventHandler)SaveFile_FileOk);
			}
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

	private virtual frmNewFNOStock FNONewStock
	{
		[DebuggerNonUserCode]
		get
		{
			return _FNONewStock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_FNONewStock != null)
			{
				_FNONewStock.StockAdded -= FNONewStock_StockAdded;
				_FNONewStock.RefreshGrid -= FNONewStock_RefreshGrid;
			}
			_FNONewStock = value;
			if (_FNONewStock != null)
			{
				_FNONewStock.StockAdded += FNONewStock_StockAdded;
				_FNONewStock.RefreshGrid += FNONewStock_RefreshGrid;
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

	public string ExchangeSymbol
	{
		get
		{
			return _ExchangeSymbol;
		}
		set
		{
			_ExchangeSymbol = value;
		}
	}

	public frmFutures()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)frmFutures_Load);
		((Form)this).add_FormClosed(new FormClosedEventHandler(frmFutures_FormClosed));
		__ENCList.Add(new WeakReference(this));
		datetime_LastSort = DateAndTime.get_Now();
		strSortColumn = "";
		strSort = true;
		FNONewStock = new frmNewFNOStock();
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
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
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
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Expected O, but got Unknown
		components = new Container();
		UltraGridBand val = new UltraGridBand("Band 0", -1);
		UltraGridColumn val2 = new UltraGridColumn("Exchange Symbol");
		UltraGridColumn val3 = new UltraGridColumn("Bridge Symbol");
		UltraGridColumn val4 = new UltraGridColumn("Scrip Name");
		UltraGridColumn val5 = new UltraGridColumn("Last Price");
		UltraGridColumn val6 = new UltraGridColumn("Change");
		UltraGridColumn val7 = new UltraGridColumn("% Change");
		UltraGridColumn val8 = new UltraGridColumn("Volume");
		UltraGridColumn val9 = new UltraGridColumn("Open Interest");
		UltraGridColumn val10 = new UltraGridColumn("Change OI");
		UltraGridColumn val11 = new UltraGridColumn("OI % Change");
		UltraGridColumn val12 = new UltraGridColumn("RollOver");
		UltraGridColumn val13 = new UltraGridColumn("Basis");
		UltraGridColumn val14 = new UltraGridColumn("Turn Over");
		UltraGridColumn val15 = new UltraGridColumn("Series OI %");
		UltraGridColumn val16 = new UltraGridColumn("Series LTP");
		UltraGridColumn val17 = new UltraGridColumn("Lot Size");
		UltraGridColumn val18 = new UltraGridColumn("Trading Contracts");
		UltraGridColumn val19 = new UltraGridColumn("OI Contracts");
		UltraGridColumn val20 = new UltraGridColumn("OI Change Contracts");
		UltraGridColumn val21 = new UltraGridColumn("OI1");
		UltraGridColumn val22 = new UltraGridColumn("OI2");
		UltraGridColumn val23 = new UltraGridColumn("OI3");
		UltraGridColumn val24 = new UltraGridColumn("Prev Day Close");
		UltraGridColumn val25 = new UltraGridColumn("Expiry Date");
		UltraGridColumn val26 = new UltraGridColumn("Prev Day OI");
		UltraGridColumn val27 = new UltraGridColumn("Spot");
		UltraGridColumn val28 = new UltraGridColumn("Prev Series OI");
		UltraGridColumn val29 = new UltraGridColumn("Prev Series LTP");
		Appearance val30 = new Appearance();
		Appearance val31 = new Appearance();
		Appearance val32 = new Appearance();
		Appearance val33 = new Appearance();
		Appearance val34 = new Appearance();
		Appearance val35 = new Appearance();
		UltraToolbar val36 = new UltraToolbar("UltraToolbar1");
		PopupMenuTool val37 = new PopupMenuTool("File");
		PopupMenuTool val38 = new PopupMenuTool("Manual Add");
		PopupMenuTool val39 = new PopupMenuTool("Advanced");
		PopupMenuTool val40 = new PopupMenuTool("Help");
		PopupMenuTool val41 = new PopupMenuTool("File");
		ButtonTool val42 = new ButtonTool("New");
		ButtonTool val43 = new ButtonTool("Open");
		ButtonTool val44 = new ButtonTool("Refresh");
		ButtonTool val45 = new ButtonTool("SaveAs");
		ButtonTool val46 = new ButtonTool("ExportToExcel");
		PopupMenuTool val47 = new PopupMenuTool("Manual Add");
		ButtonTool val48 = new ButtonTool("NewFuture");
		ButtonTool val49 = new ButtonTool("New");
		Appearance val50 = new Appearance();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmFutures));
		ButtonTool val51 = new ButtonTool("Open");
		Appearance val52 = new Appearance();
		ButtonTool val53 = new ButtonTool("SaveAs");
		Appearance val54 = new Appearance();
		ButtonTool val55 = new ButtonTool("ExportToExcel");
		Appearance val56 = new Appearance();
		ButtonTool val57 = new ButtonTool("NewFuture");
		Appearance val58 = new Appearance();
		ButtonTool val59 = new ButtonTool("Refresh");
		Appearance val60 = new Appearance();
		PopupMenuTool val61 = new PopupMenuTool("Help");
		ButtonTool val62 = new ButtonTool("HelpShortcuts");
		ButtonTool val63 = new ButtonTool("About CNBC Money 2010");
		ButtonTool val64 = new ButtonTool("HelpShortcuts");
		ButtonTool val65 = new ButtonTool("About CNBC Money 2010");
		PopupMenuTool val66 = new PopupMenuTool("Advanced");
		Appearance val67 = new Appearance();
		ButtonTool val68 = new ButtonTool("HideColumns");
		ButtonTool val69 = new ButtonTool("ShowColumns");
		ButtonTool val70 = new ButtonTool("HideColumns");
		Appearance val71 = new Appearance();
		ButtonTool val72 = new ButtonTool("ShowColumns");
		Appearance val73 = new Appearance();
		ugFutures = new UltraGrid();
		UltraToolbarsManager1 = new UltraToolbarsManager(components);
		_frmFutures_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
		_frmFutures_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
		_frmFutures_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
		_frmFutures_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
		OpenFile = new OpenFileDialog();
		SaveFile = new SaveFileDialog();
		UltraGridExcelExporter1 = new UltraGridExcelExporter(components);
		PowerUDP = new Udp(components);
		Timer2_ReSort = new Timer(components);
		Timer1 = new Timer(components);
		((ISupportInitialize)ugFutures).BeginInit();
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
		val12.get_Header().set_VisiblePosition(10);
		val13.get_Header().set_VisiblePosition(11);
		val14.get_Header().set_VisiblePosition(12);
		val15.get_Header().set_VisiblePosition(13);
		val16.get_Header().set_VisiblePosition(14);
		val17.get_Header().set_VisiblePosition(15);
		val18.get_Header().set_VisiblePosition(16);
		val19.get_Header().set_VisiblePosition(17);
		val20.get_Header().set_VisiblePosition(18);
		val21.get_Header().set_VisiblePosition(19);
		val22.get_Header().set_VisiblePosition(20);
		val23.get_Header().set_VisiblePosition(21);
		val24.get_Header().set_VisiblePosition(22);
		val25.get_Header().set_VisiblePosition(23);
		val26.get_Header().set_VisiblePosition(24);
		val27.get_Header().set_VisiblePosition(25);
		val28.get_Header().set_VisiblePosition(26);
		val29.get_Header().set_VisiblePosition(27);
		val.get_Columns().AddRange(new object[28]
		{
			val2, val3, val4, val5, val6, val7, val8, val9, val10, val11,
			val12, val13, val14, val15, val16, val17, val18, val19, val20, val21,
			val22, val23, val24, val25, val26, val27, val28, val29
		});
		val30.set_BackColor(Color.Purple);
		val30.set_BackColor2(Color.Purple);
		val.get_Override().set_SelectedCellAppearance((AppearanceBase)(object)val30);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_BandsSerializer().Add((object)val);
		((UltraGridBase)ugFutures).get_DisplayLayout().set_CaptionVisible((DefaultableBoolean)2);
		((UltraGridBase)ugFutures).get_DisplayLayout().set_MaxColScrollRegions(1);
		((UltraGridBase)ugFutures).get_DisplayLayout().set_MaxRowScrollRegions(1);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_AllowDelete((DefaultableBoolean)2);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_AllowRowFiltering((DefaultableBoolean)1);
		val31.set_BackColor(Color.Transparent);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val31);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_FilterOperatorLocation((FilterOperatorLocation)3);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_FilterUIType((FilterUIType)2);
		val32.set_BackColor(Color.FromArgb(89, 135, 214));
		val32.set_BackColor2(Color.FromArgb(7, 59, 150));
		val32.set_BackGradientStyle((GradientStyle)2);
		val32.get_FontData().set_BoldAsString("True");
		val32.get_FontData().set_Name("Arial");
		val32.get_FontData().set_SizeInPoints(10f);
		val32.set_ForeColor(Color.White);
		val32.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val32);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_HeaderClickAction((HeaderClickAction)2);
		val33.set_BackGradientAlignment((GradientAlignment)3);
		val33.set_BackGradientStyle((GradientStyle)2);
		val33.set_BackHatchStyle((BackHatchStyle)2);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_RowAppearance((AppearanceBase)(object)val33);
		val34.set_BackColor(Color.FromArgb(89, 135, 214));
		val34.set_BackColor2(Color.FromArgb(7, 59, 150));
		val34.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val34);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_RowSelectorNumberStyle((RowSelectorNumberStyle)3);
		val35.set_BackColor(Color.FromArgb(251, 230, 148));
		val35.set_BackColor2(Color.FromArgb(238, 149, 21));
		val35.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val35);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Override().set_SelectTypeRow((SelectType)2);
		((UltraGridBase)ugFutures).get_DisplayLayout().set_ScrollBounds((ScrollBounds)0);
		((Control)ugFutures).set_Dock((DockStyle)5);
		((Control)ugFutures).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraGrid obj = ugFutures;
		Point location = new Point(4, 50);
		((Control)obj).set_Location(location);
		((Control)ugFutures).set_Name("ugFutures");
		UltraGrid obj2 = ugFutures;
		Size size = new Size(1276, 443);
		((Control)obj2).set_Size(size);
		((Control)ugFutures).set_TabIndex(5);
		UltraToolbarsManager1.set_DesignerFlags(1);
		UltraToolbarsManager1.set_DockWithinContainer((Control)(object)this);
		UltraToolbarsManager1.set_Office2007UICompatibility(false);
		UltraToolbarsManager1.get_Ribbon().get_ApplicationMenu().set_Visible(false);
		UltraToolbarsManager1.get_Ribbon().get_QuickAccessToolbar().set_Visible(false);
		UltraToolbarsManager1.get_Ribbon().set_Visible(true);
		UltraToolbarsManager1.set_ShowFullMenusDelay(500);
		val36.set_DockedColumn(0);
		val36.set_DockedRow(0);
		val36.set_Text("UltraToolbar1");
		((ToolsCollectionBase)((UltraToolbarBase)val36).get_Tools()).AddRange((ToolBase[])(object)new ToolBase[4]
		{
			(ToolBase)val37,
			(ToolBase)val38,
			(ToolBase)val39,
			(ToolBase)val40
		});
		UltraToolbarsManager1.get_Toolbars().AddRange((UltraToolbar[])(object)new UltraToolbar[1] { val36 });
		((ToolPropsBase)((ToolBase)val41).get_SharedProps()).set_Caption("File");
		((ToolsCollectionBase)val41.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[5]
		{
			(ToolBase)val42,
			(ToolBase)val43,
			(ToolBase)val44,
			(ToolBase)val45,
			(ToolBase)val46
		});
		((ToolPropsBase)((ToolBase)val47).get_SharedProps()).set_Caption("Manual Add");
		((ToolsCollectionBase)val47.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[1] { (ToolBase)val48 });
		val50.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance7.Image")));
		((ToolPropsBase)((ToolBase)val49).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val50);
		((ToolPropsBase)((ToolBase)val49).get_SharedProps()).set_Caption("New");
		((ToolBase)val49).get_SharedProps().set_Shortcut((Shortcut)131150);
		val52.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance8.Image")));
		((ToolPropsBase)((ToolBase)val51).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val52);
		((ToolPropsBase)((ToolBase)val51).get_SharedProps()).set_Caption("Open");
		((ToolBase)val51).get_SharedProps().set_Shortcut((Shortcut)131151);
		val54.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance9.Image")));
		((ToolPropsBase)((ToolBase)val53).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val54);
		((ToolPropsBase)((ToolBase)val53).get_SharedProps()).set_Caption("Save As");
		((ToolBase)val53).get_SharedProps().set_Shortcut((Shortcut)131155);
		val56.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance10.Image")));
		((ToolPropsBase)((ToolBase)val55).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val56);
		((ToolPropsBase)((ToolBase)val55).get_SharedProps()).set_Caption("Export to Excel");
		((ToolBase)val55).get_SharedProps().set_Shortcut((Shortcut)131141);
		val58.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance11.Image")));
		((ToolPropsBase)((ToolBase)val57).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val58);
		((ToolPropsBase)((ToolBase)val57).get_SharedProps()).set_Caption("New Future");
		((ToolBase)val57).get_SharedProps().set_Shortcut((Shortcut)117);
		val60.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance12.Image")));
		((ToolPropsBase)((ToolBase)val59).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val60);
		((ToolPropsBase)((ToolBase)val59).get_SharedProps()).set_Caption("Refresh");
		((ToolBase)val59).get_SharedProps().set_Shortcut((Shortcut)116);
		((ToolPropsBase)((ToolBase)val61).get_SharedProps()).set_Caption("Help");
		((ToolsCollectionBase)val61.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[2]
		{
			(ToolBase)val62,
			(ToolBase)val63
		});
		((ToolPropsBase)((ToolBase)val64).get_SharedProps()).set_Caption("Help Shortcuts");
		((ToolBase)val64).get_SharedProps().set_Shortcut((Shortcut)112);
		((ToolPropsBase)((ToolBase)val65).get_SharedProps()).set_Caption("About CNBC Money 2010");
		val67.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance13.Image")));
		((ToolPropsBase)((ToolBase)val66).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val67);
		((ToolPropsBase)((ToolBase)val66).get_SharedProps()).set_Caption("Advanced");
		((ToolsCollectionBase)val66.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[2]
		{
			(ToolBase)val68,
			(ToolBase)val69
		});
		val71.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance14.Image")));
		((ToolPropsBase)((ToolBase)val70).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val71);
		((ToolPropsBase)((ToolBase)val70).get_SharedProps()).set_Caption("Hide Columns");
		((ToolBase)val70).get_SharedProps().set_Shortcut((Shortcut)131140);
		val73.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance15.Image")));
		((ToolPropsBase)((ToolBase)val72).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val73);
		((ToolPropsBase)((ToolBase)val72).get_SharedProps()).set_Caption("Show Columns");
		((ToolBase)val72).get_SharedProps().set_Shortcut((Shortcut)196676);
		UltraToolbarsManager1.get_Tools().AddRange((ToolBase[])(object)new ToolBase[14]
		{
			(ToolBase)val41,
			(ToolBase)val47,
			(ToolBase)val49,
			(ToolBase)val51,
			(ToolBase)val53,
			(ToolBase)val55,
			(ToolBase)val57,
			(ToolBase)val59,
			(ToolBase)val61,
			(ToolBase)val64,
			(ToolBase)val65,
			(ToolBase)val66,
			(ToolBase)val70,
			(ToolBase)val72
		});
		((Control)_frmFutures_Toolbars_Dock_Area_Left).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmFutures_Toolbars_Dock_Area_Left).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmFutures_Toolbars_Dock_Area_Left.set_DockedPosition((DockedPosition)2);
		((Control)_frmFutures_Toolbars_Dock_Area_Left).set_ForeColor(SystemColors.ControlText);
		_frmFutures_Toolbars_Dock_Area_Left.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmFutures_Toolbars_Dock_Area_Left = _frmFutures_Toolbars_Dock_Area_Left;
		location = new Point(0, 50);
		((Control)frmFutures_Toolbars_Dock_Area_Left).set_Location(location);
		((Control)_frmFutures_Toolbars_Dock_Area_Left).set_Name("_frmFutures_Toolbars_Dock_Area_Left");
		UltraToolbarsDockArea frmFutures_Toolbars_Dock_Area_Left2 = _frmFutures_Toolbars_Dock_Area_Left;
		size = new Size(4, 443);
		((Control)frmFutures_Toolbars_Dock_Area_Left2).set_Size(size);
		_frmFutures_Toolbars_Dock_Area_Left.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmFutures_Toolbars_Dock_Area_Right).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmFutures_Toolbars_Dock_Area_Right).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmFutures_Toolbars_Dock_Area_Right.set_DockedPosition((DockedPosition)3);
		((Control)_frmFutures_Toolbars_Dock_Area_Right).set_ForeColor(SystemColors.ControlText);
		_frmFutures_Toolbars_Dock_Area_Right.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmFutures_Toolbars_Dock_Area_Right = _frmFutures_Toolbars_Dock_Area_Right;
		location = new Point(1280, 50);
		((Control)frmFutures_Toolbars_Dock_Area_Right).set_Location(location);
		((Control)_frmFutures_Toolbars_Dock_Area_Right).set_Name("_frmFutures_Toolbars_Dock_Area_Right");
		UltraToolbarsDockArea frmFutures_Toolbars_Dock_Area_Right2 = _frmFutures_Toolbars_Dock_Area_Right;
		size = new Size(4, 443);
		((Control)frmFutures_Toolbars_Dock_Area_Right2).set_Size(size);
		_frmFutures_Toolbars_Dock_Area_Right.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmFutures_Toolbars_Dock_Area_Top).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmFutures_Toolbars_Dock_Area_Top).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmFutures_Toolbars_Dock_Area_Top.set_DockedPosition((DockedPosition)0);
		((Control)_frmFutures_Toolbars_Dock_Area_Top).set_ForeColor(SystemColors.ControlText);
		UltraToolbarsDockArea frmFutures_Toolbars_Dock_Area_Top = _frmFutures_Toolbars_Dock_Area_Top;
		location = new Point(0, 0);
		((Control)frmFutures_Toolbars_Dock_Area_Top).set_Location(location);
		((Control)_frmFutures_Toolbars_Dock_Area_Top).set_Name("_frmFutures_Toolbars_Dock_Area_Top");
		UltraToolbarsDockArea frmFutures_Toolbars_Dock_Area_Top2 = _frmFutures_Toolbars_Dock_Area_Top;
		size = new Size(1284, 50);
		((Control)frmFutures_Toolbars_Dock_Area_Top2).set_Size(size);
		_frmFutures_Toolbars_Dock_Area_Top.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmFutures_Toolbars_Dock_Area_Bottom).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmFutures_Toolbars_Dock_Area_Bottom).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmFutures_Toolbars_Dock_Area_Bottom.set_DockedPosition((DockedPosition)1);
		((Control)_frmFutures_Toolbars_Dock_Area_Bottom).set_ForeColor(SystemColors.ControlText);
		_frmFutures_Toolbars_Dock_Area_Bottom.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmFutures_Toolbars_Dock_Area_Bottom = _frmFutures_Toolbars_Dock_Area_Bottom;
		location = new Point(0, 493);
		((Control)frmFutures_Toolbars_Dock_Area_Bottom).set_Location(location);
		((Control)_frmFutures_Toolbars_Dock_Area_Bottom).set_Name("_frmFutures_Toolbars_Dock_Area_Bottom");
		UltraToolbarsDockArea frmFutures_Toolbars_Dock_Area_Bottom2 = _frmFutures_Toolbars_Dock_Area_Bottom;
		size = new Size(1284, 4);
		((Control)frmFutures_Toolbars_Dock_Area_Bottom2).set_Size(size);
		_frmFutures_Toolbars_Dock_Area_Bottom.set_ToolbarsManager(UltraToolbarsManager1);
		((FileDialog)OpenFile).set_DefaultExt("TV18");
		((FileDialog)OpenFile).set_Filter("Text files (*.TV_FNO18)|*.TVFNO18|\" & \"All files|*.*");
		PowerUDP.set_Editor((object)PowerUDP);
		Timer2_ReSort.set_Interval(5000);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(300000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(1284, 497);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ugFutures);
		((Control)this).get_Controls().Add((Control)(object)_frmFutures_Toolbars_Dock_Area_Left);
		((Control)this).get_Controls().Add((Control)(object)_frmFutures_Toolbars_Dock_Area_Right);
		((Control)this).get_Controls().Add((Control)(object)_frmFutures_Toolbars_Dock_Area_Top);
		((Control)this).get_Controls().Add((Control)(object)_frmFutures_Toolbars_Dock_Area_Bottom);
		((Control)this).set_Name("frmFutures");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_Text("FUTURES");
		((ISupportInitialize)ugFutures).EndInit();
		((ISupportInitialize)UltraToolbarsManager1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmFutures_Load(object sender, EventArgs e)
	{
		try
		{
			IsActive = true;
			objEquity = new clsEquity();
			strSQL = "SELECT ISNULL(SORT_COLUMN,'') AS SORT_COLUMN, ISNULL(SORT_INDICATOR,0) AS SORT_INDICATOR FROM CNBCMONEY_USERS_MST  WHERE USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX = -1";
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
			objEquity.Update_ConnectedUsers(-1);
			((Control)ugFutures).Focus();
			PowerUDP_Connect();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void frmFutures_FormClosed(object sender, FormClosedEventArgs e)
	{
		try
		{
			objEquity = new clsEquity();
			objEquity.DeActivateTab(-1, strSortColumn, Conversions.ToString(strSort));
			PowerUDP.Close();
			((Component)(object)PowerUDP).Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void FNONewStock_RefreshGrid()
	{
		BindGridData();
	}

	private void FNONewStock_StockAdded(string strBridgeSymbol)
	{
		AddFNONewStock(strBridgeSymbol, 0, isAddnew: true);
	}

	private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		switch (Strings.UCase(((ToolEventArgs)e).get_Tool().get_Key()))
		{
		case "NEW":
			File_New();
			break;
		case "OPEN":
			File_Open();
			break;
		case "SAVEAS":
			Save_Futures();
			break;
		case "EXPORTTOEXCEL":
			((FileDialog)SaveFile).set_Filter("xls (*.xls)|*.xls|All files|*.*");
			((CommonDialog)SaveFile).ShowDialog();
			break;
		case "NEWFUTURE":
			FNONewStock = new frmNewFNOStock();
			((Form)FNONewStock).ShowDialog();
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
		case "SHOWCOLUMNS":
			AdvancedColumns(showhide: false);
			break;
		case "HIDECOLUMNS":
			AdvancedColumns(showhide: true);
			break;
		}
	}

	private void ugFutures_AfterSortChange(object sender, BandEventArgs e)
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

	private void ugFutures_InitializeLayout(object sender, InitializeLayoutEventArgs e)
	{
		e.get_Layout().get_Appearance().get_FontData()
			.set_Name(MySettingsProperty.Settings.FONT_DATA);
		e.get_Layout().get_Appearance().get_FontData()
			.set_SizeInPoints(Conversions.ToSingle(MySettingsProperty.Settings.FONT_SIZE));
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
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Expiry Date")
				.set_Format("dd-MM-yyyy");
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Basis")
				.set_Format("0.00");
		}
	}

	private void SaveFile_FileOk(object sender, CancelEventArgs e)
	{
		try
		{
			UltraGridExcelExporter1.Export(ugFutures, ((FileDialog)SaveFile).get_FileName());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			mdlMain.ShowMessage("Specified Path Does Not Exist", "Invalid File Name");
			ProjectData.ClearProjectError();
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
			if ((Strings.Len(text) > 0) & IsActive)
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

	private void Timer2_ReSort_Tick(object sender, EventArgs e)
	{
		Timer2_ReSort.set_Enabled(false);
		((UltraGridBase)ugFutures).get_DisplayLayout().get_Bands().get_Item(0)
			.get_SortedColumns()
			.RefreshSort(false);
		Timer2_ReSort.set_Enabled(true);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.set_Enabled(false);
		objEquity = new clsEquity();
		objEquity.Update_DateTime(-1);
		Timer1.set_Enabled(true);
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
			int num = 1;
			strSQL = "Select  Distinct(Expiry_Date) from FNO_TRANSACTION_DATA order  by expiry_DATE";
			try
			{
				SqlDataReader val = SqlHelper.ExecuteReader(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
				while (val.Read())
				{
					string text = ((Strings.Len(DateAndTime.Month(Conversions.ToDate(val.get_Item(0)))) != 1) ? Conversions.ToString(DateAndTime.Month(Conversions.ToDate(val.get_Item(0)))) : ("0" + Conversions.ToString(DateAndTime.Month(Conversions.ToDate(val.get_Item(0))))));
					switch (num)
					{
					case 1:
						mon1 = text;
						break;
					case 2:
						mon2 = text;
						break;
					case 3:
						mon3 = text;
						break;
					}
					num = checked(num + 1);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				((Form)this).Close();
				ProjectData.ClearProjectError();
			}
			strSQL = "Select Exchangesymbol AS [Exchange Symbol],BRIDGESYMBOL AS [Bridge Symbol]  , [Scrip Name] = isnull((Select top 1 Name from VehicleType VT Join vehicle_exchange b on VT.code=b.code where b.Symbol=a.BRIDGESymbol),exchangesymbol) ,  CONVERT(VARCHAR,Expiry_Date,105) AS [Expiry Date],ISNULL(LastPrice,0) as [Last Price],ISNULL(convert(decimal(10,2), [LastPrice]-[Close]),0) as Change,ISNULL(convert(decimal(10,2), (([lastprice] - [close]) / [close] * 100)),0) as [% Change],ISNULL(convert(decimal(10,0), Volume),0) as Volume,ISNULL([CLOSE],0) as [Prev Day Close]  , ISNULL(Open_Interest,0) as [OI],ISNULL(prevday_Open_Interest,0) as [Prev Day OI] , OI1 =ISNULL((Select ISNULL(Open_Interest,0) from FNO_transaction_data where ExchangeSymbol=a.ExchangeSymbol and month(expiry_date)='" + mon1 + "'),0)  , OI2 =ISNULL((Select ISNULL(Open_Interest,0) from FNO_transaction_data where ExchangeSymbol=a.ExchangeSymbol and month(expiry_date)='" + mon2 + "'),0)  , OI3 =ISNULL((Select ISNULL(Open_Interest,0) from FNO_transaction_data where ExchangeSymbol=a.ExchangeSymbol and month(expiry_date)='" + mon3 + "'),0)  , Spot =ISNULL((Select top 1 lastPRICE from Equity_transaction_data where Exchangesymbol=A.Exchangesymbol AND Market_type='N' and Series in ('EQ','BE')),0)  , isnull(PrevSeries_OI,'1') AS [Prev Series OI] , isnull(PrevSeries_LTP,'1') AS [Prev Series LTP], 0.00 AS [Basis],0.00  as [Series LTP] , ISNULL(LOTSIZE,1) as [Lot Size], ([Open_Interest] - [prevday_Open_Interest]) as [Change OI] , (([Open_Interest] - [PrevSeries_OI])/ [PrevSeries_OI]) * 100 AS [Series OI] , ISNULL(convert(decimal(10,2), (([Open_Interest] - [prevday_Open_Interest]) / [prevday_Open_Interest] * 100)),0) as [OI % Change] , (convert(decimal(10,0), Volume) * ISNULL(LastPrice,0)) as [Turn Over], 0 AS RollOver , (convert(decimal(10,0), Volume) / ISNULL(LOTSIZE,1)) as [Trading Contracts] , (ISNULL(Open_Interest,0) / ISNULL(LOTSIZE,1)) as [OI Contracts] , ((ISNULL(Open_Interest,0)-ISNULL(prevday_Open_Interest,0)) / ISNULL(LOTSIZE,1)) as [OI Change Contracts]   from FNO_transaction_data a    where BridgeSymbol IN (SELECT BRIDGESYMBOL FROM vw_CNBCMONEY_DETAILS WHERE TABINDEX = -1 AND  USERNAME = '" + mdlMain.gUserName + "')  and [CLOSE]<>0 and [prevday_Open_Interest]<>0 order by BridgeSymbol,expiry_date";
			dtFutures = new DataTable();
			dtFutures = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
			((UltraGridBase)ugFutures).set_DataSource((object)dtFutures);
			if (Operators.CompareString(strSortColumn, "", false) != 0)
			{
				((UltraGridBase)ugFutures).get_DisplayLayout().get_Bands().get_Item(0)
					.get_Columns()
					.get_Item(strSortColumn)
					.set_SortIndicator((SortIndicator)Conversions.ToInteger(Interaction.IIf(strSort, (object)(SortIndicator)2, (object)(SortIndicator)1)));
			}
			Loop_InitializeRow();
			((UltraGridBase)ugFutures).UpdateData();
			((Form)money_Splash).Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
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
			if (((UltraGridBase)ugFutures).get_Rows().get_Count() > 0)
			{
				MsgBoxResult val = Interaction.MsgBox((object)" The Current item list has unsaved changes.Would you like to save them now?", (MsgBoxStyle)3, (object)null);
				if ((int)val == 6)
				{
					Save_Futures();
				}
				objEquity = new clsEquity();
				objEquity.DeletePortFolio("FNO", -1);
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

	private void Save_Futures()
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
				RowEnumerator enumerator = ((UltraGridBase)ugFutures).get_Rows().GetEnumerator();
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

	private bool AddFNONewStock(string strBridgeSymbol, int rowID = 0, bool isAddnew = false)
	{
		checked
		{
			bool result = default(bool);
			try
			{
				strSQL = "Select Exchangesymbol AS [Exchange Symbol],BRIDGESYMBOL AS [Bridge Symbol]  , [Scrip Name] = isnull((Select top 1 Name from VehicleType VT Join vehicle_exchange b on VT.code=b.code where b.Symbol=a.BRIDGESymbol),exchangesymbol) ,  CONVERT(VARCHAR,Expiry_Date,105) AS [Expiry Date],ISNULL(LastPrice,0) as [Last Price],ISNULL(convert(decimal(10,2), [LastPrice]-[Close]),0) as Change,ISNULL(convert(decimal(10,2), (([lastprice] - [close]) / [close] * 100)),0) as [% Change],ISNULL(convert(decimal(10,0), Volume),0) as Volume,ISNULL([CLOSE],0) as [Prev Day Close]  , ISNULL(Open_Interest,0) as [OI],ISNULL(prevday_Open_Interest,0) as [Prev Day OI] , OI1 =ISNULL((Select ISNULL(Open_Interest,0) from FNO_transaction_data where ExchangeSymbol=a.ExchangeSymbol and month(expiry_date)='" + mon1 + "'),0)  , OI2 =ISNULL((Select ISNULL(Open_Interest,0) from FNO_transaction_data where ExchangeSymbol=a.ExchangeSymbol and month(expiry_date)='" + mon2 + "'),0)  , OI3 =ISNULL((Select ISNULL(Open_Interest,0) from FNO_transaction_data where ExchangeSymbol=a.ExchangeSymbol and month(expiry_date)='" + mon3 + "'),0)  , Spot =ISNULL((Select top 1 lastPRICE from Equity_transaction_data where Exchangesymbol=A.Exchangesymbol AND Market_type='N' and Series in ('EQ','BE')),0)  , isnull(PrevSeries_OI,'1') AS [Prev Series OI] , isnull(PrevSeries_LTP,'1') AS [Prev Series LTP], 0.00 AS [Basis],0.00  as [Series LTP] , ISNULL(LOTSIZE,1) as [Lot Size], ([Open_Interest] - [prevday_Open_Interest]) as [Change OI] , (([Open_Interest] - [PrevSeries_OI])/ [PrevSeries_OI]) * 100 AS [Series OI] , ISNULL(convert(decimal(10,2), (([Open_Interest] - [prevday_Open_Interest]) / [prevday_Open_Interest] * 100)),0) as [OI % Change] , (convert(decimal(10,0), Volume) * ISNULL(LastPrice,0)) as [Turn Over], 0 AS RollOver , (convert(decimal(10,0), Volume) / ISNULL(LOTSIZE,1)) as [Trading Contracts] , (ISNULL(Open_Interest,0) / ISNULL(LOTSIZE,1)) as [OI Contracts] , ((ISNULL(Open_Interest,0)-ISNULL(prevday_Open_Interest,0)) / ISNULL(LOTSIZE,1)) as [OI Change Contracts]   from FNO_transaction_data a    where [CLOSE]<>0 and [prevday_Open_Interest]<>0 ";
				if ((Operators.CompareString(strBridgeSymbol, "", false) != 0) & (Operators.CompareString(strBridgeSymbol, "All", false) != 0))
				{
					strSQL = strSQL + " AND BridgeSymbol LIKE '" + strBridgeSymbol + "%'";
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
							DataRow dataRow = dtFutures.NewRow();
							dataRow.ItemArray = dt.Rows[i].ItemArray;
							dtFutures.Rows.Add(dataRow);
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
						((UltraGridBase)ugFutures).get_Rows().get_Item(rowID).get_Cells()
							.get_Item(dt.Columns[i].ColumnName)
							.set_Value(RuntimeHelpers.GetObjectValue(dt.Rows[0][dt.Columns[i].ColumnName]));
						i++;
					}
				}
				InitializeRow(((UltraGridBase)ugFutures).get_Rows().get_Item(((UltraGridBase)ugFutures).get_Rows().get_Count() - 1));
				((UltraGridBase)ugFutures).get_DisplayLayout().get_Bands().get_Item(0)
					.get_SortedColumns()
					.RefreshSort(false);
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
			PowerUDP.Open(objEquity.getMyIP(), 15008);
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
			if (Strings.InStr(1, aa, "AAA", (CompareMethod)0) > 0)
			{
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
						RowEnumerator enumerator = ((UltraGridBase)ugFutures).get_Rows().GetEnumerator();
						while (enumerator.MoveNext())
						{
							UltraGridRow current = enumerator.get_Current();
							if (!((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "FN", (CompareMethod)0) > 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(current.get_Cells().get_Item("Exchange Symbol").get_Text())), Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false) == 0) & (Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)), "FUT", (CompareMethod)0) > 0)) || Operators.CompareString(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Expiry Date").get_Value())), Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))), false) != 0)
							{
								if ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "FI", (CompareMethod)0) > 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(current.get_Cells().get_Item("Exchange Symbol").get_Text())), Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false) == 0) & (Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)), "FUT", (CompareMethod)0) > 0))
								{
									if (Operators.CompareString(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Expiry Date").get_Value())), Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))), false) == 0)
									{
										current.get_Cells().get_Item("OI").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("Change OI").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Operators.SubtractObject(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("prev day OI").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("OI Contracts").set_Value((object)Strings.FormatNumber((object)(Conversions.ToDouble(current.get_Cells().get_Item("OI").get_Value()) / Conversions.ToDouble(current.get_Cells().get_Item("Lot Size").get_Value())), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("OI Change Contracts").set_Value((object)Strings.FormatNumber((object)(Conversions.ToDouble(current.get_Cells().get_Item("Change OI").get_Value()) / Conversions.ToDouble(current.get_Cells().get_Item("Lot Size").get_Value())), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("OI % Change").set_Value((object)Strings.FormatNumber(Operators.MultiplyObject(Operators.DivideObject(current.get_Cells().get_Item("Change OI").get_Value(), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("prev day OI").get_Value()))), (object)100), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("Series OI").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Prev Series OI").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
									}
									if (Strings.InStr(1, Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))), "-" + Strings.Trim(mon1) + "-", (CompareMethod)0) > 0)
									{
										current.get_Cells().get_Item("OI1").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
									}
									if (Strings.InStr(1, Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))), "-" + Strings.Trim(mon2) + "-", (CompareMethod)0) > 0)
									{
										current.get_Cells().get_Item("OI2").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
									}
									if (Strings.InStr(1, Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))), "-" + Strings.Trim(mon3) + "-", (CompareMethod)0) > 0)
									{
										current.get_Cells().get_Item("OI3").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
									}
									if (Conversions.ToDouble(current.get_Cells().get_Item("OI1").get_Value()) + Conversions.ToDouble(current.get_Cells().get_Item("OI2").get_Value()) + Conversions.ToDouble(current.get_Cells().get_Item("OI3").get_Value()) > 0.0)
									{
										current.get_Cells().get_Item("Rollover").set_Value((object)Math.Round(Conversions.ToDouble(current.get_Cells().get_Item("OI2").get_Value()) / (Conversions.ToDouble(current.get_Cells().get_Item("OI1").get_Value()) + Conversions.ToDouble(current.get_Cells().get_Item("OI2").get_Value()) + Conversions.ToDouble(current.get_Cells().get_Item("OI3").get_Value())) * 100.0, 2));
									}
									InitializeRow(current);
								}
								continue;
							}
							if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Last Price").get_Value(), (object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false))
							{
								current.get_Cells().get_Item("Last Price").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("Change").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Operators.SubtractObject(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Prev day Close").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("% Change").set_Value((object)Strings.FormatNumber(Operators.MultiplyObject(Operators.DivideObject(current.get_Cells().get_Item("Change").get_Value(), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Prev day Close").get_Value()))), (object)100), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("Basis").set_Value((object)Strings.FormatNumber((object)(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)) - Conversions.ToDouble(current.get_Cells().get_Item("Spot").get_Value())), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("Series LTP").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Operators.SubtractObject(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Prev Series LTP").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
							}
							if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Volume").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 12 }, (string[])null)))), false))
							{
								current.get_Cells().get_Item("Volume").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 12 }, (string[])null)))));
							}
							current.get_Cells().get_Item("TURN OVER").set_Value((object)Strings.FormatNumber((object)(Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) * Conversions.ToDouble(current.get_Cells().get_Item("Volume").get_Value())), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
							current.get_Cells().get_Item("Trading Contracts").set_Value((object)Strings.FormatNumber((object)(Conversions.ToDouble(current.get_Cells().get_Item("Volume").get_Value()) / Conversions.ToDouble(current.get_Cells().get_Item("Lot Size").get_Value())), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
							if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Prev day Close").get_Value()))) > 0.0)
							{
								current.get_Cells().get_Item("Change").set_Value(RuntimeHelpers.GetObjectValue(current.get_Cells().get_Item("Change").get_Value()));
								current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
							}
							else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Prev day Close").get_Value()))) < 0.0)
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
			else
			{
				if (Strings.InStr(1, Strings.Trim(aa), "|", (CompareMethod)0) <= 0)
				{
					return;
				}
				Array array2 = Strings.Split(aa, "|", -1, (CompareMethod)0);
				RowEnumerator enumerator2 = ((UltraGridBase)ugFutures).get_Rows().GetEnumerator();
				UltraGridRow current2;
				while (true)
				{
					if (!enumerator2.MoveNext())
					{
						return;
					}
					current2 = enumerator2.get_Current();
					if (((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "FN", (CompareMethod)0) > 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(current2.get_Cells().get_Item("Exchange Symbol").get_Text())), Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false) == 0)) && Operators.CompareString(Strings.Trim(Conversions.ToString(current2.get_Cells().get_Item("Expiry Date").get_Value())), Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 4 }, (string[])null))), false) == 0)
					{
						break;
					}
					if ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "FI", (CompareMethod)0) > 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(current2.get_Cells().get_Item("Exchange Symbol").get_Text())), Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false) == 0))
					{
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(current2.get_Cells().get_Item("Expiry Date").get_Value())), Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))), false) == 0)
						{
							current2.get_Cells().get_Item("OI").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
							current2.get_Cells().get_Item("Change OI").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Operators.SubtractObject(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null), (object)Strings.Trim(Conversions.ToString(current2.get_Cells().get_Item("prev day OI").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
							current2.get_Cells().get_Item("OI Contracts").set_Value((object)Strings.FormatNumber((object)(Conversions.ToDouble(current2.get_Cells().get_Item("OI").get_Value()) / Conversions.ToDouble(current2.get_Cells().get_Item("Lot Size").get_Value())), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
							current2.get_Cells().get_Item("OI Change Contracts").set_Value((object)Strings.FormatNumber((object)(Conversions.ToDouble(current2.get_Cells().get_Item("Change OI").get_Value()) / Conversions.ToDouble(current2.get_Cells().get_Item("Lot Size").get_Value())), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
						}
						if (Strings.InStr(1, Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))), "-" + Strings.Trim(mon1) + "-", (CompareMethod)0) > 0)
						{
							current2.get_Cells().get_Item("OI1").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
						}
						if (Strings.InStr(1, Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))), "-" + Strings.Trim(mon2) + "-", (CompareMethod)0) > 0)
						{
							current2.get_Cells().get_Item("OI2").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
						}
						if (Strings.InStr(1, Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null))), "-" + Strings.Trim(mon3) + "-", (CompareMethod)0) > 0)
						{
							current2.get_Cells().get_Item("OI3").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
						}
						if (Conversions.ToDouble(current2.get_Cells().get_Item("OI1").get_Value()) + Conversions.ToDouble(current2.get_Cells().get_Item("OI2").get_Value()) + Conversions.ToDouble(current2.get_Cells().get_Item("OI3").get_Value()) > 0.0)
						{
							current2.get_Cells().get_Item("Rollover").set_Value((object)Math.Round(Conversions.ToDouble(current2.get_Cells().get_Item("OI2").get_Value()) / (Conversions.ToDouble(current2.get_Cells().get_Item("OI1").get_Value()) + Conversions.ToDouble(current2.get_Cells().get_Item("OI2").get_Value()) + Conversions.ToDouble(current2.get_Cells().get_Item("OI3").get_Value()) * 100.0), 4));
						}
						InitializeRow(current2);
					}
				}
				if (Operators.ConditionalCompareObjectNotEqual(current2.get_Cells().get_Item("Last Price").get_Value(), (object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false))
				{
					current2.get_Cells().get_Item("Last Price").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
					current2.get_Cells().get_Item("Change").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Operators.SubtractObject(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null), (object)Strings.Trim(Conversions.ToString(current2.get_Cells().get_Item("Prev day Close").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
					current2.get_Cells().get_Item("% Change").set_Value((object)Strings.FormatNumber(Operators.MultiplyObject(Operators.DivideObject(current2.get_Cells().get_Item("Change").get_Value(), (object)Strings.Trim(Conversions.ToString(current2.get_Cells().get_Item("Prev day Close").get_Value()))), (object)100), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
					current2.get_Cells().get_Item("Basis").set_Value((object)Strings.FormatNumber((object)(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)) - Conversions.ToDouble(current2.get_Cells().get_Item("Spot").get_Value())), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
					current2.get_Cells().get_Item("Series LTP").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Operators.SubtractObject(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null), (object)Strings.Trim(Conversions.ToString(current2.get_Cells().get_Item("Prev Series LTP").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
				}
				if (Operators.ConditionalCompareObjectNotEqual(current2.get_Cells().get_Item("Volume").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 12 }, (string[])null)))), false))
				{
					current2.get_Cells().get_Item("Volume").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 12 }, (string[])null)))));
				}
				current2.get_Cells().get_Item("TURN OVER").set_Value((object)Strings.FormatNumber((object)(Conversions.ToDouble(current2.get_Cells().get_Item("Last Price").get_Value()) * Conversions.ToDouble(current2.get_Cells().get_Item("Volume").get_Value())), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
				current2.get_Cells().get_Item("Trading Contracts").set_Value((object)Strings.FormatNumber((object)(Conversions.ToDouble(current2.get_Cells().get_Item("Volume").get_Value()) / Conversions.ToDouble(current2.get_Cells().get_Item("Lot Size").get_Value())), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
				if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current2.get_Cells().get_Item("Prev day Close").get_Value()))) > 0.0)
				{
					current2.get_Cells().get_Item("Change").set_Value(RuntimeHelpers.GetObjectValue(current2.get_Cells().get_Item("Change").get_Value()));
					current2.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
				}
				else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current2.get_Cells().get_Item("Prev day Close").get_Value()))) < 0.0)
				{
					current2.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
				}
				else
				{
					current2.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
				}
				InitializeRow(current2);
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
			val.get_Cells().get_Item("Basis").set_Value((object)(Conversions.ToDouble(val.get_Cells().get_Item("Last Price").get_Value()) - Conversions.ToDouble(val.get_Cells().get_Item("spot").get_Value())));
			if (Operators.ConditionalCompareObjectEqual(val.get_Cells().get_Item("Prev Series LTP").get_Value(), (object)"0", false))
			{
				val.get_Cells().get_Item("Prev Series LTP").set_Value((object)"1");
			}
			else
			{
				val.get_Cells().get_Item("Prev Series LTP").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(val.get_Cells().get_Item("Prev Series LTP").get_Value()))), -1, (TriState)(-2), (TriState)0, (TriState)(-2)));
			}
			val.get_Cells().get_Item("Series LTP").set_Value((object)Strings.FormatNumber((object)(Conversions.ToDouble(val.get_Cells().get_Item("Last Price").get_Value()) - Conversions.ToDouble(val.get_Cells().get_Item("Prev Series LTP").get_Value())), 2, (TriState)(-1), (TriState)0, (TriState)(-2)));
			if (Conversions.ToDouble(val.get_Cells().get_Item("OI1").get_Value()) + Conversions.ToDouble(val.get_Cells().get_Item("OI2").get_Value()) + Conversions.ToDouble(val.get_Cells().get_Item("OI3").get_Value()) == Conversions.ToDouble("0"))
			{
				val.get_Cells().get_Item("Rollover").set_Value((object)0);
			}
			else
			{
				val.get_Cells().get_Item("Rollover").set_Value((object)(Conversions.ToDouble(val.get_Cells().get_Item("OI2").get_Value()) / (Conversions.ToDouble(val.get_Cells().get_Item("OI1").get_Value()) + Conversions.ToDouble(val.get_Cells().get_Item("OI2").get_Value()) + Conversions.ToDouble(val.get_Cells().get_Item("OI3").get_Value())) * 100.0));
			}
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
			object value2 = val.get_Cells().get_Item("OI % Change").get_Value();
			if (Operators.ConditionalCompareObjectEqual(value2, (object)0, false))
			{
				val.get_Cells().get_Item("OI % Change").get_Appearance()
					.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
			}
			else if (Operators.ConditionalCompareObjectGreater(value2, (object)0, false))
			{
				val.get_Cells().get_Item("OI % Change").get_Appearance()
					.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
			}
			else if (Operators.ConditionalCompareObjectLess(value2, (object)0, false))
			{
				val.get_Cells().get_Item("OI % Change").get_Appearance()
					.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
			}
			if (DateAndTime.DateDiff((DateInterval)9, datetime_LastSort, DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1) > 9L)
			{
				((UltraGridBase)ugFutures).get_DisplayLayout().get_Bands().get_Item(0)
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
				int num = ((UltraGridBase)ugFutures).get_Rows().get_Count() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						InitializeRow(((UltraGridBase)ugFutures).get_Rows().get_Item(num2));
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

	private void AdvancedColumns(bool showhide)
	{
		try
		{
			((UltraGridBase)ugFutures).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Exchange Symbol")
				.set_Hidden(showhide);
			((UltraGridBase)ugFutures).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Market Type")
				.set_Hidden(showhide);
			((UltraGridBase)ugFutures).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Series")
				.set_Hidden(showhide);
			((UltraGridBase)ugFutures).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Upper Circuit")
				.set_Hidden(showhide);
			((UltraGridBase)ugFutures).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Lower Circuit")
				.set_Hidden(showhide);
			((UltraGridBase)ugFutures).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Week Close")
				.set_Hidden(showhide);
			((UltraGridBase)ugFutures).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Month Close")
				.set_Hidden(showhide);
			((UltraGridBase)ugFutures).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Year Close")
				.set_Hidden(showhide);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
