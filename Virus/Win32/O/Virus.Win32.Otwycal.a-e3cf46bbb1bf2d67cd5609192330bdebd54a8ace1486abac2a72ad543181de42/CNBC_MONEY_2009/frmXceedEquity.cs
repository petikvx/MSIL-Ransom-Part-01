#define DEBUG
using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
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
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using Infragistics.Win.UltraWinToolbars;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Xceed.Grid;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmXceedEquity : Form
{
	private delegate void Delg_SortColumn();

	private delegate void Delg_CrunchData(string str);

	private delegate void ChangeText(string strGroup, string strTool, string theTextString);

	public delegate void MarketWatchEventHandler();

	public delegate void Rename_MDI_TabEventHandler(string strTabName);

	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("UltraToolbarsManager1")]
	private UltraToolbarsManager _UltraToolbarsManager1;

	[AccessedThroughProperty("_InheritedForm_Toolbars_Dock_Area_Left")]
	private UltraToolbarsDockArea __InheritedForm_Toolbars_Dock_Area_Left;

	[AccessedThroughProperty("_InheritedForm_Toolbars_Dock_Area_Right")]
	private UltraToolbarsDockArea __InheritedForm_Toolbars_Dock_Area_Right;

	[AccessedThroughProperty("_InheritedForm_Toolbars_Dock_Area_Top")]
	private UltraToolbarsDockArea __InheritedForm_Toolbars_Dock_Area_Top;

	[AccessedThroughProperty("_InheritedForm_Toolbars_Dock_Area_Bottom")]
	private UltraToolbarsDockArea __InheritedForm_Toolbars_Dock_Area_Bottom;

	[AccessedThroughProperty("UltraGridExcelExporter1")]
	private UltraGridExcelExporter _UltraGridExcelExporter1;

	[AccessedThroughProperty("SaveFile")]
	private SaveFileDialog _SaveFile;

	[AccessedThroughProperty("OpenFile")]
	private OpenFileDialog _OpenFile;

	[AccessedThroughProperty("PowerTCP")]
	private Tcp _PowerTCP;

	[AccessedThroughProperty("PowerUDP")]
	private Udp _PowerUDP;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("ugEquity")]
	private UltraGrid _ugEquity;

	[AccessedThroughProperty("XgEquity")]
	private GridControl _XgEquity;

	[AccessedThroughProperty("dataRowTemplate1")]
	private DataRow _dataRowTemplate1;

	[AccessedThroughProperty("GroupByRow1")]
	private GroupByRow _GroupByRow1;

	[AccessedThroughProperty("ColumnManagerRow1")]
	private ColumnManagerRow _ColumnManagerRow1;

	private string strSQL;

	private string strChart;

	private DataSet ds;

	private DataTable dtEquity;

	private DataTable dt;

	private int i;

	private string strSortColumn;

	private bool strSort;

	private string DeleteExchangeSymbol;

	private clsEquity objEquity;

	private int RowIndex;

	private int CellIndex;

	private string U_COLOR;

	private string D_COLOR;

	private string UN_COLOR;

	private string BG_COLOR;

	[AccessedThroughProperty("NewStock")]
	private frmNewStock _NewStock;

	[AccessedThroughProperty("FeedRanking")]
	private frmFeedRanking _FeedRanking;

	private MarketWatchEventHandler MarketWatchEvent;

	private Rename_MDI_TabEventHandler Rename_MDI_TabEvent;

	private int _TabIndex;

	private string _Tab_Name;

	private bool Start_PowerUDP;

	private bool IsActive;

	private bool IsAdvance;

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
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			if (_UltraToolbarsManager1 != null)
			{
				_UltraToolbarsManager1.remove_ToolValueChanged(new ToolEventHandler(UltraToolbarsManager1_ToolValueChanged));
				_UltraToolbarsManager1.remove_AfterToolExitEditMode(new AfterToolExitEditModeEventHandler(UltraToolbarsManager1_AfterToolExitEditMode));
				_UltraToolbarsManager1.remove_ToolClick(new ToolClickEventHandler(UltraToolbarsManager1_ToolClick));
			}
			_UltraToolbarsManager1 = value;
			if (_UltraToolbarsManager1 != null)
			{
				_UltraToolbarsManager1.add_ToolValueChanged(new ToolEventHandler(UltraToolbarsManager1_ToolValueChanged));
				_UltraToolbarsManager1.add_AfterToolExitEditMode(new AfterToolExitEditModeEventHandler(UltraToolbarsManager1_AfterToolExitEditMode));
				_UltraToolbarsManager1.add_ToolClick(new ToolClickEventHandler(UltraToolbarsManager1_ToolClick));
			}
		}
	}

	internal virtual UltraToolbarsDockArea _InheritedForm_Toolbars_Dock_Area_Left
	{
		[DebuggerNonUserCode]
		get
		{
			return __InheritedForm_Toolbars_Dock_Area_Left;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__InheritedForm_Toolbars_Dock_Area_Left = value;
		}
	}

	internal virtual UltraToolbarsDockArea _InheritedForm_Toolbars_Dock_Area_Right
	{
		[DebuggerNonUserCode]
		get
		{
			return __InheritedForm_Toolbars_Dock_Area_Right;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__InheritedForm_Toolbars_Dock_Area_Right = value;
		}
	}

	internal virtual UltraToolbarsDockArea _InheritedForm_Toolbars_Dock_Area_Top
	{
		[DebuggerNonUserCode]
		get
		{
			return __InheritedForm_Toolbars_Dock_Area_Top;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__InheritedForm_Toolbars_Dock_Area_Top = value;
		}
	}

	internal virtual UltraToolbarsDockArea _InheritedForm_Toolbars_Dock_Area_Bottom
	{
		[DebuggerNonUserCode]
		get
		{
			return __InheritedForm_Toolbars_Dock_Area_Bottom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__InheritedForm_Toolbars_Dock_Area_Bottom = value;
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

	internal virtual Tcp PowerTCP
	{
		[DebuggerNonUserCode]
		get
		{
			return _PowerTCP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PowerTCP = value;
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

	internal virtual UltraGrid ugEquity
	{
		[DebuggerNonUserCode]
		get
		{
			return _ugEquity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected O, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected O, but got Unknown
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Expected O, but got Unknown
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			if (_ugEquity != null)
			{
				_ugEquity.remove_InitializeLayout(new InitializeLayoutEventHandler(ugEquity_InitializeLayout));
				_ugEquity.remove_CellChange(new CellEventHandler(ugEquity_CellChange));
				_ugEquity.remove_BeforeRowsDeleted(new BeforeRowsDeletedEventHandler(ugEquity_BeforeRowsDeleted));
				((UltraGridBase)_ugEquity).remove_AfterSortChange(new BandEventHandler(ugEquity_AfterSortChange));
				_ugEquity.remove_InitializeRow(new InitializeRowEventHandler(ugEquity_InitializeRow));
				_ugEquity.remove_AfterRowsDeleted((EventHandler)ugEquity_AfterRowsDeleted);
				_ugEquity.remove_AfterRowInsert(new RowEventHandler(ugEquity_AfterRowInsert));
				_ugEquity.remove_AfterCellUpdate(new CellEventHandler(ugEquity_AfterCellUpdate));
			}
			_ugEquity = value;
			if (_ugEquity != null)
			{
				_ugEquity.add_InitializeLayout(new InitializeLayoutEventHandler(ugEquity_InitializeLayout));
				_ugEquity.add_CellChange(new CellEventHandler(ugEquity_CellChange));
				_ugEquity.add_BeforeRowsDeleted(new BeforeRowsDeletedEventHandler(ugEquity_BeforeRowsDeleted));
				((UltraGridBase)_ugEquity).add_AfterSortChange(new BandEventHandler(ugEquity_AfterSortChange));
				_ugEquity.add_InitializeRow(new InitializeRowEventHandler(ugEquity_InitializeRow));
				_ugEquity.add_AfterRowsDeleted((EventHandler)ugEquity_AfterRowsDeleted);
				_ugEquity.add_AfterRowInsert(new RowEventHandler(ugEquity_AfterRowInsert));
				_ugEquity.add_AfterCellUpdate(new CellEventHandler(ugEquity_AfterCellUpdate));
			}
		}
	}

	internal virtual GridControl XgEquity
	{
		[DebuggerNonUserCode]
		get
		{
			return _XgEquity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XgEquity = value;
		}
	}

	internal virtual DataRow dataRowTemplate1
	{
		[DebuggerNonUserCode]
		get
		{
			return _dataRowTemplate1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dataRowTemplate1 = value;
		}
	}

	internal virtual GroupByRow GroupByRow1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupByRow1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupByRow1 = value;
		}
	}

	internal virtual ColumnManagerRow ColumnManagerRow1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnManagerRow1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnManagerRow1 = value;
		}
	}

	private virtual frmNewStock NewStock
	{
		[DebuggerNonUserCode]
		get
		{
			return _NewStock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_NewStock != null)
			{
				_NewStock.StockAdded -= NewStock_StockAdded;
			}
			_NewStock = value;
			if (_NewStock != null)
			{
				_NewStock.StockAdded += NewStock_StockAdded;
			}
		}
	}

	private virtual frmFeedRanking FeedRanking
	{
		[DebuggerNonUserCode]
		get
		{
			return _FeedRanking;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_FeedRanking != null)
			{
				_FeedRanking.TextHasChanged -= FeedRanking_TextHasChanged;
			}
			_FeedRanking = value;
			if (_FeedRanking != null)
			{
				_FeedRanking.TextHasChanged += FeedRanking_TextHasChanged;
			}
		}
	}

	public int Tab_Index
	{
		get
		{
			return _TabIndex;
		}
		set
		{
			_TabIndex = value;
		}
	}

	public string Tab_Name
	{
		get
		{
			return _Tab_Name;
		}
		set
		{
			_Tab_Name = value;
		}
	}

	public event MarketWatchEventHandler MarketWatch
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			MarketWatchEvent = (MarketWatchEventHandler)Delegate.Combine(MarketWatchEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			MarketWatchEvent = (MarketWatchEventHandler)Delegate.Remove(MarketWatchEvent, value);
		}
	}

	public event Rename_MDI_TabEventHandler Rename_MDI_Tab
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			Rename_MDI_TabEvent = (Rename_MDI_TabEventHandler)Delegate.Combine(Rename_MDI_TabEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			Rename_MDI_TabEvent = (Rename_MDI_TabEventHandler)Delegate.Remove(Rename_MDI_TabEvent, value);
		}
	}

	public frmXceedEquity()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)frmEquity_Load);
		((Form)this).add_FormClosed(new FormClosedEventHandler(frmEquity_FormClosed));
		__ENCList.Add(new WeakReference(this));
		dtEquity = new DataTable();
		strSortColumn = "";
		strSort = true;
		DeleteExchangeSymbol = "";
		NewStock = new frmNewStock();
		FeedRanking = new frmFeedRanking();
		Start_PowerUDP = true;
		IsActive = false;
		IsAdvance = false;
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
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected O, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected O, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected O, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected O, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected O, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected O, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected O, but got Unknown
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected O, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected O, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected O, but got Unknown
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected O, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected O, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected O, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected O, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected O, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got Unknown
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected O, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected O, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected O, but got Unknown
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected O, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected O, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected O, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected O, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected O, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected O, but got Unknown
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Expected O, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected O, but got Unknown
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected O, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected O, but got Unknown
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected O, but got Unknown
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected O, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected O, but got Unknown
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Expected O, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected O, but got Unknown
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Expected O, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected O, but got Unknown
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected O, but got Unknown
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Expected O, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Expected O, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected O, but got Unknown
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected O, but got Unknown
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected O, but got Unknown
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected O, but got Unknown
		//IL_206b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2075: Expected O, but got Unknown
		components = new Container();
		UltraToolbar val = new UltraToolbar("UltraToolbar1");
		PopupMenuTool val2 = new PopupMenuTool("File");
		PopupMenuTool val3 = new PopupMenuTool("Add");
		PopupMenuTool val4 = new PopupMenuTool("AutoFill");
		PopupMenuTool val5 = new PopupMenuTool("View");
		ButtonTool val6 = new ButtonTool("AddNewStock");
		Appearance val7 = new Appearance();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmXceedEquity));
		PopupMenuTool val8 = new PopupMenuTool("AutoFill");
		ButtonTool val9 = new ButtonTool("FeedRanking");
		PopupMenuTool val10 = new PopupMenuTool("StandardList");
		ButtonTool val11 = new ButtonTool("FeedRanking");
		Appearance val12 = new Appearance();
		PopupMenuTool val13 = new PopupMenuTool("View");
		PopupMenuTool val14 = new PopupMenuTool("Chart");
		PopupMenuTool val15 = new PopupMenuTool("TechChart");
		ButtonTool val16 = new ButtonTool("FullQuote");
		ButtonTool val17 = new ButtonTool("OPTIONSDATA");
		PopupMenuTool val18 = new PopupMenuTool("Properties");
		ButtonTool val19 = new ButtonTool("Note");
		TextBoxTool val20 = new TextBoxTool("RenameTab");
		PopupMenuTool val21 = new PopupMenuTool("Advanced");
		ButtonTool val22 = new ButtonTool("ShowStory");
		PopupMenuTool val23 = new PopupMenuTool("Chart");
		Appearance val24 = new Appearance();
		ButtonTool val25 = new ButtonTool("Today");
		ButtonTool val26 = new ButtonTool("7Days");
		ButtonTool val27 = new ButtonTool("14Days");
		ButtonTool val28 = new ButtonTool("1 Month");
		ButtonTool val29 = new ButtonTool("3 Months");
		ButtonTool val30 = new ButtonTool("6 Months");
		ButtonTool val31 = new ButtonTool("ThisYear");
		ButtonTool val32 = new ButtonTool("1Year");
		ButtonTool val33 = new ButtonTool("2Year");
		PopupMenuTool val34 = new PopupMenuTool("TechChart");
		Appearance val35 = new Appearance();
		ButtonTool val36 = new ButtonTool("1Month");
		ButtonTool val37 = new ButtonTool("3Months");
		ButtonTool val38 = new ButtonTool("6Months");
		ButtonTool val39 = new ButtonTool("12Months");
		ButtonTool val40 = new ButtonTool("This Year");
		ButtonTool val41 = new ButtonTool("FullQuote");
		Appearance val42 = new Appearance();
		ButtonTool val43 = new ButtonTool("Today");
		Appearance val44 = new Appearance();
		ButtonTool val45 = new ButtonTool("7Days");
		Appearance val46 = new Appearance();
		ButtonTool val47 = new ButtonTool("14Days");
		Appearance val48 = new Appearance();
		ButtonTool val49 = new ButtonTool("1 Month");
		Appearance val50 = new Appearance();
		ButtonTool val51 = new ButtonTool("3 Months");
		Appearance val52 = new Appearance();
		ButtonTool val53 = new ButtonTool("6 Months");
		Appearance val54 = new Appearance();
		ButtonTool val55 = new ButtonTool("ThisYear");
		Appearance val56 = new Appearance();
		ButtonTool val57 = new ButtonTool("1Year");
		Appearance val58 = new Appearance();
		ButtonTool val59 = new ButtonTool("2Year");
		Appearance val60 = new Appearance();
		ButtonTool val61 = new ButtonTool("3Months");
		Appearance val62 = new Appearance();
		ButtonTool val63 = new ButtonTool("6Months");
		Appearance val64 = new Appearance();
		ButtonTool val65 = new ButtonTool("12Months");
		Appearance val66 = new Appearance();
		ButtonTool val67 = new ButtonTool("This Year");
		Appearance val68 = new Appearance();
		PopupMenuTool val69 = new PopupMenuTool("Properties");
		Appearance val70 = new Appearance();
		FontListTool val71 = new FontListTool("Font");
		ComboBoxTool val72 = new ComboBoxTool("FontSize");
		PopupColorPickerTool val73 = new PopupColorPickerTool("Color");
		PopupColorPickerTool val74 = new PopupColorPickerTool("Change>0");
		PopupColorPickerTool val75 = new PopupColorPickerTool("Change=0");
		PopupColorPickerTool val76 = new PopupColorPickerTool("Change<0");
		ButtonTool val77 = new ButtonTool("ResettoDefault");
		FontListTool val78 = new FontListTool("Font");
		Appearance val79 = new Appearance();
		PopupColorPickerTool val80 = new PopupColorPickerTool("Color");
		Appearance val81 = new Appearance();
		PopupMenuTool val82 = new PopupMenuTool("File");
		ButtonTool val83 = new ButtonTool("New");
		ButtonTool val84 = new ButtonTool("Open");
		ButtonTool val85 = new ButtonTool("Refresh");
		ButtonTool val86 = new ButtonTool("SaveAs");
		ButtonTool val87 = new ButtonTool("ExporttoExcel");
		ButtonTool val88 = new ButtonTool("ExporttoExcel");
		Appearance val89 = new Appearance();
		ButtonTool val90 = new ButtonTool("Refresh");
		Appearance val91 = new Appearance();
		PopupColorPickerTool val92 = new PopupColorPickerTool("Change>0");
		Appearance val93 = new Appearance();
		PopupColorPickerTool val94 = new PopupColorPickerTool("Change=0");
		Appearance val95 = new Appearance();
		PopupColorPickerTool val96 = new PopupColorPickerTool("Change<0");
		Appearance val97 = new Appearance();
		ButtonTool val98 = new ButtonTool("SaveAs");
		Appearance val99 = new Appearance();
		PopupMenuTool val100 = new PopupMenuTool("Add");
		ButtonTool val101 = new ButtonTool("AddNewStock");
		ButtonTool val102 = new ButtonTool("New");
		Appearance val103 = new Appearance();
		ButtonTool val104 = new ButtonTool("Open");
		Appearance val105 = new Appearance();
		ButtonTool val106 = new ButtonTool("ResettoDefault");
		Appearance val107 = new Appearance();
		TextBoxTool val108 = new TextBoxTool("RenameTab");
		Appearance val109 = new Appearance();
		ButtonTool val110 = new ButtonTool("Note");
		Appearance val111 = new Appearance();
		ComboBoxTool val112 = new ComboBoxTool("FontSize");
		Appearance val113 = new Appearance();
		ValueList val114 = new ValueList(0);
		ValueListItem val115 = new ValueListItem();
		ValueListItem val116 = new ValueListItem();
		ValueListItem val117 = new ValueListItem();
		ValueListItem val118 = new ValueListItem();
		ValueListItem val119 = new ValueListItem();
		ValueListItem val120 = new ValueListItem();
		ValueListItem val121 = new ValueListItem();
		ValueListItem val122 = new ValueListItem();
		ValueListItem val123 = new ValueListItem();
		ValueListItem val124 = new ValueListItem();
		ButtonTool val125 = new ButtonTool("1Month");
		Appearance val126 = new Appearance();
		ButtonTool val127 = new ButtonTool("AdvancedColumns");
		Appearance val128 = new Appearance();
		ButtonTool val129 = new ButtonTool("OPTIONSDATA");
		Appearance val130 = new Appearance();
		ButtonTool val131 = new ButtonTool("ShowStory");
		Appearance val132 = new Appearance();
		PopupMenuTool val133 = new PopupMenuTool("Advanced");
		Appearance val134 = new Appearance();
		ButtonTool val135 = new ButtonTool("AdvancedColumns");
		ButtonTool val136 = new ButtonTool("ShowColumns");
		ButtonTool val137 = new ButtonTool("ShowColumns");
		Appearance val138 = new Appearance();
		PopupMenuTool val139 = new PopupMenuTool("StandardList");
		ButtonTool val140 = new ButtonTool("Sensex");
		ButtonTool val141 = new ButtonTool("Nifty");
		ButtonTool val142 = new ButtonTool("AllIndices");
		ButtonTool val143 = new ButtonTool("NSETopVolume");
		ButtonTool val144 = new ButtonTool("Sensex");
		ButtonTool val145 = new ButtonTool("Nifty");
		ButtonTool val146 = new ButtonTool("AllIndices");
		ButtonTool val147 = new ButtonTool("NSETopVolume");
		UltraGridBand val148 = new UltraGridBand("Band 0", -1);
		UltraGridColumn val149 = new UltraGridColumn("Bridge Symbol");
		UltraGridColumn val150 = new UltraGridColumn("IssueCapital");
		UltraGridColumn val151 = new UltraGridColumn("Exchange Symbol");
		UltraGridColumn val152 = new UltraGridColumn("Scrip Name");
		UltraGridColumn val153 = new UltraGridColumn("Last Price");
		UltraGridColumn val154 = new UltraGridColumn("Change");
		UltraGridColumn val155 = new UltraGridColumn("% Change");
		UltraGridColumn val156 = new UltraGridColumn("Volume");
		UltraGridColumn val157 = new UltraGridColumn("Close Price");
		UltraGridColumn val158 = new UltraGridColumn("Week % Change");
		UltraGridColumn val159 = new UltraGridColumn("Month % Change");
		UltraGridColumn val160 = new UltraGridColumn("Year %  Change");
		UltraGridColumn val161 = new UltraGridColumn("Open");
		UltraGridColumn val162 = new UltraGridColumn("High");
		UltraGridColumn val163 = new UltraGridColumn("Low");
		UltraGridColumn val164 = new UltraGridColumn("WeekHigh52");
		UltraGridColumn val165 = new UltraGridColumn("WeekLow52");
		UltraGridColumn val166 = new UltraGridColumn("LifeTime High");
		UltraGridColumn val167 = new UltraGridColumn("LifeTime Low");
		UltraGridColumn val168 = new UltraGridColumn("Share Outstanding");
		UltraGridColumn val169 = new UltraGridColumn("Market Cap");
		UltraGridColumn val170 = new UltraGridColumn("Turn Over");
		UltraGridColumn val171 = new UltraGridColumn("Series %");
		UltraGridColumn val172 = new UltraGridColumn("Upper Circuit");
		UltraGridColumn val173 = new UltraGridColumn("Lower Circuit");
		UltraGridColumn val174 = new UltraGridColumn("10 Day Avg");
		UltraGridColumn val175 = new UltraGridColumn("Market Type");
		UltraGridColumn val176 = new UltraGridColumn("Series");
		UltraGridColumn val177 = new UltraGridColumn("Day High");
		UltraGridColumn val178 = new UltraGridColumn("Day Low");
		UltraGridColumn val179 = new UltraGridColumn("Week Close");
		UltraGridColumn val180 = new UltraGridColumn("Month Close");
		UltraGridColumn val181 = new UltraGridColumn("Year Close");
		Appearance val182 = new Appearance();
		Appearance val183 = new Appearance();
		Appearance val184 = new Appearance();
		Appearance val185 = new Appearance();
		Appearance val186 = new Appearance();
		Appearance val187 = new Appearance();
		UltraToolbarsManager1 = new UltraToolbarsManager(components);
		ugEquity = new UltraGrid();
		_InheritedForm_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
		_InheritedForm_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
		_InheritedForm_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
		_InheritedForm_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
		UltraGridExcelExporter1 = new UltraGridExcelExporter(components);
		SaveFile = new SaveFileDialog();
		OpenFile = new OpenFileDialog();
		PowerTCP = new Tcp(components);
		PowerUDP = new Udp(components);
		Timer1 = new Timer(components);
		XgEquity = new GridControl();
		GroupByRow1 = new GroupByRow();
		ColumnManagerRow1 = new ColumnManagerRow();
		dataRowTemplate1 = new DataRow();
		((ISupportInitialize)UltraToolbarsManager1).BeginInit();
		((ISupportInitialize)ugEquity).BeginInit();
		((ISupportInitialize)XgEquity).BeginInit();
		((ISupportInitialize)ColumnManagerRow1).BeginInit();
		((ISupportInitialize)dataRowTemplate1).BeginInit();
		((Control)this).SuspendLayout();
		UltraToolbarsManager1.set_DesignerFlags(1);
		UltraToolbarsManager1.set_DockWithinContainer((Control)(object)this);
		UltraToolbarsManager1.set_MenuAnimationStyle((MenuAnimationStyle)3);
		UltraToolbarsManager1.set_Office2007UICompatibility(false);
		UltraToolbarsManager1.get_Ribbon().get_ApplicationMenu().set_Visible(false);
		((SettingsBase)UltraToolbarsManager1.get_Ribbon().get_QuickAccessToolbar().get_Settings()).set_ToolDisplayStyle((ToolDisplayStyle)4);
		UltraToolbarsManager1.get_Ribbon().get_QuickAccessToolbar().set_Visible(false);
		UltraToolbarsManager1.get_Ribbon().set_Visible(true);
		UltraToolbarsManager1.set_ShowFullMenusDelay(500);
		UltraToolbarsManager1.set_Style((ToolbarStyle)5);
		val.set_DockedColumn(0);
		val.set_DockedRow(0);
		val.set_Text("UltraToolbar1");
		((ToolsCollectionBase)((UltraToolbarBase)val).get_Tools()).AddRange((ToolBase[])(object)new ToolBase[4]
		{
			(ToolBase)val2,
			(ToolBase)val3,
			(ToolBase)val4,
			(ToolBase)val5
		});
		UltraToolbarsManager1.get_Toolbars().AddRange((UltraToolbar[])(object)new UltraToolbar[1] { val });
		UltraToolbarsManager1.get_ToolbarSettings().set_AllowCustomize((DefaultableBoolean)2);
		val7.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance7.Image")));
		((ToolPropsBase)((ToolBase)val6).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val7);
		((ToolPropsBase)((ToolBase)val6).get_SharedProps()).set_Caption("New Stock");
		((ToolPropsBase)((ToolBase)val6).get_SharedProps()).set_DisplayStyle((ToolDisplayStyle)4);
		((ToolBase)val6).get_SharedProps().set_Shortcut((Shortcut)117);
		((ToolPropsBase)((ToolBase)val8).get_SharedProps()).set_Caption("AutoFill");
		((ToolsCollectionBase)val8.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[2]
		{
			(ToolBase)val9,
			(ToolBase)val10
		});
		val12.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance8.Image")));
		((ToolPropsBase)((ToolBase)val11).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val12);
		((ToolPropsBase)((ToolBase)val11).get_SharedProps()).set_Caption("Feed Ranking");
		((ToolBase)val11).get_SharedProps().set_Shortcut((Shortcut)118);
		((ToolPropsBase)((ToolBase)val13).get_SharedProps()).set_Caption("View");
		((ToolBase)val18).get_InstanceProps().set_IsFirstInGroup(true);
		((ToolsCollectionBase)val13.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[9]
		{
			(ToolBase)val14,
			(ToolBase)val15,
			(ToolBase)val16,
			(ToolBase)val17,
			(ToolBase)val18,
			(ToolBase)val19,
			(ToolBase)val20,
			(ToolBase)val21,
			(ToolBase)val22
		});
		val24.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance9.Image")));
		((ToolPropsBase)((ToolBase)val23).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val24);
		((ToolPropsBase)((ToolBase)val23).get_SharedProps()).set_Caption("Chart");
		((ToolsCollectionBase)val23.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[9]
		{
			(ToolBase)val25,
			(ToolBase)val26,
			(ToolBase)val27,
			(ToolBase)val28,
			(ToolBase)val29,
			(ToolBase)val30,
			(ToolBase)val31,
			(ToolBase)val32,
			(ToolBase)val33
		});
		val35.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance10.Image")));
		((ToolPropsBase)((ToolBase)val34).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val35);
		((ToolPropsBase)((ToolBase)val34).get_SharedProps()).set_Caption("TechChart");
		((ToolsCollectionBase)val34.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[5]
		{
			(ToolBase)val36,
			(ToolBase)val37,
			(ToolBase)val38,
			(ToolBase)val39,
			(ToolBase)val40
		});
		val42.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance11.Image")));
		((ToolPropsBase)((ToolBase)val41).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val42);
		((ToolPropsBase)((ToolBase)val41).get_SharedProps()).set_Caption("Full Quote");
		((ToolBase)val41).get_SharedProps().set_Shortcut((Shortcut)120);
		val44.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance12.Image")));
		((ToolPropsBase)((ToolBase)val43).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val44);
		((ToolPropsBase)((ToolBase)val43).get_SharedProps()).set_Caption("Today");
		((ToolBase)val43).get_SharedProps().set_Shortcut((Shortcut)131156);
		val46.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance13.Image")));
		((ToolPropsBase)((ToolBase)val45).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val46);
		((ToolPropsBase)((ToolBase)val45).get_SharedProps()).set_Caption("7 Days");
		val48.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance14.Image")));
		((ToolPropsBase)((ToolBase)val47).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val48);
		((ToolPropsBase)((ToolBase)val47).get_SharedProps()).set_Caption("14 Days");
		val50.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance15.Image")));
		((ToolPropsBase)((ToolBase)val49).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val50);
		((ToolPropsBase)((ToolBase)val49).get_SharedProps()).set_Caption("1 Month");
		val52.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance16.Image")));
		((ToolPropsBase)((ToolBase)val51).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val52);
		((ToolPropsBase)((ToolBase)val51).get_SharedProps()).set_Caption("3 Months");
		val54.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance17.Image")));
		((ToolPropsBase)((ToolBase)val53).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val54);
		((ToolPropsBase)((ToolBase)val53).get_SharedProps()).set_Caption("6 Months");
		val56.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance18.Image")));
		((ToolPropsBase)((ToolBase)val55).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val56);
		((ToolPropsBase)((ToolBase)val55).get_SharedProps()).set_Caption("This Year");
		val58.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance19.Image")));
		((ToolPropsBase)((ToolBase)val57).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val58);
		((ToolPropsBase)((ToolBase)val57).get_SharedProps()).set_Caption("1 Year");
		val60.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance20.Image")));
		((ToolPropsBase)((ToolBase)val59).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val60);
		((ToolPropsBase)((ToolBase)val59).get_SharedProps()).set_Caption("2 Year");
		val62.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance21.Image")));
		((ToolPropsBase)((ToolBase)val61).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val62);
		((ToolPropsBase)((ToolBase)val61).get_SharedProps()).set_Caption("3 Months");
		val64.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance22.Image")));
		((ToolPropsBase)((ToolBase)val63).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val64);
		((ToolPropsBase)((ToolBase)val63).get_SharedProps()).set_Caption("6 Months");
		val66.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance23.Image")));
		((ToolPropsBase)((ToolBase)val65).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val66);
		((ToolPropsBase)((ToolBase)val65).get_SharedProps()).set_Caption("12 Months");
		val68.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance24.Image")));
		((ToolPropsBase)((ToolBase)val67).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val68);
		((ToolPropsBase)((ToolBase)val67).get_SharedProps()).set_Caption("This Year");
		val70.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance25.Image")));
		((ToolPropsBase)((ToolBase)val69).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val70);
		((ToolPropsBase)((ToolBase)val69).get_SharedProps()).set_Caption("Properties");
		((ToolsCollectionBase)val69.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[7]
		{
			(ToolBase)val71,
			(ToolBase)val72,
			(ToolBase)val73,
			(ToolBase)val74,
			(ToolBase)val75,
			(ToolBase)val76,
			(ToolBase)val77
		});
		val79.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance26.Image")));
		((ToolPropsBase)((ToolBase)val78).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val79);
		((ToolPropsBase)((ToolBase)val78).get_SharedProps()).set_Caption("Font Name");
		((ToolPropsBase)((ToolBase)val78).get_SharedProps()).set_MinWidth(150);
		val80.set_ReplaceableColor(Color.Empty);
		val81.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance27.Image")));
		((ToolPropsBase)((ToolBase)val80).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val81);
		((ToolPropsBase)((ToolBase)val80).get_SharedProps()).set_Caption("Background Color");
		((ToolBase)val80).get_SharedProps().set_Visible(false);
		((ToolPropsBase)((ToolBase)val82).get_SharedProps()).set_Caption("File");
		((ToolsCollectionBase)val82.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[5]
		{
			(ToolBase)val83,
			(ToolBase)val84,
			(ToolBase)val85,
			(ToolBase)val86,
			(ToolBase)val87
		});
		val89.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance28.Image")));
		((ToolPropsBase)((ToolBase)val88).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val89);
		((ToolPropsBase)((ToolBase)val88).get_SharedProps()).set_Caption("Export to Excel");
		((ToolPropsBase)((ToolBase)val88).get_SharedProps()).set_DisplayStyle((ToolDisplayStyle)4);
		((ToolBase)val88).get_SharedProps().set_Shortcut((Shortcut)131141);
		val91.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance29.Image")));
		((ToolPropsBase)((ToolBase)val90).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val91);
		((ToolPropsBase)((ToolBase)val90).get_SharedProps()).set_Caption("Refresh");
		((ToolPropsBase)((ToolBase)val90).get_SharedProps()).set_DisplayStyle((ToolDisplayStyle)4);
		((ToolBase)val90).get_SharedProps().set_Shortcut((Shortcut)116);
		val93.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance30.Image")));
		((ToolPropsBase)((ToolBase)val92).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val93);
		((ToolPropsBase)((ToolBase)val92).get_SharedProps()).set_Caption("Color [Change > 0]");
		val95.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance31.Image")));
		((ToolPropsBase)((ToolBase)val94).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val95);
		((ToolPropsBase)((ToolBase)val94).get_SharedProps()).set_Caption("Color [Change = 0]");
		val97.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance32.Image")));
		((ToolPropsBase)((ToolBase)val96).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val97);
		((ToolPropsBase)((ToolBase)val96).get_SharedProps()).set_Caption("Color [Change < 0]");
		val99.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance33.Image")));
		((ToolPropsBase)((ToolBase)val98).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val99);
		((ToolPropsBase)((ToolBase)val98).get_SharedProps()).set_Caption("Save As");
		((ToolPropsBase)((ToolBase)val98).get_SharedProps()).set_DisplayStyle((ToolDisplayStyle)4);
		((ToolBase)val98).get_SharedProps().set_Shortcut((Shortcut)131155);
		((ToolPropsBase)((ToolBase)val100).get_SharedProps()).set_Caption("Manual Add");
		((ToolsCollectionBase)val100.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[1] { (ToolBase)val101 });
		val103.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance34.Image")));
		((ToolPropsBase)((ToolBase)val102).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val103);
		((ToolPropsBase)((ToolBase)val102).get_SharedProps()).set_Caption("New");
		((ToolBase)val102).get_SharedProps().set_Shortcut((Shortcut)131150);
		val105.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance35.Image")));
		((ToolPropsBase)((ToolBase)val104).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val105);
		((ToolPropsBase)((ToolBase)val104).get_SharedProps()).set_Caption("Open");
		((ToolBase)val104).get_SharedProps().set_Shortcut((Shortcut)131151);
		val107.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance36.Image")));
		((ToolPropsBase)((ToolBase)val106).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val107);
		((ToolPropsBase)((ToolBase)val106).get_SharedProps()).set_Caption("Reset to Default");
		val109.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance37.Image")));
		((ToolPropsBase)((ToolBase)val108).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val109);
		((ToolPropsBase)((ToolBase)val108).get_SharedProps()).set_Caption("Rename Tab");
		val111.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance38.Image")));
		((ToolPropsBase)((ToolBase)val110).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val111);
		((ToolPropsBase)((ToolBase)val110).get_SharedProps()).set_Caption("Make a Note");
		((ToolBase)val110).get_SharedProps().set_Shortcut((Shortcut)119);
		val113.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance39.Image")));
		((ToolPropsBase)((ToolBase)val112).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val113);
		((ToolPropsBase)((ToolBase)val112).get_SharedProps()).set_Caption("Font Size");
		((ToolPropsBase)((ToolBase)val112).get_SharedProps()).set_MinWidth(150);
		val115.set_DataValue((object)"8");
		val115.set_DisplayText("8pt");
		val116.set_DataValue((object)"10");
		val116.set_DisplayText("10pt");
		val117.set_DataValue((object)"11");
		val117.set_DisplayText("11pt");
		val118.set_DataValue((object)"12");
		val118.set_DisplayText("12pt");
		val119.set_DataValue((object)"13");
		val119.set_DisplayText("13pt");
		val120.set_DataValue((object)"14");
		val120.set_DisplayText("14pt");
		val121.set_DataValue((object)"15");
		val121.set_DisplayText("15pt");
		val122.set_DataValue((object)"16");
		val122.set_DisplayText("16pt");
		val123.set_DataValue((object)"17");
		val123.set_DisplayText("17pt");
		val124.set_DataValue((object)"18");
		val124.set_DisplayText("18pt");
		val114.get_ValueListItems().AddRange((ValueListItem[])(object)new ValueListItem[10] { val115, val116, val117, val118, val119, val120, val121, val122, val123, val124 });
		val112.set_ValueList(val114);
		val126.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance40.Image")));
		((ToolPropsBase)((ToolBase)val125).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val126);
		((ToolPropsBase)((ToolBase)val125).get_SharedProps()).set_Caption("1 Month");
		val128.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance41.Image")));
		((ToolPropsBase)((ToolBase)val127).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val128);
		((ToolPropsBase)((ToolBase)val127).get_SharedProps()).set_Caption("Hide Columns");
		((ToolBase)val127).get_SharedProps().set_Shortcut((Shortcut)131140);
		val130.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance42.Image")));
		((ToolPropsBase)((ToolBase)val129).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val130);
		((ToolPropsBase)((ToolBase)val129).get_SharedProps()).set_Caption("Options Data");
		((ToolBase)val129).get_SharedProps().set_Shortcut((Shortcut)121);
		val132.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance43.Image")));
		((ToolPropsBase)((ToolBase)val131).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val132);
		((ToolPropsBase)((ToolBase)val131).get_SharedProps()).set_Caption("Show Story");
		((ToolBase)val131).get_SharedProps().set_Shortcut((Shortcut)131144);
		val134.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance44.Image")));
		((ToolPropsBase)((ToolBase)val133).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val134);
		((ToolPropsBase)((ToolBase)val133).get_SharedProps()).set_Caption("Advanced");
		((ToolsCollectionBase)val133.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[2]
		{
			(ToolBase)val135,
			(ToolBase)val136
		});
		val138.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance45.Image")));
		((ToolPropsBase)((ToolBase)val137).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val138);
		((ToolPropsBase)((ToolBase)val137).get_SharedProps()).set_Caption("Show Columns");
		((ToolBase)val137).get_SharedProps().set_Shortcut((Shortcut)196676);
		((ToolPropsBase)((ToolBase)val139).get_SharedProps()).set_Caption("Standard List");
		((ToolsCollectionBase)val139.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[4]
		{
			(ToolBase)val140,
			(ToolBase)val141,
			(ToolBase)val142,
			(ToolBase)val143
		});
		((ToolPropsBase)((ToolBase)val144).get_SharedProps()).set_Caption("Sensex");
		((ToolBase)val144).get_SharedProps().set_Shortcut((Shortcut)131145);
		((ToolPropsBase)((ToolBase)val145).get_SharedProps()).set_Caption("Nifty");
		((ToolBase)val145).get_SharedProps().set_Shortcut((Shortcut)131146);
		((ToolPropsBase)((ToolBase)val146).get_SharedProps()).set_Caption("All Indices");
		((ToolBase)val146).get_SharedProps().set_Shortcut((Shortcut)131147);
		((ToolPropsBase)((ToolBase)val147).get_SharedProps()).set_Caption("NSE Top Volume");
		((ToolBase)val147).get_SharedProps().set_Shortcut((Shortcut)131148);
		UltraToolbarsManager1.get_Tools().AddRange((ToolBase[])(object)new ToolBase[48]
		{
			(ToolBase)val6,
			(ToolBase)val8,
			(ToolBase)val11,
			(ToolBase)val13,
			(ToolBase)val23,
			(ToolBase)val34,
			(ToolBase)val41,
			(ToolBase)val43,
			(ToolBase)val45,
			(ToolBase)val47,
			(ToolBase)val49,
			(ToolBase)val51,
			(ToolBase)val53,
			(ToolBase)val55,
			(ToolBase)val57,
			(ToolBase)val59,
			(ToolBase)val61,
			(ToolBase)val63,
			(ToolBase)val65,
			(ToolBase)val67,
			(ToolBase)val69,
			(ToolBase)val78,
			(ToolBase)val80,
			(ToolBase)val82,
			(ToolBase)val88,
			(ToolBase)val90,
			(ToolBase)val92,
			(ToolBase)val94,
			(ToolBase)val96,
			(ToolBase)val98,
			(ToolBase)val100,
			(ToolBase)val102,
			(ToolBase)val104,
			(ToolBase)val106,
			(ToolBase)val108,
			(ToolBase)val110,
			(ToolBase)val112,
			(ToolBase)val125,
			(ToolBase)val127,
			(ToolBase)val129,
			(ToolBase)val131,
			(ToolBase)val133,
			(ToolBase)val137,
			(ToolBase)val139,
			(ToolBase)val144,
			(ToolBase)val145,
			(ToolBase)val146,
			(ToolBase)val147
		});
		UltraToolbarsManager1.SetContextMenuUltra((Component)(object)ugEquity, "View");
		val149.get_Header().set_VisiblePosition(0);
		val150.get_Header().set_VisiblePosition(1);
		val151.set_CellActivation((Activation)3);
		val151.get_Header().set_VisiblePosition(2);
		val152.set_CellActivation((Activation)3);
		val152.get_Header().set_VisiblePosition(3);
		val153.set_CellActivation((Activation)3);
		val153.get_Header().set_VisiblePosition(4);
		val154.set_CellActivation((Activation)3);
		val154.get_Header().set_VisiblePosition(5);
		val155.set_CellActivation((Activation)3);
		val155.get_Header().set_VisiblePosition(6);
		val156.set_CellActivation((Activation)3);
		val156.get_Header().set_VisiblePosition(10);
		val157.set_CellActivation((Activation)3);
		val157.get_Header().set_VisiblePosition(11);
		val158.set_CellActivation((Activation)3);
		val158.get_Header().set_VisiblePosition(7);
		val159.set_CellActivation((Activation)3);
		val159.get_Header().set_VisiblePosition(8);
		val160.set_CellActivation((Activation)3);
		val160.get_Header().set_VisiblePosition(9);
		val161.set_CellActivation((Activation)3);
		val161.get_Header().set_VisiblePosition(12);
		val162.set_CellActivation((Activation)3);
		val162.get_Header().set_VisiblePosition(13);
		val163.set_CellActivation((Activation)3);
		val163.get_Header().set_VisiblePosition(14);
		val164.set_CellActivation((Activation)3);
		val164.get_Header().set_VisiblePosition(15);
		val165.set_CellActivation((Activation)3);
		val165.get_Header().set_VisiblePosition(16);
		val166.set_CellActivation((Activation)3);
		val166.get_Header().set_VisiblePosition(17);
		val167.set_CellActivation((Activation)3);
		val167.get_Header().set_VisiblePosition(18);
		val168.set_CellActivation((Activation)3);
		val168.get_Header().set_VisiblePosition(19);
		val169.set_CellActivation((Activation)3);
		val169.get_Header().set_VisiblePosition(20);
		val170.set_CellActivation((Activation)3);
		val170.get_Header().set_VisiblePosition(21);
		val171.set_CellActivation((Activation)3);
		val171.get_Header().set_VisiblePosition(22);
		val172.set_CellActivation((Activation)3);
		val172.get_Header().set_VisiblePosition(23);
		val173.set_CellActivation((Activation)3);
		val173.get_Header().set_VisiblePosition(24);
		val174.set_CellActivation((Activation)3);
		val174.get_Header().set_VisiblePosition(25);
		val175.set_CellActivation((Activation)3);
		val175.get_Header().set_VisiblePosition(26);
		val176.set_CellActivation((Activation)3);
		val176.get_Header().set_VisiblePosition(27);
		val177.set_CellActivation((Activation)3);
		val177.get_Header().set_VisiblePosition(28);
		val178.set_CellActivation((Activation)3);
		val178.get_Header().set_VisiblePosition(29);
		val179.set_CellActivation((Activation)3);
		val179.get_Header().set_VisiblePosition(30);
		val180.set_CellActivation((Activation)3);
		val180.get_Header().set_VisiblePosition(31);
		val181.set_CellActivation((Activation)3);
		val181.get_Header().set_VisiblePosition(32);
		val148.get_Columns().AddRange(new object[33]
		{
			val149, val150, val151, val152, val153, val154, val155, val156, val157, val158,
			val159, val160, val161, val162, val163, val164, val165, val166, val167, val168,
			val169, val170, val171, val172, val173, val174, val175, val176, val177, val178,
			val179, val180, val181
		});
		val182.set_BackColor(Color.Purple);
		val182.set_BackColor2(Color.Purple);
		val148.get_Override().set_SelectedCellAppearance((AppearanceBase)(object)val182);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_BandsSerializer().Add((object)val148);
		((UltraGridBase)ugEquity).get_DisplayLayout().set_CaptionVisible((DefaultableBoolean)2);
		((UltraGridBase)ugEquity).get_DisplayLayout().set_MaxColScrollRegions(1);
		((UltraGridBase)ugEquity).get_DisplayLayout().set_MaxRowScrollRegions(1);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_AllowAddNew((AllowAddNew)6);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_AllowColSizing((AllowColSizing)1);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_AllowRowFiltering((DefaultableBoolean)2);
		val183.set_BackColor(Color.Transparent);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val183);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_FilterOperatorLocation((FilterOperatorLocation)3);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_FilterUIType((FilterUIType)2);
		val184.set_BackColor(Color.FromArgb(89, 135, 214));
		val184.set_BackColor2(Color.FromArgb(7, 59, 150));
		val184.set_BackGradientStyle((GradientStyle)2);
		val184.get_FontData().set_BoldAsString("True");
		val184.get_FontData().set_Name("Arial");
		val184.get_FontData().set_SizeInPoints(10f);
		val184.set_ForeColor(Color.White);
		val184.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val184);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_HeaderClickAction((HeaderClickAction)2);
		val185.set_BackGradientAlignment((GradientAlignment)3);
		val185.set_BackGradientStyle((GradientStyle)2);
		val185.set_BackHatchStyle((BackHatchStyle)2);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_RowAppearance((AppearanceBase)(object)val185);
		val186.set_BackColor(Color.FromArgb(89, 135, 214));
		val186.set_BackColor2(Color.FromArgb(7, 59, 150));
		val186.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val186);
		val187.set_BackColor(Color.FromArgb(251, 230, 148));
		val187.set_BackColor2(Color.FromArgb(238, 149, 21));
		val187.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val187);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_SelectTypeRow((SelectType)2);
		((UltraGridBase)ugEquity).get_DisplayLayout().set_ScrollBounds((ScrollBounds)0);
		((UltraGridBase)ugEquity).get_DisplayLayout().set_ScrollStyle((ScrollStyle)1);
		((Control)ugEquity).set_Dock((DockStyle)5);
		((Control)ugEquity).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraGrid obj = ugEquity;
		Point location = new Point(4, 48);
		((Control)obj).set_Location(location);
		((Control)ugEquity).set_Name("ugEquity");
		UltraGrid obj2 = ugEquity;
		Size size = new Size(949, 417);
		((Control)obj2).set_Size(size);
		((Control)ugEquity).set_TabIndex(6);
		((Control)ugEquity).set_Text("UltraGrid1");
		ugEquity.set_UpdateMode((UpdateMode)1);
		((Control)_InheritedForm_Toolbars_Dock_Area_Left).set_AccessibleRole((AccessibleRole)20);
		((Control)_InheritedForm_Toolbars_Dock_Area_Left).set_BackColor(Color.FromArgb(191, 219, 255));
		_InheritedForm_Toolbars_Dock_Area_Left.set_DockedPosition((DockedPosition)2);
		((Control)_InheritedForm_Toolbars_Dock_Area_Left).set_ForeColor(SystemColors.ControlText);
		_InheritedForm_Toolbars_Dock_Area_Left.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Left = _InheritedForm_Toolbars_Dock_Area_Left;
		location = new Point(0, 48);
		((Control)inheritedForm_Toolbars_Dock_Area_Left).set_Location(location);
		((Control)_InheritedForm_Toolbars_Dock_Area_Left).set_Name("_InheritedForm_Toolbars_Dock_Area_Left");
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Left2 = _InheritedForm_Toolbars_Dock_Area_Left;
		size = new Size(4, 556);
		((Control)inheritedForm_Toolbars_Dock_Area_Left2).set_Size(size);
		_InheritedForm_Toolbars_Dock_Area_Left.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_InheritedForm_Toolbars_Dock_Area_Right).set_AccessibleRole((AccessibleRole)20);
		((Control)_InheritedForm_Toolbars_Dock_Area_Right).set_BackColor(Color.FromArgb(191, 219, 255));
		_InheritedForm_Toolbars_Dock_Area_Right.set_DockedPosition((DockedPosition)3);
		((Control)_InheritedForm_Toolbars_Dock_Area_Right).set_ForeColor(SystemColors.ControlText);
		_InheritedForm_Toolbars_Dock_Area_Right.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Right = _InheritedForm_Toolbars_Dock_Area_Right;
		location = new Point(953, 48);
		((Control)inheritedForm_Toolbars_Dock_Area_Right).set_Location(location);
		((Control)_InheritedForm_Toolbars_Dock_Area_Right).set_Name("_InheritedForm_Toolbars_Dock_Area_Right");
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Right2 = _InheritedForm_Toolbars_Dock_Area_Right;
		size = new Size(4, 556);
		((Control)inheritedForm_Toolbars_Dock_Area_Right2).set_Size(size);
		_InheritedForm_Toolbars_Dock_Area_Right.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_InheritedForm_Toolbars_Dock_Area_Top).set_AccessibleRole((AccessibleRole)20);
		((Control)_InheritedForm_Toolbars_Dock_Area_Top).set_BackColor(Color.FromArgb(191, 219, 255));
		_InheritedForm_Toolbars_Dock_Area_Top.set_DockedPosition((DockedPosition)0);
		((Control)_InheritedForm_Toolbars_Dock_Area_Top).set_ForeColor(SystemColors.ControlText);
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Top = _InheritedForm_Toolbars_Dock_Area_Top;
		location = new Point(0, 0);
		((Control)inheritedForm_Toolbars_Dock_Area_Top).set_Location(location);
		((Control)_InheritedForm_Toolbars_Dock_Area_Top).set_Name("_InheritedForm_Toolbars_Dock_Area_Top");
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Top2 = _InheritedForm_Toolbars_Dock_Area_Top;
		size = new Size(957, 48);
		((Control)inheritedForm_Toolbars_Dock_Area_Top2).set_Size(size);
		_InheritedForm_Toolbars_Dock_Area_Top.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_InheritedForm_Toolbars_Dock_Area_Bottom).set_AccessibleRole((AccessibleRole)20);
		((Control)_InheritedForm_Toolbars_Dock_Area_Bottom).set_BackColor(Color.FromArgb(191, 219, 255));
		_InheritedForm_Toolbars_Dock_Area_Bottom.set_DockedPosition((DockedPosition)1);
		((Control)_InheritedForm_Toolbars_Dock_Area_Bottom).set_ForeColor(SystemColors.ControlText);
		_InheritedForm_Toolbars_Dock_Area_Bottom.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Bottom = _InheritedForm_Toolbars_Dock_Area_Bottom;
		location = new Point(0, 604);
		((Control)inheritedForm_Toolbars_Dock_Area_Bottom).set_Location(location);
		((Control)_InheritedForm_Toolbars_Dock_Area_Bottom).set_Name("_InheritedForm_Toolbars_Dock_Area_Bottom");
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Bottom2 = _InheritedForm_Toolbars_Dock_Area_Bottom;
		size = new Size(957, 4);
		((Control)inheritedForm_Toolbars_Dock_Area_Bottom2).set_Size(size);
		_InheritedForm_Toolbars_Dock_Area_Bottom.set_ToolbarsManager(UltraToolbarsManager1);
		((FileDialog)OpenFile).set_DefaultExt("TV18");
		((FileDialog)OpenFile).set_Filter("Text files (*.TV18)|*.TV18|\" & \"All files|*.*");
		PowerUDP.set_Editor((object)PowerUDP);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(300000);
		XgEquity.set_DataRowTemplate(dataRowTemplate1);
		((Control)XgEquity).set_Dock((DockStyle)2);
		XgEquity.get_FixedHeaderRows().Add((Row)(object)GroupByRow1);
		XgEquity.get_FixedHeaderRows().Add((Row)(object)ColumnManagerRow1);
		GridControl xgEquity = XgEquity;
		location = new Point(4, 465);
		((Control)xgEquity).set_Location(location);
		((Control)XgEquity).set_Name("XgEquity");
		GridControl xgEquity2 = XgEquity;
		size = new Size(949, 139);
		((Control)xgEquity2).set_Size(size);
		((Control)XgEquity).set_TabIndex(11);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(957, 608);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ugEquity);
		((Control)this).get_Controls().Add((Control)(object)XgEquity);
		((Control)this).get_Controls().Add((Control)(object)_InheritedForm_Toolbars_Dock_Area_Left);
		((Control)this).get_Controls().Add((Control)(object)_InheritedForm_Toolbars_Dock_Area_Right);
		((Control)this).get_Controls().Add((Control)(object)_InheritedForm_Toolbars_Dock_Area_Top);
		((Control)this).get_Controls().Add((Control)(object)_InheritedForm_Toolbars_Dock_Area_Bottom);
		((Control)this).set_Name("frmXceedEquity");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_Text("Equity");
		((ISupportInitialize)UltraToolbarsManager1).EndInit();
		((ISupportInitialize)ugEquity).EndInit();
		((ISupportInitialize)XgEquity).EndInit();
		((ISupportInitialize)ColumnManagerRow1).EndInit();
		((ISupportInitialize)dataRowTemplate1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmEquity_Load(object sender, EventArgs e)
	{
		BindGridData();
	}

	private void frmEquity_FormClosed(object sender, FormClosedEventArgs e)
	{
		try
		{
			DeActivateTab();
			PowerUDP.Close();
			((Component)(object)PowerUDP).Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void NewStock_StockAdded(string strBridgeSymbol)
	{
		AddNewStock(strBridgeSymbol, 0, isAddnew: true);
	}

	private void FeedRanking_TextHasChanged()
	{
		AddFeedRanking();
	}

	private void ugEquity_AfterCellUpdate(object sender, CellEventArgs e)
	{
		if ((!e.get_Cell().get_IsFilterRowCell() & (e.get_Cell().get_Row().get_Index() != checked(((UltraGridBase)ugEquity).get_Rows().get_Count() - 1))) && !e.get_Cell().get_IsFilterRowCell())
		{
			if (Operators.CompareString(((HeaderBase)e.get_Cell().get_Column().get_Header()).get_Caption(), "Bridge Symbol", false) == 0)
			{
				ManualAdd(e.get_Cell().get_Row().get_Index());
				((UltraGridBase)ugEquity).UpdateData();
			}
			if ((Operators.CompareString(strSortColumn, "", false) != 0) & (Operators.CompareString(((HeaderBase)e.get_Cell().get_Column().get_Header()).get_Caption(), strSortColumn, false) == 0))
			{
			}
		}
	}

	private void ugEquity_AfterRowInsert(object sender, RowEventArgs e)
	{
		checked
		{
			if (e.get_Row().get_Index() != 0 && ((UltraGridBase)ugEquity).get_Rows().get_Item(e.get_Row().get_Index() - 1).get_Cells()
				.get_Item(0)
				.get_Value() != DBNull.Value && ((UltraGridBase)ugEquity).get_Rows().get_Item(e.get_Row().get_Index() - 1).get_Cells()
				.get_Item(1)
				.get_Value() == DBNull.Value)
			{
				ManualAdd(e.get_Row().get_Index() - 1);
				((UltraGridBase)ugEquity).UpdateData();
				if (Operators.CompareString(strSortColumn, "", false) != 0)
				{
					((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
						.get_SortedColumns()
						.Clear();
					((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
						.get_SortedColumns()
						.Add(strSortColumn, strSort, false);
				}
			}
		}
	}

	private void ugEquity_AfterRowsDeleted(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		try
		{
			if (Operators.CompareString(DeleteExchangeSymbol, "", false) != 0)
			{
				objEquity = new clsEquity();
				SqlParameter[] array = (SqlParameter[])(object)new SqlParameter[4]
				{
					new SqlParameter(),
					default(SqlParameter),
					default(SqlParameter),
					default(SqlParameter)
				};
				array[0].set_Direction(ParameterDirection.Input);
				array[0].set_ParameterName("@TABINDEX");
				array[0].set_DbType(DbType.Int64);
				array[0].set_Value((object)Tab_Index);
				array[1] = new SqlParameter();
				array[1].set_Direction(ParameterDirection.Input);
				array[1].set_ParameterName("@USERNAME");
				array[1].set_DbType(DbType.String);
				array[1].set_Value((object)mdlMain.gUserName);
				array[2] = new SqlParameter();
				array[2].set_Direction(ParameterDirection.Input);
				array[2].set_ParameterName("@USERDOMAIN");
				array[2].set_DbType(DbType.String);
				array[2].set_Value((object)mdlMain.gDomain);
				array[3] = new SqlParameter();
				array[3].set_Direction(ParameterDirection.Input);
				array[3].set_ParameterName("@EXCHANGESYMBOL");
				array[3].set_DbType(DbType.String);
				array[3].set_Value((object)DeleteExchangeSymbol);
				strSQL = "sp_DELETE_CNBCMONEY_BRIDGESYMBOL";
				SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.StoredProcedure, strSQL, array);
				DeleteExchangeSymbol = "";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ugEquity_AfterSortChange(object sender, BandEventArgs e)
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

	private void ugEquity_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
	{
		try
		{
			DeleteExchangeSymbol = Conversions.ToString(Interaction.IIf(((UltraGridBase)ugEquity).get_Rows().get_Item(((UltraGridBase)ugEquity).get_ActiveRow().get_Index()).get_Cells()
				.get_Item(1)
				.get_Value() == DBNull.Value, (object)"", RuntimeHelpers.GetObjectValue(((UltraGridBase)ugEquity).get_Rows().get_Item(((UltraGridBase)ugEquity).get_ActiveRow().get_Index()).get_Cells()
				.get_Item(1)
				.get_Value())));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ugEquity_CellChange(object sender, CellEventArgs e)
	{
		try
		{
			if ((!e.get_Cell().get_IsFilterRowCell() & (e.get_Cell().get_Row().get_Index() != checked(((UltraGridBase)ugEquity).get_Rows().get_Count() - 1))) && Operators.CompareString(((HeaderBase)e.get_Cell().get_Column().get_Header()).get_Caption(), "Bridge Symbol", false) != 0)
			{
				((UltraGridBase)ugEquity).UpdateData();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ugEquity_InitializeLayout(object sender, InitializeLayoutEventArgs e)
	{
		checked
		{
			try
			{
				e.get_Layout().get_Appearance().get_FontData()
					.set_Name(MySettingsProperty.Settings.FONT_DATA);
				e.get_Layout().get_Appearance().get_FontData()
					.set_SizeInPoints(Conversions.ToSingle(MySettingsProperty.Settings.FONT_SIZE));
				int num = ((DisposableObjectCollectionBase)e.get_Layout().get_Bands().get_Item(0)
					.get_Columns()).get_Count() - 1;
				i = 0;
				while (true)
				{
					int num2 = i;
					int num3 = num;
					if (num2 > num3)
					{
						break;
					}
					if (i > 2)
					{
						e.get_Layout().get_Bands().get_Item(0)
							.get_Columns()
							.get_Item(i)
							.set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)6);
						e.get_Layout().get_Bands().get_Item(0)
							.get_Columns()
							.get_Item(i)
							.get_CellAppearance()
							.set_TextHAlign((HAlign)3);
					}
					else
					{
						e.get_Layout().get_Bands().get_Item(0)
							.get_Columns()
							.get_Item(i)
							.set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
					}
					if (i > 0)
					{
						UltraGridColumn val = e.get_Layout().get_Bands().get_Item(0)
							.get_Columns()
							.get_Item(i);
						val.set_CellActivation((Activation)3);
						val.set_CellClickAction((CellClickAction)3);
						val = null;
					}
					i++;
				}
				e.get_Layout().get_Bands().get_Item(0)
					.get_Columns()
					.get_Item("IssueCapital")
					.set_Hidden(true);
				if (!IsAdvance)
				{
					AdvancedColumns(showhide: true);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ugEquity_InitializeRow(object sender, InitializeRowEventArgs e)
	{
		try
		{
			if (!e.get_Row().get_IsAddRow())
			{
				if (e.get_Row().get_Cells().get_Item("Last Price")
					.get_Value() == DBNull.Value)
				{
					e.get_Row().get_Cells().get_Item("Last Price")
						.set_Value((object)0);
				}
				if (e.get_Row().get_Cells().get_Item("Close Price")
					.get_Value() == DBNull.Value)
				{
					e.get_Row().get_Cells().get_Item("Close Price")
						.set_Value((object)0);
				}
				if (e.get_Row().get_Cells().get_Item("Week Close")
					.get_Value() == DBNull.Value)
				{
					e.get_Row().get_Cells().get_Item("Week Close")
						.set_Value((object)0);
				}
				if (e.get_Row().get_Cells().get_Item("Month Close")
					.get_Value() == DBNull.Value)
				{
					e.get_Row().get_Cells().get_Item("Month Close")
						.set_Value((object)0);
				}
				if (e.get_Row().get_Cells().get_Item("Year Close")
					.get_Value() == DBNull.Value)
				{
					e.get_Row().get_Cells().get_Item("Year Close")
						.set_Value((object)0);
				}
				if (e.get_Row().get_Cells().get_Item("IssueCapital")
					.get_Value() == DBNull.Value)
				{
					e.get_Row().get_Cells().get_Item("IssueCapital")
						.set_Value((object)"0");
				}
				if (e.get_Row().get_Cells().get_Item("High")
					.get_Value() == DBNull.Value)
				{
					e.get_Row().get_Cells().get_Item("High")
						.set_Value((object)0);
				}
				if (e.get_Row().get_Cells().get_Item("Low")
					.get_Value() == DBNull.Value)
				{
					e.get_Row().get_Cells().get_Item("Low")
						.set_Value((object)0);
				}
				double num = Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Last Price")
					.get_Value()) - Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Close Price")
					.get_Value());
				e.get_Row().get_Cells().get_Item("Change")
					.set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)num, 2, (TriState)(-1), (TriState)0, (TriState)0)));
				e.get_Row().get_Cells().get_Item("% Change")
					.set_Value((object)Conversions.ToDouble(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(e.get_Row().get_Cells().get_Item("Close Price")
						.get_Value(), (object)0, false), (object)0, (object)(num / Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Close Price")
						.get_Value()) * 100.0))), 2, (TriState)(-1), (TriState)0, (TriState)0)));
				e.get_Row().get_Cells().get_Item("Week % Change")
					.set_Value((object)Conversions.ToDouble(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(e.get_Row().get_Cells().get_Item("Week Close")
						.get_Value(), (object)0, false), (object)0, (object)((Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Last Price")
						.get_Value()) - Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Week Close")
						.get_Value())) / Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Week Close")
						.get_Value()) * 100.0))), 2, (TriState)(-1), (TriState)0, (TriState)0)));
				e.get_Row().get_Cells().get_Item("Month % Change")
					.set_Value((object)Conversions.ToDouble(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(e.get_Row().get_Cells().get_Item("Month Close")
						.get_Value(), (object)0, false), (object)0, (object)((Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Last Price")
						.get_Value()) - Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Month Close")
						.get_Value())) / Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Month Close")
						.get_Value()) * 100.0))), 2, (TriState)(-1), (TriState)0, (TriState)0)));
				e.get_Row().get_Cells().get_Item("Year % Change")
					.set_Value((object)Conversions.ToDouble(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(e.get_Row().get_Cells().get_Item("Year Close")
						.get_Value(), (object)0, false), (object)0, (object)((Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Last Price")
						.get_Value()) - Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Year Close")
						.get_Value())) / Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Year Close")
						.get_Value()) * 100.0))), 2, (TriState)(-1), (TriState)0, (TriState)0)));
				double num2 = num;
				if (num2 == 0.0)
				{
					e.get_Row().get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
				}
				else if (num2 > 0.0)
				{
					e.get_Row().get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
				}
				else if (num2 < 0.0)
				{
					e.get_Row().get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
				}
				object value = e.get_Row().get_Cells().get_Item("% Change")
					.get_Value();
				if (Operators.ConditionalCompareObjectEqual(value, (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("% Change")
						.get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
				}
				else if (Operators.ConditionalCompareObjectGreater(value, (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("% Change")
						.get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
				}
				else if (Operators.ConditionalCompareObjectLess(value, (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("% Change")
						.get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
				}
				object value2 = e.get_Row().get_Cells().get_Item("Week % Change")
					.get_Value();
				if (Operators.ConditionalCompareObjectEqual(value2, (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("Week % Change")
						.get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
				}
				else if (Operators.ConditionalCompareObjectGreater(value2, (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("Week % Change")
						.get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
				}
				else if (Operators.ConditionalCompareObjectLess(value2, (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("Week % Change")
						.get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
				}
				object value3 = e.get_Row().get_Cells().get_Item("Month % Change")
					.get_Value();
				if (Operators.ConditionalCompareObjectEqual(value3, (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("Month % Change")
						.get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
				}
				else if (Operators.ConditionalCompareObjectGreater(value3, (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("Month % Change")
						.get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
				}
				else if (Operators.ConditionalCompareObjectLess(value3, (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("Month % Change")
						.get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
				}
				object value4 = e.get_Row().get_Cells().get_Item("Year % Change")
					.get_Value();
				if (Operators.ConditionalCompareObjectEqual(value4, (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("Year % Change")
						.get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
				}
				else if (Operators.ConditionalCompareObjectGreater(value4, (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("Year % Change")
						.get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
				}
				else if (Operators.ConditionalCompareObjectLess(value4, (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("Year % Change")
						.get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
				}
				if (e.get_Row().get_Cells().get_Item("Volume")
					.get_Value() == DBNull.Value)
				{
					e.get_Row().get_Cells().get_Item("Volume")
						.set_Value((object)0);
				}
				e.get_Row().get_Cells().get_Item("Turn Over")
					.set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)(Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Last Price")
						.get_Value()) * Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Volume")
						.get_Value()) / 100000.0), 2, (TriState)(-1), (TriState)0, (TriState)0)));
				if (Operators.ConditionalCompareObjectGreater(e.get_Row().get_Cells().get_Item("Last Price")
					.get_Value(), (object)0, false))
				{
					e.get_Row().get_Cells().get_Item("Day High")
						.set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)((Conversions.ToDouble(e.get_Row().get_Cells().get_Item("HIGH")
							.get_Value()) - Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Last Price")
							.get_Value())) / Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Last Price")
							.get_Value()) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2))));
				}
				else
				{
					e.get_Row().get_Cells().get_Item("Day High")
						.set_Value((object)0.0);
				}
				if (Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Low")
					.get_Value()) > Conversions.ToDouble("0"))
				{
					e.get_Row().get_Cells().get_Item("Day Low")
						.set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)((Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Last Price")
							.get_Value()) - Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Low")
							.get_Value())) / Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Low")
							.get_Value()) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2))));
				}
				else
				{
					e.get_Row().get_Cells().get_Item("Day Low")
						.set_Value((object)0.0);
				}
				if (Operators.ConditionalCompareObjectNotEqual(e.get_Row().get_Cells().get_Item("IssueCapital")
					.get_Value(), (object)"0", false))
				{
					e.get_Row().get_RowSelectorAppearance().set_BackColor(Color.Orange);
					e.get_Row().get_RowSelectorAppearance().set_BackColor2(Color.Black);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void UltraToolbarsManager1_AfterToolExitEditMode(object sender, AfterToolExitEditModeEventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.CompareString(((TextBoxTool)((ToolsCollectionBase)UltraToolbarsManager1.get_Tools()).get_Item(((CancelableToolEventArgs)e).get_Tool().get_Key())).get_Text(), "", false) != 0 && Operators.CompareString(Strings.UCase(((CancelableToolEventArgs)e).get_Tool().get_Key()), "RENAMETAB", false) == 0)
			{
				Rename_Tab_Name(((Form)this).get_Text(), ((TextBoxTool)((ToolsCollectionBase)UltraToolbarsManager1.get_Tools()).get_Item(((CancelableToolEventArgs)e).get_Tool().get_Key())).get_Text());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			switch (Strings.UCase(((ToolEventArgs)e).get_Tool().get_Key()))
			{
			case "ADDNEWSTOCK":
				NewStock = new frmNewStock();
				NewStock.Tab_Index = Tab_Index;
				NewStock.Tab_Name = ((Form)this).get_Text();
				((Form)NewStock).ShowDialog();
				break;
			case "FEEDRANKING":
				FeedRanking = new frmFeedRanking();
				((Form)FeedRanking).ShowDialog();
				break;
			case "EXPORTTOEXCEL":
				((FileDialog)SaveFile).set_Filter("xls (*.xls)|*.xls|All files|*.*");
				((CommonDialog)SaveFile).ShowDialog();
				break;
			case "REFRESH":
				MarketWatchEvent?.Invoke();
				BindGridData();
				break;
			case "SAVEAS":
				Save_PortFolio();
				break;
			case "NEW":
				File_New();
				break;
			case "OPEN":
				File_Open();
				break;
			case "RESETTODEFAULT":
				Reset_To_Default();
				break;
			case "NOTE":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					frmNote frmNote2 = MyProject.Forms.frmNote;
					frmNote2.BridgeSymbol = Conversions.ToString(((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Bridge Symbol")
						.get_Value());
					frmNote2.ScripName = Conversions.ToString(((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value());
					frmNote2.Tab_Index = Conversions.ToString(Tab_Index);
					frmNote2.TabName = ((Form)this).get_Text();
					((Form)frmNote2).ShowDialog();
					frmNote2 = null;
				}
				break;
			case "SHOWCOLUMNS":
				AdvancedColumns(showhide: false);
				IsAdvance = true;
				break;
			case "ADVANCEDCOLUMNS":
				AdvancedColumns(showhide: true);
				IsAdvance = false;
				break;
			case "FULLQUOTE":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					frmFullQuote frmFullQuote2 = new frmFullQuote();
					frmFullQuote frmFullQuote3 = frmFullQuote2;
					frmFullQuote3.BridgeSymbol = Conversions.ToString(((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Bridge Symbol")
						.get_Value());
					((Form)frmFullQuote3).ShowDialog();
					frmFullQuote3 = null;
				}
				break;
			case "OPTIONSDATA":
			{
				frmOptionsData frmOptionsData2 = new frmOptionsData();
				frmOptionsData frmOptionsData3 = frmOptionsData2;
				frmOptionsData3.ExchangeSymbol = Conversions.ToString(((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Exchange Symbol")
					.get_Value());
				((Form)frmOptionsData3).ShowDialog();
				frmOptionsData3 = null;
				break;
			}
			case "SHOWSTORY":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					if (Operators.ConditionalCompareObjectEqual(((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("IssueCapital")
						.get_Value(), (object)"0", false))
					{
						mdlMain.ShowMessage(Conversions.ToString(Operators.ConcatenateObject((object)"No News for ", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
							.get_Value())));
						break;
					}
					objEquity = new clsEquity();
					objEquity.ShowNews("", "", Conversions.ToString(((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("IssueCapital")
						.get_Value()));
				}
				break;
			case "SENSEX":
				AutoInitialize("137", "100", "EQ", "", "BSE", "NAME", "", "", "N", "C", 0, 0);
				break;
			case "NIFTY":
				AutoInitialize("138", "100", "EQ", "", "NSE", "NAME", "", "", "N", "C", Conversions.ToInteger("0"), Conversions.ToInteger("0"));
				break;
			case "ALLINDICES":
				AutoInitialize("98", "500", "INX", "", "BOTH", "VOLUME", "", "", "N", "C", Conversions.ToInteger("0"), Conversions.ToInteger("0"));
				break;
			case "NSETOPVOLUME":
				AutoInitialize("98", "50", "EQ", "", "NSE", "VOLUME", "", "", "N", "C", Conversions.ToInteger("0"), Conversions.ToInteger("0"));
				break;
			case "TODAY":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|chart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|Today|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "7DAYS":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|chart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|7 day|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "14DAYS":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|chart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|14 day|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "1 MONTH":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|chart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|1 Month|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "3 MONTHS":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|chart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|3 Month|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "6 MONTHS":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|chart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|6 Month|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "THISYEAR":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|chart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|1 Year|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "1YEAR":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|chart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|12 month|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "2YEAR":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|chart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|2 Year|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "1MONTH":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|techchart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|1 Month|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "3MONTHS":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|techchart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|3 Month|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "6MONTHS":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|techchart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|6 Month|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "12MONTHS":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|techchart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|12 month|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
				}
				break;
			case "THIS YEAR":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					strChart = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"|techchart|", ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("BRIDGE SYMBOL")
						.get_Value()), (object)"|1 Year|"), ((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
						.get_Value()));
					Process.Start(Application.get_StartupPath() + "/DrawGraph_2010.exe", strChart);
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

	private void UltraToolbarsManager1_ToolValueChanged(object sender, ToolEventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			switch (Strings.UCase(e.get_Tool().get_Key()))
			{
			case "FONT":
			{
				string text2 = Conversions.ToString(((ComboBoxTool)(FontListTool)((ToolsCollectionBase)UltraToolbarsManager1.get_Tools()).get_Item("Font")).get_Value());
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("FONT_DATA", (object)text2);
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				((UltraGridBase)ugEquity).get_DisplayLayout().get_Appearance().get_FontData()
					.set_Name(text2);
				break;
			}
			case "FONTSIZE":
			{
				string text = ((ComboBoxTool)e.get_Tool()).get_Value().ToString();
				((UltraGridBase)ugEquity).get_DisplayLayout().get_Appearance().get_FontData()
					.set_SizeInPoints(Conversions.ToSingle(text));
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("FONT_SIZE", (object)text);
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				break;
			}
			case "COLOR":
			{
				Color selectedColor4 = ((PopupColorPickerTool)((ToolsCollectionBase)UltraToolbarsManager1.get_Tools()).get_Item("Color")).get_SelectedColor();
				((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().get_RowAppearance()
					.set_BackColor2(selectedColor4);
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_BACKGROUND", (object)selectedColor4);
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				Application.DoEvents();
				break;
			}
			case "CHANGE>0":
			{
				Color selectedColor3 = ((PopupColorPickerTool)((ToolsCollectionBase)UltraToolbarsManager1.get_Tools()).get_Item("CHANGE>0")).get_SelectedColor();
				Color_Change("G", selectedColor3);
				break;
			}
			case "CHANGE=0":
			{
				Color selectedColor2 = ((PopupColorPickerTool)((ToolsCollectionBase)UltraToolbarsManager1.get_Tools()).get_Item("CHANGE=0")).get_SelectedColor();
				Color_Change("E", selectedColor2);
				break;
			}
			case "CHANGE<0":
			{
				Color selectedColor = ((PopupColorPickerTool)((ToolsCollectionBase)UltraToolbarsManager1.get_Tools()).get_Item("CHANGE<0")).get_SelectedColor();
				Color_Change("L", selectedColor);
				break;
			}
			}
			UpdateSettingsToDB();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void SaveFile_FileOk(object sender, CancelEventArgs e)
	{
		try
		{
			UltraGridExcelExporter1.Export(ugEquity, ((FileDialog)SaveFile).get_FileName());
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
		byte[] array = new byte[257];
		try
		{
			if (!Start_PowerUDP)
			{
				PowerUDP.Close();
				((Component)(object)PowerUDP).Dispose();
				return;
			}
			byte[] Data = e.get_Datagram().get_Buffer();
			string text = BytesToString(ref Data, checked((short)Information.UBound((Array)e.get_Datagram().get_Buffer(), 1)));
			text = Strings.Trim(text.Replace("\r\n", ""));
			if (Strings.Len(text) > 0)
			{
				CrunchData(Strings.Trim(text));
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
		Update_DateTime();
		Timer1.set_Enabled(true);
	}

	public void BindGridData()
	{
		checked
		{
			try
			{
				GetSettingsFromDB();
				((Control)MyProject.Forms.Money_Splash).Show();
				strSQL = "SELECT BridgeSymbol AS [Bridge Symbol], ExchangeSymbol AS [Exchange Symbol], ShortName AS [Scrip Name],  convert(decimal(10,2),ISNULL(lastprice,0)) AS [Last Price], convert(decimal(10,2),0) AS [Change], convert(decimal(10,2),0) AS [% Change], Volume,  [Close] AS [Close Price], ISNULL([OPEN],0)  as [Open], ISNULL(High,0) AS High, ISNULL(Low,0) AS Low, isnull(WeekHigh52,0) AS WeekHigh52, isnull(WeekLow52,0) AS WeekLow52 , convert(decimal(10,2), isnull(LifeTimeHigh,0)) AS [LifeTime High],  convert(decimal(10,2),isnull(LifeTimeLow,0)) AS [LifeTime Low], ShareOutStanding AS [Share OutStanding] , ISNULL(LastPrice,0) *ISNULL(VOLUME,0) AS [Turn Over], 0 AS [Market Cap],  0 AS [Series %], Upper_Circuit AS [Upper Circuit], Lower_Circuit AS [Lower Circuit], 0 AS [10 Day Avg] , Series,  0.00 AS [Day High], 0.00 AS [Day Low], Market_Type AS [Market Type], ISNULL(WeekClose,0.00) AS [Week Close],   ISNULL(MonthClose,0.00) AS [Month Close], ISNULL(YearClose,0.00) AS [Year Close],  0.00 AS [Week % Change], 0.00 AS [Month % Change], 0.00 AS [Year % Change], ISNULL(NewsExch,0) AS IssueCapital FROM Equity_transaction_data WHERE Market_Type = 'N' and SERIES IN ('EQ', 'BE', 'INX')  AND [Close]<>0 and [Close]is not NULL  AND BridgeSymbol IN (SELECT BRIDGESYMBOL FROM vw_CNBCMONEY_DETAILS WHERE TABINDEX = " + Conversions.ToString(Tab_Index) + " AND  USERNAME = '" + mdlMain.gUserName + "')";
				string text = "SELECT ISNULL(STRSQL,'') AS STRSQL FROM CNBCMONEY_USERS_MST WHERE USERNAME = '" + mdlMain.gUserName + "' AND  TABINDEX = " + Conversions.ToString(Tab_Index);
				dt = new DataTable();
				dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, text).Tables[0];
				if (dt.Rows.Count > 0 && Operators.ConditionalCompareObjectNotEqual(dt.Rows[0]["STRSQL"], (object)"", false))
				{
					strSQL = Strings.Replace(Conversions.ToString(dt.Rows[0]["STRSQL"]), "''", "'", 1, -1, (CompareMethod)0);
				}
				dtEquity = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				strSQL = "DELETE FROM CNBCMONEY_DETAILS WHERE USERID = (SELECT USERID FROM CNBCMONEY_USERS_MST WHERE USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX = " + Conversions.ToString(Tab_Index) + ")";
				int num = dtEquity.Rows.Count - 1;
				i = 0;
				while (true)
				{
					int num2 = i;
					int num3 = num;
					if (num2 > num3)
					{
						break;
					}
					FeedIntoDatabase(Conversions.ToString(dtEquity.Rows[i]["Bridge Symbol"]), Conversions.ToString(dtEquity.Rows[i]["Exchange Symbol"]));
					i++;
				}
				((UltraGridBase)ugEquity).set_DataSource((object)dtEquity);
				if (((UltraGridBase)ugEquity).get_Rows().get_Count() == 0)
				{
					((UltraGridBase)ugEquity).get_Rows().get_TemplateAddRow().get_Cells()
						.get_Item(0)
						.Activate();
				}
				((Form)MyProject.Forms.Money_Splash).Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				((Form)MyProject.Forms.Money_Splash).Close();
				ProjectData.ClearProjectError();
			}
		}
	}

	private bool AddNewStock(string strBridgeSymbol, int rowID = 0, bool isAddnew = false)
	{
		checked
		{
			bool result = default(bool);
			try
			{
				((UltraGridBase)ugEquity).UpdateData();
				strSQL = "SELECT BridgeSymbol AS [Bridge Symbol], ExchangeSymbol AS [Exchange Symbol], ShortName AS [Scrip Name],  convert(decimal(10,2),ISNULL(lastprice,0)) AS [Last Price], convert(decimal(10,2),0) AS [Change], convert(decimal(10,2),0) AS [% Change], Volume,  [Close] AS [Close Price], ISNULL([OPEN],0)  AS [Open], ISNULL(High,0) AS High, ISNULL(Low,0) AS Low, WeekHigh52, WeekLow52, convert(decimal(10,2),ISNULL(LifeTimeHigh,0)) AS [LifeTime High],  convert(decimal(10,2),ISNULL(LifeTimeLow,0)) AS [LifeTime Low], ShareOutStanding AS [Share OutStanding] , ISNULL(LastPrice,0) *ISNULL(VOLUME,0) AS [Turn Over], 0 AS [Market Cap],  0 AS [Series %], Upper_Circuit AS [Upper Circuit], Lower_Circuit AS [Lower Circuit], 0 AS [10 Day Avg] , Series,  0.00 AS [Day High], 0.00 AS [Day Low], Market_Type AS [Market Type], ISNULL(WeekClose,0.0) AS [Week Close],   ISNULL(MonthClose,0.0) AS [Month Close], ISNULL(YearClose,0.0) AS [Year Close],  0.00 AS [Week % Change], 0.00 AS [Month % Change], 0.00 AS [Year % Change], ISNULL(NewsExch,0) AS IssueCapital FROM Equity_transaction_data WHERE Market_Type = 'N' and SERIES IN ('EQ', 'BE', 'INX') ";
				if (Operators.CompareString(strBridgeSymbol, "", false) != 0)
				{
					strSQL = strSQL + " AND BridgeSymbol = '" + strBridgeSymbol + "'";
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
					DataRow dataRow = dtEquity.NewRow();
					dataRow.ItemArray = dt.Rows[0].ItemArray;
					dtEquity.Rows.Add(dataRow);
				}
				else
				{
					int num = dt.Columns.Count - 1;
					i = 1;
					while (true)
					{
						int num2 = i;
						int num3 = num;
						if (num2 > num3)
						{
							break;
						}
						((UltraGridBase)ugEquity).get_Rows().get_Item(rowID).get_Cells()
							.get_Item(dt.Columns[i].ColumnName)
							.set_Value(RuntimeHelpers.GetObjectValue(dt.Rows[0][dt.Columns[i].ColumnName]));
						i++;
					}
				}
				((UltraGridBase)ugEquity).UpdateData();
				if (Operators.ConditionalCompareObjectEqual(dt.Rows[0]["IssueCapital"], (object)"0", false))
				{
					((AppearanceBase)((UltraGridBase)ugEquity).get_Rows().get_Item(rowID).get_RowSelectorAppearance()).ResetBackColor();
					((AppearanceBase)((UltraGridBase)ugEquity).get_Rows().get_Item(rowID).get_RowSelectorAppearance()).ResetBackColor2();
				}
				else
				{
					((UltraGridBase)ugEquity).get_Rows().get_Item(rowID).get_RowSelectorAppearance()
						.set_BackColor(Color.Orange);
					((UltraGridBase)ugEquity).get_Rows().get_Item(rowID).get_RowSelectorAppearance()
						.set_BackColor2(Color.Black);
				}
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

	private void AddFeedRanking()
	{
		try
		{
			string sECTORID = Conversions.ToString(FeedRanking.cmbSectorName.get_Value());
			string tOPP = Conversions.ToString(FeedRanking.cmbNumber.get_Value());
			string series = Conversions.ToString(FeedRanking.cmbSeries.get_Value());
			string exchange_id = Conversions.ToString(FeedRanking.cmbExchange.get_Value());
			string sortby = Conversions.ToString(FeedRanking.cmbRanking.get_Value());
			string tvolume = Conversions.ToString(((TextEditorControlBase)FeedRanking.txtVolume).get_Value());
			string last_price = Conversions.ToString(((TextEditorControlBase)FeedRanking.txtLastPrice).get_Value());
			string market_type = Conversions.ToString(FeedRanking.cmbMarketType.get_Value());
			string changeOver = Conversions.ToString(((TextEditorControlBase)FeedRanking.txtChange).get_Value());
			int mKTcapg = ((Operators.CompareString(((TextEditorControlBase)FeedRanking.txtMktCapG).get_Text(), "", false) != 0) ? Conversions.ToInteger(((TextEditorControlBase)FeedRanking.txtMktCapG).get_Text()) : 0);
			int mKTcapl = ((Operators.CompareString(((TextEditorControlBase)FeedRanking.txtMktCapL).get_Text(), "", false) != 0) ? Conversions.ToInteger(((TextEditorControlBase)FeedRanking.txtMktCapL).get_Text()) : 0);
			AutoInitialize(sECTORID, tOPP, series, "", exchange_id, sortby, tvolume, last_price, market_type, changeOver, mKTcapg, mKTcapl);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void AutoInitialize(string SECTORID, string TOPP, string Series, string filename, string exchange_id, string sortby, string Tvolume, string last_price, string Market_type, string ChangeOver, int MKTcapg, int MKTcapl)
	{
		checked
		{
			try
			{
				strSQL = "Select Distinct top " + TOPP + " BRIDGESYMBOL AS [Bridge Symbol], c.Exchangesymbol as [Exchange Symbol],  shortname as [Scrip Name],LastPrice AS [Last Price], 0.0 as Change,((LastPrice-[Close])/[Close]) * 100 as [% Change], isnull(Volume,0) as Volume,  [CLOSE] as [Close Price], ISNULL([OPEN],0)  AS [Open],ISNULL(HIGH,0)  as High, ISNULL(LOW,0)  as Low,  ISNULL(WEEKHIGH52,0) as WeekHigh52,ISNULL(WEEKLOW52,0) as WeekLow52, convert(decimal(10,2),ISNULL(LIFETIMEHIGH,0)) as [LifeTime High],  convert(decimal(10,2),ISNULL(LIFETIMELOW,0)) as [LifeTime Low], ISNULL(SHAREOUTSTANDING,0) as [Share Outstanding], 0 AS [Market Cap],  ISNULL(LastPrice,0) *ISNULL(VOLUME,0) as [Turn Over], 0 as [Series %] ,ISNULL(UPPER_CIRCUIT,0) as [Upper Circuit],ISNULL(LOWER_CIRCUIT,0) as [Lower Circuit], ISNULL(DAY_10_AVERAGE,0) as [10 Day Avg], c.Series  as Series, 0.00 as [Day High], 0.00 AS [Day Low], Market_Type AS [Market Type], ISNULL(WeekClose,0.0) AS [Week Close],   ISNULL(MonthClose,0.0) AS [Month Close], ISNULL(YearClose,0.0) AS [Year Close],  0.00 AS [Week % Change], 0.00 AS [Month % Change], 0.00 AS [Year % Change], ISNULL(NewsExch,0) AS IssueCapital from Vehicle_Exchange a  join vehicle_sector b on a.code=b.code  join EQUITY_TRANSACTION_DATA C on a.SYMBOL=C.BRIDGESYMBOL";
				if (Operators.CompareString(Strings.UCase(sortby), "LifeTime High", false) == 0)
				{
					strSQL += "  and HIGH>=LIFETIMEHIGH ";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "LifeTime Low", false) == 0)
				{
					strSQL += "  and LOW<=LIFETIMELOW ";
				}
				if (Operators.CompareString(Strings.UCase(sortby), "WEEKHIGH52", false) == 0)
				{
					strSQL += "  and HIGH>=WEEKHIGH52 ";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "WEEKLOW52", false) == 0)
				{
					strSQL += "  and LOW<=WEEKLOW52 ";
				}
				if (Operators.CompareString(Strings.UCase(sortby), "UPPER_CIRCUIT", false) == 0)
				{
					strSQL += "  and Lastprice>=Upper_circuit * .995   AND Upper_circuit<>0";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "LOWER_CIRCUIT", false) == 0)
				{
					strSQL += "  and Lastprice<=lower_circuit * 1.005   AND lower_circuit<>0 ";
				}
				if (Operators.CompareString(Series, "INX", false) != 0 && Operators.CompareString(exchange_id, "BOTH", false) != 0)
				{
					if (Operators.CompareString(exchange_id, "NSE", false) == 0)
					{
						strSQL += "  and Exchange_ID='1732257' ";
					}
					else
					{
						strSQL += "  and Exchange_ID='1732256' ";
					}
				}
				if (Operators.CompareString(Strings.UCase(Strings.Trim(Series)), "EQ", false) == 0)
				{
					strSQL += " and C.Series in ('EQ','BE') ";
				}
				else
				{
					strSQL = strSQL + " and C.Series='" + Series + "' ";
				}
				if (Operators.CompareString(Series, "INX", false) != 0)
				{
					strSQL = strSQL + " and Market_type='" + Market_type + "'";
				}
				if (Strings.Len(last_price) == 0)
				{
					last_price = Conversions.ToString(0);
				}
				strSQL = strSQL + " and lastprice>'" + last_price + "'";
				if (Strings.Len(Tvolume) == 0)
				{
					Tvolume = Conversions.ToString(0);
				}
				if (Operators.CompareString(Series, "INX", false) != 0 && Operators.CompareString(Strings.LCase(sortby), "name", false) != 0)
				{
					strSQL = strSQL + " and volume>'" + Tvolume + "'";
				}
				if (MKTcapg != 0)
				{
					strSQL = strSQL + " and ((ISNULL(SHAREOUTSTANDING,0) * lastprice) / 10000000)>'" + Conversions.ToString(MKTcapg) + "' and ((ISNULL(SHAREOUTSTANDING,0) * lastprice) / 10000000)>'0'";
				}
				if (MKTcapl != 0)
				{
					strSQL = strSQL + " and ((ISNULL(SHAREOUTSTANDING,0) * lastprice) / 10000000)<'" + Conversions.ToString(MKTcapl) + "' and ((ISNULL(SHAREOUTSTANDING,0) * lastprice) / 10000000)>'0'";
				}
				if (Operators.CompareString(Series, "INX", false) != 0)
				{
					strSQL = strSQL + " and SectorID='" + Strings.Trim(SECTORID) + "' ";
				}
				strSQL += " and [Close]<>0 and [Close]is not NULL ";
				string text = "";
				if (Operators.CompareString(Strings.UCase(sortby), "GAINERS", false) == 0)
				{
					text = "% Change";
					strSQL = strSQL + " ORDER BY [" + text + "] DESC";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "LOSERS", false) == 0)
				{
					text = "% Change";
					strSQL = strSQL + " ORDER BY [" + text + "] ";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "VOLUME", false) == 0)
				{
					text = "VOLUME";
					strSQL = strSQL + " ORDER BY [" + text + "] DESC";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "NAME", false) == 0)
				{
					text = "Scrip Name";
					strSQL = strSQL + " ORDER BY [" + text + "]";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "LifeTime High", false) == 0)
				{
					text = "VOLUME";
					strSQL = strSQL + " ORDER BY [" + text + "] DESC";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "LifeTime Low", false) == 0)
				{
					text = "VOLUME";
					strSQL = strSQL + " ORDER BY [" + text + "] DESC";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "WEEKLOW52", false) == 0)
				{
					text = "VOLUME";
					strSQL = strSQL + " ORDER BY [" + text + "] DESC";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "WEEKHIGH52", false) == 0)
				{
					text = "VOLUME";
					strSQL = strSQL + " ORDER BY [" + text + "] DESC";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "UPPER_CIRCUIT", false) == 0)
				{
					text = "VOLUME";
					strSQL = strSQL + " ORDER BY [" + text + "] DESC";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "LOWER_CIRCUIT", false) == 0)
				{
					text = "VOLUME";
					strSQL = strSQL + " ORDER BY [" + text + "] DESC";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "TURNOVER", false) == 0)
				{
					text = "TURN OVER";
					strSQL = strSQL + " ORDER BY [" + text + "] DESC";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "", false) == 0)
				{
					text = "Volume";
					strSQL = strSQL + " ORDER BY [" + text + "] DESC";
				}
				dtEquity = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				((UltraGridBase)ugEquity).set_DataSource((object)dtEquity);
				((UltraGridBase)ugEquity).DataBind();
				if (Operators.CompareString(Strings.UCase(sortby), "NAME", false) == 0)
				{
					strSort = false;
				}
				else
				{
					strSort = true;
				}
				if (Operators.CompareString(text, "", false) != 0)
				{
					((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
						.get_SortedColumns()
						.Clear();
					((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
						.get_SortedColumns()
						.Add(text, strSort, false);
				}
				objEquity = new clsEquity();
				objEquity.DeletePortFolio(Tab_Name, Tab_Index);
				int num = dtEquity.Rows.Count - 1;
				i = 0;
				while (true)
				{
					int num2 = i;
					int num3 = num;
					if (num2 > num3)
					{
						break;
					}
					FeedIntoDatabase(Conversions.ToString(dtEquity.Rows[i]["Bridge Symbol"]), Conversions.ToString(dtEquity.Rows[i]["Exchange Symbol"]));
					i++;
				}
				string text2 = "UPDATE CNBCMONEY_USERS_MST SET STRSQL = '" + Strings.Replace(strSQL, "'", "''", 1, -1, (CompareMethod)0) + "' WHERE USERNAME = '" + mdlMain.gUserName + "' AND  TABINDEX = " + Conversions.ToString(Tab_Index);
				SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, text2);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ManualAdd(int rowID)
	{
		try
		{
			if (AddNewStock(Conversions.ToString(((UltraGridBase)ugEquity).get_Rows().get_Item(rowID).get_Cells()
				.get_Item(0)
				.get_Value()), rowID))
			{
				objEquity = new clsEquity();
				objEquity.AddLookUp(Conversions.ToString(((UltraGridBase)ugEquity).get_Rows().get_Item(rowID).get_Cells()
					.get_Item("Bridge Symbol")
					.get_Value()), Conversions.ToString(((UltraGridBase)ugEquity).get_Rows().get_Item(rowID).get_Cells()
					.get_Item("Exchange Symbol")
					.get_Value()), ((Form)this).get_Text(), Tab_Index);
				objEquity = null;
			}
			((UltraGridBase)ugEquity).UpdateData();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void FeedIntoDatabase(string strBridgeSymbol, string strExchangeSymbol)
	{
		try
		{
			objEquity = new clsEquity();
			objEquity.AddLookUp(strBridgeSymbol, strExchangeSymbol, ((Form)this).get_Text(), Tab_Index);
			objEquity = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Color_Change(string strCondition, Color strcolor)
	{
		checked
		{
			try
			{
				int num = ((UltraGridBase)ugEquity).get_Rows().get_Count() - 1;
				i = 0;
				while (true)
				{
					int num2 = i;
					int num3 = num;
					if (num2 > num3)
					{
						break;
					}
					switch (strCondition)
					{
					case "G":
						if (Operators.ConditionalCompareObjectGreater(((UltraGridBase)ugEquity).get_Rows().get_Item(i).get_Cells()
							.get_Item("Change")
							.get_Value(), (object)0, false))
						{
							((UltraGridBase)ugEquity).get_Rows().get_Item(i).get_Appearance()
								.set_ForeColor(strcolor);
						}
						((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_G_ZERO", (object)strcolor);
						break;
					case "E":
						if (Operators.ConditionalCompareObjectEqual(((UltraGridBase)ugEquity).get_Rows().get_Item(i).get_Cells()
							.get_Item("Change")
							.get_Value(), (object)0, false))
						{
							((UltraGridBase)ugEquity).get_Rows().get_Item(i).get_Appearance()
								.set_ForeColor(strcolor);
						}
						((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_E_ZERO", (object)strcolor);
						break;
					case "L":
						if (Operators.ConditionalCompareObjectLess(((UltraGridBase)ugEquity).get_Rows().get_Item(i).get_Cells()
							.get_Item("Change")
							.get_Value(), (object)0, false))
						{
							((UltraGridBase)ugEquity).get_Rows().get_Item(i).get_Appearance()
								.set_ForeColor(strcolor);
						}
						((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_L_ZERO", (object)strcolor);
						break;
					}
					i++;
				}
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Save_PortFolio()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		StreamWriter streamWriter = null;
		string text = "";
		try
		{
			SaveFileDialog saveFile = SaveFile;
			((FileDialog)saveFile).set_Filter("Text files (*.TV18)|*.TV18|All files|*.*");
			if ((int)((CommonDialog)saveFile).ShowDialog() == 1)
			{
				streamWriter = new StreamWriter(((FileDialog)saveFile).get_FileName());
				RowEnumerator enumerator = ((UltraGridBase)ugEquity).get_Rows().GetEnumerator();
				while (enumerator.MoveNext())
				{
					UltraGridRow current = enumerator.get_Current();
					if (current.get_Cells().get_Item("Exchange Symbol").get_Value() != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Exchange Symbol").get_Value(), (object)"HH", false))
					{
						text = text + Strings.UCase(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Exchange Symbol").get_Value()))) + ", " + Strings.UCase(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Series").get_Value()))) + ", " + Strings.UCase(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Market Type").get_Value()))) + "\r\n";
					}
				}
				streamWriter.Write(text);
			}
			if ((Operators.CompareString(text, "", false) != 0) & (Operators.CompareString(((FileDialog)saveFile).get_FileName(), "", false) != 0))
			{
				Interaction.MsgBox((object)("Data Saved to :" + ((FileDialog)saveFile).get_FileName()), (MsgBoxStyle)0, (object)null);
			}
			saveFile = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			streamWriter?.Close();
		}
	}

	private void File_New()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		try
		{
			if (((UltraGridBase)ugEquity).get_Rows().get_Count() == 0)
			{
				return;
			}
			MsgBoxResult val = Interaction.MsgBox((object)" The Current item list has unsaved changes.Would you like to save them now?", (MsgBoxStyle)3, (object)null);
			if ((int)val != 2)
			{
				if ((int)val == 6)
				{
					Save_PortFolio();
				}
				objEquity = new clsEquity();
				objEquity.DeletePortFolio(Tab_Name, Tab_Index);
				BindGridData();
				((UltraGridBase)ugEquity).UpdateData();
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
				objEquity.DeletePortFolio(((Form)this).get_Text(), Tab_Index);
				while (text != null)
				{
					if (Strings.InStr(1, text, ",", (CompareMethod)0) > 0)
					{
						Array array = Strings.Split(text, ",", -1, (CompareMethod)0);
						string text2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null));
						strSQL = "SELECT Symbol FROM Vehicle_Exchange WHERE Series = 'Equity' AND ExchangeSymbol = '" + text2 + "'";
						string strBridgeSymbol = Conversions.ToString(SqlHelper.ExecuteScalar(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL));
						Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
						Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null));
						objEquity = new clsEquity();
						objEquity.AddLookUp(strBridgeSymbol, text2, ((Form)this).get_Text(), Tab_Index);
						text = streamReader.ReadLine();
					}
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

	private void Update_EquityConnectedUsers()
	{
		try
		{
			objEquity = new clsEquity();
			strSQL = "UPDATE CNBCMONEY_USERS_MST SET ISACTIVE = 1, UPDATED_DATETIME = GETDATE() WHERE TABINDEX = " + Conversions.ToString(Tab_Index) + " AND  USERNAME = '" + mdlMain.gUserName + "'";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Reset_To_Default()
	{
		checked
		{
			try
			{
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("FONT_DATA", (object)"VERDANA");
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("FONT_SIZE", (object)"10");
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_BACKGROUND", (object)Color.White);
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_G_ZERO", (object)Color.Green);
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_E_ZERO", (object)Color.Black);
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_L_ZERO", (object)Color.Red);
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				int num = ((UltraGridBase)ugEquity).get_Rows().get_Count() - 1;
				i = 0;
				while (true)
				{
					int num2 = i;
					int num3 = num;
					if (num2 > num3)
					{
						break;
					}
					double num4 = Conversions.ToDouble(((UltraGridBase)ugEquity).get_Rows().get_Item(i).get_Cells()
						.get_Item("Change")
						.get_Value());
					if (num4 == 0.0)
					{
						((UltraGridBase)ugEquity).get_Rows().get_Item(i).get_Appearance()
							.set_ForeColor(Color.Black);
					}
					else if (num4 > 0.0)
					{
						((UltraGridBase)ugEquity).get_Rows().get_Item(i).get_Appearance()
							.set_ForeColor(Color.Green);
					}
					else if (num4 < 0.0)
					{
						((UltraGridBase)ugEquity).get_Rows().get_Item(i).get_Appearance()
							.set_ForeColor(Color.Red);
					}
					i++;
				}
				((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().get_RowAppearance()
					.set_BackColor2(Color.White);
				((UltraGridBase)ugEquity).get_DisplayLayout().get_Appearance().get_FontData()
					.set_Name("VERDANA");
				((UltraGridBase)ugEquity).get_DisplayLayout().get_Appearance().get_FontData()
					.set_SizeInPoints(10f);
				UpdateSettingsToDB();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Rename_Tab_Name(string strOldTabName, string strNewTabName)
	{
		try
		{
			if (((UltraGridBase)ugEquity).get_Rows().get_Count() > 0)
			{
				objEquity = new clsEquity();
				strSQL = "UPDATE CNBCMONEY_USERS_MST SET TABNAME  = '" + Strings.Replace(strNewTabName, "'", "''", 1, -1, (CompareMethod)0) + "' WHERE  USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX = " + Conversions.ToString(Tab_Index);
				SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
				Rename_MDI_TabEvent?.Invoke(strNewTabName);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PowerUDP_Connect()
	{
		try
		{
			objEquity = new clsEquity();
			PowerUDP.Open(objEquity.getMyIP(), 15007);
			byte[] array = new byte[257];
			PowerUDP.BeginReceive(array);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string BytesToString(ref byte[] Data, short max)
	{
		checked
		{
			try
			{
				Data = (byte[])Utils.CopyArray((Array)Data, (Array)new byte[max + 1]);
				string text = "";
				short num = max;
				short num2 = 0;
				while (true)
				{
					short num3 = num2;
					short num4 = num;
					if (num3 > num4)
					{
						break;
					}
					text += Conversions.ToString(Strings.Chr(unchecked((int)Data[num2])));
					num2 = (short)unchecked(num2 + 1);
				}
				return text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public void CrunchData(string aa)
	{
		checked
		{
			try
			{
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
						RowEnumerator enumerator = ((UltraGridBase)ugEquity).get_Rows().GetEnumerator();
						while (enumerator.MoveNext())
						{
							UltraGridRow current = enumerator.get_Current();
							if (current.get_Index() == ((UltraGridBase)ugEquity).get_Rows().get_Count() - 1)
							{
								break;
							}
							if (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Exchange Symbol").get_Value()))), Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)))), false) == 0)
							{
								if ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "CN", (CompareMethod)0) > 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Series").get_Value()))), Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false) == 0))
								{
									if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(current.get_Cells().get_Item("Last Price").get_Value(), (object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false), (object)(Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null)))) != 0.0))) && ((Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Volume").get_Value()))) < Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null))))) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null)))) != 0.0)))
									{
										try
										{
											current.get_Cells().get_Item("Last Price").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										}
										catch (Exception projectError)
										{
											ProjectData.SetProjectError(projectError);
											Debug.WriteLine("HERE2" + Information.Err().get_Description());
											ProjectData.ClearProjectError();
										}
										current.get_Cells().get_Item("Change").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Operators.SubtractObject(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("% Change").set_Value((object)Strings.FormatNumber(Operators.MultiplyObject(Operators.DivideObject(current.get_Cells().get_Item("Change").get_Value(), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))), (object)100), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("Open").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("High").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 12 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("Low").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 13 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("Turn Over").set_Value((object)Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Volume").get_Value()), (object)100000), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("Market Cap").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Share Outstanding").get_Value()), (object)10000000), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
										if ((Conversions.ToDouble(current.get_Cells().get_Item("High").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("WEEKHIGH52").get_Appearance()
												.set_BackColor(Color.HotPink);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("WEEKLOW52").get_Appearance()
												.set_BackColor(Color.HotPink);
										}
										if (Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null)) > 0.0)
										{
											current.get_Cells().get_Item("Day High").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)((Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 12 }, (string[])null)) - Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null))) / Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null)) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2))));
										}
										else
										{
											current.get_Cells().get_Item("Day High").set_Value((object)0);
										}
										if (Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 13 }, (string[])null)) > 0.0)
										{
											current.get_Cells().get_Item("Day Low").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)((Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null)) - Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 13 }, (string[])null))) / Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 13 }, (string[])null)) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2))));
										}
										else
										{
											current.get_Cells().get_Item("Day Low").set_Value((object)0);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("WEEKHIGH52").get_Appearance()
												.set_BackColor(Color.HotPink);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("WEEKLOW52").get_Appearance()
												.set_BackColor(Color.HotPink);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("High").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("LifeTime High").get_Appearance()
												.set_BackColor(Color.HotPink);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("LifeTime Low").get_Appearance()
												.set_BackColor(Color.HotPink);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("LifeTime High").get_Appearance()
												.set_BackColor(Color.HotPink);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("LifeTime Low").get_Appearance()
												.set_BackColor(Color.HotPink);
										}
									}
									if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) >= 0.995 * Conversions.ToDouble(current.get_Cells().get_Item("Upper Circuit").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("Upper Circuit").get_Value()) > 0.0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Change").get_Value()))) > 0.0))
									{
										current.get_Cells().get_Item("% Change").get_Appearance()
											.set_BackColor(Color.LightSkyBlue);
									}
									if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) <= 1.005 * Conversions.ToDouble(current.get_Cells().get_Item("Lower Circuit").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("Lower Circuit").get_Value()) > 0.0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Change").get_Value()))) < 0.0))
									{
										current.get_Cells().get_Item("% Change").get_Appearance()
											.set_BackColor(Color.DarkBlue);
									}
									if ((Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Volume").get_Value()))) < Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null))))) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null)))) != 0.0))
									{
										current.get_Cells().get_Item("Volume").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 9 }, (string[])null)))));
										current.get_Cells().get_Item("Turn Over").set_Value((object)Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Volume").get_Value()), (object)100000), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
									}
									if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null)))) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))) > 0.0)
									{
										current.get_Cells().get_Item("Change").set_Value(RuntimeHelpers.GetObjectValue(current.get_Cells().get_Item("Change").get_Value()));
										current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
									}
									else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null)))) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))) < 0.0)
									{
										current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
									}
									else
									{
										current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
									}
									break;
								}
								if (Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "CX", (CompareMethod)0) > 0)
								{
									if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Last Price").get_Value(), (object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false))
									{
										current.get_Cells().get_Item("Last Price").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("WEEKHIGH52").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 7 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("WEEKLOW52").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("Change").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Operators.SubtractObject(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("% Change").set_Value((object)Strings.FormatNumber(Operators.MultiplyObject(Operators.DivideObject(current.get_Cells().get_Item("Change").get_Value(), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))), (object)100), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("Open").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("High").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 5 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("Low").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										current.get_Cells().get_Item("Market Cap").set_Value((object)Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Share Outstanding").get_Value()), (object)10000000), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
										if (Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)) > 0.0)
										{
											current.get_Cells().get_Item("Day High").set_Value((object)Strings.FormatNumber((object)((Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 5 }, (string[])null)) - Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null))) / Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
										}
										else
										{
											current.get_Cells().get_Item("Day High").set_Value((object)"0.00");
										}
										if (Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)) > 0.0)
										{
											current.get_Cells().get_Item("Day Low").set_Value((object)Strings.FormatNumber((object)((Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)) - Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null))) / Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
										}
										else
										{
											current.get_Cells().get_Item("Day Low").set_Value((object)"0.00");
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("High").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("WEEKHIGH52").get_Appearance()
												.set_BackColor(Color.Green);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("WEEKLOW52").get_Appearance()
												.set_BackColor(Color.Green);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("WEEKHIGH52").get_Appearance()
												.set_BackColor(Color.Green);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("WEEKLOW52").get_Appearance()
												.set_BackColor(Color.Green);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("High").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("LifeTime High").get_Appearance()
												.set_BackColor(Color.Green);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("LifeTime Low").get_Appearance()
												.set_BackColor(Color.Green);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("LifeTime High").get_Appearance()
												.set_BackColor(Color.Green);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("LifeTime Low").get_Appearance()
												.set_BackColor(Color.Green);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("High").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("Yest_High").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("Yest_High").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("High").get_Appearance()
												.set_BackColor(Color.Pink);
										}
										if ((Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("Yest_Low").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("Yest_Low").get_Value()) > 0.0))
										{
											current.get_Cells().get_Item("Low").get_Appearance()
												.set_BackColor(Color.Pink);
										}
									}
									if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) >= 0.995 * Conversions.ToDouble(current.get_Cells().get_Item("Upper Circuit").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("Upper Circuit").get_Value()) > 0.0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Change").get_Value()))) > 0.0))
									{
										current.get_Cells().get_Item("% Change").get_Appearance()
											.set_BackColor(Color.LightSkyBlue);
									}
									else
									{
										current.get_Cells().get_Item("% Change").get_Appearance()
											.set_BackColor(Color.White);
									}
									if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) <= 1.005 * Conversions.ToDouble(current.get_Cells().get_Item("Lower Circuit").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("Lower Circuit").get_Value()) > 0.0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Change").get_Value()))) < 0.0))
									{
										current.get_Cells().get_Item("% Change").get_Appearance()
											.set_BackColor(Color.DarkBlue);
									}
									else
									{
										current.get_Cells().get_Item("% Change").get_Appearance()
											.set_BackColor(Color.White);
									}
									if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))) > 0.0)
									{
										current.get_Cells().get_Item("Change").set_Value(RuntimeHelpers.GetObjectValue(current.get_Cells().get_Item("Change").get_Value()));
										current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
									}
									else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))) < 0.0)
									{
										current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
									}
									else
									{
										current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
									}
									break;
								}
							}
							if (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Exchange Symbol").get_Value()))), Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 2 }, (string[])null)))), false) != 0)
							{
								continue;
							}
							if (Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)), "1907", (CompareMethod)0) > 0)
							{
								if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Last Price").get_Value(), (object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false))
								{
									current.get_Cells().get_Item("Last Price").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
									current.get_Cells().get_Item("Change").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)(Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)))) / 100.0 - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value())))), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
									current.get_Cells().get_Item("% Change").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.MultiplyObject(Operators.DivideObject(current.get_Cells().get_Item("Change").get_Value(), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))), (object)100), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
									current.get_Cells().get_Item("Market Cap").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Share Outstanding").get_Value()), (object)10000000), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
									current.get_Cells().get_Item("Turn Over").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Volume").get_Value()), (object)100000), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) >= 0.995 * Conversions.ToDouble(current.get_Cells().get_Item("Upper Circuit").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("Upper Circuit").get_Value()) > 0.0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Change").get_Value()))) > 0.0))
								{
									current.get_Cells().get_Item("Change").get_Appearance()
										.set_BackColor(Color.LightSkyBlue);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) <= 1.005 * Conversions.ToDouble(current.get_Cells().get_Item("Lower Circuit").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("Lower Circuit").get_Value()) > 0.0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Change").get_Value()))) < 0.0))
								{
									current.get_Cells().get_Item("Change").get_Appearance()
										.set_BackColor(Color.DarkBlue);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("High").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("WEEKHIGH52").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("WEEKLOW52").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("WEEKHIGH52").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("WEEKLOW52").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("High").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("LifeTime High").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("LifeTime Low").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("LifeTime High").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("LifeTime Low").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if (Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) > Conversions.ToDouble("0"))
								{
									current.get_Cells().get_Item("Day High").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)((Conversions.ToDouble(current.get_Cells().get_Item("High").get_Value()) - Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value())) / Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2))));
								}
								else
								{
									current.get_Cells().get_Item("Day High").set_Value((object)0);
								}
								if (Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) > Conversions.ToDouble("0"))
								{
									current.get_Cells().get_Item("Day Low").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) - Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value())) / Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2))));
								}
								else
								{
									current.get_Cells().get_Item("Day Low").set_Value((object)0);
								}
								((UltraGridBase)ugEquity).UpdateData();
								break;
							}
							if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Last Price").get_Value(), (object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false))
							{
								current.get_Cells().get_Item("Last Price").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
								current.get_Cells().get_Item("Change").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)(Conversions.ToDouble(Operators.DivideObject(NewLateBinding.LateIndexGet((object)array2, new object[1] { 11 }, (string[])null), (object)100)) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value())))), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
								current.get_Cells().get_Item("% Change").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)(Conversions.ToDouble(Operators.DivideObject(current.get_Cells().get_Item("Change").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))))) * 100.0), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
								current.get_Cells().get_Item("Open").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 3 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
								current.get_Cells().get_Item("High").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 5 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
								current.get_Cells().get_Item("Low").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 6 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
								current.get_Cells().get_Item("Market Cap").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Share Outstanding").get_Value()), (object)10000000), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
								current.get_Cells().get_Item("Turn Over").set_Value((object)Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Volume").get_Value()), (object)100000), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("WEEKHIGH52").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("WEEKLOW52").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("LifeTime High").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("LifeTime Low").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("High").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKHIGH52").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("WEEKHIGH52").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("WEEKLOW52").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("WEEKLOW52").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("High").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime High").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("LifeTime High").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("LifeTime Low").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("LifeTime Low").get_Appearance()
										.set_BackColor(Color.Green);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("High").get_Value()) >= Conversions.ToDouble(current.get_Cells().get_Item("Yest_High").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("Yest_High").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("High").get_Appearance()
										.set_BackColor(Color.Pink);
								}
								if ((Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) <= Conversions.ToDouble(current.get_Cells().get_Item("Yest_Low").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("Yest_Low").get_Value()) > 0.0))
								{
									current.get_Cells().get_Item("Low").get_Appearance()
										.set_BackColor(Color.Pink);
								}
							}
							if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) >= 0.995 * Conversions.ToDouble(current.get_Cells().get_Item("Upper Circuit").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("Upper Circuit").get_Value()) > 0.0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Change").get_Value()))) > 0.0))
							{
								current.get_Cells().get_Item("% Change").get_Appearance()
									.set_BackColor(Color.LightSkyBlue);
							}
							else
							{
								current.get_Cells().get_Item("% Change").get_Appearance()
									.set_BackColor(Color.White);
							}
							if ((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) <= 1.005 * Conversions.ToDouble(current.get_Cells().get_Item("Lower Circuit").get_Value())) & (Conversions.ToDouble(current.get_Cells().get_Item("Lower Circuit").get_Value()) > 0.0) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Change").get_Value()))) < 0.0))
							{
								current.get_Cells().get_Item("% Change").get_Appearance()
									.set_BackColor(Color.DarkBlue);
							}
							else
							{
								current.get_Cells().get_Item("% Change").get_Appearance()
									.set_BackColor(Color.White);
							}
							if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Volume").get_Value()))) < Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null))))))
							{
								current.get_Cells().get_Item("Volume").set_Value((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array2, new object[1] { 8 }, (string[])null)))));
								current.get_Cells().get_Item("Turn Over").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Volume").get_Value()), (object)100000), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
							}
							if (Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))) > 0.0)
							{
								current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
								current.get_Cells().get_Item("Change").set_Value((object)Conversions.ToDouble(current.get_Cells().get_Item("Change").get_Value()));
							}
							else if (Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))) < 0.0)
							{
								current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
							}
							else
							{
								current.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
							}
							if (Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) > Conversions.ToDouble("0"))
							{
								current.get_Cells().get_Item("Day High").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)((Conversions.ToDouble(current.get_Cells().get_Item("High").get_Value()) - Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value())) / Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2))));
							}
							else
							{
								current.get_Cells().get_Item("Day High").set_Value((object)"0.00");
							}
							if (Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) > Conversions.ToDouble("0"))
							{
								current.get_Cells().get_Item("Day Low").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)((Conversions.ToDouble(current.get_Cells().get_Item("Last Price").get_Value()) - Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value())) / Conversions.ToDouble(current.get_Cells().get_Item("Low").get_Value()) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2))));
							}
							else
							{
								current.get_Cells().get_Item("Day Low").set_Value((object)"0.00");
							}
							((UltraGridBase)ugEquity).UpdateData();
							break;
						}
					}
					num2++;
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DoChangeText(string strGroup, string strTool, string theTextString)
	{
		try
		{
			if (((Control)this).get_InvokeRequired())
			{
				ChangeText changeText = DoChangeText;
				((Control)this).Invoke((Delegate)changeText, new object[3] { strGroup, strTool, theTextString });
			}
			else
			{
				((ToolPropsBase)((ToolsCollectionBase)((RibbonTabCollectionBase)UltraToolbarsManager1.get_Ribbon().get_Tabs()).get_Item(0).get_Groups().get_Item(strGroup)
					.get_Tools()).get_Item(strTool).get_SharedProps()).set_Caption(theTextString);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void UpdateRow(string strExchangeSymbol, int iVolume)
	{
		DataColumn dataColumn = dtEquity.Columns[1];
		DataColumn[] array = new DataColumn[1];
		object[] array2 = new object[checked(dtEquity.Columns.Count - 1 + 1)];
		array[0] = dataColumn;
		dtEquity.PrimaryKey = array;
		array2[1] = strExchangeSymbol;
		array2[6] = iVolume;
		dtEquity.BeginLoadData();
		dtEquity.LoadDataRow(array2, LoadOption.PreserveChanges);
		dtEquity.EndLoadData();
	}

	private void DeActivateTab()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected I4, but got Unknown
		try
		{
			string text;
			string text2;
			if (((DisposableObjectCollectionBase)((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
				.get_SortedColumns()).get_Count() > 0)
			{
				text = ((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
					.get_SortedColumns()
					.get_Item(0)
					.ToString();
				text2 = Conversions.ToString((int)((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
					.get_SortedColumns()
					.get_Item(0)
					.get_SortIndicator());
			}
			else
			{
				text = "";
				text2 = "";
			}
			objEquity = new clsEquity();
			strSQL = "UPDATE CNBCMONEY_USERS_MST SET ISACTIVE = 0, SORT_INDICATOR = '" + text2 + "', SORT_COLUMN = '" + text + "' WHERE TABINDEX = " + Conversions.ToString(Tab_Index) + " AND USERNAME = '" + mdlMain.gUserName + "'";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private bool IsActiveRow(string strTitle)
	{
		if ((((UltraGridBase)ugEquity).get_ActiveRow() == null) | ((UltraGridBase)ugEquity).get_ActiveRow().get_IsFilterRow())
		{
			mdlMain.ShowMessage("Select a stock.", "UltraToolbarsManager1_ToolClick :: " + strTitle);
			return false;
		}
		return true;
	}

	private void AdvancedColumns(bool showhide)
	{
		try
		{
			((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Exchange Symbol")
				.set_Hidden(showhide);
			((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Market Type")
				.set_Hidden(showhide);
			((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Series")
				.set_Hidden(showhide);
			((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Upper Circuit")
				.set_Hidden(showhide);
			((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Lower Circuit")
				.set_Hidden(showhide);
			((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Week Close")
				.set_Hidden(showhide);
			((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("Month Close")
				.set_Hidden(showhide);
			((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
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

	private void Update_DateTime()
	{
		try
		{
			strSQL = "UPDATE CNBCMONEY_USERS_MST SET UPDATED_DATETIME = GETDATE() WHERE USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX IN (111, 0," + Conversions.ToString(Tab_Index) + ")";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
			strSQL = "UPDATE CNBCMONEY_DETAILS SET UPDATED_DATETIME = GETDATE() WHERE USERID IN (SELECT USERID FROM CNBCMONEY_USERS_MST WHERE USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX IN (111, 0," + Conversions.ToString(Tab_Index) + "))";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void UpdateSettingsToDB()
	{
		try
		{
			strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("UPDATE CNBCMONEY_USERS_MST SET COLOR_BACKGROUND = '" + Conversions.ToString(MySettingsProperty.Settings.COLOR_BACKGROUND.ToArgb()), "', "), " COLOR_CHANGE_L_ZERO = '"), Conversions.ToString(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO.ToArgb())), "', COLOR_CHANGE_E_ZERO = '"), Conversions.ToString(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO.ToArgb())), "', "), " COLOR_CHANGE_G_ZERO = '"), Conversions.ToString(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO.ToArgb())), "', FONT_DATA ='"), Interaction.IIf(Operators.CompareString(MySettingsProperty.Settings.FONT_DATA, "", false) == 0, (object)"Verdana", (object)MySettingsProperty.Settings.FONT_DATA)), (object)"', "), (object)" FONT_SIZE = '"), (object)MySettingsProperty.Settings.FONT_SIZE), (object)"' WHERE USERNAME = '"), (object)mdlMain.gUserName), (object)"'"));
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void GetSettingsFromDB()
	{
		try
		{
			strSQL = "SELECT * FROM CNBCMONEY_USERS_MST WHERE USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX = " + Conversions.ToString(Tab_Index);
			dt = new DataTable();
			dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
			if (dt.Rows.Count > 0 && dt.Rows[0]["COLOR_BACKGROUND"] != DBNull.Value)
			{
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_BACKGROUND", (object)Color.FromArgb(Conversions.ToInteger(dt.Rows[0]["COLOR_BACKGROUND"])));
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_L_ZERO", (object)Color.FromArgb(Conversions.ToInteger(dt.Rows[0]["COLOR_CHANGE_L_ZERO"])));
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_G_ZERO", (object)Color.FromArgb(Conversions.ToInteger(dt.Rows[0]["COLOR_CHANGE_G_ZERO"])));
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_E_ZERO", (object)Color.FromArgb(Conversions.ToInteger(dt.Rows[0]["COLOR_CHANGE_E_ZERO"])));
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("FONT_DATA", RuntimeHelpers.GetObjectValue(dt.Rows[0]["FONT_DATA"]));
				((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("FONT_SIZE", RuntimeHelpers.GetObjectValue(dt.Rows[0]["FONT_SIZE"]));
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
