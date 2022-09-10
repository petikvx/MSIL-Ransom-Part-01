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

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmEquity : Form
{
	private delegate void Delg_SortColumn();

	private delegate void Delg_CrunchData(string str);

	private delegate void ChangeText(string strGroup, string strTool, string theTextString);

	public delegate void MarketWatchEventHandler();

	public delegate void SendToBroadCastEventHandler();

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

	[AccessedThroughProperty("OpenMyFile")]
	private OpenFileDialog _OpenMyFile;

	[AccessedThroughProperty("PowerTCP")]
	private Tcp _PowerTCP;

	[AccessedThroughProperty("PowerUDP")]
	private Udp _PowerUDP;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("ugEquity")]
	private UltraGrid _ugEquity;

	[AccessedThroughProperty("Timer2_ReSort")]
	private Timer _Timer2_ReSort;

	private string strSQL;

	private string strChart;

	private DataSet ds;

	private DataTable dtEquity;

	private DataTable dt;

	private int i;

	private string strSortColumn;

	private bool strSort;

	private string OldBridgeSymbol;

	private string DeleteExchangeSymbol;

	private clsEquity objEquity;

	private int RowIndex;

	private int CellIndex;

	private string strIssueCapital;

	private DateTime datetime_LastSort;

	private string U_COLOR;

	private string D_COLOR;

	private string UN_COLOR;

	private string BG_COLOR;

	private Appearance specialRowSeparatorAppearance;

	[AccessedThroughProperty("NewStock")]
	private frmNewStock _NewStock;

	[AccessedThroughProperty("FeedRanking")]
	private frmFeedRanking _FeedRanking;

	private MarketWatchEventHandler MarketWatchEvent;

	private SendToBroadCastEventHandler SendToBroadCastEvent;

	private Rename_MDI_TabEventHandler Rename_MDI_TabEvent;

	private int _TabIndex;

	private string _Tab_Name;

	private string _ExchangeSymbol;

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

	internal virtual OpenFileDialog OpenMyFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenMyFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OpenMyFile = value;
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
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected O, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected O, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Expected O, but got Unknown
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Expected O, but got Unknown
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected O, but got Unknown
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Expected O, but got Unknown
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Expected O, but got Unknown
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Expected O, but got Unknown
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Expected O, but got Unknown
			if (_ugEquity != null)
			{
				_ugEquity.remove_AfterCellUpdate(new CellEventHandler(ugEquity_AfterCellUpdate));
				((UltraGridBase)_ugEquity).remove_BeforeColumnChooserDisplayed(new BeforeColumnChooserDisplayedEventHandler(ugEquity_BeforeColumnChooserDisplayed));
				((Control)_ugEquity).remove_DragDrop(new DragEventHandler(ugEquity_DragDrop));
				((Control)_ugEquity).remove_DragOver(new DragEventHandler(ugEquity_DragOver));
				_ugEquity.remove_SelectionDrag((CancelEventHandler)ugEquity_SelectionDrag);
				_ugEquity.remove_InitializeLayout(new InitializeLayoutEventHandler(ugEquity_InitializeLayout));
				_ugEquity.remove_CellChange(new CellEventHandler(ugEquity_CellChange));
				_ugEquity.remove_BeforeRowsDeleted(new BeforeRowsDeletedEventHandler(ugEquity_BeforeRowsDeleted));
				_ugEquity.remove_BeforeCellUpdate(new BeforeCellUpdateEventHandler(ugEquity_BeforeCellUpdate));
				((UltraGridBase)_ugEquity).remove_AfterSortChange(new BandEventHandler(ugEquity_AfterSortChange));
				_ugEquity.remove_AfterRowsDeleted((EventHandler)ugEquity_AfterRowsDeleted);
				_ugEquity.remove_AfterRowInsert(new RowEventHandler(ugEquity_AfterRowInsert));
			}
			_ugEquity = value;
			if (_ugEquity != null)
			{
				_ugEquity.add_AfterCellUpdate(new CellEventHandler(ugEquity_AfterCellUpdate));
				((UltraGridBase)_ugEquity).add_BeforeColumnChooserDisplayed(new BeforeColumnChooserDisplayedEventHandler(ugEquity_BeforeColumnChooserDisplayed));
				((Control)_ugEquity).add_DragDrop(new DragEventHandler(ugEquity_DragDrop));
				((Control)_ugEquity).add_DragOver(new DragEventHandler(ugEquity_DragOver));
				_ugEquity.add_SelectionDrag((CancelEventHandler)ugEquity_SelectionDrag);
				_ugEquity.add_InitializeLayout(new InitializeLayoutEventHandler(ugEquity_InitializeLayout));
				_ugEquity.add_CellChange(new CellEventHandler(ugEquity_CellChange));
				_ugEquity.add_BeforeRowsDeleted(new BeforeRowsDeletedEventHandler(ugEquity_BeforeRowsDeleted));
				_ugEquity.add_BeforeCellUpdate(new BeforeCellUpdateEventHandler(ugEquity_BeforeCellUpdate));
				((UltraGridBase)_ugEquity).add_AfterSortChange(new BandEventHandler(ugEquity_AfterSortChange));
				_ugEquity.add_AfterRowsDeleted((EventHandler)ugEquity_AfterRowsDeleted);
				_ugEquity.add_AfterRowInsert(new RowEventHandler(ugEquity_AfterRowInsert));
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

	public event SendToBroadCastEventHandler SendToBroadCast
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			SendToBroadCastEvent = (SendToBroadCastEventHandler)Delegate.Combine(SendToBroadCastEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			SendToBroadCastEvent = (SendToBroadCastEventHandler)Delegate.Remove(SendToBroadCastEvent, value);
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

	public frmEquity()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)frmEquity_Load);
		((Form)this).add_FormClosed(new FormClosedEventHandler(frmEquity_FormClosed));
		__ENCList.Add(new WeakReference(this));
		dtEquity = new DataTable();
		strSortColumn = "";
		strSort = true;
		OldBridgeSymbol = "";
		DeleteExchangeSymbol = "";
		strIssueCapital = "";
		datetime_LastSort = DateAndTime.get_Now();
		specialRowSeparatorAppearance = new Appearance();
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
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
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
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
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
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
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
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected O, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected O, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected O, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected O, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected O, but got Unknown
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected O, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected O, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected O, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected O, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected O, but got Unknown
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected O, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected O, but got Unknown
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
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected O, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected O, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected O, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected O, but got Unknown
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected O, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected O, but got Unknown
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected O, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected O, but got Unknown
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected O, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected O, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected O, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected O, but got Unknown
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected O, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected O, but got Unknown
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected O, but got Unknown
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected O, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected O, but got Unknown
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected O, but got Unknown
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected O, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected O, but got Unknown
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected O, but got Unknown
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected O, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected O, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected O, but got Unknown
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected O, but got Unknown
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected O, but got Unknown
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected O, but got Unknown
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected O, but got Unknown
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected O, but got Unknown
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected O, but got Unknown
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected O, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected O, but got Unknown
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected O, but got Unknown
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected O, but got Unknown
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Expected O, but got Unknown
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected O, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected O, but got Unknown
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected O, but got Unknown
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected O, but got Unknown
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected O, but got Unknown
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected O, but got Unknown
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected O, but got Unknown
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Expected O, but got Unknown
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected O, but got Unknown
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected O, but got Unknown
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected O, but got Unknown
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected O, but got Unknown
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected O, but got Unknown
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected O, but got Unknown
		//IL_2491: Unknown result type (might be due to invalid IL or missing references)
		//IL_249b: Expected O, but got Unknown
		components = new Container();
		UltraToolbar val = new UltraToolbar("UltraToolbar1");
		PopupMenuTool val2 = new PopupMenuTool("File");
		PopupMenuTool val3 = new PopupMenuTool("Add");
		PopupMenuTool val4 = new PopupMenuTool("AutoFill");
		PopupMenuTool val5 = new PopupMenuTool("View");
		PopupMenuTool val6 = new PopupMenuTool("Help");
		ButtonTool val7 = new ButtonTool("AddNewStock");
		Appearance val8 = new Appearance();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmEquity));
		PopupMenuTool val9 = new PopupMenuTool("AutoFill");
		ButtonTool val10 = new ButtonTool("FeedRanking");
		PopupMenuTool val11 = new PopupMenuTool("StandardList");
		ButtonTool val12 = new ButtonTool("FeedRanking");
		Appearance val13 = new Appearance();
		PopupMenuTool val14 = new PopupMenuTool("View");
		PopupMenuTool val15 = new PopupMenuTool("Chart");
		PopupMenuTool val16 = new PopupMenuTool("TechChart");
		ButtonTool val17 = new ButtonTool("FullQuote");
		ButtonTool val18 = new ButtonTool("OPTIONSDATA");
		ButtonTool val19 = new ButtonTool("ShowStory");
		ButtonTool val20 = new ButtonTool("Note");
		PopupMenuTool val21 = new PopupMenuTool("Properties");
		TextBoxTool val22 = new TextBoxTool("RenameTab");
		PopupMenuTool val23 = new PopupMenuTool("Advanced");
		ButtonTool val24 = new ButtonTool("AddSeperator");
		PopupMenuTool val25 = new PopupMenuTool("Chart");
		Appearance val26 = new Appearance();
		ButtonTool val27 = new ButtonTool("Today");
		ButtonTool val28 = new ButtonTool("7Days");
		ButtonTool val29 = new ButtonTool("14Days");
		ButtonTool val30 = new ButtonTool("1 Month");
		ButtonTool val31 = new ButtonTool("3 Months");
		ButtonTool val32 = new ButtonTool("6 Months");
		ButtonTool val33 = new ButtonTool("ThisYear");
		ButtonTool val34 = new ButtonTool("1Year");
		ButtonTool val35 = new ButtonTool("2Year");
		PopupMenuTool val36 = new PopupMenuTool("TechChart");
		Appearance val37 = new Appearance();
		ButtonTool val38 = new ButtonTool("1Month");
		ButtonTool val39 = new ButtonTool("3Months");
		ButtonTool val40 = new ButtonTool("6Months");
		ButtonTool val41 = new ButtonTool("12Months");
		ButtonTool val42 = new ButtonTool("This Year");
		ButtonTool val43 = new ButtonTool("FullQuote");
		Appearance val44 = new Appearance();
		ButtonTool val45 = new ButtonTool("Today");
		Appearance val46 = new Appearance();
		ButtonTool val47 = new ButtonTool("7Days");
		Appearance val48 = new Appearance();
		ButtonTool val49 = new ButtonTool("14Days");
		Appearance val50 = new Appearance();
		ButtonTool val51 = new ButtonTool("1 Month");
		Appearance val52 = new Appearance();
		ButtonTool val53 = new ButtonTool("3 Months");
		Appearance val54 = new Appearance();
		ButtonTool val55 = new ButtonTool("6 Months");
		Appearance val56 = new Appearance();
		ButtonTool val57 = new ButtonTool("ThisYear");
		Appearance val58 = new Appearance();
		ButtonTool val59 = new ButtonTool("1Year");
		Appearance val60 = new Appearance();
		ButtonTool val61 = new ButtonTool("2Year");
		Appearance val62 = new Appearance();
		ButtonTool val63 = new ButtonTool("3Months");
		Appearance val64 = new Appearance();
		ButtonTool val65 = new ButtonTool("6Months");
		Appearance val66 = new Appearance();
		ButtonTool val67 = new ButtonTool("12Months");
		Appearance val68 = new Appearance();
		ButtonTool val69 = new ButtonTool("This Year");
		Appearance val70 = new Appearance();
		PopupMenuTool val71 = new PopupMenuTool("Properties");
		Appearance val72 = new Appearance();
		FontListTool val73 = new FontListTool("Font");
		ComboBoxTool val74 = new ComboBoxTool("FontSize");
		PopupColorPickerTool val75 = new PopupColorPickerTool("Color");
		PopupColorPickerTool val76 = new PopupColorPickerTool("Change>0");
		PopupColorPickerTool val77 = new PopupColorPickerTool("Change=0");
		PopupColorPickerTool val78 = new PopupColorPickerTool("Change<0");
		ButtonTool val79 = new ButtonTool("ResettoDefault");
		FontListTool val80 = new FontListTool("Font");
		Appearance val81 = new Appearance();
		PopupColorPickerTool val82 = new PopupColorPickerTool("Color");
		Appearance val83 = new Appearance();
		PopupMenuTool val84 = new PopupMenuTool("File");
		ButtonTool val85 = new ButtonTool("New");
		ButtonTool val86 = new ButtonTool("FileOpen");
		ButtonTool val87 = new ButtonTool("Refresh");
		ButtonTool val88 = new ButtonTool("SaveAs");
		ButtonTool val89 = new ButtonTool("ExporttoExcel");
		ButtonTool val90 = new ButtonTool("ExporttoExcel");
		Appearance val91 = new Appearance();
		ButtonTool val92 = new ButtonTool("Refresh");
		Appearance val93 = new Appearance();
		PopupColorPickerTool val94 = new PopupColorPickerTool("Change>0");
		Appearance val95 = new Appearance();
		PopupColorPickerTool val96 = new PopupColorPickerTool("Change=0");
		Appearance val97 = new Appearance();
		PopupColorPickerTool val98 = new PopupColorPickerTool("Change<0");
		Appearance val99 = new Appearance();
		ButtonTool val100 = new ButtonTool("SaveAs");
		Appearance val101 = new Appearance();
		PopupMenuTool val102 = new PopupMenuTool("Add");
		ButtonTool val103 = new ButtonTool("AddNewStock");
		ButtonTool val104 = new ButtonTool("New");
		Appearance val105 = new Appearance();
		ButtonTool val106 = new ButtonTool("FileOpen");
		Appearance val107 = new Appearance();
		ButtonTool val108 = new ButtonTool("ResettoDefault");
		Appearance val109 = new Appearance();
		TextBoxTool val110 = new TextBoxTool("RenameTab");
		Appearance val111 = new Appearance();
		ButtonTool val112 = new ButtonTool("Note");
		Appearance val113 = new Appearance();
		ComboBoxTool val114 = new ComboBoxTool("FontSize");
		Appearance val115 = new Appearance();
		ValueList val116 = new ValueList(0);
		ValueListItem val117 = new ValueListItem();
		ValueListItem val118 = new ValueListItem();
		ValueListItem val119 = new ValueListItem();
		ValueListItem val120 = new ValueListItem();
		ValueListItem val121 = new ValueListItem();
		ValueListItem val122 = new ValueListItem();
		ValueListItem val123 = new ValueListItem();
		ValueListItem val124 = new ValueListItem();
		ValueListItem val125 = new ValueListItem();
		ValueListItem val126 = new ValueListItem();
		ButtonTool val127 = new ButtonTool("1Month");
		Appearance val128 = new Appearance();
		ButtonTool val129 = new ButtonTool("AdvancedColumns");
		Appearance val130 = new Appearance();
		ButtonTool val131 = new ButtonTool("OPTIONSDATA");
		Appearance val132 = new Appearance();
		ButtonTool val133 = new ButtonTool("ShowStory");
		Appearance val134 = new Appearance();
		PopupMenuTool val135 = new PopupMenuTool("Advanced");
		Appearance val136 = new Appearance();
		ButtonTool val137 = new ButtonTool("AdvancedColumns");
		ButtonTool val138 = new ButtonTool("ShowColumns");
		ButtonTool val139 = new ButtonTool("RemoveSorting");
		ButtonTool val140 = new ButtonTool("ShowColumns");
		Appearance val141 = new Appearance();
		PopupMenuTool val142 = new PopupMenuTool("StandardList");
		Appearance val143 = new Appearance();
		ButtonTool val144 = new ButtonTool("Sensex");
		ButtonTool val145 = new ButtonTool("Nifty");
		ButtonTool val146 = new ButtonTool("AllIndices");
		ButtonTool val147 = new ButtonTool("NSETopVolume");
		ButtonTool val148 = new ButtonTool("ForeignIndices");
		ButtonTool val149 = new ButtonTool("Gainers");
		ButtonTool val150 = new ButtonTool("Losers");
		ButtonTool val151 = new ButtonTool("Sensex");
		Appearance val152 = new Appearance();
		ButtonTool val153 = new ButtonTool("Nifty");
		Appearance val154 = new Appearance();
		ButtonTool val155 = new ButtonTool("AllIndices");
		Appearance val156 = new Appearance();
		ButtonTool val157 = new ButtonTool("NSETopVolume");
		Appearance val158 = new Appearance();
		ButtonTool val159 = new ButtonTool("AddSeperator");
		ButtonTool val160 = new ButtonTool("RemoveSorting");
		Appearance val161 = new Appearance();
		ButtonTool val162 = new ButtonTool("ForeignIndices");
		Appearance val163 = new Appearance();
		PopupMenuTool val164 = new PopupMenuTool("Help");
		ButtonTool val165 = new ButtonTool("HelpShortcuts");
		ButtonTool val166 = new ButtonTool("About CNBC Money 2010");
		ButtonTool val167 = new ButtonTool("HelpShortcuts");
		ButtonTool val168 = new ButtonTool("About CNBC Money 2010");
		ButtonTool val169 = new ButtonTool("Gainers");
		Appearance val170 = new Appearance();
		ButtonTool val171 = new ButtonTool("Losers");
		Appearance val172 = new Appearance();
		UltraGridBand val173 = new UltraGridBand("Band 0", -1);
		UltraGridColumn val174 = new UltraGridColumn("Bridge Symbol");
		UltraGridColumn val175 = new UltraGridColumn("IssueCapital");
		UltraGridColumn val176 = new UltraGridColumn("Exchange Symbol");
		UltraGridColumn val177 = new UltraGridColumn("Scrip Name");
		UltraGridColumn val178 = new UltraGridColumn("Last Price");
		UltraGridColumn val179 = new UltraGridColumn("Change");
		UltraGridColumn val180 = new UltraGridColumn("% Change");
		UltraGridColumn val181 = new UltraGridColumn("Volume");
		UltraGridColumn val182 = new UltraGridColumn("Close Price");
		UltraGridColumn val183 = new UltraGridColumn("Week % Change");
		UltraGridColumn val184 = new UltraGridColumn("Month % Change");
		UltraGridColumn val185 = new UltraGridColumn("Year %  Change");
		UltraGridColumn val186 = new UltraGridColumn("Open");
		UltraGridColumn val187 = new UltraGridColumn("High");
		UltraGridColumn val188 = new UltraGridColumn("Low");
		UltraGridColumn val189 = new UltraGridColumn("WeekHigh52");
		UltraGridColumn val190 = new UltraGridColumn("WeekLow52");
		UltraGridColumn val191 = new UltraGridColumn("LifeTime High");
		UltraGridColumn val192 = new UltraGridColumn("LifeTime Low");
		UltraGridColumn val193 = new UltraGridColumn("Share Outstanding");
		UltraGridColumn val194 = new UltraGridColumn("Market Cap");
		UltraGridColumn val195 = new UltraGridColumn("Turn Over");
		UltraGridColumn val196 = new UltraGridColumn("Series %");
		UltraGridColumn val197 = new UltraGridColumn("Upper Circuit");
		UltraGridColumn val198 = new UltraGridColumn("Lower Circuit");
		UltraGridColumn val199 = new UltraGridColumn("10 Day Avg");
		UltraGridColumn val200 = new UltraGridColumn("Market Type");
		UltraGridColumn val201 = new UltraGridColumn("Series");
		UltraGridColumn val202 = new UltraGridColumn("Day High");
		UltraGridColumn val203 = new UltraGridColumn("Day Low");
		UltraGridColumn val204 = new UltraGridColumn("Week Close");
		UltraGridColumn val205 = new UltraGridColumn("Month Close");
		UltraGridColumn val206 = new UltraGridColumn("Year Close");
		Appearance val207 = new Appearance();
		Appearance val208 = new Appearance();
		Appearance val209 = new Appearance();
		Appearance val210 = new Appearance();
		Appearance val211 = new Appearance();
		Appearance val212 = new Appearance();
		Appearance val213 = new Appearance();
		UltraToolbarsManager1 = new UltraToolbarsManager(components);
		ugEquity = new UltraGrid();
		_InheritedForm_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
		_InheritedForm_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
		_InheritedForm_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
		_InheritedForm_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
		UltraGridExcelExporter1 = new UltraGridExcelExporter(components);
		SaveFile = new SaveFileDialog();
		OpenMyFile = new OpenFileDialog();
		PowerTCP = new Tcp(components);
		PowerUDP = new Udp(components);
		Timer1 = new Timer(components);
		Timer2_ReSort = new Timer(components);
		((ISupportInitialize)UltraToolbarsManager1).BeginInit();
		((ISupportInitialize)ugEquity).BeginInit();
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
		((ToolsCollectionBase)((UltraToolbarBase)val).get_Tools()).AddRange((ToolBase[])(object)new ToolBase[5]
		{
			(ToolBase)val2,
			(ToolBase)val3,
			(ToolBase)val4,
			(ToolBase)val5,
			(ToolBase)val6
		});
		UltraToolbarsManager1.get_Toolbars().AddRange((UltraToolbar[])(object)new UltraToolbar[1] { val });
		UltraToolbarsManager1.get_ToolbarSettings().set_AllowCustomize((DefaultableBoolean)2);
		val8.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance8.Image")));
		((ToolPropsBase)((ToolBase)val7).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val8);
		((ToolPropsBase)((ToolBase)val7).get_SharedProps()).set_Caption("New Stock");
		((ToolPropsBase)((ToolBase)val7).get_SharedProps()).set_DisplayStyle((ToolDisplayStyle)4);
		((ToolBase)val7).get_SharedProps().set_Shortcut((Shortcut)117);
		((ToolPropsBase)((ToolBase)val9).get_SharedProps()).set_Caption("AutoFill");
		((ToolsCollectionBase)val9.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[2]
		{
			(ToolBase)val10,
			(ToolBase)val11
		});
		val13.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance9.Image")));
		((ToolPropsBase)((ToolBase)val12).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val13);
		((ToolPropsBase)((ToolBase)val12).get_SharedProps()).set_Caption("Feed Ranking");
		((ToolBase)val12).get_SharedProps().set_Shortcut((Shortcut)118);
		((ToolPropsBase)((ToolBase)val14).get_SharedProps()).set_Caption("View");
		((ToolBase)val21).get_InstanceProps().set_IsFirstInGroup(true);
		((ToolsCollectionBase)val14.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[10]
		{
			(ToolBase)val15,
			(ToolBase)val16,
			(ToolBase)val17,
			(ToolBase)val18,
			(ToolBase)val19,
			(ToolBase)val20,
			(ToolBase)val21,
			(ToolBase)val22,
			(ToolBase)val23,
			(ToolBase)val24
		});
		val26.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance10.Image")));
		((ToolPropsBase)((ToolBase)val25).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val26);
		((ToolPropsBase)((ToolBase)val25).get_SharedProps()).set_Caption("Chart");
		((ToolsCollectionBase)val25.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[9]
		{
			(ToolBase)val27,
			(ToolBase)val28,
			(ToolBase)val29,
			(ToolBase)val30,
			(ToolBase)val31,
			(ToolBase)val32,
			(ToolBase)val33,
			(ToolBase)val34,
			(ToolBase)val35
		});
		val37.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance11.Image")));
		((ToolPropsBase)((ToolBase)val36).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val37);
		((ToolPropsBase)((ToolBase)val36).get_SharedProps()).set_Caption("TechChart");
		((ToolsCollectionBase)val36.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[5]
		{
			(ToolBase)val38,
			(ToolBase)val39,
			(ToolBase)val40,
			(ToolBase)val41,
			(ToolBase)val42
		});
		val44.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance12.Image")));
		((ToolPropsBase)((ToolBase)val43).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val44);
		((ToolPropsBase)((ToolBase)val43).get_SharedProps()).set_Caption("Full Quote");
		((ToolBase)val43).get_SharedProps().set_Shortcut((Shortcut)120);
		val46.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance13.Image")));
		((ToolPropsBase)((ToolBase)val45).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val46);
		((ToolPropsBase)((ToolBase)val45).get_SharedProps()).set_Caption("Today");
		((ToolBase)val45).get_SharedProps().set_Shortcut((Shortcut)123);
		val48.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance14.Image")));
		((ToolPropsBase)((ToolBase)val47).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val48);
		((ToolPropsBase)((ToolBase)val47).get_SharedProps()).set_Caption("7 Days");
		val50.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance15.Image")));
		((ToolPropsBase)((ToolBase)val49).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val50);
		((ToolPropsBase)((ToolBase)val49).get_SharedProps()).set_Caption("14 Days");
		val52.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance16.Image")));
		((ToolPropsBase)((ToolBase)val51).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val52);
		((ToolPropsBase)((ToolBase)val51).get_SharedProps()).set_Caption("1 Month");
		val54.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance17.Image")));
		((ToolPropsBase)((ToolBase)val53).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val54);
		((ToolPropsBase)((ToolBase)val53).get_SharedProps()).set_Caption("3 Months");
		val56.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance18.Image")));
		((ToolPropsBase)((ToolBase)val55).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val56);
		((ToolPropsBase)((ToolBase)val55).get_SharedProps()).set_Caption("6 Months");
		val58.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance19.Image")));
		((ToolPropsBase)((ToolBase)val57).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val58);
		((ToolPropsBase)((ToolBase)val57).get_SharedProps()).set_Caption("This Year");
		val60.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance20.Image")));
		((ToolPropsBase)((ToolBase)val59).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val60);
		((ToolPropsBase)((ToolBase)val59).get_SharedProps()).set_Caption("1 Year");
		val62.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance21.Image")));
		((ToolPropsBase)((ToolBase)val61).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val62);
		((ToolPropsBase)((ToolBase)val61).get_SharedProps()).set_Caption("2 Year");
		val64.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance22.Image")));
		((ToolPropsBase)((ToolBase)val63).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val64);
		((ToolPropsBase)((ToolBase)val63).get_SharedProps()).set_Caption("3 Months");
		val66.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance23.Image")));
		((ToolPropsBase)((ToolBase)val65).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val66);
		((ToolPropsBase)((ToolBase)val65).get_SharedProps()).set_Caption("6 Months");
		val68.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance24.Image")));
		((ToolPropsBase)((ToolBase)val67).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val68);
		((ToolPropsBase)((ToolBase)val67).get_SharedProps()).set_Caption("12 Months");
		val70.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance25.Image")));
		((ToolPropsBase)((ToolBase)val69).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val70);
		((ToolPropsBase)((ToolBase)val69).get_SharedProps()).set_Caption("This Year");
		val72.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance26.Image")));
		((ToolPropsBase)((ToolBase)val71).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val72);
		((ToolPropsBase)((ToolBase)val71).get_SharedProps()).set_Caption("Properties");
		((ToolsCollectionBase)val71.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[7]
		{
			(ToolBase)val73,
			(ToolBase)val74,
			(ToolBase)val75,
			(ToolBase)val76,
			(ToolBase)val77,
			(ToolBase)val78,
			(ToolBase)val79
		});
		val81.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance27.Image")));
		((ToolPropsBase)((ToolBase)val80).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val81);
		((ToolPropsBase)((ToolBase)val80).get_SharedProps()).set_Caption("Font Name");
		((ToolPropsBase)((ToolBase)val80).get_SharedProps()).set_MinWidth(150);
		val82.set_ReplaceableColor(Color.Empty);
		val83.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance28.Image")));
		((ToolPropsBase)((ToolBase)val82).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val83);
		((ToolPropsBase)((ToolBase)val82).get_SharedProps()).set_Caption("Background Color");
		((ToolBase)val82).get_SharedProps().set_Visible(false);
		((ToolPropsBase)((ToolBase)val84).get_SharedProps()).set_Caption("File");
		((ToolsCollectionBase)val84.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[5]
		{
			(ToolBase)val85,
			(ToolBase)val86,
			(ToolBase)val87,
			(ToolBase)val88,
			(ToolBase)val89
		});
		val91.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance29.Image")));
		((ToolPropsBase)((ToolBase)val90).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val91);
		((ToolPropsBase)((ToolBase)val90).get_SharedProps()).set_Caption("Export to Excel");
		((ToolPropsBase)((ToolBase)val90).get_SharedProps()).set_DisplayStyle((ToolDisplayStyle)4);
		((ToolBase)val90).get_SharedProps().set_Shortcut((Shortcut)131141);
		val93.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance30.Image")));
		((ToolPropsBase)((ToolBase)val92).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val93);
		((ToolPropsBase)((ToolBase)val92).get_SharedProps()).set_Caption("Refresh");
		((ToolPropsBase)((ToolBase)val92).get_SharedProps()).set_DisplayStyle((ToolDisplayStyle)4);
		((ToolBase)val92).get_SharedProps().set_Shortcut((Shortcut)116);
		val95.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance31.Image")));
		((ToolPropsBase)((ToolBase)val94).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val95);
		((ToolPropsBase)((ToolBase)val94).get_SharedProps()).set_Caption("Color [Change > 0]");
		val97.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance32.Image")));
		((ToolPropsBase)((ToolBase)val96).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val97);
		((ToolPropsBase)((ToolBase)val96).get_SharedProps()).set_Caption("Color [Change = 0]");
		val99.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance33.Image")));
		((ToolPropsBase)((ToolBase)val98).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val99);
		((ToolPropsBase)((ToolBase)val98).get_SharedProps()).set_Caption("Color [Change < 0]");
		val101.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance34.Image")));
		((ToolPropsBase)((ToolBase)val100).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val101);
		((ToolPropsBase)((ToolBase)val100).get_SharedProps()).set_Caption("Save As");
		((ToolPropsBase)((ToolBase)val100).get_SharedProps()).set_DisplayStyle((ToolDisplayStyle)4);
		((ToolBase)val100).get_SharedProps().set_Shortcut((Shortcut)131155);
		((ToolPropsBase)((ToolBase)val102).get_SharedProps()).set_Caption("Manual Add");
		((ToolsCollectionBase)val102.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[1] { (ToolBase)val103 });
		val105.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance35.Image")));
		((ToolPropsBase)((ToolBase)val104).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val105);
		((ToolPropsBase)((ToolBase)val104).get_SharedProps()).set_Caption("New");
		((ToolBase)val104).get_SharedProps().set_Shortcut((Shortcut)131150);
		val107.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance36.Image")));
		((ToolPropsBase)((ToolBase)val106).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val107);
		((ToolPropsBase)((ToolBase)val106).get_SharedProps()).set_Caption("Open");
		((ToolBase)val106).get_SharedProps().set_Shortcut((Shortcut)131151);
		val109.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance37.Image")));
		((ToolPropsBase)((ToolBase)val108).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val109);
		((ToolPropsBase)((ToolBase)val108).get_SharedProps()).set_Caption("Reset to Default");
		val111.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance38.Image")));
		((ToolPropsBase)((ToolBase)val110).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val111);
		((ToolPropsBase)((ToolBase)val110).get_SharedProps()).set_Caption("Rename Tab");
		val113.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance39.Image")));
		((ToolPropsBase)((ToolBase)val112).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val113);
		((ToolPropsBase)((ToolBase)val112).get_SharedProps()).set_Caption("Make a Note");
		((ToolBase)val112).get_SharedProps().set_Shortcut((Shortcut)119);
		val115.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance40.Image")));
		((ToolPropsBase)((ToolBase)val114).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val115);
		((ToolPropsBase)((ToolBase)val114).get_SharedProps()).set_Caption("Font Size");
		((ToolPropsBase)((ToolBase)val114).get_SharedProps()).set_MinWidth(50);
		((ToolPropsBase)((ToolBase)val114).get_SharedProps()).set_Width(50);
		val117.set_DataValue((object)"8");
		val117.set_DisplayText("8pt");
		val118.set_DataValue((object)"10");
		val118.set_DisplayText("10pt");
		val119.set_DataValue((object)"11");
		val119.set_DisplayText("11pt");
		val120.set_DataValue((object)"12");
		val120.set_DisplayText("12pt");
		val121.set_DataValue((object)"13");
		val121.set_DisplayText("13pt");
		val122.set_DataValue((object)"14");
		val122.set_DisplayText("14pt");
		val123.set_DataValue((object)"15");
		val123.set_DisplayText("15pt");
		val124.set_DataValue((object)"16");
		val124.set_DisplayText("16pt");
		val125.set_DataValue((object)"17");
		val125.set_DisplayText("17pt");
		val126.set_DataValue((object)"18");
		val126.set_DisplayText("18pt");
		val116.get_ValueListItems().AddRange((ValueListItem[])(object)new ValueListItem[10] { val117, val118, val119, val120, val121, val122, val123, val124, val125, val126 });
		val114.set_ValueList(val116);
		val128.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance41.Image")));
		((ToolPropsBase)((ToolBase)val127).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val128);
		((ToolPropsBase)((ToolBase)val127).get_SharedProps()).set_Caption("1 Month");
		val130.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance42.Image")));
		((ToolPropsBase)((ToolBase)val129).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val130);
		((ToolPropsBase)((ToolBase)val129).get_SharedProps()).set_Caption("Hide Columns");
		((ToolBase)val129).get_SharedProps().set_Shortcut((Shortcut)131140);
		val132.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance43.Image")));
		((ToolPropsBase)((ToolBase)val131).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val132);
		((ToolPropsBase)((ToolBase)val131).get_SharedProps()).set_Caption("Options Data");
		((ToolBase)val131).get_SharedProps().set_Shortcut((Shortcut)121);
		val134.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance44.Image")));
		((ToolPropsBase)((ToolBase)val133).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val134);
		((ToolPropsBase)((ToolBase)val133).get_SharedProps()).set_Caption("Show Story");
		((ToolBase)val133).get_SharedProps().set_Shortcut((Shortcut)122);
		val136.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance45.Image")));
		((ToolPropsBase)((ToolBase)val135).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val136);
		((ToolPropsBase)((ToolBase)val135).get_SharedProps()).set_Caption("Advanced");
		((ToolsCollectionBase)val135.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[3]
		{
			(ToolBase)val137,
			(ToolBase)val138,
			(ToolBase)val139
		});
		val141.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance46.Image")));
		((ToolPropsBase)((ToolBase)val140).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val141);
		((ToolPropsBase)((ToolBase)val140).get_SharedProps()).set_Caption("Show Columns");
		((ToolBase)val140).get_SharedProps().set_Shortcut((Shortcut)196676);
		val143.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance47.Image")));
		((ToolPropsBase)((ToolBase)val142).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val143);
		((ToolPropsBase)((ToolBase)val142).get_SharedProps()).set_Caption("Standard List");
		((ToolsCollectionBase)val142.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[7]
		{
			(ToolBase)val144,
			(ToolBase)val145,
			(ToolBase)val146,
			(ToolBase)val147,
			(ToolBase)val148,
			(ToolBase)val149,
			(ToolBase)val150
		});
		val152.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance48.Image")));
		((ToolPropsBase)((ToolBase)val151).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val152);
		((ToolPropsBase)((ToolBase)val151).get_SharedProps()).set_Caption("Sensex");
		((ToolBase)val151).get_SharedProps().set_Shortcut((Shortcut)131145);
		val154.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance49.Image")));
		((ToolPropsBase)((ToolBase)val153).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val154);
		((ToolPropsBase)((ToolBase)val153).get_SharedProps()).set_Caption("Nifty");
		((ToolBase)val153).get_SharedProps().set_Shortcut((Shortcut)131146);
		val156.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance50.Image")));
		((ToolPropsBase)((ToolBase)val155).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val156);
		((ToolPropsBase)((ToolBase)val155).get_SharedProps()).set_Caption("All Indices");
		((ToolBase)val155).get_SharedProps().set_Shortcut((Shortcut)131147);
		val158.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance51.Image")));
		((ToolPropsBase)((ToolBase)val157).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val158);
		((ToolPropsBase)((ToolBase)val157).get_SharedProps()).set_Caption("NSE Top Volume");
		((ToolBase)val157).get_SharedProps().set_Shortcut((Shortcut)131148);
		((ToolPropsBase)((ToolBase)val159).get_SharedProps()).set_Caption("Add Seperator");
		((ToolBase)val159).get_SharedProps().set_Visible(false);
		val161.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance52.Image")));
		((ToolPropsBase)((ToolBase)val160).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val161);
		((ToolPropsBase)((ToolBase)val160).get_SharedProps()).set_Caption("Remove Sorting");
		((ToolBase)val160).get_SharedProps().set_Shortcut((Shortcut)131149);
		val163.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance53.Image")));
		((ToolPropsBase)((ToolBase)val162).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val163);
		((ToolPropsBase)((ToolBase)val162).get_SharedProps()).set_Caption("Foreign Indices");
		((ToolBase)val162).get_SharedProps().set_Shortcut((Shortcut)131154);
		((ToolPropsBase)((ToolBase)val164).get_SharedProps()).set_Caption("Help");
		((ToolsCollectionBase)val164.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[2]
		{
			(ToolBase)val165,
			(ToolBase)val166
		});
		((ToolPropsBase)((ToolBase)val167).get_SharedProps()).set_Caption("Help Shortcuts");
		((ToolBase)val167).get_SharedProps().set_Shortcut((Shortcut)112);
		((ToolPropsBase)((ToolBase)val168).get_SharedProps()).set_Caption("About CNBC Money 2010");
		val170.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance54.Image")));
		((ToolPropsBase)((ToolBase)val169).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val170);
		((ToolPropsBase)((ToolBase)val169).get_SharedProps()).set_Caption("Gainers");
		((ToolBase)val169).get_SharedProps().set_Shortcut((Shortcut)131143);
		val172.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance55.Image")));
		((ToolPropsBase)((ToolBase)val171).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val172);
		((ToolPropsBase)((ToolBase)val171).get_SharedProps()).set_Caption("Losers");
		((ToolBase)val171).get_SharedProps().set_Shortcut((Shortcut)131157);
		UltraToolbarsManager1.get_Tools().AddRange((ToolBase[])(object)new ToolBase[56]
		{
			(ToolBase)val7,
			(ToolBase)val9,
			(ToolBase)val12,
			(ToolBase)val14,
			(ToolBase)val25,
			(ToolBase)val36,
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
			(ToolBase)val71,
			(ToolBase)val80,
			(ToolBase)val82,
			(ToolBase)val84,
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
			(ToolBase)val114,
			(ToolBase)val127,
			(ToolBase)val129,
			(ToolBase)val131,
			(ToolBase)val133,
			(ToolBase)val135,
			(ToolBase)val140,
			(ToolBase)val142,
			(ToolBase)val151,
			(ToolBase)val153,
			(ToolBase)val155,
			(ToolBase)val157,
			(ToolBase)val159,
			(ToolBase)val160,
			(ToolBase)val162,
			(ToolBase)val164,
			(ToolBase)val167,
			(ToolBase)val168,
			(ToolBase)val169,
			(ToolBase)val171
		});
		((Control)ugEquity).set_AllowDrop(true);
		UltraToolbarsManager1.SetContextMenuUltra((Component)(object)ugEquity, "View");
		val174.get_Header().set_VisiblePosition(0);
		val175.get_Header().set_VisiblePosition(1);
		val176.set_CellActivation((Activation)3);
		val176.get_Header().set_VisiblePosition(2);
		val177.set_CellActivation((Activation)3);
		val177.get_Header().set_VisiblePosition(3);
		val178.set_CellActivation((Activation)3);
		val178.get_Header().set_VisiblePosition(4);
		val179.set_CellActivation((Activation)3);
		val179.get_Header().set_VisiblePosition(5);
		val180.set_CellActivation((Activation)3);
		val180.get_Header().set_VisiblePosition(6);
		val181.set_CellActivation((Activation)3);
		val181.get_Header().set_VisiblePosition(10);
		val182.set_CellActivation((Activation)3);
		val182.get_Header().set_VisiblePosition(11);
		val183.set_CellActivation((Activation)3);
		val183.get_Header().set_VisiblePosition(7);
		val184.set_CellActivation((Activation)3);
		val184.get_Header().set_VisiblePosition(8);
		val185.get_Header().set_VisiblePosition(9);
		val186.set_CellActivation((Activation)3);
		val186.get_Header().set_VisiblePosition(12);
		val187.set_CellActivation((Activation)3);
		val187.get_Header().set_VisiblePosition(13);
		val188.set_CellActivation((Activation)3);
		val188.get_Header().set_VisiblePosition(14);
		val189.set_CellActivation((Activation)3);
		val189.set_Format("0.00");
		val189.get_Header().set_VisiblePosition(15);
		val190.set_CellActivation((Activation)3);
		val190.set_Format("0.00");
		val190.get_Header().set_VisiblePosition(16);
		val191.set_CellActivation((Activation)3);
		val191.get_Header().set_VisiblePosition(17);
		val192.set_CellActivation((Activation)3);
		val192.set_Format("0.00");
		val192.get_Header().set_VisiblePosition(18);
		val193.set_CellActivation((Activation)3);
		val193.get_Header().set_VisiblePosition(19);
		val194.set_CellActivation((Activation)3);
		val194.get_Header().set_VisiblePosition(20);
		val195.set_CellActivation((Activation)3);
		val195.get_Header().set_VisiblePosition(21);
		val196.set_CellActivation((Activation)3);
		val196.get_Header().set_VisiblePosition(22);
		val197.set_CellActivation((Activation)3);
		val197.get_Header().set_VisiblePosition(23);
		val198.set_CellActivation((Activation)3);
		val198.get_Header().set_VisiblePosition(24);
		val199.set_CellActivation((Activation)3);
		val199.get_Header().set_VisiblePosition(25);
		val200.set_CellActivation((Activation)3);
		val200.get_Header().set_VisiblePosition(26);
		val201.set_CellActivation((Activation)3);
		val201.get_Header().set_VisiblePosition(27);
		val202.set_CellActivation((Activation)3);
		val202.get_Header().set_VisiblePosition(28);
		val203.set_CellActivation((Activation)3);
		val203.get_Header().set_VisiblePosition(29);
		val204.set_CellActivation((Activation)3);
		val204.get_Header().set_VisiblePosition(30);
		val205.set_CellActivation((Activation)3);
		val205.get_Header().set_VisiblePosition(31);
		val206.set_CellActivation((Activation)3);
		val206.get_Header().set_VisiblePosition(32);
		val173.get_Columns().AddRange(new object[33]
		{
			val174, val175, val176, val177, val178, val179, val180, val181, val182, val183,
			val184, val185, val186, val187, val188, val189, val190, val191, val192, val193,
			val194, val195, val196, val197, val198, val199, val200, val201, val202, val203,
			val204, val205, val206
		});
		val207.set_BackColor(Color.Purple);
		val207.set_BackColor2(Color.Purple);
		val173.get_Override().set_SelectedCellAppearance((AppearanceBase)(object)val207);
		val208.set_BackColor(Color.Maroon);
		val173.get_Override().set_SpecialRowSeparatorAppearance((AppearanceBase)(object)val208);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_BandsSerializer().Add((object)val173);
		((UltraGridBase)ugEquity).get_DisplayLayout().set_CaptionVisible((DefaultableBoolean)2);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_EmptyRowSettings().set_Style((EmptyRowStyle)0);
		((SpecialBoxBase)((UltraGridBase)ugEquity).get_DisplayLayout().get_GroupByBox()).set_Hidden(true);
		((UltraGridBase)ugEquity).get_DisplayLayout().set_MaxColScrollRegions(1);
		((UltraGridBase)ugEquity).get_DisplayLayout().set_MaxRowScrollRegions(1);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_AllowAddNew((AllowAddNew)6);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_AllowRowFiltering((DefaultableBoolean)1);
		val209.set_BackColor(Color.Transparent);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val209);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_FilterOperatorLocation((FilterOperatorLocation)3);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_FilterUIType((FilterUIType)2);
		val210.set_BackColor(Color.FromArgb(89, 135, 214));
		val210.set_BackColor2(Color.FromArgb(7, 59, 150));
		val210.set_BackGradientStyle((GradientStyle)2);
		val210.get_FontData().set_BoldAsString("True");
		val210.get_FontData().set_Name("Arial");
		val210.get_FontData().set_SizeInPoints(10f);
		val210.set_ForeColor(Color.White);
		val210.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val210);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_HeaderClickAction((HeaderClickAction)2);
		val211.set_BackGradientAlignment((GradientAlignment)3);
		val211.set_BackGradientStyle((GradientStyle)2);
		val211.set_BackHatchStyle((BackHatchStyle)2);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_RowAppearance((AppearanceBase)(object)val211);
		val212.set_BackColor(Color.FromArgb(89, 135, 214));
		val212.set_BackColor2(Color.FromArgb(7, 59, 150));
		val212.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val212);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_RowSelectorHeaderStyle((RowSelectorHeaderStyle)4);
		val213.set_BackColor(Color.FromArgb(251, 230, 148));
		val213.set_BackColor2(Color.FromArgb(238, 149, 21));
		val213.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val213);
		((UltraGridBase)ugEquity).get_DisplayLayout().get_Override().set_SelectTypeRow((SelectType)4);
		((UltraGridBase)ugEquity).get_DisplayLayout().set_ScrollBounds((ScrollBounds)0);
		((UltraGridBase)ugEquity).get_DisplayLayout().set_ScrollStyle((ScrollStyle)1);
		((Control)ugEquity).set_Dock((DockStyle)5);
		((Control)ugEquity).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraGrid obj = ugEquity;
		Point location = new Point(4, 48);
		((Control)obj).set_Location(location);
		((Control)ugEquity).set_Name("ugEquity");
		UltraGrid obj2 = ugEquity;
		Size size = new Size(691, 350);
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
		size = new Size(4, 350);
		((Control)inheritedForm_Toolbars_Dock_Area_Left2).set_Size(size);
		_InheritedForm_Toolbars_Dock_Area_Left.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_InheritedForm_Toolbars_Dock_Area_Right).set_AccessibleRole((AccessibleRole)20);
		((Control)_InheritedForm_Toolbars_Dock_Area_Right).set_BackColor(Color.FromArgb(191, 219, 255));
		_InheritedForm_Toolbars_Dock_Area_Right.set_DockedPosition((DockedPosition)3);
		((Control)_InheritedForm_Toolbars_Dock_Area_Right).set_ForeColor(SystemColors.ControlText);
		_InheritedForm_Toolbars_Dock_Area_Right.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Right = _InheritedForm_Toolbars_Dock_Area_Right;
		location = new Point(695, 48);
		((Control)inheritedForm_Toolbars_Dock_Area_Right).set_Location(location);
		((Control)_InheritedForm_Toolbars_Dock_Area_Right).set_Name("_InheritedForm_Toolbars_Dock_Area_Right");
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Right2 = _InheritedForm_Toolbars_Dock_Area_Right;
		size = new Size(4, 350);
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
		size = new Size(699, 48);
		((Control)inheritedForm_Toolbars_Dock_Area_Top2).set_Size(size);
		_InheritedForm_Toolbars_Dock_Area_Top.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_InheritedForm_Toolbars_Dock_Area_Bottom).set_AccessibleRole((AccessibleRole)20);
		((Control)_InheritedForm_Toolbars_Dock_Area_Bottom).set_BackColor(Color.FromArgb(191, 219, 255));
		_InheritedForm_Toolbars_Dock_Area_Bottom.set_DockedPosition((DockedPosition)1);
		((Control)_InheritedForm_Toolbars_Dock_Area_Bottom).set_ForeColor(SystemColors.ControlText);
		_InheritedForm_Toolbars_Dock_Area_Bottom.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Bottom = _InheritedForm_Toolbars_Dock_Area_Bottom;
		location = new Point(0, 398);
		((Control)inheritedForm_Toolbars_Dock_Area_Bottom).set_Location(location);
		((Control)_InheritedForm_Toolbars_Dock_Area_Bottom).set_Name("_InheritedForm_Toolbars_Dock_Area_Bottom");
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Bottom2 = _InheritedForm_Toolbars_Dock_Area_Bottom;
		size = new Size(699, 4);
		((Control)inheritedForm_Toolbars_Dock_Area_Bottom2).set_Size(size);
		_InheritedForm_Toolbars_Dock_Area_Bottom.set_ToolbarsManager(UltraToolbarsManager1);
		((FileDialog)OpenMyFile).set_DefaultExt("TV18");
		((FileDialog)OpenMyFile).set_Filter("Text files (*.TV18)|*.TV18|\" & \"All files|*.*");
		PowerUDP.set_Editor((object)PowerUDP);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(300000);
		Timer2_ReSort.set_Enabled(true);
		Timer2_ReSort.set_Interval(5000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(699, 402);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ugEquity);
		((Control)this).get_Controls().Add((Control)(object)_InheritedForm_Toolbars_Dock_Area_Left);
		((Control)this).get_Controls().Add((Control)(object)_InheritedForm_Toolbars_Dock_Area_Right);
		((Control)this).get_Controls().Add((Control)(object)_InheritedForm_Toolbars_Dock_Area_Top);
		((Control)this).get_Controls().Add((Control)(object)_InheritedForm_Toolbars_Dock_Area_Bottom);
		((Control)this).set_Name("frmEquity");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_Text("EQUITY");
		((ISupportInitialize)UltraToolbarsManager1).EndInit();
		((ISupportInitialize)ugEquity).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmEquity_Load(object sender, EventArgs e)
	{
		try
		{
			objEquity = new clsEquity();
			strSQL = "SELECT ISNULL(SORT_COLUMN,'') AS SORT_COLUMN, ISNULL(SORT_INDICATOR,0) AS SORT_INDICATOR FROM CNBCMONEY_USERS_MST  WHERE USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX = " + Conversions.ToString(Tab_Index);
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
			BindGridData(IsNewList: false, IsFormLoad: true);
			objEquity = new clsEquity();
			objEquity.Update_ConnectedUsers(Tab_Index);
			((Control)ugEquity).Focus();
			SendToBroadCastEvent?.Invoke();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void frmEquity_FormClosed(object sender, FormClosedEventArgs e)
	{
		try
		{
			objEquity = new clsEquity();
			objEquity.DeActivateTab(Tab_Index, strSortColumn, Conversions.ToString(strSort));
			PowerUDP.Close();
			((Component)(object)PowerUDP).Dispose();
			SendToBroadCastEvent?.Invoke();
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
		objEquity = new clsEquity();
		objEquity.Update_ConnectedUsers(Tab_Index);
	}

	private void FeedRanking_TextHasChanged()
	{
		AddFeedRanking();
		objEquity = new clsEquity();
		objEquity.Update_ConnectedUsers(Tab_Index);
	}

	private void ugEquity_AfterCellUpdate(object sender, CellEventArgs e)
	{
		try
		{
			if (!e.get_Cell().get_IsFilterRowCell() && Operators.CompareString(((HeaderBase)e.get_Cell().get_Column().get_Header()).get_Caption(), "Bridge Symbol", false) == 0)
			{
				ManualAdd(e.get_Cell().get_Row().get_Index());
				OldBridgeSymbol = "";
				((UltraGridBase)ugEquity).UpdateData();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ugEquity_AfterRowInsert(object sender, RowEventArgs e)
	{
		checked
		{
			try
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
							.RefreshSort(false);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
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

	private void ugEquity_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
	{
		try
		{
			if ((!e.get_Cell().get_Row().get_IsAddRow() & !e.get_Cell().get_Row().get_IsFilterRow()) && Operators.CompareString(((HeaderBase)e.get_Cell().get_Column().get_Header()).get_Caption(), "Bridge Symbol", false) == 0)
			{
				OldBridgeSymbol = Conversions.ToString(((UltraGridBase)ugEquity).get_Rows().get_Item(e.get_Cell().get_Row().get_Index()).get_Cells()
					.get_Item(0)
					.get_Value());
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
				e.get_Cell().Activate();
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
				((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
					.get_Override()
					.set_RowSelectorNumberStyle((RowSelectorNumberStyle)3);
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
				UltraGridBand val2 = e.get_Layout().get_Bands().get_Item(0);
				((HeaderBase)val2.get_Columns().get_Item("Day High").get_Header()).set_Caption("% OFF High");
				((HeaderBase)val2.get_Columns().get_Item("Day Low").get_Header()).set_Caption("% OFF Low");
				val2.get_Columns().get_Item("Market Cap").set_Format("0.00");
				val2.get_Columns().get_Item("% Change").set_Format("0.00");
				val2.get_Columns().get_Item("Last Price").set_Format("0.00");
				val2.get_Columns().get_Item("LifeTime High").set_Format("0.00");
				((HeaderBase)val2.get_Columns().get_Item("Week % change").get_Header()).set_Caption("W % Change");
				((HeaderBase)val2.get_Columns().get_Item("Month % change").get_Header()).set_Caption("M % Change");
				((HeaderBase)val2.get_Columns().get_Item("Year % change").get_Header()).set_Caption("Y % Change");
				val2.get_Columns().get_Item("IssueCapital").set_Width(0);
				val2.get_Columns().get_Item("IssueCapital").set_Hidden(true);
				val2.get_Columns().get_Item("Series %").set_Width(0);
				val2.get_Columns().get_Item("Series %").set_Hidden(true);
				val2 = null;
				if (!IsAdvance)
				{
					AdvancedColumns(showhide: true);
				}
				e.get_Layout().get_Bands().get_Item(0)
					.get_Override()
					.set_SpecialRowSeparator((SpecialRowSeparator)16);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ugEquity_SelectionDrag(object sender, CancelEventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		((Control)ugEquity).DoDragDrop((object)ugEquity.get_Selected().get_Rows(), (DragDropEffects)2);
	}

	private void ugEquity_DragOver(object sender, DragEventArgs e)
	{
		e.set_Effect((DragDropEffects)2);
		UltraGrid val = (UltraGrid)((sender is UltraGrid) ? sender : null);
		Point point = new Point(e.get_X(), e.get_Y());
		Point point2 = ((Control)val).PointToClient(point);
		if (point2.Y < 20)
		{
			((UltraGridBase)ugEquity).get_ActiveRowScrollRegion().Scroll((RowScrollAction)0);
		}
		else if (point2.Y > checked(((Control)val).get_Height() - 20))
		{
			((UltraGridBase)ugEquity).get_ActiveRowScrollRegion().Scroll((RowScrollAction)1);
		}
	}

	private void ugEquity_DragDrop(object sender, DragEventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		UltraGridUIElement uIElement = ((UltraGridBase)ugEquity).get_DisplayLayout().get_UIElement();
		UltraGrid obj = ugEquity;
		Point point = new Point(e.get_X(), e.get_Y());
		UIElement val = ((UIElement)uIElement).ElementFromPoint(((Control)obj).PointToClient(point));
		object context = val.GetContext(typeof(UltraGridRow), true);
		UltraGridRow val2 = (UltraGridRow)((context is UltraGridRow) ? context : null);
		if (val2 != null)
		{
			int index = val2.get_Index();
			SelectedRowsCollection val3 = (SelectedRowsCollection)e.get_Data().GetData(typeof(SelectedRowsCollection));
			RowEnumerator enumerator = val3.GetEnumerator();
			while (enumerator.MoveNext())
			{
				UltraGridRow current = enumerator.get_Current();
				((UltraGridBase)ugEquity).get_Rows().Move(current, index);
			}
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
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
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
			case "FILEOPEN":
				Click_Open();
				break;
			case "RESETTODEFAULT":
				Reset_To_Default();
				break;
			case "NOTE":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					frmNote frmNote2 = MyProject.Forms.frmNote;
					frmNote2.ExchangeSymbol = RuntimeHelpers.GetObjectValue(((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Exchange Symbol")
						.get_Value());
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
				frmOptionsData3.ExchangeSymbol = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Exchange Symbol")
					.get_Value(), (object)"S&P CNX NIFTY", false), (object)"NIFTY", RuntimeHelpers.GetObjectValue(((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Exchange Symbol")
					.get_Value())));
				((Form)frmOptionsData3).ShowDialog();
				frmOptionsData3 = null;
				break;
			}
			case "SHOWSTORY":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					ShowStory();
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
			case "FOREIGNINDICES":
				AutoInitialize("", "500", "", "", "104", "NAME", "", "", "N", "C", Conversions.ToInteger("0"), Conversions.ToInteger("0"));
				break;
			case "GAINERS":
				AutoInitialize("98", "50", "EQ", "", "NSE", "GAINERS", "", "", "N", "C", Conversions.ToInteger("0"), Conversions.ToInteger("0"));
				break;
			case "LOSERS":
				AutoInitialize("98", "50", "EQ", "", "NSE", "LOSERS", "", "", "N", "C", Conversions.ToInteger("0"), Conversions.ToInteger("0"));
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
			case "ADDSEPERATOR":
				if (IsActiveRow(((ToolEventArgs)e).get_Tool().get_Key()))
				{
					AddSeperator();
				}
				break;
			case "REMOVESORTING":
				((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
					.ResetSortedColumns();
				break;
			case "HELPSHORTCUTS":
			{
				frmHelp frmHelp2 = new frmHelp();
				((Control)frmHelp2).Show();
				break;
			}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			mdlMain.ShowMessage(ex2.Message + " TOOL CLICK");
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
			objEquity = new clsEquity();
			objEquity.UpdateSettingsToDB();
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
	}

	private void Timer2_ReSort_Tick(object sender, EventArgs e)
	{
		Timer2_ReSort.set_Enabled(false);
	}

	private void ugEquity_BeforeColumnChooserDisplayed(object sender, BeforeColumnChooserDisplayedEventArgs e)
	{
		e.get_Dialog().get_ColumnChooserControl().set_ColumnDisplayOrder((ColumnDisplayOrder)1);
	}

	public void BindGridData(bool IsNewList = false, bool IsFormLoad = false)
	{
		Money_Splash money_Splash = new Money_Splash();
		checked
		{
			try
			{
				((Control)money_Splash).Show();
				((Control)money_Splash).Refresh();
				ExchangeSymbol = "";
				objEquity = new clsEquity();
				objEquity.GetSettingsFromDB(Tab_Index);
				strSQL = "SELECT BridgeSymbol AS [Bridge Symbol], ExchangeSymbol AS [Exchange Symbol], ShortName AS [Scrip Name],  ISNULL(lastprice,0) AS [Last Price], convert(decimal(10,2),0) AS [Change], 0.00 AS [% Change],  0.00 AS [Week % Change], 0.00 AS [Month % Change], 0.00 AS [Year % Change], Volume,  [Close] AS [Close Price], ISNULL([OPEN],0)  as [Open], ISNULL(High,0) AS High, ISNULL(Low,0) AS Low, isnull(WeekHigh52,0) AS WeekHigh52, isnull(WeekLow52,0) AS WeekLow52 , isnull(LifeTimeHigh,0) AS [LifeTime High],  isnull(LifeTimeLow,0) AS [LifeTime Low], ShareOutStanding AS [Share OutStanding] , 0.00 AS [Turn Over], 0.00 AS [Market Cap],  0 AS [Series %], ISNULL(Upper_Circuit,0) AS [Upper Circuit], ISNULL(Lower_Circuit,0) AS [Lower Circuit], ISNULL(Day_10_Average,0) AS [10 Day Avg] , Series,  0.00 AS [Day High], 0.00 AS [Day Low], Market_Type AS [Market Type], ISNULL(WeekClose,0.00) AS [Week Close],   ISNULL(MonthClose,0.00) AS [Month Close], ISNULL(YearClose,0.00) AS [Year Close],  ISNULL(NewsExch,0) AS IssueCapital FROM Equity_transaction_data WHERE Market_Type = 'N' and SERIES IN ('EQ', 'BE', 'INX')  AND [Close]<>0 and [Close]is not NULL  AND BridgeSymbol IN (SELECT BRIDGESYMBOL FROM vw_CNBCMONEY_DETAILS WHERE TABINDEX = " + Conversions.ToString(Tab_Index) + " AND  USERNAME = '" + mdlMain.gUserName + "')";
				string text = "SELECT ISNULL(STRSQL,'') AS STRSQL FROM CNBCMONEY_USERS_MST WHERE USERNAME = '" + mdlMain.gUserName + "' AND  TABINDEX = " + Conversions.ToString(Tab_Index);
				dt = new DataTable();
				dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, text).Tables[0];
				if (dt.Rows.Count > 0 && Operators.ConditionalCompareObjectNotEqual(dt.Rows[0]["STRSQL"], (object)"", false))
				{
					strSQL = Strings.Replace(Conversions.ToString(dt.Rows[0]["STRSQL"]), "''", "'", 1, -1, (CompareMethod)0);
				}
				dtEquity = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				if (IsNewList)
				{
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
				}
				((UltraGridBase)ugEquity).set_DataSource((object)dtEquity);
				if (((UltraGridBase)ugEquity).get_Rows().get_Count() == 0)
				{
					((UltraGridBase)ugEquity).get_Rows().get_TemplateAddRow().get_Cells()
						.get_Item(0)
						.Activate();
				}
				GetExchangeSymbol();
				Loop_InitializeRow();
				if (Operators.CompareString(strSortColumn, "", false) != 0)
				{
					((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
						.get_Columns()
						.get_Item(strSortColumn)
						.set_SortIndicator((SortIndicator)Conversions.ToInteger(Interaction.IIf(strSort, (object)(SortIndicator)2, (object)(SortIndicator)1)));
				}
				((Form)money_Splash).Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				((Form)money_Splash).Close();
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
				strSQL = "SELECT BridgeSymbol AS [Bridge Symbol], ExchangeSymbol AS [Exchange Symbol], ShortName AS [Scrip Name],  ISNULL(lastprice,0) AS [Last Price], convert(decimal(10,2),0) AS [Change], 0.00 AS [% Change],  0.00 AS [Week % Change], 0.00 AS [Month % Change], 0.00 AS [Year % Change], Volume,  [Close] AS [Close Price], ISNULL([OPEN],0)  as [Open], ISNULL(High,0) AS High, ISNULL(Low,0) AS Low, isnull(WeekHigh52,0) AS WeekHigh52, isnull(WeekLow52,0) AS WeekLow52 , isnull(LifeTimeHigh,0) AS [LifeTime High],  isnull(LifeTimeLow,0) AS [LifeTime Low], ShareOutStanding AS [Share OutStanding] ,  0 AS [Turn Over], 0 AS [Market Cap],  0 AS [Series %], ISNULL(Upper_Circuit,0) AS [Upper Circuit], ISNULL(Lower_Circuit,0) AS [Lower Circuit], Day_10_Average AS [10 Day Avg] , Series,  0.00 AS [Day High], 0.00 AS [Day Low], Market_Type AS [Market Type], ISNULL(WeekClose,0.00) AS [Week Close],   ISNULL(MonthClose,0.00) AS [Month Close], ISNULL(YearClose,0.00) AS [Year Close],  ISNULL(NewsExch,0) AS IssueCapital FROM Equity_transaction_data WHERE Market_Type = 'N' and SERIES IN ('EQ', 'BE', 'INX')  AND [Close]<>0 and [Close] is not NULL ";
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
				((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
					.ResetSortedColumns();
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
				string text = "UPDATE CNBCMONEY_USERS_MST SET STRSQL = '' WHERE USERNAME = '" + mdlMain.gUserName + "' AND  TABINDEX = " + Conversions.ToString(Tab_Index);
				SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, text);
				if (((UltraGridBase)ugEquity).get_Rows().get_Count() != 1)
				{
				}
				if (isAddnew)
				{
					InitializeRow(((UltraGridBase)ugEquity).get_Rows().get_Item(dtEquity.Rows.Count - 1));
				}
				else
				{
					InitializeRow(((UltraGridBase)ugEquity).get_Rows().get_Item(((UltraGridBase)ugEquity).get_Rows().get_Count() - 1));
				}
				((UltraGridBase)ugEquity).UpdateData();
				((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
					.get_SortedColumns()
					.RefreshSort(false);
				GetExchangeSymbol();
				SendToBroadCastEvent?.Invoke();
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
			SendToBroadCastEvent?.Invoke();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void AutoInitialize(string SECTORID, string TOPP, string Series, string filename, string exchange_id, string sortby, string Tvolume, string last_price, string Market_type, string ChangeOver, int MKTcapg, int MKTcapl)
	{
		Money_Splash money_Splash = new Money_Splash();
		checked
		{
			try
			{
				((Control)money_Splash).Show();
				((Control)money_Splash).Refresh();
				strSQL = "Select top " + TOPP + " BRIDGESYMBOL AS [Bridge Symbol], c.Exchangesymbol as [Exchange Symbol],  shortname as [Scrip Name],LastPrice AS [Last Price], 0.0 as Change, 0.00 as [% Change],  0.00 AS [Week % Change], 0.00 AS [Month % Change], 0.00 AS [Year % Change], isnull(Volume,0) as Volume,  [CLOSE] as [Close Price], ISNULL([OPEN],0)  AS [Open],ISNULL(HIGH,0)  as High, ISNULL(LOW,0)  as Low,  ISNULL(WEEKHIGH52,0) as WeekHigh52,ISNULL(WEEKLOW52,0) as WeekLow52, ISNULL(LIFETIMEHIGH,0) as [LifeTime High],  ISNULL(LIFETIMELOW,0) as [LifeTime Low], ISNULL(SHAREOUTSTANDING,0) as [Share Outstanding],   0 as [Turn Over], 0 AS [Market Cap], 0 as [Series %] ,ISNULL(UPPER_CIRCUIT,0) as [Upper Circuit],ISNULL(LOWER_CIRCUIT,0) as [Lower Circuit], ISNULL(DAY_10_AVERAGE,0) as [10 Day Avg], c.Series  as Series, 0.00 as [Day High], 0.00 AS [Day Low], 'N' AS [Market Type], ISNULL(WeekClose,0.0) AS [Week Close],   ISNULL(MonthClose,0.0) AS [Month Close], ISNULL(YearClose,0.0) AS [Year Close],  ISNULL(NewsExch,0) AS IssueCapital from EQUITY_TRANSACTION_DATA C  WHERE Bridgesymbol IS NOT NULL  AND BridgeSymbol <> '' AND shortname IS NOT NULL  AND shortname <> '' ";
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
				if (Operators.CompareString(Series, "INX", false) != 0)
				{
					switch (exchange_id)
					{
					case "104":
						strSQL += "  and ExchangeID='104' ";
						break;
					case "NSE":
						strSQL += "  and ExchangeID='1732257' ";
						break;
					default:
						strSQL += "  and ExchangeID='1732256' ";
						break;
					case "BOTH":
						break;
					}
				}
				else if (Operators.CompareString(exchange_id, "BOTH", false) != 0)
				{
					if (Operators.CompareString(exchange_id, "NSE", false) == 0)
					{
						strSQL += "  and ExchangeID='1732257' ";
					}
					else
					{
						strSQL += "  and ExchangeID='1732256' ";
					}
				}
				else
				{
					strSQL += "  and ExchangeID IN ('1732256','1732257') ";
				}
				if (Operators.CompareString(Strings.UCase(Strings.Trim(Series)), "EQ", false) == 0)
				{
					strSQL += " and C.Series in ('EQ','BE') ";
				}
				else if (Operators.CompareString(Strings.UCase(Strings.Trim(Series)), "", false) != 0)
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
				if ((Operators.CompareString(Series, "INX", false) != 0) & (Operators.CompareString(Series, "", false) != 0) & (Operators.CompareString(SECTORID, "98", false) != 0))
				{
					strSQL = strSQL + " and Sector LIKE '%," + Strings.Trim(SECTORID) + ",%' ";
				}
				strSQL += " and [Close]<>0 and [Close] is not NULL ";
				string text = "";
				if (Operators.CompareString(SECTORID, "98", false) == 0)
				{
					if (Operators.CompareString(Strings.UCase(sortby), "GAINERS", false) == 0)
					{
						text = "% Change";
						strSQL += " ORDER BY (([LASTPRICE]-[CLOSE])/[CLOSE])*100 DESC";
					}
					else if (Operators.CompareString(Strings.UCase(sortby), "LOSERS", false) == 0)
					{
						text = "% Change";
						strSQL += " ORDER BY (([LASTPRICE]-[CLOSE])/[CLOSE])*100 ";
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
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "GAINERS", false) == 0)
				{
					text = "% Change";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "LOSERS", false) == 0)
				{
					text = "% Change";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "VOLUME", false) == 0)
				{
					text = "VOLUME";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "NAME", false) == 0)
				{
					text = "Scrip Name";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "LifeTime High", false) == 0)
				{
					text = "VOLUME";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "LifeTime Low", false) == 0)
				{
					text = "VOLUME";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "WEEKLOW52", false) == 0)
				{
					text = "VOLUME";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "WEEKHIGH52", false) == 0)
				{
					text = "VOLUME";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "UPPER_CIRCUIT", false) == 0)
				{
					text = "VOLUME";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "LOWER_CIRCUIT", false) == 0)
				{
					text = "VOLUME";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "TURNOVER", false) == 0)
				{
					text = "TURN OVER";
				}
				else if (Operators.CompareString(Strings.UCase(sortby), "", false) == 0)
				{
					text = "Volume";
				}
				dtEquity = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				((UltraGridBase)ugEquity).set_DataSource((object)dtEquity);
				((UltraGridBase)ugEquity).DataBind();
				if ((Operators.CompareString(Strings.UCase(sortby), "NAME", false) == 0) | (Operators.CompareString(Strings.UCase(sortby), "LOSERS", false) == 0))
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
						.get_Columns()
						.get_Item(text)
						.set_SortIndicator((SortIndicator)Conversions.ToInteger(Interaction.IIf(strSort, (object)(SortIndicator)2, (object)(SortIndicator)1)));
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
				Loop_InitializeRow();
				GetExchangeSymbol();
				objEquity = new clsEquity();
				objEquity.Update_ConnectedUsers(Tab_Index);
				((Form)money_Splash).Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				((Form)money_Splash).Close();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ManualAdd(int rowID)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = default(string);
			string text2 = default(string);
			if (((DisposableObjectCollectionBase)((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
				.get_SortedColumns()).get_Count() > 0)
			{
				text = ((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
					.get_SortedColumns()
					.get_Item(0)
					.ToString();
				text2 = ((Enum)((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
					.get_SortedColumns()
					.get_Item(0)
					.get_SortIndicator()).ToString();
			}
			if (AddNewStock(Conversions.ToString(((UltraGridBase)ugEquity).get_Rows().get_Item(rowID).get_Cells()
				.get_Item(0)
				.get_Value()), rowID))
			{
				objEquity = new clsEquity();
				objEquity.AddLookUp(Conversions.ToString(((UltraGridBase)ugEquity).get_Rows().get_Item(rowID).get_Cells()
					.get_Item("Bridge Symbol")
					.get_Value()), Conversions.ToString(((UltraGridBase)ugEquity).get_Rows().get_Item(rowID).get_Cells()
					.get_Item("Exchange Symbol")
					.get_Value()), ((Form)this).get_Text(), Tab_Index, "", OldBridgeSymbol);
				objEquity = null;
			}
			if (((DisposableObjectCollectionBase)((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
				.get_SortedColumns()).get_Count() > 0)
			{
				((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
					.get_SortedColumns()
					.get_Item(text)
					.set_SortIndicator((SortIndicator)Conversions.ToInteger(text2));
			}
			((UltraGridBase)ugEquity).UpdateData();
			GetExchangeSymbol();
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
					{
						UltraGridRow val2 = ((UltraGridBase)ugEquity).get_Rows().get_Item(i);
						if (Operators.ConditionalCompareObjectGreater(val2.get_Cells().get_Item("Change").get_Value(), (object)0, false))
						{
							val2.get_Appearance().set_ForeColor(strcolor);
						}
						if (Operators.ConditionalCompareObjectGreater(val2.get_Cells().get_Item("% Change").get_Value(), (object)0, false))
						{
							val2.get_Cells().get_Item("% Change").get_Appearance()
								.set_ForeColor(strcolor);
						}
						if (Operators.ConditionalCompareObjectGreater(val2.get_Cells().get_Item("Week % Change").get_Value(), (object)0, false))
						{
							val2.get_Cells().get_Item("Week % Change").get_Appearance()
								.set_ForeColor(strcolor);
						}
						if (Operators.ConditionalCompareObjectGreater(val2.get_Cells().get_Item("Month % Change").get_Value(), (object)0, false))
						{
							val2.get_Cells().get_Item("Month % Change").get_Appearance()
								.set_ForeColor(strcolor);
						}
						if (Operators.ConditionalCompareObjectGreater(val2.get_Cells().get_Item("Year % Change").get_Value(), (object)0, false))
						{
							val2.get_Cells().get_Item("Year % Change").get_Appearance()
								.set_ForeColor(strcolor);
						}
						val2 = null;
						((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_G_ZERO", (object)strcolor);
						break;
					}
					case "E":
					{
						UltraGridRow val3 = ((UltraGridBase)ugEquity).get_Rows().get_Item(i);
						if (Operators.ConditionalCompareObjectEqual(val3.get_Cells().get_Item("Change").get_Value(), (object)0, false))
						{
							val3.get_Appearance().set_ForeColor(strcolor);
						}
						if (Operators.ConditionalCompareObjectEqual(val3.get_Cells().get_Item("% Change").get_Value(), (object)0, false))
						{
							val3.get_Cells().get_Item("% Change").get_Appearance()
								.set_ForeColor(strcolor);
						}
						if (Operators.ConditionalCompareObjectEqual(val3.get_Cells().get_Item("Week % Change").get_Value(), (object)0, false))
						{
							val3.get_Cells().get_Item("Week % Change").get_Appearance()
								.set_ForeColor(strcolor);
						}
						if (Operators.ConditionalCompareObjectEqual(val3.get_Cells().get_Item("Month % Change").get_Value(), (object)0, false))
						{
							val3.get_Cells().get_Item("Month % Change").get_Appearance()
								.set_ForeColor(strcolor);
						}
						if (Operators.ConditionalCompareObjectEqual(val3.get_Cells().get_Item("Year % Change").get_Value(), (object)0, false))
						{
							val3.get_Cells().get_Item("Year % Change").get_Appearance()
								.set_ForeColor(strcolor);
						}
						val3 = null;
						((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_E_ZERO", (object)strcolor);
						break;
					}
					case "L":
					{
						UltraGridRow val = ((UltraGridBase)ugEquity).get_Rows().get_Item(i);
						if (Operators.ConditionalCompareObjectLess(val.get_Cells().get_Item("Change").get_Value(), (object)0, false))
						{
							val.get_Appearance().set_ForeColor(strcolor);
						}
						if (Operators.ConditionalCompareObjectLess(val.get_Cells().get_Item("% Change").get_Value(), (object)0, false))
						{
							val.get_Cells().get_Item("% Change").get_Appearance()
								.set_ForeColor(strcolor);
						}
						if (Operators.ConditionalCompareObjectLess(val.get_Cells().get_Item("Week % Change").get_Value(), (object)0, false))
						{
							val.get_Cells().get_Item("Week % Change").get_Appearance()
								.set_ForeColor(strcolor);
						}
						if (Operators.ConditionalCompareObjectLess(val.get_Cells().get_Item("Month % Change").get_Value(), (object)0, false))
						{
							val.get_Cells().get_Item("Month % Change").get_Appearance()
								.set_ForeColor(strcolor);
						}
						if (Operators.ConditionalCompareObjectLess(val.get_Cells().get_Item("Year % Change").get_Value(), (object)0, false))
						{
							val.get_Cells().get_Item("Year % Change").get_Appearance()
								.set_ForeColor(strcolor);
						}
						val = null;
						((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_L_ZERO", (object)strcolor);
						break;
					}
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
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		StreamWriter streamWriter = null;
		string text = "";
		try
		{
			SaveFileDialog saveFile = SaveFile;
			((FileDialog)saveFile).set_FileName(((Form)this).get_Text());
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
				mdlMain.ShowMessage("Data Saved to :" + ((FileDialog)saveFile).get_FileName());
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
				BindGridData(IsNewList: true);
				((UltraGridBase)ugEquity).UpdateData();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Click_Open()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		try
		{
			OpenFileDialog openMyFile = OpenMyFile;
			if ((int)((CommonDialog)openMyFile).ShowDialog() == 1)
			{
				new StreamReader(openMyFile.OpenFile());
				StreamReader streamReader = new StreamReader(((FileDialog)openMyFile).get_FileName());
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
				BindGridData(IsNewList: true);
				Rename_Tab_Name(((Form)this).get_Text(), Strings.Split(((FileDialog)openMyFile).get_FileName(), ".", -1, (CompareMethod)0)[0]);
			}
			openMyFile = null;
			BindGridData(IsNewList: true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			mdlMain.ShowMessage(ex2.Message, "File_Open");
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
				objEquity = new clsEquity();
				objEquity.UpdateSettingsToDB();
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
		try
		{
			aa = Strings.Replace(aa, "AAA", "", 1, -1, (CompareMethod)0);
			if (Strings.InStr(1, Strings.Trim(aa), "|", (CompareMethod)0) > 0)
			{
				Array array = Strings.Split(aa, "|", -1, (CompareMethod)0);
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CN", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"CX", false))))
				{
					Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
				}
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1907", false), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"1906", false))))
				{
					Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null));
				}
				RowEnumerator enumerator = ((UltraGridBase)ugEquity).get_Rows().GetEnumerator();
				while (enumerator.MoveNext())
				{
					UltraGridRow current = enumerator.get_Current();
					if (current.get_IsAddRow())
					{
						break;
					}
					if ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null)), "CALC", (CompareMethod)0) > 0) & (Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), "NEWS", (CompareMethod)0) > 0))
					{
						Type typeFromHandle = typeof(Strings);
						object[] array2 = new object[1];
						object[] array3 = array2;
						UltraGridCell val = current.get_Cells().get_Item("Bridge Symbol");
						array3[0] = RuntimeHelpers.GetObjectValue(val.get_Value());
						object[] array4 = array2;
						object[] array5 = array4;
						bool[] array6 = new bool[1] { true };
						object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array5, (string[])null, (Type[])null, array6);
						if (array6[0])
						{
							val.set_Value(RuntimeHelpers.GetObjectValue(array4[0]));
						}
						Type typeFromHandle2 = typeof(Strings);
						object[] array7 = new object[1];
						object[] array8 = array7;
						object[] array9 = new object[1];
						object[] array10 = array9;
						int num = 2;
						array10[0] = 2;
						array8[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, array9, (string[])null));
						object[] array11 = array7;
						object[] array12 = array11;
						bool[] array13 = new bool[1] { true };
						object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array12, (string[])null, (Type[])null, array13);
						if (array13[0])
						{
							NewLateBinding.LateIndexSetComplex((object)array, new object[2]
							{
								num,
								RuntimeHelpers.GetObjectValue(array11[0])
							}, (string[])null, true, false);
						}
						if (Operators.ConditionalCompareObjectEqual(obj, obj2, false))
						{
							strIssueCapital = Conversions.ToString(current.get_Cells().get_Item("Exchange Symbol").get_Value());
							current.get_Cells().get_Item("IssueCapital").set_Value((object)strIssueCapital);
							return;
						}
						Type typeFromHandle3 = typeof(Strings);
						object[] array14 = new object[1];
						object[] array15 = array14;
						val = current.get_Cells().get_Item("Bridge Symbol");
						array15[0] = RuntimeHelpers.GetObjectValue(val.get_Value());
						array11 = array14;
						object[] array16 = array11;
						array13 = new bool[1] { true };
						object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "UCase", array16, (string[])null, (Type[])null, array13);
						if (array13[0])
						{
							val.set_Value(RuntimeHelpers.GetObjectValue(array11[0]));
						}
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(obj3, NewLateBinding.LateGet((object)null, typeof(Strings), "UCase", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)"N") }, (string[])null, (Type[])null, (bool[])null), false), (object)(strIssueCapital != null))))
						{
							current.get_Cells().get_Item("IssueCapital").set_Value((object)strIssueCapital);
							return;
						}
					}
					if (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Exchange Symbol").get_Value()))), Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)))), false) == 0)
					{
						if ((Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null)), "CN", (CompareMethod)0) > 0) & (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Series").get_Value()))), Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)))), false) == 0))
						{
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(current.get_Cells().get_Item("Last Price").get_Value(), (object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 8 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false), (object)(Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 9 }, (string[])null)))) != 0.0))) && Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Volume").get_Value()))) < Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 9 }, (string[])null)))))
							{
								try
								{
									current.get_Cells().get_Item("Last Price").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 8 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								}
								catch (Exception projectError)
								{
									ProjectData.SetProjectError(projectError);
									Debug.WriteLine("HERE2" + Information.Err().get_Description());
									ProjectData.ClearProjectError();
								}
								current.get_Cells().get_Item("Change").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Operators.SubtractObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 8 }, (string[])null), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("% Change").set_Value((object)Strings.FormatNumber(Operators.MultiplyObject(Operators.DivideObject(current.get_Cells().get_Item("Change").get_Value(), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))), (object)100), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("Open").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 11 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("High").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 12 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("Low").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 13 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("Turn Over").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Volume").get_Value()), (object)100000), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
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
								if (Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 8 }, (string[])null)) > 0.0)
								{
									current.get_Cells().get_Item("Day High").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)((Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 12 }, (string[])null)) - Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 8 }, (string[])null))) / Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 8 }, (string[])null)) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2))));
								}
								else
								{
									current.get_Cells().get_Item("Day High").set_Value((object)0);
								}
								if (Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 13 }, (string[])null)) > 0.0)
								{
									current.get_Cells().get_Item("Day Low").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)((Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 8 }, (string[])null)) - Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 13 }, (string[])null))) / Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 13 }, (string[])null)) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2))));
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
							if ((Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Volume").get_Value()))) < Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 9 }, (string[])null))))) & (Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 9 }, (string[])null)))) != 0.0))
							{
								current.get_Cells().get_Item("Volume").set_Value((object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 9 }, (string[])null)))));
								current.get_Cells().get_Item("Turn Over").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Volume").get_Value()), (object)100000), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
							}
							InitializeRow(current);
							break;
						}
						if (Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null)), "CX", (CompareMethod)0) > 0)
						{
							if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Last Price").get_Value(), (object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false))
							{
								current.get_Cells().get_Item("Last Price").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("WEEKHIGH52").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 7 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("WEEKLOW52").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 8 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("Change").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Operators.SubtractObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("% Change").set_Value((object)Strings.FormatNumber(Operators.MultiplyObject(Operators.DivideObject(current.get_Cells().get_Item("Change").get_Value(), (object)Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))), (object)100), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("Open").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("High").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 5 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("Low").set_Value((object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 6 }, (string[])null)))), 2, (TriState)(-1), (TriState)(-2), (TriState)0));
								current.get_Cells().get_Item("Market Cap").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Share Outstanding").get_Value()), (object)10000000), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
								if (Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)) > 0.0)
								{
									current.get_Cells().get_Item("Day High").set_Value((object)Strings.FormatNumber((object)((Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 5 }, (string[])null)) - Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null))) / Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
								}
								else
								{
									current.get_Cells().get_Item("Day High").set_Value((object)"0.00");
								}
								if (Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 6 }, (string[])null)) > 0.0)
								{
									current.get_Cells().get_Item("Day Low").set_Value((object)Strings.FormatNumber((object)((Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)) - Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 6 }, (string[])null))) / Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 6 }, (string[])null)) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
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
							InitializeRow(current);
							break;
						}
					}
					if (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Exchange Symbol").get_Value()))), Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)))), false) != 0)
					{
						Application.DoEvents();
						continue;
					}
					if (Strings.InStr(1, Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null)), "1907", (CompareMethod)0) > 0)
					{
						if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Last Price").get_Value(), (object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false))
						{
							current.get_Cells().get_Item("Last Price").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
							current.get_Cells().get_Item("Change").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)(Conversions.ToDouble(Strings.Trim(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)))) / 100.0 - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value())))), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
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
						InitializeRow(current);
					}
					else
					{
						if (Operators.ConditionalCompareObjectNotEqual(current.get_Cells().get_Item("Last Price").get_Value(), (object)Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 11 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0), false))
						{
							current.get_Cells().get_Item("Last Price").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 11 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
							current.get_Cells().get_Item("Change").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)(Conversions.ToDouble(Operators.DivideObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 11 }, (string[])null), (object)100)) - Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value())))), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
							current.get_Cells().get_Item("% Change").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)(Conversions.ToDouble(Operators.DivideObject(current.get_Cells().get_Item("Change").get_Value(), (object)Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Close Price").get_Value()))))) * 100.0), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
							current.get_Cells().get_Item("Open").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
							current.get_Cells().get_Item("High").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 5 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
							current.get_Cells().get_Item("Low").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 6 }, (string[])null)) / 100.0)), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
							current.get_Cells().get_Item("Market Cap").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Share Outstanding").get_Value()), (object)10000000), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
							current.get_Cells().get_Item("Turn Over").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Volume").get_Value()), (object)100000), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
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
						if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(current.get_Cells().get_Item("Volume").get_Value()))) < Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 8 }, (string[])null))))))
						{
							current.get_Cells().get_Item("Volume").set_Value((object)Strings.Trim(Conversions.ToString(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)array, new object[1] { 8 }, (string[])null)))));
							current.get_Cells().get_Item("Turn Over").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(current.get_Cells().get_Item("Last Price").get_Value(), current.get_Cells().get_Item("Volume").get_Value()), (object)100000), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
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
					}
					InitializeRow(current);
					break;
				}
			}
			Application.DoEvents();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
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

	private int Grid_RowIndex(string strExchangeSymbol)
	{
		int result = default(int);
		try
		{
			DataColumn dataColumn = dtEquity.Columns[1];
			DataColumn[] primaryKey = new DataColumn[1] { dataColumn };
			dtEquity.PrimaryKey = primaryKey;
			result = dtEquity.Rows.IndexOf(dtEquity.Rows.Find(strExchangeSymbol));
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
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

	private void AddSeperator()
	{
		checked
		{
			try
			{
				if (((UltraGridBase)ugEquity).get_ActiveRow().get_Index() > ((UltraGridBase)ugEquity).get_Rows().get_FixedRows().get_Count())
				{
					int count = ((UltraGridBase)ugEquity).get_Rows().get_FixedRows().get_Count();
					int index = ((UltraGridBase)ugEquity).get_ActiveRow().get_Index();
					i = count;
					while (true)
					{
						int num = i;
						int num2 = index;
						if (num <= num2)
						{
							((UltraGridBase)ugEquity).get_Rows().get_FixedRows().Add(((UltraGridBase)ugEquity).get_Rows().get_Item(i));
							i++;
							continue;
						}
						break;
					}
					return;
				}
				int count2 = ((UltraGridBase)ugEquity).get_Rows().get_FixedRows().get_Count();
				int index2 = ((UltraGridBase)ugEquity).get_ActiveRow().get_Index();
				i = count2;
				while (true)
				{
					int num3 = i;
					int num2 = index2;
					if (num3 < num2)
					{
						break;
					}
					((UltraGridBase)ugEquity).get_Rows().get_FixedRows().Remove(((UltraGridBase)ugEquity).get_Rows().get_Item(i));
					i += -1;
				}
				((UltraControlBase)ugEquity).Update();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void GetExchangeSymbol()
	{
		checked
		{
			try
			{
				ExchangeSymbol = "";
				int num = ((UltraGridBase)ugEquity).get_Rows().get_Count() - 1;
				i = 0;
				while (true)
				{
					int num2 = i;
					int num3 = num;
					if (num2 <= num3)
					{
						ExchangeSymbol = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)ExchangeSymbol, ((UltraGridBase)ugEquity).get_Rows().get_Item(i).get_Cells()
							.get_Item("Exchange Symbol")
							.get_Value()), (object)","));
						i++;
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

	private void Loop_InitializeRow()
	{
		checked
		{
			try
			{
				int num = ((UltraGridBase)ugEquity).get_Rows().get_Count() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						InitializeRow(((UltraGridBase)ugEquity).get_Rows().get_Item(num2));
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

	private void InitializeRow(UltraGridRow dRow)
	{
		try
		{
			if (!dRow.get_IsAddRow())
			{
				UltraGridRow val = dRow;
				if (val.get_Cells().get_Item("Last Price").get_Value() == DBNull.Value)
				{
					val.get_Cells().get_Item("Last Price").set_Value((object)0);
				}
				if (val.get_Cells().get_Item("Close Price").get_Value() == DBNull.Value)
				{
					val.get_Cells().get_Item("Close Price").set_Value((object)0);
				}
				if (val.get_Cells().get_Item("Week Close").get_Value() == DBNull.Value)
				{
					val.get_Cells().get_Item("Week Close").set_Value((object)0);
				}
				if (val.get_Cells().get_Item("Month Close").get_Value() == DBNull.Value)
				{
					val.get_Cells().get_Item("Month Close").set_Value((object)0);
				}
				if (val.get_Cells().get_Item("Year Close").get_Value() == DBNull.Value)
				{
					val.get_Cells().get_Item("Year Close").set_Value((object)0);
				}
				if (val.get_Cells().get_Item("IssueCapital").get_Value() == DBNull.Value)
				{
					val.get_Cells().get_Item("IssueCapital").set_Value((object)"0");
				}
				if (val.get_Cells().get_Item("High").get_Value() == DBNull.Value)
				{
					val.get_Cells().get_Item("High").set_Value((object)0);
				}
				if (val.get_Cells().get_Item("Low").get_Value() == DBNull.Value)
				{
					val.get_Cells().get_Item("Low").set_Value((object)0);
				}
				double num = Conversions.ToDouble(val.get_Cells().get_Item("Last Price").get_Value()) - Conversions.ToDouble(val.get_Cells().get_Item("Close Price").get_Value());
				val.get_Cells().get_Item("Change").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)num, 2, (TriState)(-1), (TriState)0, (TriState)0)));
				val.get_Cells().get_Item("% Change").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(val.get_Cells().get_Item("Close Price").get_Value(), (object)0, false), (object)0, (object)(num / Conversions.ToDouble(val.get_Cells().get_Item("Close Price").get_Value()) * 100.0))), 2, (TriState)(-1), (TriState)0, (TriState)0)));
				val.get_Cells().get_Item("Week % Change").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(val.get_Cells().get_Item("Week Close").get_Value(), (object)0, false), (object)0, (object)((Conversions.ToDouble(val.get_Cells().get_Item("Last Price").get_Value()) - Conversions.ToDouble(val.get_Cells().get_Item("Week Close").get_Value())) / Conversions.ToDouble(val.get_Cells().get_Item("Week Close").get_Value()) * 100.0))), 2, (TriState)(-1), (TriState)0, (TriState)0)));
				val.get_Cells().get_Item("Month % Change").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(val.get_Cells().get_Item("Month Close").get_Value(), (object)0, false), (object)0, (object)((Conversions.ToDouble(val.get_Cells().get_Item("Last Price").get_Value()) - Conversions.ToDouble(val.get_Cells().get_Item("Month Close").get_Value())) / Conversions.ToDouble(val.get_Cells().get_Item("Month Close").get_Value()) * 100.0))), 2, (TriState)(-1), (TriState)0, (TriState)0)));
				val.get_Cells().get_Item("Year % Change").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(val.get_Cells().get_Item("Year Close").get_Value(), (object)0, false), (object)0, (object)((Conversions.ToDouble(val.get_Cells().get_Item("Last Price").get_Value()) - Conversions.ToDouble(val.get_Cells().get_Item("Year Close").get_Value())) / Conversions.ToDouble(val.get_Cells().get_Item("Year Close").get_Value()) * 100.0))), 2, (TriState)(-1), (TriState)0, (TriState)0)));
				double num2 = num;
				if (num2 == 0.0)
				{
					val.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
				}
				else if (num2 > 0.0)
				{
					val.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
				}
				else if (num2 < 0.0)
				{
					val.get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
				}
				object value = val.get_Cells().get_Item("% Change").get_Value();
				if (Operators.ConditionalCompareObjectEqual(value, (object)0, false))
				{
					val.get_Cells().get_Item("% Change").get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
				}
				else if (Operators.ConditionalCompareObjectGreater(value, (object)0, false))
				{
					val.get_Cells().get_Item("% Change").get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
				}
				else if (Operators.ConditionalCompareObjectLess(value, (object)0, false))
				{
					val.get_Cells().get_Item("% Change").get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
				}
				object value2 = val.get_Cells().get_Item("Week % Change").get_Value();
				if (Operators.ConditionalCompareObjectEqual(value2, (object)0, false))
				{
					val.get_Cells().get_Item("Week % Change").get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
				}
				else if (Operators.ConditionalCompareObjectGreater(value2, (object)0, false))
				{
					val.get_Cells().get_Item("Week % Change").get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
				}
				else if (Operators.ConditionalCompareObjectLess(value2, (object)0, false))
				{
					val.get_Cells().get_Item("Week % Change").get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
				}
				object value3 = val.get_Cells().get_Item("Month % Change").get_Value();
				if (Operators.ConditionalCompareObjectEqual(value3, (object)0, false))
				{
					val.get_Cells().get_Item("Month % Change").get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
				}
				else if (Operators.ConditionalCompareObjectGreater(value3, (object)0, false))
				{
					val.get_Cells().get_Item("Month % Change").get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
				}
				else if (Operators.ConditionalCompareObjectLess(value3, (object)0, false))
				{
					val.get_Cells().get_Item("Month % Change").get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
				}
				object value4 = val.get_Cells().get_Item("Year % Change").get_Value();
				if (Operators.ConditionalCompareObjectEqual(value4, (object)0, false))
				{
					val.get_Cells().get_Item("Year % Change").get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
				}
				else if (Operators.ConditionalCompareObjectGreater(value4, (object)0, false))
				{
					val.get_Cells().get_Item("Year % Change").get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
				}
				else if (Operators.ConditionalCompareObjectLess(value4, (object)0, false))
				{
					val.get_Cells().get_Item("Year % Change").get_Appearance()
						.set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
				}
				if (val.get_Cells().get_Item("Volume").get_Value() == DBNull.Value)
				{
					val.get_Cells().get_Item("Volume").set_Value((object)0);
				}
				val.get_Cells().get_Item("Turn Over").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)(Conversions.ToDouble(val.get_Cells().get_Item("Last Price").get_Value()) * Conversions.ToDouble(val.get_Cells().get_Item("Volume").get_Value()) / 100000.0), 2, (TriState)(-1), (TriState)0, (TriState)0)));
				if (Operators.ConditionalCompareObjectGreater(val.get_Cells().get_Item("Last Price").get_Value(), (object)0, false))
				{
					val.get_Cells().get_Item("Day High").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)((Conversions.ToDouble(val.get_Cells().get_Item("HIGH").get_Value()) - Conversions.ToDouble(val.get_Cells().get_Item("Last Price").get_Value())) / Conversions.ToDouble(val.get_Cells().get_Item("Last Price").get_Value()) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2))));
				}
				else
				{
					val.get_Cells().get_Item("Day High").set_Value((object)0.0);
				}
				if (Conversions.ToDouble(val.get_Cells().get_Item("Low").get_Value()) > Conversions.ToDouble("0"))
				{
					val.get_Cells().get_Item("Day Low").set_Value((object)Conversions.ToDouble(Strings.FormatNumber((object)((Conversions.ToDouble(val.get_Cells().get_Item("Last Price").get_Value()) - Conversions.ToDouble(val.get_Cells().get_Item("Low").get_Value())) / Conversions.ToDouble(val.get_Cells().get_Item("Low").get_Value()) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2))));
				}
				else
				{
					val.get_Cells().get_Item("Day Low").set_Value((object)0.0);
				}
				val.get_Cells().get_Item("Market Cap").set_Value((object)Conversions.ToDouble(Strings.FormatNumber(Operators.DivideObject(Operators.MultiplyObject(val.get_Cells().get_Item("Last Price").get_Value(), val.get_Cells().get_Item("Share Outstanding").get_Value()), (object)10000000), 2, (TriState)(-1), (TriState)(-2), (TriState)0)));
				if (Operators.ConditionalCompareObjectNotEqual(val.get_Cells().get_Item("IssueCapital").get_Value(), (object)"0", false))
				{
					val.get_RowSelectorAppearance().set_BackColor(Color.Orange);
					val.get_RowSelectorAppearance().set_BackColor2(Color.Black);
				}
				if (DateAndTime.DateDiff((DateInterval)9, datetime_LastSort, DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1) > 9L)
				{
					((UltraGridBase)ugEquity).get_DisplayLayout().get_Bands().get_Item(0)
						.get_SortedColumns()
						.RefreshSort(false);
					datetime_LastSort = DateAndTime.get_Now();
				}
				RowIndex = val.get_Index();
				val.Update();
				val.Refresh();
				val = null;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ShowStory()
	{
		try
		{
			string text = Conversions.ToString(((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Bridge Symbol")
				.get_Value());
			if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Exchange Symbol")
				.get_Value())))
			{
				text = Strings.Mid(text, 1, checked(text.Length - 1));
			}
			strSQL = "SELECT EXCHANGESYMBOL,* FROM equity_transaction_data WHERE BridgeSymbol = '" + text + "' AND market_type = 'N' AND Series IN ('EQ', 'BE', 'INX')";
			text = Conversions.ToString(SqlHelper.ExecuteScalar(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL));
			objEquity = new clsEquity();
			objEquity.ShowNewsHistory("", "", text, Conversions.ToString(((UltraGridBase)ugEquity).get_ActiveRow().get_Cells().get_Item("Scrip Name")
				.get_Value()));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
